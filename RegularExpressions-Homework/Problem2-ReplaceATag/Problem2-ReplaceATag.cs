using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem2_ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"<a.*href=((?:.|\n)*?(?=>))>((?:.|\n)*?(?=<))<\/a>";
            string replace = @"[URL href=$1]$2[/URL]";
            var replaced = Regex.Replace(text, pattern, replace);
            Console.WriteLine(replaced);
        }
    }
}
