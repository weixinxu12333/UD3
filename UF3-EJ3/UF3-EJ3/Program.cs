using System;

namespace UF3_EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 5;
            double n = 7;
            double m = 9;
            Console.WriteLine("x={0}, y={1}, n={2}, m={3}", x, y, n, m);
            Console.WriteLine("x+y={0}, x-y={1}, x*y={2}, x/y={3}, x%y={4}", x + y, x - y, x * y, x / y, x % y);
            Console.WriteLine("n+m={0}, n-m={1}, n*m={2}, n/m={3}, n%m={4}", n + m, n - m, n * m, n / m, n % m);
            Console.WriteLine("x+n={0}, y/m={1}, y%m={2}", x + n, y / m, y % m);
            Console.WriteLine("double x={0}, double y={1}, double n={2}, double m={3}", (double)x, (double)y, n, m);
            Console.WriteLine("suma total={0}, multiplica total={1}", x + y + n + m, x * y * n * m);
        }
    }
}
