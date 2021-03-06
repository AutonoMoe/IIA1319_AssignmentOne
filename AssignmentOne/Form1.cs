﻿using System;
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


        private void InitializeSubMenus()
        {
            panelSensorsSubMenu.Visible = false;
            panelMenuSelectionIndicator.Visible = false;
            btnLogging.Enabled = false;
        }

        private void InitializeTimers()
        {
            SensorHandler.InitializeTimers();
        }

        private void InitializeSensors()
        {
            SensorHandler.InitializeSensors();
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
                SensorHandler.sensorSampleTimer.TimeString = DateTime.Now.AddSeconds(Configuration.SamplingTime).ToString();
            }
            else
            {
                SensorHandler.sampleTimer.Stop();
                SensorHandler.loggingTimer.Stop();
                btnSampling.Text = "Start Sampling";
                btnLogging.Enabled = false;
                SensorHandler.sensorSampleTimer.TimeString = "";
                SensorHandler.sensorLoggingTimer.TimeString = "";
            }
        }

        private void btnLogging_Click(object sender, EventArgs e)
        {
            if (btnLogging.Text == "Start Logging")
            {
                SensorHandler.loggingTimer.Start();
                btnLogging.Text = "Stop Logging";
                SensorHandler.sensorLoggingTimer.TimeString = DateTime.Now.AddSeconds(Configuration.LoggingTime).ToString();
            }
            else
            {
                SensorHandler.loggingTimer.Stop();
                btnLogging.Text = "Start Logging";
                SensorHandler.sensorLoggingTimer.TimeString = "";
            }
        }

        private void btnLogging_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.ForeColor = btn.Enabled ? Color.Gainsboro : Color.Gray;
            btn.Text = btn.Enabled ? "Start Logging" : "Logging disabled";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.BackgroundImage = (System.Drawing.Image)(AssignmentOneApplication.Properties.Resources.icons8_restore_down_32);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.BackgroundImage = (System.Drawing.Image)(AssignmentOneApplication.Properties.Resources.icons8_maximize_button_52);
            }
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The DAQ Simulation application is used to simulate sensor inputs and logging of the sensor values. Sensor values can be viewed in the Sensors panel, Configuration can be changed in the Configuration panel and more information can be viewed in the About panel.",
                                "DAQ Simulator Help", System.Windows.Forms.MessageBoxButtons.OK);
        }
    }
}
