using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler_
{
    class Check
    {
        const int cash = 1;
        const int EarninDay = 100;
        public void check()
        {

            Console.WriteLine("Bet for every game:" + cash + "Earn in every day in Bet:" + EarninDay);

        }
        //UC2Gambler make 1 bet Winorloss
        const int win = 1;
        public void winorloss()
        {
            Random random = new Random();
            int Check = random.Next(0, 2);
            if (Check == win)
            {
                Console.WriteLine("Gambler win the bet");
            }
            else
            {
                Console.WriteLine("Gambler loss the bet");
            }
        }
    }

}
