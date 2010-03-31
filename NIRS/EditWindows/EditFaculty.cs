using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace NIRS
{
	public partial class EditFaculty : WindowsEditBaseForm
	{
		public EditFaculty() : base ()
		{
		}
		
        private NIRS_Viewer.bind bind_division_del_helpful = new NIRS_Viewer.bind();

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Редактирование факультетов";

            bind_division_del_helpful.DataMember = "division";
            dataBinding.DataMember = "faculty";

            DataGridInitializer.InitFaculty(dataGridView);
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
				(new FixProblemsInDivision(variable.ToString())).ShowDialog();
			}
		}
	}
}
