using System;

namespace MyFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux = Console.ReadLine();
            int nCount = Convert.ToInt32(aux);
            CountToN(nCount);
            CountToN(nCount);
            
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
        private static void CountToN(int n)
        {
            for (int i=1 ; i <= n; i ++)
            Console.WriteLine(i);
        }
        
    }
}
