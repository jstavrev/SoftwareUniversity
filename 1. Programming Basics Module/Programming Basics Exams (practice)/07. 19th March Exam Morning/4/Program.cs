using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double payPerLecture = budget / n;
            double salaryJelev = 0.0;
            double salaryRoyal = 0.0;
            double salaryRoli = 0.0;
            double salaryTrofon = 0.0;
            double salarySino = 0.0;
            double othersSalary = 0.0;

            for (int i = 0; i < n; i++)
            {
                string teacherName = Console.ReadLine();
                
                switch (teacherName)
                {
                    case "Jelev":
                        salaryJelev += payPerLecture;
                        break;
                    case "RoYaL":
                        salaryRoyal += payPerLecture;
                        break;
                    case "Roli":
                        salaryRoli += payPerLecture;
                        break;
                    case "Trofon":
                        salaryTrofon += payPerLecture;
                        break;
                    case "Sino":
                        salarySino += payPerLecture;
                        break;
                    default:
                        othersSalary += payPerLecture;
                        break;
                }
            }
            Console.WriteLine($"Jelev salary: {salaryJelev:F2} lv");
            Console.WriteLine($"RoYaL salary: {salaryRoyal:F2} lv");
            Console.WriteLine($"Roli salary: {salaryRoli:F2} lv");
            Console.WriteLine($"Trofon salary: {salaryTrofon:F2} lv");
            Console.WriteLine($"Sino salary: {salarySino:F2} lv");
            Console.WriteLine($"Others salary: {othersSalary:F2} lv");
        }
    }
}
