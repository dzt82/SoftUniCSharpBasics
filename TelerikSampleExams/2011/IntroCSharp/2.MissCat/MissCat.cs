﻿using System;

class MissCat
{
    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());
        uint cat1 = 0, cat2 = 0, cat3 = 0, cat4 = 0, cat5 = 0, cat6 = 0, cat7 = 0, cat8 = 0, cat9 = 0, cat10 = 0;

        for (int i = 1; i <= N; i++)
        {
           byte cat = byte.Parse(Console.ReadLine());
           switch (cat)
           {
               case 1:
                   cat1++;
                   break;
               case 2:
                   cat2++;
                   break;
               case 3:
                   cat3++;
                   break;
               case 4:
                   cat4++;
                   break;
               case 5:
                   cat5++;
                   break;
               case 6:
                   cat6++;
                   break;
               case 7:
                   cat7++;
                   break;
               case 8:
                   cat8++;
                   break;
               case 9:
                   cat9++;
                   break;
               default:
                   cat10++;
                   break;
           }
        }
        if (cat1 >= cat2 && cat1 >= cat3 && cat1 >= cat4 && cat1 >= cat5 && cat1 >= cat6 && cat1 >= cat7 && cat1 >= cat8 && cat1 >= cat9 && cat1 >= cat10)
        Console.WriteLine(1);
        else if (cat2 > cat1 && cat2 >= cat3 && cat2 >= cat4 && cat2 >= cat5 && cat2 >= cat6 && cat2 >= cat7 && cat2 >= cat8 && cat2 >= cat9 && cat2 >= cat10)
            Console.WriteLine(2);
        else if (cat3 > cat2 &&  cat3 >= cat4 && cat3 >= cat5 && cat3 >= cat6 && cat3 >= cat7 && cat3 >= cat8 && cat3 >= cat9 && cat3 >= cat10)
            Console.WriteLine(3);
        else if (cat4 > cat3 &&   cat4 >= cat5 && cat4 >= cat6 && cat4 >= cat7 && cat4 >= cat8 && cat4 >= cat9 && cat4 >= cat10)
            Console.WriteLine(4);
        else if (cat5 > cat4 && cat5 >= cat6 && cat5 >= cat7 && cat5 >= cat8 && cat5 >= cat9 && cat5 >= cat10)
            Console.WriteLine(5);
        else if (cat6 > cat5 && cat6 >= cat7 && cat6 >= cat8 && cat6 >= cat9 && cat6 >= cat10)
            Console.WriteLine(6);
        else if (cat7 > cat6 && cat7 >= cat8 && cat7 >= cat9 && cat7 >= cat10)
            Console.WriteLine(7);
        else if (cat8 > cat7 && cat8 >= cat9 && cat8 >= cat10)
            Console.WriteLine(8);
        else if (cat9 > cat8 && cat9 >= cat10)
            Console.WriteLine(9);
        else
            Console.WriteLine(10);
    }
}
