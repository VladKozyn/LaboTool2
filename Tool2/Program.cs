using System;
using System.Collections.Generic;
using System.Text;
using Tool1;
using Tool2.Model;

namespace Tool2
{
    class Program
    {
       public static void Main(string[] args)
        {
            LeesTxtBestandEnVerwerk leesTxtBestandEnVerwerk = new LeesTxtBestandEnVerwerk();
            List<Provincie> listProvincies = leesTxtBestandEnVerwerk.maakListVanProvincies(leesTxtBestandEnVerwerk.provinciesData()); //list van gebruikte prov
            List<Gemeente> listGemeentes = leesTxtBestandEnVerwerk.maakListVanGemeente(leesTxtBestandEnVerwerk.GemeenteData()); //list van gebruikte prov
            List<Straat> listStraten = leesTxtBestandEnVerwerk.maakListVanStraten(leesTxtBestandEnVerwerk.stratenData()); //list van gebruikte prov
            List<Graaf> listGraven = leesTxtBestandEnVerwerk.maakListVanGraven(leesTxtBestandEnVerwerk.graafData()); //list van gebruikte prov
            List<Knoop> listKnopen = leesTxtBestandEnVerwerk.maakListVanKnopen(leesTxtBestandEnVerwerk.KnopenData()); //list van gebruikte prov
            List<Segment> listSegmenten = leesTxtBestandEnVerwerk.maakListVanSegmenten(leesTxtBestandEnVerwerk.segmentenData()); //list van gebruikte prov
            List<Punt> listPunten = leesTxtBestandEnVerwerk.maakListVanPunten(leesTxtBestandEnVerwerk.puntenData()); //list van gebruikte prov

        }
    }
}
