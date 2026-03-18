using GeomShape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = GeomShape.Rectangle;

namespace RectangleTest
{
    public class RectangleTest1
    {
        const int width = 10;
        const int height = 10;
        const int widthError = -10;
        const int heightError = 0;
        const double area = 100;
        const double perimeter = 40;
        // const string error = "некорректные данные";

        //проверка на площадь 
        [Fact]
        public void TryArea()
        {
            Rectangle rectangle = new Rectangle();
            double resultArea = rectangle.Area(width, height);
            Assert.Equal(area, resultArea);

        }
        //пррверка на периметер
        [Fact]
        public void TryPerimeter()
        {
            Rectangle rectangle = new Rectangle();
            double resultPerimeter = rectangle.Perimeter(width, height);
            Assert.Equal(perimeter, resultPerimeter);

        }
        //пррверка на некорректность данных
        /*[Fact]
        public void TryData()
        {
            Rectangle rectangle = new Rectangle();
            string resultValidation = rectangle.Validation(widthError, heightError);
            Assert.Equal(error, resultValidation);

        }*/
    }
}