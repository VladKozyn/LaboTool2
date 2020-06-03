using System;
using System.Collections.Generic;
using System.Text;

namespace Tool2.Model
{
    public class Knoop
    {
        public int knoopId { get; set; }
        public int puntX { get; set; }
        public int puntY { get; set; }
        public int graafId { get; set; }

        public Knoop(int knoopId, int puntX, int puntY, int graafId)
        {
            this.knoopId = knoopId;
            this.puntX = puntX;
            this.puntY = puntY;
            this.graafId = graafId;
        }
    }
}
