using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Thousand_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo provider = CultureInfo.InvariantCulture;
            
            string input = Console.ReadLine();
            string DateFormat = "dd-MM-yyyy";
            DateTime result = DateTime.ParseExact(input, DateFormat, provider);
            result = result.AddDays(999);
            Console.WriteLine(result.ToString(DateFormat));
        }
    }
}
