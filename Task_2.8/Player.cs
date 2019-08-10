using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._8
{
    class Player:GameObject,IMovable
    {
        private int heathPoints;
        public override int CoordinateX { get; set; }
        public override int CoordinateY { get; set; }

        // Размещенение игрока в центре поля 50х50 и установка очков здоровья
        public Player()
        {
            CoordinateX = 25;
            CoordinateY = 25;
            heathPoints = 1;
        }
        // Получение координат после выбыра пользователя в качестве аргументов и массива с координатами препятствий (0 - свободное поле)
        public void Move(int x, int y,int [,]z)
        {
            if (z[x, y] == 0)
            {
                CoordinateX = x;
                CoordinateY = y;
            }
            else Console.WriteLine("Move in other direction");
        }
        // Поле бонуса не считается преградой, текущие координаты и массив с координатами бонусов в качестве аргументов
        public void GetBonus(int x, int y, int [,]b)
        {
            if (b[x,y]==1)
            {
                heathPoints++;
            }
        }
    }
}
