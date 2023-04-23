using System;

namespace calcalator4ik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;

            Console.WriteLine("Калькулялька на сишарке C#\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Введите число и нажмите Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число и нажмите Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - плюс");
            Console.WriteLine("\ts - минус");
            Console.WriteLine("\tm - звездочка");
            Console.WriteLine("\td - разделить");
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Получаеца {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Получаеца {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Получаеца {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Получаеца {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.Write("Нажмите любую клавишу, чтобы завершить работу кальки");
            Console.ReadKey();
        }
    }
}
