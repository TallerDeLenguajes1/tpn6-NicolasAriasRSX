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
        }
    }
}
