using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Sockets;

namespace codmorser
{
    class Program
    {
        public static Dictionary<char, string> MorseDictionary;
        static void Main(string[] args)
        {
          
           

            MorseDictionary = new Dictionary<char, string>()
            {
            {'A',".-"},
            { 'B',"-..."},
            { 'C',"-.-."},
            { 'D',"-.."},
            { 'E',"."},
            { 'F',"..-."},
            { 'G',"--."},
            { 'H',"...."},
            { 'I',".."},
            { 'J',".---"},
            { 'K',"-.-"},
            { 'L',".-.."},
            { 'M',"--"},
            { 'N',"-."},
            { 'O',"---"},
            { 'P',".--."},
            { 'Q',"--.-"},
            { 'R',".-."},
            { 'S',"..."},
            { 'T',"-"},
            { 'U',"..-"},
            { 'V',"...-"},
            { 'W',".--"},
            { 'X',"-..-"},
            { 'Y',"-.--"},
            { 'Z',"--.."},
            { '0',"-----"},
            { '1',".----"},
            { '2',"..---"},
            { '3',"...--"},
            { '4',"....-"},
            { '5',"....."},
            { '6',"-...."},
            { '7',"--..."},
            { '8',"---.."},
            { '9',"----."}
        };

            String texto;
            char morse;
             const int dot = 250;
            const int dash = dot * 3;
            try
            {
                for (int i = 0; i < args.Length; i++)
                {
                    texto = args[i].ToUpper();
                    Console.WriteLine(texto);

                    for (int j = 0; j < texto.Length; j++)
                    {
                        try {
                            morse = texto[j];
                            Console.WriteLine(MorseDictionary[morse]);

                            foreach (var caracteres in MorseDictionary[morse])
                            {
                                if (caracteres == '.')
                                {
                                    Console.Beep(600, dot);
                                } else
                                {
                                    Console.Beep(600, dash);
                                }

                                System.Threading.Thread.Sleep(dot * 3);
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("error", e.Message);
                        }
                     }
                    System.Threading.Thread.Sleep(dot * 7);
                }
              

              }
 catch(Exception e)
 {
                Console.WriteLine("error", e.Message);
 }

    }

                }
            }


