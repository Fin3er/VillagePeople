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
            this.txtbPostiosoite = new System.Windows.Forms.TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbhenktunnus = new System.Windows.Forms.TextBox();
            this.lblkansalaisuus = new System.Windows.Forms.Label();
            this.txtbkansalaisuus = new System.Windows.Forms.TextBox();
            this.lbllisatietoja = new System.Windows.Forms.Label();
            this.txtblisatietoja = new System.Windows.Forms.TextBox();
            this.lblmuut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxAsiakaslista
            // 
            this.lstbxAsiakaslista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxAsiakaslista.FormattingEnabled = true;
            this.lstbxAsiakaslista.ItemHeight = 24;
            this.lstbxAsiakaslista.Location = new System.Drawing.Point(42, 55);
            this.lstbxAsiakaslista.Margin = new System.Windows.Forms.Padding(4);
            this.lstbxAsiakaslista.Name = "lstbxAsiakaslista";
            this.lstbxAsiakaslista.Size = new System.Drawing.Size(200, 676);
            this.lstbxAsiakaslista.TabIndex = 0;
            this.lstbxAsiakaslista.SelectedIndexChanged += new System.EventHandler(this.lstbxAsiakaslista_SelectedIndexChanged);
            // 
            // lblAsiakaslista
            // 
            this.lblAsiakaslista.AutoSize = true;
            this.lblAsiakaslista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiakaslista.Location = new System.Drawing.Point(37, 19);
            this.lblAsiakaslista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsiakaslista.Name = "lblAsiakaslista";
            this.lblAsiakaslista.Size = new System.Drawing.Size(127, 25);
            this.lblAsiakaslista.TabIndex = 1;
            this.lblAsiakaslista.Text = "Asiakaslista";
            // 
            // txtbEtunimi
            // 
            this.txtbEtunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEtunimi.Location = new System.Drawing.Point(465, 125);
            this.txtbEtunimi.Margin = new System.Windows.Forms.Padding(4);
            this.txtbEtunimi.Name = "txtbEtunimi";
            this.txtbEtunimi.Size = new System.Drawing.Size(200, 29);
            this.txtbEtunimi.TabIndex = 2;
            // 
            // txtbSukunimi
            // 
            this.txtbSukunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSukunimi.Location = new System.Drawing.Point(465, 159);
            this.txtbSukunimi.Margin = new System.Windows.Forms.Padding(4);
            this.txtbSukunimi.Name = "txtbSukunimi";
            this.txtbSukunimi.Size = new System.Drawing.Size(200, 29);
            this.txtbSukunimi.TabIndex = 3;
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtunimi.Location = new System.Drawing.Point(379, 128);
            this.lblEtunimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(78, 24);
            this.lblEtunimi.TabIndex = 4;
            this.lblEtunimi.Text = "Etunimi:";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSukunimi.Location = new System.Drawing.Point(364, 162);
            this.lblSukunimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(93, 24);
            this.lblSukunimi.TabIndex = 5;
            this.lblSukunimi.Text = "Sukunimi:";
            // 
            // txtbSyntymaaika
            // 
            this.txtbSyntymaaika.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSyntymaaika.Location = new System.Drawing.Point(465, 236);
            this.txtbSyntymaaika.Margin = new System.Windows.Forms.Padding(4);
            this.txtbSyntymaaika.Name = "txtbSyntymaaika";
            this.txtbSyntymaaika.Size = new System.Drawing.Size(200, 29);
            this.txtbSyntymaaika.TabIndex = 6;
            // 
            // lblSyntymaaika
            // 
            this.lblSyntymaaika.AutoSize = true;
            this.lblSyntymaaika.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSyntymaaika.Location = new System.Drawing.Point(338, 239);
            this.lblSyntymaaika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSyntymaaika.Name = "lblSyntymaaika";
            this.lblSyntymaaika.Size = new System.Drawing.Size(119, 24);
            this.lblSyntymaaika.TabIndex = 7;
            this.lblSyntymaaika.Text = "Syntymäaika:";
            // 
            // txtbPostiosoite
            // 
            this.txtbPostiosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPostiosoite.Location = new System.Drawing.Point(881, 55);
            this.txtbPostiosoite.Margin = new System.Windows.Forms.Padding(4);
            this.txtbPostiosoite.Name = "txtbPostiosoite";
            this.txtbPostiosoite.Size = new System.Drawing.Size(200, 29);
            this.txtbPostiosoite.TabIndex = 8;
            // 
            // txtbPostinumero
            // 
            this.txtbPostinumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPostinumero.Location = new System.Drawing.Point(881, 89);
            this.txtbPostinumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtbPostinumero.Name = "txtbPostinumero";
            this.txtbPostinumero.Size = new System.Drawing.Size(200, 29);
            this.txtbPostinumero.TabIndex = 9;
            // 
            // txtbMaa
            // 
            this.txtbMaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaa.Location = new System.Drawing.Point(881, 157);
            this.txtbMaa.Margin = new System.Windows.Forms.Padding(4);
            this.txtbMaa.Name = "txtbMaa";
            this.txtbMaa.Size = new System.Drawing.Size(200, 29);
            this.txtbMaa.TabIndex = 10;
            // 
            // txtbPostitoimipaikka
            // 
            this.txtbPostitoimipaikka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPostitoimipaikka.Location = new System.Drawing.Point(881, 123);
            this.txtbPostitoimipaikka.Margin = new System.Windows.Forms.Padding(4);
            this.txtbPostitoimipaikka.Name = "txtbPostitoimipaikka";
            this.txtbPostitoimipaikka.Size = new System.Drawing.Size(200, 29);
            this.txtbPostitoimipaikka.TabIndex = 11;
            // 
            // lblKatuosoite
            // 
            this.lblKatuosoite.AutoSize = true;
            this.lblKatuosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKatuosoite.Location = new System.Drawing.Point(768, 58);
            this.lblKatuosoite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKatuosoite.Name = "lblKatuosoite";
            this.lblKatuosoite.Size = new System.Drawing.Size(105, 24);
            this.lblKatuosoite.TabIndex = 12;
            this.lblKatuosoite.Text = "Postiosoite:";
            // 
            // lblPostitoimipaikka
            // 
            this.lblPostitoimipaikka.AutoSize = true;
            this.lblPostitoimipaikka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostitoimipaikka.Location = new System.Drawing.Point(726, 126);
            this.lblPostitoimipaikka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostitoimipaikka.Name = "lblPostitoimipaikka";
            this.lblPostitoimipaikka.Size = new System.Drawing.Size(147, 24);
            this.lblPostitoimipaikka.TabIndex = 13;
            this.lblPostitoimipaikka.Text = "Postitoimipaikka:";
            // 
            // lblPostinumero
            // 
            this.lblPostinumero.AutoSize = true;
            this.lblPostinumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostinumero.Location = new System.Drawing.Point(752, 92);
            this.lblPostinumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostinumero.Name = "lblPostinumero";
            this.lblPostinumero.Size = new System.Drawing.Size(121, 24);
            this.lblPostinumero.TabIndex = 14;
            this.lblPostinumero.Text = "Postinumero:";
            // 
            // lblMaa
            // 
            this.lblMaa.AutoSize = true;
            this.lblMaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaa.Location = new System.Drawing.Point(822, 160);
            this.lblMaa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaa.Name = "lblMaa";
            this.lblMaa.Size = new System.Drawing.Size(51, 24);
            this.lblMaa.TabIndex = 15;
            this.lblMaa.Text = "Maa:";
            // 
            // cbbxNimitys
            // 
            this.cbbxNimitys.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbxNimitys.FormattingEnabled = true;
            this.cbbxNimitys.Location = new System.Drawing.Point(465, 89);
            this.cbbxNimitys.Margin = new System.Windows.Forms.Padding(4);
            this.cbbxNimitys.Name = "cbbxNimitys";
            this.cbbxNimitys.Size = new System.Drawing.Size(200, 32);
            this.cbbxNimitys.TabIndex = 16;
            // 
            // lblNimitys
            // 
            this.lblNimitys.AutoSize = true;
            this.lblNimitys.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNimitys.Location = new System.Drawing.Point(399, 92);
            this.lblNimitys.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNimitys.Name = "lblNimitys";
            this.lblNimitys.Size = new System.Drawing.Size(58, 24);
            this.lblNimitys.TabIndex = 17;
            this.lblNimitys.Text = "Titteli:";
            // 
            // txtbPuhelinnumero
            // 
            this.txtbPuhelinnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPuhelinnumero.Location = new System.Drawing.Point(465, 387);
            this.txtbPuhelinnumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtbPuhelinnumero.Name = "txtbPuhelinnumero";
            this.txtbPuhelinnumero.Size = new System.Drawing.Size(200, 29);
            this.txtbPuhelinnumero.TabIndex = 18;
            // 
            // lblPuhelinumero
            // 
            this.lblPuhelinumero.AutoSize = true;
            this.lblPuhelinumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuhelinumero.Location = new System.Drawing.Point(312, 390);
            this.lblPuhelinumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuhelinumero.Name = "lblPuhelinumero";
            this.lblPuhelinumero.Size = new System.Drawing.Size(145, 24);
            this.lblPuhelinumero.TabIndex = 19;
            this.lblPuhelinumero.Text = "Puhelinnumero:";
            // 
            // txtbSahkopostiosoite
            // 
            this.txtbSahkopostiosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSahkopostiosoite.Location = new System.Drawing.Point(465, 421);
            this.txtbSahkopostiosoite.Margin = new System.Windows.Forms.Padding(4);
            this.txtbSahkopostiosoite.Name = "txtbSahkopostiosoite";
            this.txtbSahkopostiosoite.Size = new System.Drawing.Size(200, 29);
            this.txtbSahkopostiosoite.TabIndex = 20;
            // 
            // lblSahkopostiosoite
            // 
            this.lblSahkopostiosoite.AutoSize = true;
            this.lblSahkopostiosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSahkopostiosoite.Location = new System.Drawing.Point(300, 424);
            this.lblSahkopostiosoite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSahkopostiosoite.Name = "lblSahkopostiosoite";
            this.lblSahkopostiosoite.Size = new System.Drawing.Size(157, 24);
            this.lblSahkopostiosoite.TabIndex = 21;
            this.lblSahkopostiosoite.Text = "Sähköpostiosoite:";
            // 
            // btnLisaaUusiAsiakas
            // 
            this.btnLisaaUusiAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaaUusiAsiakas.Location = new System.Drawing.Point(465, 686);
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
            this.btnPoistaAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaAsiakas.Location = new System.Drawing.Point(881, 686);
            this.btnPoistaAsiakas.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoistaAsiakas.Name = "btnPoistaAsiakas";
            this.btnPoistaAsiakas.Size = new System.Drawing.Size(200, 46);
            this.btnPoistaAsiakas.TabIndex = 23;
            this.btnPoistaAsiakas.Text = "Poista asiakas";
            this.btnPoistaAsiakas.UseVisualStyleBackColor = false;
            this.btnPoistaAsiakas.Click += new System.EventHandler(this.btnPoistaAsiakas_Click);
            // 
            // btnTallennaTiedot
            // 
            this.btnTallennaTiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTallennaTiedot.Location = new System.Drawing.Point(673, 686);
            this.btnTallennaTiedot.Margin = new System.Windows.Forms.Padding(4);
            this.btnTallennaTiedot.Name = "btnTallennaTiedot";
            this.btnTallennaTiedot.Size = new System.Drawing.Size(200, 46);
            this.btnTallennaTiedot.TabIndex = 24;
            this.btnTallennaTiedot.Text = "Muokkaa tietoja";
            this.btnTallennaTiedot.UseVisualStyleBackColor = true;
            this.btnTallennaTiedot.Click += new System.EventHandler(this.btnTallennaTiedot_Click);
            // 
            // txbxAsiakasnumero
            // 
            this.txbxAsiakasnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxAsiakasnumero.Location = new System.Drawing.Point(465, 56);
            this.txbxAsiakasnumero.Name = "txbxAsiakasnumero";
            this.txbxAsiakasnumero.Size = new System.Drawing.Size(200, 29);
            this.txbxAsiakasnumero.TabIndex = 25;
            // 
            // lblAsiakasnumero
            // 
            this.lblAsiakasnumero.AutoSize = true;
            this.lblAsiakasnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiakasnumero.Location = new System.Drawing.Point(314, 59);
            this.lblAsiakasnumero.Name = "lblAsiakasnumero";
            this.lblAsiakasnumero.Size = new System.Drawing.Size(145, 24);
            this.lblAsiakasnumero.TabIndex = 26;
            this.lblAsiakasnumero.Text = "Asiakasnumero:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Asiakastiedot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Yhteystiedot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(813, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Osoitetiedot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Henkilötunnus:";
            // 
            // txtbhenktunnus
            // 
            this.txtbhenktunnus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbhenktunnus.Location = new System.Drawing.Point(465, 273);
            this.txtbhenktunnus.Margin = new System.Windows.Forms.Padding(4);
            this.txtbhenktunnus.Name = "txtbhenktunnus";
            this.txtbhenktunnus.Size = new System.Drawing.Size(200, 29);
            this.txtbhenktunnus.TabIndex = 30;
            // 
            // lblkansalaisuus
            // 
            this.lblkansalaisuus.AutoSize = true;
            this.lblkansalaisuus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkansalaisuus.Location = new System.Drawing.Point(332, 313);
            this.lblkansalaisuus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkansalaisuus.Name = "lblkansalaisuus";
            this.lblkansalaisuus.Size = new System.Drawing.Size(125, 24);
            this.lblkansalaisuus.TabIndex = 33;
            this.lblkansalaisuus.Text = "Kansalaisuus:";
            // 
            // txtbkansalaisuus
            // 
            this.txtbkansalaisuus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbkansalaisuus.Location = new System.Drawing.Point(465, 310);
            this.txtbkansalaisuus.Margin = new System.Windows.Forms.Padding(4);
            this.txtbkansalaisuus.Name = "txtbkansalaisuus";
            this.txtbkansalaisuus.Size = new System.Drawing.Size(200, 29);
            this.txtbkansalaisuus.TabIndex = 32;
            // 
            // lbllisatietoja
            // 
            this.lbllisatietoja.AutoSize = true;
            this.lbllisatietoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllisatietoja.Location = new System.Drawing.Point(777, 277);
            this.lbllisatietoja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllisatietoja.Name = "lbllisatietoja";
            this.lbllisatietoja.Size = new System.Drawing.Size(96, 24);
            this.lbllisatietoja.TabIndex = 34;
            this.lbllisatietoja.Text = "Lisätietoja:";
            // 
            // txtblisatietoja
            // 
            this.txtblisatietoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtblisatietoja.Location = new System.Drawing.Point(881, 277);
            this.txtblisatietoja.Margin = new System.Windows.Forms.Padding(4);
            this.txtblisatietoja.Multiline = true;
            this.txtblisatietoja.Name = "txtblisatietoja";
            this.txtblisatietoja.Size = new System.Drawing.Size(200, 173);
            this.txtblisatietoja.TabIndex = 35;
            // 
            // lblmuut
            // 
            this.lblmuut.AutoSize = true;
            this.lblmuut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmuut.Location = new System.Drawing.Point(847, 241);
            this.lblmuut.Name = "lblmuut";
            this.lblmuut.Size = new System.Drawing.Size(60, 25);
            this.lblmuut.TabIndex = 36;
            this.lblmuut.Text = "Muut";
            // 
            // FormAsiakkaanHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblmuut);
            this.Controls.Add(this.txtblisatietoja);
            this.Controls.Add(this.lbllisatietoja);
            this.Controls.Add(this.lblkansalaisuus);
            this.Controls.Add(this.txtbkansalaisuus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbhenktunnus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.txtbPostiosoite);
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
            this.Size = new System.Drawing.Size(1100, 750);
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
        private System.Windows.Forms.TextBox txtbPostiosoite;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbhenktunnus;
        private System.Windows.Forms.Label lblkansalaisuus;
        private System.Windows.Forms.TextBox txtbkansalaisuus;
        private System.Windows.Forms.Label lbllisatietoja;
        private System.Windows.Forms.TextBox txtblisatietoja;
        private System.Windows.Forms.Label lblmuut;
    }
}

