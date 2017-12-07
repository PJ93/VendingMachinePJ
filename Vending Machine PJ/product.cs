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
        //bool buy ?
        

        //public product(string name, int price)//made this public, but the base name ect are still private
        //{
        //    this.name = name;
        //    this.price = price;
        //}


    }//class
}//namespace
