using System;

namespace Uso_de_if
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digita un numero");
            int a = int.Parse(Console.ReadLine());
            if (a >= 23)
            {
                Console.WriteLine($"El numero {a} es mayor a 23");
            }
            else
            {
                Console.WriteLine($"El numero {a} es menor a 23");

            }
            if (a == 23)
            {
                Console.WriteLine($"El numero {a} es igual a 23");

            }
        }
    }
}
