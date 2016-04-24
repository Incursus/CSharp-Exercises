using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexMatching
{
    class Program
    {
        static void Main()
        {
            //Used RegexBuddy for the exercise.
            string twitchPageContent = File.ReadAllText("RegexExerciseData.htm");
            var matchCollection = Regex.Matches(twitchPageContent, @"[0-9]+,[0-9]+\s+viewers");
            List<int> viewerCounts = new List<int>();

            foreach (object match in matchCollection)
            {
                var text = match.ToString().Replace("viewers", "").Replace(",", "").Trim();
                int cleanCount = int.Parse(text);
                viewerCounts.Add(cleanCount);
            }

            var moreThanThousandViewers = viewerCounts.Count(i => i > 1000);
            var totalViewers = viewerCounts.Sum();
            Console.WriteLine("Games that have over 1000 viewers: " + moreThanThousandViewers);
            Console.WriteLine("Total viewer count: " + totalViewers);
        }
    }
}
