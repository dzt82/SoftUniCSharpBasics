using System;

class Program
{
    static void Main()
    {
        float weight;
        while (true)
        {
            Console.Write("Please enter your weight in kgs. : ");
            if (float.TryParse(Console.ReadLine(), out weight) && weight > 0 && weight < 500)
                break;
            else Console.WriteLine("Incorrect data, please enter your weight again!");
        }
        Console.WriteLine("Your weight on the Moon would be {0} kgs." , weight*17/100);
    }
}
