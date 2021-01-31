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
        private Random randomSensorValue = new Random();

        private int sensorId;

        [Category("Sensor Properties")]
        public int SensorId
        {
            get { return sensorId; }
            set { sensorId = value; randomSensorValue = new Random(value); }
        }

        private string sensorName = "Sensor";

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

        private double sensorValue = 0.0;

        [Category("Sensor Properties")]
        public double SensorValue
        {
            get { return sensorValue; }
            set { sensorValue = value; txtSensorValue.Text = value.ToString("0.##") + " V"; }
        }

        private Color sensorColor = Color.BlueViolet;

        [Category("Sensor Properties")]
        public Color SensorColor
        {
            get { return sensorColor; }
            set { sensorColor = value; panelSensorTop.BackColor = value; panelSensorData.BackColor = Color.FromArgb(value.A, (int)((255 - value.R) * 0.2 + value.R), (int)((255 - value.G) * 0.2 + value.G), (int)((255 - value.B) * 0.2 + value.B)); }
        }

        private bool sensorAnalog = true;

        [Category("Sensor Properties")]
        public bool SensorAnalog
        {
            get { return sensorAnalog; }
            set { sensorAnalog = value; }
        }

        #endregion

        #region Functions
        public void GetSensorValue()
        {
            if (!SensorAnalog)
            {
                SensorValue = randomSensorValue.NextDouble() < 0.5 ? Configuration.DaqInputVoltageMin : Configuration.DaqInputVoltageMax;
            }
            else
            {
                double addition = (randomSensorValue.NextDouble() - 0.5) * (Configuration.DaqInputVoltageMax - Configuration.DaqInputVoltageMin) * 0.2;
                SensorValue += addition;
                if(SensorValue > Configuration.DaqInputVoltageMax)
                {
                    SensorValue = Configuration.DaqInputVoltageMax;
                }
                else if (SensorValue < Configuration.DaqInputVoltageMin)
                {
                    SensorValue = Configuration.DaqInputVoltageMin;
                }
            }
        }
        #endregion
    }
}
