namespace Rjecnici
{
    partial class Prevoditelj
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
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonRecenica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(49, 74);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(121, 53);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj riječi u riječnik";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonRecenica
            // 
            this.buttonRecenica.Location = new System.Drawing.Point(236, 74);
            this.buttonRecenica.Name = "buttonRecenica";
            this.buttonRecenica.Size = new System.Drawing.Size(121, 53);
            this.buttonRecenica.TabIndex = 1;
            this.buttonRecenica.Text = "Prijevod rečenica";
            this.buttonRecenica.UseVisualStyleBackColor = true;
            this.buttonRecenica.Click += new System.EventHandler(this.buttonRecenica_Click);
            // 
            // Prevoditelj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 201);
            this.Controls.Add(this.buttonRecenica);
            this.Controls.Add(this.buttonDodaj);
            this.Name = "Prevoditelj";
            this.Text = "Prevoditelj";
            this.Load += new System.EventHandler(this.Prevoditelj_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonRecenica;
    }
}

