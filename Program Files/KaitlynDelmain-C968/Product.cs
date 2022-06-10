using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace KaitlynDelmain_C968
{
    class Product
    {
        public BindingList<Part> assocPartList = new BindingList<Part>();

        public static int assocPartIndex { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public static int prodCount = 1;

        public Product(int pID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = prodCount++;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
    }
}
