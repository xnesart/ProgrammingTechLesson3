using System;

namespace ProgrammingTechPracticTasks
{
    //1.	Создать структуру Point, описывающей точку на плоскости, заданную декартовыми координатами.
    //Среди методов Point предусмотреть метод Distance, вычисляющий расстояние до заданной точки.  
    public struct Point
    {
        public double CoordinatesX;
        public double CoordinatesY;

        public Point(double coordinatesX, double coordinatesY)
        {
            this.CoordinatesX = coordinatesX;
            this.CoordinatesY = coordinatesY;
        }

        /// <summary>
        /// вычисляет расстояние от точки до начала координат
        /// </summary>
        /// <returns></returns>
        public double Distance()
        {
            return Math.Sqrt(Math.Pow(CoordinatesX - 0, 2) + Math.Pow(CoordinatesY - 0, 2));
        }

        public double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow(CoordinatesX - point.CoordinatesX, 2) +
                             Math.Pow(CoordinatesY - point.CoordinatesY, 2));
        }
    }
}