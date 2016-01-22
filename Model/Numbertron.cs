using System;

namespace Model
{
    public class Numbertron
    {
        private readonly Random _random = new Random();

        public event EventHandler<NewNumberEventArgs> NewNumber;

        protected virtual void OnNewNumber(int newNumber)
        {
            NewNumber?.Invoke(this, new NewNumberEventArgs(newNumber));
        }

        public void Generate()
        {
            var randomNumber = _random.Next(0, 1000);
            OnNewNumber(randomNumber);
        }
    }
}
