using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Lego : Product
    {
        public int NumberParts { get; set; }

        public Lego(int numberParts, string name, double price, int count)
            : base(name, price, count)
        {
            NumberParts = numberParts;
        }
        public override string Display()
        {
            return ($"{Name} {Price} {Count} {NumberParts}");
        }
    }
}
