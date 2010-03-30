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
			InitializeComponent();
            InitializeDataViewAndBindings();
		}

        /// <summary>
        /// Override me to init dataBinding field
        /// </summary>
        protected virtual void InitializeDataViewAndBindings()
        {
            throw new NotImplementedException();
        }
		
		void УдалитьВыбранныеToolStripMenuItemClick(object sender, EventArgs e)
		{
            DataGridView_RowsRemoving();
			foreach(DataGridViewCell cell in dataGridView.SelectedCells)
			{
				if(cell.RowIndex!=-1)
				{
					if(cell.RowIndex != dataGridView.Rows.Count - 1)
                        dataGridView.Rows.RemoveAt(cell.RowIndex);
				}
			}
		}
		
		void Faculty_windowsLoad(object sender, EventArgs e)
		{
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // hide "id" column
            dataGridView.Columns[0].Visible = false;
			
			toolsOpacityStatus.Value = (int)(this.Opacity*100.0);
			
			for(int i=0; i < dataGridView.Columns.Count; i++)
			{
                DataColumn column = dataBinding.current_DataTable.Columns[i];
				if(!column.ColumnName.Contains("id"))
				{
                    toolsFindIn.Items.Add(new strings_container(column.ColumnName, dataGridView.Columns[i].HeaderText + column.ColumnName));
				}
			}
		}
		
		void ToolsFindItKeyUp(object sender, KeyEventArgs e)
		{
			if(toolsFindIt.Text=="")
			{
				dataBinding.Filter = null;
				return;
			}
			if(toolsFindIn.SelectedIndex!=-1)
			{
				switch(toolsFindIn.Items[toolsFindIn.SelectedIndex].ToString())
				{
					case ("none") : dataBinding.Filter = null; break;
					default : 
									dataBinding.Filter =
										((strings_container)toolsFindIn.SelectedItem).value +
										" LIKE '" + toolsFindIt + "*'";
									break;
				}
			}
		}
		
		void ToolsFindInSelectedIndexChanged(object sender, EventArgs e)
		{
			ToolsFindItKeyUp(null, null);
		}
		
		void ToolStripSaveClick(object sender, EventArgs e)
		{
			try
			{
				dataBinding.Save();
			}
			catch{}
		}
		
		void ToolStripOpacityMinusClick(object sender, EventArgs e)
		{
			if(this.Opacity>0.3)
			{
				this.Opacity -= 0.1;
				toolsOpacityStatus.Value = (int)(this.Opacity*100.0);
			}
		}
		
		void ToolsOpacityPlusClick(object sender, EventArgs e)
		{
			if(this.Opacity<1.0)
			{
				this.Opacity += 0.1;
				toolsOpacityStatus.Value = (int)(this.Opacity*100.0);
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

	}
}
