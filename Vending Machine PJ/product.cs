using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_PJ
{

    public class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public int stuff { get; set; }
        public static bool Consume = false;

        //make generic use method here
        //gonna overload it when  specific products gets bought
        public static void Useit()
        {
            Console.WriteLine("Do you wanna 'drink' the " + name + "?");

            bool choice = true;
            while (choice)
            {
                Console.WriteLine("Y/N");
                char Y = Console.ReadKey(true).KeyChar;
                switch (Y)
                {
                    case 'Y':
                    case 'y':
                        Console.WriteLine("you 'drink' the " + name + ", it tastes a bit funny but you feel refreshed.");
                        choice = false;
                        Product.Consume = false;
                        break;
                    case 'N':
                    case 'n':
                        Console.WriteLine("You decide to save the " + name + " for a later time.");
                        choice = false;
                        Product.Consume = false;
                        break;
                    default:
                        Console.WriteLine("Only use Y or N");
                        break;
                }//switch


            }//while(choice)

        }//use it
    }//class
}//namespace

