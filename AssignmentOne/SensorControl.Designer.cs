
namespace AssignmentOneApplication
{
    partial class SensorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SensorControl));
            this.panelSensorTop = new System.Windows.Forms.Panel();
            this.lblSensorName = new System.Windows.Forms.Label();
            this.picSensorIcon = new System.Windows.Forms.PictureBox();
            this.panelSensorData = new System.Windows.Forms.Panel();
            this.txtSensorValue = new System.Windows.Forms.Label();
            this.lblSensorValue = new System.Windows.Forms.Label();
            this.panelSensorTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSensorIcon)).BeginInit();
            this.panelSensorData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSensorTop
            // 
            this.panelSensorTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.panelSensorTop.Controls.Add(this.lblSensorName);
            this.panelSensorTop.Controls.Add(this.picSensorIcon);
            this.panelSensorTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSensorTop.Location = new System.Drawing.Point(0, 0);
            this.panelSensorTop.Name = "panelSensorTop";
            this.panelSensorTop.Size = new System.Drawing.Size(160, 120);
            this.panelSensorTop.TabIndex = 0;
            // 
            // lblSensorName
            // 
            this.lblSensorName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSensorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensorName.ForeColor = System.Drawing.Color.White;
            this.lblSensorName.Location = new System.Drawing.Point(0, 90);
            this.lblSensorName.Name = "lblSensorName";
            this.lblSensorName.Size = new System.Drawing.Size(160, 30);
            this.lblSensorName.TabIndex = 1;
            this.lblSensorName.Text = "Sensor Name";
            this.lblSensorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSensorIcon
            // 
            this.picSensorIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.picSensorIcon.Image = ((System.Drawing.Image)(resources.GetObject("picSensorIcon.Image")));
            this.picSensorIcon.Location = new System.Drawing.Point(0, 0);
            this.picSensorIcon.Name = "picSensorIcon";
            this.picSensorIcon.Padding = new System.Windows.Forms.Padding(10);
            this.picSensorIcon.Size = new System.Drawing.Size(160, 90);
            this.picSensorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSensorIcon.TabIndex = 0;
            this.picSensorIcon.TabStop = false;
            // 
            // panelSensorData
            // 
            this.panelSensorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.panelSensorData.Controls.Add(this.txtSensorValue);
            this.panelSensorData.Controls.Add(this.lblSensorValue);
            this.panelSensorData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSensorData.Location = new System.Drawing.Point(0, 120);
            this.panelSensorData.Name = "panelSensorData";
            this.panelSensorData.Size = new System.Drawing.Size(160, 95);
            this.panelSensorData.TabIndex = 1;
            // 
            // txtSensorValue
            // 
            this.txtSensorValue.BackColor = System.Drawing.Color.Transparent;
            this.txtSensorValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSensorValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtSensorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSensorValue.ForeColor = System.Drawing.Color.White;
            this.txtSensorValue.Location = new System.Drawing.Point(0, 23);
            this.txtSensorValue.Margin = new System.Windows.Forms.Padding(3);
            this.txtSensorValue.Name = "txtSensorValue";
            this.txtSensorValue.Size = new System.Drawing.Size(160, 72);
            this.txtSensorValue.TabIndex = 1;
            this.txtSensorValue.Text = "0.5 V";
            this.txtSensorValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblSensorValue
            // 
            this.lblSensorValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSensorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensorValue.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSensorValue.Location = new System.Drawing.Point(0, 0);
            this.lblSensorValue.Name = "lblSensorValue";
            this.lblSensorValue.Size = new System.Drawing.Size(160, 23);
            this.lblSensorValue.TabIndex = 0;
            this.lblSensorValue.Text = "Sensor Value";
            this.lblSensorValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SensorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSensorData);
            this.Controls.Add(this.panelSensorTop);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "SensorControl";
            this.Size = new System.Drawing.Size(160, 215);
            this.panelSensorTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSensorIcon)).EndInit();
            this.panelSensorData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSensorTop;
        private System.Windows.Forms.Label lblSensorName;
        private System.Windows.Forms.PictureBox picSensorIcon;
        private System.Windows.Forms.Panel panelSensorData;
        private System.Windows.Forms.Label lblSensorValue;
        private System.Windows.Forms.Label txtSensorValue;
    }
}
