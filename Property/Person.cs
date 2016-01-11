namespace Property
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string SkinColor { get; private set; } = "Hwite";
    }
}
