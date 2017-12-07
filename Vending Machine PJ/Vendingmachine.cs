using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_PJ
{
    public class Vendingmachine
    {
        //make into list array
        //drinks


        List<Product> drinks = new List<Product>();

        Drinks coke = new Drinks("Coca-cola", 12);
        Drinks fanta = new Drinks("Fanta", 12);
        Drinks water = new Drinks("Water", 15);

        //snacks
        Snacks Choco = new Snacks("Chocolate", 10);
        Snacks Chips = new Snacks("Chips", 25);

        //food
        Food sandvich = new Food("Cheese Sandvich", 25);

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
                Product.Consume = true;
            }
            //return res;
            return Money.kronorpool;
        }



        
        public void Vending()
        {

            int peng = 0;
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
                //possible improvement make all products into generic list 

                //Console.WriteLine("Drinks");
                Console.WriteLine("1 " + coke.name);
                Console.WriteLine("2 " + fanta.name);
                Console.WriteLine("3 " + water.name);
                //Console.WriteLine("Snacks");
                Console.WriteLine("4 " + Choco.name);
                //Console.WriteLine("Food");
                Console.WriteLine("5 " + sandvich.name);

                //end it
                Console.WriteLine("0 END");

                char choice = Console.ReadKey(true).KeyChar;
                    

                switch (choice)//possible improvement make the calcuations into a generic method
                {
                    case '1':
                        Money.price = coke.price;//somehow make it so money.price = becomes a generic method, overload possibly?
                        Money.kronorpool = Sub(Money.kronorpool, coke.price);
                        if(Product.Consume == true)
                        {
                            coke.Drinkit();
                        }
                        
                    break;

                    case '2':
                        Money.price = fanta.price;
                        Money.kronorpool = Sub(Money.kronorpool, fanta.price);
                        Product.Useit();
                    break;

                    case '3':
                        Money.price = water.price;
                        Money.kronorpool = Sub(Money.kronorpool, Money.price);
                    break;
                    case '4':
                        Money.price = Choco.price;
                        Money.kronorpool = Sub(Money.kronorpool, Money.price);
                        if (Product.Consume == true)
                            Choco.Eatit();
                    break;

                    case '5':
                        Money.price = sandvich.price;
                        Money.kronorpool = Sub(Money.kronorpool, Money.price);
                        if (Product.Consume == true)
                            sandvich.Eatit();
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
            //Console.WriteLine("You get back a total of " + Money.kronorpool + "kr");

            Console.ReadKey(true);

        }//vending

    }//class
}//namespace
