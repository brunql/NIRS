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

namespace NIRS
{
	/// <summary>
	/// Description of faculty_windows.
	/// </summary>
	public partial class faculty_windows : WindowsEditBaseForm
	{
		public faculty_windows()
		{
			base.InitializeComponent();
		}
		
        private NIRS_Viewer.bind bind_division_del_helpful = new NIRS_Viewer.bind();

        protected override void InitializeDataBindings()
        {
            bind_division_del_helpful.DataMember = "division";
            dataBinding.DataMember = "faculty";
            dataBinding.Save();
        }

		protected override void DataGridView_RowsRemoving()
		{
			string first_part_of_select_expression = "(fac_id = ";
			string last_part_of_select_expression = ") OR ";
			StringBuilder variable = new StringBuilder();
			DataGridViewCell cell;
			int i;
			for( i= dataGridView.SelectedCells.Count-1; i>0; i--)
			{
				cell = dataGridView.SelectedCells[i];
				variable.Append( 
					first_part_of_select_expression +
					dataGridView.Rows[cell.RowIndex].Cells[0].Value.ToString() + 
					last_part_of_select_expression);
			}
			cell = dataGridView.SelectedCells[i];
			variable.Append(
				first_part_of_select_expression + 
				dataGridView.Rows[cell.RowIndex].Cells[0].Value.ToString() + 
				")"
			);
			bind_division_del_helpful.Filter = variable.ToString();
			if(bind_division_del_helpful.Count!=0)
			{
				(new fix_problem_in_division(variable.ToString())).ShowDialog();
			}
		}
		
        //void УдалитьВыбранныеToolStripMenuItemClick(object sender, EventArgs e)
        //{
        //    DataGridView_faculty_RowsWillRemoved();
        //    foreach(DataGridViewCell cell in dataGridView_faculty.SelectedCells)
        //    {
        //        if(cell.RowIndex!=-1)
        //        {
        //            dataGridView_faculty.Rows.RemoveAt(cell.RowIndex);
        //        }
        //    }
        //}
		
        //private class strings_container
        //{
        //    public string value;
        //    public string caption;
        //    public strings_container(string value, string caption)
        //    {
        //        this.value = value;
        //        this.caption = caption;
        //    }
        //    public override string ToString()
        //    {
        //        return caption;
        //    }
        //}
		
        //void Faculty_windowsLoad(object sender, EventArgs e)
        //{
        //    // hide "id" column
        //    dataGridView_faculty.Columns[0].Visible = false;
			
        //    toolsOpacityStatus.Value = (int)(this.Opacity*100.0);
			
        //    foreach(DataColumn column in bind_faculty.current_DataTable.Columns)
        //    {
        //        if(column.ColumnMapping != MappingType.Hidden)
        //        {
        //            toolsFindIn.Items.Add(new strings_container(column.ColumnName, (string)column.Caption.Clone()));
        //        }
        //    }
        //}
		
        //void ToolsFindItKeyUp(object sender, KeyEventArgs e)
        //{
        //    if(toolsFindIt.Text=="")
        //    {
        //        bind_faculty.Filter = null;
        //        return;
        //    }
        //    if(toolsFindIn.SelectedIndex!=-1)
        //    {
        //        switch(toolsFindIn.Items[toolsFindIn.SelectedIndex].ToString())
        //        {
        //            case ("none") : bind_faculty.Filter = null; break;
        //            default : 
        //                            bind_faculty.Filter =
        //                                ((strings_container)toolsFindIn.SelectedItem).value +
        //                                " LIKE '" + toolsFindIt + "*'";
        //                            break;
        //        }
        //    }
        //}
		
        //void ToolsFindInSelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ToolsFindItKeyUp(null, null);
        //}
		
        //void ToolStripSaveClick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        bind_faculty.Save();
        //    }
        //    catch{}
        //}
		
        //void ToolStripOpacityMinusClick(object sender, EventArgs e)
        //{
        //    if(this.Opacity>0.3)
        //    {
        //        this.Opacity -= 0.1;
        //        toolsOpacityStatus.Value = (int)(this.Opacity*100.0);
        //    }
        //}
		
        //void ToolsOpacityPlusClick(object sender, EventArgs e)
        //{
        //    if(this.Opacity<1.0)
        //    {
        //        this.Opacity += 0.1;
        //        toolsOpacityStatus.Value = (int)(this.Opacity*100.0);
        //    }
        //}
		
        //void DataGridView_facultyRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        //{
        //    DataGridView_faculty_RowsWillRemoved();
        //}
	}
}
