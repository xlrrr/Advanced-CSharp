using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\text.txt");
            StreamWriter writer = new StreamWriter(@"..\..\output.txt");
            string str;
            int lineNumber = 1;
            using (reader)
            {
                using (writer)
                {
                    str = reader.ReadLine();
                    while (str != null)
                    {
                        writer.WriteLine("Line {0}: {1}", lineNumber, str);
                        lineNumber++;
                        str = reader.ReadLine();
                    }
                }
            }
        }
    }
}
