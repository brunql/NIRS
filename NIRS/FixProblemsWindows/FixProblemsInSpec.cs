/*
 * Created by SharpDevelop.
 * User: Администратор
 * Date: 21.03.2010
 * Time: 7:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace NIRS
{
	/// <summary>
	/// Description of fix_problem_in_spec.
	/// </summary>
	public partial class FixProblemsInSpec : FixProblemsBaseForm
	{
        public FixProblemsInSpec(string filter_string) : base(filter_string) { }

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Исправление зависимостей в специальностях";
            dataBinding.DataMember = "spec";
            DataGridInitializer.InitSpec(dataGridView);
        }
	}
}
