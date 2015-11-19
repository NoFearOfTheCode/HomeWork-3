using System;

namespace Model
{
    public class Jay : Gambler
    {
        public Jay() : base("Jay"){}

        public override void FetchNewNumber(object sender, NewNumberEventArgs e)
        {
            if (e.CurentNumber.IsEven() == true)
            {
                Score++;
            }
        }
    }
}
