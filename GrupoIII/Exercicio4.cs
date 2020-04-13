using System;

namespace GrupoIII
{
    public class Exercicio4
    {

        #region Exercicio 4 a
        public static void Calculadora()
        {
            Console.WriteLine("Primeiro número.");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundo número.");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduza uma operação.");
            var op = Console.ReadLine();

            
            switch (op)
            {
                case "+":
                    Console.WriteLine("O resultado de "+a+" + "+b +" é " + (a + b));
                    break;
                case "-":
                    Console.WriteLine("O resultado de " + a + " - " + b + " é " + (a - b));
                    break;
                case "*":
                    Console.WriteLine("O resultado de " + a + " * " + b + " é " + (a * b));
                    break;
                case "/":
                    Console.WriteLine("O resultado de " + a + " / " + b + " é " + (a / b));
                    break;
                case "%":
                    Console.WriteLine("O resultado de " + a + " % " + b + " é " + (a % b));
                    break;

            }

        }

        #endregion

        #region Exercicio 4 b

        public static void Calculadora2()
        {
            Console.WriteLine("Primeiro número.");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundo número.");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduza uma operação.");
            var op = Console.ReadLine();

            try
            {
                ValidarInput(a, b, op);

                switch (op)
                {
                    case "+":
                        Console.WriteLine("O resultado de " + a + " + " + b + " é " + (a + b));
                        break;
                    case "-":
                        Console.WriteLine("O resultado de " + a + " - " + b + " é " + (a - b));
                        break;
                    case "*":
                        Console.WriteLine("O resultado de " + a + " * " + b + " é " + (a * b));
                        break;
                    case "/":
                        Console.WriteLine("O resultado de " + a + " / " + b + " é " + (a / b));
                        break;
                    case "%":
                        Console.WriteLine("O resultado de " + a + " % " + b + " é " + (a % b));
                        break;

                }
            }
            catch (InvalidOperationException) { Console.WriteLine("Inválido"); }
            catch (DivideByZeroException) { Console.WriteLine("Tentou dividir por zero."); }
            catch (ArgumentOutOfRangeException) { Console.WriteLine("Argumento fora dos limites."); }
            catch (ArithmeticException) { Console.WriteLine("Excepção aritmética."); }
        }

        #endregion



        private static void ValidarInput(int a, int b, string opt)
        {
            var op = opt[0];
            if(op != '+' && op != '-' && op != '*' && op != '/' && op != '%' ) throw new InvalidOperationException();
            if (op == '/'  && b == 0) throw new DivideByZeroException();
            if(a<0 || a > 100 || b<0 || b >100) throw new ArgumentOutOfRangeException();
            if(a%5==0 || b%3==0) throw new ArithmeticException();
        }

        private static void ValidarInput(int a, int b, char op)
        {
           
            if (op != '+' || op != '-' || op != '*' || op != '/' || op != '%') throw new InvalidOperationException();
            if (b == 0) throw new DivideByZeroException();
            if (a < 0 || a > 100 || b < 0 || b > 100) throw new ArgumentOutOfRangeException();
            if (a % 5 == 0 || b % 3 == 0) throw new ArithmeticException();
        }
    }
}
