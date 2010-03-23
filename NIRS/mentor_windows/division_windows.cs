/*
 * Created by SharpDevelop.
 * User: Администратор
 * Date: 21.03.2010
 * Time: 6:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace NIRS_database
{
	/// <summary>
	/// Description of division_windows.
	/// </summary>
	public partial class division_windows : Form
	{
		public division_windows()
		{
			InitializeComponent();
		}
		
		void DataGridView_division_RowsWillRemoved()
		{
			string first_part_of_select_expression = "(div_id = ";
			string last_part_of_select_expression = ") OR ";
			StringBuilder variable = new StringBuilder();
			DataGridViewCell cell;
			int i;
			for( i= dataGridView_division.SelectedCells.Count-1; i>0; i--)
			{
				cell = dataGridView_division.SelectedCells[i];
				variable.Append( 
					first_part_of_select_expression +
					dataGridView_division.Rows[cell.RowIndex].Cells[0].Value.ToString() + 
					last_part_of_select_expression);
			}
			cell = dataGridView_division.SelectedCells[i];
			variable.Append(
				first_part_of_select_expression + 
				dataGridView_division.Rows[cell.RowIndex].Cells[0].Value.ToString() + 
				")"
			);
			bind_division_mentor_helpful.Filter = variable.ToString();
			if(bind_division_mentor_helpful.Count!=0)
			{
				(new fix_problem_in_mentor(variable.ToString())).ShowDialog();
			}
			bind_division_spec_helpful.Filter = variable.ToString();
			if(bind_division_mentor_helpful.Count!=0)
			{
				(new fix_problem_in_spec(variable.ToString())).ShowDialog();
			}
		}
		
		void УдалитьВыбранныеToolStripMenuItemClick(object sender, EventArgs e)
		{
			DataGridView_division_RowsWillRemoved();
			foreach(DataGridViewCell cell in dataGridView_division.SelectedCells)
			{
				if(cell.RowIndex!=-1)
				{
					dataGridView_division.Rows.RemoveAt(cell.RowIndex);
				}
			}
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
		
        //int visible_column_count;
        //int visible_column_width;
		void division_windowsLoad(object sender, EventArgs e)
		{
			// hide "id" column
			dataGridView_division.Columns[0].Visible = false;
			
            //visible_column_count = 0;
			foreach(DataColumn column in bind_division.current_DataTable.Columns)
			{
				if(column.ColumnMapping != MappingType.Hidden)
				{
                    //visible_column_count++;
					toolsFindIn.Items.Add(new strings_container(column.ColumnName, (string)column.Caption.Clone()));
				}
			}

            dataGridView_division.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
		
		void ToolsFindItKeyUp(object sender, KeyEventArgs e)
		{
			if(toolsFindIt.Text=="")
			{
				bind_division.Filter = null;
				return;
			}
			if(toolsFindIn.SelectedIndex!=-1)
			{
				switch(toolsFindIn.Items[toolsFindIn.SelectedIndex].ToString())
				{
					case ("none") : bind_division.Filter = null; break;
					default : 
									bind_division.Filter =
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
			bind_division.Update();
		}
		
		void DataGridView_divisionResize(object sender, EventArgs e)
		{
            //dataGridView_division.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
	}
}
