using System;

namespace GrupoIII
{
    public class Exercicio2
    {

        #region Exercicio 2 a

        public static void OlaPessoa()
        {
            Console.WriteLine("Introduza um nome.");
            var a = Console.ReadLine();
            Console.WriteLine($"Olá, {a}.");

        }

        #endregion

        #region Exercicio 2 b
        public static int QuantasPatas(int vacas, int porcos, int galinhas)
        {
            var total = vacas * 4 + porcos * 4 + galinhas * 2;
            //Console.WriteLine($"O número de patas total é {total}.");
            return total;
            
        }

        #endregion

        #region Exercicio 2 d

        public static void ParImpar()
        {
            Console.WriteLine("Introduza um número.");
            var a = Console.ReadLine();
            int n = Convert.ToInt32(a);

            if (n % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é impar.");
            }
        }


        #endregion

        #region Exercicio 2 e

        public static void Somar(int n1, int n2)
        {
            var sum = n1 + n2;
            if( n1 == n2)
            {
                Console.WriteLine(3 * sum);
            }
            else
            {
                Console.WriteLine(sum);
            }
        }

        #endregion

        #region Exercicio 2 f

        public static void Potencia(int num, int pot)
        {
            int num2=num;
            for (int i=1; i<pot; i++)
            {
                num2 = num2 * num;
            }
            Console.WriteLine(num2);
            
        }

        #endregion

        
    }
}
