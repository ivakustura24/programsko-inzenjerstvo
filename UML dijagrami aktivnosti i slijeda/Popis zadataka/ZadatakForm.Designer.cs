namespace _09_Popis_zadataka
{
    partial class btnDodaj
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgwZadatci = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpKrajnjiRok = new System.Windows.Forms.DateTimePicker();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZadatci)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj zadatak";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgwZadatci
            // 
            this.dgwZadatci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwZadatci.Location = new System.Drawing.Point(12, 28);
            this.dgwZadatci.Name = "dgwZadatci";
            this.dgwZadatci.RowHeadersWidth = 51;
            this.dgwZadatci.RowTemplate.Height = 24;
            this.dgwZadatci.Size = new System.Drawing.Size(365, 268);
            this.dgwZadatci.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Krajnji rok";
            // 
            // dtpKrajnjiRok
            // 
            this.dtpKrajnjiRok.Location = new System.Drawing.Point(177, 354);
            this.dtpKrajnjiRok.Name = "dtpKrajnjiRok";
            this.dtpKrajnjiRok.Size = new System.Drawing.Size(200, 22);
            this.dtpKrajnjiRok.TabIndex = 4;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(177, 321);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(200, 22);
            this.tbNaziv.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.dtpKrajnjiRok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwZadatci);
            this.Controls.Add(this.button1);
            this.Name = "btnDodaj";
            this.Text = "Zadatci";
            this.Load += new System.EventHandler(this.btnDodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwZadatci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgwZadatci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpKrajnjiRok;
        private System.Windows.Forms.TextBox tbNaziv;
    }
}

