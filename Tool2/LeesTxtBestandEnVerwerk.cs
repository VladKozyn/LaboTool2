using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Tool2.Model;

namespace Tool1
{
    public class LeesTxtBestandEnVerwerk
    {
        public LeesTxtBestandEnVerwerk()
        {
        }
        //leest alle wegsegmenten en steeks ze in een list list
        public List<List<String>> segmentenData()
        {
            List<List<String>> ListGesorteerdData = new List<List<string>>();
            using (StreamReader sr = new StreamReader(@"C:\Users\lieke\OneDrive\scool\prog 3\Labo\1\repository\MyFiles\Segmenten.txt"))
            {
                string[] currentLineChopped;
                int LineTeller = 0;
                string currentLine;
                sr.ReadLine();
                // currentLine moet null zijn als het einde bereikt
                while ((currentLine = sr.ReadLine()) != null)
                {
                    ListGesorteerdData.Add(new List<String>());
                    currentLineChopped = currentLine.Split(';');
                    for (int i = 0; i < currentLineChopped.Length; i++)
                    {

                        ListGesorteerdData[LineTeller].Add(currentLineChopped[i]);

                    }
                    LineTeller++;


                }
            }
            return ListGesorteerdData;
            /*segmentId[0];beginKnoop[1];eindKnoop[2];knoopId[3]*/
        }

        //vraagt de list list van alle wegsegmenten en steekt ze in een lijst van segmenten
        public List<Segment> maakListVanSegmenten(List<List<String>> wegSegmentenListText)
        {
            List<Segment> listMetWegsegmenten = new List<Segment>();
            for (int i = 0; i < wegSegmentenListText.Count; i++)
            {
                int segmentId = int.Parse(wegSegmentenListText[i][0]);
                int beginKnoop = int.Parse(wegSegmentenListText[i][1]);
                int eindKnoop = int.Parse(wegSegmentenListText[i][2]);
                int knoopId = int.Parse(wegSegmentenListText[i][3]);

                listMetWegsegmenten.Add(new Segment(segmentId, beginKnoop, eindKnoop, knoopId));
            }
            return listMetWegsegmenten;
            /*segmentId[0];beginKnoop[1];eindKnoop[2];knoopId[3]*/
        }


        //leest alle gemeentes en steeks ze in een list list
        public List<List<String>> GemeenteData()
        {
            List<List<String>> ListGesorteerdData = new List<List<string>>();
            using (StreamReader sr = new StreamReader(@"C:\Users\lieke\OneDrive\scool\prog 3\Labo\1\repository\MyFiles\Gemeente.txt"))
            {
                string[] currentLineChopped;
                int LineTeller = 0;
                string currentLine;
                sr.ReadLine();
                // currentLine moet null zijn als het einde bereikt
                while ((currentLine = sr.ReadLine()) != null)
                {
                    ListGesorteerdData.Add(new List<String>());
                    currentLineChopped = currentLine.Split(';');
                    for (int i = 0; i < currentLineChopped.Length; i++)
                    {

                        ListGesorteerdData[LineTeller].Add(currentLineChopped[i]);

                    }
                    LineTeller++;


                }
            }
            return ListGesorteerdData;
            /*gemeenteId[0];gemeenteNaam[1];totaalAantalStraten[2];provincieId[3]*/
        }

        //vraagt de list list van alle gemeentes en steekt ze in een lijst van gemeentes
        public List<Gemeente> maakListVanGemeente(List<List<String>> gemeenteListText)
        {
            List<Gemeente> listMetGemeentes = new List<Gemeente>();
            for (int i = 0; i < gemeenteListText.Count; i++)
            {
                int gemeenteId = int.Parse(gemeenteListText[i][0]);
                string gemeenteNaam = gemeenteListText[i][1];
                int totaalAantalStraten = int.Parse(gemeenteListText[i][2]);
                int provincieId = int.Parse(gemeenteListText[i][3]);

                listMetGemeentes.Add(new Gemeente(gemeenteId, gemeenteNaam, totaalAantalStraten, provincieId));
            }
            return listMetGemeentes;
            /*gemeenteId[0];gemeenteNaam[1];totaalAantalStraten[2];provincieId[3]*/
        }

