using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Products
{
    internal class Snack : Product
    {
        public Snack(string name, string dictionaryKey, int cost, int amount)
        {
            this.name = name;
            this.dictionaryKey = dictionaryKey;
            this.cost = cost;
            this.amount = amount;
        }
        private string name;
        private string dictionaryKey;
        private int cost;
        private int amount;

        public override string Name { get { return name; } set { name = value; } }
        internal override int Amount { get { return amount; } set { amount = value; } }
        internal override string DicitonaryKey { get { return dictionaryKey; } }
        internal override int Cost { get { return cost; } set { cost = value; } }

    }
}
