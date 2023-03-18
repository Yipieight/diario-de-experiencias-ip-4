using System;

namespace Laborotorio03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("a. Sumatoria");
            //Console.WriteLine("b. Tablas de multiplicar");
            //Console.WriteLine("c. Número perfecto");


            //char opcion = Convert.ToChar(Console.ReadLine());

            //switch (opcion)
            //{
            //    case 'a':
            //        Console.WriteLine("ingrese un numero");
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        int resultado = 0;
            //        do
            //        {
            //            resultado = resultado + num;
            //            num--;
            //        } while (num > 0);
            //        Console.WriteLine("Sumatoria igual " + resultado);
            //        break;


            //    case 'b':
            //        for (int i = 1; i <= 10; i++)
            //        {
            //            Console.Write(i + ": ");
            //            for (int j = 1; j < 11; j++)
            //            {
            //                Console.Write((i * j) + "\t");
            //            }
            //            Console.Write("\n");
            //        }
            //        break;
            //    case 'c':
            //        int nume = 0;
            //        int suma = 0;
            //        int tab = 0;

            //        Console.WriteLine("Ingrese un numero entero");
            //        nume = int.Parse(Console.ReadLine());
            //        for (int i = 1; i < nume; i++)
            //        {
            //            tab = nume % i;
            //            if (tab == 0)
            //            {
            //                Console.Write(i + " ");

            //                suma = suma + i;
            //            }
            //        }
            //        if (suma == nume)
            //        {
            //            Console.WriteLine("= " + nume);
            //            Console.WriteLine("Es un numero perfecto");
            //        }
            //        else
            //        {
            //            Console.WriteLine("= " + nume);
            //            Console.WriteLine("no es un numero perfecto");
            //        }
            //        break;
            //}

            ////TAREA 
            ////EJERCICIO 1
            //Console.WriteLine("ingrese un numero de base 10. (1,2,3,4,5,6,7,8 y 9)");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //int resultado1 = 0;
            //string binario = "";
            //int numero1 = numero;

            //while (numero > 0)
            //{
            //    resultado1 = numero % 2;
            //    binario = resultado1.ToString() + binario;
            //    numero = numero / 2;
            //}

            //Console.WriteLine("El número ingresado en base 10 es: " + numero1);
            //Console.WriteLine("Su equivalente en binario es: " + binario);
            //Console.ReadLine();
            ////EJERCICIO 2
            Console.WriteLine("Ingrese un numero de base 10. (1,2,3,4,5,6,7,8 y 9)");
            int decima = Convert.ToInt32(Console.ReadLine());
            int mod = 0;
            string hexadecimal = "";
            int numero1 = decima;

            while (decima > 0)
            {
                mod = decima % 16;

                if (mod == 10)
                {
                    string letra = "A";
                    hexadecimal = letra + hexadecimal;
                }
                else if (mod == 11)
                {
                    string letra = "B";
                    hexadecimal = letra + hexadecimal;
                }
                else if (mod == 12)
                {
                    string letra = "C";
                    hexadecimal = letra + hexadecimal;

                }
                else if (mod == 13)
                {
                    string letra = "D";
                    hexadecimal = letra + hexadecimal;
                }
                else if (mod == 14)
                {
                    string letra = "E";
                    hexadecimal = letra + hexadecimal;
                }
                else if (mod == 15)
                {
                    string letra = "F";
                    hexadecimal = letra + hexadecimal;
                }
                else
                {
                    hexadecimal = mod.ToString() + hexadecimal;
                }
                decima = decima / 16;

            }

            Console.WriteLine("El número ingresado en base 10 es: " + numero1);
            Console.WriteLine("Su equivalente en hexadecimal es: " + hexadecimal);
            Console.ReadKey();


        }
    }
}