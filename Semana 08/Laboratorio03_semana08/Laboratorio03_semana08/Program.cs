using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborotorio03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("a. Sumatoria");
            Console.WriteLine("b. Tablas de multiplicar");
            Console.WriteLine("c. Número perfecto");


            char opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                case 'a':
                    Console.WriteLine("ingrese un numero");
                    int num = Convert.ToInt32(Console.ReadLine());
                    int resultado = 0;
                    do
                    {
                        resultado = resultado + num;
                        num--;
                    } while (num > 0);
                    Console.WriteLine("Sumatoria igual " + resultado);
                    break;


                case 'b':
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write(i + ": ");
                        for (int j = 1; j < 11; j++)
                        {
                            Console.Write((i * j) + "\t");
                        }
                        Console.Write("\n");
                    }
                    break;
                case 'c':
                    int nume = 0;
                    int suma = 0;
                    int tab = 0;
                    do
                    {
                        Console.WriteLine("Ingrese un numero entero");
                        nume = int.Parse(Console.ReadLine());
                        Console.WriteLine("Los numeros para sumar " + nume);
                        for (int i = 1; i < nume; i++)
                        {
                            tab = nume % i;
                            if (tab == 0)
                            {
                                suma = suma + i;
                            }
                            Console.WriteLine(suma);
                        }

                    }
                    while (suma == nume);
                    Console.WriteLine(nume);
                    break;
            }
            Console.ReadLine();
        
        }
    }
}