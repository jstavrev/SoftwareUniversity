using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grades = double.Parse(Console.ReadLine());
            double minimumIncome = double.Parse(Console.ReadLine());

            bool excellentGradesScholarship = grades >= 5.5;
            bool socialScholarship = (income <= minimumIncome) && (grades > 4.5);
            double scholarshipExcellent = 0.0;
            double scholarshipSocial = 0.0;

            if (excellentGradesScholarship)
            {
                scholarshipExcellent = Math.Floor(grades * 25);
            }
            if (socialScholarship)
            {
                scholarshipSocial = Math.Floor(minimumIncome * 0.35);
            }

            if (grades < 4.5 || (grades < 5.5 && income > minimumIncome))
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (grades >= 5.5 && scholarshipExcellent >= scholarshipSocial)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipExcellent:F0} BGN");
            }
            else if (socialScholarship && scholarshipExcellent < scholarshipSocial)
            {
                Console.WriteLine($"You get a Social scholarship {scholarshipSocial:F0} BGN");
            }
        }
    }
}
