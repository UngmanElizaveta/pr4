using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomShape
{
    public class Rectangle
    {
        public double Width
        {
            get; set;
        }
        public double Height
        {
            get; set;
        }


        public double Area(double width, double height)
        {
            Width = width;
            Height = height;
            double _area = Width * Height;
            return _area;
        }
        public double Perimeter(double width, double height)
        {
            Width = width;
            Height = height;
            double _perimetr = (Width + Height) * 2;
            return _perimetr;
        }
        public string ToString()
        {
            return $"Площадь прямоугольника равна {Area} и периметр равен {Perimeter}";
        }
        public string Validation(double width, double height)
        {
            Width = width;
            Height = height;
            if (width < 0)
                return "некорректные данные";
            if (width == 0)
                return "некорректные данные";
            if (height < 0)
                return "некорректные данные";
            if (height == 0)
                return "некорректные данные";

            return "";
        }

    }
}
