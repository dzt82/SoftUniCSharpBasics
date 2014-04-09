using System;

class ExchangeVarValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("The initial values of 'a' and 'b' are a= {0} and b= {1}" , a, b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("The value of 'a' and 'b' after the exchange are a= {0} and b= {1}" , a, b);
    }
}
