
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
            this.lblSensorsNextSampleTime = new System.Windows.Forms.Label();
            this.txtSensorsNextSampleTime = new System.Windows.Forms.TextBox();
            this.txtSensorsNextLoggingTime = new System.Windows.Forms.TextBox();
            this.lblSensorsNextLoggingTime = new System.Windows.Forms.Label();
            this.flowSensorsMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSensorsSidebar = new System.Windows.Forms.Panel();
            this.panelSensorsMain = new System.Windows.Forms.Panel();
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
            this.txtSensorsNextSampleTime.ReadOnly = true;
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
            this.Load += new System.EventHandler(this.FormSensors_Load);
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
    }
}