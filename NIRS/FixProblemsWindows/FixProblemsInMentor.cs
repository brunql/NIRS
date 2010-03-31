using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace NIRS
{
	public partial class FixProblemsInMentor : FixProblemsBaseForm
	{
        public FixProblemsInMentor(string filter_string) : base(filter_string) { }

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Исправление зависимостей в руководителях";
            dataBinding.DataMember = "mentor";
            DataGridInitializer.InitMentor(dataGridView);
        }
	}
}
