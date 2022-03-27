using System;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uisng this formula below, input your values accordingly: ");
            Console.WriteLine("A^2 + BX + C = 0");

            Console.Write("Please enter a value for A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Please enter a value for B: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Please enter a value for C: ");
            int C = int.Parse(Console.ReadLine());

            if ((Math.Pow(B,2))-(4*A*C)>0)
            {
                Console.WriteLine("Real roots");
            }
            else if ((Math.Pow(B, 2)) - (4 * A * C) < 0)
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
