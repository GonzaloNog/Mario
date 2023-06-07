using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            holamundo();
            bool vivo = false;
            if (vivo)
            {
                Console.WriteLine("Correcto!!!");
            }
            else
            {
                Console.WriteLine("Incorrecto!!!");
            }
            int a = 0;
            while(a < 10)
            {
                a = int.Parse(Console.ReadLine());
                Console.WriteLine(a * 10);    
            }
        }
        static void holamundo()
        {
            Console.WriteLine("Hello World!");
            suma();
            //suma(4, 2);
        }
        static void suma(int a, int b, int c = 1)
        {
            Console.WriteLine(a + b + c);
        }
        static void suma(int a, int b, int c, int d)
        {
            Console.WriteLine(a + b + c + d);
        }
        static void suma()
        {
            Console.WriteLine("Error: no cargaste ningun numero");
        }

    }
}