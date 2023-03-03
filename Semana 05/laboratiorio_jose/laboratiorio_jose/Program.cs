using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratiorio_jose
{
    class Program
    {
        static void Main(string[] args)
        {
            ////EJERCICIO 1: OPERACIONES ARIRMÉTICAS (1)
            //Console.WriteLine("Ejercicio 1: Operaciones aritmeticas. ");
            //Console.Write("Ingrese un numer
            //o: ");
            //int n1 = Convert.ToInt32(Console.ReadLine()); //5

            //Console.Write("Ingrese un numero: ");
            //int n2 = Convert.ToInt32(Console.ReadLine()); //3


            //int suma = n1 + n2;
            //Console.WriteLine(n1 + " + " + n2 + " = " + suma);

            //int resta = n1 - n2;
            //Console.WriteLine(n1 + " - " + n2 + " = " + resta);

            //int multi = n1 * n2;
            //Console.WriteLine(n1 + " * " + n2 + " = " + multi);

            ////double n1d = n1;
            ////double n2d = n2;

            //double division = (double)n1 / n2;
            //Console.WriteLine(n1 + " / " + n2 + " = " + division);

            //int div1 = n1 / n2;
            //Console.WriteLine(n1 + " / " + n2 + " = " + div1);

            //int mod1 = n1 % n2;
            //Console.WriteLine(n1 + " % " + n2 + " = " + mod1);

            ////OPERACIONES BOOLEANAS (2)

            //Console.WriteLine("");
            //Console.WriteLine("EJERCICIO 2: Operaciones booleanas");
            //Console.WriteLine("");

            //bool bool1, bool2, bool3;

            //bool1 = n1 > n2;
            //bool2 = n1 < n2;
            //bool3 = n1 == n2;

            //Console.WriteLine(n1 + " > " + n2 + " = " + bool1);
            //Console.WriteLine(n1 + " < " + n2 + " = " + bool2);
            //Console.WriteLine(n1 + " = " + n2 + " = " + bool3);

            //EJERCICIO 3: Operaciones jerarquia de operaciones

            Console.WriteLine("");
            Console.WriteLine("EJERCICIO 3: Operaciones jerarquia de operaciones");
            Console.WriteLine("");

            double a, b, c;

            Console.WriteLine("Ingrese el valor de la letra <A>");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la letra <B>");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la letra <C>");
            c = Convert.ToDouble(Console.ReadLine());


            double operador1 = (a * b + c);
            double operador2 = (a * (b + c));
            double operador3 = (a / (b * c));
            double operador41 = (3 * a + 2 * b);
            double operador42 = (c * c);
            double operador4 = operador41 / operador42;


            Console.WriteLine("");

            Console.WriteLine("operador No.1 = " +operador1);
            Console.WriteLine("operador No.2 = " + operador2);
            Console.WriteLine("operador No.3 = " + operador3);
            Console.WriteLine("operador No.4 = " + operador4);

            //EXPRESION CUADRATICA (4)

            double operador51 = (-1 * b);
            double operador52 = (b * b);
            double operador53 = (-4 * (a*c));
            double operador54 = (2*a);

            Console.WriteLine("");
            Console.WriteLine("Ecuaciones cuadráticas: Método formula general");
            Console.WriteLine("");

            //operacion de la raiz
            //verificamos el discriminante (b^2 -4ac)
            double operador55 = (operador52 - (-operador53));
            Console.Write("La discriminates es " + operador55 + " por lo tanto ");

            //if, no es un número imaginario
            if (operador55 < 0)
            {
                Console.Write("es un número imaginario");
            }
            //else, es un número imaginario
            else
            {
                Console.Write("no es un número imaginario");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("El resultado de la ecuación cuadrática es:");

                //raiz de la discriminante
                double raizcuadrada = Math.Sqrt(operador55);

                //resultado de x1 de forma negativa
                double raizcuadrada1 = operador51 - raizcuadrada;
                double raizcuadrada2 = raizcuadrada1 / operador54;
                Console.WriteLine("X1 = " + raizcuadrada2);

                //resultado de x2 de forma positiva
                double raizcuadrada3 = (operador51 + (raizcuadrada));
                double raizcuadrada4 = raizcuadrada3 / operador54;
                Console.WriteLine("X2 = " + raizcuadrada4);
            }
            Console.ReadKey();


            


        }
    }
}
