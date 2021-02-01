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
            set 
            {
                if (sensorId == value) return;
                sensorId = value;
                var handler = SensorIdChanged;
                if (handler != null) handler(this, EventArgs.Empty);
                randomSensorValue = new Random(value);
            }
        }

        public event EventHandler SensorIdChanged;

        public string SensorName
        {
            get { return sensorName; }
            set
            {
                if (sensorName == value) return;
                sensorName = value;
                var handler = SensorNameChanged;
                if (handler != null) handler(this, EventArgs.Empty);
            }
        }

        public event EventHandler SensorNameChanged;

        public double SensorValue
        {
            get { return sensorValue; }
            set
            {
                if (sensorValue == value) return;
                sensorValue = value;
                var handler = SensorValueChanged;
                if (handler != null) handler(this, EventArgs.Empty);
            }
        }

        public event EventHandler SensorValueChanged;

        public bool SensorAnalog
        {
            get { return sensorAnalog; }
            set
            {
                if (sensorAnalog == value) return;
                sensorAnalog = value;
                var handler = SensorAnalogChanged;
                if (handler != null) handler(this, EventArgs.Empty);
            }
        }

        public event EventHandler SensorAnalogChanged;

        #endregion

        #region Functions
        public void GetSensorValue()
        {
            if (!sensorAnalog)
            {
                SensorValue = randomSensorValue.NextDouble() < 0.5 ? Configuration.DaqInputVoltageMin : Configuration.DaqInputVoltageMax;
            }
            else
            {
                double addition = (randomSensorValue.NextDouble() - 0.5) * (Configuration.DaqInputVoltageMax - Configuration.DaqInputVoltageMin) * 0.2;
                SensorValue += addition;
                if (SensorValue > Configuration.DaqInputVoltageMax)
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
