namespace Filtirranje_transakcija
{
    partial class PopisTransakcijaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RacunComboBox = new System.Windows.Forms.ComboBox();
            this.UplateRadio = new System.Windows.Forms.RadioButton();
            this.IsplataRadio = new System.Windows.Forms.RadioButton();
            this.SveRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OcistiButton = new System.Windows.Forms.Button();
            this.FiltrirajButton = new System.Windows.Forms.Button();
            this.TransakcijeDataGridView = new System.Windows.Forms.DataGridView();
            this.DetaljiButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransakcijeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RacunComboBox);
            this.groupBox1.Controls.Add(this.UplateRadio);
            this.groupBox1.Controls.Add(this.IsplataRadio);
            this.groupBox1.Controls.Add(this.SveRadio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // RacunComboBox
            // 
            this.RacunComboBox.FormattingEnabled = true;
            this.RacunComboBox.Location = new System.Drawing.Point(142, 41);
            this.RacunComboBox.Name = "RacunComboBox";
            this.RacunComboBox.Size = new System.Drawing.Size(221, 24);
            this.RacunComboBox.TabIndex = 5;
            // 
            // UplateRadio
            // 
            this.UplateRadio.AutoSize = true;
            this.UplateRadio.Location = new System.Drawing.Point(295, 99);
            this.UplateRadio.Name = "UplateRadio";
            this.UplateRadio.Size = new System.Drawing.Size(68, 20);
            this.UplateRadio.TabIndex = 4;
            this.UplateRadio.TabStop = true;
            this.UplateRadio.Text = "Uplate";
            this.UplateRadio.UseVisualStyleBackColor = true;
            // 
            // IsplataRadio
            // 
            this.IsplataRadio.AutoSize = true;
            this.IsplataRadio.Location = new System.Drawing.Point(209, 99);
            this.IsplataRadio.Name = "IsplataRadio";
            this.IsplataRadio.Size = new System.Drawing.Size(68, 20);
            this.IsplataRadio.TabIndex = 3;
            this.IsplataRadio.TabStop = true;
            this.IsplataRadio.Text = "Isplate";
            this.IsplataRadio.UseVisualStyleBackColor = true;
            // 
            // SveRadio
            // 
            this.SveRadio.AutoSize = true;
            this.SveRadio.Location = new System.Drawing.Point(142, 99);
            this.SveRadio.Name = "SveRadio";
            this.SveRadio.Size = new System.Drawing.Size(52, 20);
            this.SveRadio.TabIndex = 2;
            this.SveRadio.TabStop = true;
            this.SveRadio.Text = "Sve";
            this.SveRadio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip transakcije:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Račun:";
            // 
            // OcistiButton
            // 
            this.OcistiButton.Location = new System.Drawing.Point(527, 59);
            this.OcistiButton.Name = "OcistiButton";
            this.OcistiButton.Size = new System.Drawing.Size(116, 49);
            this.OcistiButton.TabIndex = 1;
            this.OcistiButton.Text = "Očisti";
            this.OcistiButton.UseVisualStyleBackColor = true;
            this.OcistiButton.Click += new System.EventHandler(this.OcistiButton_Click);
            // 
            // FiltrirajButton
            // 
            this.FiltrirajButton.Location = new System.Drawing.Point(527, 130);
            this.FiltrirajButton.Name = "FiltrirajButton";
            this.FiltrirajButton.Size = new System.Drawing.Size(116, 52);
            this.FiltrirajButton.TabIndex = 2;
            this.FiltrirajButton.Text = "Filtiraj";
            this.FiltrirajButton.UseVisualStyleBackColor = true;
            this.FiltrirajButton.Click += new System.EventHandler(this.FiltrirajButton_Click);
            // 
            // TransakcijeDataGridView
            // 
            this.TransakcijeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransakcijeDataGridView.Location = new System.Drawing.Point(44, 224);
            this.TransakcijeDataGridView.Name = "TransakcijeDataGridView";
            this.TransakcijeDataGridView.RowHeadersWidth = 51;
            this.TransakcijeDataGridView.RowTemplate.Height = 24;
            this.TransakcijeDataGridView.Size = new System.Drawing.Size(599, 150);
            this.TransakcijeDataGridView.TabIndex = 6;
            // 
            // DetaljiButton
            // 
            this.DetaljiButton.Location = new System.Drawing.Point(527, 397);
            this.DetaljiButton.Name = "DetaljiButton";
            this.DetaljiButton.Size = new System.Drawing.Size(116, 49);
            this.DetaljiButton.TabIndex = 7;
            this.DetaljiButton.Text = "Detalji računa";
            this.DetaljiButton.UseVisualStyleBackColor = true;
            this.DetaljiButton.Click += new System.EventHandler(this.DetaljiButton_Click);
            // 
            // PopisTransakcijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 467);
            this.Controls.Add(this.DetaljiButton);
            this.Controls.Add(this.TransakcijeDataGridView);
            this.Controls.Add(this.FiltrirajButton);
            this.Controls.Add(this.OcistiButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "PopisTransakcijaForm";
            this.Text = "PopisTransakcija";
            this.Load += new System.EventHandler(this.PopisTransakcijaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransakcijeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox RacunComboBox;
        private System.Windows.Forms.RadioButton UplateRadio;
        private System.Windows.Forms.RadioButton IsplataRadio;
        private System.Windows.Forms.RadioButton SveRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OcistiButton;
        private System.Windows.Forms.Button FiltrirajButton;
        private System.Windows.Forms.DataGridView TransakcijeDataGridView;
        private System.Windows.Forms.Button DetaljiButton;
    }
}

