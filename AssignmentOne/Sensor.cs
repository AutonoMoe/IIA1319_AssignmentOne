using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneApplication
{
    class Sensor
    {

        #region Properties
        private Random randomSensorValue = new Random();
        private int sensorId;
        private string sensorName = "Sensor";
        private double sensorValue = 0.0;
        private bool sensorAnalog = true;

        public Sensor(int id, string name, double value, bool isAnalog = true)
        {
            this.SensorId = id;
            this.SensorName = name;
            this.SensorValue = value;
            this.SensorAnalog = isAnalog;
        }

        public int SensorId
        {
            get { return sensorId; }
            set { sensorId = value; randomSensorValue = new Random(value); }
        }

        public string SensorName
        {
            get { return sensorName; }
            set { sensorName = value; }
        }

        public double SensorValue
        {
            get { return sensorValue; }
            set { sensorValue = value; }
        }

        public bool SensorAnalog
        {
            get { return sensorAnalog; }
            set { sensorAnalog = value; }
        }

        #endregion

        #region Functions
        public void GetSensorValue()
        {
            if (!sensorAnalog)
            {
                sensorValue = randomSensorValue.NextDouble() < 0.5 ? Configuration.DaqInputVoltageMin : Configuration.DaqInputVoltageMax;
            }
            else
            {
                double addition = (randomSensorValue.NextDouble() - 0.5) * (Configuration.DaqInputVoltageMax - Configuration.DaqInputVoltageMin) * 0.2;
                sensorValue += addition;
                if (sensorValue > Configuration.DaqInputVoltageMax)
                {
                    sensorValue = Configuration.DaqInputVoltageMax;
                }
                else if (sensorValue < Configuration.DaqInputVoltageMin)
                {
                    sensorValue = Configuration.DaqInputVoltageMin;
                }
            }
        }
        #endregion
    }
}
