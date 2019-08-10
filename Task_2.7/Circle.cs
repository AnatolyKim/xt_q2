using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._7
{
    public class Circle:Figure
    {
        private double coordinateX;
        private double coordinateY;
        private double radius;

        // Считаем что начало координат находится в левом нижнем углу окна редактора, координаты не могут быть отрицательными
        public double CoordinateX
        {
            get { return coordinateX; }
            set
            {
                if (value < 0) { throw new ArgumentException("Coordinate X can not be negative"); }
                coordinateX = value;
            }
        }

        public double CoordinateY
        {
            get { return coordinateY; }
            set
            {
                if (value < 0) { throw new ArgumentException("Coordinate Y can not be negative"); }
                coordinateY = value;
            }
        }
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0) { throw new ArgumentException("Radius can not be negative"); }
                radius = value;
            }
        }

        public override void Draw()
        {
            SetInputData();
            Console.WriteLine(string.Format("Circle with coordinates {0:0.00} {1:0.00} and radius {2:0.00} is drawn",
                   coordinateX, coordinateY, radius));
        }

        public void SetInputData()
        {
            Console.WriteLine("Input coordinate X:");
            CoordinateX = double.Parse(Console.ReadLine());
            Console.WriteLine("Input coordinate Y:");
            CoordinateY = double.Parse(Console.ReadLine());
            Console.WriteLine("Input radius:");
            Radius = double.Parse(Console.ReadLine());
        }
    }
}
