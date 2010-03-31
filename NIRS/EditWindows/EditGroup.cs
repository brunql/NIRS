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

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Редактирование групп";

            bind_group_in_student_helpful.DataMember = "student";
            dataBinding.DataMember = "group";

            DataGridInitializer.InitGroup(dataGridView);
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
