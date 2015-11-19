using System;

namespace Model
{
    public class Numbertron
    {
        public event EventHandler<NewNumberEventArgs> NewNumber;

        protected virtual void OnNewNumber(int newNumber)
        {
            NewNumber?.Invoke(this, new NewNumberEventArgs(newNumber));
        }

        public void Generate(Random random)
        {
            var randomNumber = random.Next(0, 1000);
            OnNewNumber(randomNumber);
        }
    }
}
