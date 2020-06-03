using System;
using System.Collections.Generic;
using System.Text;

namespace Tool2.Model
{
    public class Graaf
    {
        public int graafId { get; set; }
        public int straatId { get; set; }

        public Graaf(int graafId, int straatId)
        {
            this.graafId = graafId;
            this.straatId = straatId;
        }
    }
}
