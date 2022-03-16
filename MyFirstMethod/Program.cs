using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// Recebe 2 numeros, depois faz a contagem de 1 até esses numeros.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string aux = Console.ReadLine();
            int nCount = Convert.ToInt32(aux);
            string aux2 = Console.ReadLine();
            int nCount2 = Convert.ToInt32(aux2);
            CountToN(nCount);
            CountToN(nCount2);
            
        }

        /// <summary>
        /// Função conta de 1 a 10
        /// </summary>
        private static void CountTo10()
            {
                CountToN (10);
            }


        /// <summary>
        /// Função conta de 1 até n
        /// </summary>
        /// <param name="n">
        /// valor inteiro
        /// </param>
        private static void CountToN(int n)
        {
            for (int i=1 ; i <= n; i ++)
            Console.WriteLine(i);
        }
        
    }
}
