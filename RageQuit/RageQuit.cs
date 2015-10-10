using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = Regex.Split(input, "[0-9]+");
            for (int i = 0; i < words.Count(); i++)
            {
                words[i] = words[i].ToUpper();
            }
            Regex regex = new Regex("[0-9]+");
            string pattern = @"[0-9]+";

            List<char> uniqueSymbolExist = new List<char>();
            for (int i = 0; i < words.Count(); i++)
            {
                char[] uniqueSymbol = words[i].ToCharArray();
                for (int j = 0; j < uniqueSymbol.Count(); j++)
                {
                    if (!uniqueSymbolExist.Contains(Char.ToUpper(uniqueSymbol[j])))
                    {
                        uniqueSymbolExist.Add(Char.ToUpper(uniqueSymbol[j]));
                    }
                }
            }
            List<string> matches = new List<string>();
            MatchCollection wordCount = Regex.Matches(input,pattern);
            foreach(var match in wordCount)
            {
                matches.Add(match.ToString());
            }
            Console.WriteLine("Unique symbols used: ", uniqueSymbolExist.Count());
            for (int i = 0; i < matches.Count; i++)
            {
                Console.Write(string.Concat(Enumerable.Repeat(words[i], int.Parse(matches[i]))));
            }
            Console.WriteLine();
            
        }
    }
}
