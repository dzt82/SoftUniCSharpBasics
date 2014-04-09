using System;

class IsThirdDigit7
{
    static void Main()
    {
        int i;
        while (true)
        {
            Console.Write("Please enter an Integer number:");
            if (int.TryParse(Console.ReadLine(), out i))
                break;
            else Console.WriteLine("Incorrect data, please try again!");
        }
        {
            int third = (i / 100) % 10;
            bool is7 = (third == 7 || third == -7);
            Console.WriteLine("Is the third digit, from right-to-left of the entered nuber 7? {0}", is7);     
        }
    }
}
