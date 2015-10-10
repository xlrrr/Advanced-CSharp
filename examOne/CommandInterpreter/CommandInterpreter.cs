using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputWords = Regex.Split(input, @"\s+");
            string[] commandWords;
            while (true)
            {
            string commandInput = Console.ReadLine();
            commandWords = Regex.Split(commandInput, @"\s+");
            if (commandWords[0] == "end") break;
            string command = commandWords[0];
            switch (command)
            {
                case "reverse":
                    int start = int.Parse(commandWords[2]), end = int.Parse(commandWords[4]);
                    List<string> result= new List<string>();
                    for (int i = 0; i < start; i++)
                    {
                        result.Add(inputWords[i]);
                    }
                    for (int i = end+1; i >= start; i--)
                    {
                        result.Add(inputWords[i]);
                    }
                    for (int i = end + 2; i < inputWords.Count(); i++)
                    {
                        result.Add(inputWords[i]);
                    }
                    Console.Write("[");
                    int j;
                    for(j=0;j<result.Count()-1;j++){
                        Console.Write("{0}, ", result[j]);
                    }
                    Console.Write("{0}]",result[j]);
                        break;
                case "sort":
                    break;
                case "rollLeft":
                    break;
                case "rollRight":
                    break;
                default:
                    Console.WriteLine("Invalid input parameters");
                    break;
            }

            }
        }
    }
}
