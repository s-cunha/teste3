using System;

namespace GrupoIII
{
    public class Exercicio3
    {

        #region Exercicio 3 a
        public static void FazTabela()
        {
            Console.WriteLine("Quantas linhas?");
            var l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantas Colunas?");
            var c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a letra?");
            var letra = Console.ReadLine();

            int i;
            int j;

            for (i = 0; i < l; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write(letra+" ");
                }
                Console.WriteLine("\n");
            }

        }

        #endregion

        #region Exercicio 3 b 
        
        public static void Multiplo3e7(int n)
        {
            if (n % 3 == 0 && n % 7 == 0) { Console.WriteLine("É multiplo de 3 e 7."); }
            if (n % 3 == 0 && n % 7 != 0) { Console.WriteLine("É multiplo de 3."); }
            if (n % 3 != 0 && n % 7 == 0) { Console.WriteLine("É multiplo de 7."); }
            if (n % 3 != 0 && n % 7 != 0) { Console.WriteLine("Não é multiplo de 3 nem de 7."); }
        }

        #endregion

        #region Exercicio 3 c

        public static void Fatorial()
        {
            Console.WriteLine("Introduz um número.");
            var n = Convert.ToInt32(Console.ReadLine());
            CalculoFatorial(n);
        }

        public static void CalculoFatorial(int num)
        {
            int num2 = num;
            for (int i = 1; i < num; i++)
            {
                num = num - 1;
                num2 = num2 * num;
            }
            Console.WriteLine(num2);
        }

        #endregion
    }
}
