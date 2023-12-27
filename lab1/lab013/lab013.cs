using System;

namespace lab013
{
    public class Point
    {
        // Поля содержащие x,y точки
        private int x;
        private int y;


        // Свойство X
        // Имеет публичный геттер (можно прочитать x)
        // И приватный сеттер (в x можно записать только внутри класса)
        public int X
        {
            get { return x; }
            private set { x = value; }
        }

        public int Y
        {
            get { return y; }
            private set { y = value; }
        }

        // Конструктор принимающий только и только 2 аргумента
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Figure
    {
        private List<Point> points;
        
        // Автосвойство Name
        // на данный момент абсолютно ничем не отличается от поля
        public string Name
        {
            get;
            set;
        }

        // Первый конструктор, который принимает 5 точек
        // Если некоторые последние точки являются null - не добавляет их в список точек
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new List<Point>
            {
                p1,
                p2,
                p3
            };
            if (p4 != null)
            {
                points.Add(p4);
            }
            if (p5 != null)
            {
                points.Add(p5);
            }
        }

        // Конструктор принимающий 4 точки
        // Вызывает конструктор (свой же) который принимает 5 точек и вместо последней точки - null
        public Figure(Point p1, Point p2, Point p3, Point p4) : this(p1, p2, p3, p4, null)
        {

        }
        // Такая же логика но с 3мя точками
        public Figure(Point p1, Point p2, Point p3) : this(p1, p2, p3, null, null)
        {

        }

        // Формула длины отрезка с линейной алгебры
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        // Периметр это сумма последовательных расстояний между точками
        // и расстояния между первой и последней (контур замкнут всегда)
        public double PerimeterCalculator()
        {
            double perimeter = 0;

            for (int i = 0; i < points.Count - 1; ++i)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }

            perimeter += LengthSide(points[points.Count - 1], points[0]);
            Console.WriteLine($"The figure {Name} - perimeter: {perimeter}");
            return perimeter;
        }
    }

    class lab013
    {
        static void Main()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 1);
            Point p3 = new Point(1, 1);
            Point p4 = new Point(1, 0);
            // Создаём фигуру с 3мя точками(треугольник)
            Figure triangle = new Figure(p1, p2, p3)
            {
                Name = "triangle",
            };
            // Создаём фигуру с 4мя точками(квадрат)
            Figure square = new Figure(p1, p2, p3, p4)
            {
                Name = "squar",
            };

            triangle.PerimeterCalculator();
            square.PerimeterCalculator();
        }
    }
}