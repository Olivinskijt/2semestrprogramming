using System;

namespace Practical1.Exercises
{
    public delegate double MathOperation(double x, double y);

    internal class Ex1
    {
        public static void Run()
        {
            MathOperation operation;

            double a = 10.5;
            double b = 5.0;

            Console.WriteLine($"Числа: {a} та {b}\n");

            operation = Add;
            PrintResult(operation, a, b, "Додавання");

            operation = Subtract;
            PrintResult(operation, a, b, "Віднімання");

            operation = Multiply;
            PrintResult(operation, a, b, "Множення");

            operation = Divide;
            PrintResult(operation, a, b, "Ділення");
        }

        static double Add(double x, double y) => x + y;
        static double Subtract(double x, double y) => x - y;
        static double Multiply(double x, double y) => x * y;

        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Помилка: Ділення на нуль!");
                return 0;
            }
            return x / y;
        }

        static void PrintResult(MathOperation op, double x, double y, string opName)
        {
            double result = op(x, y);
            Console.WriteLine($"{opName}: {result}");
        }
    }
}