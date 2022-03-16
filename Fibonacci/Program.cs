using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux = Console.ReadLine();
            int nCount = Convert.ToInt32(aux);
            Console.WriteLine(Fibonacci(nCount));
            
        }


        private static int Fibonacci(int n)
        {
            if (n <=1)
            {
                return n;
            }

            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            
        }




    }
}
