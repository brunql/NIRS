using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace NIRS
{
	public partial class FixProblemsInStudent : FixProblemsBaseForm
	{
        public FixProblemsInStudent(string filter_string) : base(filter_string) { }

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Исправление зависимостей в студентах";
            dataBinding.DataMember = "student";
            DataGridInitializer.InitStudent(dataGridView);
        }
	}
}
