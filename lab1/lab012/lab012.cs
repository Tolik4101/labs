using System;

namespace lab012 {
    public class Rectangle
    {
        // Ниже представлены поля класса Rectangle
        // Так как эти поля имеют модификатор private
        // Доступ извне(например в Main) к ним получить нельзя
        // Доступ на чтение и запись имеют только методы этого класса
        private double side1;
        private double side2;

        // Конструктор принимает только и только(не 0) 2 аргумента - 2 стороны
        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
        }

        // Это методы класса Rectangle
        // Так как они имеют модификатор private, то их можно вызвать только внутри класса (методов класса)
        private double CalculateArea()
        {
            return side1 * side2;
        }

        private double CalculatePerimeter()
        {
            return 2 * (side1 + side2);
        }

        // А это свойства класса Rectangle
        // По своему использовании сильно похожи на поля
        // Но отличаются по своей "внутренней структуре"
        // В отличии от поля, свойства могут иметь разный модификатор доступа на чтение и запись
        // либо не иметь вообще функций записи и доступа
        // В данном примере, свойство имеет публичный геттер(чтение) и не вообще имеет сеттера(записи)
        // getter - "де факто" функция возвращающая значение
        // setter - так же, функция записывающая значение в переменную
        // В зависимости от умысла разработчика, сеттеры и геттеры могут заниматься не просто
        // записью и получением значений, но и вызывом других функции, изменением других переменных и т.д.
        public double Area
        {
            get { return CalculateArea(); }
        }

        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }

    class lab012
    {
        static void Main(string[] args)
        {
            // Создаём экземпляр Rectangle и проверяем его работоспособность(подсчёт площади и периметра)
            Console.WriteLine("Enter the Side1:");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Side2:");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(sideA, sideB);

            Console.WriteLine($"Rectangle perimeter: {rectangle.Perimeter}");
            Console.WriteLine($"Rectangle area: {rectangle.Area}");
        }
    }
}