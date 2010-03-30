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
	/// Description of EditFaculty.
	/// </summary>
	public partial class EditFaculty : WindowsEditBaseForm
	{
		public EditFaculty() : base ()
		{
		}
		
        private NIRS_Viewer.bind bind_division_del_helpful = new NIRS_Viewer.bind();
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Редактирование факультетов";

            bind_division_del_helpful.DataMember = "division";
            dataBinding.DataMember = "faculty";

            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ToolTipText = "Название факультета";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Полное название факультета";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ToolTipText = "Полное название факультета";


            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    this.idDataGridViewTextBoxColumn,
                    this.nameDataGridViewTextBoxColumn,
                    this.fullnameDataGridViewTextBoxColumn
                });
        }

		protected override void DataGridView_RowsRemoving()
		{
			StringBuilder variable = new StringBuilder();
			DataGridViewCell cell;
			for(int i = 0; i < dataGridView.SelectedCells.Count; i++)
			{
				cell = dataGridView.SelectedCells[i];
				variable.Append(
                    "(fac_id = " +
					    dataGridView.Rows[cell.RowIndex].Cells[0].Value.ToString() +
                    ((i == dataGridView.SelectedCells.Count - 1) ? ")" : ") OR "));
			}
			bind_division_del_helpful.Filter = variable.ToString();
			if(bind_division_del_helpful.Count!=0)
			{
				(new fix_problem_in_division(variable.ToString())).ShowDialog();
			}
		}
	}
}
