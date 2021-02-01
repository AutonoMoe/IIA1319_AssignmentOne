using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneApplication
{
    class SensorTimer
    {
        private string timeString;

        public SensorTimer()
        {
            timeString = "";
        }

        public string TimeString
        {
            get { return timeString; }
            set { if (timeString == value) return; 
                timeString = value;
                TimeStringChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler TimeStringChanged;
    }
}
