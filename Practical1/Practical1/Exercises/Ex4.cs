using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1.Exercises
{
    internal class Ex4
    {
        private double Add(double a, double b) => a + b;

        public void Example()
        {
            Func<double, double, double> operation = Add;
            double result = operation(5, 3);
            Console.WriteLine($"The result of the operation is: {result}");

            List<string> students = new List<string> { "Maksym", "Artem", "Andrey", "Denis", "Illia" };

            List<string> namesStartsWithA = students.FindAll(name => name.StartsWith("A"));

            Console.WriteLine("У кого ім'я починається на 'A':");
            foreach (string name in namesStartsWithA)
            {
                Console.WriteLine(name);
            }
        }
    }
}
