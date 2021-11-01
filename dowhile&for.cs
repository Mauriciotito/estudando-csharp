using System;

namespace estudandocsharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            do
            {
                Console.WriteLine(a);
                a++;
            } 
            while (a < 3);

            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine(x);
            }
        }
    }
}
 