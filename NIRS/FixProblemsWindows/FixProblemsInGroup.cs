using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace NIRS
{
	public partial class FixProblemsInGroup : FixProblemsBaseForm
	{
        public FixProblemsInGroup(string filter_string) : base(filter_string) { }

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Исправление зависимостей в группах";
            dataBinding.DataMember = "group";
            DataGridInitializer.InitGroup(dataGridView);
        }
	}
}
