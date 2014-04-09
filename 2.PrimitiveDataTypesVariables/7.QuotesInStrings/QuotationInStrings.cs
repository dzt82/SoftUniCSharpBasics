using System;

class QuotationInStrings
{
    static void Main()
    {
        string quotation1 = @"The ""use"" of quotations causes difficulties.";
        string quotation2 = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(quotation1 + '\n' + quotation2);
    }
}