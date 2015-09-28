using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem4_SentenceExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = string.Format(@"(?<=\s|^)[^!.?]*\b{0}\b[^!.?]*[!.?]", word);
            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
            Console.WriteLine("Found {0} matches", matches.Count);
            foreach (Match sentence in matches)
            {
                Console.WriteLine(sentence.Groups[0]);
            }
        }
    }
}
