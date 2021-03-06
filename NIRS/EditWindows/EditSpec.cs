﻿using System;
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
        
        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Редактирование специальностей";

            bind_spec_in_group_helpful.DataMember = "group";
            dataBinding.DataMember = "spec";

            DataGridInitializer.InitSpec(dataGridView);

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
