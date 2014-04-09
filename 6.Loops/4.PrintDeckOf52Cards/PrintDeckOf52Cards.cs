using System;

class PrintDeckOf52Cards
{
    static void Main()
    {
        string[] cards = { " 2", " 3", " 4", " 5", " 6", " 7", " 8", " 9", "10", " J", " Q", " K", " A" };
        int[] colors = { 5, 4, 3, 6 };

        foreach (var card in cards)
        {
            foreach (var color in colors) 
            {
                Console.Write(card);
                Console.Write((char)color + " ");
            }
            {
                Console.WriteLine();
            }
        }
    }
}


