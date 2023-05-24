using System;

namespace lab3
{
	public class QuadraticEquationSolver
	{
		public static IQuadraticEquationResult Solve(double a, double b, double c)
		{
			double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                // Комплексні корені
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                return new ComplexRootsResult(realPart, imaginaryPart);
            }
            else if (discriminant == 0)
            {
                // Рівні дійсні корені
                double root = -b / (2 * a);
                return new RealEqualRootsResult(root);
            }
            else
            {
                // Різні дійсні корені
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new RealDistinctRootsResult(root1, root2);
            }

        }
    }

}