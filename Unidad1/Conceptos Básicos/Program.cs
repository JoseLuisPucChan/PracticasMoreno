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
            Console.WriteLine("2. Serie de Fibonaci");
            Console.WriteLine("3. MCD");
            Console.WriteLine("4. Cambio");
          
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
                        Console.WriteLine("Ingrese un número");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (num >= 0)
                        {
                            if (num >= 3)
                            {
                                Console.WriteLine("La serie de fibonacci es: \n" + fibonacci(num, 0, 3, "", 1, 1));
                            }
                            else
                            {
                                Console.WriteLine("La serie de fibonacci es: \n" + fibonacci(num, 0, 1, "", 1, 1));
                            }
                        }
                        else { Console.WriteLine("El número debe ser mayor o igual a 0"); }
                    }
                    break;

                case 3:
                    {
                        int a, b;
                        Console.WriteLine("Introduce primer numero: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce segundo numero: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("MCD: {0}", mcd(a, b));
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Cambio de monedas");
                        Console.WriteLine("");
                        Console.Write("Ingrese cantidad a pagar: ");
                        double num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.Write("Pago con:");
                        double num2 = double.Parse(Console.ReadLine());
                        double cambio = Math.Round(num2 - num1, 2);
                        double cambio2 = cambio;
                        long billete_cien = 0, billete_cincuenta = 0, billete_veinte = 0;
                        long moneda_diez = 0, moneda_cinco = 0, moneda_peso = 0, centavo_cincuenta = 0, centavo_veinte = 0, centavo_diez = 0, centavo_centavo = 0;
                        while (cambio >= 0.1)
                        {
                            billete_cien = (long)cambio / (100);
                            cambio = Math.Round((cambio % 100), 2);
                            billete_cincuenta = (long)cambio / (50);
                            cambio = Math.Round((cambio % 50), 2);
                            billete_veinte = (long)cambio / (20);
                            cambio = Math.Round((cambio % 20), 2);
                            moneda_diez = (long)cambio / (10);
                            cambio = Math.Round((cambio % 10), 2);
                            moneda_cinco = (long)cambio / (5);
                            cambio = Math.Round((cambio % 5), 2);
                            moneda_peso = (long)cambio / (1);
                            cambio = Math.Round((cambio % 1), 2);
                            centavo_cincuenta = (long)(cambio / (0.50));
                            cambio = Math.Round((cambio % 0.50), 2);
                            centavo_veinte = (long)(cambio / (0.20));
                            cambio = Math.Round((cambio % 0.20), 2);
                            centavo_diez = (long)(cambio / (0.10));
                            cambio = Math.Round((cambio % 0.10), 2);
                            centavo_centavo = (long)(cambio / 0.01);
                            cambio = Math.Round((cambio % (0.01)), 2);
                        }
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


        static string fibonacci(int cant, int numact, int cont, string cad, int numant, int numsig)
        {
            if (cant == 1)
            {
                cad = "0";
            }
            else
            {
                if (cant == 2)
                {
                    cad = "0, 1";
                }
                else
                {
                    if (cant >= 3 && (cont == 3))
                    {
                        cad = "0, 1, 1";
                    }
                }
            }
            if (cont == cant)
            {
                return cad;
            }
            numact = numant + numsig;
            numant = numsig;
            numsig = numact;
            cad = cad + ", " + numact;
            cont++;
            return fibonacci(cant, numact, cont, cad, numant, numsig);
        }

    }
}
