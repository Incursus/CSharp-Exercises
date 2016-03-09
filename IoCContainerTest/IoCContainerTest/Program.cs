using Microsoft.Practices.Unity;

namespace IoCContainerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer myContainer = new UnityContainer();

            myContainer.RegisterType(typeof(MyEmailService), "MyBestEmail");
        }
    }
}
