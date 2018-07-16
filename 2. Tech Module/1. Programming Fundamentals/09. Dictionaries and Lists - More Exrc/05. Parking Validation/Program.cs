using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string licensePlate = "";
            Dictionary<string, string> registeredParking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                if (input[0] == "register")
                {
                    licensePlate = input[2];
                }
                bool licensePlateCheck = (licensePlate.Length == 8) && ((licensePlate[2] >= 48 && licensePlate[2] <= 57) && (licensePlate[3] >= 48 && licensePlate[3] <= 57)
                    && (licensePlate[4] >= 48 && licensePlate[4] <= 57) && (licensePlate[5] >= 48 && licensePlate[5] <= 57)) && ((licensePlate[0] >= 65 && licensePlate[0] <= 90) 
                    && (licensePlate[1] >= 65 && licensePlate[1] <= 90) && (licensePlate[6] >= 65 && licensePlate[6] <= 90) && (licensePlate[7] >= 65 && licensePlate[7] <= 90));
                if (input[0] == "register")
                {
                    if (registeredParking.ContainsKey(input[1]))
                        Console.WriteLine($"ERROR: already registered with plate number {registeredParking[input[1]]}");
                    else if (!(licensePlateCheck))
                        Console.WriteLine($"ERROR: invalid license plate {input[2]}");
                    else if (registeredParking.ContainsValue(input[2]))
                        Console.WriteLine($"ERROR: license plate {input[2]} is busy");
                    else
                    {
                        Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                        registeredParking.Add(input[1], input[2]);
                    }
                }
                else
                {
                    if (!(registeredParking.ContainsKey(input[1])))
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    else
                    {
                        Console.WriteLine($"user {input[1]} unregistered successfully");
                        registeredParking.Remove(input[1]);
                    }
                }
            }
            foreach (var user in registeredParking)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
