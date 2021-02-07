using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneApplication
{
    
    static class Configuration
    {

        public static int NumberOfAnalogSensors
        {
            get { return Properties.Settings.Default.numberOfAnalogSensors; }
            set {
                if (value == Properties.Settings.Default.numberOfAnalogSensors) return;
                if (value > 0) 
                {
                    Properties.Settings.Default.numberOfAnalogSensors = value;
                }
                else
                {
                    Properties.Settings.Default.numberOfAnalogSensors = 1;
                }
                Properties.Settings.Default.Save();
                SensorHandler.InitializeSensors();
            }
        }

        public static int NumberOfDigitalSensors
        {
            get { return Properties.Settings.Default.numberOfDigitalSensors; }
            set
            {
                if (value == Properties.Settings.Default.numberOfDigitalSensors) return;
                if (value > 0)
                {
                    Properties.Settings.Default.numberOfDigitalSensors = value;
                }
                else
                {
                    Properties.Settings.Default.numberOfDigitalSensors = 1;
                }
                Properties.Settings.Default.Save();
                SensorHandler.InitializeSensors();
            }
        }

        public static double SamplingTime
        {
            get { return Properties.Settings.Default.samplingTime; }
            set 
            {
                if (value == Properties.Settings.Default.samplingTime) return;
                if(value > 0) Properties.Settings.Default.samplingTime = value;
                Properties.Settings.Default.Save();
                SensorHandler.InitializeTimers();
            }
        }

        public static double LoggingTime
        {
            get { return Properties.Settings.Default.loggingTime; }
            set 
            {
                if (value == Properties.Settings.Default.loggingTime) return;
                if(value > 0) Properties.Settings.Default.loggingTime = value;
                Properties.Settings.Default.Save();
                SensorHandler.InitializeTimers();
            }
        }

        public static double DaqInputVoltageMin
        {
            get { return Properties.Settings.Default.daqInputVoltageMin; }
            set 
            { 
                if (value <= DaqInputVoltageMax) Properties.Settings.Default.daqInputVoltageMin = value;
                Properties.Settings.Default.Save();
            }
        }
                
        public static double DaqInputVoltageMax
        {
            get { return Properties.Settings.Default.daqInputVoltageMax; }
            set 
            { 
                if (value >= DaqInputVoltageMin) Properties.Settings.Default.daqInputVoltageMax = value;
                Properties.Settings.Default.Save();
            }
        }

        public static int DaqResolution
        {
            get { return Properties.Settings.Default.daqResolution; }
            set 
            { 
                if(value > 0) Properties.Settings.Default.daqResolution = value;
                Properties.Settings.Default.Save();
            }
        }

        public static FilterTypes FilterType
        {
            get { return (FilterTypes) Enum.Parse(typeof(FilterTypes), Properties.Settings.Default.filterType); }
            set 
            {
                if ((FilterTypes)Enum.Parse(typeof(FilterTypes), Properties.Settings.Default.filterType) == value) return;
                Properties.Settings.Default.filterType = value.ToString();
                Properties.Settings.Default.Save();
                SensorHandler.InitializeSensors();
            }
        }

        public static bool LogFileNameWithDateTime
        {
            get { return Properties.Settings.Default.logFileNameWithDateTime; }
            set 
            { 
                Properties.Settings.Default.logFileNameWithDateTime = value;
                Properties.Settings.Default.Save();
            }
        }

        public static string LogSaveLocation
        {
            get { return Properties.Settings.Default.logSaveLocation; }
            set 
            { 
                Properties.Settings.Default.logSaveLocation = value;
                Properties.Settings.Default.Save();
            }
        }
    }

    public enum FilterTypes {
        LowPass,
        MovingAverage
    }
}
