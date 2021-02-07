using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneApplication
{
    class SensorFilter
    {
        FilterTypes filterType;
        double[] pastValues;
        double lowPassAlpha = 0.0;

        public SensorFilter(FilterTypes _filterType, double _initialValue, double _sampleTime, double _filterTime)
        {
            this.filterType = _filterType;
            if(this.filterType == FilterTypes.LowPass)
            {
                this.pastValues = new double[1];
                this.pastValues[0] = _initialValue;
                this.lowPassAlpha = (int) (_sampleTime/(_sampleTime + _filterTime));
            }
            else if(this.filterType == FilterTypes.MovingAverage)
            {
                this.pastValues = new double[(int)(_filterTime / _sampleTime)];
                for (int i = 0; i < this.pastValues.Length; i++)
                {
                    this.pastValues[i] = _initialValue;
                }
            }
            
        }

        public double FilterValue(double sample)
        {

            double filteredValue = 0;
            if (this.filterType == FilterTypes.MovingAverage)
            {
                for (int i = 0; i < this.pastValues.Length - 1; i++)
                {
                    this.pastValues[i] = this.pastValues[i + 1];
                    filteredValue += (this.pastValues[i + 1] / this.pastValues.Length);
                }
                this.pastValues[this.pastValues.Length - 1] = sample;
                filteredValue += sample / this.pastValues.Length;
            }
            else if(this.filterType == FilterTypes.LowPass)
            {
                filteredValue = (1 - this.lowPassAlpha) * this.pastValues[0] + this.lowPassAlpha * sample;
                this.pastValues[0] = sample;
            }
            
            return filteredValue;
        }

    }
}
