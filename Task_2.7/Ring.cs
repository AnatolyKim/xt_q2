using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._7
{
    public class Ring:Figure
    {
        private Circle inner;
        private Circle outer;
        private double coordinateX;
        private double coordinateY;
        private double innerRadius;
        private double outerRadius;

        public override void Draw()
        {
            SetInputData();
            inner = new Circle { Radius = innerRadius, CoordinateX = coordinateX, CoordinateY = coordinateY };
            outer = new Circle { Radius = outerRadius, CoordinateX = coordinateX, CoordinateY = coordinateY };
            Console.WriteLine(string.Format("Ring with coordinates x:{0:0.00} y:{1:0.00} and inner radius {2:0.00} outer radius {3:0.00} is drawn",
                   coordinateX, coordinateY, innerRadius,outerRadius));
        }

        public void SetInputData()
        {
            Console.WriteLine("Input coordinate X:");
            coordinateX = double.Parse(Console.ReadLine());
            Console.WriteLine("Input coordinate Y:");
            coordinateY = double.Parse(Console.ReadLine());
            Console.WriteLine("Input inner radius:");
            innerRadius = double.Parse(Console.ReadLine());
            Console.WriteLine("Input outer radius:");
            outerRadius = double.Parse(Console.ReadLine());
            if (innerRadius > outerRadius)
                throw new ArgumentException("Inner Radius can not be bigger than outer Radius");
        }
    }
}
