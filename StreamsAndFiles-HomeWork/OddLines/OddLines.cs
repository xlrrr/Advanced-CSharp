using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader(@"..\..\text.txt");
                string s;
                int lineNumber = 0;
                using (reader)
                {
                    do
                    {
                        s = reader.ReadLine();
                        lineNumber++;
                        s = reader.ReadLine();
                        Console.WriteLine("Line {0, 2}: {1}", lineNumber, s);
                        lineNumber++;
                    } while (s != null);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}

