using System;

namespace Fibonacci {
    static class Program {
        static void Main(string[] args) {
            int num = 5;
            if(args.Length == 1)
                num = int.Parse(args[0]);

            int[] fibonacci = CreateFibonacciSeries(num);

            for (int i = 0; i < fibonacci.Length; i++) {
                Console.Out.Write(fibonacci[i]);
                Console.Out.Write(" ");
            }
            Console.Out.WriteLine();
        }

        static int[] CreateFibonacciSeries(int count) {
            int[] fibonacci = new int[count];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < count; i++) {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            return fibonacci;
        }
    }
}