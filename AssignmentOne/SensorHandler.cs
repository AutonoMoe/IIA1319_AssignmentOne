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
                sensorLogger.AddLog(s.SensorId, s.SensorName, DateTime.Now.ToString("dd-MM-yyyy HH:mm.ss"), s.SensorFilteredValue);
            }
        }

    }
}
