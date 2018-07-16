using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> usersInfo = new SortedDictionary<string, Dictionary<string, int>>();
            string userName = "";
            string userIp = "";

            while (true)
            {
                List<string> input = Console.ReadLine().Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input[0] == "end")
                    break;
                userName = input[5];
                userIp = input[1];

                if (usersInfo.ContainsKey(userName))
                {
                    if (usersInfo[userName].ContainsKey(userIp))
                    {
                        usersInfo[userName][userIp]++;
                    }
                    else
                    {
                        usersInfo[userName][userIp] = 1;
                    }
                }
                else
                {
                    Dictionary<string, int> assistDic = new Dictionary<string, int>();
                    assistDic.Add(userIp, 1);
                    usersInfo.Add(userName, assistDic);
                }
            }
            foreach (var user in usersInfo)
            {
                Console.WriteLine($"{user.Key}:");
                List<string> printList = new List<string>();
                foreach (var ip in user.Value)
                {
                    printList.Add($"{ip.Key} => {ip.Value}");
                }
                Console.WriteLine(String.Join(", ", printList) + ".");
            }
        }
    }
}
