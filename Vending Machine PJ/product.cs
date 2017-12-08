using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_PJ
{

    public class Product
    {
        public string name;
        public int price;
        public int itemnum;
        public bool Consume = false;

        public Product(int itemnum, string name, int price)
        {
            this.itemnum = itemnum;
            this.name = name;
            this.price = price;
        }
        public override string ToString() //fixed names not showing up.
        {
            return $"{itemnum} {name}: \t{price}kr";
        }

        public virtual void Useit()
        {
            Console.WriteLine($"you a bought {name}");
            Console.WriteLine("Do you wanna consume the " + name + "?");

            bool choice = true;
            while (choice)
            {
                Console.WriteLine("Y/N");
                char Y = Console.ReadKey().KeyChar;
                switch (Y)
                {
                    case 'Y':
                    case 'y':
                        Console.WriteLine("you use the " + name);
                        Console.ReadKey();
                        Console.ReadKey();
                        this.Consume = false;
                        choice = false;
                        break;
                    case 'N':
                    case 'n':
                        Console.WriteLine("You decide to save the " + name + " for a later time.");
                        Console.ReadKey();
                        this.Consume = false;
                        choice = false;
                        break;
                    default:
                        Console.WriteLine("Only use Y or N");
                        Console.ReadKey();
                        break;
                }//switch
                Console.ReadKey();

            }//while(choice)
            Console.ReadKey();
        }//use it
        

    }//class
}//namespace

