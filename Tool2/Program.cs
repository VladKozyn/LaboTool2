using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            Databeheer databeheer = new Databeheer(@"Data Source =.\SQLEXPRESS; Initial Catalog = Labo; Integrated Security = True");
            //   List<Provincie> listProvincies = leesTxtBestandEnVerwerk.maakListVanProvincies(leesTxtBestandEnVerwerk.provinciesData()); //list van gebruikte Provincies
            //   List<Gemeente> listGemeentes = leesTxtBestandEnVerwerk.maakListVanGemeente(leesTxtBestandEnVerwerk.GemeenteData()); //list van gebruikte Gemeentes
            //   List<Straat> listStraten = leesTxtBestandEnVerwerk.maakListVanStraten(leesTxtBestandEnVerwerk.stratenData()); //list van gebruikte Straten
          //  List<Graaf> listGraven = leesTxtBestandEnVerwerk.maakListVanGraven(leesTxtBestandEnVerwerk.graafData()); //list van gebruikte Graven
            List<Knoop> listKnopen = leesTxtBestandEnVerwerk.maakListVanKnopen(leesTxtBestandEnVerwerk.KnopenData()); //list van gebruikte Knopen
          //  List<Segment> listSegmenten = leesTxtBestandEnVerwerk.maakListVanSegmenten(leesTxtBestandEnVerwerk.segmentenData()); //list van gebruikte Segmenten
          //  List<Punt> listPunten = leesTxtBestandEnVerwerk.maakListVanPunten(leesTxtBestandEnVerwerk.puntenData()); //list van gebruikte Punten

            //  databeheer.voegProvinciesToe(listProvincies);
            //  databeheer.voegGemeentesToe(listGemeentes);
            //  databeheer.voegStratenToe(listStraten);
          //  databeheer.voegGravenToe(listGraven);
            databeheer.voegKnopenToe(listKnopen);
         //   databeheer.voegSegmentenToe(listSegmenten);
         //   databeheer.voegPuntenToe(listPunten);
        }
    }
}
