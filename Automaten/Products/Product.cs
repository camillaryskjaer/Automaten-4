using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Products
{
    internal abstract class Product
    {

        public abstract string Name { get; set; }
        internal abstract int Amount { get; set; }
        internal abstract string DicitonaryKey { get; }
        internal abstract int Cost { get; set; }
    }
}
