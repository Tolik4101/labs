using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab012;

namespace test012 {

    // Аттрибут [TestClass] помечает данный класс для тестирования (не компилируется в программе)
    [TestClass]
    public class RectangleTests {
        // Данный аттрибут указывает, что данный метод является тестирующим методом(вызывается при тесте)
        // Здесь мы проверяем что класс возвращает правильную площадь (20) при передаче сторон 5 и 4
        [TestMethod]
        public void CalculateArea_ValidInput_ReturnsCorrectArea() {
            double sideA = 5.0;
            double sideB = 4.0;

            lab012.Rectangle rectangle = new lab012.Rectangle(sideA, sideB);

            double area = rectangle.Area; 

            Assert.AreEqual(20.0, area, 0.001);
        }
        // Здесь мы проверяем что класс возвращает правильный периметр (18) при передаче сторон 5 и 4
        [TestMethod]
        public void CalculatePerimeter_ValidInput_ReturnsCorrectPerimeter() {
            double sideA = 5.0;
            double sideB = 4.0;
            lab012.Rectangle rectangle = new lab012.Rectangle(sideA, sideB);

            double perimeter = rectangle.Perimeter;

            Assert.AreEqual(18.0, perimeter, 0.001);
        }
    }

}

