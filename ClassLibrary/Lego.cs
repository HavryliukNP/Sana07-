using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Lego : Product
    {
        protected int numberParts;
        public int NumberParts
        {
            get { return numberParts; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Кількість деталей не може бути від'ємною.");
                numberParts = value;
            }
        }
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
