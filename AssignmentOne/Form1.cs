using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentOne
{
    public partial class AssignmentOne : Form
    {

        private Form activeForm = null;

        public AssignmentOne()
        {
            InitializeComponent();
            InitializeSubMenus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeSubMenus()
        {
            panelSensorsSubMenu.Visible = false;
            panelMenuSelectionIndicator.Visible = false;
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

    }
}
