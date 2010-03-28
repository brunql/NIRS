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
	/// Description of division_windows.
	/// </summary>
	public partial class division_windows : Form
	{
		public division_windows()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
		
		int visible_column_count;
		int visible_column_width;
		void division_windowsLoad(object sender, EventArgs e)
		{
			// hide "id" column
			dataGridView_division.Columns[0].Visible = false;
			
			toolsOpacityStatus.Value = (int)this.Opacity*100;
			
			visible_column_count = 0;
			foreach(DataColumn column in bind_division.current_DataTable.Columns)
			{
				if(column.ColumnMapping != MappingType.Hidden)
				{
					visible_column_count++;
					toolsFindIn.Items.Add(new strings_container(column.ColumnName, (string)column.Caption.Clone()));
				}
			}
			
			DataGridView_divisionResize(null, null);
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
			try
			{
				bind_division.Update();
			}
			catch{}
		}
		
		void DataGridView_divisionResize(object sender, EventArgs e)
		{
			visible_column_width = (dataGridView_division.Width - 50)/ visible_column_count;
			foreach(DataGridViewColumn DGVcolumn in dataGridView_division.Columns)
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
		
		void DataGridView_divisionRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			DataGridView_division_RowsWillRemoved();
		}
	}
}