
namespace AssignmentOne
{
    partial class AssignmentOne
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
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panelMenuSelectionIndicator = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.panelSensorsSubMenu = new System.Windows.Forms.Panel();
            this.btnLogging = new System.Windows.Forms.Button();
            this.btnSampling = new System.Windows.Forms.Button();
            this.btnSensors = new System.Windows.Forms.Button();
            this.panelApplicationTitle = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblApplicationTitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMainLogo = new System.Windows.Forms.Panel();
            this.lblMainLogoTitle = new System.Windows.Forms.Label();
            this.panelSideBar.SuspendLayout();
            this.panelSensorsSubMenu.SuspendLayout();
            this.panelApplicationTitle.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.Controls.Add(this.panelMenuSelectionIndicator);
            this.panelSideBar.Controls.Add(this.btnAbout);
            this.panelSideBar.Controls.Add(this.btnConfiguration);
            this.panelSideBar.Controls.Add(this.panelSensorsSubMenu);
            this.panelSideBar.Controls.Add(this.btnSensors);
            this.panelSideBar.Controls.Add(this.panelApplicationTitle);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(250, 700);
            this.panelSideBar.TabIndex = 0;
            // 
            // panelMenuSelectionIndicator
            // 
            this.panelMenuSelectionIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenuSelectionIndicator.BackColor = System.Drawing.Color.White;
            this.panelMenuSelectionIndicator.Location = new System.Drawing.Point(235, 100);
            this.panelMenuSelectionIndicator.Name = "panelMenuSelectionIndicator";
            this.panelMenuSelectionIndicator.Size = new System.Drawing.Size(15, 45);
            this.panelMenuSelectionIndicator.TabIndex = 5;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(0, 270);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(250, 45);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguration.FlatAppearance.BorderSize = 0;
            this.btnConfiguration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnConfiguration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.btnConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguration.Location = new System.Drawing.Point(0, 225);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConfiguration.Size = new System.Drawing.Size(250, 45);
            this.btnConfiguration.TabIndex = 3;
            this.btnConfiguration.Text = "Configuration";
            this.btnConfiguration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguration.UseVisualStyleBackColor = true;
            this.btnConfiguration.Click += new System.EventHandler(this.btnConfiguration_Click);
            // 
            // panelSensorsSubMenu
            // 
            this.panelSensorsSubMenu.Controls.Add(this.btnLogging);
            this.panelSensorsSubMenu.Controls.Add(this.btnSampling);
            this.panelSensorsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSensorsSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelSensorsSubMenu.Name = "panelSensorsSubMenu";
            this.panelSensorsSubMenu.Size = new System.Drawing.Size(250, 80);
            this.panelSensorsSubMenu.TabIndex = 2;
            // 
            // btnLogging
            // 
            this.btnLogging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.btnLogging.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogging.FlatAppearance.BorderSize = 0;
            this.btnLogging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogging.Location = new System.Drawing.Point(0, 40);
            this.btnLogging.Name = "btnLogging";
            this.btnLogging.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLogging.Size = new System.Drawing.Size(250, 40);
            this.btnLogging.TabIndex = 1;
            this.btnLogging.Text = "Start Logging";
            this.btnLogging.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogging.UseVisualStyleBackColor = false;
            // 
            // btnSampling
            // 
            this.btnSampling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.btnSampling.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSampling.FlatAppearance.BorderSize = 0;
            this.btnSampling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSampling.Location = new System.Drawing.Point(0, 0);
            this.btnSampling.Name = "btnSampling";
            this.btnSampling.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSampling.Size = new System.Drawing.Size(250, 40);
            this.btnSampling.TabIndex = 0;
            this.btnSampling.Text = "Start Sampling";
            this.btnSampling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSampling.UseVisualStyleBackColor = false;
            // 
            // btnSensors
            // 
            this.btnSensors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSensors.FlatAppearance.BorderSize = 0;
            this.btnSensors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnSensors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.btnSensors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSensors.Location = new System.Drawing.Point(0, 100);
            this.btnSensors.Name = "btnSensors";
            this.btnSensors.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSensors.Size = new System.Drawing.Size(250, 45);
            this.btnSensors.TabIndex = 1;
            this.btnSensors.Text = "Sensors";
            this.btnSensors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSensors.UseVisualStyleBackColor = true;
            this.btnSensors.Click += new System.EventHandler(this.btnSensors_Click);
            // 
            // panelApplicationTitle
            // 
            this.panelApplicationTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.panelApplicationTitle.Controls.Add(this.panelLogo);
            this.panelApplicationTitle.Controls.Add(this.lblApplicationTitle);
            this.panelApplicationTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelApplicationTitle.Location = new System.Drawing.Point(0, 0);
            this.panelApplicationTitle.Name = "panelApplicationTitle";
            this.panelApplicationTitle.Size = new System.Drawing.Size(250, 100);
            this.panelApplicationTitle.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.panelLogo.BackgroundImage = global::AssignmentOne.Properties.Resources.plug_128;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Location = new System.Drawing.Point(93, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(64, 64);
            this.panelLogo.TabIndex = 1;
            // 
            // lblApplicationTitle
            // 
            this.lblApplicationTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.lblApplicationTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblApplicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationTitle.ForeColor = System.Drawing.Color.White;
            this.lblApplicationTitle.Location = new System.Drawing.Point(0, 68);
            this.lblApplicationTitle.Name = "lblApplicationTitle";
            this.lblApplicationTitle.Size = new System.Drawing.Size(250, 32);
            this.lblApplicationTitle.TabIndex = 0;
            this.lblApplicationTitle.Text = "DAQ Simulator";
            this.lblApplicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(950, 100);
            this.panelTitleBar.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.btnExit.BackgroundImage = global::AssignmentOne.Properties.Resources.close_window_64;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Location = new System.Drawing.Point(915, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(950, 100);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelMainLogo);
            this.panelMain.Controls.Add(this.lblMainLogoTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(950, 600);
            this.panelMain.TabIndex = 3;
            // 
            // panelMainLogo
            // 
            this.panelMainLogo.BackgroundImage = global::AssignmentOne.Properties.Resources.plug_128;
            this.panelMainLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMainLogo.Location = new System.Drawing.Point(416, 128);
            this.panelMainLogo.Name = "panelMainLogo";
            this.panelMainLogo.Size = new System.Drawing.Size(128, 128);
            this.panelMainLogo.TabIndex = 3;
            // 
            // lblMainLogoTitle
            // 
            this.lblMainLogoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainLogoTitle.ForeColor = System.Drawing.Color.White;
            this.lblMainLogoTitle.Location = new System.Drawing.Point(355, 259);
            this.lblMainLogoTitle.Name = "lblMainLogoTitle";
            this.lblMainLogoTitle.Size = new System.Drawing.Size(250, 32);
            this.lblMainLogoTitle.TabIndex = 2;
            this.lblMainLogoTitle.Text = "DAQ Simulator";
            this.lblMainLogoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AssignmentOne
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelSideBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "AssignmentOne";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment One";
            this.TopMost = true;
            this.panelSideBar.ResumeLayout(false);
            this.panelSensorsSubMenu.ResumeLayout(false);
            this.panelApplicationTitle.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelApplicationTitle;
        private System.Windows.Forms.Button btnSensors;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblApplicationTitle;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnConfiguration;
        private System.Windows.Forms.Panel panelSensorsSubMenu;
        private System.Windows.Forms.Button btnLogging;
        private System.Windows.Forms.Button btnSampling;
        private System.Windows.Forms.Panel panelMenuSelectionIndicator;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelMainLogo;
        private System.Windows.Forms.Label lblMainLogoTitle;
    }
}

