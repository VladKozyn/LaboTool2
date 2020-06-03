using System;
using System.Collections.Generic;
using System.Text;

namespace Tool2.Model
{
    public class Punt
    {
        public double puntX { get; set; }
        public double puntY { get; set; }
        public int segmentId { get; set; }

        public Punt(double puntX, double puntY, int segmentId)
        {
            this.puntX = puntX;
            this.puntY = puntY;
            this.segmentId = segmentId;
        }
    }
}
