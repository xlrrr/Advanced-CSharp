using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class PopulationCentre
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var populationData = new Dictionary<string, Dictionary<string, int>>();
            while (input != "report")
            {
                string[] inputSplit = Regex.Split(input, @"\|");

                if (!populationData.ContainsKey(inputSplit[0]))
                {
                    populationData.Add(inputSplit[0], new Dictionary<string, int>());
                }

                populationData[inputSplit[0]].Add(inputSplit[1], int.Parse(inputSplit[2]));
                input = Console.ReadLine();

            }
            var sortedPopulationData = populationData
                .OrderByDescending(x => x.Value
                    .Sum(y => y.Value));

            foreach (var countryInfo in sortedPopulationData)
            {
                long totalPopulation = countryInfo.Value.Sum(x => x.Value);
                Console.WriteLine(
                    "{0} (total population: {1})",
                    countryInfo.Key,
                    totalPopulation);

                var orderedCityData = countryInfo.Value
                    .OrderByDescending(x => x.Value);

                foreach (var cityInfo in orderedCityData)
                {
                    Console.WriteLine("=>{0}: {1}", cityInfo.Key, cityInfo.Value);
                }
            }
        }
    }
}