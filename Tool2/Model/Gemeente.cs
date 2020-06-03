using System;
using System.Collections.Generic;
using System.Text;

namespace Tool2.Model
{
    public class Gemeente
    {
        public int gemeenteId { get; set; }
        public string gemeenteNaam { get; set; }
        public int totaalAantalStraten { get; set; }
        public int provincieId { get; set; }

        public Gemeente(int gemeenteId, string gemeenteNaam, int totaalAantalStraten, int provincieId)
        {
            this.gemeenteId = gemeenteId;
            this.gemeenteNaam = gemeenteNaam;
            this.totaalAantalStraten = totaalAantalStraten;
            this.provincieId = provincieId;
        }
    }
}
