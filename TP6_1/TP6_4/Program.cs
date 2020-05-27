using System;

namespace TP6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena");
            string cadena = Console.ReadLine();
            Console.WriteLine(cadena[1]);
            Console.WriteLine(cadena[3]);
            Console.WriteLine(cadena[5]);
            Console.WriteLine(cadena.Length);
            Console.WriteLine("Ingrese otra cadena ");
            string cadena2 = Console.ReadLine();
            string S = String.Concat(cadena, cadena2);
            Console.WriteLine("Cadena concatenada \n {0}",S);
            Console.WriteLine(S.Substring(0,10));
            //--------------------Calculadora--------------------
            string Operacion, aux;
            int N;
            double Res, a, b;
            Console.WriteLine("Seleccione la operacion");
            Console.WriteLine("1 Suma");
            Console.WriteLine("2 Resta");
            Console.WriteLine("3 Producto");
            Console.WriteLine("4 Cociente");
            Operacion = Console.ReadLine();
            N = Convert.ToInt32(Operacion);
            Console.WriteLine("Ingrese el primer Numero");
            aux = Console.ReadLine();
            a = Convert.ToDouble(aux);
            Console.WriteLine("Ingrese el segundo Numero");
            aux = Console.ReadLine();
            b = Convert.ToDouble(aux);

            switch (N)
            {
                case 1:
                    Res = a + b;
                    Console.WriteLine("La Suma de {0} y de {1} es igual a : {2}", a, b, Res);                    
                    break;
                case 2:
                    Res = a - b;                    
                    Console.WriteLine("La Resta de {0} y de {1} es igual a : {2}", a, b, Res);
                    break;
                case 3:
                    Res = a * b;
                    Console.WriteLine("El product de {0} y de {1} es igual a : {2}", a, b, Res);
                    break;
                case 4:
                    if (b <= 0)
                    {
                        Console.WriteLine("No se puede dividir por cero");
                    }
                    else
                    {
                        Res = a / b;
                        Console.WriteLine("El cociente de {0} y de {1} es igual a : {2}", a, b, Res);
                    }
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }

            foreach(var Cadenas in S)
            {
                Console.WriteLine(Cadenas);
            }
            Console.WriteLine("Ingrese una palabra a buscar en la cadena");
            string Buscar = Console.ReadLine();

            if (S.Contains(Buscar))
            {
                Console.WriteLine("La palabra esta en la cadena");
            }
            else
            {
                Console.WriteLine("La palabra no esta en cadena");
            }            
            Console.WriteLine(cadena);
            
            Console.WriteLine("Cadena en Mayuscula \n{0}", cadena.ToUpper());
            Console.WriteLine("Cadena en Minuscula \n{0}", cadena.ToLower());

            if(String.Compare(cadena,cadena2)!= 0)
            {
                Console.WriteLine("Las cadenas son distintas");
            }
            else
            {
                Console.WriteLine("Las cadenas son iguales");
            }
            char separador = 'a';
            string [] SubCadena = S.Split(separador);
            foreach (string  recorrer in SubCadena)
            {
                Console.WriteLine(recorrer);
            }
        }
    }
}
