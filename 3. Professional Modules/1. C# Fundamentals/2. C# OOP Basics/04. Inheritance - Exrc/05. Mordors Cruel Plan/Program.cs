using System;

class Program
{
    static void Main(string[] args)
    {
        string[] foodInput = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int happyness = 0;

        foreach (var food in foodInput)
        {
            switch (food)
            {
                case "cram":
                    happyness += 2;
                    break;
                case "lembas":
                    happyness += 3;
                    break;
                case "apple":
                    happyness++;
                    break;
                case "melon":
                    happyness++;
                    break;
                case "honeycake":
                    happyness += 5;
                    break;
                case "mushrooms":
                    happyness -= 10;
                    break;
                default:
                    happyness--;
                    break;
            }
        }

        string mood = string.Empty;

        if (happyness < -5)
        {
            mood = "Angry";
        }
        else if (happyness >= -5 && happyness <= 0)
        {
            mood = "Sad";
        }
        else if (happyness >= 1 && happyness <= 15)
        {
            mood = "Happy";
        }
        else if (happyness > 15)
        {
            mood = "JavaScript";
        }

        Console.WriteLine(happyness);
        Console.WriteLine(mood);

    }
}

