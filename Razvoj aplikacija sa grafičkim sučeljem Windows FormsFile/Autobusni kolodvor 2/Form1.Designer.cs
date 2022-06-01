namespace Autobusni_kolodvor_2
{
    partial class AutobusneLinijeForm
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
            this.PopisLinijaDataGridView = new System.Windows.Forms.DataGridView();
            this.PronadiButton = new System.Windows.Forms.Button();
            this.KupiKartuButton = new System.Windows.Forms.Button();
            this.PronadiTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PopisLinijaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odredište";
            // 
            // PopisLinijaDataGridView
            // 
            this.PopisLinijaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopisLinijaDataGridView.Location = new System.Drawing.Point(32, 65);
            this.PopisLinijaDataGridView.Name = "PopisLinijaDataGridView";
            this.PopisLinijaDataGridView.RowHeadersWidth = 51;
            this.PopisLinijaDataGridView.RowTemplate.Height = 24;
            this.PopisLinijaDataGridView.Size = new System.Drawing.Size(737, 307);
            this.PopisLinijaDataGridView.TabIndex = 1;
            this.PopisLinijaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PronadiButton
            // 
            this.PronadiButton.Location = new System.Drawing.Point(442, 25);
            this.PronadiButton.Name = "PronadiButton";
            this.PronadiButton.Size = new System.Drawing.Size(95, 23);
            this.PronadiButton.TabIndex = 2;
            this.PronadiButton.Text = "Pronađi";
            this.PronadiButton.UseVisualStyleBackColor = true;
            this.PronadiButton.Click += new System.EventHandler(this.PronadiButton_Click);
            // 
            // KupiKartuButton
            // 
            this.KupiKartuButton.Location = new System.Drawing.Point(665, 389);
            this.KupiKartuButton.Name = "KupiKartuButton";
            this.KupiKartuButton.Size = new System.Drawing.Size(104, 23);
            this.KupiKartuButton.TabIndex = 3;
            this.KupiKartuButton.Text = "Kupi kartu";
            this.KupiKartuButton.UseVisualStyleBackColor = true;
            this.KupiKartuButton.Click += new System.EventHandler(this.KupiKartuButton_Click);
            // 
            // PronadiTextBox
            // 
            this.PronadiTextBox.Location = new System.Drawing.Point(139, 26);
            this.PronadiTextBox.Name = "PronadiTextBox";
            this.PronadiTextBox.Size = new System.Drawing.Size(274, 22);
            this.PronadiTextBox.TabIndex = 4;
            // 
            // AutobusneLinijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PronadiTextBox);
            this.Controls.Add(this.KupiKartuButton);
            this.Controls.Add(this.PronadiButton);
            this.Controls.Add(this.PopisLinijaDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "AutobusneLinijeForm";
            this.Text = "Autobusne linije";
            ((System.ComponentModel.ISupportInitialize)(this.PopisLinijaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PopisLinijaDataGridView;
        private System.Windows.Forms.Button PronadiButton;
        private System.Windows.Forms.Button KupiKartuButton;
        private System.Windows.Forms.TextBox PronadiTextBox;
    }
}

