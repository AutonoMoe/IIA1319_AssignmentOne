
namespace AssignmentOneApplication
{
    partial class FormConfiguration
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
            this.lblConfigNumberOfAnalog = new System.Windows.Forms.Label();
            this.txtConfigNumberOfAnalog = new System.Windows.Forms.TextBox();
            this.txtConfigNumberOfDigital = new System.Windows.Forms.TextBox();
            this.lblConfigNumberOfDigital = new System.Windows.Forms.Label();
            this.txtConfigSamplingTime = new System.Windows.Forms.TextBox();
            this.lblConfigSamplingTime = new System.Windows.Forms.Label();
            this.txtConfigLoggingTime = new System.Windows.Forms.TextBox();
            this.lblConfigLoggingTime = new System.Windows.Forms.Label();
            this.txtConfigDaqInputVoltageMin = new System.Windows.Forms.TextBox();
            this.lblConfigDaqInputVoltage = new System.Windows.Forms.Label();
            this.txtConfigDaqInputVoltageMax = new System.Windows.Forms.TextBox();
            this.lblConfigDaqInputVoltageSep = new System.Windows.Forms.Label();
            this.txtConfigDaqResolution = new System.Windows.Forms.TextBox();
            this.lblConfigDaqResolution = new System.Windows.Forms.Label();
            this.lblConfigFilterType = new System.Windows.Forms.Label();
            this.radioConfigFilterType1 = new System.Windows.Forms.RadioButton();
            this.radioConfigFilterType2 = new System.Windows.Forms.RadioButton();
            this.lblConfigLogFileDateTime = new System.Windows.Forms.Label();
            this.checkBoxConfigDateTimeInLogFileName = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblConfigNumberOfAnalog
            // 
            this.lblConfigNumberOfAnalog.AutoSize = true;
            this.lblConfigNumberOfAnalog.ForeColor = System.Drawing.Color.White;
            this.lblConfigNumberOfAnalog.Location = new System.Drawing.Point(13, 13);
            this.lblConfigNumberOfAnalog.Name = "lblConfigNumberOfAnalog";
            this.lblConfigNumberOfAnalog.Size = new System.Drawing.Size(176, 17);
            this.lblConfigNumberOfAnalog.TabIndex = 0;
            this.lblConfigNumberOfAnalog.Text = "Number of Analog Devices";
            // 
            // txtConfigNumberOfAnalog
            // 
            this.txtConfigNumberOfAnalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtConfigNumberOfAnalog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfigNumberOfAnalog.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtConfigNumberOfAnalog.Location = new System.Drawing.Point(16, 33);
            this.txtConfigNumberOfAnalog.Name = "txtConfigNumberOfAnalog";
            this.txtConfigNumberOfAnalog.Size = new System.Drawing.Size(52, 16);
            this.txtConfigNumberOfAnalog.TabIndex = 1;
            this.txtConfigNumberOfAnalog.TextChanged += new System.EventHandler(this.txtConfigNumberOfAnalog_TextChanged);
            // 
            // txtConfigNumberOfDigital
            // 
            this.txtConfigNumberOfDigital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtConfigNumberOfDigital.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfigNumberOfDigital.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtConfigNumberOfDigital.Location = new System.Drawing.Point(16, 93);
            this.txtConfigNumberOfDigital.Name = "txtConfigNumberOfDigital";
            this.txtConfigNumberOfDigital.Size = new System.Drawing.Size(52, 16);
            this.txtConfigNumberOfDigital.TabIndex = 3;
            this.txtConfigNumberOfDigital.TextChanged += new System.EventHandler(this.txtConfigNumberOfDigital_TextChanged);
            // 
            // lblConfigNumberOfDigital
            // 
            this.lblConfigNumberOfDigital.AutoSize = true;
            this.lblConfigNumberOfDigital.ForeColor = System.Drawing.Color.White;
            this.lblConfigNumberOfDigital.Location = new System.Drawing.Point(13, 73);
            this.lblConfigNumberOfDigital.Name = "lblConfigNumberOfDigital";
            this.lblConfigNumberOfDigital.Size = new System.Drawing.Size(171, 17);
            this.lblConfigNumberOfDigital.TabIndex = 2;
            this.lblConfigNumberOfDigital.Text = "Number of Digital Devices";
            // 
            // txtConfigSamplingTime
            // 
            this.txtConfigSamplingTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtConfigSamplingTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfigSamplingTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtConfigSamplingTime.Location = new System.Drawing.Point(16, 153);
            this.txtConfigSamplingTime.Name = "txtConfigSamplingTime";
            this.txtConfigSamplingTime.Size = new System.Drawing.Size(52, 16);
            this.txtConfigSamplingTime.TabIndex = 5;
            this.txtConfigSamplingTime.TextChanged += new System.EventHandler(this.txtConfigSamplingTime_TextChanged);
            // 
            // lblConfigSamplingTime
            // 
            this.lblConfigSamplingTime.AutoSize = true;
            this.lblConfigSamplingTime.ForeColor = System.Drawing.Color.White;
            this.lblConfigSamplingTime.Location = new System.Drawing.Point(13, 133);
            this.lblConfigSamplingTime.Name = "lblConfigSamplingTime";
            this.lblConfigSamplingTime.Size = new System.Drawing.Size(137, 17);
            this.lblConfigSamplingTime.TabIndex = 4;
            this.lblConfigSamplingTime.Text = "Sampling Time (sec)";
            // 
            // txtConfigLoggingTime
            // 
            this.txtConfigLoggingTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtConfigLoggingTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfigLoggingTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtConfigLoggingTime.Location = new System.Drawing.Point(16, 213);
            this.txtConfigLoggingTime.Name = "txtConfigLoggingTime";
            this.txtConfigLoggingTime.Size = new System.Drawing.Size(52, 16);
            this.txtConfigLoggingTime.TabIndex = 7;
            this.txtConfigLoggingTime.TextChanged += new System.EventHandler(this.txtConfigLoggingTime_TextChanged);
            // 
            // lblConfigLoggingTime
            // 
            this.lblConfigLoggingTime.AutoSize = true;
            this.lblConfigLoggingTime.ForeColor = System.Drawing.Color.White;
            this.lblConfigLoggingTime.Location = new System.Drawing.Point(13, 193);
            this.lblConfigLoggingTime.Name = "lblConfigLoggingTime";
            this.lblConfigLoggingTime.Size = new System.Drawing.Size(130, 17);
            this.lblConfigLoggingTime.TabIndex = 6;
            this.lblConfigLoggingTime.Text = "Logging Time (sec)";
            // 
            // txtConfigDaqInputVoltageMin
            // 
            this.txtConfigDaqInputVoltageMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtConfigDaqInputVoltageMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfigDaqInputVoltageMin.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtConfigDaqInputVoltageMin.Location = new System.Drawing.Point(300, 33);
            this.txtConfigDaqInputVoltageMin.Name = "txtConfigDaqInputVoltageMin";
            this.txtConfigDaqInputVoltageMin.Size = new System.Drawing.Size(52, 16);
            this.txtConfigDaqInputVoltageMin.TabIndex = 9;
            this.txtConfigDaqInputVoltageMin.TextChanged += new System.EventHandler(this.txtConfigDaqInputVoltageMin_TextChanged);
            // 
            // lblConfigDaqInputVoltage
            // 
            this.lblConfigDaqInputVoltage.AutoSize = true;
            this.lblConfigDaqInputVoltage.ForeColor = System.Drawing.Color.White;
            this.lblConfigDaqInputVoltage.Location = new System.Drawing.Point(297, 13);
            this.lblConfigDaqInputVoltage.Name = "lblConfigDaqInputVoltage";
            this.lblConfigDaqInputVoltage.Size = new System.Drawing.Size(125, 17);
            this.lblConfigDaqInputVoltage.TabIndex = 8;
            this.lblConfigDaqInputVoltage.Text = "DAQ Input Voltage";
            // 
            // txtConfigDaqInputVoltageMax
            // 
            this.txtConfigDaqInputVoltageMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtConfigDaqInputVoltageMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfigDaqInputVoltageMax.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtConfigDaqInputVoltageMax.Location = new System.Drawing.Point(370, 33);
            this.txtConfigDaqInputVoltageMax.Name = "txtConfigDaqInputVoltageMax";
            this.txtConfigDaqInputVoltageMax.Size = new System.Drawing.Size(52, 16);
            this.txtConfigDaqInputVoltageMax.TabIndex = 10;
            this.txtConfigDaqInputVoltageMax.TextChanged += new System.EventHandler(this.txtConfigDaqInputVoltageMax_TextChanged);
            // 
            // lblConfigDaqInputVoltageSep
            // 
            this.lblConfigDaqInputVoltageSep.AutoSize = true;
            this.lblConfigDaqInputVoltageSep.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblConfigDaqInputVoltageSep.Location = new System.Drawing.Point(354, 33);
            this.lblConfigDaqInputVoltageSep.Name = "lblConfigDaqInputVoltageSep";
            this.lblConfigDaqInputVoltageSep.Size = new System.Drawing.Size(13, 17);
            this.lblConfigDaqInputVoltageSep.TabIndex = 11;
            this.lblConfigDaqInputVoltageSep.Text = "-";
            // 
            // txtConfigDaqResolution
            // 
            this.txtConfigDaqResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtConfigDaqResolution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfigDaqResolution.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtConfigDaqResolution.Location = new System.Drawing.Point(300, 93);
            this.txtConfigDaqResolution.Name = "txtConfigDaqResolution";
            this.txtConfigDaqResolution.Size = new System.Drawing.Size(52, 16);
            this.txtConfigDaqResolution.TabIndex = 13;
            this.txtConfigDaqResolution.TextChanged += new System.EventHandler(this.txtConfigDaqResolution_TextChanged);
            // 
            // lblConfigDaqResolution
            // 
            this.lblConfigDaqResolution.AutoSize = true;
            this.lblConfigDaqResolution.ForeColor = System.Drawing.Color.White;
            this.lblConfigDaqResolution.Location = new System.Drawing.Point(297, 73);
            this.lblConfigDaqResolution.Name = "lblConfigDaqResolution";
            this.lblConfigDaqResolution.Size = new System.Drawing.Size(145, 17);
            this.lblConfigDaqResolution.TabIndex = 12;
            this.lblConfigDaqResolution.Text = "DAQ Resolution (bits)";
            // 
            // lblConfigFilterType
            // 
            this.lblConfigFilterType.AutoSize = true;
            this.lblConfigFilterType.ForeColor = System.Drawing.Color.White;
            this.lblConfigFilterType.Location = new System.Drawing.Point(297, 133);
            this.lblConfigFilterType.Name = "lblConfigFilterType";
            this.lblConfigFilterType.Size = new System.Drawing.Size(139, 17);
            this.lblConfigFilterType.TabIndex = 14;
            this.lblConfigFilterType.Text = "Low Pass Filter Type";
            // 
            // radioConfigFilterType1
            // 
            this.radioConfigFilterType1.AutoSize = true;
            this.radioConfigFilterType1.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioConfigFilterType1.Location = new System.Drawing.Point(300, 153);
            this.radioConfigFilterType1.Name = "radioConfigFilterType1";
            this.radioConfigFilterType1.Size = new System.Drawing.Size(86, 21);
            this.radioConfigFilterType1.TabIndex = 15;
            this.radioConfigFilterType1.TabStop = true;
            this.radioConfigFilterType1.Text = "Low Pass";
            this.radioConfigFilterType1.UseVisualStyleBackColor = true;
            this.radioConfigFilterType1.CheckedChanged += new System.EventHandler(this.radioConfigFilterType1_CheckedChanged);
            // 
            // radioConfigFilterType2
            // 
            this.radioConfigFilterType2.AutoSize = true;
            this.radioConfigFilterType2.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioConfigFilterType2.Location = new System.Drawing.Point(300, 180);
            this.radioConfigFilterType2.Name = "radioConfigFilterType2";
            this.radioConfigFilterType2.Size = new System.Drawing.Size(128, 21);
            this.radioConfigFilterType2.TabIndex = 16;
            this.radioConfigFilterType2.TabStop = true;
            this.radioConfigFilterType2.Text = "Moving Average";
            this.radioConfigFilterType2.UseVisualStyleBackColor = true;
            this.radioConfigFilterType2.CheckedChanged += new System.EventHandler(this.radioConfigFilterType2_CheckedChanged);
            // 
            // lblConfigLogFileDateTime
            // 
            this.lblConfigLogFileDateTime.AutoSize = true;
            this.lblConfigLogFileDateTime.ForeColor = System.Drawing.Color.White;
            this.lblConfigLogFileDateTime.Location = new System.Drawing.Point(581, 13);
            this.lblConfigLogFileDateTime.Name = "lblConfigLogFileDateTime";
            this.lblConfigLogFileDateTime.Size = new System.Drawing.Size(183, 17);
            this.lblConfigLogFileDateTime.TabIndex = 17;
            this.lblConfigLogFileDateTime.Text = "Date/Time in Log File Name";
            // 
            // checkBoxConfigDateTimeInLogFileName
            // 
            this.checkBoxConfigDateTimeInLogFileName.AutoSize = true;
            this.checkBoxConfigDateTimeInLogFileName.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxConfigDateTimeInLogFileName.Location = new System.Drawing.Point(584, 34);
            this.checkBoxConfigDateTimeInLogFileName.Name = "checkBoxConfigDateTimeInLogFileName";
            this.checkBoxConfigDateTimeInLogFileName.Size = new System.Drawing.Size(54, 21);
            this.checkBoxConfigDateTimeInLogFileName.TabIndex = 18;
            this.checkBoxConfigDateTimeInLogFileName.Text = "OFF";
            this.checkBoxConfigDateTimeInLogFileName.UseVisualStyleBackColor = true;
            this.checkBoxConfigDateTimeInLogFileName.CheckedChanged += new System.EventHandler(this.checkBoxConfigDateTimeInLogFileName_CheckedChanged);
            // 
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.checkBoxConfigDateTimeInLogFileName);
            this.Controls.Add(this.lblConfigLogFileDateTime);
            this.Controls.Add(this.radioConfigFilterType2);
            this.Controls.Add(this.radioConfigFilterType1);
            this.Controls.Add(this.lblConfigFilterType);
            this.Controls.Add(this.txtConfigDaqResolution);
            this.Controls.Add(this.lblConfigDaqResolution);
            this.Controls.Add(this.lblConfigDaqInputVoltageSep);
            this.Controls.Add(this.txtConfigDaqInputVoltageMax);
            this.Controls.Add(this.txtConfigDaqInputVoltageMin);
            this.Controls.Add(this.lblConfigDaqInputVoltage);
            this.Controls.Add(this.txtConfigLoggingTime);
            this.Controls.Add(this.lblConfigLoggingTime);
            this.Controls.Add(this.txtConfigSamplingTime);
            this.Controls.Add(this.lblConfigSamplingTime);
            this.Controls.Add(this.txtConfigNumberOfDigital);
            this.Controls.Add(this.lblConfigNumberOfDigital);
            this.Controls.Add(this.txtConfigNumberOfAnalog);
            this.Controls.Add(this.lblConfigNumberOfAnalog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormConfiguration";
            this.Text = "FormConfiguration";
            this.Load += new System.EventHandler(this.FormConfiguration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfigNumberOfAnalog;
        private System.Windows.Forms.TextBox txtConfigNumberOfAnalog;
        private System.Windows.Forms.TextBox txtConfigNumberOfDigital;
        private System.Windows.Forms.Label lblConfigNumberOfDigital;
        private System.Windows.Forms.TextBox txtConfigSamplingTime;
        private System.Windows.Forms.Label lblConfigSamplingTime;
        private System.Windows.Forms.TextBox txtConfigLoggingTime;
        private System.Windows.Forms.Label lblConfigLoggingTime;
        private System.Windows.Forms.TextBox txtConfigDaqInputVoltageMin;
        private System.Windows.Forms.Label lblConfigDaqInputVoltage;
        private System.Windows.Forms.TextBox txtConfigDaqInputVoltageMax;
        private System.Windows.Forms.Label lblConfigDaqInputVoltageSep;
        private System.Windows.Forms.TextBox txtConfigDaqResolution;
        private System.Windows.Forms.Label lblConfigDaqResolution;
        private System.Windows.Forms.Label lblConfigFilterType;
        private System.Windows.Forms.RadioButton radioConfigFilterType1;
        private System.Windows.Forms.RadioButton radioConfigFilterType2;
        private System.Windows.Forms.Label lblConfigLogFileDateTime;
        private System.Windows.Forms.CheckBox checkBoxConfigDateTimeInLogFileName;
    }
}