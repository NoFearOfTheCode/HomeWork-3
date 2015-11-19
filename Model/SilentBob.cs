using System;

namespace Model
{
    public class SilentBob : Gambler
    {
        public SilentBob() : base("Silent Bob"){}

        public override void FetchNewNumber(object sender, NewNumberEventArgs e)
        {
            if (e.CurentNumber.IsEven() == false)
            {
                Score++;
            }
        }
    }
}
