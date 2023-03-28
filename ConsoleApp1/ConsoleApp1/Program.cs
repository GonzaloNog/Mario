using System; //Librerias de sistema 

namespace MyApp // Nombre de la calse de using para no llamar en cada linea
{
    internal class Program
    {
        static void Main(string[] args)//Main funcion reservada es el codigo que se ejecuta 
        {
            //Console.WriteLine("Hello World!"); //Imprime una linea en consola
            //Console.WriteLine(23 + 3 + 50); //Diferencia numero de texto con ""
            int numero = 200; //Numero entero Variable 
            string numero2 = "1";
            int resultado = numero + int.Parse(numero2);

            int.Parse(numero2);//COnvierte un string en un int

            Console.WriteLine(resultado);//Imprime el valor de la variable 

            float b = 1.5f;

            float flo = b * numero; //Numero con decimales hasta 9 decimales
            double c = 1.0f; // Igual que el float pero con 16 decimales
            bool d = false; //solo dos resultados Verdadero y Falso 
            string e = "HOLA"; //String es una cadena de texto
            char f = 'a';

            // Comentarios

            /*
             Comentario Largo
                1
                2
                3
            */
        }
    }
}