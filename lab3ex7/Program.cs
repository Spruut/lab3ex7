using System;

namespace lab3ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Enter number N for Fibonacci series ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n} element of Fibonacci series - {Fibonacci(n)}");
            Console.ReadKey();
            Program.Main(args);
        }
        static int Fibonacci(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
