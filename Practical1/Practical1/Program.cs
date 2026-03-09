using Practical1.Exercises;
using System;

namespace Practical1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Завдання 1: Калькулятор ---");
            Ex1.Run();

            Console.WriteLine("\n--- Завдання 2: Мультикастинг ---");
            Ex2 ex2 = new Ex2();
            ex2.Example();

            Console.WriteLine("\n--- Завдання 3: Фільтрація списку (Делегат як параметр) ---");
            Ex3 ex3 = new Ex3();
            ex3.Example();

            Console.WriteLine("\n--- Завдання 4: Використання стандартних делегатів (Func та Action) ---");
            Ex4 ex4 = new Ex4();
            ex4.Example();

            Console.WriteLine("\n--- Завдання 5: Логування (Практичний кейс) ---");
            Ex5 ex5 = new Ex5();
            ex5.Example();


            Console.WriteLine("\n--- Завдання 6: Динамічний валідатор тексту ---");
            Ex6 ex6 = new Ex6();
            ex6.Example();



            Console.ReadKey();
        }
    }
}