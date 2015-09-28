using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banned = Console.ReadLine().Split(',').ToArray();
            string text = Console.ReadLine();
            StringBuilder textBuilder = new StringBuilder(text);
            foreach (string ban in banned)
            {
                string mask = new string('*', ban.Length);
                textBuilder.Replace(ban, mask);
            }
            Console.WriteLine(textBuilder.ToString());
        }
    }
}
