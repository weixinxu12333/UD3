using System;

namespace UF3_EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 5;

            int suma = n1 + n2;
            int resta = n1 - n2;
            int multiplica = n1 * n2;
            int dividir = n1 / n2;
            int mod = n1 % n2;

            Console.WriteLine("suma: {0}, resta: {1}, multiplica: {2}, dividir: {3}, mod: {4}",
                suma, resta, multiplica, dividir, mod);

            Console.ReadKey();
        }
    }
}
