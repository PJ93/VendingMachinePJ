using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_PJ
{
    public class Vendingmachine
    {
        //loops
        bool buying = false;

        int krona = Money.kronorpool;
        //method buying //possibly move to money class
        int Sub( int krona, int price)
        {
            int res = krona - price;

            
            //kronorpool = res;              
            if (res < 0)
            {
                Console.WriteLine("Not enough money, purchase failed.");
                buying = false;
            }
            else
            {
                Money.kronorpool = res;
            }
            //return res;
            return Money.kronorpool;
        }//sub

        public void Vending()
        {

            int peng = 0;


            Product cola = new Drinks("Coca-cola", 12);
            Product fanta = new Drinks("Fanta", 12);
            Product sandwichcheese = new Food("Cheese Sandvich", 30);
            Product choco = new Snacks("Chocolade", 20);

            List<Product> items = new List<Product>
            {
                cola,
                fanta,
                sandwichcheese,
                choco
            };


            while (true)
            {
                bool test = true;
                Console.Write("Insert money: ");
                string inputcoin = Console.ReadLine();
                try
                {
                    test = int.TryParse(inputcoin, out peng);
                }
                catch
                {
                    //catch must still be here or visual studio complains
                }

                bool acceptable = false;
                for (int i = 0; i < Money.kronor.Length; i++)
                {
                    if (peng == Money.kronor[i]) acceptable = true;
                    if (acceptable) break;//if it hits the same number it stops and doesn't continue going thru the array
                }

                if (test && acceptable) break; //easier way of making a loop until condition is met
                else Console.WriteLine("Error");
            }//money check
            Money.kronorpool = Money.kronorpool + peng;

            bool buying = true;
            while (buying)
            {



                Console.WriteLine("Amount of money to spend: " + Money.kronorpool);

                Console.WriteLine("What do you wanna buy?");

                for (int i = 0; i < items.Count; i++)
                {
                    //items[i].ToString();
                    Console.WriteLine($"{i}: {items[i]}");
                }

                //end it
                Console.WriteLine("0 END");

                char choice = Console.ReadKey(true).KeyChar;
                    

                switch (choice)//possible improvement make the calcuations into a generic method
                {
                    case '1':
                        Money.price = cola.price;//somehow make it so money.price = becomes a generic method, overload possibly?
                        Money.kronorpool = Sub(Money.kronorpool, cola.price);
                        if(cola.Consume == false)
                        {
                            cola.Useit();
                        }
                        
                    break;

                    case '2':
                        Money.price = fanta.price;
                        Money.kronorpool = Sub(Money.kronorpool, fanta.price);
                        //Product.Useit();
                    break;

                    case '3':
                        Money.price = water.price;
                        Money.kronorpool = Sub(Money.kronorpool, Money.price);
                    break;
                    case '4':
                        Money.price = choco.price;
                        Money.kronorpool = Sub(Money.kronorpool, Money.price);
                        if (choco.Consume == false)
                            choco.Useit();
                    break;

                    case '5':
                        Money.price = sandwichcheese.price;
                        Money.kronorpool = Sub(Money.kronorpool, Money.price);
                        if (sandwichcheese.Consume == false)
                            sandwichcheese.Useit();
                    break;

                    case '0':                            
                        buying = false;
                    break;
                    //case '+':
                    //    Console.WriteLine("How much do you wanna add?");
                    //    int add = Convert.ToInt32(Console.ReadLine());

                    //    kronorpool = kronorpool + add;
                            
                    //break;

                    default:
                        Console.WriteLine("Only use the numbers");
                    break;

                }//choice
            }//buying
            Money.Seperatemoney(); 

            Console.ReadKey(true);

        }//vending

    }//class
}//namespace
