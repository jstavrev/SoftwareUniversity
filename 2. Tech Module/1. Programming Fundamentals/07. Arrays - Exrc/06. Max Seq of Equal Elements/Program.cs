using System;
using System.Linq;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // Vzimam array ot integeri.
            int start = 0; //Zadavam variable, koito shte zapazva nachaloto na vseki sequence.
            int length = 1; //Zadavam variable, koito shte zapazva duljinata na vseki sequence.
            int bestStart = 0; //Zadavam variable, koito she zapazva nachaloto na nai golemiq sequence za momenta.
            int bestLen = 1; //Zadavam variable, koito she zapazva duljinata na nai golemiq sequence za momenta.

            for (int i = 1; i < nums.Length; i++) //Cikul s koito shte obhodq vsichkite elementi na masiva, trugvaiki ot vtoriq zashtoto purviq e nachaloto na purviq sequence.
            {
                if (nums[i] == nums[i - 1]) //Sravnqvam vseki element ot masiva sus predishniq, i ako sa ednakvi duljinata na tekushtiq sequence se uvliechava s 1.
                {
                    length++;
                }
                else //Ako ne sa ravni, zapochvam nov sequence zadavaiki nova startova poziciq, i length se vrushta na 1.
                {
                    start = i;
                    length = 1;
                }
                if (length > bestLen) //Ako lengtha na tekushtiq sequence e po dulug ot lengtha na predishniq best sequence, tekushtiq sequence stava best sequenc-a.
                {
                    bestLen = length;
                    bestStart = start;
                }
            }
            for (int i = bestStart; i < bestStart + bestLen; i++) // Printiram rezultata.
            {
                Console.Write(nums[bestStart] + " ");
            }
            Console.WriteLine();

        }
    }
}
