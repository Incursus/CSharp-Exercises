using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main()
        {
            EReader kindleText = new Kindle();
            kindleText.PrintSupportedFormats();

            EReader nookText = new Nook();
            nookText.PrintSupportedFormats();
        }
    }
}
