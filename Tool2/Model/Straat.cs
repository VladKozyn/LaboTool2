using System;
using System.Collections.Generic;
using System.Text;

namespace Tool2.Model
{
    public class Straat
    {
        public int straatId { get; set; }
        public string straatNaam { get; set; }
        public double lengteStraat { get; set; }
        public int gemeenteId { get; set; }

        public Straat(int straatId, string straatNaam, double lengteStraat, int gemeenteId)
        {
            this.straatId = straatId;
            this.straatNaam = straatNaam;
            this.lengteStraat = lengteStraat;
            this.gemeenteId = gemeenteId;
        }
    }
}
