using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_PJ
{
    public class Drinks : Product
    {
        
        public Drinks(string name, int price)//made this public, but the base name ect are still private
            :base(name, price)
        {
            //this.name = name;
            //this.price = price;
            this.Consume = false;
        }

        public override void Useit()
        {
            Console.WriteLine("Do you wanna drink the "+ name +"?");

            bool drinkchoice = true;
            while (drinkchoice)
            {
                Console.WriteLine("Y/N");
                char Y = Console.ReadKey(true).KeyChar;
                switch (Y)
                {
                    case 'Y':
                    case 'y':
                        Console.WriteLine("you drink the " + name + ", it tastes a bit funny but you feel refreshed.");
                        drinkchoice = false;
                        this.Consume = false;
                        break;
                    case 'N':
                    case 'n':
                        Console.WriteLine("You decide to save the " + name + " for a later time.");
                        drinkchoice = false;
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
