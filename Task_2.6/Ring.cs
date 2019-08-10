using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._6
{
    class Ring
    {
        public Round inner;
        public Round outer;

        public Ring()
        {
            inner = new Round { Radius = 0, CoordinateX = 0, CoordinateY = 0 };
            outer = new Round { Radius = 1, CoordinateX = 0, CoordinateY = 0 };
        }

        public Ring(double innR,double outR,double coordinateX,double coordinateY)
        {
            if (innR > outR) throw new ArgumentException("Inner Radius can not be bigger than outer Radius");
            inner = new Round { Radius = innR, CoordinateX = coordinateX, CoordinateY = coordinateY };
            outer = new Round { Radius = outR, CoordinateX = coordinateX, CoordinateY = coordinateY };
        }

        public double Area
        {
           get { return outer.Area - inner.Area; }
        }

        public double RingLength
        {
            get { return outer.CircleLength + inner.CircleLength; }
        }

    }
}
