namespace TaxiKosten
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Taxibedrijf = new System.Windows.Forms.TabPage();
            this.Taxi = new System.Windows.Forms.TabPage();
            this.Rit = new System.Windows.Forms.TabPage();
            this.totaleInkomen = new System.Windows.Forms.Label();
            this.gemAfstand = new System.Windows.Forms.Label();
            this.langsteRit = new System.Windows.Forms.Label();
            this.butLangsteRit = new System.Windows.Forms.Button();
            this.butGemAfstand = new System.Windows.Forms.Button();
            this.butTotaleInkomen = new System.Windows.Forms.Button();
            this.naamBedrijf = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.butNaamBedrijf = new System.Windows.Forms.Button();
            this.inputNaamBedrijf = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Taxibedrijf.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Taxibedrijf);
            this.tabControl1.Controls.Add(this.Taxi);
            this.tabControl1.Controls.Add(this.Rit);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // Taxibedrijf
            // 
            this.Taxibedrijf.Controls.Add(this.totaleInkomen);
            this.Taxibedrijf.Controls.Add(this.gemAfstand);
            this.Taxibedrijf.Controls.Add(this.langsteRit);
            this.Taxibedrijf.Controls.Add(this.butLangsteRit);
            this.Taxibedrijf.Controls.Add(this.butGemAfstand);
            this.Taxibedrijf.Controls.Add(this.butTotaleInkomen);
            this.Taxibedrijf.Controls.Add(this.naamBedrijf);
            this.Taxibedrijf.Controls.Add(this.label5);
            this.Taxibedrijf.Controls.Add(this.label4);
            this.Taxibedrijf.Controls.Add(this.label3);
            this.Taxibedrijf.Controls.Add(this.label2);
            this.Taxibedrijf.Controls.Add(this.label7);
            this.Taxibedrijf.Controls.Add(this.butNaamBedrijf);
            this.Taxibedrijf.Controls.Add(this.inputNaamBedrijf);
            this.Taxibedrijf.Location = new System.Drawing.Point(4, 22);
            this.Taxibedrijf.Name = "Taxibedrijf";
            this.Taxibedrijf.Padding = new System.Windows.Forms.Padding(3);
            this.Taxibedrijf.Size = new System.Drawing.Size(934, 536);
            this.Taxibedrijf.TabIndex = 0;
            this.Taxibedrijf.Text = "Taxibedrijf";
            this.Taxibedrijf.UseVisualStyleBackColor = true;
            // 
            // Taxi
            // 
            this.Taxi.Location = new System.Drawing.Point(4, 22);
            this.Taxi.Name = "Taxi";
            this.Taxi.Padding = new System.Windows.Forms.Padding(3);
            this.Taxi.Size = new System.Drawing.Size(934, 536);
            this.Taxi.TabIndex = 1;
            this.Taxi.Text = "Taxi";
            this.Taxi.UseVisualStyleBackColor = true;
            // 
            // Rit
            // 
            this.Rit.Location = new System.Drawing.Point(4, 22);
            this.Rit.Name = "Rit";
            this.Rit.Size = new System.Drawing.Size(934, 536);
            this.Rit.TabIndex = 2;
            this.Rit.Text = "Rit";
            this.Rit.UseVisualStyleBackColor = true;
            // 
            // totaleInkomen
            // 
            this.totaleInkomen.AutoSize = true;
            this.totaleInkomen.Location = new System.Drawing.Point(210, 155);
            this.totaleInkomen.Name = "totaleInkomen";
            this.totaleInkomen.Size = new System.Drawing.Size(0, 13);
            this.totaleInkomen.TabIndex = 27;
            // 
            // gemAfstand
            // 
            this.gemAfstand.AutoSize = true;
            this.gemAfstand.Location = new System.Drawing.Point(210, 188);
            this.gemAfstand.Name = "gemAfstand";
            this.gemAfstand.Size = new System.Drawing.Size(0, 13);
            this.gemAfstand.TabIndex = 26;
            // 
            // langsteRit
            // 
            this.langsteRit.AutoSize = true;
            this.langsteRit.Location = new System.Drawing.Point(210, 219);
            this.langsteRit.Name = "langsteRit";
            this.langsteRit.Size = new System.Drawing.Size(0, 13);
            this.langsteRit.TabIndex = 25;
            // 
            // butLangsteRit
            // 
            this.butLangsteRit.Location = new System.Drawing.Point(324, 329);
            this.butLangsteRit.Name = "butLangsteRit";
            this.butLangsteRit.Size = new System.Drawing.Size(81, 23);
            this.butLangsteRit.TabIndex = 24;
            this.butLangsteRit.Text = "De langste rit";
            this.butLangsteRit.UseVisualStyleBackColor = true;
            // 
            // butGemAfstand
            // 
            this.butGemAfstand.Location = new System.Drawing.Point(190, 329);
            this.butGemAfstand.Name = "butGemAfstand";
            this.butGemAfstand.Size = new System.Drawing.Size(128, 23);
            this.butGemAfstand.TabIndex = 23;
            this.butGemAfstand.Text = "De gemiddelde afstand";
            this.butGemAfstand.UseVisualStyleBackColor = true;
            // 
            // butTotaleInkomen
            // 
            this.butTotaleInkomen.Location = new System.Drawing.Point(84, 329);
            this.butTotaleInkomen.Name = "butTotaleInkomen";
            this.butTotaleInkomen.Size = new System.Drawing.Size(100, 23);
            this.butTotaleInkomen.TabIndex = 22;
            this.butTotaleInkomen.Text = "Totale inkomen";
            this.butTotaleInkomen.UseVisualStyleBackColor = true;
            // 
            // naamBedrijf
            // 
            this.naamBedrijf.AutoSize = true;
            this.naamBedrijf.Location = new System.Drawing.Point(382, 148);
            this.naamBedrijf.Name = "naamBedrijf";
            this.naamBedrijf.Size = new System.Drawing.Size(0, 13);
            this.naamBedrijf.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "De naam is:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "De langste rit is:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "De gemiddelde afstand is:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Het totale inkomen is:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Naam Taxibedrijf";
            // 
            // butNaamBedrijf
            // 
            this.butNaamBedrijf.Location = new System.Drawing.Point(308, 51);
            this.butNaamBedrijf.Name = "butNaamBedrijf";
            this.butNaamBedrijf.Size = new System.Drawing.Size(75, 23);
            this.butNaamBedrijf.TabIndex = 15;
            this.butNaamBedrijf.Text = "Submit";
            this.butNaamBedrijf.UseVisualStyleBackColor = true;
            this.butNaamBedrijf.Click += new System.EventHandler(this.butNaamBedrijf_Click);
            // 
            // inputNaamBedrijf
            // 
            this.inputNaamBedrijf.Location = new System.Drawing.Point(162, 51);
            this.inputNaamBedrijf.Name = "inputNaamBedrijf";
            this.inputNaamBedrijf.Size = new System.Drawing.Size(100, 20);
            this.inputNaamBedrijf.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 559);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Taxibedrijf.ResumeLayout(false);
            this.Taxibedrijf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Taxibedrijf;
        private System.Windows.Forms.TabPage Taxi;
        private System.Windows.Forms.TabPage Rit;
        private System.Windows.Forms.Label totaleInkomen;
        private System.Windows.Forms.Label gemAfstand;
        private System.Windows.Forms.Label langsteRit;
        private System.Windows.Forms.Button butLangsteRit;
        private System.Windows.Forms.Button butGemAfstand;
        private System.Windows.Forms.Button butTotaleInkomen;
        private System.Windows.Forms.Label naamBedrijf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butNaamBedrijf;
        private System.Windows.Forms.TextBox inputNaamBedrijf;
    }
}

