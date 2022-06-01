namespace Autobusni_kolodvor_2
{
    partial class KupiKartu
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IspisiButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PovratnaCheckBox = new System.Windows.Forms.CheckBox();
            this.PrtljagaCheckBox = new System.Windows.Forms.CheckBox();
            this.IspisTextBox = new System.Windows.Forms.RichTextBox();
            this.VrstaKarteComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VrstaKarteComboBox);
            this.groupBox1.Controls.Add(this.PrtljagaCheckBox);
            this.groupBox1.Controls.Add(this.PovratnaCheckBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcije karte";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IspisTextBox);
            this.groupBox2.Location = new System.Drawing.Point(28, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ispis karte";
            // 
            // IspisiButton
            // 
            this.IspisiButton.Location = new System.Drawing.Point(384, 244);
            this.IspisiButton.Name = "IspisiButton";
            this.IspisiButton.Size = new System.Drawing.Size(120, 23);
            this.IspisiButton.TabIndex = 2;
            this.IspisiButton.Text = "Ispiši kartu";
            this.IspisiButton.UseVisualStyleBackColor = true;
            this.IspisiButton.Click += new System.EventHandler(this.IspisiButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta karte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dodatno";
            // 
            // PovratnaCheckBox
            // 
            this.PovratnaCheckBox.AutoSize = true;
            this.PovratnaCheckBox.Location = new System.Drawing.Point(204, 112);
            this.PovratnaCheckBox.Name = "PovratnaCheckBox";
            this.PovratnaCheckBox.Size = new System.Drawing.Size(116, 20);
            this.PovratnaCheckBox.TabIndex = 3;
            this.PovratnaCheckBox.Text = "Povratna karta";
            this.PovratnaCheckBox.UseVisualStyleBackColor = true;
            // 
            // PrtljagaCheckBox
            // 
            this.PrtljagaCheckBox.AutoSize = true;
            this.PrtljagaCheckBox.Location = new System.Drawing.Point(204, 162);
            this.PrtljagaCheckBox.Name = "PrtljagaCheckBox";
            this.PrtljagaCheckBox.Size = new System.Drawing.Size(75, 20);
            this.PrtljagaCheckBox.TabIndex = 4;
            this.PrtljagaCheckBox.Text = "Prtljaga";
            this.PrtljagaCheckBox.UseVisualStyleBackColor = true;
            // 
            // IspisTextBox
            // 
            this.IspisTextBox.Location = new System.Drawing.Point(28, 21);
            this.IspisTextBox.Name = "IspisTextBox";
            this.IspisTextBox.Size = new System.Drawing.Size(431, 195);
            this.IspisTextBox.TabIndex = 0;
            this.IspisTextBox.Text = "";
            // 
            // VrstaKarteComboBox
            // 
            this.VrstaKarteComboBox.FormattingEnabled = true;
            this.VrstaKarteComboBox.Location = new System.Drawing.Point(199, 48);
            this.VrstaKarteComboBox.Name = "VrstaKarteComboBox";
            this.VrstaKarteComboBox.Size = new System.Drawing.Size(121, 24);
            this.VrstaKarteComboBox.TabIndex = 5;
            // 
            // KupiKartu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 537);
            this.Controls.Add(this.IspisiButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KupiKartu";
            this.Text = "KupiKartu";
            this.Load += new System.EventHandler(this.KupiKartu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox PrtljagaCheckBox;
        private System.Windows.Forms.CheckBox PovratnaCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox IspisTextBox;
        private System.Windows.Forms.Button IspisiButton;
        private System.Windows.Forms.ComboBox VrstaKarteComboBox;
    }
}