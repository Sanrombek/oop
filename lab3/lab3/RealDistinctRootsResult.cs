using System;

namespace lab3
{
	public class RealDistinctRootsResult : IQuadraticEquationResult
	{
		private readonly double root1;
		private readonly double root2;

		public RealDistinctRootsResult(double root1, double root2)
		{
			this.root1 = root1;
			this.root2 = root2;
		}

		public void Printing()
		{
			Console.WriteLine($"x1 = {root1}");
			Console.WriteLine($"x2 = {root2}");
		}
	}

}