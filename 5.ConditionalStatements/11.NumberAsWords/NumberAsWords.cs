

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class SayNumbers
        {
        static void Main(string[] args)
        {
            string[] digits = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eignt", "Nine" };
            string[] digits2 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eignt", "nine" };
            Console.Write("Enter your number: ");
            string numberAsString = Console.ReadLine();
            int number;

            if (!int.TryParse(numberAsString, out number))
            {
                Console.WriteLine("Invalid type format.");
                return;
            }

            if (number < 0 || number > 999)
            {
                Console.WriteLine("Number should be in the range [0...999].");
                return;
            }

            if (number < 10)
            {
                Console.WriteLine(digits[number]);
            }
            
            if (number >= 10 && number < 20)
            {
                switch (number)
                {
                    case 10:
                        Console.WriteLine("Ten");
                        break;
                    case 11:
                        Console.WriteLine("Eleven");
                        break;
                    case 12:
                        Console.WriteLine("Twelve");
                        break;
                    case 13:
                        Console.WriteLine("Thirteen");
                        break;
                    case 15:
                        Console.WriteLine("Fifteen");
                        break;
                    default:
                        int lastDigit = number % 10;
                        Console.WriteLine(digits[lastDigit] + "teen");
                        break;
                }
            }
            else if (number >= 20 && number < 100)
            {
                int secondDigit = number % 10;
                number /= 10;
                int firstDigit = number % 10;
                switch (firstDigit)
                {
                    case 2:
                        if (secondDigit == 0) Console.WriteLine("Twenty");
                        else Console.WriteLine("Twenty {0}", digits2[secondDigit]);
                        break;
                    case 3:
                        if (secondDigit == 0) Console.WriteLine("thirty");
                        else Console.WriteLine("Thirty {0}", digits2[secondDigit]);
                        break;
                    case 5:
                        if (secondDigit == 0) Console.WriteLine("fifty");
                        else Console.WriteLine("Fifty {0}", digits2[secondDigit]);
                        break;
                    default:
                        if (secondDigit == 0) Console.WriteLine("{0}ty", digits[firstDigit]);
                        else Console.WriteLine("{0}ty {1}", digits[firstDigit], digits2[secondDigit]);
                        break;
                }
            }
            else if (number > 99)
            {
                int thirdDigit = number % 10;
                number /= 10;
                int secondDigit = number % 10;
                number /= 10;
                int firstDigit = number % 10;

                if (secondDigit == 0 && thirdDigit == 0) Console.WriteLine("{0} hundred", digits[firstDigit]);
                else
                {
                    switch (secondDigit)
                    {
                        case 0:
                            Console.WriteLine("{0} hundred and {1}", digits[firstDigit], digits2[thirdDigit]);
                            break;
                        case 1:
                            switch (thirdDigit)
                            {
                                case 0:
                                    Console.WriteLine("{0} hundred and ten", digits[firstDigit]);
                                    break;
                                case 1:
                                    Console.WriteLine("{0} hundred and eleven", digits[firstDigit]);
                                    break;
                                case 2:
                                    Console.WriteLine("{0} hundred and twelve", digits[firstDigit]);
                                    break;
                                case 3:
                                    Console.WriteLine("{0} hundred and thirteen", digits[firstDigit]);
                                    break;
                                case 5:
                                    Console.WriteLine("{0} hundred and fifteen", digits[firstDigit]);
                                    break;
                                default:
                                    Console.WriteLine("{0} hundred and {1}teen", digits[firstDigit], digits2[thirdDigit]);
                                    break;
                            }
                            break;
                        case 2:
                            if (thirdDigit == 0) Console.WriteLine("{0} hundred and twenty", digits[firstDigit]);
                            else Console.WriteLine("{0} hundred twenty {1}", digits[firstDigit], digits2[thirdDigit]);
                            break;
                        case 3:
                            if (thirdDigit == 0) Console.WriteLine("{0} hundred and thirty", digits[firstDigit]);
                            else Console.WriteLine("{0} hundred thirty {1}", digits[firstDigit], digits2[thirdDigit]);
                            break;
                        case 5:
                            if (thirdDigit == 0) Console.WriteLine("{0} hundred and fifty", digits[firstDigit]);
                            else Console.WriteLine("{0} hundred fifty {1}", digits[firstDigit], digits2[thirdDigit]);
                            break;
                        default:
                            if (thirdDigit == 0) Console.WriteLine("{0} hundred and {1}ty ", digits[firstDigit], digits2[secondDigit]);
                            else Console.WriteLine("{0} hundred {1}ty {2}", digits[firstDigit], digits2[secondDigit], digits2[thirdDigit]);
                            break;
                    }
                }
            }
        }
    }

