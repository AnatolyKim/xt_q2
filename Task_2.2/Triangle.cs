using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2
{
    public class Triangle
    {
        // Перменные для сторон треугольника
        private double a;
        private double b;
        private double c;
        // Установка начального корректного состояния
        public Triangle()
        {
            a = 1;
            b = 1;
            c = 1;
        }
        // Объявление свойств с соотвествующей проверкой устанавливаемых значений
        public double A
        {
            get { return a; }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
                else throw new ArgumentException("Length can not be negative or zero");
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else throw new ArgumentException("Length can not be negative or zero");
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (value > 0)
                {
                    c = value;
                }
                else throw new ArgumentException("Length can not be negative or zero");
            }
        }
        // Расчет площади в свойстве по Формуле герона 
        public double Area
        {
            get { return Math.Sqrt(Perimeter * (Perimeter - a) * (Perimeter - b) * (Perimeter - c)); }
        }
        // Определение периметра
        public double Perimeter
        {
            get { return a + b + c; }
        }
    }
}
