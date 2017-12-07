using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_PJ
{


    class Snacks : Product
    {


        public Snacks(string name, int price)//made this public, but the base name ect are still private
        {
            this.name = name;
            this.price = price;
        }

        public void Eatit()
        {
            Console.WriteLine("Do you wanna eat the " + name + "?");

            bool eatchoice = true;
            while (eatchoice)
            {
                Console.WriteLine("Y/N");
                char Y = Console.ReadKey(true).KeyChar;
                switch (Y)
                {
                    case 'Y':
                    case 'y':
                        Console.WriteLine("you eat the " + name + ", it tastes a bit funny...");
                        eatchoice = false;
                        Product.Consume = false;
                        break;
                    case 'N':
                    case 'n':
                        Console.WriteLine("You decide to save the " + name + " for a later time.");
                        eatchoice = false;
                        Product.Consume = false;
                        break;
                    default:
                        Console.WriteLine("Only use Y or N");
                        break;
                }


            }
        }


    }//class
}//namespace
