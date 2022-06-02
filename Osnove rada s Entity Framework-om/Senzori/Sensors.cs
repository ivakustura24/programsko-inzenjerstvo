using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Sensor
{
    public partial class SensorsFrm : Form
    {
        public SensorsFrm()
        {
            InitializeComponent();
        }

        private void dgvSensors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            dgvSensors.DataSource = FillSensors();
            dgvSensors.Columns["MeasurementUnit"].Visible = false;
            dgvSensors.Columns["SensorType"].Visible = false;
        }

        private object FillSensors()
        {
            using (var context = new DB_EntityEntities())
            {
                return context.Sensors.ToList();
            }
        }

        private void SensorsFrm_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void btnAddSensor_Click(object sender, EventArgs e)
        {
            AddSensor forma = new AddSensor();
            forma.ShowDialog();

            RefreshGUI();
        }

        private void btnDeleteSensor_Click(object sender, EventArgs e)
        {
            if(dgvSensors.CurrentRow != null)
            {
                using (var context= new DB_EntityEntities())
                {
                    Sensor sensor = dgvSensors.CurrentRow.DataBoundItem as Sensor;
                    context.Sensors.Attach(sensor);
                    context.Sensors.Remove(sensor);
                    context.SaveChanges();
                }
                RefreshGUI();
                
            }
        }
    }
}
