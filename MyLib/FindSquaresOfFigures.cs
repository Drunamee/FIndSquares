using System;

namespace MyLib
{
    public class FindSquaresOfFigures
    {
        const double Pi = Math.PI;
        public static void FindSquaresOfCircle()
        {
            Console.WriteLine("Нахождение площади круга по его радиусу" + "\n" + "Введите радус круга");
            double circleRadius = Convert.ToDouble(Console.ReadLine());
            double squaresOfCircle = Pi * (circleRadius * circleRadius);
            Console.WriteLine("Площадь круга:" + " " + squaresOfCircle);
        }
        public static void FindSquaresOfTriangle() 
        {
            Console.WriteLine("\n" + "Нахождение площади треугольника методом Герона");
            Console.WriteLine("Введите длину стороны A");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину стороны B");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину стороны C");
            double c = Convert.ToDouble(Console.ReadLine());
            double semiPerimeter = (a + b + c) / 2;
            double squaresOfTriangle = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
            Console.WriteLine("Площадь треугольника:" + " " + squaresOfTriangle);
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
                Console.WriteLine("Треугольник прямоугольный");
            else
                Console.WriteLine("Треугольник не прямоугольный");
        }
    }
}
