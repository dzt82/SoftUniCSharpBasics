using System;
using System.Text;

class AsciiTable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; //switch to UTF8 encoding
        for (int i = 0; i < 256; i++ )
        {
             Console.WriteLine("ASCI code " + i + "-> " + (char)i);
        }
    }
}
