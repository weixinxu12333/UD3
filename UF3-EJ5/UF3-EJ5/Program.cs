using System;

namespace UF3_EJ5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 1;
            int B = 2;
            int C = 3;
            int D = 4;

            B = C;
            Console.WriteLine(B);
            C = A;
            Console.WriteLine(C);
            A = D;
            Console.WriteLine(A);
            D = B;
            Console.WriteLine(D);
        }
    }
}
