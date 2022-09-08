using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Products
{
    internal class Drink : Product
    {
        public Drink(string name, string dictionaryKey, int cost)
        {
            this.name = name;
            this.dictionaryKey = dictionaryKey;
            this.cost = cost;
        }
        private string name;
        private string dictionaryKey;
        private int cost;
        public override string Name { get { return name; } }
        internal override string DicitonaryKey { get { return dictionaryKey; } set { dictionaryKey = value; } }
        internal override int Cost { get { return cost; } set { cost = value; } }
    }
}