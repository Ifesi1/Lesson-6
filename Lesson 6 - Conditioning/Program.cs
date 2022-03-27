using System;

namespace Lesson_6___Conditioning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The given quadratic equation is: ");
            Console.WriteLine("X^2 + 6X + 5 = 0");
            int a = 1;
            int b = 6;
            int c = 5;

            if ((Math.Pow(b,2))-(4*a*c)>0)
            {
                Console.WriteLine("Real roots");
            }
            else if ((Math.Pow(b, 2)) - (4 * a * c) < 0)
            {
                Console.WriteLine("Complex Roots");
            }
            else
            {
                Console.WriteLine("Equal Roots");
            }
            Console.WriteLine();
        }
    }
}
