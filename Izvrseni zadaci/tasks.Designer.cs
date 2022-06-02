namespace _14_Izvrseni_zadatci
{
    partial class tasksFrm
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
            this.dgvOtvoreni = new System.Windows.Forms.DataGridView();
            this.dgvIzvrseni = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Priority = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.btnMarkAsComplete = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtvoreni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvrseni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOtvoreni
            // 
            this.dgvOtvoreni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtvoreni.Location = new System.Drawing.Point(57, 51);
            this.dgvOtvoreni.Name = "dgvOtvoreni";
            this.dgvOtvoreni.RowHeadersWidth = 51;
            this.dgvOtvoreni.RowTemplate.Height = 24;
            this.dgvOtvoreni.Size = new System.Drawing.Size(580, 150);
            this.dgvOtvoreni.TabIndex = 0;
            // 
            // dgvIzvrseni
            // 
            this.dgvIzvrseni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvrseni.Location = new System.Drawing.Point(58, 313);
            this.dgvIzvrseni.Name = "dgvIzvrseni";
            this.dgvIzvrseni.RowHeadersWidth = 51;
            this.dgvIzvrseni.RowTemplate.Height = 24;
            this.dgvIzvrseni.Size = new System.Drawing.Size(580, 196);
            this.dgvIzvrseni.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description";
            // 
            // Priority
            // 
            this.Priority.AutoSize = true;
            this.Priority.Location = new System.Drawing.Point(486, 219);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(48, 16);
            this.Priority.TabIndex = 3;
            this.Priority.Text = "Priority";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(327, 252);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(139, 22);
            this.tbDescription.TabIndex = 4;
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(489, 250);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(121, 24);
            this.cmbPriority.TabIndex = 5;
            // 
            // btnMarkAsComplete
            // 
            this.btnMarkAsComplete.Location = new System.Drawing.Point(665, 74);
            this.btnMarkAsComplete.Name = "btnMarkAsComplete";
            this.btnMarkAsComplete.Size = new System.Drawing.Size(92, 61);
            this.btnMarkAsComplete.TabIndex = 6;
            this.btnMarkAsComplete.Text = "Mark as complete";
            this.btnMarkAsComplete.UseVisualStyleBackColor = true;
            this.btnMarkAsComplete.Click += new System.EventHandler(this.btnMarkAsComplete_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(665, 225);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(92, 49);
            this.btnAddTask.TabIndex = 7;
            this.btnAddTask.Text = "Add task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Otovreni zadaci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Izvršeni zadaci";
            // 
            // tasksFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnMarkAsComplete);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.Priority);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIzvrseni);
            this.Controls.Add(this.dgvOtvoreni);
            this.Name = "tasksFrm";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.tasksFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtvoreni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvrseni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOtvoreni;
        private System.Windows.Forms.DataGridView dgvIzvrseni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Priority;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Button btnMarkAsComplete;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

