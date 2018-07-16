using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string endCheck = "";
            while (true)
            {
                string[] commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commands[0] == "Even")
                {
                    endCheck = commands[0];
                    break;
                }
                else if (commands[0] == "Odd")
                {
                    endCheck = commands[0];
                    break;
                }
                if (commands[0] == "Delete")
                {
                    nums.RemoveAll(item => item == int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    nums.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }
            }
            if (endCheck == "Even")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (i == nums.Count - 1)
                    {
                        if (nums[i] % 2 == 0)
                        {
                            Console.WriteLine(nums[i]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            break;
                        }
                    }
                    if (nums[i] % 2 == 0)
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
            }
            else
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (i == nums.Count - 1)
                    {
                        if (nums[i] % 2 != 0)
                        {
                            Console.WriteLine(nums[i]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            break;
                        }
                    }
                    if (nums[i] % 2 != 0)
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
            }
        }
    }
}
