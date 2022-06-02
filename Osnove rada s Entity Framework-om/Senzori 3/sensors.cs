using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_Sensors
{
    public partial class SensorsFrm : Form
    {
        public SensorsFrm()
        {
            InitializeComponent();
        }

        private void SensorsFrm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            dgvSensors.DataSource = DohvatiSenzore();
            dgvSensors.Columns[4].Visible = false;
            dgvSensors.Columns[5].Visible = false;
        }

        private object DohvatiSenzore()
        {
            using (var context = new DB_EntityEntities())
            {
                return context.Sensors.ToList();
            }
        }

        private void btnAddSensor_Click(object sender, EventArgs e)
        {
            AddNewSensorFrm forma = new AddNewSensorFrm();
            forma.Show();
            this.Hide();

            Osvjezi();
        }
    }
}
