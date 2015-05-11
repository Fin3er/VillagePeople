namespace Mokkivarausjarjestelma
{
    partial class Varaustenhallinta
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUusiVaraus = new System.Windows.Forms.Button();
            this.btnPoistaVaraus = new System.Windows.Forms.Button();
            this.btnMuokkaaVaraus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1217, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnUusiVaraus
            // 
            this.btnUusiVaraus.Location = new System.Drawing.Point(1, 242);
            this.btnUusiVaraus.Name = "btnUusiVaraus";
            this.btnUusiVaraus.Size = new System.Drawing.Size(129, 40);
            this.btnUusiVaraus.TabIndex = 1;
            this.btnUusiVaraus.Text = "Uusi varaus";
            this.btnUusiVaraus.UseVisualStyleBackColor = true;
            this.btnUusiVaraus.Click += new System.EventHandler(this.btnUusiVaraus_Click);
            // 
            // btnPoistaVaraus
            // 
            this.btnPoistaVaraus.Location = new System.Drawing.Point(302, 245);
            this.btnPoistaVaraus.Name = "btnPoistaVaraus";
            this.btnPoistaVaraus.Size = new System.Drawing.Size(129, 37);
            this.btnPoistaVaraus.TabIndex = 2;
            this.btnPoistaVaraus.Text = "Poista varaus";
            this.btnPoistaVaraus.UseVisualStyleBackColor = true;
            // 
            // btnMuokkaaVaraus
            // 
            this.btnMuokkaaVaraus.Location = new System.Drawing.Point(146, 246);
            this.btnMuokkaaVaraus.Name = "btnMuokkaaVaraus";
            this.btnMuokkaaVaraus.Size = new System.Drawing.Size(129, 36);
            this.btnMuokkaaVaraus.TabIndex = 3;
            this.btnMuokkaaVaraus.Text = "Muokkaa varausta";
            this.btnMuokkaaVaraus.UseVisualStyleBackColor = true;
            // 
            // Varaustenhallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 514);
            this.Controls.Add(this.btnMuokkaaVaraus);
            this.Controls.Add(this.btnPoistaVaraus);
            this.Controls.Add(this.btnUusiVaraus);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Varaustenhallinta";
            this.Text = "Varaustenhallinta";
            this.Load += new System.EventHandler(this.Varaustenhallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUusiVaraus;
        private System.Windows.Forms.Button btnPoistaVaraus;
        private System.Windows.Forms.Button btnMuokkaaVaraus;
    }
}