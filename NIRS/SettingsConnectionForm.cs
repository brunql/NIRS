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
                txtPassword.Text = DBConnection.InstalledSettings.pwd;
                txtDB.Text = DBConnection.InstalledSettings.database;
            }
            else
            {
                txtHost.Text = DBSettings.DefaultSettings.host;
                txtPort.Text = DBSettings.DefaultSettings.port;
                txtUser.Text = DBSettings.DefaultSettings.user;
                txtPassword.Text = DBSettings.DefaultSettings.pwd;
                txtDB.Text = DBSettings.DefaultSettings.database;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // TODO:
            // Change NIRS_Viewer.Properties.Settings.nirsConnectionString and reinitialize NIRS_DataSet
            // Good luck :)

            DBSettings dbsettings = new DBSettings(
                txtHost.Text,
                txtPort.Text,
                txtUser.Text,
                txtPassword.Text,
                txtDB.Text
            );

            try
            {
                DBConnection.Connection(dbsettings);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
