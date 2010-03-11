using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NIRS_DB;

namespace NIRS
{
    public partial class SettingsConnectionForm : Form
    {
        public SettingsConnectionForm()
        {
            InitializeComponent();
            if (DBConnection.InstalledSettings != null)
            {
                txtHost.Text = DBConnection.InstalledSettings.host;
                txtPort.Text = DBConnection.InstalledSettings.port;
                txtUser.Text = DBConnection.InstalledSettings.user;
                txtPassword.Text = "";
                txtDB.Text = DBConnection.InstalledSettings.database;
            }
            else
            {
                txtHost.Text = "localhost";
                txtPort.Text = "3306";
                txtUser.Text = "root";
                txtPassword.Text = "";
                txtDB.Text = "nirs";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DBSettings dbsettings = new DBSettings();
            dbsettings.host = txtHost.Text;
            dbsettings.port = txtPort.Text;
            dbsettings.user = txtUser.Text;
            dbsettings.pwd = txtPassword.Text;
            dbsettings.database = txtDB.Text;

            try
            {
                DBConnection.Connection(dbsettings);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
