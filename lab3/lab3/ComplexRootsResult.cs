using System;

namespace lab3
{
	public class ComplexRootsResult : IQuadraticEquationResult
	{
		private readonly double realPart;
		private readonly double imaginaryPart;

		public ComplexRootsResult(double realPart, double imaginaryPart)
		{
			this.realPart = realPart;
			this.imaginaryPart = imaginaryPart;
		}

		public void Printing()
		{
			Console.WriteLine($"x1 = {realPart} + {imaginaryPart}i");
			Console.WriteLine($"x2 = {realPart} - {imaginaryPart}i");
		}
	}

}