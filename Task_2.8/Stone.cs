using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._8
{
    class Stone : GameObject
    {
        public override int CoordinateX { get; set; }
        public override int CoordinateY { get; set; }

        public Stone()
        {
            Random rnd = new Random();
            CoordinateX = rnd.Next(0, 50);
            CoordinateY = rnd.Next(0, 50);
        }
    }
}
