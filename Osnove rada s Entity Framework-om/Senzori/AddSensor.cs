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
    public partial class AddSensor : Form
    {
        public AddSensor()
        {
            InitializeComponent();
        }

        private void AddSensor_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            FillTypes();
            FillUnits();
        }

        private void FillUnits()
        {
            using (var context = new DB_EntityEntities())
            {
                cmbType.DataSource = context.SensorTypes.ToList();
            }
        }

        private void FillTypes()
        {
            using (var context = new DB_EntityEntities())
            {
                cmbUnit.DataSource = context.MeasurementUnits.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new DB_EntityEntities())
            {
                string name = tbName.Text;
                SensorType type = cmbType.SelectedItem as SensorType;
                MeasurementUnit unit = cmbUnit.SelectedItem as MeasurementUnit;
                context.SensorTypes.Attach(type);
                context.MeasurementUnits.Attach(unit);

                Sensor sensor = new Sensor()
                {
                    Name = name,
                    IdSensorTypes = type.Id,
                    IdMeasurementUnits = unit.Id
                };
                context.Sensors.Add(sensor);
                context.SaveChanges();
            }
            Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
