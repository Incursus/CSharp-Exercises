namespace Static
{
    class Program
    {
        static void Main()
        {
            //https://msdn.microsoft.com/en-us/library/79b3xss3.aspx

            Twitch.GoTurbo("static");
            "redk@test.com".ToConsole();

            var turbo = new Twitch();
            turbo.GoTurboNonStatic("non-static");
        }
    }
}
