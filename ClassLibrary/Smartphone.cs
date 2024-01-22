using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Smartphone : Product
    {
        public string OperatingSystem { get; set; }
        public string Memory { get; set; }
        public Smartphone(string operatingSystem, string memory, string name, double price, int count)
            :base(name, price, count)
        {
            OperatingSystem = operatingSystem;
            Memory = memory;
        }
        public override string Display()
        {
            return ($"{Name} {Price} {Count} {OperatingSystem} {Memory}");
        }
    }
}
