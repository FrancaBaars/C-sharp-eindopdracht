using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TaxiKosten
{
    public partial class Form2 : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
        }

        //vult de comboboxen met informatie van de taxi's wanneer de form word geladen.
        private void Form2_Load(object sender, EventArgs e)
        {
            krijgTaxiComboBoxData();
        }


        //taxibedrijf functies

        //krijg de informatie van taxibedrijf Bosman als er op de knop krijg informatie wordt gedrukt.
        private void krijgInformatieBedrijf_Click(object sender, EventArgs e)
        {
            //vult nieuw taxibedrijf met de gegevens uit de database
            TaxiBedrijf taxiBedrijf = maakTaxiBedrijf();

            //vult de labels met gegevens uit de klasse taxibedrijf.
            langsteRitBedrijf.Text = taxiBedrijf.langsteRit().ToString() + " minuten.";
            gemiddeldeAfstandBedrijf.Text = taxiBedrijf.gemiddeldeAfstand().ToString() + " km.";
            totaleInkomenBedrijf.Text = "€" + taxiBedrijf.totaleInkomen().ToString();

        }

        /// <summary>
        /// functie om een Taxibedrijf te vullen met gegevens uit de database en ook meteen Taxi's aanmaakt en ritten.
        /// </summary>
        /// <returns>Taxibedrijf met gegevens.</returns>
        private TaxiBedrijf maakTaxiBedrijf()
        {          
            //maak een dataset voor taxibedrijf en vul deze met gegevens uit de database.
            DataSet dsBedrijf = Database.krijgDataVanDatabase("SELECT bedrijf_id, naam FROM taxiBedrijf WHERE bedrijf_id = 1004");

            //maakt een nieuw taxibedrijf aan met gegevens uit de database.
            TaxiBedrijf taxiBedrijf = new TaxiBedrijf(dsBedrijf.Tables[0].Rows[0]["naam"].ToString(), (int)dsBedrijf.Tables[0].Rows[0]["bedrijf_id"]);

            //maak een Dataset voor taxis en vul deze met informatie. en maak een nieuwe dataset aan voor ritten
            DataSet dsTaxi = Database.krijgDataVanDatabase("SELECT taxiNummer, bedrijf_id FROM taxi WHERE bedrijf_id = 1004");
            DataSet dsRit = new DataSet();


            //loop door de taxi's heen.
            foreach (DataRow taxi in dsTaxi.Tables[0].Rows)
            {
                //maak een taxi met gegevens uit de database en zet deze in de list van taxi's en krijg het taxiNummer van de huidige taxi.
                Taxi huidigeTaxi = new Taxi((int)taxi[0], (int)taxi[1]);
                taxiBedrijf.voegTaxiToe(huidigeTaxi);
                int huidigTaxiNummer = huidigeTaxi.getTaxiNummer();

                //de query om rit gegevens te krijgen uit de database.
                string query = @"SELECT rit_id, beginTijd, eindTijd, weekDag, afstand, taxiNummer FROM rit WHERE taxiNummer = @huidigTaxiNummer";
                
                //maak een adapter aan en maak verbinding met de database, verklaar de parameters en full de rit Dataset.
                SqlDataAdapter adapter = new SqlDataAdapter(query, Database.OpenSqlConnection());
                adapter.SelectCommand.Parameters.AddWithValue("@huidigTaxiNummer", huidigTaxiNummer);
                adapter.Fill(dsRit);

                //loop door de ritten heen.
                foreach (DataRow rit in dsRit.Tables[0].Rows)
                {
                    //verklaar de variable voordat ze in een Rit gaan zodat ze goede datatype hebben.
                    int rit_id = Convert.ToInt32(rit[0]);
                    DateTime beginTijd = Convert.ToDateTime(rit[1]);
                    DateTime eindTijd = Convert.ToDateTime(rit[2]);
                    String weekDag = rit[3].ToString();
                    float afstand = float.Parse(rit[4].ToString());
                    int taxiNummer = (int)rit[5];

                    //maak een nieuwe rit aan en vul deze met gegevens en voeg hem aan de taxi toe.
                    Rit huidigeRit = new Rit(rit_id, beginTijd, eindTijd, weekDag, afstand, taxiNummer);
                    huidigeTaxi.voegRitToe(huidigeRit);
                }
            }
            dataGridView1.DataSource = dsRit.Tables[0].DefaultView;
            return taxiBedrijf;
        }




        //taxi functies


        //voeg een taxi toe aan een bedrijf
        private void butTaxiNummer_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO taxi(bedrijf_id) VALUES(@bedrijfid) ";
            SqlCommand cmd = new SqlCommand(query, Database.OpenSqlConnection());
            int bedrijfId = 1004;
            if (!bedrijfId.Equals(string.Empty))
            {
                cmd.Parameters.AddWithValue("@bedrijfId", bedrijfId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Taxi succesvol toegevoegd.");
            }
            else
            {
                MessageBox.Show("Er is iets missgegaan.");
            }
            krijgTaxiComboBoxData();
        }





        //rit functies
        //een functie om een rit toe te voegen aan de database.
        private void submitRit_Click(object sender, EventArgs e)
        {
            //maak de query om gegevens in de database te inserten.
            string query = @"INSERT INTO rit(taxiNummer, beginTijd, eindTijd, weekDag, afstand) VALUES(@taxiNummer, @beginTijd, @eindTijd, @weekDag, @afstand)";
            SqlCommand cmd = new SqlCommand(query, Database.OpenSqlConnection());

            //check of de velden ingevuld zijn.
            if (!taxiNummerCombo.Text.Equals(string.Empty) && !weekDagInput.Text.Equals(string.Empty) && afstandInput.Value != 0)
            {
                //verklaar de parameters.
                int taxiNummer = int.Parse(taxiNummerCombo.SelectedItem.ToString());
                DateTime beginTijd = Convert.ToDateTime(beginTijdInput.Value);
                DateTime eindTijd = Convert.ToDateTime(eindTijdInput.Value);
                string weekDag = weekDagInput.Text;
                float afstand = (float)afstandInput.Value;

                //als de velden niet leeg zijn dan mogen ze toegevoegd worden aan de database.
                if (!taxiNummer.Equals(string.Empty))
                {
                    //bind de gegevens aan de parameters in de query.
                    cmd.Parameters.AddWithValue("@taxiNummer", taxiNummer);
                    cmd.Parameters.AddWithValue("@beginTijd", beginTijd);
                    cmd.Parameters.AddWithValue("@eindTijd", eindTijd);
                    cmd.Parameters.AddWithValue("@weekDag", weekDag);
                    cmd.Parameters.AddWithValue("@afstand", afstand);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("De rit is succesvolg toegevoegd.");
                }
                else
                {
                    MessageBox.Show("Alles moet ingevuld zijn.");
                }
                //om de combobox te updaten.
                krijgTaxiComboBoxData();
                taxiNummerCombo.SelectedText = "";
            }
            else
            {
                MessageBox.Show("Vul alle velden in!");
            }

        }

        //algmene functies
        //krijg gegevens van taxi om in de combobox met taxinummers te zetten.
        public void krijgTaxiComboBoxData()
        {
            taxiNummerCombo.Items.Clear();
            cmd = new SqlCommand("SELECT taxiNummer FROM taxi", Database.OpenSqlConnection());
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                taxiNummerCombo.Items.Add(dr[0].ToString());
            }
        }

        //maak de app zichtbaar.
        private void showApp()
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        //als er op close wordt gedrukt sluit de app.
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //als er op taxiBedrijf wordt gedrukt dan opent het tablad taxibedrijf
        private void taxiBedrijfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showApp();
            tabControl1.SelectedTab = tabControl1.TabPages["Taxibedrijf"];
        }

        //als er op taxi wordt gedrukt dat opent het tablad taxi.
        private void taxiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showApp();
            tabControl1.SelectedTab = tabControl1.TabPages["Taxi"];
        }

        //als er op rit wordt gedrukt dan opent het tablad rit.
        private void ritToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showApp();
            tabControl1.SelectedTab = tabControl1.TabPages["Rit"];
        }

        //als er op about wordt gedrukt dan open het aboutscherm.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }

        //als er op open wordt gedrukt dan opent de app.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showApp();
        }

        //als er 1x op het icoon wordt geklikt dan opent de app.
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            showApp();
        }
    }
}
