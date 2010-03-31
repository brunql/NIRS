using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace NIRS
{
	public partial class FixProblemsInWorks : FixProblemsBaseForm
	{
        public FixProblemsInWorks(string filter_string) : base(filter_string) { }

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Исправление зависимостей в научных работах";
            dataBinding.DataMember = "works";
            DataGridInitializer.InitWorks(dataGridView);
        }
	}
}
