
namespace AssignmentOne
{
    partial class FormAbout
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
            this.lblAboutMadeBy = new System.Windows.Forms.Label();
            this.txtAboutMadeBy = new System.Windows.Forms.TextBox();
            this.txtAboutSubject = new System.Windows.Forms.TextBox();
            this.lblAboutSubject = new System.Windows.Forms.Label();
            this.txtAboutAssignment = new System.Windows.Forms.TextBox();
            this.lblAboutAssignment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAboutMadeBy
            // 
            this.lblAboutMadeBy.AutoSize = true;
            this.lblAboutMadeBy.ForeColor = System.Drawing.Color.White;
            this.lblAboutMadeBy.Location = new System.Drawing.Point(12, 80);
            this.lblAboutMadeBy.Name = "lblAboutMadeBy";
            this.lblAboutMadeBy.Size = new System.Drawing.Size(71, 17);
            this.lblAboutMadeBy.TabIndex = 0;
            this.lblAboutMadeBy.Text = "Made By: ";
            // 
            // txtAboutMadeBy
            // 
            this.txtAboutMadeBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.txtAboutMadeBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAboutMadeBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAboutMadeBy.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtAboutMadeBy.Location = new System.Drawing.Point(120, 81);
            this.txtAboutMadeBy.Name = "txtAboutMadeBy";
            this.txtAboutMadeBy.Size = new System.Drawing.Size(800, 16);
            this.txtAboutMadeBy.TabIndex = 1;
            this.txtAboutMadeBy.Text = "Ronnie André Horne Moe";
            // 
            // txtAboutSubject
            // 
            this.txtAboutSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.txtAboutSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAboutSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAboutSubject.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtAboutSubject.Location = new System.Drawing.Point(120, 27);
            this.txtAboutSubject.Name = "txtAboutSubject";
            this.txtAboutSubject.Size = new System.Drawing.Size(800, 16);
            this.txtAboutSubject.TabIndex = 3;
            this.txtAboutSubject.Text = "IIA1319 - Software Engineering";
            // 
            // lblAboutSubject
            // 
            this.lblAboutSubject.AutoSize = true;
            this.lblAboutSubject.ForeColor = System.Drawing.Color.White;
            this.lblAboutSubject.Location = new System.Drawing.Point(12, 26);
            this.lblAboutSubject.Name = "lblAboutSubject";
            this.lblAboutSubject.Size = new System.Drawing.Size(59, 17);
            this.lblAboutSubject.TabIndex = 2;
            this.lblAboutSubject.Text = "Subject:";
            // 
            // txtAboutAssignment
            // 
            this.txtAboutAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.txtAboutAssignment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAboutAssignment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAboutAssignment.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtAboutAssignment.Location = new System.Drawing.Point(120, 54);
            this.txtAboutAssignment.Name = "txtAboutAssignment";
            this.txtAboutAssignment.Size = new System.Drawing.Size(800, 16);
            this.txtAboutAssignment.TabIndex = 5;
            this.txtAboutAssignment.Text = "Assignment #1: DAQ Simulator";
            // 
            // lblAboutAssignment
            // 
            this.lblAboutAssignment.AutoSize = true;
            this.lblAboutAssignment.ForeColor = System.Drawing.Color.White;
            this.lblAboutAssignment.Location = new System.Drawing.Point(12, 53);
            this.lblAboutAssignment.Name = "lblAboutAssignment";
            this.lblAboutAssignment.Size = new System.Drawing.Size(85, 17);
            this.lblAboutAssignment.TabIndex = 4;
            this.lblAboutAssignment.Text = "Assignment:";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.txtAboutAssignment);
            this.Controls.Add(this.lblAboutAssignment);
            this.Controls.Add(this.txtAboutSubject);
            this.Controls.Add(this.lblAboutSubject);
            this.Controls.Add(this.txtAboutMadeBy);
            this.Controls.Add(this.lblAboutMadeBy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAbout";
            this.Text = "FormAbout";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAboutMadeBy;
        private System.Windows.Forms.TextBox txtAboutMadeBy;
        private System.Windows.Forms.TextBox txtAboutSubject;
        private System.Windows.Forms.Label lblAboutSubject;
        private System.Windows.Forms.TextBox txtAboutAssignment;
        private System.Windows.Forms.Label lblAboutAssignment;
    }
}