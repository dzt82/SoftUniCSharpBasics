using System;

class FourDigitNumber
{
    static void Main()
    {
        int i;
        while (true)
        {
            Console.Write("Please enter a four-digit Integer number: ");
            if (int.TryParse(Console.ReadLine(), out i) && i.ToString().Length == 4 && i > 0)
                break;
            else Console.WriteLine("Incorrect data, please enter new number!");
        }
        {
            int digit1 = i%10;
            int digit2 = (i%100 - i%10)/10;
            int digit3 = (i%1000-i%100)/100;
            int digit4 = (i-i%1000)/1000;
            int digitsum = digit4 + digit3 + digit2 + digit1;
            Console.WriteLine("The sum of all the digits of the entered number is: {0}" ,digitsum);
            Console.WriteLine("The reversed number is: {0}{1}{2}{3}" , digit1, digit2, digit3, digit4);
            Console.WriteLine("The number with last digit in front is: {0}{1}{2}{3}" , digit1, digit4, digit3, digit2);
            Console.WriteLine("The number with second and third digits exchanged is: {0}{1}{2}{3}", digit4, digit2, digit3, digit1);
        }
    }
}