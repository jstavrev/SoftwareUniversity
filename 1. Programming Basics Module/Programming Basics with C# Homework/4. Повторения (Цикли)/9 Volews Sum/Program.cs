using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Volews_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string volews = Console.ReadLine();

            int bonusPoints = 0;
           
            for (int i = 0; i < volews.Length; i++)
            {
               if (volews[i] == 'a')
                {
                    bonusPoints = bonusPoints + 1;
                }
                if (volews[i] == 'e')
                {
                    bonusPoints = bonusPoints + 2;
                }
                if (volews[i] == 'i')
                {
                    bonusPoints = bonusPoints + 3;
                }
                if (volews[i] == 'o')
                {
                    bonusPoints = bonusPoints + 4;
                }
                if (volews[i] == 'u')
                {
                    bonusPoints = bonusPoints + 5;
                }

            }
            Console.WriteLine(bonusPoints);
            
        }
    }
}
