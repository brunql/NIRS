﻿using System;
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
                txtHost.Text = DBConnection.DefaultSettings.host;
                txtPort.Text = DBConnection.DefaultSettings.port;
                txtUser.Text = DBConnection.DefaultSettings.user;
                txtPassword.Text = DBConnection.DefaultSettings.pwd;
                txtDB.Text = DBConnection.DefaultSettings.database;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
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
