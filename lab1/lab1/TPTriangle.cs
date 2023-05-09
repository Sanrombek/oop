using System;

namespace Lab_1
{
    public class TPTriangle
    {

        public double Side { get; set; }

        public TPTriangle()
        {
            Console.WriteLine("Введiть значення сторони:");
            Side = double.Parse(Console.ReadLine());
        }

        public TPTriangle(double side)
        {
            Side = side;

        }

        public TPTriangle(TPTriangle pevTriangle)
        {
            Side = pevTriangle.Side;
        }

        public virtual double FindPer()
        {
            double per = Side * 3;
            if (per == 0)
            {
                Console.WriteLine("Трикутник не iснує");
                return 0;
            }
            return per;
        }
        public virtual double FindSqr()
        {
            double sqr = (Math.Abs(3) * Math.Pow((Side), 2)) / 4;
            if (sqr == 0)
            {
                Console.WriteLine("Трикутник не iснує");
                return 0;
            }
            return sqr;
        }

        public virtual void Compare(TPTriangle triangle1, TPTriangle triangle2)
        {
            double per1 = FindPer();
            double per2 = triangle2.FindPer();
            if (per1 > per2)
            {
                Console.WriteLine("Периметр першого трикутника бiльший");
            }
            else if (per1 == per2)
            {
                Console.WriteLine("Периметри рiвнi");
            }
            else
            {
                Console.WriteLine("Периметр другого трикутника бiльший");
            }

            double sqw1 = triangle1.FindSqr();
            double sqw2 = triangle2.FindSqr();
            if (sqw1 > sqw2)
            {
                Console.WriteLine("Площа першого трикутника бiльша");
            }
            else if (sqw1 == sqw2)
            {
                Console.WriteLine("Площi рiвнi");
            }
            else
            {
                Console.WriteLine("Площа другого трикутника бiльша");
            }

        }
        public virtual void ShowInfo()
        {
            if (Side == 0)
            {
                Console.WriteLine("Трикутник не iснує");
                return;
            }
            Console.WriteLine("Сторона: " + Side);
            Console.WriteLine("Площа: " + FindSqr());
            Console.WriteLine("Периметр: " + FindPer());
        }
        public static TPTriangle operator +(TPTriangle triangle1, TPTriangle triangle2)
        {
            return new TPTriangle((triangle1.Side + triangle2.Side));
        }
        public static TPTriangle operator -(TPTriangle triangle1, TPTriangle triangle2)
        {
            return new TPTriangle((triangle1.Side - triangle2.Side));
        }
        public static TPTriangle operator *(TPTriangle triangle1, int num)
        {
            return new TPTriangle((triangle1.Side * num));
        }
    }
}