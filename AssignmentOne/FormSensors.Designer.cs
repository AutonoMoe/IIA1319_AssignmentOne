
namespace AssignmentOne
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblSensorsNextSampleTime
            // 
            this.lblSensorsNextSampleTime.AutoSize = true;
            this.lblSensorsNextSampleTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSensorsNextSampleTime.Location = new System.Drawing.Point(13, 13);
            this.lblSensorsNextSampleTime.Name = "lblSensorsNextSampleTime";
            this.lblSensorsNextSampleTime.Size = new System.Drawing.Size(122, 17);
            this.lblSensorsNextSampleTime.TabIndex = 0;
            this.lblSensorsNextSampleTime.Text = "Next Sample Time";
            // 
            // txtSensorsNextSampleTime
            // 
            this.txtSensorsNextSampleTime.Location = new System.Drawing.Point(16, 34);
            this.txtSensorsNextSampleTime.Name = "txtSensorsNextSampleTime";
            this.txtSensorsNextSampleTime.Size = new System.Drawing.Size(150, 23);
            this.txtSensorsNextSampleTime.TabIndex = 1;
            this.txtSensorsNextSampleTime.Text = "2021-01-26 23:59:23";
            // 
            // txtSensorsNextLoggingTime
            // 
            this.txtSensorsNextLoggingTime.Location = new System.Drawing.Point(16, 101);
            this.txtSensorsNextLoggingTime.Name = "txtSensorsNextLoggingTime";
            this.txtSensorsNextLoggingTime.Size = new System.Drawing.Size(150, 23);
            this.txtSensorsNextLoggingTime.TabIndex = 3;
            this.txtSensorsNextLoggingTime.Text = "2021-01-26 23:59:23";
            // 
            // lblSensorsNextLoggingTime
            // 
            this.lblSensorsNextLoggingTime.AutoSize = true;
            this.lblSensorsNextLoggingTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSensorsNextLoggingTime.Location = new System.Drawing.Point(13, 80);
            this.lblSensorsNextLoggingTime.Name = "lblSensorsNextLoggingTime";
            this.lblSensorsNextLoggingTime.Size = new System.Drawing.Size(126, 17);
            this.lblSensorsNextLoggingTime.TabIndex = 2;
            this.lblSensorsNextLoggingTime.Text = "Next Logging Time";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(172, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(816, 504);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormSensors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtSensorsNextLoggingTime);
            this.Controls.Add(this.lblSensorsNextLoggingTime);
            this.Controls.Add(this.txtSensorsNextSampleTime);
            this.Controls.Add(this.lblSensorsNextSampleTime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSensors";
            this.Text = "FormSensors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSensorsNextSampleTime;
        private System.Windows.Forms.TextBox txtSensorsNextSampleTime;
        private System.Windows.Forms.TextBox txtSensorsNextLoggingTime;
        private System.Windows.Forms.Label lblSensorsNextLoggingTime;
        private System.Windows.Forms.ListView listView1;
    }
}