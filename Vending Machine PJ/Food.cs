using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_PJ
{
    class Food : Product
    {

        public Food(string name, int price)//made this public, but the base name ect are still private
            : base(name, price)
        {
            this.name = name;
            this.price = price;
        }


        public override void Useit()
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
                        this.Consume = false;
                        break;
                    case 'N':
                    case 'n':
                        Console.WriteLine("You decide to save the " + name + " for a later time, probably lunch.");
                        eatchoice = false;
                        this.Consume = false;
                        break;
                    default:
                        Console.WriteLine("Only use Y or N");
                        break;
                }


            }
        }
    }//class
}//namespace
