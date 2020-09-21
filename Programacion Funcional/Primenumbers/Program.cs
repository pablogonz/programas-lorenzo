using System;

namespace Primenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
			static int printprime(int inicio, int limite)
			{
				if (limite < 1)
				{
					return inicio;
				}
				limite--;
				Console.Write(" {0} ", inicio);
				return printprime(inicio + 2, limite);
			}

			{
			
				Console.Write("\n\n Numeros primos :  \n");
			
				Console.Write(" Cuantos numeros quieres mostrar?: ");
				int limite = Convert.ToInt32(Console.ReadLine());
				
				printprime(1, limite);
				Console.Write("\n\n");
			}
		}
	}
    }

