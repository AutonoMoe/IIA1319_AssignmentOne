using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    
    static class Configuration
    {

        private static int numberOfAnalogSensors = 6;

        public static int NumberOfAnalogSensors
        {
            get { return numberOfAnalogSensors; }
            set { 
                if (value > 0) 
                {
                    numberOfAnalogSensors = value;
                }
                else
                {
                    numberOfAnalogSensors = 1;
                }
            }
        }

        private static int numberOfDigitalSensors = 3;

        public static int NumberOfDigitalSensors
        {
            get { return numberOfDigitalSensors; }
            set
            {
                if (value > 0)
                {
                    numberOfDigitalSensors = value;
                }
                else
                {
                    numberOfDigitalSensors = 1;
                }
            }
        }

        private static double samplingTime = 3.0;

        public static double SamplingTime
        {
            get { return samplingTime; }
            set { if(value > 0) samplingTime = value; }
        }

        private static double loggingTime = 47.0;

        public static double LoggingTime
        {
            get { return loggingTime; }
            set { if(value > 0) loggingTime = value; }
        }

        private static double daqInputVoltageMin = 0.0;

        public static double DaqInputVoltageMin
        {
            get { return daqInputVoltageMin; }
            set { if (value <= daqInputVoltageMax) daqInputVoltageMin = value; }
        }

        private static double daqInputVoltageMax = 1.0;
        
        public static double DaqInputVoltageMax
        {
            get { return daqInputVoltageMax; }
            set { if (value >= daqInputVoltageMin) daqInputVoltageMax = value; }
        }

        private static int daqResolution = 12;

        public static int DaqResolution
        {
            get { return daqResolution; }
            set { if(value > 0) daqResolution = value; }
        }

        private static FilterTypes filterType = FilterTypes.MovingAverage;

        public static FilterTypes FilterType
        {
            get { return filterType; }
            set { filterType = value; }
        }

        private static bool logFileNameWithDateTime = false;

        public static bool LogFileNameWithDateTime
        {
            get { return logFileNameWithDateTime; }
            set { logFileNameWithDateTime = value; }
        }
    }

    public enum FilterTypes {
        LowPass,
        MovingAverage
    }
}
