using System;

namespace Gambler
{
    class Program
    {
        static void Main(string[] args)
        {
            int stake = 100;
            int bet = 1;
            int odds = 0;
            Program Gambler = new Program();
            
            if (stake == odds)
            {
                Console.WriteLine("Gambler Won ");
                stake++;
            }
            else
            {
                Console.WriteLine("Gambler Loose");
                stake--;
            }

            Console.WriteLine("game per stake {0} game per bet {1}", stake, bet);
        }
           
    }
}

