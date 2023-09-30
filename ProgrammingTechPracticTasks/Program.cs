using System;

namespace ProgrammingTechPracticTasks
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Задание 1. Точка
            Console.WriteLine("задание 1");
            Point somePoint = new Point(2, 2);
            double pointResult = somePoint.Distance();
            Console.WriteLine("Расстояние точки от начала координат = " + pointResult);
            //Задание 2. Линия
            Console.WriteLine("задание 2");
            Point point1 = new Point(2, 2);
            Point point2 = new Point(1, 3);
            Line line = new Line(point1, point2);
            double length = line.GetLength();
            Console.WriteLine("Длина линии = " + length);
            Console.WriteLine("принадлежность точки отрезку = " + line.isBelong(somePoint, point1, point2));
            //Задание 3. Квадрат
            Console.WriteLine("задание 3");
            Point squarePoint = new Point(5, 5);
            Square square = new Square(squarePoint, 3);
            double perimeter = square.getPerimeter();
            double getSquare = square.getSquare();
            Console.WriteLine("площадь квадрата = " + getSquare);
            Console.WriteLine("периметр квадрата = " + perimeter);


            //Использование перечислений в C#
            ConveyerControl conveyerControl = new ConveyerControl();
            Console.WriteLine(
                "Нажмите стрелку вправо для запуска конвеера, стрелку влево - остановка, стрелку вверх - лента вперёд, стрелку вниз - лента назад");
            Console.WriteLine("Нажмите пробел чтобы выйти из управления конвеером");
            while (true)
            {
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.LeftArrow)
                {
                    conveyerControl.Conveyer(ConveyerControl.Action.Stop);
                }
                else if (input.Key == ConsoleKey.RightArrow)
                {
                    conveyerControl.Conveyer(ConveyerControl.Action.Start);
                }
                else if (input.Key == ConsoleKey.UpArrow)
                {
                    conveyerControl.Conveyer(ConveyerControl.Action.Forward);
                }
                else if (input.Key == ConsoleKey.DownArrow)
                {
                    conveyerControl.Conveyer(ConveyerControl.Action.Back);
                }
                else if (input.Key == ConsoleKey.Spacebar)
                {
                    Console.WriteLine("Выходим");
                    return;
                }
            }
        }
    }
}