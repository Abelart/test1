
namespace Prueba
{
    class Ejercicios
    {
        // Ejercicio: Hacer una función que imprima por pantalla los números del 0 al 99
        public static void Ejercicio1()
        {
            int contador;
            contador = 0;
            while (contador < 100)
            {
                System.Console.WriteLine(contador);
                contador = contador + 1;
            }
        }

        //Ejercicio: Hacer una función que imprima todos los números pares desde 0 hasta n

        public static void Ejercicio2(int n)
        {
            int i = 0;
            while (i < n) 
            {
                if (Misc.IsEven(i))
                    System.Console.WriteLine(i);

                    i++;
            }
        }

        //Ejercicio
        
        public static void Ejercicio3(int number)
        {
            bool is_prime;
            is_prime =  Maths.IsPrime(number);
            if (is_prime == true)
                System.Console.WriteLine("El número" + number + "es primo");
            else
                System.Console.WriteLine("El número" + number + "no es primo");

        }

        //Ejercicio 4

        public static void Ejercicio4()
        {
            for (int i = 0; i < 90; i++)
            {
                System.Console.WriteLine(5 - i);
            }
        }

        //Ejercicio 5

        public static void Ejercicio5()
        {
            for (int i = 0; i < 90; i++)
            {
                if ((i % 2) == 0)
                    System.Console.WriteLine(-i);
                else
                    System.Console.WriteLine(i);
            }
        }

        public static void Ejercicio6()
        {
            int n1 = 0;
            int n2 = 1;
            System.Console.WriteLine(n1);
            System.Console.WriteLine(n2);           
            for (int i = 0; i < 8; i++)
            {

                System.Console.WriteLine(n1 + n2);

                n2 = n1 + n2;
                n1 = n2 - n1;    
            }

        }
    }

}
