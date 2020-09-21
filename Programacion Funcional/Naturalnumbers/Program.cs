using System;

namespace Naturalnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
			static int printNatural(int stval, int ctr)
			{
				if (ctr < 1)
				{
					return stval;
				}
				ctr--;
				Console.Write(" {0} ", stval);
				return printNatural(stval + 1, ctr);
			}
		
			{
				Console.Write("\n\n Numeros naturales :  \n");
				Console.Write("---------------------------------------------------\n");
				Console.Write(" Cuantos numeros quieres mostrar?: ");
				int ctr = Convert.ToInt32(Console.ReadLine());
				// Call recursive method with two parameters.	
				printNatural(1, ctr);
				Console.Write("\n\n");
			}
		}
	}

    }

