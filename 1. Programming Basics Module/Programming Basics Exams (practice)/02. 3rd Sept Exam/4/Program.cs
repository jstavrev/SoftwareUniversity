using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int piecesCake = width * height;

            while (piecesCake >= 0)
            {
                string piecesEaten = Console.ReadLine();
                if (piecesEaten == "STOP")
                {
                    break;
                }
                else
                {
                    int piecesTaken = Convert.ToInt32(piecesEaten);
                    piecesCake -= piecesTaken;
                }
            }
            if (piecesCake >= 0)
            {
                Console.WriteLine($"{piecesCake} pieces are left.");
            }
            else
            {
                Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(piecesCake));
            }
        }
    }
}
