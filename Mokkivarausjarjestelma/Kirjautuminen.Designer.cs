namespace Mokkivarausjarjestelma
{
    partial class Kirjautuminen
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
            this.btn_kirjaudu = new System.Windows.Forms.Button();
            this.lbl_villagepeople = new System.Windows.Forms.Label();
            this.lbl_mokkivaraus = new System.Windows.Forms.Label();
            this.txtB_kayttajatunnus = new System.Windows.Forms.TextBox();
            this.lbl_kayttajatunnus = new System.Windows.Forms.Label();
            this.lbl_salasana = new System.Windows.Forms.Label();
            this.txtB_Salasana = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_kirjaudu
            // 
            this.btn_kirjaudu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kirjaudu.Location = new System.Drawing.Point(490, 516);
            this.btn_kirjaudu.Name = "btn_kirjaudu";
            this.btn_kirjaudu.Size = new System.Drawing.Size(190, 60);
            this.btn_kirjaudu.TabIndex = 0;
            this.btn_kirjaudu.Text = "Kirjaudu";
            this.btn_kirjaudu.UseVisualStyleBackColor = true;
            // 
            // lbl_villagepeople
            // 
            this.lbl_villagepeople.AutoSize = true;
            this.lbl_villagepeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_villagepeople.Location = new System.Drawing.Point(469, 132);
            this.lbl_villagepeople.Name = "lbl_villagepeople";
            this.lbl_villagepeople.Size = new System.Drawing.Size(237, 39);
            this.lbl_villagepeople.TabIndex = 1;
            this.lbl_villagepeople.Text = "Village People";
            // 
            // lbl_mokkivaraus
            // 
            this.lbl_mokkivaraus.AutoSize = true;
            this.lbl_mokkivaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mokkivaraus.Location = new System.Drawing.Point(403, 190);
            this.lbl_mokkivaraus.Name = "lbl_mokkivaraus";
            this.lbl_mokkivaraus.Size = new System.Drawing.Size(384, 39);
            this.lbl_mokkivaraus.TabIndex = 2;
            this.lbl_mokkivaraus.Text = "Mökkivarausjärjestelmä";
            // 
            // txtB_kayttajatunnus
            // 
            this.txtB_kayttajatunnus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_kayttajatunnus.Location = new System.Drawing.Point(490, 404);
            this.txtB_kayttajatunnus.Name = "txtB_kayttajatunnus";
            this.txtB_kayttajatunnus.Size = new System.Drawing.Size(190, 35);
            this.txtB_kayttajatunnus.TabIndex = 3;
            // 
            // lbl_kayttajatunnus
            // 
            this.lbl_kayttajatunnus.AutoSize = true;
            this.lbl_kayttajatunnus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kayttajatunnus.Location = new System.Drawing.Point(317, 407);
            this.lbl_kayttajatunnus.Name = "lbl_kayttajatunnus";
            this.lbl_kayttajatunnus.Size = new System.Drawing.Size(167, 29);
            this.lbl_kayttajatunnus.TabIndex = 5;
            this.lbl_kayttajatunnus.Text = "Käyttäjätunnus";
            // 
            // lbl_salasana
            // 
            this.lbl_salasana.AutoSize = true;
            this.lbl_salasana.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salasana.Location = new System.Drawing.Point(372, 456);
            this.lbl_salasana.Name = "lbl_salasana";
            this.lbl_salasana.Size = new System.Drawing.Size(112, 29);
            this.lbl_salasana.TabIndex = 7;
            this.lbl_salasana.Text = "Salasana";
            // 
            // txtB_Salasana
            // 
            this.txtB_Salasana.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_Salasana.Location = new System.Drawing.Point(490, 453);
            this.txtB_Salasana.Name = "txtB_Salasana";
            this.txtB_Salasana.Size = new System.Drawing.Size(190, 35);
            this.txtB_Salasana.TabIndex = 6;
            // 
            // Kirjautuminen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.lbl_salasana);
            this.Controls.Add(this.txtB_Salasana);
            this.Controls.Add(this.lbl_kayttajatunnus);
            this.Controls.Add(this.txtB_kayttajatunnus);
            this.Controls.Add(this.lbl_mokkivaraus);
            this.Controls.Add(this.lbl_villagepeople);
            this.Controls.Add(this.btn_kirjaudu);
            this.Name = "Kirjautuminen";
            this.Text = "Village People Mökkivarausjärjestelmä";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kirjaudu;
        private System.Windows.Forms.Label lbl_villagepeople;
        private System.Windows.Forms.Label lbl_mokkivaraus;
        private System.Windows.Forms.TextBox txtB_kayttajatunnus;
        private System.Windows.Forms.Label lbl_kayttajatunnus;
        private System.Windows.Forms.Label lbl_salasana;
        private System.Windows.Forms.TextBox txtB_Salasana;
    }
}