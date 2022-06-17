using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiKosten
{
    internal class TaxiBedrijf
    {
        //fields
        public List<Taxi> taxis;
        public String naam;
        public int bedrijfId;

        //constructor
        public TaxiBedrijf(String naam, int bedrijfId)
        {
            this.naam = naam;
            this.bedrijfId = bedrijfId;
            this.taxis = new List<Taxi>();
        }

        //getters en setters
        public List<Taxi> getTaxis()
        {
            return this.taxis;
        }

        public void setTaxis(List<Taxi> taxis)
        {
            this.taxis = taxis;
        }

        public void voegTaxiToe(Taxi taxi)
        {
            this.taxis.Add(taxi);
        }

        public String getNaam()
        {
            return this.naam;
        }

        public void setNaam(String naam)
        {
            this.naam = naam;
        }

        public int getBedrijfId()
        {
            return this.bedrijfId;
        }

        public void setBedrijfId(int bedrijfId)
        {
            this.bedrijfId = bedrijfId;
        }

        //methodes
        /// <summary>
        /// Krijg het totale inkomen van het taxibedrijf.
        /// </summary>
        /// <returns>float aan euro's.</returns>
        public float totaleInkomen()
        {
            if (this.taxis.Count == 0) { return 0; }
            float totaleInkomen = 0;

            foreach(Taxi taxi in this.taxis)
            {
                totaleInkomen = taxi.krijgInkomstenTaxi();
            }
            return totaleInkomen;
        }

        /// <summary>
        /// Krijg de gemiddelde afstand van alle ritten van het taxibedrijf in kilometers.
        /// </summary>
        /// <returns>float aan kilometers.</returns>
        public float gemiddeldeAfstand()
        {
            float gemiddeldeAfstand = 0;
            float totaleAfstand = 0;
            int aantalRitten = 0;

            if(this.taxis.Count == 0) { return 0; } 

            foreach(Taxi taxi in this.taxis)
            {
                aantalRitten = taxi.krijgAantalRitten();
                totaleAfstand = taxi.krijgAfstandTaxi();
            }

            gemiddeldeAfstand = totaleAfstand / aantalRitten;
            return gemiddeldeAfstand;
        }

        /// <summary>
        /// Krijg de langste rit van het taxibedrijf in minuten.
        /// </summary>
        /// <returns>double aan minuten.</returns>
        public double langsteRit()
        {
            if(this.taxis.Count == 0) { return 0; }
            Taxi eersteTaxi = taxis.First<Taxi>();
            double aantalMinuten = eersteTaxi.krijgLangsteRit();

            foreach(Taxi taxi in this.taxis)
            {
                if(taxi.krijgLangsteRit() >= eersteTaxi.krijgLangsteRit())
                {
                    aantalMinuten = taxi.krijgLangsteRit();
                    eersteTaxi = taxi;
                    Console.WriteLine(aantalMinuten);
                }
            }
            return aantalMinuten;
        }
    }
}
