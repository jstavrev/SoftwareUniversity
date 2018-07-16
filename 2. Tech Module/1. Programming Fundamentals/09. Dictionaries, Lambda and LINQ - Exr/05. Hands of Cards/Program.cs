using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> playersCards = new Dictionary<string, string>();
            List<string> input = new List<string>();
            List<string> pointCalc = new List<string>();
            List<int> result = new List<int>();
            List<string> inputCards = new List<string>();
            int value = 0;
            int sum = 0;
            while (true)
            {
                input = Console.ReadLine().Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input[0] == "JOKER")
                {
                    break;
                }
                inputCards = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int i = 0; i < inputCards.Count; i++)
                {
                    if (playersCards.ContainsKey(input[0]))
                        playersCards[input[0]] += " " + inputCards[i];
                    else
                        playersCards.Add(input[0], inputCards[i]);
                }
            }
            foreach (var player in playersCards)
            {
                pointCalc = player.Value.Split(' ').ToList();
                pointCalc = pointCalc.Distinct().ToList();
                foreach (var card in pointCalc)
                {
                    if (card[0] == 'J' || card[0] == 'Q' || card[0] == 'K' || card[0] == 'A' || card[0] == 1)
                    {
                        switch (card[0])
                        {
                            case (char)1: value = 10; break;
                            case 'J': value = 11; break;
                            case 'Q': value = 12; break;
                            case 'K': value = 13; break;
                            case 'A': value = 14; break;
                        }
                    }
                    else
                    {
                        value = int.Parse(card.Remove(card.Length - 1, 1));
                    }
                    if (card.Last() == 'S')
                        sum += value * 4;
                    else if (card.Last() == 'H')
                        sum += value * 3;
                    else if (card.Last() == 'D')
                        sum += value * 2;
                    else if (card.Last() == 'C')
                        sum += value * 1;
                }
                result.Add(sum);
                sum = 0;
            }
            for (int i = 0; i < playersCards.Count; i++)
            {
                Console.WriteLine("{0}: {1}", playersCards.ElementAt(i).Key, result[i]);
            }
        }
    }
}
