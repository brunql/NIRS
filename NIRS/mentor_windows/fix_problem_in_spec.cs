﻿/*
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

namespace NIRS_database
{
	/// <summary>
	/// Description of fix_problem_in_spec.
	/// </summary>
	public partial class fix_problem_in_spec : Form
	{
		public fix_problem_in_spec(string filter_string)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			bind_spec.Filter = filter_string;
		}
		
		List<DataRow> kill_they = new List<DataRow>();
		void DataGridView_specCellValueChanged(object sender, DataGridViewCellEventArgs e)
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
		void DataGridView_specCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			if(e.ColumnIndex!=-1 && e.RowIndex!=-1)
			{
				changed_row = ((DataRowView)bind_spec.List[e.RowIndex]).Row;
				wasChanged = true;
			}
		}
		
		void ToolStripFixedClick(object sender, EventArgs e)
		{
			bind_spec.Update();
			this.Close();
		}
		
		int visible_column_count;
		int visible_column_width;
		void Fix_problem_in_specLoad(object sender, EventArgs e)
		{
			dataGridView_spec.Columns[0].Visible = false;
			
			visible_column_count = 0;
			foreach(DataColumn column in bind_spec.current_DataTable.Columns)
			{
				if(column.ColumnMapping != MappingType.Hidden)
				{
					visible_column_count++;
				}
			}
			DataGridView_specResize(null,null);
		}
		
		void DataGridView_specResize(object sender, EventArgs e)
		{
			visible_column_width = (dataGridView_spec.Width - 50)/ visible_column_count;
			foreach(DataGridViewColumn DGVcolumn in dataGridView_spec.Columns)
			{
				if(DGVcolumn.Visible)
				{
					DGVcolumn.Width = visible_column_width;
				}
			}
		}
	}
}