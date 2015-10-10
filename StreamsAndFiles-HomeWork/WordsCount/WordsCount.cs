using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordsCount
{
    class WordsCount
    {
        static void Main(string[] args)
        {
            StreamReader readerWords = new StreamReader(@"..\..\words.txt");
            StreamReader readerText = new StreamReader(@"..\..\text.txt");
            StreamWriter writer = new StreamWriter(@"..\..\result.txt");

            using (readerWords)
            {
                using (readerText)
                {
                    using (writer)
                    {
                        Dictionary<string,int> search = new Dictionary<string,int>();
                        while(true){
                            string temp = readerWords.ReadLine();
                            if (temp != null) search.Add(temp, 0);
                            if (temp == null) break;
                        }

                            
                            while (true)
                            {
                                string text = readerText.ReadLine();
                                if (text == null) break;
                                else
                                {
                                    MatchCollection matches = Regex.Matches(text, @"\w+");
                                    for (int j = 0; j < matches.Count; j++)
                                    {
                                        string check = matches[j].ToString().ToLower();
                                        if (search.ContainsKey(check)) search[matches[j].ToString().ToLower()]++;
                                    }
                                }
                                
                            }

                            foreach (KeyValuePair<string, int> item in search.OrderByDescending(key => key.Value))
                            {
                                writer.WriteLine("{0} - {1}", item.Key, item.Value);
                                Console.WriteLine("{0} - {1}",item.Key, item.Value);
                            }
                    }
                }
            }

        }
    }
}
