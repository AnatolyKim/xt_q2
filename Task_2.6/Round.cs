using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._6
{
    public class Round
    {
        // Объявление основых переменных
        private double coordinateX;
        private double coordinateY;
        private double radius;
        // Установка начального корректного состояния
        public Round()
        {
            coordinateX = 0;
            coordinateY = 0;
            radius = 0;
        }
        // Определение свойств с соотвествующей проверкой на корректность
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value >= 0)
                {
                    radius = value;
                }
                else throw new ArgumentException("Radius can not be negative");
            }
        }
        public double Area
        {
            get { return Math.PI * radius * radius; }
        }
        public double CircleLength
        {
            get { return 2 * Math.PI * radius; }
        }
    }
}
