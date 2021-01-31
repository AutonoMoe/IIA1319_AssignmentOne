﻿using System;
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
            foreach(Sensor s in SensorHandler.sensors)
            {
                SensorControl sensorControl = new SensorControl();
                sensorControl.Size = new System.Drawing.Size(160, 215);
                sensorControl.SensorId = s.SensorId;
                sensorControl.SensorName = s.SensorName;
                sensorControl.SensorValue = s.SensorValue;
                sensorControl.SensorIcon = s.SensorAnalog == true ? ((System.Drawing.Image)(AssignmentOneApplication.Properties.Resources.icons8_plot_100)) : ((System.Drawing.Image)(AssignmentOneApplication.Properties.Resources.icons8_square_wave_100));
                flowSensorsMain.Controls.Add(sensorControl);
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
