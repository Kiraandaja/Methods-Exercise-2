using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Add(5, 5);
            Add(2, 4);
            Subtract(3, 1);
            Modulus(10, 2);
            Modulus(2, 10);
            Multiply(2, 4);
            Division(21, 7);
        }
        public static void Add(int x, int y)
        {
            int sum = (x + y);
            Console.WriteLine(sum);
        }
        public static void Subtract(int x, int y)
        {
            int answer = (x - y);
            Console.WriteLine(answer);
        }
        public static void Modulus (int x, int y)
        {
            int answer = (x % y);
            Console.WriteLine(answer);
        }
        public static void Multiply (int x, int y)
        {
            int answer = (x * y);
            Console.WriteLine(answer);
        }
        public static void Division (int x, int y)
        {   int answer = (x / y);
            Console.WriteLine(answer);
        }
    }
}
