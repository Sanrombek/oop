using System;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Створити клас, що містить методи розв’язання квадратного рівняння (знаходження
            //розв’язків розглядати як у R , так і просторі комплексних чисел). Для різних випадків
            //передбачити відповідні інтерфейси.
            int s = 0;
            while (s != 2)
            {
                Console.WriteLine($"Якщо ви хочете розв'язати рiвняння, натиснiть 1 \nЯкщо ви хочете вийти, натиснiть 2 ");


                s = int.Parse(Console.ReadLine());

                switch (s)
                {
                    case 1:
                        Console.WriteLine("Квадратне рiвняння: a*x^2 + b*x + c = 0");
                        Console.WriteLine();
                        Console.WriteLine("Введiть a");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Введiть b");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Введiть c");
                        double c = double.Parse(Console.ReadLine());

                        var result = QuadraticEquationSolver.Solve(a, b, c);
                        result.Printing();
                        break;

                    case 2:
                        return;

                    default:
                        Console.WriteLine("\r\nВиберiть правильне значення");
                        break;
                }
            }
        }
    }
}
