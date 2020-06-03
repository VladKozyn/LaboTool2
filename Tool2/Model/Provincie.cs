using System;
using System.Collections.Generic;
using System.Text;

namespace Tool2.Model
{
    public class Provincie
    {
        public int provincieId { get; set; }
        public string provincieNaam { get; set; }

        public Provincie(int provincieId, string provincieNaam)
        {
            this.provincieId = provincieId;
            this.provincieNaam = provincieNaam;
        }
    }
}
