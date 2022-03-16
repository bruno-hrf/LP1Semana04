using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux = Console.ReadLine();
            
        }

        private static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            
            return Fibonacci(n-1) + Fibonacci(n-2);

        }




    }
}
