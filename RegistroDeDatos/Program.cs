using System;
using System.IO;
namespace RegistroDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
           
         
        Console.WriteLine("Menu Principal." +
                     "\n" +
                     "\n[1]: Agregar ." +
                     "\n[2]: Listar" +
                     "\n[3]: Buscar " +
                     "\n[4]: Modificar" +
                     "\n[5]: Eliminar" +
                     "\nEliga una opcion:"
                     );
                     
            menu = Convert.ToInt16(Console.ReadLine());
            switch (menu)
               
            {
                    case 1:

                        Console.Write(args[0]);
                        long cedula;
                        int edad;

                        string nombre, apellido;

                        Console.WriteLine("Inserte su numero de cedula");
                        cedula = (Convert.ToInt64(Console.ReadLine()));

                        Console.WriteLine("Inserte su nombre ");
                        nombre = Console.ReadLine();

                        Console.WriteLine("Inserte su apellido ");
                        apellido = Console.ReadLine();

                        Console.WriteLine("Inserte su Edad");
                        edad = (Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("La informacion registrada es:" + " " + cedula + "," + nombre + "," + apellido + "," + edad);
                        Console.ReadKey();

                        Estudiante(cedula, nombre, apellido, edad, args[0]);

                        static void Estudiante(long cedula, string nombre, string apellido, int edad, string archivo)
                        {
                            bool exist = File.Exists(archivo);

                            try
                            {

                                using (System.IO.StreamWriter file = new System.IO.StreamWriter(archivo, true))
                                {
                                    if (!exist)
                                    {
                                        file.WriteLine("cedula,nombre,apellido,edad");
                                    }
                                    file.WriteLine($"{cedula},{nombre},{apellido},{edad}");

                                }
                            }
                            catch (Exception ex)
                            {
                                throw new ApplicationException(" hubo un error: ", ex);

                            }

                        }
                    break;
                case 2:
                    string[] lines = File.ReadAllLines(args[0]);
                    foreach(var line in lines)
                    {
                        var values = line.Split(',');
                        Console.WriteLine($"{values[0]},{values[1]},{values[2]},{values[3]}");                 
                        }
                    break;
                   case 3:


 Console.WriteLine("Introduzca numero de cedula a buscar");
 string find=Console.ReadLine();
                   string [] liness =new string[] {File.ReadAllText(args[0])};
                 File.OpenText(args[0]);
   if (liness[0].Contains(find))
                      {
                    Console.WriteLine($" la cedula: {find} del archivo {args[0]} ha sido encontrada");                 
                      }
                      else
                      {
                          Console.WriteLine("La cedula digitada no existe en este archivo");
                      }
                   break;
                }
        }
    }
}
