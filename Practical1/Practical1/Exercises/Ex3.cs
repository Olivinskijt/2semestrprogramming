using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Practical1.Exercises
{
    internal class Ex3
    {
        public delegate bool FilterPredicate(int number);

        public void FilterArray(int[] numbers, FilterPredicate predicate)
        {
            foreach (int number in numbers)
            {
                if (predicate(number))
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }

        public void Example()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Even numbers:");
            FilterArray(numbers, number => number % 2 == 0);

            Console.WriteLine("Numbers greater than 5:");
            FilterArray(numbers, number => number > 5);

            Console.WriteLine("Odd numbers (анонімний метод):");
            FilterArray(numbers, delegate (int n) { return n % 2 != 0; });
        }
    }
}
