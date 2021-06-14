using System;

namespace Binary_test
{
    class Program
    {
        static int aaaa(int h)
        {
           return h*5;
        }
        static int Binary(int decimalnumber)
        {
            int remainder;
            string result = string.Empty;
            while (decimalnumber > 0)
            {
                remainder = decimalnumber % 2;
                decimalnumber /= 2;
                result = remainder.ToString() + result;

            }
            return int.Parse(result);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int decimalnumber, yn;
                {
                    Console.Write("Decimal: ");
                    decimalnumber = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Binary: {0}", Binary(decimalnumber));

                Console.WriteLine();
                {
                    Console.Write("Do You Want To Continue?  [Y] [N] ");
                    yn = Convert.ToChar(Console.ReadLine());
                    if (yn == 'y' | yn == 'Y')
                    {
                        Console.WriteLine();
                        continue;
                    }
                    else if (yn == 'n' | yn == 'N')
                    {
                        break;
                    }
                    else
                    { 
                        break;
                    }
                }
            }
             
        }
    }
}
