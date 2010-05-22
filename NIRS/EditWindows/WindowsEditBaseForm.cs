using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace NIRS
{
    public partial class WindowsEditBaseForm : Form
	{
        public WindowsEditBaseForm()
		{
            try
            {
                InitializeComponent();
                InitializeDataViewAndBindings();
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
		}

        /// <summary>
        /// Override me to init dataBinding and dataGridView field
        /// </summary>
        protected virtual void InitializeDataViewAndBindings()
        {
            throw new NotImplementedException();
        }
		
		void УдалитьВыбранныеToolStripMenuItemClick(object sender, EventArgs e)
		{
            try
            {
                DataGridView_RowsRemoving();
                foreach (DataGridViewCell cell in dataGridView.SelectedCells)
                {
                    if (cell.RowIndex != -1)
                    {
                        if (cell.RowIndex != dataGridView.Rows.Count - 1)
                            dataGridView.Rows.RemoveAt(cell.RowIndex);
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
		}
		
		void Faculty_windowsLoad(object sender, EventArgs e)
		{
            try
            {
                dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // hide "id" column
                dataGridView.Columns[0].Visible = false;

                toolsOpacityStatus.Value = (int)(this.Opacity * 100.0);

                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    DataColumn column = dataBinding.current_DataTable.Columns[i];
                    if (!column.ColumnName.Contains("id")) // TODO!!! contains id>??? u are crazy!! check it!!
                    {
                        toolsFindIn.Items.Add(new strings_container(column.ColumnName, dataGridView.Columns[i].HeaderText));
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
		}

        void ToolsFindInSelectedIndexChanged(object sender, EventArgs e) //ToolsFindItKeyUp
		{
            try
            {
                if (toolsFindIt.Text == "")
                {
                    dataBinding.Filter = null;
                    return;
                }
                if (toolsFindIn.SelectedIndex != -1)
                {
                    dataBinding.Filter = ((strings_container)toolsFindIn.SelectedItem).value +
                        " LIKE '" + toolsFindIt + "*'";
                }
                else
                {
                    dataBinding.Filter = null;
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
		}
		
		void ToolStripSaveClick(object sender, EventArgs e)
		{
            try
            {
                dataBinding.Save();
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
		}
		
		void ToolStripOpacityMinusClick(object sender, EventArgs e)
        {
            try
            {
                if (this.Opacity > 0.3)
                {
                    this.Opacity -= 0.1;
                    toolsOpacityStatus.Value = (int)(this.Opacity * 100.0);
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
            
		}
		
		void ToolsOpacityPlusClick(object sender, EventArgs e)
		{
            try
            {
                if (this.Opacity < 1.0)
                {
                    this.Opacity += 0.1;
                    toolsOpacityStatus.Value = (int)(this.Opacity * 100.0);
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
		}

        /// <summary>
        /// Override me!
        /// </summary>
        protected virtual void DataGridView_RowsRemoving()
        {
            throw new NotImplementedException();
        }




        private class strings_container
        {
            public string value;
            public string caption;
            public strings_container(string value, string caption)
            {
                this.value = value;
                this.caption = caption;
            }
            public override string ToString()
            {
                return caption;
            }
        }

        private void WindowsEditBaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                NIRS_Viewer.config.NIRS_DataSet.RejectChanges();
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
        }

	}
}
