using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// Recebe 2 numeros, depois faz a contagem do 1º até o 2º.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string aux = Console.ReadLine();
            int nCount = Convert.ToInt32(aux);
            string aux2 = Console.ReadLine();
            int nCount2 = Convert.ToInt32(aux2);
            CountToN(nCount, nCount2);
            
            
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

        /// <summary>
        /// Counta de n1 até n2
        /// </summary>
        /// <param name="n1">
        /// numero onde começa
        /// </param>
        /// <param name="n2">
        /// numero onde acaba
        /// </param>
        private static void CountToN(int n1 , int n2)
        {
            for (int i=n1 ; i <= n2; i ++)
            Console.WriteLine(i);
        }
        
    }
}
