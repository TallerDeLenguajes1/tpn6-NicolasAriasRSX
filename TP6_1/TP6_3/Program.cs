using System;

namespace TP6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrse Un numero mayor a 0");
            string Numero = Console.ReadLine();
            double Num = Convert.ToDouble(Numero);
            
            Console.WriteLine("El valor absoluto es = " + Math.Abs(Num));
            Console.WriteLine("      El cuadrado es = " + Math.Pow(Num, 2));
            if (Num < 0)
            {
                Console.WriteLine("No se puede calcular la raiz de un numero negativo");
            }
            else
            {
                Console.WriteLine("          La raiz es = " + Math.Sqrt(Num));
            }
            Console.WriteLine("          El seno es = " + Math.Sin(Num));
            Console.WriteLine("        El coseno es = " + Math.Cos(Num));
            Console.WriteLine("  La parte entera es = " + Math.Truncate(Num));

            Console.WriteLine("Ingrese 2 Numeros");
            Console.WriteLine("Ingrese el primer numero");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El maximo entre los numeros es: " + Math.Max(A,B));
            Console.WriteLine("El minimo entre los numeros es: " + Math.Min(A,B));

        }
    }
}
