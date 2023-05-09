using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class TPiramid : TPTriangle
    {
        public double Side2 { get; set; }

        public TPiramid()
        {
            Console.WriteLine("Введiть значення ребра:");
            Side2 = double.Parse(Console.ReadLine());
        }

        public TPiramid(double side, double side2)
        {
            Side = side;
            Side2 = side2;

        }
        public double FindPerBase()
        {
            double perB = Side * 3;
            if (perB == 0)
            {
                Console.WriteLine("Трикутник не iснує");
                return 0;
            }
            return perB;
        }
        public double FindPerS()
        {
            double perS = Side2 * 2 + Side;
            if (perS == 0)
            {
                Console.WriteLine("Трикутник не iснує");
                return 0;
            }
            return perS;
        }
        public override double FindSqr()
        {
            double h = Math.Sqrt(Math.Pow(Side2, 2) - Math.Pow((Side / 2), 2));

            double sqr = (Math.Sqrt(3) * Math.Pow((Side), 2)) + (1 / 2 * Side2 * h);
            if (sqr == 0)
            {
                Console.WriteLine("Трикутник не iснує");
                return 0;
            }
            return sqr;
        }


        public double FindCapacity()
        {
            double r = Side / Math.Sqrt(3);
            double h = Math.Sqrt(Math.Pow(Side2, 2) - Math.Pow(r, 2));

            double capacity = (Math.Sqrt(3) * Math.Pow((r), 2) * h) / 4;

            if (capacity == 0)
            {
                Console.WriteLine("Трикутник не iснує");
                return 0;
            }
            return capacity;
        }
        public override void ShowInfo()
        {
            if (Side == 0 || Side2 == 0)
            {
                Console.WriteLine("Трикутник не iснує");
                return;
            }
            Console.WriteLine("Сторона : " + Side);
            Console.WriteLine("Ребро: " + Side2);
            Console.WriteLine("Периметр основи: " + FindPerBase());
            Console.WriteLine("Периметр бiчної гранi: " + FindPerS());
            Console.WriteLine("Площа поверхнi: " + FindSqr());
            Console.WriteLine("Об'єм: " + FindCapacity());
        }
    }
}