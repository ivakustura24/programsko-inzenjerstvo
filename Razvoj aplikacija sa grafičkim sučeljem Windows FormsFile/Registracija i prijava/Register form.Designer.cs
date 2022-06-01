namespace Registracija_i_prijava
{
    partial class RegisterForm
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
            this.FirstnameTB = new System.Windows.Forms.TextBox();
            this.LastnameTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmployeeRadio = new System.Windows.Forms.RadioButton();
            this.GuestRadio = new System.Windows.Forms.RadioButton();
            this.AdministratorRadio = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // FirstnameTB
            // 
            this.FirstnameTB.Location = new System.Drawing.Point(164, 49);
            this.FirstnameTB.Name = "FirstnameTB";
            this.FirstnameTB.Size = new System.Drawing.Size(231, 22);
            this.FirstnameTB.TabIndex = 4;
            // 
            // LastnameTB
            // 
            this.LastnameTB.Location = new System.Drawing.Point(164, 112);
            this.LastnameTB.Name = "LastnameTB";
            this.LastnameTB.Size = new System.Drawing.Size(231, 22);
            this.LastnameTB.TabIndex = 5;
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(164, 173);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(231, 22);
            this.UsernameTB.TabIndex = 6;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(164, 237);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(231, 22);
            this.PasswordTB.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AdministratorRadio);
            this.groupBox1.Controls.Add(this.GuestRadio);
            this.groupBox1.Controls.Add(this.EmployeeRadio);
            this.groupBox1.Location = new System.Drawing.Point(164, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 114);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User type";
            // 
            // EmployeeRadio
            // 
            this.EmployeeRadio.AutoSize = true;
            this.EmployeeRadio.Location = new System.Drawing.Point(34, 31);
            this.EmployeeRadio.Name = "EmployeeRadio";
            this.EmployeeRadio.Size = new System.Drawing.Size(90, 20);
            this.EmployeeRadio.TabIndex = 0;
            this.EmployeeRadio.TabStop = true;
            this.EmployeeRadio.Text = "Employee";
            this.EmployeeRadio.UseVisualStyleBackColor = true;
            // 
            // GuestRadio
            // 
            this.GuestRadio.AutoSize = true;
            this.GuestRadio.Location = new System.Drawing.Point(34, 57);
            this.GuestRadio.Name = "GuestRadio";
            this.GuestRadio.Size = new System.Drawing.Size(63, 20);
            this.GuestRadio.TabIndex = 1;
            this.GuestRadio.TabStop = true;
            this.GuestRadio.Text = "Guest";
            this.GuestRadio.UseVisualStyleBackColor = true;
            // 
            // AdministratorRadio
            // 
            this.AdministratorRadio.AutoSize = true;
            this.AdministratorRadio.Location = new System.Drawing.Point(34, 83);
            this.AdministratorRadio.Name = "AdministratorRadio";
            this.AdministratorRadio.Size = new System.Drawing.Size(106, 20);
            this.AdministratorRadio.TabIndex = 2;
            this.AdministratorRadio.TabStop = true;
            this.AdministratorRadio.Text = "Administrator";
            this.AdministratorRadio.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(183, 399);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 38);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(295, 399);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(91, 38);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.LastnameTB);
            this.Controls.Add(this.FirstnameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "Register form";
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
        private System.Windows.Forms.TextBox FirstnameTB;
        private System.Windows.Forms.TextBox LastnameTB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton AdministratorRadio;
        private System.Windows.Forms.RadioButton GuestRadio;
        private System.Windows.Forms.RadioButton EmployeeRadio;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}