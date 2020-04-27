using System;
using System.Collections.Generic;

namespace car_lot
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, Dictionary<string, string>>> vehicles = new List<Dictionary<string, Dictionary<string, string>>>();

            Dictionary<string, Dictionary<string, string>> sale = new Dictionary<string, Dictionary<string, string>>();

            Dictionary<string, string> vehicle = new Dictionary<string, string>();
            vehicle.Add("year", "2008");
            vehicle.Add("model", "Damfresh");
            vehicle.Add("make", "Biotraxquote");
            vehicle.Add("color", "sky magenta");

            Dictionary<string, string> salesAgent = new Dictionary<string, string>();
            salesAgent.Add("mobile", "(896) 478-6975");
            salesAgent.Add("lastName", "Botsford");
            salesAgent.Add("firstName", "Shaina");

            Dictionary<string, string> credit = new Dictionary<string, string>();
            credit.Add("creditProvider", "J.P. Morgan Chase & Co");
            credit.Add("account", "601109582720302");

            sale.Add("vehicle", vehicle);
            sale.Add("salesAgent", salesAgent);
            sale.Add("credit", credit);

            vehicles.Add(sale);

            Dictionary<string, Dictionary<string, string>> sale2 = new Dictionary<string, Dictionary<string, string>>();

            Dictionary<string, string> vehicle2 = new Dictionary<string, string>();
            vehicle2.Add("year", "2010");
            vehicle2.Add("model", "Hotquadtrax");
            vehicle2.Add("make", "Transtintechno");
            vehicle2.Add("color", "robin egg blue");

            Dictionary<string, string> salesAgent2 = new Dictionary<string, string>();
            salesAgent2.Add("mobile", "562.300.2912");
            salesAgent2.Add("lastName", "Davis");
            salesAgent2.Add("firstName", "Gerardo");

            Dictionary<string, string> credit2 = new Dictionary<string, string>();
            credit2.Add("creditProvider", "PNC Financial Services");
            credit2.Add("account", "34578280562836");

            sale2.Add("vehicle", vehicle2);
            sale2.Add("salesAgent", salesAgent2);
            sale2.Add("credit", credit2);

            vehicles.Add(sale2);

            foreach (Dictionary<string, Dictionary<string, string>> dict in vehicles)
            {
                foreach (KeyValuePair<string, Dictionary<string, string>> salePair in dict)
                {
                    Console.WriteLine($"This is: {salePair.Key}");
                    foreach(KeyValuePair<string, string> section in salePair.Value)
                    {
                        Console.WriteLine($"{section.Key}: {section.Value}");
                    }
                }
            }

            // foreach (KeyValuePair<string, string> item in salesAgent2)
            // {
            //     Console.WriteLine($"The item key is {item.Key} and the item value is {item.Value}");
            // }            
        }
    }
}

// "vehicles": [
//     {
//         "vehicle": {
//             "year": "2008",
//             "model": "Damfresh",
//             "make": "Biotraxquote",
//             "color": "sky magenta"
//         },
//         "sales_agent": {
//             "mobile": "(896) 478-6975",
//             "last_name": "Botsford",
//             "first_name": "Shaina"
//         },
//         "credit": {
//             "credit_provider": "J.P.Morgan Chase & Co",
//             "account": "601109582720302"
//         }
//     },
//     {
//         "vehicle": {
//             "year": "2010",
//             "model": "Hotquadtrax",
//             "make": "Transtintechno",
//             "color": "robin egg blue"
//         },
//         "sales_agent": {
//             "mobile": "562.300.2912",
//             "last_name": "Davis",
//             "first_name": "Gerardo"
//         },
//         "credit": {
//             "credit_provider": "PNC Financial Services",
//             "account": "34578280562836"
//         }
//     }
// ]