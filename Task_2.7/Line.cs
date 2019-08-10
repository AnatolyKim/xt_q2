using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._7
{
    public class Line:Figure
    {
        private double coordinateX1;
        private double coordinateY1;
        private double coordinateX2;
        private double coordinateY2;

        // Считаем что начало координат находится в левом нижнем углу окна редактора, координаты не могут быть отрицательными
        public double CoordinateX1
        {
            get { return coordinateX1; }
            set
            {
                if (value < 0) { throw new ArgumentException("Coordinate X1 can not be negative"); }
                coordinateX1 = value;
            }
        }

        public double CoordinateY1
        {
            get { return coordinateY1; }
            set
            {
                if (value < 0) { throw new ArgumentException("Coordinate Y1 can not be negative"); }
                coordinateY1 = value;
            }
        }
        public double CoordinateX2
        {
            get { return coordinateX1; }
            set
            {
                if (value < 0) { throw new ArgumentException("Coordinate X2 can not be negative"); }
                coordinateX2 = value;
            }
        }
        public double CoordinateY2
        {
            get { return coordinateX1; }
            set
            {
                if (value < 0) { throw new ArgumentException("Coordinate Y2 can not be negative"); }
                coordinateY2 = value;
            }
        }

        public override void Draw()
        {
            SetInputData();
            Console.WriteLine(string.Format("Line with start coordinates {0:0.00} {1:0.00} and end coordinates {2:0.00} {3:0.00} is drawn", 
                               coordinateX1,coordinateY1,coordinateX2,coordinateY2));
        }

        public void SetInputData()
        {
            Console.WriteLine("Input coordinate X1:");
            CoordinateX1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input coordinate Y1:");
            CoordinateY1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input coordinate X2:");
            CoordinateX2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input coordinate Y2:");
            CoordinateY2 = double.Parse(Console.ReadLine());
        }
    }
}
