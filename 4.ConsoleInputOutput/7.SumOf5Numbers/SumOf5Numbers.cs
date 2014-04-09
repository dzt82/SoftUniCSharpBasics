using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Please enter five numbers separated by space and then press 'Enter': ");
        string[] Input = Console.ReadLine().Split();
        double numb1 = Convert.ToDouble(Input[0]);
        double numb2 = Convert.ToDouble(Input[1]);
        double numb3 = Convert.ToDouble(Input[2]);
        double numb4 = Convert.ToDouble(Input[3]);
        double numb5 = Convert.ToDouble(Input[4]);
        double sum = numb1 + numb2 + numb3 + numb4 + numb5;
        Console.WriteLine("The sum is: {0}", sum);
    }
}

