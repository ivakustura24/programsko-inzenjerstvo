namespace Prijava_i_prikaz_korisnickog_profila
{
    partial class UserprofileForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LastnameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.FirstnameTB = new System.Windows.Forms.TextBox();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GuestRadio = new System.Windows.Forms.RadioButton();
            this.AdminRadio = new System.Windows.Forms.RadioButton();
            this.EmployeeRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // LastnameTB
            // 
            this.LastnameTB.Location = new System.Drawing.Point(163, 80);
            this.LastnameTB.Name = "LastnameTB";
            this.LastnameTB.Size = new System.Drawing.Size(185, 22);
            this.LastnameTB.TabIndex = 4;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(163, 166);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(185, 22);
            this.PasswordTB.TabIndex = 5;
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(163, 126);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(185, 22);
            this.UsernameTB.TabIndex = 6;
            // 
            // FirstnameTB
            // 
            this.FirstnameTB.Location = new System.Drawing.Point(163, 37);
            this.FirstnameTB.Name = "FirstnameTB";
            this.FirstnameTB.Size = new System.Drawing.Size(185, 22);
            this.FirstnameTB.TabIndex = 7;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(264, 341);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(84, 35);
            this.LogOutButton.TabIndex = 8;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GuestRadio);
            this.groupBox1.Controls.Add(this.EmployeeRadio);
            this.groupBox1.Controls.Add(this.AdminRadio);
            this.groupBox1.Location = new System.Drawing.Point(167, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 110);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User type";
            // 
            // GuestRadio
            // 
            this.GuestRadio.AutoSize = true;
            this.GuestRadio.Location = new System.Drawing.Point(18, 56);
            this.GuestRadio.Name = "GuestRadio";
            this.GuestRadio.Size = new System.Drawing.Size(63, 20);
            this.GuestRadio.TabIndex = 10;
            this.GuestRadio.TabStop = true;
            this.GuestRadio.Text = "Guest";
            this.GuestRadio.UseVisualStyleBackColor = true;
            // 
            // AdminRadio
            // 
            this.AdminRadio.AutoSize = true;
            this.AdminRadio.Location = new System.Drawing.Point(18, 30);
            this.AdminRadio.Name = "AdminRadio";
            this.AdminRadio.Size = new System.Drawing.Size(106, 20);
            this.AdminRadio.TabIndex = 11;
            this.AdminRadio.TabStop = true;
            this.AdminRadio.Text = "Administrator";
            this.AdminRadio.UseVisualStyleBackColor = true;
            // 
            // EmployeeRadio
            // 
            this.EmployeeRadio.AutoSize = true;
            this.EmployeeRadio.Location = new System.Drawing.Point(18, 82);
            this.EmployeeRadio.Name = "EmployeeRadio";
            this.EmployeeRadio.Size = new System.Drawing.Size(90, 20);
            this.EmployeeRadio.TabIndex = 12;
            this.EmployeeRadio.TabStop = true;
            this.EmployeeRadio.Text = "Employee";
            this.EmployeeRadio.UseVisualStyleBackColor = true;
            // 
            // UserprofileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.FirstnameTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LastnameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserprofileForm";
            this.Text = "User profile";
            this.Load += new System.EventHandler(this.UserprofileForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastnameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox FirstnameTB;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton GuestRadio;
        private System.Windows.Forms.RadioButton EmployeeRadio;
        private System.Windows.Forms.RadioButton AdminRadio;
    }
}