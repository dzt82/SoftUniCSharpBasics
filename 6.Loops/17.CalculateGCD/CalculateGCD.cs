using System;

class CalculateGCD
{
    static void Main()
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int remain = 1;
                while (remain != 0)
                {
                    remain = a % b;
                    a = b;
                    b = remain;    
                }
                Console.WriteLine(Math.Abs(a));
            }

}

//using System;

//class CalculateGCD
//{
//    static void Main()
//    {
//        int a = int.Parse(Console.ReadLine());
//        int b = int.Parse(Console.ReadLine());
//        a = Math.Abs(a);
//        b = Math.Abs(b);
//        int rem = 1;

//        if (b > a)
//        {
//            a = a + b;
//            b = a - b;
//            a = a - b;
//        }

//        while (rem != 0)
//        {
//            rem = a % b;
//            if (rem == 0)
//            {
//                Console.WriteLine(b);
//            }
//            else if (rem != 0)
//            {
//                a = a + b;
//                b = a - b;
//                a = a - b;
//                b = b + rem;
//                rem = b - rem;
//                b = b - rem;
//            }
//        }
//}
//}


