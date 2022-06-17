namespace TaxiKosten
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Taxibedrijf = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.krijgInformatieBedrijf = new System.Windows.Forms.Button();
            this.totaleInkomenBedrijf = new System.Windows.Forms.Label();
            this.gemiddeldeAfstandBedrijf = new System.Windows.Forms.Label();
            this.langsteRitBedrijf = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Taxi = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.gemiddeldeAfstandTaxiOutput = new System.Windows.Forms.Label();
            this.langsteRitTaxiOuput = new System.Windows.Forms.Label();
            this.inkomstenTaxiOutput = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.taxiButton = new System.Windows.Forms.Button();
            this.Rit = new System.Windows.Forms.TabPage();
            this.taxiNummerCombo = new System.Windows.Forms.ComboBox();
            this.input1 = new System.Windows.Forms.Label();
            this.submitRit = new System.Windows.Forms.Button();
            this.afstandInput = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.eindTijdInput = new System.Windows.Forms.DateTimePicker();
            this.beginTijdInput = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.weekDagInput = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.taxiBedrijfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ritToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.Taxibedrijf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Taxi.SuspendLayout();
            this.Rit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afstandInput)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(387, 341);
            this.tabControl1.TabIndex = 0;
            // 
            // Taxibedrijf
            // 
            this.Taxibedrijf.Controls.Add(this.dataGridView1);
            this.Taxibedrijf.Controls.Add(this.krijgInformatieBedrijf);
            this.Taxibedrijf.Controls.Add(this.totaleInkomenBedrijf);
            this.Taxibedrijf.Controls.Add(this.gemiddeldeAfstandBedrijf);
            this.Taxibedrijf.Controls.Add(this.langsteRitBedrijf);
            this.Taxibedrijf.Controls.Add(this.label19);
            this.Taxibedrijf.Controls.Add(this.label4);
            this.Taxibedrijf.Controls.Add(this.label3);
            this.Taxibedrijf.Controls.Add(this.label2);
            this.Taxibedrijf.Location = new System.Drawing.Point(4, 22);
            this.Taxibedrijf.Name = "Taxibedrijf";
            this.Taxibedrijf.Padding = new System.Windows.Forms.Padding(3);
            this.Taxibedrijf.Size = new System.Drawing.Size(379, 315);
            this.Taxibedrijf.TabIndex = 0;
            this.Taxibedrijf.Text = "Taxibedrijf";
            this.Taxibedrijf.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(201, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(167, 102);
            this.dataGridView1.TabIndex = 33;
            // 
            // krijgInformatieBedrijf
            // 
            this.krijgInformatieBedrijf.Location = new System.Drawing.Point(20, 207);
            this.krijgInformatieBedrijf.Name = "krijgInformatieBedrijf";
            this.krijgInformatieBedrijf.Size = new System.Drawing.Size(139, 23);
            this.krijgInformatieBedrijf.TabIndex = 32;
            this.krijgInformatieBedrijf.Text = "Krijg informatie van bedrijf Bosman";
            this.krijgInformatieBedrijf.UseVisualStyleBackColor = true;
            this.krijgInformatieBedrijf.Click += new System.EventHandler(this.krijgInformatieBedrijf_Click);
            // 
            // totaleInkomenBedrijf
            // 
            this.totaleInkomenBedrijf.AutoSize = true;
            this.totaleInkomenBedrijf.Location = new System.Drawing.Point(159, 143);
            this.totaleInkomenBedrijf.Name = "totaleInkomenBedrijf";
            this.totaleInkomenBedrijf.Size = new System.Drawing.Size(0, 13);
            this.totaleInkomenBedrijf.TabIndex = 31;
            // 
            // gemiddeldeAfstandBedrijf
            // 
            this.gemiddeldeAfstandBedrijf.AutoSize = true;
            this.gemiddeldeAfstandBedrijf.Location = new System.Drawing.Point(159, 103);
            this.gemiddeldeAfstandBedrijf.Name = "gemiddeldeAfstandBedrijf";
            this.gemiddeldeAfstandBedrijf.Size = new System.Drawing.Size(0, 13);
            this.gemiddeldeAfstandBedrijf.TabIndex = 30;
            // 
            // langsteRitBedrijf
            // 
            this.langsteRitBedrijf.AutoSize = true;
            this.langsteRitBedrijf.Location = new System.Drawing.Point(118, 57);
            this.langsteRitBedrijf.Name = "langsteRitBedrijf";
            this.langsteRitBedrijf.Size = new System.Drawing.Size(0, 13);
            this.langsteRitBedrijf.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(8, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(171, 24);
            this.label19.TabIndex = 28;
            this.label19.Text = "Taxibedrijf Bosman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "De langste rit is:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "De gemiddelde afstand is:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Het totale inkomen is:";
            // 
            // Taxi
            // 
            this.Taxi.Controls.Add(this.label1);
            this.Taxi.Controls.Add(this.gemiddeldeAfstandTaxiOutput);
            this.Taxi.Controls.Add(this.langsteRitTaxiOuput);
            this.Taxi.Controls.Add(this.inkomstenTaxiOutput);
            this.Taxi.Controls.Add(this.label15);
            this.Taxi.Controls.Add(this.taxiButton);
            this.Taxi.Location = new System.Drawing.Point(4, 22);
            this.Taxi.Name = "Taxi";
            this.Taxi.Padding = new System.Windows.Forms.Padding(3);
            this.Taxi.Size = new System.Drawing.Size(379, 315);
            this.Taxi.TabIndex = 1;
            this.Taxi.Text = "Taxi";
            this.Taxi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Voeg een taxi toe";
            // 
            // gemiddeldeAfstandTaxiOutput
            // 
            this.gemiddeldeAfstandTaxiOutput.AutoSize = true;
            this.gemiddeldeAfstandTaxiOutput.Location = new System.Drawing.Point(561, 407);
            this.gemiddeldeAfstandTaxiOutput.Name = "gemiddeldeAfstandTaxiOutput";
            this.gemiddeldeAfstandTaxiOutput.Size = new System.Drawing.Size(0, 13);
            this.gemiddeldeAfstandTaxiOutput.TabIndex = 15;
            // 
            // langsteRitTaxiOuput
            // 
            this.langsteRitTaxiOuput.AutoSize = true;
            this.langsteRitTaxiOuput.Location = new System.Drawing.Point(561, 367);
            this.langsteRitTaxiOuput.Name = "langsteRitTaxiOuput";
            this.langsteRitTaxiOuput.Size = new System.Drawing.Size(0, 13);
            this.langsteRitTaxiOuput.TabIndex = 14;
            // 
            // inkomstenTaxiOutput
            // 
            this.inkomstenTaxiOutput.AutoSize = true;
            this.inkomstenTaxiOutput.Location = new System.Drawing.Point(561, 324);
            this.inkomstenTaxiOutput.Name = "inkomstenTaxiOutput";
            this.inkomstenTaxiOutput.Size = new System.Drawing.Size(0, 13);
            this.inkomstenTaxiOutput.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(28, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 24);
            this.label15.TabIndex = 6;
            this.label15.Text = "Voeg Taxi toe";
            // 
            // taxiButton
            // 
            this.taxiButton.Location = new System.Drawing.Point(144, 81);
            this.taxiButton.Name = "taxiButton";
            this.taxiButton.Size = new System.Drawing.Size(75, 23);
            this.taxiButton.TabIndex = 2;
            this.taxiButton.Text = "Voeg toe";
            this.taxiButton.UseVisualStyleBackColor = true;
            this.taxiButton.Click += new System.EventHandler(this.butTaxiNummer_Click);
            // 
            // Rit
            // 
            this.Rit.Controls.Add(this.taxiNummerCombo);
            this.Rit.Controls.Add(this.input1);
            this.Rit.Controls.Add(this.submitRit);
            this.Rit.Controls.Add(this.afstandInput);
            this.Rit.Controls.Add(this.label14);
            this.Rit.Controls.Add(this.eindTijdInput);
            this.Rit.Controls.Add(this.beginTijdInput);
            this.Rit.Controls.Add(this.label12);
            this.Rit.Controls.Add(this.label11);
            this.Rit.Controls.Add(this.label10);
            this.Rit.Controls.Add(this.label8);
            this.Rit.Controls.Add(this.weekDagInput);
            this.Rit.Location = new System.Drawing.Point(4, 22);
            this.Rit.Name = "Rit";
            this.Rit.Size = new System.Drawing.Size(379, 315);
            this.Rit.TabIndex = 2;
            this.Rit.Text = "Rit";
            this.Rit.UseVisualStyleBackColor = true;
            // 
            // taxiNummerCombo
            // 
            this.taxiNummerCombo.FormattingEnabled = true;
            this.taxiNummerCombo.Location = new System.Drawing.Point(167, 66);
            this.taxiNummerCombo.Name = "taxiNummerCombo";
            this.taxiNummerCombo.Size = new System.Drawing.Size(121, 21);
            this.taxiNummerCombo.TabIndex = 21;
            // 
            // input1
            // 
            this.input1.AutoSize = true;
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(23, 18);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(144, 24);
            this.input1.TabIndex = 19;
            this.input1.Text = "Voeg een rit toe";
            // 
            // submitRit
            // 
            this.submitRit.Location = new System.Drawing.Point(27, 237);
            this.submitRit.Name = "submitRit";
            this.submitRit.Size = new System.Drawing.Size(104, 23);
            this.submitRit.TabIndex = 18;
            this.submitRit.Text = "Voeg rit toe";
            this.submitRit.UseVisualStyleBackColor = true;
            this.submitRit.Click += new System.EventHandler(this.submitRit_Click);
            // 
            // afstandInput
            // 
            this.afstandInput.Location = new System.Drawing.Point(167, 171);
            this.afstandInput.Name = "afstandInput";
            this.afstandInput.Size = new System.Drawing.Size(120, 20);
            this.afstandInput.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Afstand";
            // 
            // eindTijdInput
            // 
            this.eindTijdInput.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.eindTijdInput.Location = new System.Drawing.Point(168, 119);
            this.eindTijdInput.Name = "eindTijdInput";
            this.eindTijdInput.Size = new System.Drawing.Size(200, 20);
            this.eindTijdInput.TabIndex = 12;
            this.eindTijdInput.Value = new System.DateTime(2022, 6, 1, 13, 0, 0, 0);
            // 
            // beginTijdInput
            // 
            this.beginTijdInput.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.beginTijdInput.Location = new System.Drawing.Point(168, 93);
            this.beginTijdInput.Name = "beginTijdInput";
            this.beginTijdInput.Size = new System.Drawing.Size(200, 20);
            this.beginTijdInput.TabIndex = 11;
            this.beginTijdInput.Value = new System.DateTime(2022, 6, 1, 12, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Dag";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Eindtijd";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Begintijd";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "TaxiNummer";
            // 
            // weekDagInput
            // 
            this.weekDagInput.Location = new System.Drawing.Point(168, 145);
            this.weekDagInput.Name = "weekDagInput";
            this.weekDagInput.Size = new System.Drawing.Size(100, 20);
            this.weekDagInput.TabIndex = 4;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TaxiBedrijf";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taxiBedrijfToolStripMenuItem,
            this.taxiToolStripMenuItem,
            this.ritToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 136);
            // 
            // taxiBedrijfToolStripMenuItem
            // 
            this.taxiBedrijfToolStripMenuItem.Name = "taxiBedrijfToolStripMenuItem";
            this.taxiBedrijfToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.taxiBedrijfToolStripMenuItem.Text = "TaxiBedrijf";
            this.taxiBedrijfToolStripMenuItem.Click += new System.EventHandler(this.taxiBedrijfToolStripMenuItem_Click);
            // 
            // taxiToolStripMenuItem
            // 
            this.taxiToolStripMenuItem.Name = "taxiToolStripMenuItem";
            this.taxiToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.taxiToolStripMenuItem.Text = "Taxi";
            this.taxiToolStripMenuItem.Click += new System.EventHandler(this.taxiToolStripMenuItem_Click);
            // 
            // ritToolStripMenuItem
            // 
            this.ritToolStripMenuItem.Name = "ritToolStripMenuItem";
            this.ritToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ritToolStripMenuItem.Text = "Rit";
            this.ritToolStripMenuItem.Click += new System.EventHandler(this.ritToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 336);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.Taxibedrijf.ResumeLayout(false);
            this.Taxibedrijf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Taxi.ResumeLayout(false);
            this.Taxi.PerformLayout();
            this.Rit.ResumeLayout(false);
            this.Rit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afstandInput)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Taxibedrijf;
        private System.Windows.Forms.TabPage Taxi;
        private System.Windows.Forms.TabPage Rit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button taxiButton;
        private System.Windows.Forms.Label input1;
        private System.Windows.Forms.Button submitRit;
        private System.Windows.Forms.NumericUpDown afstandInput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker eindTijdInput;
        private System.Windows.Forms.DateTimePicker beginTijdInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox weekDagInput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label gemiddeldeAfstandTaxiOutput;
        private System.Windows.Forms.Label langsteRitTaxiOuput;
        private System.Windows.Forms.Label inkomstenTaxiOutput;
        private System.Windows.Forms.ComboBox taxiNummerCombo;
        private System.Windows.Forms.Label totaleInkomenBedrijf;
        private System.Windows.Forms.Label gemiddeldeAfstandBedrijf;
        private System.Windows.Forms.Label langsteRitBedrijf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button krijgInformatieBedrijf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taxiBedrijfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ritToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

