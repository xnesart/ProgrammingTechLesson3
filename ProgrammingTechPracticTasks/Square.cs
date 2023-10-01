namespace ProgrammingTechPracticTasks
{
    public struct Square
    {
        public Point startPointSquare;
        public Line sideLength;
      

        public Square(Point leftTopAngle, int side)
        {
            startPointSquare = leftTopAngle;
            sideLength = new Line(leftTopAngle, new Point(leftTopAngle.CoordinatesX + side, leftTopAngle.CoordinatesY));
        }
        /// <summary>
        /// вычисляет площадь квадрата
        /// </summary>
        /// <returns></returns>
        public double getSquare()
        {
            return sideLength.Length() * sideLength.Length();
        }
        /// <summary>
        /// вычисляет периметр квадрата
        /// </summary>
        /// <returns></returns>
        public double getPerimeter()
        {
            return 4 * sideLength.Length();
        }
    }
}