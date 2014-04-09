using System;

class StringsConcatenation
{
    static void Main()
    {
        string s1 = "Hello";
        string s2 = "World";
        object obj1 = (s1 + " " + s2);
        string s3 =  (string)obj1;
        Console.WriteLine(s3);
    }
}

