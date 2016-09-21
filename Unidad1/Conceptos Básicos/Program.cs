using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceptos_Básicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Seleccione una de las siguientes operaciones a realizar");
            Console.WriteLine("1. Factorial");
            Console.WriteLine("2. MCD");
          
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    {
                        Program oRec = new Program();
                        int Numero = 0;
                        Console.WriteLine("Introduce un Número para obtener su factorial:");
                        Numero = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Resultado:");
                        Console.WriteLine(oRec.factorial(Numero)); 
                    }
                    break;
                case 2:
                    {
                        int a, b;
                        Console.WriteLine("Introduce primer numero: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce segundo numero: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("MCD: {0}", mcd(a, b));
                    }
                    break;
                default:
                    {
                        Console.WriteLine("No ha seleccionado una opción disponible");
                    }
                    break;
            }


            Console.ReadKey();
           
        }
        public int factorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public static int mcd(int x, int y)
        {
            int k;
            if (x == 0) k = y;
            else k = mcd(y % x, x);
            return k;
        } 

   


    }
}
