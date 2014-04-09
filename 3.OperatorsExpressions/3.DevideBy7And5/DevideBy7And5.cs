using System;

class DevideBy7And5
{
    static void Main()
    {
        int i;
        while (true)
        {
            Console.Write("Please enter an Integer number:");
            if (int.TryParse(Console.ReadLine(), out i))
                break;
            else Console.WriteLine("Incorrect data, please enter new number!");
        }
        bool dev = (i % 7 == 0) && (i % 5 == 0);
        {
            if (i == 0)
            Console.WriteLine("The entered number can be devided by 7 and 5 in the same time without reminder.\nFalse");
            else
            Console.WriteLine("The entered number can be devided by 7 and 5 in the same time without reminder.\n{0} ", dev);
        }
    }
}
