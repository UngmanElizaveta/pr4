using GeomShape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleTest
{
    public class TriangleTest
    {
        const double area = 4.15;
        const double perimeter = 11;
        const int a = 3;
        const int b = 5;
        const int c = 3;


        [Fact]
        public void TryAreaTr()
        {
            Triangle triangle = new Triangle();
            double resultAreaTr = triangle.Area(a, b, c);
            Assert.Equal(area, resultAreaTr);

        }

        [Fact]
        public void Tryperimetertr()
        {
            Triangle triangle = new Triangle();
            double resultPerimTr = triangle.Perimeter(a, b, c);
            Assert.Equal(perimeter, resultPerimTr);
        }

    }
}