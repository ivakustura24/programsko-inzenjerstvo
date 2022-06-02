namespace Inventura2
{
    partial class FrmInventura
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
            this.dgvInventurniZapisi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArtikl = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtStvarnaKolicina = new System.Windows.Forms.TextBox();
            this.txtZaduzen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventurniZapisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventurniZapisi
            // 
            this.dgvInventurniZapisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventurniZapisi.Location = new System.Drawing.Point(12, 34);
            this.dgvInventurniZapisi.Name = "dgvInventurniZapisi";
            this.dgvInventurniZapisi.Size = new System.Drawing.Size(694, 239);
            this.dgvInventurniZapisi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zapisi s inventure:";
            // 
            // txtArtikl
            // 
            this.txtArtikl.Location = new System.Drawing.Point(713, 50);
            this.txtArtikl.Margin = new System.Windows.Forms.Padding(2);
            this.txtArtikl.Name = "txtArtikl";
            this.txtArtikl.Size = new System.Drawing.Size(114, 20);
            this.txtArtikl.TabIndex = 6;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(713, 91);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(2);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(114, 20);
            this.txtKolicina.TabIndex = 7;
            // 
            // txtStvarnaKolicina
            // 
            this.txtStvarnaKolicina.Location = new System.Drawing.Point(714, 130);
            this.txtStvarnaKolicina.Margin = new System.Windows.Forms.Padding(2);
            this.txtStvarnaKolicina.Name = "txtStvarnaKolicina";
            this.txtStvarnaKolicina.Size = new System.Drawing.Size(113, 20);
            this.txtStvarnaKolicina.TabIndex = 8;
            // 
            // txtZaduzen
            // 
            this.txtZaduzen.Location = new System.Drawing.Point(714, 171);
            this.txtZaduzen.Margin = new System.Windows.Forms.Padding(2);
            this.txtZaduzen.Name = "txtZaduzen";
            this.txtZaduzen.Size = new System.Drawing.Size(113, 20);
            this.txtZaduzen.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Artikl:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(713, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Količina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(712, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stvarna količina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(714, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Zadužen:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(712, 196);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(115, 23);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Filter (zadužena osoba):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(443, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 20;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(562, 5);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(69, 23);
            this.btnFiltriraj.TabIndex = 22;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Location = new System.Drawing.Point(637, 5);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(69, 23);
            this.btnPrikaziSve.TabIndex = 23;
            this.btnPrikaziSve.Text = "Prikaži sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = true;
            this.btnPrikaziSve.Click += new System.EventHandler(this.btnPrikaziSve_Click);
            // 
            // FrmInventura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 287);
            this.Controls.Add(this.btnPrikaziSve);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtZaduzen);
            this.Controls.Add(this.txtStvarnaKolicina);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtArtikl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInventurniZapisi);
            this.Name = "FrmInventura";
            this.Text = "Inventura";
            this.Load += new System.EventHandler(this.FrmInventura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventurniZapisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventurniZapisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArtikl;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtStvarnaKolicina;
        private System.Windows.Forms.TextBox txtZaduzen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnPrikaziSve;
    }
}

