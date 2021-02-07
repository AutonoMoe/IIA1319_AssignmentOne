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
    public partial class AssignmentOne : Form
    {

        private Form activeForm = null;
        private Random rnd = new Random();

        public AssignmentOne()
        {
            InitializeComponent();
            InitializeSubMenus();
            InitializeTimers();
            InitializeSensors();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeSubMenus()
        {
            panelSensorsSubMenu.Visible = false;
            panelMenuSelectionIndicator.Visible = false;
            btnLogging.Enabled = false;
        }

        private void InitializeTimers()
        {
            SensorHandler.sampleTimer.Interval = (int)(Configuration.SamplingTime * 1000);
            SensorHandler.sampleTimer.Tick += new EventHandler(SensorHandler.SampleSensors);
            
            SensorHandler.loggingTimer.Interval = (int)(Configuration.LoggingTime * 1000);
            SensorHandler.loggingTimer.Tick += new EventHandler(SensorHandler.LogSamples);
        }

        private void InitializeSensors()
        {
            int numberOfSensors = Configuration.NumberOfAnalogSensors + Configuration.NumberOfDigitalSensors;
            SensorHandler.sensors = new Sensor[numberOfSensors];
            for (int i = 0; i < Configuration.NumberOfAnalogSensors + Configuration.NumberOfDigitalSensors; i++)
            {
                SensorHandler.sensors[i] = new Sensor(i, "Sensor #" + (i + 1), 0.5, i < Configuration.NumberOfAnalogSensors ? true : false);
                SensorHandler.sensors[i].GetSensorValue();
            }
        }

        private void HideSubMenu()
        {
            if(panelSensorsSubMenu.Visible == true)
            {
                panelSensorsSubMenu.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
        }

        private void btnSensors_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSensors());
            lblTitle.Text = "Sensors";
            ShowSubMenu(panelSensorsSubMenu);
            panelMenuSelectionIndicator.Visible = true;
            panelMenuSelectionIndicator.Height = btnSensors.Height;
            panelMenuSelectionIndicator.Top = btnSensors.Top;
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            openChildForm(new FormConfiguration());
            lblTitle.Text = "Configuration";
            HideSubMenu();
            panelMenuSelectionIndicator.Visible = true;
            panelMenuSelectionIndicator.Height = btnConfiguration.Height;
            panelMenuSelectionIndicator.Top = btnConfiguration.Top;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAbout());
            lblTitle.Text = "About";
            HideSubMenu();
            panelMenuSelectionIndicator.Visible = true;
            panelMenuSelectionIndicator.Height = btnAbout.Height;
            panelMenuSelectionIndicator.Top = btnAbout.Top;
        }

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSampling_Click(object sender, EventArgs e)
        {
            if(btnSampling.Text == "Start Sampling")
            {
                SensorHandler.sampleTimer.Start();
                btnSampling.Text = "Stop Sampling";
                btnLogging.Enabled = true;
            }
            else
            {
                SensorHandler.sampleTimer.Stop();
                SensorHandler.loggingTimer.Stop();
                btnSampling.Text = "Start Sampling";
                btnLogging.Enabled = false;
            }
        }

        private void btnLogging_Click(object sender, EventArgs e)
        {
            if (btnLogging.Text == "Start Logging")
            {
                SensorHandler.loggingTimer.Start();
                btnLogging.Text = "Stop Logging";
            }
            else
            {
                SensorHandler.loggingTimer.Stop();
                btnLogging.Text = "Start Logging";
            }
        }

        private void btnLogging_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.ForeColor = btn.Enabled ? Color.Gainsboro : Color.Gray;
            btn.Text = btn.Enabled ? "Start Logging" : "Logging disabled";
        }
    }
}
