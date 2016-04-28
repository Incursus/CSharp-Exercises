using System;
using Microsoft.Practices.Unity;

namespace IoCContainerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer myContainer = new UnityContainer();

            myContainer.RegisterType(typeof(MyEmailService), "MyBestEmail");
            myContainer.RegisterType(typeof (IEmailChecker), typeof (EmailChecker));
            var test = myContainer.Resolve<MyEmailService>();
            Console.WriteLine(test.GetType());
        }
    }
}
