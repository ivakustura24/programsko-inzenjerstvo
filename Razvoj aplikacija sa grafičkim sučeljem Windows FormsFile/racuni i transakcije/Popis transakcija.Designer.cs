namespace Računi_i_transakcije
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TransakcijeDGW = new System.Windows.Forms.DataGridView();
            this.PrimjeniButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SveRadio = new System.Windows.Forms.RadioButton();
            this.IsplateRadio = new System.Windows.Forms.RadioButton();
            this.UplateRadio = new System.Windows.Forms.RadioButton();
            this.IBANTextBox = new System.Windows.Forms.TextBox();
            this.StanjeTextBox = new System.Windows.Forms.TextBox();
            this.VlasnikTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransakcijeDGW)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VlasnikTextBox);
            this.groupBox1.Controls.Add(this.StanjeTextBox);
            this.groupBox1.Controls.Add(this.IBANTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o računu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "IBAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stanje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vlasnik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Transakcije";
            // 
            // TransakcijeDGW
            // 
            this.TransakcijeDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransakcijeDGW.Location = new System.Drawing.Point(40, 210);
            this.TransakcijeDGW.Name = "TransakcijeDGW";
            this.TransakcijeDGW.RowHeadersWidth = 51;
            this.TransakcijeDGW.RowTemplate.Height = 24;
            this.TransakcijeDGW.Size = new System.Drawing.Size(631, 144);
            this.TransakcijeDGW.TabIndex = 2;
            // 
            // PrimjeniButton
            // 
            this.PrimjeniButton.Location = new System.Drawing.Point(596, 397);
            this.PrimjeniButton.Name = "PrimjeniButton";
            this.PrimjeniButton.Size = new System.Drawing.Size(75, 23);
            this.PrimjeniButton.TabIndex = 3;
            this.PrimjeniButton.Text = "Primjeni";
            this.PrimjeniButton.UseVisualStyleBackColor = true;
            this.PrimjeniButton.Click += new System.EventHandler(this.PrimjeniButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UplateRadio);
            this.groupBox2.Controls.Add(this.IsplateRadio);
            this.groupBox2.Controls.Add(this.SveRadio);
            this.groupBox2.Location = new System.Drawing.Point(32, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 86);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter prikaza";
            // 
            // SveRadio
            // 
            this.SveRadio.AutoSize = true;
            this.SveRadio.Location = new System.Drawing.Point(30, 40);
            this.SveRadio.Name = "SveRadio";
            this.SveRadio.Size = new System.Drawing.Size(93, 20);
            this.SveRadio.TabIndex = 0;
            this.SveRadio.TabStop = true;
            this.SveRadio.Text = "Prikaži sve";
            this.SveRadio.UseVisualStyleBackColor = true;
            // 
            // IsplateRadio
            // 
            this.IsplateRadio.AutoSize = true;
            this.IsplateRadio.Location = new System.Drawing.Point(199, 40);
            this.IsplateRadio.Name = "IsplateRadio";
            this.IsplateRadio.Size = new System.Drawing.Size(111, 20);
            this.IsplateRadio.TabIndex = 1;
            this.IsplateRadio.TabStop = true;
            this.IsplateRadio.Text = "Prikaži isplate";
            this.IsplateRadio.UseVisualStyleBackColor = true;
            // 
            // UplateRadio
            // 
            this.UplateRadio.AutoSize = true;
            this.UplateRadio.Location = new System.Drawing.Point(380, 40);
            this.UplateRadio.Name = "UplateRadio";
            this.UplateRadio.Size = new System.Drawing.Size(108, 20);
            this.UplateRadio.TabIndex = 5;
            this.UplateRadio.TabStop = true;
            this.UplateRadio.Text = "Prikaži uplate";
            this.UplateRadio.UseVisualStyleBackColor = true;
            // 
            // IBANTextBox
            // 
            this.IBANTextBox.Location = new System.Drawing.Point(115, 34);
            this.IBANTextBox.Name = "IBANTextBox";
            this.IBANTextBox.Size = new System.Drawing.Size(182, 22);
            this.IBANTextBox.TabIndex = 4;
            // 
            // StanjeTextBox
            // 
            this.StanjeTextBox.Location = new System.Drawing.Point(115, 73);
            this.StanjeTextBox.Name = "StanjeTextBox";
            this.StanjeTextBox.Size = new System.Drawing.Size(182, 22);
            this.StanjeTextBox.TabIndex = 5;
            // 
            // VlasnikTextBox
            // 
            this.VlasnikTextBox.Location = new System.Drawing.Point(115, 109);
            this.VlasnikTextBox.Name = "VlasnikTextBox";
            this.VlasnikTextBox.Size = new System.Drawing.Size(182, 22);
            this.VlasnikTextBox.TabIndex = 6;
            // 
            // PopisTransakcijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 482);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PrimjeniButton);
            this.Controls.Add(this.TransakcijeDGW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "PopisTransakcijaForm";
            this.Text = "Popis transakcija";
            this.Load += new System.EventHandler(this.PopisTransakcijaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransakcijeDGW)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView TransakcijeDGW;
        private System.Windows.Forms.TextBox VlasnikTextBox;
        private System.Windows.Forms.TextBox StanjeTextBox;
        private System.Windows.Forms.TextBox IBANTextBox;
        private System.Windows.Forms.Button PrimjeniButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton UplateRadio;
        private System.Windows.Forms.RadioButton IsplateRadio;
        private System.Windows.Forms.RadioButton SveRadio;
    }
}