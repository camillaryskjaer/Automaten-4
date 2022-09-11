using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Products
{
    //Abstract internal class
    internal abstract class Product
    {
        //one public abstract variable with get set
        public abstract string Name { get; set; }

        //Internal Abstract variables with get set and one with only get
        internal abstract int MaxStock { get; set; }
        internal abstract int Stock { get; set; }
        internal abstract int Amount { get; set; }
        internal abstract int Cost { get; set; }
        internal abstract string DicitonaryKey { get; }
    }
}
