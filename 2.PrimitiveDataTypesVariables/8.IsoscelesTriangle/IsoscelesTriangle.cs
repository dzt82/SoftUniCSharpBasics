using System;
using System.Text; //for displaing the copyright symbol

class IsoscalesTriangle
{
    static void Main()
    {
        char copyRight = '\u00A9'; //the copyright symbol
        Console.OutputEncoding = Encoding.UTF8; //switch to UTF8 encoding
        byte space = 3; //begin with 3 spaces
        for (int i = 0; i < 3; i++)
        {
            for (int spacesLeft = 0; spacesLeft < space; spacesLeft++) //spaces on the left
            {
                Console.Write(" ");
            }
                 for (int printCR = 0; printCR <= i; printCR++) //print the symbol
            {
                Console.Write(copyRight);
            }
                             for (int spacesRight = 0; spacesRight < i; spacesRight++)//spaces on the right
            {
                Console.Write(copyRight);
            }
            Console.WriteLine();
            space--;
        }
    }
}

