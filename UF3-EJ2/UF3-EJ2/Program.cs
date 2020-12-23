using System;

namespace UF3_EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            double A = 4.56;
            char C = 'a';
            int c = (int)C;
            Console.WriteLine("N={0}, A={1}, C={2}, Suma de N+A={3}, Diferencia de A-N={4}, num char de C={5}",
                N, A, C, N + A, A - N, c);
        }
    }
}
