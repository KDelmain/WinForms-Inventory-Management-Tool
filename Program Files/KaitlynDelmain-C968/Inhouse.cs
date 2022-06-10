using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaitlynDelmain_C968
{
    class Inhouse : Part
    {
        public Inhouse(int pID, string name, decimal price, int inStock, int min, int max, int mID)
            : base(pID, name, price, inStock, min, max)
        {
            MachineID = mID;
        }
        public int MachineID { get; set; }
    }
}
