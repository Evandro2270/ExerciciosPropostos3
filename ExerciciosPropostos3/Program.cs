using System;
using System.Globalization;
using System.Runtime.Serialization;
namespace Programa
{
    using System;

    namespace URI
    {
        class Program
        {
            static void Main(string[] args)
            {
                CultureInfo CI = CultureInfo.InvariantCulture;

                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());  
                int c = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());

                int diferenca = a * b - c * d;

                Console.WriteLine(diferenca);

            }
        }
    }
}
