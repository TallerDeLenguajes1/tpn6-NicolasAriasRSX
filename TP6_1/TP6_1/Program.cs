using System;

namespace TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, R, NumInv = 0;
            string Numero;
            Console.WriteLine("Ingrese un Numero");
            Numero = Console.ReadLine();
            N = Convert.ToInt32(Numero);
            if (N > 0)
            {
                while (N > 0)
                {
                    R = N % 10;
                    N /= 10;
                    NumInv = (NumInv * 10) + R;
                }
                Console.WriteLine("Numero invertido: " + NumInv);
            }
            else
            {
                Console.WriteLine("El numero debe ser mayor que 0");
            }
        }
    }
}