        //leest alle graven en steeks ze in een list list
        public List<List<String>> graafData()
        {
            List<List<String>> ListGesorteerdData = new List<List<string>>();
            using (StreamReader sr = new StreamReader(@"C:\Users\lieke\OneDrive\scool\prog 3\Labo\1\repository\MyFiles\Graaf.txt"))
            {
                string[] currentLineChopped;
                int LineTeller = 0;
                string currentLine;
                sr.ReadLine();
                // currentLine moet null zijn als het einde bereikt
                while ((currentLine = sr.ReadLine()) != null)
                {
                    ListGesorteerdData.Add(new List<String>());
                    currentLineChopped = currentLine.Split(';');
                    for (int i = 0; i < currentLineChopped.Length; i++)
                    {

                        ListGesorteerdData[LineTeller].Add(currentLineChopped[i]);

                    }
                    LineTeller++;


                }
            }
            return ListGesorteerdData;
            /*GraafId;straatId*/
        }

        //vraagt de  list list van alle graven en steekt ze in een lijst van graven
        public List<Graaf> maakListVanGraven(List<List<String>> gravenLijst)
        {
            List<Graaf> listMetGraven = new List<Graaf>();
            for (int i = 0; i < gravenLijst.Count; i++)
            {

                int graafId = int.Parse(gravenLijst[i][0]);
                int straatId = int.Parse(gravenLijst[i][1]);

                listMetGraven.Add(new Graaf(graafId, straatId));
            }
            return listMetGraven;
            /*graafId[0];straatId[1]*/
        }

        //leest alle Knopen en steeks ze in een list list
        public List<List<String>> KnopenData()
        {
            List<List<String>> ListGesorteerdData = new List<List<string>>();
            using (StreamReader sr = new StreamReader(@"C:\Users\lieke\OneDrive\scool\prog 3\Labo\1\repository\MyFiles\Knopen.txt"))
            {
                string[] currentLineChopped;
                int LineTeller = 0;
                string currentLine;
                sr.ReadLine();
                // currentLine moet null zijn als het einde bereikt
                while ((currentLine = sr.ReadLine()) != null)
                {
                    ListGesorteerdData.Add(new List<String>());
                    currentLineChopped = currentLine.Split(';');
                    for (int i = 0; i < currentLineChopped.Length; i++)
                    {

                        ListGesorteerdData[LineTeller].Add(currentLineChopped[i]);

                    }
                    LineTeller++;


                }
            }
            return ListGesorteerdData;
            /*knoopId[0];puntX[1];puntY[2];graafId[3]*/
        }

        //vraagt de list list van alle Knopen en steekt ze in een lijst van Knopen
        public List<Knoop> maakListVanKnopen(List<List<String>> knopenListText)
        {
            List<Knoop> listMetKnopen = new List<Knoop>();
            for (int i = 0; i < knopenListText.Count; i++)
            {
                int knoopId = int.Parse(knopenListText[i][0]);
                double puntX = double.Parse(knopenListText[i][1]);
                double puntY = double.Parse(knopenListText[i][2]);
                int graafId = int.Parse(knopenListText[i][3]);

                listMetKnopen.Add(new Knoop(knoopId, puntX, puntY, graafId));
            }

            return listMetKnopen;
            /*knoopId[0];puntX[1];puntY[2];graafId[3]*/
        }

        //leest alle Provincies en steeks ze in een list list
        public List<List<String>> provinciesData()
        {
            List<List<String>> ListGesorteerdData = new List<List<string>>();
            using (StreamReader sr = new StreamReader(@"C:\Users\lieke\OneDrive\scool\prog 3\Labo\1\repository\MyFiles\Provincies.txt"))
            {
                string[] currentLineChopped;
                int LineTeller = 0;
                string currentLine;
                sr.ReadLine();
                // currentLine moet null zijn als het einde bereikt
                while ((currentLine = sr.ReadLine()) != null)
                {
                    ListGesorteerdData.Add(new List<String>());
                    currentLineChopped = currentLine.Split(';');
                    for (int i = 0; i < currentLineChopped.Length; i++)
                    {

                        ListGesorteerdData[LineTeller].Add(currentLineChopped[i]);

                    }
                    LineTeller++;


                }
            }
            return ListGesorteerdData;
            /*provincieID[0];provincieNaam[1]*/
        }

