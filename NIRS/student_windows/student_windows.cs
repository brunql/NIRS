﻿/*
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

namespace NIRS
{
	/// <summary>
	/// Description of student_windows.
	/// </summary>
	public partial class student_windows : Form
	{
		public student_windows()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void DataGridView_student_RowsWillRemoved()
		{
			string first_part_of_select_expression = "(student_id = ";
			string last_part_of_select_expression = ") OR ";
			StringBuilder variable = new StringBuilder();
			DataGridViewCell cell;
			int i;
			for( i= dataGridView_student.SelectedCells.Count-1; i>0; i--)
			{
				cell = dataGridView_student.SelectedCells[i];
				variable.Append( 
					first_part_of_select_expression +
					dataGridView_student.Rows[cell.RowIndex].Cells[0].Value.ToString() + 
					last_part_of_select_expression);
			}
			cell = dataGridView_student.SelectedCells[i];
			variable.Append(
				first_part_of_select_expression + 
				dataGridView_student.Rows[cell.RowIndex].Cells[0].Value.ToString() + 
				")"
			);
			bind_student_in_works_helpful.Filter = variable.ToString();
			if(bind_student_in_works_helpful.Count!=0)
			{
				(new fix_problem_in_works(variable.ToString())).ShowDialog();
			}
//			bind_student_in_student_helpful.Filter = variable.ToString();
//			if(bind_student_in_student_helpful.Count!=0)
//			{
//				(new fix_problem_in_student(variable.ToString())).ShowDialog();
//			}
		}
		
		void УдалитьВыбранныеToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dataGridView_student.SelectedRows.Count>0)
			{
				DataGridView_student_RowsWillRemoved();
				foreach(DataGridViewCell cell in dataGridView_student.SelectedCells)
				{
					if(cell.RowIndex!=-1)
					{
						dataGridView_student.Rows.RemoveAt(cell.RowIndex);
					}
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
		
		int visible_column_count;
		int visible_column_width;
		void student_windowsLoad(object sender, EventArgs e)
		{
			// hide "id" column
			dataGridView_student.Columns[0].Visible = false;
			
			toolsOpacityStatus.Value = (int)this.Opacity*100;
			
			visible_column_count = 0;
			foreach(DataColumn column in bind_student.current_DataTable.Columns)
			{
				if(column.ColumnMapping != MappingType.Hidden)
				{
					visible_column_count++;
					toolsFindIn.Items.Add(new strings_container(column.ColumnName, (string)column.Caption.Clone()));
				}
			}
			
			DataGridView_studentResize(null, null);
		}
		
		void ToolsFindItKeyUp(object sender, KeyEventArgs e)
		{
			if(toolsFindIt.Text=="")
			{
				bind_student.Filter = null;
				return;
			}
			if(toolsFindIn.SelectedIndex!=-1)
			{
				switch(toolsFindIn.Items[toolsFindIn.SelectedIndex].ToString())
				{
					case ("none") : bind_student.Filter = null; break;
					default : 
									bind_student.Filter =
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
				bind_student.Update();
			}
			catch{}
		}
		
		void DataGridView_studentResize(object sender, EventArgs e)
		{
			visible_column_width = (dataGridView_student.Width - 50)/ visible_column_count;
			foreach(DataGridViewColumn DGVcolumn in dataGridView_student.Columns)
			{
				if(DGVcolumn.Visible)
				{
					DGVcolumn.Width = visible_column_width;
				}
			}
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
		
		void DataGridView_studentRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			DataGridView_student_RowsWillRemoved();
		}
	}
}