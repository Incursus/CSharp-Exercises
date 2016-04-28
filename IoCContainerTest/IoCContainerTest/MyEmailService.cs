namespace IoCContainerTest
{
    internal class MyEmailService
    {
        private readonly IEmailChecker emailChecker;

        public MyEmailService(IEmailChecker emailChecker)
        {
            this.emailChecker = emailChecker;
        }
    }

    interface IEmailChecker
    {
         
    }

    class EmailChecker : IEmailChecker
    {
        
    }
}