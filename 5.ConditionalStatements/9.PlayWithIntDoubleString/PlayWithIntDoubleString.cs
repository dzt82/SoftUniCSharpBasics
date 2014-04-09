using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        int type;
        while (true)
        {
            Console.Write("Plese choose a type: \n 1 --> int \n 2 --> double \n 3 --> string \n Type = ");
            if ((int.TryParse(Console.ReadLine(), out type) && (type >=1) && (type<= 3)))
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }

        switch (type)
        {
            case 1:
                int i;
                Console.WriteLine("Please enter an integer number");
                int.TryParse(Console.ReadLine(), out i);
                Console.WriteLine(i+1);
                break;
            case 2:
                double d;
                Console.WriteLine("Please enter a double number");
                double.TryParse(Console.ReadLine(), out d);
                Console.WriteLine(d+1);
                break;
            default:
                Console.WriteLine("Please enter a string");
                string word = Console.ReadLine();
                Console.WriteLine("{0}*", word);
                break;
        }
    }
}
