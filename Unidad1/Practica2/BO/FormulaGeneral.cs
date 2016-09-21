using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.BO
{
    public class FormulaGeneral
    {
       public double a;

       
        public double b;
        public double c;
        double d;
        double e;
        public double r;
        public  double resultado1;
       public double resultado2;

      
    //ELEVO AL CUADRADO 
     
       public FormulaGeneral(double A, double B , double C)
       {
           a = A;
           b = B;
           c = C;
            ElevarCuadrado();
            Multiplicar();
            RaizCuadrada();
            resultado1 = ((-1 * b) + r) / (2 * a);
            resultado2 = ((-1 * b) - r) / (2 * a);
           
       }
       
        public void ElevarCuadrado()
        {
            d = b * b;
        }
        public void Multiplicar()
        {
            e = ((-1 * 4) * a) * c;
        }
        public void RaizCuadrada()
        {
            r = Math.Sqrt(d + e);
        }
      
    }
}
