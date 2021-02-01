using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentOneApplication
{
    public partial class FormConfiguration : Form
    {
        private FolderBrowserDialog folderBrowserDialog;

        public FormConfiguration()
        {
            InitializeComponent();
        }

        private void FormConfiguration_Load(object sender, EventArgs e)
        {
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog.Description =
                "Select the directory where you want to save the log.";

            // Do not allow the user to create new files via the FolderBrowserDialog.
            this.folderBrowserDialog.ShowNewFolderButton = true;

            // Default to the My Documents folder.
            this.folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            txtConfigNumberOfAnalog.Text = Configuration.NumberOfAnalogSensors.ToString();
            txtConfigNumberOfDigital.Text = Configuration.NumberOfDigitalSensors.ToString();
            txtConfigSamplingTime.Text = Configuration.SamplingTime.ToString();
            txtConfigLoggingTime.Text = Configuration.LoggingTime.ToString();
            txtConfigDaqInputVoltageMin.Text = Configuration.DaqInputVoltageMin.ToString();
            txtConfigDaqInputVoltageMax.Text = Configuration.DaqInputVoltageMax.ToString();
            txtConfigDaqResolution.Text = Configuration.DaqResolution.ToString();
            txtLogDirectory.Text = Configuration.LogSaveLocation.ToString();

            if(Configuration.FilterType == FilterTypes.LowPass)
            {
                radioConfigFilterType1.Checked = true;
                radioConfigFilterType2.Checked = false;
            }
            else
            {
                radioConfigFilterType2.Checked = true;
                radioConfigFilterType1.Checked = false;
            }
            checkBoxConfigDateTimeInLogFileName.Checked = Configuration.LogFileNameWithDateTime;
            if (checkBoxConfigDateTimeInLogFileName.Checked)
            {
                checkBoxConfigDateTimeInLogFileName.Text = "ON";
            }
            else
            {
                checkBoxConfigDateTimeInLogFileName.Text = "OFF";
            }
        }

        private void txtConfigNumberOfAnalog_TextChanged(object sender, EventArgs e)
        {
            Int32 parsedValue;
            if (Int32.TryParse(txtConfigNumberOfAnalog.Text, out parsedValue))
            {
                if(parsedValue > 0)
                {
                    Configuration.NumberOfAnalogSensors = parsedValue;
                }
                else
                {
                    txtConfigNumberOfAnalog.Text = Configuration.NumberOfAnalogSensors.ToString();
                }
            }
            else
            {
                txtConfigNumberOfAnalog.Text = Configuration.NumberOfAnalogSensors.ToString();
            }
            
        }

        private void txtConfigNumberOfDigital_TextChanged(object sender, EventArgs e)
        {
            Int32 parsedValue;
            if (Int32.TryParse(txtConfigNumberOfDigital.Text, out parsedValue))
            {
                if (parsedValue > 0)
                {
                    Configuration.NumberOfDigitalSensors = parsedValue;
                }
                else
                {
                    txtConfigNumberOfDigital.Text = Configuration.NumberOfDigitalSensors.ToString();
                }
            }
            else
            {
                txtConfigNumberOfDigital.Text = Configuration.NumberOfDigitalSensors.ToString();
            }
        }

        private void checkBoxConfigDateTimeInLogFileName_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.LogFileNameWithDateTime = checkBoxConfigDateTimeInLogFileName.Checked;
            if (checkBoxConfigDateTimeInLogFileName.Checked)
            {
                checkBoxConfigDateTimeInLogFileName.Text = "ON";
            }
            else
            {
                checkBoxConfigDateTimeInLogFileName.Text = "OFF";
            }
        }

        private void txtConfigSamplingTime_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (Double.TryParse(txtConfigSamplingTime.Text, out parsedValue))
            {
                if (parsedValue > 0.0)
                {
                    Configuration.SamplingTime = parsedValue;
                }
                else
                {
                    txtConfigSamplingTime.Text = Configuration.SamplingTime.ToString();
                }
            }
            else
            {
                txtConfigSamplingTime.Text = Configuration.SamplingTime.ToString();
            }
        }

        private void txtConfigLoggingTime_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (Double.TryParse(txtConfigLoggingTime.Text, out parsedValue))
            {
                if (parsedValue > 0.0)
                {
                    Configuration.LoggingTime = parsedValue;
                }
                else
                {
                    txtConfigLoggingTime.Text = Configuration.LoggingTime.ToString();
                }
            }
            else
            {
                txtConfigLoggingTime.Text = Configuration.LoggingTime.ToString();
            }
        }

        private void txtConfigDaqInputVoltageMin_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (Double.TryParse(txtConfigDaqInputVoltageMin.Text, out parsedValue))
            {
                if (parsedValue < Configuration.DaqInputVoltageMax)
                {
                    Configuration.DaqInputVoltageMin = parsedValue;
                }
                else
                {
                    txtConfigDaqInputVoltageMin.Text = Configuration.DaqInputVoltageMin.ToString();
                }
            }
            else
            {
                txtConfigDaqInputVoltageMin.Text = Configuration.DaqInputVoltageMin.ToString();
            }
        }

        private void txtConfigDaqInputVoltageMax_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (Double.TryParse(txtConfigDaqInputVoltageMax.Text, out parsedValue))
            {
                if (parsedValue > Configuration.DaqInputVoltageMin)
                {
                    Configuration.DaqInputVoltageMax = parsedValue;
                }
                else
                {
                    txtConfigDaqInputVoltageMax.Text = Configuration.DaqInputVoltageMax.ToString();
                }
            }
            else
            {
                txtConfigDaqInputVoltageMax.Text = Configuration.DaqInputVoltageMax.ToString();
            }
        }

        private void txtConfigDaqResolution_TextChanged(object sender, EventArgs e)
        {
            Int32 parsedValue;
            if (Int32.TryParse(txtConfigDaqResolution.Text, out parsedValue))
            {
                if (parsedValue > 0)
                {
                    Configuration.DaqResolution = parsedValue;
                }
                else
                {
                    txtConfigDaqResolution.Text = Configuration.DaqResolution.ToString();
                }
            }
            else
            {
                txtConfigDaqResolution.Text = Configuration.DaqResolution.ToString();
            }
        }

        private void radioConfigFilterType1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioConfigFilterType1.Checked == true)
            {
                Configuration.FilterType = FilterTypes.LowPass;
                radioConfigFilterType2.Checked = false;
            }
            else
            {
                Configuration.FilterType = FilterTypes.MovingAverage;
                radioConfigFilterType2.Checked = true;
            }
        }

        private void radioConfigFilterType2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioConfigFilterType2.Checked == true)
            {
                Configuration.FilterType = FilterTypes.MovingAverage;
                radioConfigFilterType1.Checked = false;
            }
            else
            {
                Configuration.FilterType = FilterTypes.LowPass;
                radioConfigFilterType1.Checked = true;
            }
        }

        private void btnBrowseDirectory_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtLogDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void txtLogDirectory_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(txtLogDirectory.Text))
            {
                Configuration.LogSaveLocation = txtLogDirectory.Text;
            }
            
        }
    }
}
