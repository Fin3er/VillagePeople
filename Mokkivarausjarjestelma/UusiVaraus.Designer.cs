namespace Mokkivarausjarjestelma
{
    partial class UusiVaraus
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
            this.cmbxtoimipiste = new System.Windows.Forms.ComboBox();
            this.lbltoimipiste = new System.Windows.Forms.Label();
            this.lblmokkityyppi = new System.Windows.Forms.Label();
            this.cmbxmokkityyppi = new System.Windows.Forms.ComboBox();
            this.lblsaapumispvm = new System.Windows.Forms.Label();
            this.dtpsaapuminen = new System.Windows.Forms.DateTimePicker();
            this.dtplahtopvm = new System.Windows.Forms.DateTimePicker();
            this.lbllahtopvm = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntarkista = new System.Windows.Forms.Button();
            this.txbxalennus = new System.Windows.Forms.TextBox();
            this.lblalennus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblvalitseasiakas = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbllisatietoja = new System.Windows.Forms.Label();
            this.txbxlisatietoja = new System.Windows.Forms.TextBox();
            this.clblisapalvelut = new System.Windows.Forms.CheckedListBox();
            this.lbllisaplavelut = new System.Windows.Forms.Label();
            this.cmbxyopyjat = new System.Windows.Forms.ComboBox();
            this.lblyopyjat = new System.Windows.Forms.Label();
            this.btnuusiasiakas = new System.Windows.Forms.Button();
            this.btnetsiasiakas = new System.Windows.Forms.Button();
            this.cmbxasiakas = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnperuutavaraus = new System.Windows.Forms.Button();
            this.btnteevaraus = new System.Windows.Forms.Button();
            this.txbxhinta = new System.Windows.Forms.TextBox();
            this.lblhinta = new System.Windows.Forms.Label();
            this.cmbxlaskutus = new System.Windows.Forms.ComboBox();
            this.lbllaskutus = new System.Windows.Forms.Label();
            this.llblkuvat = new System.Windows.Forms.LinkLabel();
            this.llblkartta = new System.Windows.Forms.LinkLabel();
            this.lblyhteenveto = new System.Windows.Forms.Label();
            this.txbxyhteenveto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbxtoimipiste
            // 
            this.cmbxtoimipiste.FormattingEnabled = true;
            this.cmbxtoimipiste.Location = new System.Drawing.Point(22, 58);
            this.cmbxtoimipiste.Name = "cmbxtoimipiste";
            this.cmbxtoimipiste.Size = new System.Drawing.Size(121, 21);
            this.cmbxtoimipiste.TabIndex = 0;
            this.cmbxtoimipiste.SelectedIndexChanged += new System.EventHandler(this.cmbxtoimipiste_SelectedIndexChanged);
            // 
            // lbltoimipiste
            // 
            this.lbltoimipiste.AutoSize = true;
            this.lbltoimipiste.Location = new System.Drawing.Point(19, 31);
            this.lbltoimipiste.Name = "lbltoimipiste";
            this.lbltoimipiste.Size = new System.Drawing.Size(87, 13);
            this.lbltoimipiste.TabIndex = 1;
            this.lbltoimipiste.Text = "Valitse toimipiste:";
            // 
            // lblmokkityyppi
            // 
            this.lblmokkityyppi.AutoSize = true;
            this.lblmokkityyppi.Location = new System.Drawing.Point(19, 107);
            this.lblmokkityyppi.Name = "lblmokkityyppi";
            this.lblmokkityyppi.Size = new System.Drawing.Size(99, 13);
            this.lblmokkityyppi.TabIndex = 2;
            this.lblmokkityyppi.Text = "Valitse mökkityyppi:";
            // 
            // cmbxmokkityyppi
            // 
            this.cmbxmokkityyppi.FormattingEnabled = true;
            this.cmbxmokkityyppi.Location = new System.Drawing.Point(22, 144);
            this.cmbxmokkityyppi.Name = "cmbxmokkityyppi";
            this.cmbxmokkityyppi.Size = new System.Drawing.Size(121, 21);
            this.cmbxmokkityyppi.TabIndex = 3;
            this.cmbxmokkityyppi.SelectedIndexChanged += new System.EventHandler(this.cmbxmokkityyppi_SelectedIndexChanged);
            // 
            // lblsaapumispvm
            // 
            this.lblsaapumispvm.AutoSize = true;
            this.lblsaapumispvm.Location = new System.Drawing.Point(22, 186);
            this.lblsaapumispvm.Name = "lblsaapumispvm";
            this.lblsaapumispvm.Size = new System.Drawing.Size(114, 13);
            this.lblsaapumispvm.TabIndex = 4;
            this.lblsaapumispvm.Text = "Valitse saapumispäivä:";
            // 
            // dtpsaapuminen
            // 
            this.dtpsaapuminen.Location = new System.Drawing.Point(25, 219);
            this.dtpsaapuminen.Name = "dtpsaapuminen";
            this.dtpsaapuminen.Size = new System.Drawing.Size(200, 20);
            this.dtpsaapuminen.TabIndex = 5;
            // 
            // dtplahtopvm
            // 
            this.dtplahtopvm.Location = new System.Drawing.Point(25, 277);
            this.dtplahtopvm.Name = "dtplahtopvm";
            this.dtplahtopvm.Size = new System.Drawing.Size(200, 20);
            this.dtplahtopvm.TabIndex = 6;
            // 
            // lbllahtopvm
            // 
            this.lbllahtopvm.AutoSize = true;
            this.lbllahtopvm.Location = new System.Drawing.Point(25, 258);
            this.lbllahtopvm.Name = "lbllahtopvm";
            this.lbllahtopvm.Size = new System.Drawing.Size(93, 13);
            this.lbllahtopvm.TabIndex = 7;
            this.lbllahtopvm.Text = "Valitse lähtöpäivä:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntarkista);
            this.groupBox1.Controls.Add(this.txbxalennus);
            this.groupBox1.Controls.Add(this.lblalennus);
            this.groupBox1.Controls.Add(this.lbltoimipiste);
            this.groupBox1.Controls.Add(this.lbllahtopvm);
            this.groupBox1.Controls.Add(this.cmbxtoimipiste);
            this.groupBox1.Controls.Add(this.dtplahtopvm);
            this.groupBox1.Controls.Add(this.lblmokkityyppi);
            this.groupBox1.Controls.Add(this.dtpsaapuminen);
            this.groupBox1.Controls.Add(this.cmbxmokkityyppi);
            this.groupBox1.Controls.Add(this.lblsaapumispvm);
            this.groupBox1.Location = new System.Drawing.Point(28, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 493);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btntarkista
            // 
            this.btntarkista.Location = new System.Drawing.Point(22, 417);
            this.btntarkista.Name = "btntarkista";
            this.btntarkista.Size = new System.Drawing.Size(75, 23);
            this.btntarkista.TabIndex = 10;
            this.btntarkista.Text = "Tarkista varaus";
            this.btntarkista.UseVisualStyleBackColor = true;
            this.btntarkista.Click += new System.EventHandler(this.btntarkista_Click);
            // 
            // txbxalennus
            // 
            this.txbxalennus.Location = new System.Drawing.Point(28, 364);
            this.txbxalennus.Name = "txbxalennus";
            this.txbxalennus.Size = new System.Drawing.Size(100, 20);
            this.txbxalennus.TabIndex = 9;
            // 
            // lblalennus
            // 
            this.lblalennus.AutoSize = true;
            this.lblalennus.Location = new System.Drawing.Point(25, 333);
            this.lblalennus.Name = "lblalennus";
            this.lblalennus.Size = new System.Drawing.Size(74, 13);
            this.lblalennus.TabIndex = 8;
            this.lblalennus.Text = "Alennuskoodi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Uusi varaus";
            // 
            // lblvalitseasiakas
            // 
            this.lblvalitseasiakas.AutoSize = true;
            this.lblvalitseasiakas.Location = new System.Drawing.Point(19, 31);
            this.lblvalitseasiakas.Name = "lblvalitseasiakas";
            this.lblvalitseasiakas.Size = new System.Drawing.Size(80, 13);
            this.lblvalitseasiakas.TabIndex = 10;
            this.lblvalitseasiakas.Text = "Valitse asiakas:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbllisatietoja);
            this.groupBox2.Controls.Add(this.txbxlisatietoja);
            this.groupBox2.Controls.Add(this.clblisapalvelut);
            this.groupBox2.Controls.Add(this.lbllisaplavelut);
            this.groupBox2.Controls.Add(this.cmbxyopyjat);
            this.groupBox2.Controls.Add(this.lblyopyjat);
            this.groupBox2.Controls.Add(this.btnuusiasiakas);
            this.groupBox2.Controls.Add(this.btnetsiasiakas);
            this.groupBox2.Controls.Add(this.cmbxasiakas);
            this.groupBox2.Controls.Add(this.lblvalitseasiakas);
            this.groupBox2.Location = new System.Drawing.Point(319, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 493);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // lbllisatietoja
            // 
            this.lbllisatietoja.AutoSize = true;
            this.lbllisatietoja.Location = new System.Drawing.Point(22, 333);
            this.lbllisatietoja.Name = "lbllisatietoja";
            this.lbllisatietoja.Size = new System.Drawing.Size(57, 13);
            this.lbllisatietoja.TabIndex = 20;
            this.lbllisatietoja.Text = "Lisätietoja:";
            // 
            // txbxlisatietoja
            // 
            this.txbxlisatietoja.Location = new System.Drawing.Point(25, 363);
            this.txbxlisatietoja.Multiline = true;
            this.txbxlisatietoja.Name = "txbxlisatietoja";
            this.txbxlisatietoja.Size = new System.Drawing.Size(179, 81);
            this.txbxlisatietoja.TabIndex = 19;
            // 
            // clblisapalvelut
            // 
            this.clblisapalvelut.FormattingEnabled = true;
            this.clblisapalvelut.Location = new System.Drawing.Point(25, 267);
            this.clblisapalvelut.Name = "clblisapalvelut";
            this.clblisapalvelut.Size = new System.Drawing.Size(120, 49);
            this.clblisapalvelut.TabIndex = 18;
            // 
            // lbllisaplavelut
            // 
            this.lbllisaplavelut.AutoSize = true;
            this.lbllisaplavelut.Location = new System.Drawing.Point(22, 225);
            this.lbllisaplavelut.Name = "lbllisaplavelut";
            this.lbllisaplavelut.Size = new System.Drawing.Size(96, 13);
            this.lbllisaplavelut.TabIndex = 17;
            this.lbllisaplavelut.Text = "Valitse lisäpalvelut:";
            // 
            // cmbxyopyjat
            // 
            this.cmbxyopyjat.FormattingEnabled = true;
            this.cmbxyopyjat.Location = new System.Drawing.Point(22, 177);
            this.cmbxyopyjat.Name = "cmbxyopyjat";
            this.cmbxyopyjat.Size = new System.Drawing.Size(121, 21);
            this.cmbxyopyjat.TabIndex = 16;
            // 
            // lblyopyjat
            // 
            this.lblyopyjat.AutoSize = true;
            this.lblyopyjat.Location = new System.Drawing.Point(19, 144);
            this.lblyopyjat.Name = "lblyopyjat";
            this.lblyopyjat.Size = new System.Drawing.Size(82, 13);
            this.lblyopyjat.TabIndex = 15;
            this.lblyopyjat.Text = "Yöpyjien määrä:";
            // 
            // btnuusiasiakas
            // 
            this.btnuusiasiakas.Location = new System.Drawing.Point(114, 94);
            this.btnuusiasiakas.Name = "btnuusiasiakas";
            this.btnuusiasiakas.Size = new System.Drawing.Size(75, 23);
            this.btnuusiasiakas.TabIndex = 13;
            this.btnuusiasiakas.Text = "Uusi asiakas";
            this.btnuusiasiakas.UseVisualStyleBackColor = true;
            // 
            // btnetsiasiakas
            // 
            this.btnetsiasiakas.Location = new System.Drawing.Point(22, 94);
            this.btnetsiasiakas.Name = "btnetsiasiakas";
            this.btnetsiasiakas.Size = new System.Drawing.Size(75, 23);
            this.btnetsiasiakas.TabIndex = 12;
            this.btnetsiasiakas.Text = "Etsi asiakas";
            this.btnetsiasiakas.UseVisualStyleBackColor = true;
            // 
            // cmbxasiakas
            // 
            this.cmbxasiakas.FormattingEnabled = true;
            this.cmbxasiakas.Location = new System.Drawing.Point(22, 57);
            this.cmbxasiakas.Name = "cmbxasiakas";
            this.cmbxasiakas.Size = new System.Drawing.Size(167, 21);
            this.cmbxasiakas.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Controls.Add(this.btnperuutavaraus);
            this.groupBox3.Controls.Add(this.btnteevaraus);
            this.groupBox3.Controls.Add(this.txbxhinta);
            this.groupBox3.Controls.Add(this.lblhinta);
            this.groupBox3.Controls.Add(this.cmbxlaskutus);
            this.groupBox3.Controls.Add(this.lbllaskutus);
            this.groupBox3.Controls.Add(this.llblkuvat);
            this.groupBox3.Controls.Add(this.llblkartta);
            this.groupBox3.Controls.Add(this.lblyhteenveto);
            this.groupBox3.Controls.Add(this.txbxyhteenveto);
            this.groupBox3.Location = new System.Drawing.Point(654, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 493);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(77, 92);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 10;
            // 
            // btnperuutavaraus
            // 
            this.btnperuutavaraus.Location = new System.Drawing.Point(132, 446);
            this.btnperuutavaraus.Name = "btnperuutavaraus";
            this.btnperuutavaraus.Size = new System.Drawing.Size(75, 23);
            this.btnperuutavaraus.TabIndex = 9;
            this.btnperuutavaraus.Text = "Peruuta";
            this.btnperuutavaraus.UseVisualStyleBackColor = true;
            // 
            // btnteevaraus
            // 
            this.btnteevaraus.Location = new System.Drawing.Point(26, 446);
            this.btnteevaraus.Name = "btnteevaraus";
            this.btnteevaraus.Size = new System.Drawing.Size(75, 23);
            this.btnteevaraus.TabIndex = 8;
            this.btnteevaraus.Text = "Tee varaus";
            this.btnteevaraus.UseVisualStyleBackColor = true;
            // 
            // txbxhinta
            // 
            this.txbxhinta.Location = new System.Drawing.Point(26, 396);
            this.txbxhinta.Name = "txbxhinta";
            this.txbxhinta.Size = new System.Drawing.Size(121, 20);
            this.txbxhinta.TabIndex = 7;
            // 
            // lblhinta
            // 
            this.lblhinta.AutoSize = true;
            this.lblhinta.Location = new System.Drawing.Point(23, 366);
            this.lblhinta.Name = "lblhinta";
            this.lblhinta.Size = new System.Drawing.Size(81, 13);
            this.lblhinta.TabIndex = 6;
            this.lblhinta.Text = "Hinta yhteensä:";
            // 
            // cmbxlaskutus
            // 
            this.cmbxlaskutus.FormattingEnabled = true;
            this.cmbxlaskutus.Location = new System.Drawing.Point(26, 316);
            this.cmbxlaskutus.Name = "cmbxlaskutus";
            this.cmbxlaskutus.Size = new System.Drawing.Size(121, 21);
            this.cmbxlaskutus.TabIndex = 5;
            // 
            // lbllaskutus
            // 
            this.lbllaskutus.AutoSize = true;
            this.lbllaskutus.Location = new System.Drawing.Point(23, 277);
            this.lbllaskutus.Name = "lbllaskutus";
            this.lbllaskutus.Size = new System.Drawing.Size(53, 13);
            this.lbllaskutus.TabIndex = 4;
            this.lbllaskutus.Text = "Laskutus:";
            // 
            // llblkuvat
            // 
            this.llblkuvat.AutoSize = true;
            this.llblkuvat.Location = new System.Drawing.Point(72, 234);
            this.llblkuvat.Name = "llblkuvat";
            this.llblkuvat.Size = new System.Drawing.Size(35, 13);
            this.llblkuvat.TabIndex = 3;
            this.llblkuvat.TabStop = true;
            this.llblkuvat.Text = "Kuvat";
            // 
            // llblkartta
            // 
            this.llblkartta.AutoSize = true;
            this.llblkartta.Location = new System.Drawing.Point(20, 234);
            this.llblkartta.Name = "llblkartta";
            this.llblkartta.Size = new System.Drawing.Size(35, 13);
            this.llblkartta.TabIndex = 2;
            this.llblkartta.TabStop = true;
            this.llblkartta.Text = "Kartta";
            // 
            // lblyhteenveto
            // 
            this.lblyhteenveto.AutoSize = true;
            this.lblyhteenveto.Location = new System.Drawing.Point(23, 31);
            this.lblyhteenveto.Name = "lblyhteenveto";
            this.lblyhteenveto.Size = new System.Drawing.Size(65, 13);
            this.lblyhteenveto.TabIndex = 1;
            this.lblyhteenveto.Text = "Yhteenveto:";
            // 
            // txbxyhteenveto
            // 
            this.txbxyhteenveto.Location = new System.Drawing.Point(23, 57);
            this.txbxyhteenveto.Multiline = true;
            this.txbxyhteenveto.Name = "txbxyhteenveto";
            this.txbxyhteenveto.Size = new System.Drawing.Size(245, 157);
            this.txbxyhteenveto.TabIndex = 0;
            // 
            // UusiVaraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 605);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UusiVaraus";
            this.Text = "UusiVaraus";
            this.Load += new System.EventHandler(this.UusiVaraus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxtoimipiste;
        private System.Windows.Forms.Label lbltoimipiste;
        private System.Windows.Forms.Label lblmokkityyppi;
        private System.Windows.Forms.ComboBox cmbxmokkityyppi;
        private System.Windows.Forms.Label lblsaapumispvm;
        private System.Windows.Forms.DateTimePicker dtpsaapuminen;
        private System.Windows.Forms.DateTimePicker dtplahtopvm;
        private System.Windows.Forms.Label lbllahtopvm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbxalennus;
        private System.Windows.Forms.Label lblalennus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblvalitseasiakas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbllisatietoja;
        private System.Windows.Forms.TextBox txbxlisatietoja;
        private System.Windows.Forms.CheckedListBox clblisapalvelut;
        private System.Windows.Forms.Label lbllisaplavelut;
        private System.Windows.Forms.ComboBox cmbxyopyjat;
        private System.Windows.Forms.Label lblyopyjat;
        private System.Windows.Forms.Button btnuusiasiakas;
        private System.Windows.Forms.Button btnetsiasiakas;
        private System.Windows.Forms.ComboBox cmbxasiakas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnperuutavaraus;
        private System.Windows.Forms.Button btnteevaraus;
        private System.Windows.Forms.TextBox txbxhinta;
        private System.Windows.Forms.Label lblhinta;
        private System.Windows.Forms.ComboBox cmbxlaskutus;
        private System.Windows.Forms.Label lbllaskutus;
        private System.Windows.Forms.LinkLabel llblkuvat;
        private System.Windows.Forms.LinkLabel llblkartta;
        private System.Windows.Forms.Label lblyhteenveto;
        private System.Windows.Forms.TextBox txbxyhteenveto;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btntarkista;
    }
}