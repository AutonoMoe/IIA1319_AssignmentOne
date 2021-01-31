using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentOneApplication
{
    public partial class FormSensors : Form
    {
        public FormSensors()
        {
            InitializeComponent();
        }

        private void InitializeSensorControls()
        {
            flowSensorsMain.Controls.Clear();
            foreach(SensorControl s in SensorHandler.sensorControls)
            {
                s.Size = new System.Drawing.Size(160, 215);
                flowSensorsMain.Controls.Add(s);
            }
        }


        private void FormSensors_Load(object sender, EventArgs e)
        {
            InitializeSensorControls();
        }

        public void SetSampleText(string text)
        {
            txtSensorsNextSampleTime.Text = text;
        }
    }
}
