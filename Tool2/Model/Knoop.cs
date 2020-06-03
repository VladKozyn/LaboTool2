using System;
using System.Collections.Generic;
using System.Text;

namespace Tool2.Model
{
    public class Knoop
    {
        public int knoopId { get; set; }
        public double puntX { get; set; }
        public double puntY { get; set; }
        public int graafId { get; set; }

        public Knoop(int knoopId, double puntX, double puntY, int graafId)
        {
            this.knoopId = knoopId;
            this.puntX = puntX;
            this.puntY = puntY;
            this.graafId = graafId;
        }
    }
}
