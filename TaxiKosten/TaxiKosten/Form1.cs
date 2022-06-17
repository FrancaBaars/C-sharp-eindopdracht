using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiKosten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //een functie die een timer start voor de progressiebalk in het laadscherm.
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if (panel2.Width >= 400)
            {
                timer1.Stop();
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }
    }
}
