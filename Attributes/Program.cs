namespace Attributes
{
    //http://progrunning.net/what-ive-learned-today-debugging-with-debuggerdisplay-attribute/
    class Program
    {
        static void Main()
        {
            House house = new House();
            house.Number = "18";
            house.Street = "Jovaru";
            house.Number = "20";
        }
    }
 }
