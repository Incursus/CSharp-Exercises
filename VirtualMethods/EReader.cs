using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    public class EReader
    {
        public virtual void PrintSupportedFormats()
        {
            Console.WriteLine("Default book formats");
        }
    }
}
