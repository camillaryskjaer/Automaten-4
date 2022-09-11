using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Products
{
    internal class Drink : Product
    {
        //Constructer
        public Drink(string name, string dictionaryKey, int cost, int amount)
        {
            this.name = name;
            this.dictionaryKey = dictionaryKey;
            this.cost = cost;
            this.amount = amount;
        }
        //Properties
        private string name;
        private string dictionaryKey;
        private int cost;
        private int amount;
        private int stock = 4;
        private int maxStock = 4;

        //Encapsulation
        public override string Name { get { return name; } set { name = value; } }
        internal override int MaxStock { get { return maxStock; } set { maxStock = value; } }
        internal override int Stock { get { return stock; } set { stock = value; } }
        internal override int Amount { get { return amount; } set { amount = value; } }
        internal override string DicitonaryKey { get { return dictionaryKey; } }
        internal override int Cost { get { return cost; } set { cost = value; } }
    }
}