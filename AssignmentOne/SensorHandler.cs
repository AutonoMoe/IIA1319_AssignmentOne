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
        public static Timer sampleTimer = new Timer();
        public static string nextSampleTime = "";
        public static Timer loggingTimer = new Timer();
        public static SensorControl[] sensorControls = new SensorControl[Configuration.NumberOfAnalogSensors + Configuration.NumberOfDigitalSensors];

        public static void SampleSensors(object sender, EventArgs e)
        {
            foreach(SensorControl s in sensorControls)
            {
                s.GetSensorValue();
            }
            nextSampleTime = DateTime.Now.AddSeconds(Configuration.SamplingTime).ToString();
        }

        public static void LogSamples(object sender, EventArgs e)
        {

        }

    }
}
