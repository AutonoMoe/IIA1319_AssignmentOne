using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneApplication
{
    class SensorLog
    {

        #region constructor
        public SensorLog(int _id, string _name, string _timeStamp, double _measurement)
        {
            Id = _id;
            Name = _name;
            TimeStamp = _timeStamp;
            Measurement = _measurement;
        }

        #endregion

        #region properties
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string timeStamp;

        public string TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        private double measurement;

        public double Measurement
        {
            get { return measurement; }
            set { measurement = value; }
        }
        #endregion
    }
}
