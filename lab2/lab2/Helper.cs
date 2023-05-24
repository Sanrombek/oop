using System;
namespace lab2
{
	internal class Helper
	{
		public static bool Validation(int rows)
		{
			if (rows <= 0) return false;
			else return true;
		}
		public static bool Validation(int rows, int cols)
		{
			if (rows <= 0 || cols <= 0) return false;
			else return true;
		}
		
		
		
		public static int[] RandomArrayFillInt()
		{
			Console.Write("Введіть кількість елементів ");
			int num = int.Parse(Console.ReadLine());
			while (!Helper.Validation(num))
			{
				Console.Write("Введіть кількість елементів  ");
				num = int.Parse(Console.ReadLine());
			}

			int[] array = new int[num];
			Random random = new Random();

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = random.Next(-50, 101);
			}
			Helper.PrintArr(array);

			return array;
		}
		public static double[] RandomArrayFillDouble()
		{
			Console.Write("Введіть кількість елементів ");
			int num = int.Parse(Console.ReadLine());
			while (!Helper.Validation(num))
			{
				Console.Write("Введіть кількість елементів ");
				num = int.Parse(Console.ReadLine());
			}

			double[] array = new double[num];
			Random random = new Random();

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (random.NextDouble() - 0.5) * 200;
			}
			Helper.PrintArr(array);

			return array;
		}


		public static int[,] RandomMatrixFill()
		{
			Console.Write("Введiть кiлькiсть рядкiв  ");
			int rows = int.Parse(Console.ReadLine());
			Console.Write("Введiть кiлькiсть стовпцiв  ");
			int cols = int.Parse(Console.ReadLine());

			while (!Helper.Validation(rows, cols))
			{
				Console.Write("Введiть кiлькiсть  рядкiв  ");
				rows = int.Parse(Console.ReadLine());
				Console.Write("Введiть кiлькiсть  стовпцiв  ");
				cols = int.Parse(Console.ReadLine());
			}

			Random random = new Random();

			int[,] matrix = new int[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					matrix[i, j] = random.Next(-50, 101);
				}
			}
			Helper.PrintMatrix(matrix);
			return matrix;
		}
		public static int[,] RandomMatrixFillTaskSquare()
		{
			Console.Write("Введiть кiлькiсть рядкiв i стовпцiв");
			int rows = int.Parse(Console.ReadLine());
			while (!Helper.Validation(rows, rows))
			{
				Console.Write("Введiть кiлькiсть рядкiв i стовпцiв");
				rows = int.Parse(Console.ReadLine());

			}

			Random random = new Random();

			int[,] matrix = new int[rows, rows];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < rows; j++)
				{
					matrix[i, j] = random.Next(-50, 101);
				}
			}
			Helper.PrintMatrix(matrix);
			return matrix;
		}
		public static void PrintArr(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write($"{array[i]} ");

			}
			Console.WriteLine();
		}
		public static void PrintArr(double[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write($"{array[i]} ");

			}
			Console.WriteLine();
		}
		public static void PrintMatrix(int[,] matrix)
		{
			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write($"{matrix[i, j]} ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

		}
	}
}