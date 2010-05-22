using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace NIRS
{
	public partial class FixProblemsBaseForm : Form
	{
        public FixProblemsBaseForm(string filter_string)
		{
            try
            {
                InitializeComponent();
                InitializeDataViewAndBindings();
                dataBinding.Filter = filter_string;
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

		
		List<DataRow> kill_they = new List<DataRow>();
		private void dataGridViewCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
            try
            {
                if (e.ColumnIndex != -1 && e.RowIndex != -1 && wasChanged)
                {
                    change_list.Add(changed_row);
                    wasChanged = false;
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
		}
	
		
		List<DataRow> change_list = new List<DataRow>();
		DataRow changed_row;
		bool wasChanged = false;
		private void dataGridViewCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
            try
            {
                if (e.ColumnIndex != -1 && e.RowIndex != -1)
                {
                    changed_row = ((DataRowView)dataBinding.List[e.RowIndex]).Row;
                    wasChanged = true;
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
		}

		void ToolStripFixed_Click(object sender, EventArgs e)
		{
            try
            {
                dataBinding.Save();
                this.Close();
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
		}

        void ToolStepBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (change_list.Count != 0)
                {
                    change_list.Reverse();
                    DataRow restored = change_list[0];
                    change_list.RemoveAt(0);
                    change_list.Reverse();
                    restored.RejectChanges();
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
        }

		
		void FixProblemsBaseForm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView.Columns[0].Visible = false;
                dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
		}
	}
}
