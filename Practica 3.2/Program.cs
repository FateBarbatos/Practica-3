﻿using System;

namespace Practica_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero a evaluar");
            int Multiplo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero del limite");
            int limite = int.Parse(Console.ReadLine());

            for(int i = 0; i <= limite; i++)
            {
                if(i % Multiplo == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
