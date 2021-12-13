using System;
using MyLib;

namespace FindSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            FindSquaresOfCircle();
            FindSquaresOfTriangle();
        }

        static void FindSquaresOfCircle()
        {
            FindSquaresOfFigures.FindSquaresOfCircle();
        }

        static void FindSquaresOfTriangle()
        {
            FindSquaresOfFigures.FindSquaresOfTriangle();
        }

    }
}
