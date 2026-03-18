using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomShape
{
    public class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public double Area(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
            double poluperimeter = (SideA + SideB + SideC) / 2;

            return Math.Round(Math.Sqrt(poluperimeter * (poluperimeter - SideA) * (poluperimeter - SideB) * (poluperimeter - SideC)), 2);
        }

        public double Perimeter(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
            return SideA + SideB + SideC;
        }

        public string ToString()
        {
            return $"Пощадь треугольника {Area} периметр треугольника {Perimeter}";

        }

        public string Validation(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
            if (SideA < SideB + SideC)
                return "некорректные данные";
            if (SideB < SideA + SideC)
                return "некорректные данные";
            if (SideC < SideB + SideA)
                return "некорректные данные";
            if (SideA == 0 || SideB == 0 || SideC == 0)
                return "некорректные данные";

            return "";
        }


    }
}
