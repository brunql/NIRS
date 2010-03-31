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

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Редактирование студентов";
            bind_student_in_works_helpful.DataMember = "works";
            dataBinding.DataMember = "student";

            DataGridInitializer.InitStudent(dataGridView);
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
