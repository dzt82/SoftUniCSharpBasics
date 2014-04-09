using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? i = null;
        double? d = null;
        Console.WriteLine("Printing null variables: {0} \n{1}", i, d);
        i = i + null;
        d = d + 365;
        Console.WriteLine("Printing null variables after summing: {0} \n{1}", i, d);
    }
}
