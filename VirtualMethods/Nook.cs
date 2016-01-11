using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    public class Nook : EReader
    {
        public override void PrintSupportedFormats()
        {
            Console.WriteLine("Nook supports default book formats... + PDF!");
        }
    }
}
