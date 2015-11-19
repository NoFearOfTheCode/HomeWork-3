using System.Runtime.InteropServices;

namespace Model
{
    public abstract class Gambler
    {
        protected Gambler(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public int Score { get; protected set; }
        public abstract void FetchNewNumber(object sender, NewNumberEventArgs e);
    }
}
