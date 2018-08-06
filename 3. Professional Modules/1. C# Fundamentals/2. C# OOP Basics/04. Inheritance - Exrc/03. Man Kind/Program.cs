using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] studentInput = Console.ReadLine().Split().ToArray();
        string[] workerInput = Console.ReadLine().Split().ToArray();

        try
        {
            Student student = new Student(studentInput[0], studentInput[1], studentInput[2]);
            Worker worker = new Worker(workerInput[0], workerInput[1], decimal.Parse(workerInput[2]), decimal.Parse(workerInput[3]));

            Console.WriteLine(student.ToString());
            Console.WriteLine();
            Console.WriteLine(worker.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
        }
    }
}

