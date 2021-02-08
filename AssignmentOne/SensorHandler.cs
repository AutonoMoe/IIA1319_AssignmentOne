using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentOneApplication
{
    static class SensorHandler
    {

        #region Properties
        public static Timer sampleTimer = new Timer();
        public static SensorTimer sensorSampleTimer = new SensorTimer();
        public static Timer loggingTimer = new Timer();
        public static SensorTimer sensorLoggingTimer = new SensorTimer();
        public static Sensor[] sensors = new Sensor[Configuration.NumberOfAnalogSensors + Configuration.NumberOfDigitalSensors];
        private static SensorLogger sensorLogger = SensorLogger.Instance;

        #endregion

        #region Functions
        public static void InitializeSensors()
        {
            int numberOfSensors = Configuration.NumberOfAnalogSensors + Configuration.NumberOfDigitalSensors;
            sensors = new Sensor[numberOfSensors];
            for (int i = 0; i < numberOfSensors; i++)
            {
                sensors[i] = new Sensor(i, "Sensor #" + (i + 1), 0.5, i < Configuration.NumberOfAnalogSensors ? true : false);
                sensors[i].GetSensorValue();
            }
        }

        public static void InitializeTimers()
        {
            sampleTimer.Interval = (int)(Configuration.SamplingTime * 1000);
            sampleTimer.Tick += new EventHandler(SampleSensors);

            loggingTimer.Interval = (int)(Configuration.LoggingTime * 1000);
            loggingTimer.Tick += new EventHandler(LogSamples);
            InitializeSensors();
        }

        public static void SampleSensors(object sender, EventArgs e)
        {
            foreach(Sensor s in sensors)
            {
                s.GetSensorValue();
            }
            sensorSampleTimer.TimeString = DateTime.Now.AddSeconds(Configuration.SamplingTime).ToString();
        }

        public static void LogSamples(object sender, EventArgs e)
        {
            foreach(Sensor s in sensors)
            {
                double logValue = 0.0;
                if (s.SensorAnalog)
                {
                    logValue = s.SensorFilteredValue;
                }
                else
                {
                    logValue = s.SensorValue;
                }
                sensorLogger.AddLog(s.SensorId, s.SensorName, DateTime.Now.ToString("dd-MM-yyyy HH:mm.ss"), logValue);
            }
            sensorLoggingTimer.TimeString = DateTime.Now.AddSeconds(Configuration.LoggingTime).ToString();
        }
        #endregion
    }
}
