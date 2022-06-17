using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TaxiKosten
{
    internal class Taxi
    {
        //fields
        public int taxiNummer;
        public int bedrijfId;
        List<Rit> ritten;

        //constuctor
        public Taxi(int taxiNummer, int bedrijfId)
        {
            this.taxiNummer = taxiNummer;
            this.bedrijfId = bedrijfId;
            this.ritten = new List<Rit>();
        }

        //getters en setter
        public int getTaxiNummer()
        {
            return this.taxiNummer;
        }

        public void setTaxiNummer(int taxiNummer)
        {
            this.taxiNummer = taxiNummer;
        }

        public List<Rit> getRitten()
        {
            return this.ritten;
        }

        public void setRitten(List<Rit> ritten)
        {
            this.ritten = ritten;
        }

        //methodes

        //voeg een rit toe aan ritten.
        public void voegRitToe(Rit rit)
        {
            this.ritten.Add(rit);
        }

        /// <summary>
        /// Een functie om de totale inkomsten van de taxi te krijgen.
        /// </summary>
        /// <returns>float aan euro's.</returns>
        public float krijgInkomstenTaxi()
        {
            if (this.ritten.Count == 0) { return 0; }
            float inkomsten = 0;

            foreach(Rit rit in this.ritten)
            {
                inkomsten += rit.verschuldigdeBedrag();
            }
            return inkomsten;
        }

        /// <summary>
        /// een functie om de langste rit in minuten van deze taxi te krijgen.
        /// </summary>
        /// <returns>double aan minuten.</returns>
        public double krijgLangsteRit()
        {
            //if (this.ritten.Count == 0) { return 0; }
            Rit eersteRit = ritten.First<Rit>();
            double aantalMinuten = eersteRit.krijgMinuten();

            foreach(Rit rit in this.ritten)
            {
                if (rit.krijgMinuten() > eersteRit.krijgMinuten())
                {
                    aantalMinuten = rit.krijgMinuten();
                    eersteRit = rit;
                    Console.WriteLine(aantalMinuten);
                }
            }
            return aantalMinuten;
        }

        /// <summary>
        /// Een functie om de totale afstand van deze taxi te krijgen.
        /// </summary>
        /// <returns>float aan kilometers.</returns>
        public float krijgAfstandTaxi()
        {
            float totaleAfstand = 0;
            if (this.ritten.Count == 0) { return 0; }

            foreach(Rit rit in this.ritten)
            {
                totaleAfstand += rit.getAfstand();
            }
            return totaleAfstand;
        }

        /// <summary>
        /// Een functie om het totaal aantal ritten van deze taxi te krijgen.
        /// </summary>
        /// <returns></returns>
        public int krijgAantalRitten()
        {
            int aantalRitten = this.ritten.Count;
            return aantalRitten;
        }
    }
}
