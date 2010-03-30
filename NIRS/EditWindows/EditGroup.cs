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
	/// Description of group_windows.
	/// </summary>
	public partial class EditGroup : WindowsEditBaseForm
	{
        public EditGroup() : base() { }

        private NIRS_Viewer.bind bind_group_in_student_helpful = new NIRS_Viewer.bind();
        private NIRS_Viewer.bind bind_father_spec = new NIRS_Viewer.bind();

        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn specidDataGridViewComboBoxColumn;

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Редактирование групп";

            bind_group_in_student_helpful.DataMember = "student";
            bind_father_spec.DataMember = "spec";
            dataBinding.DataMember = "group";

            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specidDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // specidDataGridViewComboBoxColumn
            // 
            this.specidDataGridViewComboBoxColumn.DataPropertyName = "spec_id";
            this.specidDataGridViewComboBoxColumn.DataSource = this.bind_father_spec;
            this.specidDataGridViewComboBoxColumn.DisplayMember = "name";
            this.specidDataGridViewComboBoxColumn.HeaderText = "Специальность";
            this.specidDataGridViewComboBoxColumn.Name = "specidDataGridViewTextBoxColumn";
            this.specidDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.specidDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.specidDataGridViewComboBoxColumn.ToolTipText = "специальность, на которой обучается группа";
            this.specidDataGridViewComboBoxColumn.ValueMember = "id";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Название";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ToolTipText = "название группы";


            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idDataGridViewTextBoxColumn,
									this.specidDataGridViewComboBoxColumn,
									this.codeDataGridViewTextBoxColumn});
        }
		
        protected override void DataGridView_RowsRemoving()
		{
			StringBuilder variable = new StringBuilder();
			DataGridViewCell cell;
            for (int i = 0; i < dataGridView.SelectedCells.Count; i++)
            {
                cell = dataGridView.SelectedCells[i];
                variable.Append(
                    "(group_id = " +
                        dataGridView.Rows[cell.RowIndex].Cells[0].Value.ToString() +
                    ((i == dataGridView.SelectedCells.Count - 1) ? ")" : ") OR "));
            }

			bind_group_in_student_helpful.Filter = variable.ToString();
			if(bind_group_in_student_helpful.Count!=0)
			{
                (new FixProblemsInStudent(variable.ToString())).ShowDialog();
			}
		}
	}
}
