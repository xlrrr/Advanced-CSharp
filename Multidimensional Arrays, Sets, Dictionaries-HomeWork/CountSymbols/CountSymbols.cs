using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            SortedDictionary<char,int> output = new SortedDictionary<char,int>();
            int sum=1;
            for (int i = 0; i < inputText.Length;i++ )
            {
                if (!output.ContainsKey(inputText[i]))
                {
                    output.Add(inputText[i], 0);
                }
                if (output.ContainsKey(inputText[i]))
                {
                    output[inputText[i]] =output[inputText[i]] +1;
                }
            }
            foreach (var word in output.Keys)
            {
                Console.WriteLine("{0}: {1} time/s", word,output[word]);
            }
        }
    }
}
