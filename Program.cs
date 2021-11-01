using System;

namespace estudandocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 4;

            if (i == 1)
            {
                Console.WriteLine("Sou igual ao número 1.");
            }
            else if (i == 2)
            {
                Console.WriteLine("Sou igual ao número 2.");
            }
            else if (i == 3)
            {
                Console.WriteLine("Sou igual ao número 3.");
            }
            else
            {
                Console.WriteLine("Deu nenhum dos números.");
            }
        }
    }
}
