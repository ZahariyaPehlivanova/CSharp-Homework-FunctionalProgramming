using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Office_Stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var companyInformation = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] text = input.Split('-');
                string company = text[0];
                string amount = text[1];
                string product = text[2];

                if (!companyInformation.ContainsKey(company))
                {
                    companyInformation.Add(company, new List<string>());
                }
                companyInformation[company].Add(amount);
                companyInformation[company].Add(product);
            }
            var query = from key in companyInformation.Keys.ToList()
                        orderby key ascending
                        select key;
            

            foreach (var key in query)
            {
                Console.Write(key + ":");
                int i = 0;

                foreach (KeyValuePair<string, int> pair in companyInformation[key])
                {
                    if (i == companyInformation[key].Count - 1)
                    {
                        Console.WriteLine(" {0}-{1}", pair.Key, pair.Value);
                    }
                    else
                    {
                        Console.Write(" {0}-{1},", pair.Key, pair.Value);
                    }
                    i++;
                }
            }
    }
}
