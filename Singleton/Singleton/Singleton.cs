using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonB
    {
        public static SingletonB _instance = new SingletonB();

        public void Test()
        {
            // Code runs.
            Console.WriteLine(true);
        }

        SingletonB()
        {
        }
    }

    public class Test
    {
        public string Name { get; set; }

        public Test()
        {
           
        }
    }

}
