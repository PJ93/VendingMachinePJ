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
        public bool Consume = false;

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public override string ToString() //fixed names not showing up.
        {
            return $"{name}:\t{price}kr";
        }

        //make generic use method here
        //gonna overload it when  specific products gets bought
        public virtual void Useit()
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
                        Console.WriteLine("you use the " + name);
                        choice = false;
                        this.Consume = false;
                        break;
                    case 'N':
                    case 'n':
                        Console.WriteLine("You decide to save the " + name + " for a later time.");
                        choice = false;
                        this.Consume = false;
                        break;
                    default:
                        Console.WriteLine("Only use Y or N");
                        break;
                }//switch


            }//while(choice)

        }//use it
    }//class
}//namespace

