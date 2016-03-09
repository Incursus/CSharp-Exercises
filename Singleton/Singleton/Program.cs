using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonB._instance.Test();
            Test test = new Test();
            test.Name = "Darius";
        }
    }
}
