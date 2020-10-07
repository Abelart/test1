using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    class Maths
    {
       // public static Equation2solution SolveEquation(double a, double b, double c)
        //{
            /*
            double aux1, aux2;
            Equation2solution result;

            result = new Equation2solution();

            aux1 = b * b - 4 * a * c;
            aux2 = System.Math.Sqrt(aux1);

            result.solution1 = (-b + aux2) / (2 * a);
            result.solution2 = (-b - aux2) / (2 * a);
            return result;
            */
        //    return null;

        //}

     //   public static double SolveEquation2(double a, double b)
        //{
      //      double x;
        //    x = -b / a;     
          //  return x;

        //}

        public static bool IsPrime(int number)
        {
            int i = 2;
            while (i < number)
            {
                if ((number % i) == 0)
                    return false;
                i++;
            }
            return true;
        }



    }
}
