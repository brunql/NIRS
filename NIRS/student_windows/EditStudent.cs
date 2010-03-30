using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace NIRS
{
	public partial class EditStudent : WindowsEditBaseForm
	{
        public EditStudent() : base() { }

        private NIRS_Viewer.bind bind_student_in_works_helpful = new NIRS_Viewer.bind();
        private NIRS_Viewer.bind bind_father_group = new NIRS_Viewer.bind();
        

        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn groupidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bornDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grantDataGridViewTextBoxColumn;


        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Редактирование студентов";
            bind_student_in_works_helpful.DataMember = "works";
            bind_father_group.DataMember = "group";
            dataBinding.DataMember = "student";

            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bornDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();


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
            this.nameDataGridViewTextBoxColumn.ToolTipText = "имя студента";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ToolTipText = "фамилия студента";
            // 
            // fathernameDataGridViewTextBoxColumn
            // 
            this.fathernameDataGridViewTextBoxColumn.DataPropertyName = "fathername";
            this.fathernameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.fathernameDataGridViewTextBoxColumn.Name = "fathernameDataGridViewTextBoxColumn";
            this.fathernameDataGridViewTextBoxColumn.ToolTipText = "отчество студента";
            // 
            // groupidDataGridViewTextBoxColumn
            // 
            this.groupidDataGridViewTextBoxColumn.DataPropertyName = "group_id";
            this.groupidDataGridViewTextBoxColumn.DataSource = this.bind_father_group;
            this.groupidDataGridViewTextBoxColumn.DisplayMember = "code";
            this.groupidDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.groupidDataGridViewTextBoxColumn.Name = "groupidDataGridViewTextBoxColumn";
            this.groupidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.groupidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.groupidDataGridViewTextBoxColumn.ToolTipText = "группа, в которой учится студент";
            this.groupidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // bornDataGridViewTextBoxColumn
            // 
            this.bornDataGridViewTextBoxColumn.DataPropertyName = "born";
            this.bornDataGridViewTextBoxColumn.HeaderText = "Дата Рождения";
            this.bornDataGridViewTextBoxColumn.Name = "bornDataGridViewTextBoxColumn";
            this.bornDataGridViewTextBoxColumn.ToolTipText = "дата родления студента";
            // 
            // studyDataGridViewTextBoxColumn
            // 
            this.studyDataGridViewTextBoxColumn.DataPropertyName = "study";
            this.studyDataGridViewTextBoxColumn.HeaderText = "Форма обучения";
            this.studyDataGridViewTextBoxColumn.Name = "grantDataGridViewTextBoxColumn";
            // 
            // grantDataGridViewTextBoxColumn
            // 
            this.grantDataGridViewTextBoxColumn.DataPropertyName = "grant";
            this.grantDataGridViewTextBoxColumn.HeaderText = "Стипендия";
            this.grantDataGridViewTextBoxColumn.Name = "grantDataGridViewTextBoxColumn";



            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.fathernameDataGridViewTextBoxColumn,
            this.groupidDataGridViewTextBoxColumn,
            this.bornDataGridViewTextBoxColumn,
            this.studyDataGridViewTextBoxColumn,
            this.grantDataGridViewTextBoxColumn});
        }

		protected override void DataGridView_RowsRemoving()
		{
			StringBuilder variable = new StringBuilder();
			DataGridViewCell cell;
            for (int i = 0; i < dataGridView.SelectedCells.Count; i++)
            {
                cell = dataGridView.SelectedCells[i];
                variable.Append(
                    "(student_id = " +
                        dataGridView.Rows[cell.RowIndex].Cells[0].Value.ToString() +
                    ((i == dataGridView.SelectedCells.Count - 1) ? ")" : ") OR "));
            }
			bind_student_in_works_helpful.Filter = variable.ToString();
			if(bind_student_in_works_helpful.Count!=0)
			{
                (new FixProblemsInWorks(variable.ToString())).ShowDialog();
			}
		}
	}
}
