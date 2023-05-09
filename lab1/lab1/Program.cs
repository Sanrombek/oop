using System;
namespace Lab_1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int s = 0;
            while (s != 3)
            {
                Console.WriteLine("\n1. Розглянути трикутник");
                Console.WriteLine("2. Розглянути пiрамiду");
                s = int.Parse(Console.ReadLine());
                switch (s)
                {
                    case 1:
                        TPTriangle triangle = new TPTriangle();
                        int a = 0;
                        while (a != 6)
                        {
                            Console.WriteLine("\n1. Створити новий об'єкт");
                            Console.WriteLine("2. Вивести данi про об'єкт");
                            Console.WriteLine("3. Обчислити площу трикутника");
                            Console.WriteLine("4. Обчислити периметр трикутника");
                            Console.WriteLine("5. Порiвняти з iншим трикутником");
                            Console.WriteLine("6. Вийти");
                            a = int.Parse(Console.ReadLine());
                            switch (a)
                            {
                                case 1:
                                    triangle = new TPTriangle();
                                    break;
                                case 2:
                                    triangle.ShowInfo();
                                    break;
                                case 3:
                                    Console.WriteLine(triangle.FindSqr());
                                    break;
                                case 4:
                                    Console.WriteLine(triangle.FindPer());

                                    break;
                                case 5:
                                    TPTriangle triangle1 = new TPTriangle();
                                    triangle.Compare(triangle, triangle1);
                                    break;
                                case 6:

                                    return;
                                default:
                                    Console.WriteLine("Виберiть коректне значення");
                                    break;
                            }
                        }
                        break;

                    case 2:
                        TPiramid piramid = new TPiramid();
                        int b = 0;
                        while (b != 7)
                        {
                            Console.WriteLine("\n1. Створити новий об'єкт");
                            Console.WriteLine("2. Вивести данi про об'єкт");
                            Console.WriteLine("3. Обчислити площу поверхнi");
                            Console.WriteLine("4. Обчислити периметр основи пiрамiди");
                            Console.WriteLine("5. Обчислити периметр бiчної гранi пiрамiди");
                            Console.WriteLine("6. Обчислити об'єм пiрамiди");
                            Console.WriteLine("7. Вийти");
                            b = int.Parse(Console.ReadLine());
                            switch (b)
                            {
                                case 1:
                                    piramid = new TPiramid();
                                    break;
                                case 2:
                                    piramid.ShowInfo();
                                    break;
                                case 3:
                                    Console.WriteLine(piramid.FindSqr());
                                    break;
                                case 4:
                                    Console.WriteLine(piramid.FindPerBase());

                                    break;
                                case 5:
                                    Console.WriteLine(piramid.FindPerS());

                                    break;
                                case 6:
                                    Console.WriteLine(piramid.FindCapacity());

                                    break;
                                case 7:

                                    return;
                                default:
                                    Console.WriteLine("Виберiть коректне значення");
                                    break;
                            }
                        }












                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Виберiть коректне значення");
                        break;
                }
            }
        }

    }
}
