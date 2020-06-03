using System;
using System.Collections.Generic;
using System.Text;

namespace Tool2.Model
{
    public class Segment
    {
        public int segmentId { get; set; }
        public double beginKnoop { get; set; }
        public double eindKnoop { get; set; }
        public int knoopId { get; set; }

        public Segment(int segmentId, double beginKnoop, double eindKnoop, int knoopId)
        {
            this.segmentId = segmentId;
            this.beginKnoop = beginKnoop;
            this.eindKnoop = eindKnoop;
            this.knoopId = knoopId;
        }
    }
}