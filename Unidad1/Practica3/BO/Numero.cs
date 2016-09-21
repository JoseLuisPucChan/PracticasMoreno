using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.BO
{
  public class Numero: NumeroRacional
    {
        public  int Numerador;
        public int Denominador;
        public bool Texbox = true;
        public int R1 = 0;
        public int R2 = 0;
        public int Enteros = 0;
        public override double Suma(int a, int b , int c , int d)
        {
            Numerador =  (a * d) + (b * c);
            Denominador = b * d;
            return 1;
        }
        public  double SumaMismoD(int a, int b, int c, int d)
        {
           this.Numerador = (a * d) + (b * c);
           this.Denominador = d;
            return 1;
        }
       
         public void SimplificarSuma2(int A, int B, int C, int D)
         {
             int Numero1f = 0;
             int Numero2f = 0;
             int MCD = 16;
             if (B != D)
             {
                 Suma(Convert.ToInt32(A), Convert.ToInt32(B), Convert.ToInt32(C), Convert.ToInt32(D));
                 Numero1f =  Numerador;
                 Numero2f =  Denominador;
             }
             else
             {
                 SumaMismoD(Convert.ToInt32(A), Convert.ToInt32(B), Convert.ToInt32(C), Convert.ToInt32(D));
                 Numero1f = Numerador;
                 Numero2f = Denominador;

             }
           
             for (int i = 0; i <= 30; i++)
             {
                 if (Numero1f % MCD == 0 && Numero2f % MCD == 0)
                 {
                     Numero1f = Numero1f / MCD;
                     Numero2f = Numero2f / MCD;

                     if (Numero1f % Numero2f == 0)
                     {
                         Enteros = Numero1f / Numero2f;
                         Texbox = false;
                         int mdc = 2;
                         for (int y = 0; y <= 2;y++ )
                         {

                              if (Enteros % mdc == 0)
                              {
                                  Enteros = Enteros / mdc;
                              }
                              else
                              {
                                  break;

                              }
                         }



                            
                     }
                 }
                 else
                 {
                     MCD--;
                 }

             }
             R1 = Numero1f;
             R2 = Numero2f;

         }



         public override double Multiplicar(int a, int b, int c, int d)
         {
             Numerador = (a * c);
             Denominador = (b * d);

             return 1;

         }

         public void SimplificarMultiplicacion(int A, int B, int C, int D)
         {
             Multiplicar(A, B, C, D);
             int Numero1f = 0;
             int Numero2f = 0;
             int MCD = 16;
             Numero1f = Numerador;
             Numero2f = Denominador;
              for (int i = 0; i <= 30; i++)
              {
                  if (Numero1f % MCD == 0 && Numero2f % MCD == 0)
                  {
                      Numero1f = Numero1f / MCD;
                      Numero2f = Numero2f / MCD;
                  }
                  else
                  {
                      MCD--;
                  }

              }
              R1 = Numero1f;
              R2 = Numero2f;
           
         }




         public override string EsIgual(int A, int B, int C, int D)
        {
            int Resultado1 = 0;
            int Resultado2 = 0;


            Resultado1 = A * D;
            Resultado2 = B * C;

            if (Resultado1 == Resultado2)
            {
                return "Es igual";
            }
            else
            {
                return "No es igual"; 
            }
            

        }


    }
}
