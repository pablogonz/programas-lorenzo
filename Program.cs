using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Collections;
using System.Globalization;
namespace CreacionesGrupos
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Listado, Listado1, Listado2;
            String[][] Lista;

            Int32 lineas = File.ReadAllLines("Estudiantes.txt").Length;
            String[] Estudiantes = new string[lineas];

            Listado = new string[lineas];

            for (Int32 i = 0; i < lineas; i++)
            {
                String vLin = File.ReadLines("Estudiantes.txt").Skip(i).Take(1).First();
                Listado[i] = vLin;

            }
            for (Int32 i = 0; i < lineas; lineas--)
            {
                Random aleatorio = new Random();
                Int32 numerito = aleatorio.Next(0, (lineas));

                Estudiantes[lineas - 1] = Listado[numerito];
                Listado = Listado.Except(new string[] { Listado[numerito] }).ToArray();

            }

            Int32 lineas1 = File.ReadAllLines("Grupos.txt").Length;
            String[] Grupos = new string[lineas1];
            Listado1 = new string[lineas1];
            Lista = new string[lineas1][];

            for (Int32 i = 0; i < lineas1; i++)
            {
                Lista[i] = new string[256];
            }

            for (Int32 i = 0; i < lineas1; i++)
            {
                String vLin1 = File.ReadLines("Grupos.txt").Skip(i).Take(1).First();
                Listado1[i] = vLin1;

            }
            for (Int32 i = 0; i < lineas1; lineas1--)
            {
                Random aleatorio = new Random();
                Int32 numerito = aleatorio.Next(0, (lineas1));

                Grupos[lineas1 - 1] = Listado1[numerito];
                Listado1 = Listado1.Except(new string[] { Listado1[numerito] }).ToArray();

            }

            Int32 lineas2 = File.ReadAllLines("Temas.txt").Length;
            String[] Temas = new string[lineas2];
            Listado2 = new string[lineas2];


            for (Int32 i = 0; i < lineas2; i++)
            {
                String vLin2 = File.ReadLines("Temas.txt").Skip(i).Take(1).First();
                Listado2[i] = vLin2;

            }
            for (Int32 i = 0; i < lineas2; lineas2--)
            {
                Random aleatorio = new Random();
                Int32 numerito = aleatorio.Next(0, (lineas2));

                Temas[lineas2 - 1] = Listado2[numerito];
                Listado2 = Listado2.Except(new string[] { Listado2[numerito] }).ToArray();

            }

            int n = 0;
            string[,] tabla = new string[Convert.ToInt32(2 + Math.Ceiling((Convert.ToDouble(Estudiantes.Length) / Grupos.Length))), Grupos.Length];
            for (int j = 0; j < Grupos.Length; j++)
            {
                tabla[0, j] = Grupos[j];
            }
            for (int j = 0; j < Temas.Length; j++)
            {
                tabla[1, j] = Temas[j];
            }
            for (int i = 2; i < tabla.GetLength(0); i++)
            {
                for (int j = 0; j < tabla.GetLength(1); j++)
                {
                    if (n < Estudiantes.Length)
                    {
                        tabla[i, j] = Estudiantes[n];
                        n++;
                    }
                    else
                    {
                        tabla[i, j] = null;
                    }
                }

            }
            for (int j = 0; j < tabla.GetLength(1); j++)
            {
                Console.WriteLine(tabla[0, j]);
                Console.WriteLine("Tema: " + tabla[1, j]);
                Console.WriteLine("Miembros:");
                for (int i = 2; i < tabla.GetLength(0); i++)
                {
                    Console.WriteLine(tabla[i, j]);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
