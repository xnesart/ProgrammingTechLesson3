using System;

namespace ProgrammingTechPracticTasks
{
    public struct Line
    {
        public Point pointStart;
        public Point pointEnd;
        public double Length() => pointStart.Distance(pointEnd);


        public Line(Point pointStart, Point pointEnd)
        {
            this.pointStart = pointStart;
            this.pointEnd = pointEnd;
        }
        
        /// <summary>
        /// Проверяет принадлежность точки отрезку
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool isBelongAtLine(Point point)
        {
            if (pointStart.Distance(point) + pointEnd.Distance(point) - Length() == 0)
            {
                return true;
            }
            return false;
        }
    }
}