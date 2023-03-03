// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 1: Operaciones aritmeticas. ");
Console.Write("Ingrese un numero: ");
int n1 = Convert.ToInt32(Console.ReadLine()); //5

Console.Write("Ingrese un numero: ");
int n2 = Convert.ToInt32(Console.ReadLine()); //3


int suma = n1 + n2;
Console.WriteLine(n1 + " + " + n2 + " = " + suma);

int resta = n1 - n2;
Console.WriteLine(n1 + " - " + n2 + " = " + resta);

int multi = n1 * n2;
Console.WriteLine(n1 + " * " + n2 + " = " + multi);

//double n1d = n1;
//double n2d = n2;

double division = (double)n1 / n2;
Console.WriteLine(n1 + " / " + n2 + " = " + division);

int div1 = n1 / n2;
Console.WriteLine(n1 + " / " + n2 + " = " + div1);

int mod1 = n1 % n2;
Console.WriteLine(n1 + " % " + n2 + " = " + mod1);

//EJERCICIO 2 OPERACIONES BOOLEANAS

Console.WriteLine("");
Console.WriteLine("EJERCICIO 2: Operaciones booleanas");
Console.WriteLine("");

bool bool1, bool2, bool3;

bool1 = n1 > n2;
bool2 = n1 < n2;
bool3 = n1 == n2;

Console.WriteLine(n1 + " > " + n2 + " = " + bool1);
Console.WriteLine(n1 + " < " + n2 + " = " + bool2);
Console.WriteLine(n1 + " = " + n2 + " = " + bool3);

//EJERCICIO 3: Operaciones jerarquia de operaciones

Console.WriteLine("");
Console.WriteLine("EJERCICIO 3: Operaciones jerarquia de operaciones");
Console.WriteLine("");

int a, b, c;

Console.WriteLine("Ingrese el valor de la letra <A>");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el valor de la letra <B>");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el valor de la letra <C>");
c = Convert.ToInt32(Console.ReadLine());

int operador1 = ( a * b + c);
int operador2 = (a * (b + c));
double operador3 = (double) (a / (b * c));
double operador4 = (double)((3 * a) + (2 * b)) / c * c;




