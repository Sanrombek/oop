using System;
using System.Linq;

namespace lab2
{
	internal class Arrays
	{
		public static void Task11()
		{
			Console.WriteLine("Завдання 1.1");
			Console.WriteLine("Дано n дiйсних чисел. Знайти найбiльше серед вiд’ємних");

			double[] numbers = Helper.RandomArrayFillDouble();
			double maxNegative = double.MinValue;
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] < 0 && numbers[i] > maxNegative)
				{
					maxNegative = numbers[i];
				}
			}
			if (maxNegative == double.MinValue)
			{
				Console.WriteLine("Немає вiд'ємних чисел");
			}
			else
			{
				Console.WriteLine("Найбiльше вiд'ємне число: " + maxNegative);
			}
		}
		public static void Task12()
		{
			
			Console.WriteLine("Завдання 1.2");
			Console.WriteLine("Дано два вектори x, y. Знайти косинус кута мiж ними.");


			double[] x = Helper.RandomArrayFillDouble();

			double[] y = Helper.RandomArrayFillDouble();


			double dotProduct = 0;
			for (int i = 0; i < x.Length; i++)
			{
				dotProduct += x[i] * y[i];
			}

			double xLength = Math.Sqrt(x.Select(c => c * c).Sum());
			double yLength = Math.Sqrt(y.Select(c => c * c).Sum());

			double cosine = dotProduct / (xLength * yLength);

			Console.WriteLine($"Косинус кута мiж векторами x i y:  {cosine}");
		}
		public static void Task13()
		{
		
			Console.WriteLine("Завдання 1.3");
			Console.WriteLine("Стиснути масив, вилучивши з нього всi елементи, модуль " +
				"яких знаходиться в iнтервалi [a, b], мiсце яке звiльнилось в кiнцi масиву заповнити нулями.");
			int[] arr = Helper.RandomArrayFillInt();

			Console.Write("Введiть значення першої межі ");
			int a = int.Parse(Console.ReadLine());

			Console.Write("Введiть значення другої межі ");
			int b = int.Parse(Console.ReadLine());

			int writeIndex = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				if (Math.Abs(arr[i]) < a || Math.Abs(arr[i]) > b)
				{
					arr[writeIndex++] = arr[i];
				}
			}
			while (writeIndex < arr.Length)
			{
				arr[writeIndex++] = 0;
			}

			Helper.PrintArr(arr);

		}
		public static void Task21()
		{
			Console.WriteLine("Завдання 2.1");
			Console.WriteLine("Розмiстити елементи парних рядкiв у порядку спадання");
			int[,] matrix = Helper.RandomMatrixFill();
			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);
			for (int i = 1; i < rows; i += 2)
			{
				int[] currentRow = new int[cols];
				for (int j = 0; j < cols; j++)
				{
					currentRow[j] = matrix[i, j];
				}

				for (int j = 0; j < cols - 1; j++)
				{
					for (int k = j + 1; k < cols; k++)
					{
						if (currentRow[j] < currentRow[k])
						{
							int temp = currentRow[j];
							currentRow[j] = currentRow[k];
							currentRow[k] = temp;
						}
					}
				}

				for (int j = 0; j < cols; j++)
				{
					matrix[i, j] = currentRow[j];
				}
			}
			Helper.PrintMatrix(matrix);
		}
		public static void Task22()
		{

			Console.WriteLine("Завдання 2.2");
			Console.WriteLine("Дана цiлочислова квадратна матриця. " +
				"Визначити суму елементiв в тих стовпцях, якi не мiстять вiд’ємних елементiв.");
			int[,] matrix = Helper.RandomMatrixFillTaskSquare();

			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);
			int sum = 0;
			for (int j = 0; j < cols; j++)
			{
				bool hasNegative = false;
				for (int i = 0; i < rows; i++)
				{
					if (matrix[i, j] < 0)
					{
						hasNegative = true;
						break;
					}
				}
				if (!hasNegative)
				{
					for (int i = 0; i < rows; i++)
					{
						sum += matrix[i, j];
					}
				}
			}
			Console.WriteLine($"Сума елементiв у тих стовпцях, якi\r\nне мiстять вiд'ємних елементiв: {sum}");

		}
		public static void Task23()
		{
			Console.WriteLine("Завдання 2.3");
			Console.WriteLine("Дана цiлочислова квадратна матриця. " +
				"Визначити мiнiмум серед сум модулiв елементiв дiагоналей, паралельних побiчнiй дiагоналi матрицi.");

			int[,] matrix = Helper.RandomMatrixFillTaskSquare();

			int size = matrix.GetLength(0);
			int minSum = int.MaxValue;

			for (int k = 1 - size; k < size; k++)
			{
				int sum = 0;

				for (int i = 0; i < size; i++)
				{
					int j = size - 1 - i - k;

					if (j >= 0 && j < size)
					{
						sum += Math.Abs(matrix[i, j]);
					}
				}

				minSum = Math.Min(minSum, sum);
			}

			Console.WriteLine($"Мінімальна сума модулів елементів діагоналей, паралельних побічній діагоналі: {minSum}");
		}
	}
}

