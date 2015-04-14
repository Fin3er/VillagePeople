namespace Mokkivarausjarjestelma
{
    partial class FormAsiakkaanHallinta
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
            this.lstbxAsiakaslista = new System.Windows.Forms.ListBox();
            this.lblAsiakaslista = new System.Windows.Forms.Label();
            this.txtbEtunimi = new System.Windows.Forms.TextBox();
            this.txtbSukunimi = new System.Windows.Forms.TextBox();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.txtbSyntymaaika = new System.Windows.Forms.TextBox();
            this.lblSyntymaaika = new System.Windows.Forms.Label();
            this.txtbKatuosoite = new System.Windows.Forms.TextBox();
            this.txtbPostinumero = new System.Windows.Forms.TextBox();
            this.txtbMaa = new System.Windows.Forms.TextBox();
            this.txtbPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.lblKatuosoite = new System.Windows.Forms.Label();
            this.lblPostitoimipaikka = new System.Windows.Forms.Label();
            this.lblPostinumero = new System.Windows.Forms.Label();
            this.lblMaa = new System.Windows.Forms.Label();
            this.cbbxNimitys = new System.Windows.Forms.ComboBox();
            this.lblNimitys = new System.Windows.Forms.Label();
            this.txtbPuhelinnumero = new System.Windows.Forms.TextBox();
            this.lblPuhelinumero = new System.Windows.Forms.Label();
            this.txtbSahkopostiosoite = new System.Windows.Forms.TextBox();
            this.lblSahkopostiosoite = new System.Windows.Forms.Label();
            this.btnLisaaUusiAsiakas = new System.Windows.Forms.Button();
            this.btnPoistaAsiakas = new System.Windows.Forms.Button();
            this.btnTallennaTiedot = new System.Windows.Forms.Button();
            this.txbxAsiakasnumero = new System.Windows.Forms.TextBox();
            this.lblAsiakasnumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxAsiakaslista
            // 
            this.lstbxAsiakaslista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxAsiakaslista.FormattingEnabled = true;
            this.lstbxAsiakaslista.ItemHeight = 20;
            this.lstbxAsiakaslista.Location = new System.Drawing.Point(42, 56);
            this.lstbxAsiakaslista.Margin = new System.Windows.Forms.Padding(4);
            this.lstbxAsiakaslista.Name = "lstbxAsiakaslista";
            this.lstbxAsiakaslista.Size = new System.Drawing.Size(200, 444);
            this.lstbxAsiakaslista.TabIndex = 0;
            this.lstbxAsiakaslista.SelectedIndexChanged += new System.EventHandler(this.lstbxAsiakaslista_SelectedIndexChanged);
            // 
            // lblAsiakaslista
            // 
            this.lblAsiakaslista.AutoSize = true;
            this.lblAsiakaslista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiakaslista.Location = new System.Drawing.Point(37, 32);
            this.lblAsiakaslista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsiakaslista.Name = "lblAsiakaslista";
            this.lblAsiakaslista.Size = new System.Drawing.Size(97, 20);
            this.lblAsiakaslista.TabIndex = 1;
            this.lblAsiakaslista.Text = "Asiakaslista:";
            this.lblAsiakaslista.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbEtunimi
            // 
            this.txtbEtunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEtunimi.Location = new System.Drawing.Point(534, 126);
            this.txtbEtunimi.Margin = new System.Windows.Forms.Padding(4);
            this.txtbEtunimi.Name = "txtbEtunimi";
            this.txtbEtunimi.Size = new System.Drawing.Size(132, 26);
            this.txtbEtunimi.TabIndex = 2;
            // 
            // txtbSukunimi
            // 
            this.txtbSukunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSukunimi.Location = new System.Drawing.Point(696, 126);
            this.txtbSukunimi.Margin = new System.Windows.Forms.Padding(4);
            this.txtbSukunimi.Name = "txtbSukunimi";
            this.txtbSukunimi.Size = new System.Drawing.Size(132, 26);
            this.txtbSukunimi.TabIndex = 3;
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtunimi.Location = new System.Drawing.Point(530, 102);
            this.lblEtunimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(66, 20);
            this.lblEtunimi.TabIndex = 4;
            this.lblEtunimi.Text = "Etunimi:";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSukunimi.Location = new System.Drawing.Point(692, 102);
            this.lblSukunimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(78, 20);
            this.lblSukunimi.TabIndex = 5;
            this.lblSukunimi.Text = "Sukunimi:";
            // 
            // txtbSyntymaaika
            // 
            this.txtbSyntymaaika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSyntymaaika.Location = new System.Drawing.Point(347, 203);
            this.txtbSyntymaaika.Margin = new System.Windows.Forms.Padding(4);
            this.txtbSyntymaaika.Name = "txtbSyntymaaika";
            this.txtbSyntymaaika.Size = new System.Drawing.Size(132, 26);
            this.txtbSyntymaaika.TabIndex = 6;
            // 
            // lblSyntymaaika
            // 
            this.lblSyntymaaika.AutoSize = true;
            this.lblSyntymaaika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSyntymaaika.Location = new System.Drawing.Point(343, 179);
            this.lblSyntymaaika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSyntymaaika.Name = "lblSyntymaaika";
            this.lblSyntymaaika.Size = new System.Drawing.Size(103, 20);
            this.lblSyntymaaika.TabIndex = 7;
            this.lblSyntymaaika.Text = "Syntymäaika:";
            // 
            // txtbKatuosoite
            // 
            this.txtbKatuosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbKatuosoite.Location = new System.Drawing.Point(346, 266);
            this.txtbKatuosoite.Margin = new System.Windows.Forms.Padding(4);
            this.txtbKatuosoite.Name = "txtbKatuosoite";
            this.txtbKatuosoite.Size = new System.Drawing.Size(185, 26);
            this.txtbKatuosoite.TabIndex = 8;
            // 
            // txtbPostinumero
            // 
            this.txtbPostinumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPostinumero.Location = new System.Drawing.Point(346, 320);
            this.txtbPostinumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtbPostinumero.Name = "txtbPostinumero";
            this.txtbPostinumero.Size = new System.Drawing.Size(132, 26);
            this.txtbPostinumero.TabIndex = 9;
            // 
            // txtbMaa
            // 
            this.txtbMaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaa.Location = new System.Drawing.Point(347, 374);
            this.txtbMaa.Margin = new System.Windows.Forms.Padding(4);
            this.txtbMaa.Name = "txtbMaa";
            this.txtbMaa.Size = new System.Drawing.Size(147, 26);
            this.txtbMaa.TabIndex = 10;
            // 
            // txtbPostitoimipaikka
            // 
            this.txtbPostitoimipaikka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPostitoimipaikka.Location = new System.Drawing.Point(486, 320);
            this.txtbPostitoimipaikka.Margin = new System.Windows.Forms.Padding(4);
            this.txtbPostitoimipaikka.Name = "txtbPostitoimipaikka";
            this.txtbPostitoimipaikka.Size = new System.Drawing.Size(180, 26);
            this.txtbPostitoimipaikka.TabIndex = 11;
            // 
            // lblKatuosoite
            // 
            this.lblKatuosoite.AutoSize = true;
            this.lblKatuosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKatuosoite.Location = new System.Drawing.Point(342, 242);
            this.lblKatuosoite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKatuosoite.Name = "lblKatuosoite";
            this.lblKatuosoite.Size = new System.Drawing.Size(89, 20);
            this.lblKatuosoite.TabIndex = 12;
            this.lblKatuosoite.Text = "Katuosoite:";
            // 
            // lblPostitoimipaikka
            // 
            this.lblPostitoimipaikka.AutoSize = true;
            this.lblPostitoimipaikka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostitoimipaikka.Location = new System.Drawing.Point(482, 296);
            this.lblPostitoimipaikka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostitoimipaikka.Name = "lblPostitoimipaikka";
            this.lblPostitoimipaikka.Size = new System.Drawing.Size(127, 20);
            this.lblPostitoimipaikka.TabIndex = 13;
            this.lblPostitoimipaikka.Text = "Postitoimipaikka:";
            // 
            // lblPostinumero
            // 
            this.lblPostinumero.AutoSize = true;
            this.lblPostinumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostinumero.Location = new System.Drawing.Point(342, 296);
            this.lblPostinumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostinumero.Name = "lblPostinumero";
            this.lblPostinumero.Size = new System.Drawing.Size(102, 20);
            this.lblPostinumero.TabIndex = 14;
            this.lblPostinumero.Text = "Postinumero:";
            this.lblPostinumero.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblMaa
            // 
            this.lblMaa.AutoSize = true;
            this.lblMaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaa.Location = new System.Drawing.Point(343, 350);
            this.lblMaa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaa.Name = "lblMaa";
            this.lblMaa.Size = new System.Drawing.Size(44, 20);
            this.lblMaa.TabIndex = 15;
            this.lblMaa.Text = "Maa:";
            // 
            // cbbxNimitys
            // 
            this.cbbxNimitys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbxNimitys.FormattingEnabled = true;
            this.cbbxNimitys.Location = new System.Drawing.Point(347, 124);
            this.cbbxNimitys.Margin = new System.Windows.Forms.Padding(4);
            this.cbbxNimitys.Name = "cbbxNimitys";
            this.cbbxNimitys.Size = new System.Drawing.Size(160, 28);
            this.cbbxNimitys.TabIndex = 16;
            // 
            // lblNimitys
            // 
            this.lblNimitys.AutoSize = true;
            this.lblNimitys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNimitys.Location = new System.Drawing.Point(343, 100);
            this.lblNimitys.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNimitys.Name = "lblNimitys";
            this.lblNimitys.Size = new System.Drawing.Size(63, 20);
            this.lblNimitys.TabIndex = 17;
            this.lblNimitys.Text = "Nimitys:";
            // 
            // txtbPuhelinnumero
            // 
            this.txtbPuhelinnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPuhelinnumero.Location = new System.Drawing.Point(347, 450);
            this.txtbPuhelinnumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtbPuhelinnumero.Name = "txtbPuhelinnumero";
            this.txtbPuhelinnumero.Size = new System.Drawing.Size(132, 26);
            this.txtbPuhelinnumero.TabIndex = 18;
            // 
            // lblPuhelinumero
            // 
            this.lblPuhelinumero.AutoSize = true;
            this.lblPuhelinumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuhelinumero.Location = new System.Drawing.Point(343, 426);
            this.lblPuhelinumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuhelinumero.Name = "lblPuhelinumero";
            this.lblPuhelinumero.Size = new System.Drawing.Size(119, 20);
            this.lblPuhelinumero.TabIndex = 19;
            this.lblPuhelinumero.Text = "Puhelinnumero:";
            // 
            // txtbSahkopostiosoite
            // 
            this.txtbSahkopostiosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSahkopostiosoite.Location = new System.Drawing.Point(520, 450);
            this.txtbSahkopostiosoite.Margin = new System.Windows.Forms.Padding(4);
            this.txtbSahkopostiosoite.Name = "txtbSahkopostiosoite";
            this.txtbSahkopostiosoite.Size = new System.Drawing.Size(264, 26);
            this.txtbSahkopostiosoite.TabIndex = 20;
            // 
            // lblSahkopostiosoite
            // 
            this.lblSahkopostiosoite.AutoSize = true;
            this.lblSahkopostiosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSahkopostiosoite.Location = new System.Drawing.Point(516, 426);
            this.lblSahkopostiosoite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSahkopostiosoite.Name = "lblSahkopostiosoite";
            this.lblSahkopostiosoite.Size = new System.Drawing.Size(136, 20);
            this.lblSahkopostiosoite.TabIndex = 21;
            this.lblSahkopostiosoite.Text = "Sähköpostiosoite:";
            // 
            // btnLisaaUusiAsiakas
            // 
            this.btnLisaaUusiAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaaUusiAsiakas.Location = new System.Drawing.Point(42, 523);
            this.btnLisaaUusiAsiakas.Margin = new System.Windows.Forms.Padding(4);
            this.btnLisaaUusiAsiakas.Name = "btnLisaaUusiAsiakas";
            this.btnLisaaUusiAsiakas.Size = new System.Drawing.Size(200, 46);
            this.btnLisaaUusiAsiakas.TabIndex = 22;
            this.btnLisaaUusiAsiakas.Text = "Lisää uusi asiakas";
            this.btnLisaaUusiAsiakas.UseVisualStyleBackColor = true;
            this.btnLisaaUusiAsiakas.Click += new System.EventHandler(this.btnLisaaUusiAsiakas_Click);
            // 
            // btnPoistaAsiakas
            // 
            this.btnPoistaAsiakas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPoistaAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaAsiakas.Location = new System.Drawing.Point(41, 651);
            this.btnPoistaAsiakas.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoistaAsiakas.Name = "btnPoistaAsiakas";
            this.btnPoistaAsiakas.Size = new System.Drawing.Size(200, 46);
            this.btnPoistaAsiakas.TabIndex = 23;
            this.btnPoistaAsiakas.Text = "Poista asiakas";
            this.btnPoistaAsiakas.UseVisualStyleBackColor = false;
            // 
            // btnTallennaTiedot
            // 
            this.btnTallennaTiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTallennaTiedot.Location = new System.Drawing.Point(41, 587);
            this.btnTallennaTiedot.Margin = new System.Windows.Forms.Padding(4);
            this.btnTallennaTiedot.Name = "btnTallennaTiedot";
            this.btnTallennaTiedot.Size = new System.Drawing.Size(200, 46);
            this.btnTallennaTiedot.TabIndex = 24;
            this.btnTallennaTiedot.Text = "Tallenna tiedot";
            this.btnTallennaTiedot.UseVisualStyleBackColor = true;
            this.btnTallennaTiedot.Click += new System.EventHandler(this.btnTallennaTiedot_Click);
            // 
            // txbxAsiakasnumero
            // 
            this.txbxAsiakasnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxAsiakasnumero.Location = new System.Drawing.Point(347, 56);
            this.txbxAsiakasnumero.Name = "txbxAsiakasnumero";
            this.txbxAsiakasnumero.Size = new System.Drawing.Size(123, 26);
            this.txbxAsiakasnumero.TabIndex = 25;
            // 
            // lblAsiakasnumero
            // 
            this.lblAsiakasnumero.AutoSize = true;
            this.lblAsiakasnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiakasnumero.Location = new System.Drawing.Point(347, 32);
            this.lblAsiakasnumero.Name = "lblAsiakasnumero";
            this.lblAsiakasnumero.Size = new System.Drawing.Size(123, 20);
            this.lblAsiakasnumero.TabIndex = 26;
            this.lblAsiakasnumero.Text = "Asiakasnumero:";
            // 
            // FormAsiakkaanHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 699);
            this.Controls.Add(this.lblAsiakasnumero);
            this.Controls.Add(this.txbxAsiakasnumero);
            this.Controls.Add(this.btnTallennaTiedot);
            this.Controls.Add(this.btnPoistaAsiakas);
            this.Controls.Add(this.btnLisaaUusiAsiakas);
            this.Controls.Add(this.lblSahkopostiosoite);
            this.Controls.Add(this.txtbSahkopostiosoite);
            this.Controls.Add(this.lblPuhelinumero);
            this.Controls.Add(this.txtbPuhelinnumero);
            this.Controls.Add(this.lblNimitys);
            this.Controls.Add(this.cbbxNimitys);
            this.Controls.Add(this.lblMaa);
            this.Controls.Add(this.lblPostinumero);
            this.Controls.Add(this.lblPostitoimipaikka);
            this.Controls.Add(this.lblKatuosoite);
            this.Controls.Add(this.txtbPostitoimipaikka);
            this.Controls.Add(this.txtbMaa);
            this.Controls.Add(this.txtbPostinumero);
            this.Controls.Add(this.txtbKatuosoite);
            this.Controls.Add(this.lblSyntymaaika);
            this.Controls.Add(this.txtbSyntymaaika);
            this.Controls.Add(this.lblSukunimi);
            this.Controls.Add(this.lblEtunimi);
            this.Controls.Add(this.txtbSukunimi);
            this.Controls.Add(this.txtbEtunimi);
            this.Controls.Add(this.lblAsiakaslista);
            this.Controls.Add(this.lstbxAsiakaslista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAsiakkaanHallinta";
            this.Text = "Asiakkaanhallinta";
            this.Load += new System.EventHandler(this.Asiakkaanhallinta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxAsiakaslista;
        private System.Windows.Forms.Label lblAsiakaslista;
        private System.Windows.Forms.TextBox txtbEtunimi;
        private System.Windows.Forms.TextBox txtbSukunimi;
        private System.Windows.Forms.Label lblEtunimi;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.TextBox txtbSyntymaaika;
        private System.Windows.Forms.Label lblSyntymaaika;
        private System.Windows.Forms.TextBox txtbKatuosoite;
        private System.Windows.Forms.TextBox txtbPostinumero;
        private System.Windows.Forms.TextBox txtbMaa;
        private System.Windows.Forms.TextBox txtbPostitoimipaikka;
        private System.Windows.Forms.Label lblKatuosoite;
        private System.Windows.Forms.Label lblPostitoimipaikka;
        private System.Windows.Forms.Label lblPostinumero;
        private System.Windows.Forms.Label lblMaa;
        private System.Windows.Forms.ComboBox cbbxNimitys;
        private System.Windows.Forms.Label lblNimitys;
        private System.Windows.Forms.TextBox txtbPuhelinnumero;
        private System.Windows.Forms.Label lblPuhelinumero;
        private System.Windows.Forms.TextBox txtbSahkopostiosoite;
        private System.Windows.Forms.Label lblSahkopostiosoite;
        private System.Windows.Forms.Button btnLisaaUusiAsiakas;
        private System.Windows.Forms.Button btnPoistaAsiakas;
        private System.Windows.Forms.Button btnTallennaTiedot;
        private System.Windows.Forms.TextBox txbxAsiakasnumero;
        private System.Windows.Forms.Label lblAsiakasnumero;
    }
}

