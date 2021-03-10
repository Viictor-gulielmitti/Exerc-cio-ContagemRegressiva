using System;

namespace ContagemRegressiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Preparar...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Apontar...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fogo!");
            Console.ResetColor();

        }

    }
}
