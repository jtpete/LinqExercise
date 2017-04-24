using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises
{
    class Inventory
    {
        public string product;
        public int maxSupply;
        public int actualSupply;

        public Inventory(string product, int maxSupply, int actualSupply)
        {
            this.product = product;
            this.maxSupply = maxSupply;
            this.actualSupply = actualSupply;
        }
    }
}
