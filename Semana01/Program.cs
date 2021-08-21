using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Division de dos números");
                Console.WriteLine("[4] Multiplicar de dos números");
                Console.WriteLine("[5] Imprimir los 10 primeros números primos");
                Console.WriteLine("[6] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[7] Convertir celsius a fahrenheit");
                Console.WriteLine("[8] Convertir fahrenheit a celsius");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", a, b, Resta(a, b));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division de {0} y {1} es {2}", a, b, Division(a, b));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicacion de {0} y {1} es {2}", a, b, Multiplicacion(a, b));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Calculando...");
                        NumerosPrimos();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese el número en celsius");
                        float c = float.Parse(Console.ReadLine());
                        Console.WriteLine("El número {0}° en fahrenheit es {1}°F", c, fahrenheit(c));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese el número en fahrenheit");
                        float d = float.Parse(Console.ReadLine());
                        Console.WriteLine("El número {0}°F en celsius es {1}°", d, Celsius(d));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }

        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }
        static void NumerosPrimos()
        {
            for (int j = 2; j <= 30; j++)
            {
                int a = 0;
                for (int i = 1; i <= 30; i++)
                {
                    if (j % i == 0) 
                        a++;
                }
                if (a == 2)
                {
                    Console.WriteLine(j);
                }
            }
        }
        static int Resta(int a,int b)
        {
            return a - b;
        }
        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }
        static int Division(int a, int b)
        {
            return a / b;
        }
        static float Celsius(float a)
        {
            return (5*(a - 32)) / 9;
        }
        static float fahrenheit(float a)
        {
            return ((9*a)/5)+32;
        }


    }
}
