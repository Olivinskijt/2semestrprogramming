using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1.Exercises
{
    internal class Ex6
    {
        public delegate bool Validator(string input);

        public static Validator GetValidator(int minLength)
        {
            return input => input != null && input.Length >= minLength;
        }

        public void Example()
        {
            Validator passwordValidator = GetValidator(8);
            Validator loginValidator = GetValidator(3);

            string[] testInputs = { "te", "123", "user555444", "root" };

            Console.WriteLine("--- Password Validation (min 8) ---");
            foreach (var input in testInputs)
            {
                Console.WriteLine($"'{input}': {passwordValidator(input)}");
            }

            Console.WriteLine("\n--- Login Validation (min 3) ---");
            foreach (var input in testInputs)
            {
                Console.WriteLine($"'{input}': {loginValidator(input)}");
            }
        }
    }
}
