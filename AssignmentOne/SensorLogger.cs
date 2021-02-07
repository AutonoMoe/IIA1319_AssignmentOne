using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneApplication
{
    public sealed class SensorLogger
    {
        private static SensorLogger instance = null;

        private SensorLogger()
        {
        }

        public static SensorLogger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SensorLogger();
                }
                return instance;
            }
        }

        private string fileName = "DAQ_Sensor_Log";

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public void AddLog(int id, string name, string timeStamp, double value)
        {
            var records = new List<SensorLog>
            {
                new SensorLog(id, name, timeStamp, value)
            };
        
            string dateString = DateTime.Now.Date.ToString("DD_MM_YYYY");
            string fileName = "DAQ_Sensor_Log" + (Configuration.LogFileNameWithDateTime ? "_" + dateString + ".csv" : ".csv");
            string filePath = Path.Combine(Configuration.LogSaveLocation, Path.GetFileName(fileName));
            if (System.IO.File.Exists(filePath))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = false,
                };
                using (var stream = File.Open(filePath, FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(records);
                }
            }
            else
            {
                using (var writer = new StreamWriter(filePath))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(records);
                }
            }
        }
    }
}
