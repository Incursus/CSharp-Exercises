using System;
using System.Net;
using System.Threading.Tasks;

namespace ParallelFor
{
    class Program
    {
        private static string[] _links;

        static void Main()
        {
            _links = new string[16];
            _links[0] = "https://www.twitch.tv";
            _links[1] = "https://www.twitch.tv/Summit1g";
            _links[2] = "https://www.twitch.tv/Sodapoppin";
            _links[3] = "https://www.twitch.tv/Aklaizer";
            _links[4] = "https://www.google.lt";
            _links[5] = "https://www.amazon.com";
            _links[6] = "https://www.gmail.com";
            _links[7] = "https://www.facebook.com";
            _links[8] = "https://www.delfi.lt";
            _links[9] = "http://edition.cnn.com/";
            _links[10] = "https://www.bbc.com";
            _links[11] = "https://www.twitter.com";
            _links[12] = "https://www.pinterest.com/";
            _links[13] = "https://www.youtube.com/Caseyneistat";
            _links[14] = "https://www.youtube.com/JonTronShow";
            _links[15] = "https://www.github.com";

            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.MaxDegreeOfParallelism = 8;

            Parallel.For(0, 16, parallelOptions, Call);
        }

        private static void Call(int index)
        {
            Console.WriteLine("Downloading " + _links[index]);
            WebClient webClient = new WebClient();
            var webContent = webClient.DownloadString(_links[index]);
            Console.WriteLine(_links[index] + " : " + webContent.Length);
        }
    }
}
