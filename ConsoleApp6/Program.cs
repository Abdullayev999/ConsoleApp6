using System;

namespace ConsoleApp6
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Triangle : IShape
    {
        private readonly double side1;
        private readonly double side2;
        private readonly double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double CalculateArea()
        {
            double semiperimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
        }

        public bool IsRightAngled()
        {
            double maxSide = Math.Max(Math.Max(side1, side2), side3);
            double sumOfSquares = Math.Pow(side1, 2) + Math.Pow(side2, 2) + Math.Pow(side3, 2) - Math.Pow(maxSide, 2);
            return sumOfSquares == Math.Pow(maxSide, 2);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            double circleArea = circle.CalculateArea();
            Console.WriteLine($"Area of the circle: {circleArea}");

            Triangle triangle = new Triangle(3, 4, 5);
            double triangleArea = triangle.CalculateArea();
            Console.WriteLine($"Area of the triangle: {triangleArea}");

            bool isRightAngled = triangle.IsRightAngled();
            Console.WriteLine($"Is the triangle right-angled? {isRightAngled}");

            Console.ReadLine();
        }
    }
}
