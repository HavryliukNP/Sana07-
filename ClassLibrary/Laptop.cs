using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Laptop : Product
    {
        public string Processor {  get; set; }
        public string Memory { get; set; }

        public Laptop(string processor, string memory, string name, double price, int count)
            : base(name, price, count) 
        {
            Processor = processor; 
            Memory = memory; 
        }
        public override string Display()
        {
            return ($"{Name} {Price} {Count} {Processor} {Memory}");
        }
    }
}
