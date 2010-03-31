using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace NIRS
{
	public partial class FixProblemsInDivision : FixProblemsBaseForm
	{
        public FixProblemsInDivision(string filter_string) : base(filter_string) { }

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Исправление зависимостей в кафедрах";
            dataBinding.DataMember = "division";
            DataGridInitializer.InitDivision(dataGridView);
        }
	}
}
