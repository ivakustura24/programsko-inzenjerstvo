namespace Provedba_i_sortiranje_transakcija
{
    partial class ProvedbaTransakcije
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
            this.PlatiteljCombo = new System.Windows.Forms.ComboBox();
            this.ProvediiButton = new System.Windows.Forms.Button();
            this.Platitelj = new System.Windows.Forms.Label();
            this.Primatelj = new System.Windows.Forms.Label();
            this.Iznos = new System.Windows.Forms.Label();
            this.PrimateljCombo = new System.Windows.Forms.ComboBox();
            this.IznosTextBox = new System.Windows.Forms.TextBox();
            this.OdustaniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlatiteljCombo
            // 
            this.PlatiteljCombo.FormattingEnabled = true;
            this.PlatiteljCombo.Location = new System.Drawing.Point(124, 48);
            this.PlatiteljCombo.Name = "PlatiteljCombo";
            this.PlatiteljCombo.Size = new System.Drawing.Size(169, 24);
            this.PlatiteljCombo.TabIndex = 0;
            // 
            // ProvediiButton
            // 
            this.ProvediiButton.Location = new System.Drawing.Point(124, 211);
            this.ProvediiButton.Name = "ProvediiButton";
            this.ProvediiButton.Size = new System.Drawing.Size(75, 23);
            this.ProvediiButton.TabIndex = 1;
            this.ProvediiButton.Text = "Provedi";
            this.ProvediiButton.UseVisualStyleBackColor = true;
            this.ProvediiButton.Click += new System.EventHandler(this.ProvediiButton_Click);
            // 
            // Platitelj
            // 
            this.Platitelj.AutoSize = true;
            this.Platitelj.Location = new System.Drawing.Point(37, 56);
            this.Platitelj.Name = "Platitelj";
            this.Platitelj.Size = new System.Drawing.Size(50, 16);
            this.Platitelj.TabIndex = 2;
            this.Platitelj.Text = "Platitelj";
            // 
            // Primatelj
            // 
            this.Primatelj.AutoSize = true;
            this.Primatelj.Location = new System.Drawing.Point(37, 118);
            this.Primatelj.Name = "Primatelj";
            this.Primatelj.Size = new System.Drawing.Size(59, 16);
            this.Primatelj.TabIndex = 3;
            this.Primatelj.Text = "Primatelj";
            // 
            // Iznos
            // 
            this.Iznos.AutoSize = true;
            this.Iznos.Location = new System.Drawing.Point(37, 158);
            this.Iznos.Name = "Iznos";
            this.Iznos.Size = new System.Drawing.Size(38, 16);
            this.Iznos.TabIndex = 4;
            this.Iznos.Text = "Iznos";
            // 
            // PrimateljCombo
            // 
            this.PrimateljCombo.FormattingEnabled = true;
            this.PrimateljCombo.Location = new System.Drawing.Point(124, 110);
            this.PrimateljCombo.Name = "PrimateljCombo";
            this.PrimateljCombo.Size = new System.Drawing.Size(169, 24);
            this.PrimateljCombo.TabIndex = 5;
            // 
            // IznosTextBox
            // 
            this.IznosTextBox.Location = new System.Drawing.Point(124, 155);
            this.IznosTextBox.Name = "IznosTextBox";
            this.IznosTextBox.Size = new System.Drawing.Size(169, 22);
            this.IznosTextBox.TabIndex = 6;
            // 
            // OdustaniButton
            // 
            this.OdustaniButton.Location = new System.Drawing.Point(218, 211);
            this.OdustaniButton.Name = "OdustaniButton";
            this.OdustaniButton.Size = new System.Drawing.Size(75, 23);
            this.OdustaniButton.TabIndex = 7;
            this.OdustaniButton.Text = "Odustani";
            this.OdustaniButton.UseVisualStyleBackColor = true;
            this.OdustaniButton.Click += new System.EventHandler(this.OdustaniButton_Click);
            // 
            // ProvedbaTransakcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 283);
            this.Controls.Add(this.OdustaniButton);
            this.Controls.Add(this.IznosTextBox);
            this.Controls.Add(this.PrimateljCombo);
            this.Controls.Add(this.Iznos);
            this.Controls.Add(this.Primatelj);
            this.Controls.Add(this.Platitelj);
            this.Controls.Add(this.ProvediiButton);
            this.Controls.Add(this.PlatiteljCombo);
            this.Name = "ProvedbaTransakcije";
            this.Text = "Provedba transakcije";
            this.Load += new System.EventHandler(this.ProvedbaTransakcije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PlatiteljCombo;
        private System.Windows.Forms.Button ProvediiButton;
        private System.Windows.Forms.Label Platitelj;
        private System.Windows.Forms.Label Primatelj;
        private System.Windows.Forms.Label Iznos;
        private System.Windows.Forms.ComboBox PrimateljCombo;
        private System.Windows.Forms.TextBox IznosTextBox;
        private System.Windows.Forms.Button OdustaniButton;
    }
}