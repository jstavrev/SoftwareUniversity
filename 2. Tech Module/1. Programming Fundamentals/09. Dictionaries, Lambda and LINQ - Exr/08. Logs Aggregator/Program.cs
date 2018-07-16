using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> logsInfo = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            string ip;
            string user;
            int time = 0;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                ip = input[0];
                user = input[1];
                time = int.Parse(input[2]);

                if (logsInfo.ContainsKey(user))
                {
                    if (logsInfo[user].ContainsKey(ip))
                    {
                        logsInfo[user][ip] += time;
                    }
                    else
                    {
                        logsInfo[user][ip] = time;
                    }
                }
                else
                {
                    Dictionary<string, int> assistDic = new Dictionary<string, int>();
                    assistDic.Add(ip, time);
                    logsInfo.Add(user, assistDic);
                }
            }
            List<string> printer = new List<string>();
            int totalTime = 0;
            foreach (var userLog in logsInfo.OrderBy(x => x.Key))
            {
                Console.Write($"{userLog.Key}: ");
                foreach (var pair in userLog.Value.OrderBy(x => x.Key))
                {
                    printer.Add(pair.Key);
                    totalTime += pair.Value;
                }
                Console.WriteLine($"{totalTime} [" + String.Join(", ", printer) + "]");
                totalTime = 0;
                printer.Clear();
            }
        }
    }
}
