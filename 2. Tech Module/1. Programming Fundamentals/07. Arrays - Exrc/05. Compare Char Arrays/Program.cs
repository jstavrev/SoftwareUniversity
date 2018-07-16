using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string text1 = Console.ReadLine();
            string trimedText = text.Replace(" ", "");
            string trimedText1 = text1.Replace(" ", "");
            char[] arr = new char[text.Length];
            char[] arr1 = new char[text1.Length];
            bool arrCheck = false;
            bool arr1Check = false;

            for (int i = 0; i < text.Length; i++)
            {
                arr[i] = text[i];
            }
            for (int i = 0; i < text1.Length; i++)
            {
                arr1[i] = text1[i];
            }

            int limit = Math.Min(arr.Length, arr1.Length);

            for (int i = 0; i < limit; i++)
            {
                if (arr[i] == arr1[i])
                {
                    continue;
                }
                if (arr[i] < arr1[i])
                {
                    arrCheck = true;
                    break;
                }
                else
                {
                    arr1Check = true;
                    break;
                }
            }
            if (arrCheck == false && arr1Check == false)
            {
                if (arr.Length < arr1.Length)
                {
                    Console.WriteLine(trimedText);
                    Console.WriteLine(trimedText1);
                }
                else
                {
                    Console.WriteLine(trimedText1);
                    Console.WriteLine(trimedText);
                }
            }
            if (arrCheck)
            {
                Console.WriteLine(trimedText);
                Console.WriteLine(trimedText1);
            }
            else if (arr1Check)
            {
                Console.WriteLine(trimedText1);
                Console.WriteLine(trimedText);
            }
        }
    }
}
