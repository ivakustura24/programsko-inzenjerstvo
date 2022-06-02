namespace STATE_PrepaidKartica
{
    partial class PrepaidForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerijskiBroj = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAktiviraj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUplati = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIznosUplate = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIsplati = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIznosIsplate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serijski broj:";
            // 
            // txtSerijskiBroj
            // 
            this.txtSerijskiBroj.Enabled = false;
            this.txtSerijskiBroj.Location = new System.Drawing.Point(24, 52);
            this.txtSerijskiBroj.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerijskiBroj.Name = "txtSerijskiBroj";
            this.txtSerijskiBroj.Size = new System.Drawing.Size(209, 22);
            this.txtSerijskiBroj.TabIndex = 1;
            // 
            // txtIznos
            // 
            this.txtIznos.Enabled = false;
            this.txtIznos.Location = new System.Drawing.Point(24, 100);
            this.txtIznos.Margin = new System.Windows.Forms.Padding(4);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(209, 22);
            this.txtIznos.TabIndex = 3;
            this.txtIznos.TextChanged += new System.EventHandler(this.txtIznos_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Iznos:";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(24, 148);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(209, 22);
            this.txtStatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAktiviraj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.txtSerijskiBroj);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIznos);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(265, 230);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci kartice";
            // 
            // btnAktiviraj
            // 
            this.btnAktiviraj.Location = new System.Drawing.Point(76, 180);
            this.btnAktiviraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAktiviraj.Name = "btnAktiviraj";
            this.btnAktiviraj.Size = new System.Drawing.Size(159, 28);
            this.btnAktiviraj.TabIndex = 6;
            this.btnAktiviraj.Text = "Aktiviraj";
            this.btnAktiviraj.UseVisualStyleBackColor = true;
            this.btnAktiviraj.Click += new System.EventHandler(this.btnAktiviraj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUplati);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtIznosUplate);
            this.groupBox2.Location = new System.Drawing.Point(289, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(361, 113);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uplata sredstava na karticu:";
            // 
            // btnUplati
            // 
            this.btnUplati.Location = new System.Drawing.Point(243, 53);
            this.btnUplati.Margin = new System.Windows.Forms.Padding(4);
            this.btnUplati.Name = "btnUplati";
            this.btnUplati.Size = new System.Drawing.Size(100, 28);
            this.btnUplati.TabIndex = 7;
            this.btnUplati.Text = "Uplati";
            this.btnUplati.UseVisualStyleBackColor = true;
            this.btnUplati.Click += new System.EventHandler(this.btnUplati_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Iznos uplate:";
            // 
            // txtIznosUplate
            // 
            this.txtIznosUplate.Location = new System.Drawing.Point(24, 53);
            this.txtIznosUplate.Margin = new System.Windows.Forms.Padding(4);
            this.txtIznosUplate.Name = "txtIznosUplate";
            this.txtIznosUplate.Size = new System.Drawing.Size(209, 22);
            this.txtIznosUplate.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIsplati);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtIznosIsplate);
            this.groupBox3.Location = new System.Drawing.Point(289, 135);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(361, 110);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Isplate sredstava sa kartice:";
            // 
            // btnIsplati
            // 
            this.btnIsplati.Location = new System.Drawing.Point(243, 50);
            this.btnIsplati.Margin = new System.Windows.Forms.Padding(4);
            this.btnIsplati.Name = "btnIsplati";
            this.btnIsplati.Size = new System.Drawing.Size(100, 28);
            this.btnIsplati.TabIndex = 10;
            this.btnIsplati.Text = "Isplati";
            this.btnIsplati.UseVisualStyleBackColor = true;
            this.btnIsplati.Click += new System.EventHandler(this.btnIsplati_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Iznos isplate:";
            // 
            // txtIznosIsplate
            // 
            this.txtIznosIsplate.Location = new System.Drawing.Point(24, 50);
            this.txtIznosIsplate.Margin = new System.Windows.Forms.Padding(4);
            this.txtIznosIsplate.Name = "txtIznosIsplate";
            this.txtIznosIsplate.Size = new System.Drawing.Size(209, 22);
            this.txtIznosIsplate.TabIndex = 9;
            // 
            // PrepaidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 273);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrepaidForm";
            this.Text = "Prepaid kartica";
            this.Load += new System.EventHandler(this.PrepaidForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerijskiBroj;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAktiviraj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIznosUplate;
        private System.Windows.Forms.Button btnUplati;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIsplati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIznosIsplate;
    }
}

