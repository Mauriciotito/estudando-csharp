using System;

namespace aprendendocsharp5
{
    class Program
    {

        //'foreach' e 'for' para funcionar igual um 'foreach'
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            foreach (int v in a)
            {
                Console.WriteLine(v);
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        //função recursiva

        //static void Main(string[] args)
        //{
             //looping(1);
        //}
        public void looping(int a)
        {
            Console.WriteLine(a);
            if(a < 3)
            {
                looping(a + 1);
            }
        }
    }
}
