using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_PJ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Required Features:
            //•	Money should be input in fixed denominations:
            //○ 1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr and 1000kr. fixed
            //• The user should be able to put any amount of money in, adding to the “money pool”. fixed
            //• The user should be able to buy any number of products, as long as they have the money for it in the machine. fixed
            //• When the user decides to stop buying things, the remaining money should be returned as change. fixed
            //• The vending machine should have at least three different types of product, such as drinks, snacks, food and so on. fixed
            //• Once a product has been purchased, the user should be able to use it, showing a message about how it is used (drink the drink, eat the snack / food, etc…) fix?

            Vendingmachine Vend = new Vendingmachine();

            Vend.Vending();
        }
    }//class
}//namespace
