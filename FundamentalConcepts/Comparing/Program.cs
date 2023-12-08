using System;

namespace Comparing
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Testando";
            var texto2 = "testando";

            Console.WriteLine(texto.Contains(texto2));
            Console.WriteLine(texto.Equals(texto2));
            Console.WriteLine(texto.Contains(texto2, StringComparison.OrdinalIgnoreCase));
        }
    }
}