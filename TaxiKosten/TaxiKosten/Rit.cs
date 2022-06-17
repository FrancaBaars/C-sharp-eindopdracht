using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace TaxiKosten
{
    internal class Rit
    {
        //fields
        public int id;
        public DateTime beginTijd;
        public DateTime eindTijd;
        public String weekDag;
        public float afstand;
        public int taxiNummer;

        //constructor
        public Rit(int id, DateTime beginTijd, DateTime eindTijd, String weekDag, float afstand, int taxiNummer)
        {
            this.id = id;
            this.beginTijd = beginTijd;
            this.eindTijd = eindTijd;
            this.weekDag = weekDag;
            this.afstand = afstand;
            this.taxiNummer = taxiNummer;
        }
        //getters en setters
        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public DateTime getBegintijd()
        {
            return this.beginTijd;
        }

        public void setBeginTijd(DateTime beginTijd)
        {
            this.beginTijd = beginTijd;
        }

        public DateTime getEindTijd()
        {
            return this.eindTijd;
        }

        public void setEindTijd(DateTime eindTijd)
        {
            this.eindTijd = eindTijd;
        }

        public String getNaam()
        {
            return this.getNaam();
        }

        public void setNaam(String weekDag)
        {
            this.weekDag = weekDag;
        }

        public float getAfstand()
        {
            return this.afstand;
        }

        public void setAfstand(float afstand)
        {
            this.afstand = afstand;
        }

        public int getTaxiNummer()
        {
            return this.taxiNummer;
        }

        public void setTaxiNummer(int taxiNummer)
        {
            this.taxiNummer = taxiNummer;
        }

        //methodes

        /// <summary>
        /// Een functie om het aantal minuten te krijgen hoe lang de rit duurde.
        /// </summary>
        /// <returns>double aan minuten</returns>
        public double krijgMinuten()
        {
            TimeSpan span = this.eindTijd - this.beginTijd;
            double minuten = span.TotalMinutes;
            return minuten;
        }
 
        /// <summary>
        /// Een functie om terug te krijgen wat de rit kostte in euro's.
        /// </summary>
        /// <returns>float aan euro's</returns>
        public float verschuldigdeBedrag()
        {
            DateTime startWeekend = new DateTime(2000, 01, 01, 22, 00, 00);
            DateTime eindWeekend = new DateTime(2000, 01, 01, 07, 00, 00);
            startWeekend.ToString("hh:mm");
            eindWeekend.ToString("hh:mm");
            double minuten = krijgMinuten();
            float verschuldigdeBedrag = 0;
            switch(this.weekDag)
            {
                case "maandag":
                    //als het op maandag eerder is dan 07:00 uur dan betaal je meer
                    if (this.beginTijd < eindWeekend)
                    {
                        verschuldigdeBedrag = this.afstand * 0.575f;
                        verschuldigdeBedrag += (float)minuten * 0.1955f;
                    }
                    //anders normaal tarief
                    else
                    {
                        verschuldigdeBedrag = this.afstand * 0.5f;
                        verschuldigdeBedrag += (float)minuten * 0.17f;
                    }
                    break;
                case "vrijdag":
                    //als het op vrijdag later is dan 22:00 uur dan betaal je 15% meer.
                    if (this.beginTijd >= startWeekend)
                    {
                        verschuldigdeBedrag = this.afstand * 0.575f;
                        verschuldigdeBedrag += (float)minuten * 0.1955f;
                    }
                    //anders normaal tarief
                    else
                    {
                        verschuldigdeBedrag = this.afstand * 0.5f;
                        verschuldigdeBedrag += (float)minuten * 0.17f;
                    }
                    break;
                case "zaterdag":
                    //in het weekend betaal je 15% meer.
                    verschuldigdeBedrag = this.afstand * 0.575f;
                    verschuldigdeBedrag += (float)minuten * 0.1955f;
                    break;
                case "zondag":
                    //in het weekend betaal je 15% meer.
                    verschuldigdeBedrag = this.afstand * 0.575f;
                    verschuldigdeBedrag += (float)minuten * 0.1955f;
                    break;
                default:
                    //anders betaal je normaal tarief.
                    verschuldigdeBedrag = this.afstand * 0.5f;
                    verschuldigdeBedrag += (float)minuten * 0.17f;
                    break;
            }
            return verschuldigdeBedrag;
        }



    }
}
