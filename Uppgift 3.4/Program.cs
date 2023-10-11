using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hur lång är låten?");
        string input = Console.ReadLine();
        int mellanSlagIndex = input.IndexOf(" ");
        int min = int.Parse(input[..mellanSlagIndex]);
        int sek = int.Parse(input[(mellanSlagIndex + 1)..]);
        int totalSek = (min * 60) + sek;

        if (totalSek > 165 && totalSek < 260)
        {
            Console.WriteLine("Låten får spelas!");
        }
        else
        {
            Console.WriteLine("Låten får inte spelas!");
        }
    }
}
