using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace KaitlynDelmain_C968
{
    class Inventory
    {
        private static BindingList<Part> partList = new BindingList<Part>();
        public static BindingList<Part> PartList { get { return partList; } set { partList = value; } }

        private static BindingList<Product> prodList = new BindingList<Product>();
        public static BindingList<Product> ProdList { get { return prodList; } set { prodList = value; } }

        public static Part currentPart { get; set; }

        public static Product currentProduct { get; set; }

        public static int prodIndex { get; set; }
        public static int partIndex { get; set; }


        public static void addProd(Product prod)
        {
            ProdList.Add(prod);
        }

        internal static void swapProd(Product prod)
        {
            ProdList.Insert(prodIndex, prod);
            ProdList.RemoveAt(prodIndex + 1);
        }

        public static void addPart(Part part)
        {
            PartList.Add(part);
        }

        internal static void swapPart(Part part)
        {
            PartList.Insert(partIndex, part);
            PartList.RemoveAt(partIndex + 1);
        }
    }
}
