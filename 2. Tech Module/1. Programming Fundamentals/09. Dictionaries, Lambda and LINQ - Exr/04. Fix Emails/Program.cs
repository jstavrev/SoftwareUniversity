using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();

            while (true)
            {
                string emailOwner = Console.ReadLine();
                if (emailOwner == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();
                if (email.Last() != 's' && email.Last() != 'k')
                {
                    emails.Add(emailOwner, email);
                }
            }
            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
