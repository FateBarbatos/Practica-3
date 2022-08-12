using System;

namespace Practica_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int numb = int.Parse(Console.ReadLine());

            switch (numb)
            {
                case 1:
                    Console.WriteLine("Elegiste la opcion {0}", numb);
                    break;
                case 2:
                    Console.WriteLine("Elegiste la opcion {0}", numb);
                    break;
                case 3:
                    Console.WriteLine("Elegiste la opcion {0}", numb);
                    break;
                case 4:
                    Console.WriteLine("Elegiste la opcion {0}", numb);
                    break;
                case 5:
                    Console.WriteLine("Elegiste la opcion {0}", numb);
                    break;
                case 6:
                    Console.WriteLine("Elegiste la opcion {0}", numb);
                    break;
                default:
                    Console.WriteLine("Esta opcion no esta disponible");
                    break;
            }


        }
    }
}
