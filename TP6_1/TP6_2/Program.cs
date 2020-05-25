using System;

namespace TP6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Operacion, aux;
            int N;
            float Res, a, b;
            Console.WriteLine("Seleccione la operacion");
            Console.WriteLine("1 Suma");
            Console.WriteLine("2 Resta");
            Console.WriteLine("3 Producto");
            Console.WriteLine("4 Cociente");

            Operacion = Console.ReadLine();
            N = Convert.ToInt32(Operacion);

            //Console.WriteLine("Salida" + N);
            
            Console.WriteLine("Ingrese el primer Numero");
            aux = Console.ReadLine();
            a = Convert.ToInt32(aux);
            Console.WriteLine("Ingrese el segundo Numero");
            aux = Console.ReadLine();
            b = Convert.ToInt32(aux);


            if (N == 1)
            {
                Res = a + b;
                Console.WriteLine("Suma= " + Res);
            }
            else
            {
                if (N == 2)
                {
                    Res = a - b;
                    Console.WriteLine("Resta= " + Res);
                }
                else
                {
                    if (N == 3)
                    {
                        Res = a * b;
                        Console.WriteLine("Producto= " + Res);
                    }
                    else
                    {
                        if (N == 4)
                        {
                            if ( b > 0 )
                            {
                                Res = a / b;
                                Console.WriteLine("Cociente= " + Res);
                            }
                            else
                            {
                                Console.WriteLine("No se puede Dividir por 0");
                            }
                        }
                    }
                }
            }
        }
    }
}
