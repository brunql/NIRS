/*
 * Created by SharpDevelop.
 * User: Администратор
 * Date: 21.03.2010
 * Time: 7:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace NIRS
{
	/// <summary>
	/// Description of fix_problem_in_division.
	/// </summary>
	public partial class fix_problem_in_division : Form
	{
		public fix_problem_in_division(string filter_string)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			bind_division.Filter = filter_string;
		}
		
		List<DataRow> kill_they = new List<DataRow>();
		void DataGridView_divisionCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex!=-1 && e.RowIndex!=-1 && wasChanged)
			{
				change_list.Add(changed_row);
				wasChanged = false;
			}
		}
		
		void ToolsStepBackClick(object sender, EventArgs e)
		{
			if(change_list.Count!=0)
			{
				change_list.Reverse();
				DataRow restored = change_list[0];
				change_list.RemoveAt(0);
				change_list.Reverse();
				restored.RejectChanges();
			}
		}
		
		List<DataRow> change_list = new List<DataRow>();
		DataRow changed_row;
		bool wasChanged = false;
		void DataGridView_divisionCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			if(e.ColumnIndex!=-1 && e.RowIndex!=-1)
			{
				changed_row = ((DataRowView)bind_division.List[e.RowIndex]).Row;
				wasChanged = true;
			}
		}
		
		void ToolStripFixedClick(object sender, EventArgs e)
		{
			bind_division.Save();
			this.Close();
		}
		
		void Fix_problem_in_divisionLoad(object sender, EventArgs e)
		{
			dataGridView_division.Columns[0].Visible = false;
		}
	}
}
