using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shopping_Cart_Practice.Models;

namespace Shopping_Cart_Practice.Controllers
{
    public class Item
    {

        private Table_Product product = new Table_Product();

        public Table_Product Product
        {
            get { return product; }
            set { product = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Item()
        { 
        
        
        }


        public Item(Table_Product p , int q)
        {
            product = p;
            quantity = q;


        }
    }
}