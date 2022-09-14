using System;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int unNumero = int.Parse(Console.ReadLine());

            if (unNumero > 0) Console.WriteLine("El numero ingresado es POSITIVO");
            else if (unNumero < 0) Console.WriteLine("El numero ingresado es NEGATIVO");
            else Console.WriteLine("El numero ingresado es 0");
            

        }
    }
}
