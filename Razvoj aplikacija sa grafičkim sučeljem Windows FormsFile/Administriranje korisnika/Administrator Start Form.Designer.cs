namespace Administriranje_korisnika
{
    partial class Administrator_Start_Form
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
            this.TablicaAdministratoraDataGridView = new System.Windows.Forms.DataGridView();
            this.Users = new System.Windows.Forms.Label();
            this.AktivirajKorisnikaButton = new System.Windows.Forms.Button();
            this.DeaktivirajKorisnikaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablicaAdministratoraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TablicaAdministratoraDataGridView
            // 
            this.TablicaAdministratoraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablicaAdministratoraDataGridView.Location = new System.Drawing.Point(53, 59);
            this.TablicaAdministratoraDataGridView.Name = "TablicaAdministratoraDataGridView";
            this.TablicaAdministratoraDataGridView.RowHeadersWidth = 51;
            this.TablicaAdministratoraDataGridView.RowTemplate.Height = 24;
            this.TablicaAdministratoraDataGridView.Size = new System.Drawing.Size(853, 302);
            this.TablicaAdministratoraDataGridView.TabIndex = 0;
            this.TablicaAdministratoraDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablicaAdministratoraDataGridView_CellContentClick);
            this.TablicaAdministratoraDataGridView.SelectionChanged += new System.EventHandler(this.TablicaAdministratoraDataGridView_SelectionChanged);
            // 
            // Users
            // 
            this.Users.AutoSize = true;
            this.Users.Location = new System.Drawing.Point(54, 23);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(46, 16);
            this.Users.TabIndex = 1;
            this.Users.Text = "Users:";
            // 
            // AktivirajKorisnikaButton
            // 
            this.AktivirajKorisnikaButton.Location = new System.Drawing.Point(618, 392);
            this.AktivirajKorisnikaButton.Name = "AktivirajKorisnikaButton";
            this.AktivirajKorisnikaButton.Size = new System.Drawing.Size(139, 40);
            this.AktivirajKorisnikaButton.TabIndex = 2;
            this.AktivirajKorisnikaButton.Text = "Activate User";
            this.AktivirajKorisnikaButton.UseVisualStyleBackColor = true;
            this.AktivirajKorisnikaButton.Click += new System.EventHandler(this.AktivirajKorisnikaButton_Click);
            // 
            // DeaktivirajKorisnikaButton
            // 
            this.DeaktivirajKorisnikaButton.Location = new System.Drawing.Point(763, 392);
            this.DeaktivirajKorisnikaButton.Name = "DeaktivirajKorisnikaButton";
            this.DeaktivirajKorisnikaButton.Size = new System.Drawing.Size(143, 40);
            this.DeaktivirajKorisnikaButton.TabIndex = 3;
            this.DeaktivirajKorisnikaButton.Text = "Deactivate User";
            this.DeaktivirajKorisnikaButton.UseVisualStyleBackColor = true;
            this.DeaktivirajKorisnikaButton.Click += new System.EventHandler(this.DeaktivirajKorisnikaButton_Click);
            // 
            // Administrator_Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 525);
            this.Controls.Add(this.DeaktivirajKorisnikaButton);
            this.Controls.Add(this.AktivirajKorisnikaButton);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.TablicaAdministratoraDataGridView);
            this.Name = "Administrator_Start_Form";
            this.Text = "Administrator_Start_Form";
            ((System.ComponentModel.ISupportInitialize)(this.TablicaAdministratoraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablicaAdministratoraDataGridView;
        private System.Windows.Forms.Label Users;
        private System.Windows.Forms.Button AktivirajKorisnikaButton;
        private System.Windows.Forms.Button DeaktivirajKorisnikaButton;
    }
}