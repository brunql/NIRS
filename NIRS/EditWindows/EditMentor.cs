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

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Редактирование руководителей";
            bind_mentor_in_works_helpful.DataMember = "works";
            dataBinding.DataMember = "mentor";

            DataGridInitializer.InitMentor(dataGridView);
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
                (new FixProblemsInWorks(variable.ToString())).ShowDialog();
			}
		}
	}
}
