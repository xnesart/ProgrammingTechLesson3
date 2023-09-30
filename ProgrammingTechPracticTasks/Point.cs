using System;

namespace ProgrammingTechPracticTasks
{
    //1.	Создать структуру Point, описывающей точку на плоскости, заданную декартовыми координатами.
    //Среди методов Point предусмотреть метод Distance, вычисляющий расстояние до заданной точки.  
    public struct Point
    {
        public double CoordinatesX;
        public double CoordinatesY;

        public double DistanceFromStart;

        public Point(double coordinatesX, double coordinatesY)
        {
            CoordinatesX = coordinatesX;
            CoordinatesY = coordinatesY;
            DistanceFromStart = 0;
        }

        /// <summary>
        /// вычисляет расстояние от точки до начала координат
        /// </summary>
        /// <returns></returns>
        public double Distance()
        {
            return Math.Sqrt(Math.Pow(CoordinatesX, 2) + Math.Pow(CoordinatesY, 2));
        }
    }
}