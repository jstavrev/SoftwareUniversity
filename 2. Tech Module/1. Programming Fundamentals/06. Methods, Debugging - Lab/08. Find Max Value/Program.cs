using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Find_Max_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int maxValue = GetMaxInt(a, b);
                    Console.WriteLine(maxValue);
                    break;
                case "char":
                    char achr = char.Parse(Console.ReadLine());
                    char bchr = char.Parse(Console.ReadLine());
                    char maxChr = GetMaxChr(achr, bchr);
                    Console.WriteLine(maxChr);
                    break;
                case "string":
                    string atxt = Console.ReadLine();
                    string btxt = Console.ReadLine();
                    string maxTxt = GetMaxTxt(atxt, btxt);
                    Console.WriteLine(maxTxt);
                    break;
            }
        }

        static string GetMaxTxt(string a, string b)
        {
            if (a.CompareTo(b) >= 0)
            {
                return a;
            }
            return b;
        }

        static char GetMaxChr(char a, char b)
        {
            return (char)Math.Max(a, b);
        }

        static int GetMaxInt(int a, int b)
        {
            return Math.Max(a, b);
        }
    }
}
