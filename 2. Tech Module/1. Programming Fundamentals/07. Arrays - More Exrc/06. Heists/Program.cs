using System;
using System.Linq;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int loot = 0;
            int expenses = 0;
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "Jail")
                {
                    break;
                }
                string code = input[0];
                for (int i = 0; i < code.Length; i++)
                {
                    if (code[i] == '$')
                    {
                        loot += nums[1];
                    }
                    else if (code[i] == '%')
                    {
                        loot += nums[0];
                    }
                }
                expenses += int.Parse(input[1]);
            }
            if (loot >= expenses)
            {
                Console.WriteLine("Heists will continue. Total earnings: {0}.", loot - expenses);
            }
            else
            {
                Console.WriteLine("Have to find another job. Lost: {0}.", expenses - loot);
            }
        }
    }
}
