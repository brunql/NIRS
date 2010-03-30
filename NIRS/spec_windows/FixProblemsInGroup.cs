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

        private NIRS_Viewer.bind bind_father_spec = new NIRS_Viewer.bind();

        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn specidDataGridViewComboBoxColumn;

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Исправление зависимостей в группах";

            bind_father_spec.DataMember = "spec";
            dataBinding.DataMember = "group";

            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specidDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // specidDataGridViewComboBoxColumn
            // 
            this.specidDataGridViewComboBoxColumn.DataPropertyName = "spec_id";
            this.specidDataGridViewComboBoxColumn.DataSource = this.bind_father_spec;
            this.specidDataGridViewComboBoxColumn.DisplayMember = "name";
            this.specidDataGridViewComboBoxColumn.HeaderText = "Специальность";
            this.specidDataGridViewComboBoxColumn.Name = "specidDataGridViewTextBoxColumn";
            this.specidDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.specidDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.specidDataGridViewComboBoxColumn.ToolTipText = "специальность, на которой обучается группа";
            this.specidDataGridViewComboBoxColumn.ValueMember = "id";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Название";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ToolTipText = "название группы";


            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idDataGridViewTextBoxColumn,
									this.specidDataGridViewComboBoxColumn,
									this.codeDataGridViewTextBoxColumn});
        }
	}
}
