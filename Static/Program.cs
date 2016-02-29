namespace Static
{
    class Program
    {
        static void Main()
        {
            Twitch.GoTurbo("static");
            "redk@test.com".ToConsole();

            var turbo = new Twitch();
            turbo.GoTurboNonStatic("non-static");
        }
    }
}
