using System;

namespace ProgrammingTechPracticTasks
{
    public struct Line
    {
        public Point pointStart;
        public Point pointEnd;


        public Line(Point pointStart, Point pointEnd)
        {
            this.pointStart = pointStart;
            this.pointEnd = pointEnd;
        }

        public bool isBelong(Point checkPoint, Point pointStart, Point pointEnd)
        {
            if ((checkPoint.CoordinatesX - pointStart.CoordinatesX) /
                (pointEnd.CoordinatesX - pointStart.CoordinatesX) ==
                (checkPoint.CoordinatesY - pointStart.CoordinatesY) / (pointEnd.CoordinatesY - pointStart.CoordinatesY))
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// вычисляет длину линии
        /// </summary>
        /// <returns></returns>
        public double GetLength()
        {
            return Math.Sqrt(Math.Pow((pointEnd.CoordinatesX - pointStart.CoordinatesX), 2) +
                             Math.Pow((pointEnd.CoordinatesY - pointStart.CoordinatesY), 2));
        }
    }
}