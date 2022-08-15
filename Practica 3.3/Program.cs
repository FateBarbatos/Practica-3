using System;

namespace Practica_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condicion = true;
            int contador = 0;
            
            Console.WriteLine("Ingrese un numero limite");
            int limite = int.Parse(Console.ReadLine());

            while(condicion)
            {
                Console.WriteLine(contador);
                if(contador <= limite)
                {
                    condicion = false;
                }

                contador += 1;
            }
        }
    }
}
