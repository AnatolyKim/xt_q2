using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._8
{
    class GameField
    {
        // Игровое поле размером 50х50
        public int Width { get { return 50; } }
        public int Height { get { return 50; } }
        public int[,] StatusCells = new int[50,50];
    }
}
