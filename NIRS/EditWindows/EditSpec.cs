using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace NIRS
{
	public partial class EditSpec : WindowsEditBaseForm
	{
        public EditSpec() : base() { }

        private NIRS_Viewer.bind bind_spec_in_group_helpful = new NIRS_Viewer.bind();
        private NIRS_Viewer.bind bind_father_division = new NIRS_Viewer.bind();

        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dividDataGridViewTextBoxColumn;


        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Редактирование специальностей";

            bind_spec_in_group_helpful.DataMember = "group";
            bind_father_division.DataMember = "division";
            dataBinding.DataMember = "spec";

            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dividDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dividDataGridViewTextBoxColumn
            // 
            this.dividDataGridViewTextBoxColumn.DataPropertyName = "div_id";
            this.dividDataGridViewTextBoxColumn.DataSource = this.bind_father_division;
            this.dividDataGridViewTextBoxColumn.DisplayMember = "name";
            this.dividDataGridViewTextBoxColumn.HeaderText = "Кафедра";
            this.dividDataGridViewTextBoxColumn.Name = "dividDataGridViewTextBoxColumn";
            this.dividDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dividDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dividDataGridViewTextBoxColumn.ToolTipText = "кафедра, на которой обучают специальности";
            this.dividDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ToolTipText = "код специальности";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ToolTipText = "название специальности";

            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idDataGridViewTextBoxColumn,
									this.dividDataGridViewTextBoxColumn,
									this.codeDataGridViewTextBoxColumn,
									this.nameDataGridViewTextBoxColumn});

        }
		
		protected override void DataGridView_RowsRemoving()
		{
			StringBuilder variable = new StringBuilder();
			DataGridViewCell cell;
            for (int i = 0; i < dataGridView.SelectedCells.Count; i++)
            {
                cell = dataGridView.SelectedCells[i];
                variable.Append(
                    "(spec_id = " +
                        dataGridView.Rows[cell.RowIndex].Cells[0].Value.ToString() +
                    ((i == dataGridView.SelectedCells.Count - 1) ? ")" : ") OR "));
            }
			bind_spec_in_group_helpful.Filter = variable.ToString();
			if(bind_spec_in_group_helpful.Count!=0)
			{
                (new FixProblemsInGroup(variable.ToString())).ShowDialog();
			}
		}
	}
}
