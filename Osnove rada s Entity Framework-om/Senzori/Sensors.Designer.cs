namespace _02_Sensor
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
            this.dgvSensors = new System.Windows.Forms.DataGridView();
            this.btnAddSensor = new System.Windows.Forms.Button();
            this.btnDeleteSensor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSensors
            // 
            this.dgvSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSensors.Location = new System.Drawing.Point(27, 25);
            this.dgvSensors.Name = "dgvSensors";
            this.dgvSensors.RowHeadersWidth = 51;
            this.dgvSensors.RowTemplate.Height = 24;
            this.dgvSensors.Size = new System.Drawing.Size(588, 232);
            this.dgvSensors.TabIndex = 0;
            // 
            // btnAddSensor
            // 
            this.btnAddSensor.Location = new System.Drawing.Point(27, 312);
            this.btnAddSensor.Name = "btnAddSensor";
            this.btnAddSensor.Size = new System.Drawing.Size(107, 34);
            this.btnAddSensor.TabIndex = 1;
            this.btnAddSensor.Text = "Add sensor";
            this.btnAddSensor.UseVisualStyleBackColor = true;
            this.btnAddSensor.Click += new System.EventHandler(this.btnAddSensor_Click);
            // 
            // btnDeleteSensor
            // 
            this.btnDeleteSensor.Location = new System.Drawing.Point(508, 312);
            this.btnDeleteSensor.Name = "btnDeleteSensor";
            this.btnDeleteSensor.Size = new System.Drawing.Size(107, 34);
            this.btnDeleteSensor.TabIndex = 2;
            this.btnDeleteSensor.Text = "Delete sensor";
            this.btnDeleteSensor.UseVisualStyleBackColor = true;
            this.btnDeleteSensor.Click += new System.EventHandler(this.btnDeleteSensor_Click);
            // 
            // SensorsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 388);
            this.Controls.Add(this.btnDeleteSensor);
            this.Controls.Add(this.btnAddSensor);
            this.Controls.Add(this.dgvSensors);
            this.Name = "SensorsFrm";
            this.Text = "Sensors";
            this.Load += new System.EventHandler(this.SensorsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSensors;
        private System.Windows.Forms.Button btnAddSensor;
        private System.Windows.Forms.Button btnDeleteSensor;
    }
}

