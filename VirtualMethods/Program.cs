namespace VirtualMethods
{
    internal class Program
    {
/*
            Virtual methods are part of Polymorphism which is an OOP principle. Virtual methods are part of dynamic polymorphism,
            which is executed at run-time. First link: polymorphism, second: difference between compile time and run-time.
            http://codebetter.com/raymondlewallen/2005/07/19/4-major-principles-of-object-oriented-programming/ (scroll bellow)
            http://stackoverflow.com/questions/2152848/compile-time-polymorphism-vs-run-time-polymorphism
*/

        private static void Main()
        {
            EReader kindleText = new Kindle();
            kindleText.PrintSupportedFormats();

            EReader nookText = new Nook();
            nookText.PrintSupportedFormats();
        }
    }
}
