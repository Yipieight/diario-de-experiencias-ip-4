using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02_04_Jose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////EJERCICIO 1
            //Console.WriteLine("José Andrés García Elías 1106423");
            //Console.WriteLine("Ejercicio 1");
            //Console.Write("Ingrese un número ");

            //try
            //{
            //    int x = int.Parse(Console.ReadLine());

            //    if (x == 0)
            //    {
            //        Console.WriteLine("El número es 0");
            //    }
            //    else if (x > 0)
            //    {
            //        Console.WriteLine("El número es positivo");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El número es negativo");
            //    }
            //}
            //catch (Exception ex) 
            //{
            //    Console.WriteLine("No ingreso un número " + ex.Message);
            //}
            //Console.ReadKey();

            ////EJERCICIO 2 
            //Console.Clear();
            //Console.WriteLine("José Andrés García Elías 1106423");
            //Console.WriteLine("Ejercicio 2");
            //Console.WriteLine("");
            //Console.WriteLine("Ingrese un dia de la semana. (1 al 7)");
            //try
            //{
            //    int mes = Convert.ToInt32(Console.ReadLine());

            //    if (mes > 7)
            //    {
            //        Console.WriteLine("El número a ingresar debe estar contenido entre 1 y 7");
            //    }
            //    else if ( mes <= 0)
            //    {
            //        Console.WriteLine("El número a ingresar debe estar contenido entre 1 y 7");
            //    }
            //    else
            //    {
            //        switch (mes)
            //        {
            //            case 1:
            //                Console.WriteLine("DIA: Lunes");
            //                break;
            //            case 2:
            //                Console.WriteLine("DIA: Martes");
            //                break;
            //            case 3:
            //                Console.WriteLine("DIA: Miércoles");
            //                break;
            //            case 4:
            //                Console.WriteLine("DIA: Jueves");
            //                break;
            //            case 5:
            //                Console.WriteLine("DIA: Viernes");
            //                break;
            //            case 6:
            //                Console.WriteLine("DIA: Sábado");
            //                break;
            //            case 7:
            //                Console.WriteLine("DIA: Domingo");
            //                break;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadKey();


            bool repetir = true;
            while (repetir == true)
            {
                Console.Clear();
                Console.WriteLine("José Andrés García Elías 1106423");
                Console.WriteLine("Tarea  (1)");
                Console.WriteLine("Ingrese un valor entre Q0 y Q9,999.99");
                Console.Write("Q");
                try
                {
                    double quetzales = double.Parse(Console.ReadLine());
                    if (quetzales > 9999.99)
                    {
                        Console.Clear();
                        Console.WriteLine("Debe ingresar un numero entre Q0 y Q9,999.99");
                    }
                    else if (quetzales < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Debe ingresar un numero entre Q0 y Q9,999.99");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("BILLETES DE "+ quetzales + " SON:");
                        Console.WriteLine("");

                        double multi;
                        double resta;

                        int div100 = (int)quetzales / 100;
                        multi = div100 * 100;
                        resta = quetzales - multi;
                        Console.WriteLine("(" + div100 + ")" + " Billetes de Q100");

                        multi = 0;
                        int div50 = (int)resta / 50;
                        multi = div50 * 50;
                        resta = resta - multi;
                        Console.WriteLine("(" + div50 + ")" + " Billetes de Q50");

                        multi = 0;
                        int div20 = (int)resta / 20;
                        multi = div20 * 20;
                        resta = resta - multi;
                        Console.WriteLine("(" + div20 + ")" + " Billetes de Q20");

                        multi = 0;
                        int div10 = (int)resta / 10;
                        multi = div10 * 10;
                        resta = resta - multi;
                        Console.WriteLine("(" + div10 + ")" + " Billetes de Q10");

                        multi = 0;
                        int div5 = (int)resta / 5;
                        multi = div5 * 5;
                        resta = resta - multi;
                        Console.WriteLine("(" + div5 + ")" + " Billetes de Q5");

                        multi = 0;
                        int div1 = (int)resta / 1;
                        multi = div1 * 1;
                        resta = resta - multi;
                        Console.WriteLine("(" + div1 + ")" + " Billetes de Q1");

                        //centavos

                        multi = 0;
                        double div025 = resta / 0.25;
                        int div025entero = (int)div025;
                        multi = div025entero * 0.25;
                        resta = resta - multi;
                        decimal resta1 = (decimal)resta;
                        Console.WriteLine(resta1);
                        Console.WriteLine("(" + div025entero + ")" + " Centavos de Q0.25");

                        multi = 0;
                        double div001 = resta / 0.01;
                        int div001entero = (int)div001;
                        Console.WriteLine("(" + div001entero + ")" + " Centavos de Q0.01");
                        repetir = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
           
        }
    }
}
