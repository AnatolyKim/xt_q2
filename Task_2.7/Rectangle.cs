using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._7
{
    public class Rectangle:Figure
    {
        // Строим прямоугольник по двум координатам
        private Line leftLine;
        private Line rightLine;
        private Line topLine;
        private Line bottomLine;
        private double coordinateX1;
        private double coordinateY1;
        private double coordinateX2;
        private double coordinateY2;

        public override void Draw()
        {
            SetInputData();
            leftLine = new Line { CoordinateX1 = coordinateX1, CoordinateY1 = coordinateY1, CoordinateX2 = coordinateX1, CoordinateY2 = coordinateY2 };
            rightLine = new Line { CoordinateX1 = coordinateX2, CoordinateY1 = coordinateY1, CoordinateX2 = coordinateX2, CoordinateY2 = coordinateY2 };
            topLine = new Line { CoordinateX1 = coordinateX1, CoordinateY1 = coordinateY2, CoordinateX2 = coordinateX2, CoordinateY2 = coordinateY2 };
            bottomLine = new Line { CoordinateX1 = coordinateX1, CoordinateY1 = coordinateY1, CoordinateX2 = coordinateX2, CoordinateY2 = coordinateY1 };
            Console.WriteLine(string.Format("Rectangle with start coordinates {0:0.00} {1:0.00} and end coordinates {2:0.00} {3:0.00} is drawn",
                   coordinateX1, coordinateY1, coordinateX2, coordinateY2));
        }

        public void SetInputData()
        {
            Console.WriteLine("Input coordinate X1:");
            coordinateX1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input coordinate Y1:");
            coordinateY1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input coordinate X2:");
            coordinateX2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input coordinate Y2:");
            coordinateY2 = double.Parse(Console.ReadLine());
        }
    }
}
