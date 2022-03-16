using System;

namespace MyFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CountTo10();
            CountTo10();
        }

        /// <summary>
        /// Função conta de 1 a 10
        /// </summary>
        private static void CountTo10()
            {
                for (int i =1 ; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
    }
}
