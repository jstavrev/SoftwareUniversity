﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPassword= Console.ReadLine();

            if (inputPassword == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
