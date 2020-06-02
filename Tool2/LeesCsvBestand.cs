﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
namespace Tool1
{
    public class LeesCsvBestand
    {
        public LeesCsvBestand()
        {
        }
        //leest alle wegsegmenten en steeks ze in een list list
        public List<List<String>> wegsegmentenData()

        {
            List<List<String>> ListGesorteerdData = new List<List<string>>();
            using (StreamReader sr = new StreamReader("C:/Users/lieke/OneDrive/scool/prog 3/Labo/1/repository/WRdata.csv"))
            {
                string[] currentLineChopped;
                int LineTeller = 0;
                string currentLine;
                sr.ReadLine();
                // currentLine moet null zijn als het einde bereikt
                while ((currentLine = sr.ReadLine()) != null)
                {
                    if (!currentLine.Contains(";-9;-9"))
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
            }
            return ListGesorteerdData;
            /*wegsegmentID [0];
  geo [1];
  morfologie [2];
  status [3];
  beginWegknoopID [4];
  eindWegknoopID [5];
  linksStraatnaamID [6];
  rechtsStraatnaamID [7]*/
        }

        //vraagt de lijst van alle wegsegmenten en steekt ze in een lijst van segmenten
        public List<Segment> maakListVanSegmenten(List<List<String>> wegSegmentenListText)
        {
            List<Segment> listMetWegsegmenten = new List<Segment>();
            for (int i = 0; i < wegSegmentenListText.Count; i++)
            {
                List<Double> doubleListVanPunten = new List<Double>(); //voor knoop
                List<Punt> listVanPuntenMetDoubleValue = new List<Punt>(); //voor knoop
                String puntenPlainText = wegSegmentenListText[i][1]; //v voor geopunten
                puntenPlainText = puntenPlainText.Remove(0, 12);
                puntenPlainText = puntenPlainText.Trim('(',')'); 

                String[] puntenArrayStrings = puntenPlainText.Split(" ");//^
                for (int k = 0; k < puntenArrayStrings.Length; k++)
                {
                  puntenArrayStrings[k] = puntenArrayStrings[k].TrimEnd(','); //list van punten adden
                    doubleListVanPunten.Add(Convert.ToDouble(puntenArrayStrings[k], CultureInfo.InvariantCulture));
                    if (!(k % 2 == 0))
                    {
                        listVanPuntenMetDoubleValue.Add(new Punt(doubleListVanPunten[k - 1], doubleListVanPunten[k])); //punten aanmaken om toe te voegen in geo
                        
                    }
                }

                int wegsegmentID = int.Parse(wegSegmentenListText[i][0]);
                Knoop beginKnoop = new Knoop(int.Parse(wegSegmentenListText[i][4]), listVanPuntenMetDoubleValue[0]);
                Knoop eindKnoop = new Knoop(int.Parse(wegSegmentenListText[i][5]), listVanPuntenMetDoubleValue[listVanPuntenMetDoubleValue.Count - 1]);
                int linksStraatnaamID = int.Parse(wegSegmentenListText[i][6]);
                int rechtsStraatnaamID = int.Parse(wegSegmentenListText[i][7]);

                listMetWegsegmenten.Add(new Segment(wegsegmentID, beginKnoop, eindKnoop, listVanPuntenMetDoubleValue, linksStraatnaamID, rechtsStraatnaamID));
            }
            return listMetWegsegmenten;
            /*wegsegmentID [0];
  geo [1];
  morfologie [2];
  status [3];
  beginWegknoopID [4];
  eindWegknoopID [5];
  linksStraatnaamID [6];
  rechtsStraatnaamID [7]*/
        }


        //leest alle straaten en steekt ze in een list list
        public List<List<String>> straatNamenData()
   
        {
            List<List<String>> ListGesorteerdStraten = new List<List<string>>();
            using (StreamReader sr = new StreamReader("C:/Users/lieke/OneDrive/scool/prog 3/Labo/1/repository/WRstraatnamen.csv"))
            {

                string[] currentLineChopped;
                int LineTeller = 0;
                string currentLine;
                sr.ReadLine();
                // currentLine moet null zijn als het einde bereikt
                while ((currentLine = sr.ReadLine()) != null)
                {
                    if (!currentLine.Contains("-9"))
                    {
                        ListGesorteerdStraten.Add(new List<String>());
                        currentLineChopped = currentLine.Split(';');
                        for (int i = 0; i < currentLineChopped.Length; i++)
                        {

                            ListGesorteerdStraten[LineTeller].Add(currentLineChopped[i]);

                        }
                        LineTeller++;
                    }
                }
            }
            return ListGesorteerdStraten;
            //[0] ID
            //[1] Naam
        }

        //vraagt de lijst van alle straten en steekt ze in een lijst van Straten
        public List<Straat> maakListVanStraten(List<List<String>> wegStratenListText)
        {
            List<Straat> listMetStraten = new List<Straat>();
            for (int i = 0; i < wegStratenListText.Count; i++)
            {

                int straatId = int.Parse(wegStratenListText[i][0]);
                string naamStraat = wegStratenListText[i][1];

                listMetStraten.Add(new Straat(straatId, naamStraat));
            }
            return listMetStraten;

            //[0] ID
            //[1] Naam
        }

        //leest alle gemeentes en steekt ze in een list list
        public List<List<String>> GemeentenaamData()
        {
            List<List<String>> ListGesorteerdGemeenteNamen = new List<List<string>>();
            using (StreamReader sr = new StreamReader("C:/Users/lieke/OneDrive/scool/prog 3/Labo/1/repository/WRGemeentenaam.csv"))
            {

                string[] currentLineChopped;
                int LineTeller = 0;
                string currentLine;
                sr.ReadLine();
                // currentLine moet null zijn als het einde bereikt
                while ((currentLine = sr.ReadLine()) != null)
                {
                    if (currentLine.Contains(";nl;"))
                    {
                        ListGesorteerdGemeenteNamen.Add(new List<String>());
                        currentLineChopped = currentLine.Split(';');
                        for (int i = 0; i < currentLineChopped.Length; i++)
                        {

                            ListGesorteerdGemeenteNamen[LineTeller].Add(currentLineChopped[i]);

                        }
                        LineTeller++;
                    }
                }
            }
            return ListGesorteerdGemeenteNamen;
        }

        //vraagt de lijst van alle gemeentes en steekt ze in een lijst van gemeentes
        public List<Gemeente> maakListVanGemeentes(List<List<String>> gemeentesListText)
        {
            List<Gemeente> listMetGemeentes = new List<Gemeente>();
            for (int i = 0; i < gemeentesListText.Count; i++)
            {

                int gemeenteid = int.Parse(gemeentesListText[i][1]);
                string taalCode = gemeentesListText[i][2];
                string GemeenteNaam = gemeentesListText[i][3];

                listMetGemeentes.Add(new Gemeente(gemeenteid, taalCode, GemeenteNaam));
            }
            return listMetGemeentes;
            /*
 [0] gemeentenaamID
 [1] gemeenteID
 [2] taalCodeGemeenteNaam
 [3] gemeenteNaam
*/
        }

        //leest gemeenteIddata in en steekt ze in een list list
        public List<List<int>> GemeenteIdData()
        {
            List<List<int>> ListGesorteerdGemeenteId = new List<List<int>>();
            using (StreamReader sr = new StreamReader("C:/Users/lieke/OneDrive/scool/prog 3/Labo/1/repository/WRGemeenteID.csv"))
            {

                String[] currentLineChopped;
                int LineTeller = 0;
                String currentLine;
                sr.ReadLine();
                // currentLine moet null zijn als het einde bereikt
                while ((currentLine = sr.ReadLine()) != null)
                {

                    ListGesorteerdGemeenteId.Add(new List<int>());
                    currentLineChopped = currentLine.Split(';');
                    for (int i = 0; i < currentLineChopped.Length; i++)
                    {

                        ListGesorteerdGemeenteId[LineTeller].Add(int.Parse(currentLineChopped[i]));

                    }
                    LineTeller++;

                }
            }
            return ListGesorteerdGemeenteId;
            // [0] straatNaamId
            // [1] gemeenteID
        }

        //leest provincie data in en steekt ze in een list list
        public List<List<String>> ProvincieInfoData()
        {
            List<List<String>> ListGesorteerdProvincieInfo = new List<List<string>>();
           

            using (StreamReader sr = new StreamReader("C:/Users/lieke/OneDrive/scool/prog 3/Labo/1/repository/ProvincieInfo.csv"))
            {
                List<int> gebruikteProvincie = listVanGebruikteProvincieIds();
                List<String> woordenOmNietTeGebruiken = new List<String>();
                String[] currentLineChopped;
                int LineTeller = 0;
                String currentLine;
                sr.ReadLine();

                // currentLine moet null zijn als het einde bereikt
                while ((currentLine = sr.ReadLine()) != null)
                {
                    for (int f = 0; f < gebruikteProvincie.Count; f++) {
                        if (currentLine.Contains(";" + gebruikteProvincie[f] + ";") && currentLine.Contains(";nl;"))
                        {
                            ListGesorteerdProvincieInfo.Add(new List<String>());
                            currentLineChopped = currentLine.Split(';');

                            for (int i = 0; i < currentLineChopped.Length; i++)
                            {

                                ListGesorteerdProvincieInfo[LineTeller].Add(currentLineChopped[i]);

                            }
                            LineTeller++;


                        }
                    }
                }
            }
            return ListGesorteerdProvincieInfo;
            /*
[0] gemeenteId
[1] ProvincieID
[2] taalCodeProcincieNaam
[3] ProvincieNaam
*/
        }

        //leest listvangebruikte ids in en steekt ze in een list
        public List<int> listVanGebruikteProvincieIds(){
            List<int> returnInts = new List<int>();
            StreamReader provincieIdLeesCheck = new StreamReader("C:/Users/lieke/OneDrive/scool/prog 3/Labo/1/repository/ProvincieIDsVlaanderen.csv");
            String provincieIdCheckMetComma = provincieIdLeesCheck.ReadLine();
            String[] provincieIdCheck = provincieIdCheckMetComma.Split(',');
            for (int i = 0; i < provincieIdCheck.Length; i++)
            {
                returnInts.Add(int.Parse(provincieIdCheck[i]));

            }
            return returnInts;

        }

        //vraagt de list van gebruikteids en list van alle provincie en bewerkt ze naar ee list van alle GEBRUIKTE Provincies
        public List<Provincie> maakListVanProvincies(List<List<String>> provincieListText, List<int> listVanGebruikteProvincieIds)
        {
            List<Provincie> listMetProvincies = new List<Provincie>();
           ;
            String[][] provincieArrayTextGebruikte =new String[listVanGebruikteProvincieIds.Count][]; //gebruikte provincies

            for (int i = 0; i < provincieArrayTextGebruikte.Length; i++)
            {
                provincieArrayTextGebruikte[i] =  new String[provincieListText[0].Count];
                provincieArrayTextGebruikte[i][1] = listVanGebruikteProvincieIds[i].ToString();
            }
            //gebruikte provincies provincie ID vullen

            for (int a = 0; a< provincieListText.Count; a++){
                for (int b = 0; b < provincieArrayTextGebruikte.Length; b++)
                {
                    if(provincieArrayTextGebruikte[b][1] == provincieListText[a][1])
                    {
                        if ((provincieArrayTextGebruikte[b][0]) ==null)
                        {
                            provincieArrayTextGebruikte[b][0] += provincieListText[a][0] + ",";
                                provincieArrayTextGebruikte[b][2] = provincieListText[a][2];
                            provincieArrayTextGebruikte[b][3] = provincieListText[a][3];
                        }
                        //de arrays(is nog steeds een string) lijst van gemeente IDs opvullen 
                        else if (!(provincieArrayTextGebruikte[b][0].Contains(provincieListText[a][0])))
                        {
                            provincieArrayTextGebruikte[b][0] += provincieListText[a][0] + ",";
                        }
                        //opvullen voor eerste keer
                        
                    }
                }
               

            }
            for (int i = 0; i < provincieArrayTextGebruikte.Length; i++)
            {
                String[] stringsVoorGemeenteID = provincieArrayTextGebruikte[i][0].Split(','); //de gemeenteid array splitsen
                
                List<int> gemeenteids = new List<int>(); //een nieuwe list op het te vullen met^


                for (int b = 0; b < stringsVoorGemeenteID.Length; b++)
                {
                    if (stringsVoorGemeenteID[b] != "")
                    {
                        gemeenteids.Add(int.Parse(stringsVoorGemeenteID[b]));
                    }
                }
                // de int list van gemeenteids opvullen 
                int provincieId = int.Parse(provincieArrayTextGebruikte[i][1]);
                String taalCode = provincieArrayTextGebruikte[i][2];
                String provincieNaam = provincieArrayTextGebruikte[i][3];

                listMetProvincies.Add(new Provincie(gemeenteids, provincieId, taalCode, provincieNaam));
            }


            return listMetProvincies;
            /*
[0] gemeenteId
[1] ProvincieID
[2] taalCodeProcincieNaam
[3] ProvincieNaam
*/
        }


    }

}
