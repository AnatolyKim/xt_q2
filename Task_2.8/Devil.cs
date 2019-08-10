using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._8
{
    // Охотник за игроком
    class Devil:GameObject,IMovable
    {
        public override int CoordinateX { get; set; }
        public override int CoordinateY { get; set; }

        // Начальное случайное размещение
        public Devil()
        {
            Random rnd = new Random();
            CoordinateX = rnd.Next(0,50);
            CoordinateY = rnd.Next(0,50);
        }
        // Получение координат игрока и массив, описывающий состояние игрового поля (занято/свободно от препятствий) в качестве аргументов
        public void Move(int x, int y, int [,]z)
        {
            if (x > CoordinateX && z[CoordinateY, CoordinateX + 1] == 0) CoordinateX++;
            if (x < CoordinateX && z[CoordinateY, CoordinateX - 1] == 0) CoordinateX--;
            if (y > CoordinateX && z[CoordinateY + 1, CoordinateX] == 0) CoordinateY++;
            if (y < CoordinateX && z[CoordinateY - 1, CoordinateX] == 0) CoordinateY--;
        }
        // Проверка находится ли в текущей ячейке игрок, если да, то снимаем здоровье; аргументы - координаты игрока и его здоровье
        public void CheckIfCaught(int x, int y,int z)
        {
            if(CoordinateX==x && CoordinateY == y)
            {
                z--;
                if (z == 0)
                {
                    Console.WriteLine("Game over");
                }
            }
        }
    }
}