        //vraagt de list list van alle Provincies en steekt ze in een lijst van Provincies
        public List<Provincie> maakListVanProvincies(List<List<String>> ProvinciesListText)
        {
            List<Provincie> listMetProvincies = new List<Provincie>();
            for (int i = 0; i < ProvinciesListText.Count; i++)
            {

                int provincieId = int.Parse(ProvinciesListText[i][0]);
                string provincieNaam = ProvinciesListText[i][1];

                listMetProvincies.Add(new Provincie(provincieId, provincieNaam));
            }
            return listMetProvincies;
            /*provincieID[0];provincieNaam[1]*/
        }

        //leest alle Punten en steeks ze in een list list
        public List<List<String>> puntenData()
        {
            List<List<String>> ListGesorteerdData = new List<List<string>>();
            using (StreamReader sr = new StreamReader(@"C:\Users\lieke\OneDrive\scool\prog 3\Labo\1\repository\MyFiles\Punten.txt"))
            {
                string[] currentLineChopped;
                int LineTeller = 0;
                string currentLine;
                sr.ReadLine();
                // currentLine moet null zijn als het einde bereikt
                while ((currentLine = sr.ReadLine()) != null)
                {
                    ListGesorteerdData.Add(new List<String>());
                    currentLineChopped = currentLine.Split(';');
                    for (int i = 0; i < currentLineChopped.Length; i++)
                    {

                        ListGesorteerdData[LineTeller].Add(currentLineChopped[i]);

                    }
                    LineTeller++;


                }
            }
            return ListGesorteerdData;
            /*puntX[0];puntY[1];segmentId[2]*/
        }

        //vraagt de list list van alle Punten en steekt ze in een lijst van Punten
        public List<Punt> maakListVanPunten(List<List<String>> puntenListText)
        {
            List<Punt> listMetWegsegmenten = new List<Punt>();
            for (int i = 0; i < puntenListText.Count; i++)
            {
                double puntX = double.Parse(puntenListText[i][0]);
                double puntY = double.Parse(puntenListText[i][1]);
                int segmentId = int.Parse(puntenListText[i][2]);
                
                listMetWegsegmenten.Add(new Punt(puntX, puntY, segmentId));
            }
            return listMetWegsegmenten;
            /*puntX[0];puntY[1];segmentId[2]*/

        }

        //leest alle straten en steeks ze in een list list
        public List<List<String>> stratenData()
        {
            List<List<String>> ListGesorteerdData = new List<List<string>>();
            using (StreamReader sr = new StreamReader(@"C:\Users\lieke\OneDrive\scool\prog 3\Labo\1\repository\MyFiles\Straat.txt"))
            {
                string[] currentLineChopped;
                int LineTeller = 0;
                string currentLine;
                sr.ReadLine();
                // currentLine moet null zijn als het einde bereikt
                while ((currentLine = sr.ReadLine()) != null)
                {
                    ListGesorteerdData.Add(new List<String>());
                    currentLineChopped = currentLine.Split(';');
                    for (int i = 0; i < currentLineChopped.Length; i++)
                    {

                        ListGesorteerdData[LineTeller].Add(currentLineChopped[i]);

                    }
                    LineTeller++;


                }
            }
            return ListGesorteerdData;
            /*straatId[0];straatNaam[1];lengteStraat[2];gemeenteId[3]*/
        }

        //vraagt de list list van alle straten en steekt ze in een lijst van straten
        public List<Straat> maakListVanStraten(List<List<String>> straatListText)
        {
            List<Straat> listMetStraten = new List<Straat>();
            for (int i = 0; i < straatListText.Count; i++)
            {
                int straatId = int.Parse(straatListText[i][0]);
                string straatNaam = straatListText[i][1];
                double lengteStraat = double.Parse(straatListText[i][2]);
                int gemeenteId = int.Parse(straatListText[i][3]);

                listMetStraten.Add(new Straat(straatId, straatNaam, lengteStraat, gemeenteId));
            }
            return listMetStraten;
            /*straatId[0];straatNaam[1];lengteStraat[2];gemeenteId[3]*/
        }

    }

}
