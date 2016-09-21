using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program oRec = new Program();
            int Numero = 0;
            Console.WriteLine("Introduce un Número para obtener su factorial:");
            Numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultado:");
            Console.WriteLine(oRec.factorial(Numero));

            Console.WriteLine(oRec.factorialRecursivo(Numero));
            Console.WriteLine("---------");
            oRec.algoRecursivo(Numero);
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

        public int algoRecursivo(int n)
        {
            Console.WriteLine(n);
            if (n > 0)
            {
                return algoRecursivo(n - 1);
            }
            else { return 0; }
        }
        public int factorialRecursivo(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return 1;
            }
            else
            {
                return (n * factorialRecursivo(n - 1));
            }
        }


    }
}
