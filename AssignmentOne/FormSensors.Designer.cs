
namespace AssignmentOneApplication
{
    partial class FormSensors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSensors));
            this.lblSensorsNextSampleTime = new System.Windows.Forms.Label();
            this.txtSensorsNextSampleTime = new System.Windows.Forms.TextBox();
            this.txtSensorsNextLoggingTime = new System.Windows.Forms.TextBox();
            this.lblSensorsNextLoggingTime = new System.Windows.Forms.Label();
            this.flowSensorsMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSensorsSidebar = new System.Windows.Forms.Panel();
            this.panelSensorsMain = new System.Windows.Forms.Panel();
            this.sensorControl1 = new AssignmentOneApplication.SensorControl();
            this.sensorControl2 = new AssignmentOneApplication.SensorControl();
            this.sensorControl3 = new AssignmentOneApplication.SensorControl();
            this.sensorControl4 = new AssignmentOneApplication.SensorControl();
            this.sensorControl5 = new AssignmentOneApplication.SensorControl();
            this.sensorControl6 = new AssignmentOneApplication.SensorControl();
            this.sensorControl7 = new AssignmentOneApplication.SensorControl();
            this.sensorControl8 = new AssignmentOneApplication.SensorControl();
            this.sensorControl9 = new AssignmentOneApplication.SensorControl();
            this.flowSensorsMain.SuspendLayout();
            this.panelSensorsSidebar.SuspendLayout();
            this.panelSensorsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSensorsNextSampleTime
            // 
            this.lblSensorsNextSampleTime.AutoSize = true;
            this.lblSensorsNextSampleTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSensorsNextSampleTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSensorsNextSampleTime.Location = new System.Drawing.Point(0, 0);
            this.lblSensorsNextSampleTime.Name = "lblSensorsNextSampleTime";
            this.lblSensorsNextSampleTime.Padding = new System.Windows.Forms.Padding(10);
            this.lblSensorsNextSampleTime.Size = new System.Drawing.Size(142, 37);
            this.lblSensorsNextSampleTime.TabIndex = 0;
            this.lblSensorsNextSampleTime.Text = "Next Sample Time";
            // 
            // txtSensorsNextSampleTime
            // 
            this.txtSensorsNextSampleTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtSensorsNextSampleTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSensorsNextSampleTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSensorsNextSampleTime.ForeColor = System.Drawing.Color.White;
            this.txtSensorsNextSampleTime.Location = new System.Drawing.Point(0, 37);
            this.txtSensorsNextSampleTime.Margin = new System.Windows.Forms.Padding(5);
            this.txtSensorsNextSampleTime.Name = "txtSensorsNextSampleTime";
            this.txtSensorsNextSampleTime.Size = new System.Drawing.Size(200, 16);
            this.txtSensorsNextSampleTime.TabIndex = 1;
            this.txtSensorsNextSampleTime.Text = "2021-01-26 23:59:23";
            this.txtSensorsNextSampleTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSensorsNextLoggingTime
            // 
            this.txtSensorsNextLoggingTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtSensorsNextLoggingTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSensorsNextLoggingTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSensorsNextLoggingTime.ForeColor = System.Drawing.Color.White;
            this.txtSensorsNextLoggingTime.Location = new System.Drawing.Point(0, 90);
            this.txtSensorsNextLoggingTime.Margin = new System.Windows.Forms.Padding(5);
            this.txtSensorsNextLoggingTime.Name = "txtSensorsNextLoggingTime";
            this.txtSensorsNextLoggingTime.Size = new System.Drawing.Size(200, 16);
            this.txtSensorsNextLoggingTime.TabIndex = 3;
            this.txtSensorsNextLoggingTime.Text = "2021-01-26 23:59:23";
            this.txtSensorsNextLoggingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSensorsNextLoggingTime
            // 
            this.lblSensorsNextLoggingTime.AutoSize = true;
            this.lblSensorsNextLoggingTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSensorsNextLoggingTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSensorsNextLoggingTime.Location = new System.Drawing.Point(0, 53);
            this.lblSensorsNextLoggingTime.Name = "lblSensorsNextLoggingTime";
            this.lblSensorsNextLoggingTime.Padding = new System.Windows.Forms.Padding(10);
            this.lblSensorsNextLoggingTime.Size = new System.Drawing.Size(146, 37);
            this.lblSensorsNextLoggingTime.TabIndex = 2;
            this.lblSensorsNextLoggingTime.Text = "Next Logging Time";
            // 
            // flowSensorsMain
            // 
            this.flowSensorsMain.AutoScroll = true;
            this.flowSensorsMain.Controls.Add(this.sensorControl1);
            this.flowSensorsMain.Controls.Add(this.sensorControl2);
            this.flowSensorsMain.Controls.Add(this.sensorControl3);
            this.flowSensorsMain.Controls.Add(this.sensorControl4);
            this.flowSensorsMain.Controls.Add(this.sensorControl5);
            this.flowSensorsMain.Controls.Add(this.sensorControl6);
            this.flowSensorsMain.Controls.Add(this.sensorControl7);
            this.flowSensorsMain.Controls.Add(this.sensorControl8);
            this.flowSensorsMain.Controls.Add(this.sensorControl9);
            this.flowSensorsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSensorsMain.Location = new System.Drawing.Point(0, 0);
            this.flowSensorsMain.Margin = new System.Windows.Forms.Padding(6);
            this.flowSensorsMain.Name = "flowSensorsMain";
            this.flowSensorsMain.Size = new System.Drawing.Size(800, 550);
            this.flowSensorsMain.TabIndex = 5;
            // 
            // panelSensorsSidebar
            // 
            this.panelSensorsSidebar.Controls.Add(this.txtSensorsNextLoggingTime);
            this.panelSensorsSidebar.Controls.Add(this.lblSensorsNextLoggingTime);
            this.panelSensorsSidebar.Controls.Add(this.txtSensorsNextSampleTime);
            this.panelSensorsSidebar.Controls.Add(this.lblSensorsNextSampleTime);
            this.panelSensorsSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSensorsSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSensorsSidebar.Name = "panelSensorsSidebar";
            this.panelSensorsSidebar.Size = new System.Drawing.Size(200, 550);
            this.panelSensorsSidebar.TabIndex = 7;
            // 
            // panelSensorsMain
            // 
            this.panelSensorsMain.Controls.Add(this.flowSensorsMain);
            this.panelSensorsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSensorsMain.Location = new System.Drawing.Point(200, 0);
            this.panelSensorsMain.Name = "panelSensorsMain";
            this.panelSensorsMain.Size = new System.Drawing.Size(800, 550);
            this.panelSensorsMain.TabIndex = 8;
            // 
            // sensorControl1
            // 
            this.sensorControl1.Location = new System.Drawing.Point(10, 10);
            this.sensorControl1.Margin = new System.Windows.Forms.Padding(10);
            this.sensorControl1.Name = "sensorControl1";
            this.sensorControl1.SensorColor = System.Drawing.Color.DarkRed;
            this.sensorControl1.SensorIcon = ((System.Drawing.Image)(resources.GetObject("sensorControl1.SensorIcon")));
            this.sensorControl1.SensorName = "Sensor #1";
            this.sensorControl1.SensorValue = -0.12094D;
            this.sensorControl1.Size = new System.Drawing.Size(160, 215);
            this.sensorControl1.TabIndex = 0;
            // 
            // sensorControl2
            // 
            this.sensorControl2.Location = new System.Drawing.Point(190, 10);
            this.sensorControl2.Margin = new System.Windows.Forms.Padding(10);
            this.sensorControl2.Name = "sensorControl2";
            this.sensorControl2.SensorColor = System.Drawing.Color.Green;
            this.sensorControl2.SensorIcon = ((System.Drawing.Image)(resources.GetObject("sensorControl2.SensorIcon")));
            this.sensorControl2.SensorName = "Sensor #2";
            this.sensorControl2.SensorValue = 0.21552D;
            this.sensorControl2.Size = new System.Drawing.Size(160, 215);
            this.sensorControl2.TabIndex = 1;
            // 
            // sensorControl3
            // 
            this.sensorControl3.Location = new System.Drawing.Point(370, 10);
            this.sensorControl3.Margin = new System.Windows.Forms.Padding(10);
            this.sensorControl3.Name = "sensorControl3";
            this.sensorControl3.SensorColor = System.Drawing.Color.Brown;
            this.sensorControl3.SensorIcon = ((System.Drawing.Image)(resources.GetObject("sensorControl3.SensorIcon")));
            this.sensorControl3.SensorName = "Sensor #3";
            this.sensorControl3.SensorValue = 0.55D;
            this.sensorControl3.Size = new System.Drawing.Size(160, 215);
            this.sensorControl3.TabIndex = 2;
            // 
            // sensorControl4
            // 
            this.sensorControl4.Location = new System.Drawing.Point(550, 10);
            this.sensorControl4.Margin = new System.Windows.Forms.Padding(10);
            this.sensorControl4.Name = "sensorControl4";
            this.sensorControl4.SensorColor = System.Drawing.Color.CornflowerBlue;
            this.sensorControl4.SensorIcon = ((System.Drawing.Image)(resources.GetObject("sensorControl4.SensorIcon")));
            this.sensorControl4.SensorName = "Sensor #4";
            this.sensorControl4.SensorValue = 0.8978D;
            this.sensorControl4.Size = new System.Drawing.Size(160, 215);
            this.sensorControl4.TabIndex = 3;
            // 
            // sensorControl5
            // 
            this.sensorControl5.Location = new System.Drawing.Point(10, 245);
            this.sensorControl5.Margin = new System.Windows.Forms.Padding(10);
            this.sensorControl5.Name = "sensorControl5";
            this.sensorControl5.SensorColor = System.Drawing.Color.SteelBlue;
            this.sensorControl5.SensorIcon = ((System.Drawing.Image)(resources.GetObject("sensorControl5.SensorIcon")));
            this.sensorControl5.SensorName = "Sensor #5";
            this.sensorControl5.SensorValue = 0.77D;
            this.sensorControl5.Size = new System.Drawing.Size(160, 215);
            this.sensorControl5.TabIndex = 4;
            // 
            // sensorControl6
            // 
            this.sensorControl6.Location = new System.Drawing.Point(190, 245);
            this.sensorControl6.Margin = new System.Windows.Forms.Padding(10);
            this.sensorControl6.Name = "sensorControl6";
            this.sensorControl6.SensorColor = System.Drawing.Color.LightSeaGreen;
            this.sensorControl6.SensorIcon = ((System.Drawing.Image)(resources.GetObject("sensorControl6.SensorIcon")));
            this.sensorControl6.SensorName = "Sensor #6";
            this.sensorControl6.SensorValue = 0.21552D;
            this.sensorControl6.Size = new System.Drawing.Size(160, 215);
            this.sensorControl6.TabIndex = 5;
            // 
            // sensorControl7
            // 
            this.sensorControl7.Location = new System.Drawing.Point(370, 245);
            this.sensorControl7.Margin = new System.Windows.Forms.Padding(10);
            this.sensorControl7.Name = "sensorControl7";
            this.sensorControl7.SensorColor = System.Drawing.Color.Goldenrod;
            this.sensorControl7.SensorIcon = ((System.Drawing.Image)(resources.GetObject("sensorControl7.SensorIcon")));
            this.sensorControl7.SensorName = "Sensor #7";
            this.sensorControl7.SensorValue = 1D;
            this.sensorControl7.Size = new System.Drawing.Size(160, 215);
            this.sensorControl7.TabIndex = 6;
            // 
            // sensorControl8
            // 
            this.sensorControl8.Location = new System.Drawing.Point(550, 245);
            this.sensorControl8.Margin = new System.Windows.Forms.Padding(10);
            this.sensorControl8.Name = "sensorControl8";
            this.sensorControl8.SensorColor = System.Drawing.Color.DarkOrange;
            this.sensorControl8.SensorIcon = ((System.Drawing.Image)(resources.GetObject("sensorControl8.SensorIcon")));
            this.sensorControl8.SensorName = "Sensor #8";
            this.sensorControl8.SensorValue = 0.1245D;
            this.sensorControl8.Size = new System.Drawing.Size(160, 215);
            this.sensorControl8.TabIndex = 7;
            // 
            // sensorControl9
            // 
            this.sensorControl9.Location = new System.Drawing.Point(10, 480);
            this.sensorControl9.Margin = new System.Windows.Forms.Padding(10);
            this.sensorControl9.Name = "sensorControl9";
            this.sensorControl9.SensorColor = System.Drawing.Color.DarkOrchid;
            this.sensorControl9.SensorIcon = ((System.Drawing.Image)(resources.GetObject("sensorControl9.SensorIcon")));
            this.sensorControl9.SensorName = "Sensor #9";
            this.sensorControl9.SensorValue = 0.456D;
            this.sensorControl9.Size = new System.Drawing.Size(160, 215);
            this.sensorControl9.TabIndex = 8;
            // 
            // FormSensors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panelSensorsMain);
            this.Controls.Add(this.panelSensorsSidebar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSensors";
            this.Text = "FormSensors";
            this.flowSensorsMain.ResumeLayout(false);
            this.panelSensorsSidebar.ResumeLayout(false);
            this.panelSensorsSidebar.PerformLayout();
            this.panelSensorsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSensorsNextSampleTime;
        private System.Windows.Forms.TextBox txtSensorsNextSampleTime;
        private System.Windows.Forms.TextBox txtSensorsNextLoggingTime;
        private System.Windows.Forms.Label lblSensorsNextLoggingTime;
        private System.Windows.Forms.FlowLayoutPanel flowSensorsMain;
        private System.Windows.Forms.Panel panelSensorsSidebar;
        private System.Windows.Forms.Panel panelSensorsMain;
        private AssignmentOneApplication.SensorControl sensorControl1;
        private AssignmentOneApplication.SensorControl sensorControl2;
        private SensorControl sensorControl3;
        private SensorControl sensorControl4;
        private SensorControl sensorControl5;
        private SensorControl sensorControl6;
        private SensorControl sensorControl7;
        private SensorControl sensorControl8;
        private SensorControl sensorControl9;
    }
}