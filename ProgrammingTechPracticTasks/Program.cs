using System;

namespace ProgrammingTechPracticTasks
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Задание 1. Точка
            Console.WriteLine("задание 1");
            Point somePoint = new Point(3, 2);
            double pointResult = somePoint.Distance();
            Console.WriteLine("Расстояние точки от начала координат = " + pointResult);
            //Задание 2. Линия
            Console.WriteLine("задание 2");
            Point point1 = new Point(5, 2);
            Point point2 = new Point(1, 2);
            Line line = new Line(point1, point2);
            Console.WriteLine("Длина линии = " + line.Length());
            Console.WriteLine("принадлежность точки отрезку = " + line.isBelongAtLine(somePoint));
            //Задание 3. Квадрат
            Console.WriteLine("задание 3");
            Point squarePoint = new Point(3, 3);
            Square square = new Square(squarePoint, 2);
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