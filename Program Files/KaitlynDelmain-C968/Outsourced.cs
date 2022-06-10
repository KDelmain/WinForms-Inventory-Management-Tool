using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaitlynDelmain_C968
{
    class Outsourced : Part
    {
        public Outsourced(int pID, string name, decimal price, int inStock, int min, int max, string coName)
            : base(pID, name, price, inStock, min, max)
        {
            CompanyName = coName;
        }
        public string CompanyName { get; set; }
    }
}
