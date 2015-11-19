﻿using System;
using Model;


namespace View
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var jay = new Jay();
            var silentBob = new SilentBob();
            var numbertron = new Numbertron();

            numbertron.NewNumber += jay.FetchNewNumber;
            numbertron.NewNumber += silentBob.FetchNewNumber;

            var n = 0;
            isCheck:
            try
            {
                Console.WriteLine("Сколько чисел сгенерировать?");
                while (true)
                {              
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n > 0)
                        break;
                    Console.WriteLine("Вы ввели число < либо = 0, Повторите попытку!");
                }
            }
            catch (FormatException exeption)
            {
                Console.WriteLine("{0} Повторите попытку!", exeption.Message);
                goto isCheck;
            }

            var random = new Random();
            for (var i = 0; i < n; i++)
            {        
                numbertron.Generate(random);    
            }

            if (jay.Score > silentBob.Score)
                Console.WriteLine("Jay is the winner!");
            
            else if (jay.Score == silentBob.Score)
                Console.WriteLine("DRAW!");
   
            else Console.WriteLine("SilentBob is the winner!");
            
            Console.ReadKey();
        }
    }
}
