using System;

namespace Model
{
    public class NewNumberEventArgs : EventArgs
    {
        public NewNumberEventArgs(int curentNumber)
        {
            CurentNumber = curentNumber;
        }

        public int CurentNumber { get; }
    }
}
