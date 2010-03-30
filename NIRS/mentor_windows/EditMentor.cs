using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace NIRS
{
	public partial class EditMentor : WindowsEditBaseForm
	{
        public EditMentor() : base() { }

        private NIRS_Viewer.bind bind_mentor_in_works_helpful = new NIRS_Viewer.bind();
        private NIRS_Viewer.bind bind_father_division = new NIRS_Viewer.bind();

        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dividDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acrankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Редактирование руководителей";
            bind_mentor_in_works_helpful.DataMember = "works";
            bind_father_division.DataMember = "division";
            dataBinding.DataMember = "mentor";

            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dividDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.acrankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

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
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ToolTipText = "имя научного руководителя";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ToolTipText = "фамилия научного руководителя";
            // 
            // fathernameDataGridViewTextBoxColumn
            // 
            this.fathernameDataGridViewTextBoxColumn.DataPropertyName = "fathername";
            this.fathernameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.fathernameDataGridViewTextBoxColumn.Name = "fathernameDataGridViewTextBoxColumn";
            this.fathernameDataGridViewTextBoxColumn.ToolTipText = "отчество научного руководителя";
            // 
            // workDataGridViewTextBoxColumn
            // 
            this.workDataGridViewTextBoxColumn.DataPropertyName = "work";
            this.workDataGridViewTextBoxColumn.HeaderText = "Работы";
            this.workDataGridViewTextBoxColumn.Name = "workDataGridViewTextBoxColumn";
            this.workDataGridViewTextBoxColumn.ToolTipText = "работы, курировавшиеся этим научным руководителем";
            // 
            // dividDataGridViewComboBoxColumn
            // 
            this.dividDataGridViewComboBoxColumn.DataPropertyName = "div_id";
            this.dividDataGridViewComboBoxColumn.DataSource = this.bind_father_division;
            this.dividDataGridViewComboBoxColumn.DisplayMember = "fullname";
            this.dividDataGridViewComboBoxColumn.HeaderText = "Кафедра";
            this.dividDataGridViewComboBoxColumn.Name = "dividDataGridViewComboBoxColumn";
            this.dividDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dividDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dividDataGridViewComboBoxColumn.ToolTipText = "Кафедра, на которой работает этот научный руководитель";
            this.dividDataGridViewComboBoxColumn.ValueMember = "id";
            // 
            // acrankDataGridViewTextBoxColumn
            // 
            this.acrankDataGridViewTextBoxColumn.DataPropertyName = "acrank";
            this.acrankDataGridViewTextBoxColumn.HeaderText = "Академический Ранг";
            this.acrankDataGridViewTextBoxColumn.Name = "acrankDataGridViewTextBoxColumn";
            this.acrankDataGridViewTextBoxColumn.ToolTipText = "академический ранг научного руководителя";
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            this.degreeDataGridViewTextBoxColumn.DataPropertyName = "degree";
            this.degreeDataGridViewTextBoxColumn.HeaderText = "Учёная Степень";
            this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            this.degreeDataGridViewTextBoxColumn.ToolTipText = "учёная степень научного руководителя";


            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    this.idDataGridViewTextBoxColumn,
                    this.nameDataGridViewTextBoxColumn,
                    this.surnameDataGridViewTextBoxColumn,
                    this.fathernameDataGridViewTextBoxColumn,
                    this.workDataGridViewTextBoxColumn,
                    this.dividDataGridViewComboBoxColumn,
                    this.acrankDataGridViewTextBoxColumn,
                    this.degreeDataGridViewTextBoxColumn});
        }
		
		protected override void  DataGridView_RowsRemoving()
		{
			StringBuilder variable = new StringBuilder();
			DataGridViewCell cell;
            for (int i = 0; i < dataGridView.SelectedCells.Count; i++)
            {
                cell = dataGridView.SelectedCells[i];
                variable.Append(
                    "(mentor_id = " +
                        dataGridView.Rows[cell.RowIndex].Cells[0].Value.ToString() +
                    ((i == dataGridView.SelectedCells.Count - 1) ? ")" : ") OR "));
            }

			bind_mentor_in_works_helpful.Filter = variable.ToString();
			if(bind_mentor_in_works_helpful.Count!=0)
			{
				(new fix_problem_in_works(variable.ToString())).ShowDialog();
			}
		}
	}
}
