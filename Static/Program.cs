namespace Static
{
    class Program
    {
        static void Main()
        {
            //https://msdn.microsoft.com/en-us/library/79b3xss3.aspx

            Twitch.GoTurbo("bobross@yahoo.com");

            var turbo = new Twitch();
            turbo.GoTurboNonStatic("Redas@gmail.com");
        }
    }
}
