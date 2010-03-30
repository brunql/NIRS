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
			InitializeComponent();
            InitializeDataViewAndBindings();
			dataBinding.Filter = filter_string;
		}

        /// <summary>
        /// Override me to init dataBinding and dataGridView field
        /// </summary>
        protected virtual void InitializeDataViewAndBindings()
        {
            throw new NotImplementedException();
        }

		
		List<DataRow> kill_they = new List<DataRow>();
		void dataGridViewCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex!=-1 && e.RowIndex!=-1 && wasChanged)
			{
				change_list.Add(changed_row);
				wasChanged = false;
			}
		}
	
		
		List<DataRow> change_list = new List<DataRow>();
		DataRow changed_row;
		bool wasChanged = false;
		void dataGridViewCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			if(e.ColumnIndex!=-1 && e.RowIndex!=-1)
			{
				changed_row = ((DataRowView)dataBinding.List[e.RowIndex]).Row;
				wasChanged = true;
			}
		}

		void ToolStripFixed_Click(object sender, EventArgs e)
		{
			dataBinding.Save();
			this.Close();
		}

        void ToolStepBack_Click(object sender, EventArgs e)
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

		
		void FixProblemsBaseForm_Load(object sender, EventArgs e)
		{
			dataGridView.Columns[0].Visible = false;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
	}
}
