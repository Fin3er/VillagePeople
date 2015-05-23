namespace Mokkivarausjarjestelma
{
    partial class Mokinhallinta
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
            this.btnTallennaMokkiTiedot = new System.Windows.Forms.Button();
            this.btnPoistaMokki = new System.Windows.Forms.Button();
            this.btnLisaaUusiMokki = new System.Windows.Forms.Button();
            this.dgvMokit = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTallennaMokkiTiedot
            // 
            this.btnTallennaMokkiTiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTallennaMokkiTiedot.Location = new System.Drawing.Point(244, 243);
            this.btnTallennaMokkiTiedot.Margin = new System.Windows.Forms.Padding(4);
            this.btnTallennaMokkiTiedot.Name = "btnTallennaMokkiTiedot";
            this.btnTallennaMokkiTiedot.Size = new System.Drawing.Size(79, 23);
            this.btnTallennaMokkiTiedot.TabIndex = 58;
            this.btnTallennaMokkiTiedot.Text = "MUOKKAA";
            this.btnTallennaMokkiTiedot.UseVisualStyleBackColor = true;
            this.btnTallennaMokkiTiedot.Click += new System.EventHandler(this.btnTallennaMokkiTiedot_Click);
            // 
            // btnPoistaMokki
            // 
            this.btnPoistaMokki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPoistaMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaMokki.Location = new System.Drawing.Point(41, 577);
            this.btnPoistaMokki.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoistaMokki.Name = "btnPoistaMokki";
            this.btnPoistaMokki.Size = new System.Drawing.Size(200, 46);
            this.btnPoistaMokki.TabIndex = 57;
            this.btnPoistaMokki.Text = "Poista mokki";
            this.btnPoistaMokki.UseVisualStyleBackColor = false;
            // 
            // btnLisaaUusiMokki
            // 
            this.btnLisaaUusiMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaaUusiMokki.Location = new System.Drawing.Point(136, 243);
            this.btnLisaaUusiMokki.Margin = new System.Windows.Forms.Padding(4);
            this.btnLisaaUusiMokki.Name = "btnLisaaUusiMokki";
            this.btnLisaaUusiMokki.Size = new System.Drawing.Size(79, 23);
            this.btnLisaaUusiMokki.TabIndex = 56;
            this.btnLisaaUusiMokki.Text = "LISÄÄ";
            this.btnLisaaUusiMokki.UseVisualStyleBackColor = true;
            this.btnLisaaUusiMokki.Click += new System.EventHandler(this.btnLisaaUusiMokki_Click);
            // 
            // dgvMokit
            // 
            this.dgvMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokit.Location = new System.Drawing.Point(42, 75);
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.Size = new System.Drawing.Size(473, 150);
            this.dgvMokit.TabIndex = 59;
            this.dgvMokit.SelectionChanged += new System.EventHandler(this.dgvMokit_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "POISTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mokinhallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvMokit);
            this.Controls.Add(this.btnTallennaMokkiTiedot);
            this.Controls.Add(this.btnPoistaMokki);
            this.Controls.Add(this.btnLisaaUusiMokki);
            this.Name = "Mokinhallinta";
            this.Size = new System.Drawing.Size(1184, 761);
            this.Load += new System.EventHandler(this.Mokinhallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTallennaMokkiTiedot;
        private System.Windows.Forms.Button btnPoistaMokki;
        private System.Windows.Forms.Button btnLisaaUusiMokki;
        private System.Windows.Forms.DataGridView dgvMokit;
        private System.Windows.Forms.Button button1;
    }
}