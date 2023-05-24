
using System;

namespace  lab2


{
	internal class Program
	{
		static void Main(string[] args)
		{

			int s = 0;
			while (s != 7)
			{
				Console.WriteLine("");
				Console.WriteLine("Оберiть завдання");
				Console.WriteLine("1 - Завдання 1.1");
				Console.WriteLine("2 - Завдання 1.2");
				Console.WriteLine("3 - Завдання 1.3");
				Console.WriteLine("4 - Завдання 2.1");
				Console.WriteLine("5 - Завдання 2.2");
				Console.WriteLine("6 - Завдання 2.3");

				s = int.Parse(Console.ReadLine());
				switch (s)
				{
					case 1:
						Arrays.Task11();

						break;
					case 2:
						Arrays.Task12();

						break;
					case 3:
						Arrays.Task13();

						break;
					case 4:
						Arrays.Task21();
						break;
					case 5:
						Arrays.Task22();

						break;
					case 6:
						Arrays.Task23();

						break;
					case 7:

						return;
					default:
						Console.WriteLine("\r\nОберіть коректне значення");
						break;
				}
			}
		}
	}
}