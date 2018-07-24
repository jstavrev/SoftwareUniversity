using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int[] rectangleInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        Rectangle rectangle = new Rectangle(rectangleInput[0], rectangleInput[1], rectangleInput[2], rectangleInput[3]);
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int[] pointInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point = new Point(pointInput[0], pointInput[1]);

            bool checkIfRectangleContainsPoint = rectangle.Contains(point);
            Console.WriteLine(checkIfRectangleContainsPoint);
        }
    }
}

