using System;

namespace If_else
{
    class Program
    {
        static void Main(string[] args)
        {

            int edad = 18;

            if (edad >= 18) { 
                Console.WriteLine("Eres mayor de edad");
            }
            else { 
                Console.WriteLine("Eres menor de edad");
            }
            Console.ReadKey();
        }
    }
}
