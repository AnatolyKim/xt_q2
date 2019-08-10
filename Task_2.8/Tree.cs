using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._8
{
    class Tree:GameObject
    {
        public override int CoordinateX { get; set; }
        public override int CoordinateY { get; set; }

        public Tree()
        {
            Random rnd = new Random();
            CoordinateX = rnd.Next(0, 50);
            CoordinateY = rnd.Next(0, 50);
        }
    }
}
