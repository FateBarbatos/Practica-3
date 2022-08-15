//Tarea
using System;

namespace Practica_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condi = true;
            string opc;
            int num1, num2;
            while (condi)
            {
                Console.WriteLine("Digite una opcion valida,si quiere cerrar digite cualquier cosa y de click en enter");
                Console.WriteLine("1-> Suma");
                Console.WriteLine("2->Resta");
                Console.WriteLine("3->Multiplicacion");
                Console.WriteLine("4->Division");
                opc = Console.ReadLine();
                if(opc == "1" || opc == "2" || opc == "3" || opc == "4"){ 
                Console.WriteLine("Digite el primer numero a operar");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite el segundo numero a operar");
                num2 = int.Parse(Console.ReadLine());
                    switch (opc)
                    {
                        case "1":
                            Console.WriteLine("El resultado de la operacion es: {0}", Sum(num1, num2));
                            break;
                        case "2":
                            Console.WriteLine("El resultado de la operacion es: {0}", Rest(num1, num2));
                            break;
                        case "3":
                            Console.WriteLine("El resultado de la operacion es: {0}", Multi(num1, num2));
                            break;
                        case "4":
                            Console.WriteLine("El resultado de la operacion es: {0}", Divi(num1, num2));
                            break;
                    }
                }
                else
                {
                    condi = false;
                    Console.WriteLine("La opcion no existe");
                }
                static int Sum( int num1,  int num2) => num1 + num2;
                static int Rest(int num1, int num2) => num1 - num2;
                static int Multi(int num1, int num2) => num1 * num2;
                static double Divi(double num1, double num2) => num1 / num2;
            }
        }
    }
}