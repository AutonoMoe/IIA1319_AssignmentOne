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
    public partial class SensorControl : UserControl
    {
        public SensorControl()
        {
            InitializeComponent();
        }

        #region Properties
        private string sensorName;

        [Category("Sensor Properties")]
        public string SensorName
        {
            get { return sensorName; }
            set { sensorName = value; lblSensorName.Text = value; }
        }

        private Image sensorIcon;

        [Category("Sensor Properties")]
        public Image SensorIcon
        {
            get { return sensorIcon; }
            set { sensorIcon = value; picSensorIcon.Image = value; }
        }

        private double sensorValue;

        [Category("Sensor Properties")]
        public double SensorValue
        {
            get { return sensorValue; }
            set { sensorValue = value; txtSensorValue.Text = value.ToString("0.##") + " V"; }
        }

        private Color sensorColor;

        [Category("Sensor Properties")]
        public Color SensorColor
        {
            get { return sensorColor; }
            set { sensorColor = value; panelSensorTop.BackColor = value; panelSensorData.BackColor = Color.FromArgb(value.A, (int)((255 - value.R) * 0.2 + value.R), (int)((255 - value.G) * 0.2 + value.G), (int)((255 - value.B) * 0.2 + value.B)); }
        }

        #endregion

    }
}
