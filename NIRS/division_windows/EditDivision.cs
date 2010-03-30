using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace NIRS
{
	public partial class EditDivision : WindowsEditBaseForm
	{
		public EditDivision() : base ()
		{
		}

        private NIRS_Viewer.bind bind_division_mentor_helpful = new NIRS_Viewer.bind();
        private NIRS_Viewer.bind bind_division_spec_helpful = new NIRS_Viewer.bind();
        private NIRS_Viewer.bind bind_father_fac = new NIRS_Viewer.bind();
        

        private System.Windows.Forms.DataGridViewComboBoxColumn facidDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Редактирование кафедр";

            bind_division_mentor_helpful.DataMember = "mentor";
            bind_division_spec_helpful.DataMember = "spec";
            bind_father_fac.DataMember = "faculty";
            dataBinding.DataMember = "division";

            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            facidDataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();

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
            this.nameDataGridViewTextBoxColumn.ToolTipText = "Название кафедры";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Полное название кафедры";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ToolTipText = "Полное название кафедры";
            // 
            // facidDataGridViewComboBoxColumn
            // 
            this.facidDataGridViewComboBoxColumn.DataPropertyName = "fac_id";
            this.facidDataGridViewComboBoxColumn.DataSource = this.bind_father_fac;
            this.facidDataGridViewComboBoxColumn.DisplayMember = "fullname";
            this.facidDataGridViewComboBoxColumn.HeaderText = "Факультет";
            this.facidDataGridViewComboBoxColumn.Name = "facidDataGridViewComboBoxColumn";
            this.facidDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.facidDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.facidDataGridViewComboBoxColumn.ToolTipText = "Факультет, к которому принадлежит кафедра";
            this.facidDataGridViewComboBoxColumn.ValueMember = "id";

            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    this.idDataGridViewTextBoxColumn,
                    this.facidDataGridViewComboBoxColumn,
                    this.nameDataGridViewTextBoxColumn,
                    this.fullnameDataGridViewTextBoxColumn
                });
        }



		protected override void DataGridView_RowsRemoving()
		{
			StringBuilder variable = new StringBuilder();
			DataGridViewCell cell;
            for (int i = 0; i < dataGridView.SelectedCells.Count; i++)
            {
                cell = dataGridView.SelectedCells[i];
                variable.Append(
                    "(div_id = " +
                        dataGridView.Rows[cell.RowIndex].Cells[0].Value.ToString() +
                    ((i == dataGridView.SelectedCells.Count - 1) ? ")" : ") OR "));
            }

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
	}
}
