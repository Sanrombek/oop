using System;

namespace lab3
{
	public class RealEqualRootsResult : IQuadraticEquationResult
	{
		private readonly double root;

		public RealEqualRootsResult(double root)
		{
			this.root = root;
		}

		public void Printing()
		{
			Console.WriteLine($"x1 = x2 = {root}");
		}
	}
}