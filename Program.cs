using System;

namespace estudandocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 4;

            if (a == 1)
            {
                Console.WriteLine("entrou na condição do if");
            }
            else if (a == 2)
            {
                Console.WriteLine("entrou na condição 2");
            }
            else if (a == 3)
            {
                Console.WriteLine("entrou na condição 3");
            }
            else
            {
                Console.WriteLine("entrou na condição do else");
            }

            var x = 2;
            string xy = (x == 1 + 1 ? "sim" : "não");
            Console.WriteLine(xy);

            var y = 1;
            while (y < 5)
            {
                Console.WriteLine(y);
                y = y + 1;
            }
        }
    }
}
