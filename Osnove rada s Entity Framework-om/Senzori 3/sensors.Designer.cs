namespace _17_Sensors
{
    partial class SensorsFrm
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
            this.dgvSensors = new System.Windows.Forms.DataGridView();
            this.btnAddSensor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sensors";
            // 
            // dgvSensors
            // 
            this.dgvSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSensors.Location = new System.Drawing.Point(27, 67);
            this.dgvSensors.Name = "dgvSensors";
            this.dgvSensors.RowHeadersWidth = 51;
            this.dgvSensors.RowTemplate.Height = 24;
            this.dgvSensors.Size = new System.Drawing.Size(554, 326);
            this.dgvSensors.TabIndex = 1;
            // 
            // btnAddSensor
            // 
            this.btnAddSensor.Location = new System.Drawing.Point(446, 407);
            this.btnAddSensor.Name = "btnAddSensor";
            this.btnAddSensor.Size = new System.Drawing.Size(135, 31);
            this.btnAddSensor.TabIndex = 2;
            this.btnAddSensor.Text = "Add sensor";
            this.btnAddSensor.UseVisualStyleBackColor = true;
            this.btnAddSensor.Click += new System.EventHandler(this.btnAddSensor_Click);
            // 
            // SensorsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.btnAddSensor);
            this.Controls.Add(this.dgvSensors);
            this.Controls.Add(this.label1);
            this.Name = "SensorsFrm";
            this.Text = "Sensors";
            this.Load += new System.EventHandler(this.SensorsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSensors;
        private System.Windows.Forms.Button btnAddSensor;
    }
}

