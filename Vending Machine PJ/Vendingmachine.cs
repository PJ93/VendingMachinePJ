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
        bool buying = false; //despite visual studio thinking this is not used it is.
        bool use = true;

        int krona = Money.kronorpool;



        public void Vending()
        {

            int peng = 0;

            //products
            Product cola = new Drinks(1, "Coca-cola", 12);
            Product fanta = new Drinks(2, "Fanta", 12);
            Product water = new Drinks(3, "water", 15);
            Product choco = new Snacks(4, "Chocolade", 20);
            Product sandwichcheese = new Food(5, "Cheese Sandvich", 30);
            Product banana = new Food(6, "Banana", 5);
            Product pastasallad = new Food(7, "Pasta Sallad", 55);

            List<Product> items = new List<Product>
            {
                cola,
                fanta,
                water,
                choco,
                sandwichcheese,
                banana,
                pastasallad  
            };

            //method buying //possibly move to money class
            int Sub(int krona, int price)
            {
                int res = krona - price;

                //kronorpool = res;              
                if (res < 0)
                {
                    Console.WriteLine("Not enough money, purchase failed.");
                    buying = false;
                    use = true;
                }
                else
                {
                    Money.kronorpool = res;
                    use = false;
                }
                return Money.kronorpool;
            }//sub

            bool mainmenu = true;
            while (mainmenu)
            {
                Console.WriteLine("1: Buy");
                Console.WriteLine("2: Insert money");
                Console.WriteLine("3: End and collect change.");
                Console.WriteLine($"Money to spend: {Money.kronorpool}");

                char menuchoice = Console.ReadKey(true).KeyChar;
                switch (menuchoice)
                {
                    case '1':
                        bool buying = true;
                        while (buying)
                        {
                            Console.Clear();
                            Console.WriteLine("Amount of money to spend: " + Money.kronorpool);

                            Console.WriteLine("What do you wanna buy?");

                            for (int i = 0; i < items.Count; i++)
                            {
                                Console.WriteLine($"{items[i]}");

                            }

                            Console.WriteLine("0 BACK TO MAINMENU");
                            bool test2 = true;
                            string choicein = Console.ReadLine();
                            int choiceout = 0;
                            try
                            {

                                test2 = int.TryParse(choicein, out choiceout);
                            }
                            catch
                            {
                                //catch must still be here or visual studio complains
                            }
                            if (test2)
                            if (choiceout < 0)
                            {
                                Console.WriteLine("Not a valid number");
                                break;
                            }

                            if (choiceout > 0)
                                foreach (var product in items)
                                {
                                    if (choiceout == product.itemnum)
                                    {
                                        Money.kronorpool = Sub(Money.kronorpool, product.price); 

                                        if(use == false)
                                        {
                                            product.Useit();
                                        }

                                        Console.ReadKey();

                                        
                                    }
                                }
                            else if (choiceout > items.Count)
                            {
                                Console.WriteLine("Sorry no product with that item number");
                            }
                            if (choiceout == 0)
                            {
                                buying = false;
                            }

                            //Console.Clear();

                        }//buying

                        break;

                    case '2':
                        while (true)//can possibly move to the money class
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

                        break;

                    case '3':
                        mainmenu = false;

                        break;
                }//switchmainmenu
                Console.Clear();

            }//whilemainmenu

            Money.Seperatemoney(); 

            Console.ReadKey(true);

        }//vending

    }//class
}//namespace
