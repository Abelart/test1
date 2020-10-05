namespace Ecuaciones
{
    class Geometry
    {
        public static double GetVector2DLength(double x, double y)
        {
            double aux = x * x + y * y;
            double lenght = System.Math.Sqrt(aux);
            return lenght;
        }

        public static double GetVector3DLength(double x, double y, double z)
        {
            double aux = x * x + y * y + z * z;
            double lenght = System.Math.Sqrt(aux);
            return lenght;

        }

        public static double GetCircleArea(double r);
        {
            double aux = r * r;
            double aux2 = System.Math.PI * (aux);
           
        }
    }
}
