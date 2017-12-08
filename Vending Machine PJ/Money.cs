using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_PJ
{
    public class Money
    {
        public static int kronorpool { get; set; }
        public static int price = 0;
        public static int[] kronor = new int[] { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };


        public static void Seperatemoney()
        {
            foreach (int val in kronor)
            {
                int antal = kronorpool / val;
                kronorpool -= antal * val; //-= short for pool = pool -
                if (antal > 0)
                {
                    Console.WriteLine("You get back:");
                    Console.WriteLine("{1} x {0}kr", val, antal);
                    Console.WriteLine("A total of" + kronorpool);
                }
            }
        }//sepmoney

    }//class
}//namespace
