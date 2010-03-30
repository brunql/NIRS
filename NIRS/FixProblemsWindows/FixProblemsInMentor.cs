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

        private NIRS_Viewer.bind bind_father_division = new NIRS_Viewer.bind();

        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dividDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acrankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Исправление зависимостей в руководителях";
            bind_father_division.DataMember = "division";
            dataBinding.DataMember = "mentor";

            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dividDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.acrankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ToolTipText = "Имя научного руководителя";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ToolTipText = "Фамилия научного руководителя";
            // 
            // fathernameDataGridViewTextBoxColumn
            // 
            this.fathernameDataGridViewTextBoxColumn.DataPropertyName = "fathername";
            this.fathernameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.fathernameDataGridViewTextBoxColumn.Name = "fathernameDataGridViewTextBoxColumn";
            this.fathernameDataGridViewTextBoxColumn.ToolTipText = "Отчество научного руководителя";
            // 
            // workDataGridViewTextBoxColumn
            // 
            this.workDataGridViewTextBoxColumn.DataPropertyName = "work";
            this.workDataGridViewTextBoxColumn.HeaderText = "Место работы";
            this.workDataGridViewTextBoxColumn.Name = "workDataGridViewTextBoxColumn";
            this.workDataGridViewTextBoxColumn.ToolTipText = "Место работы куратора";
            // 
            // dividDataGridViewComboBoxColumn
            // 
            this.dividDataGridViewComboBoxColumn.DataPropertyName = "div_id";
            this.dividDataGridViewComboBoxColumn.DataSource = this.bind_father_division;
            this.dividDataGridViewComboBoxColumn.DisplayMember = "fullname";
            this.dividDataGridViewComboBoxColumn.HeaderText = "Кафедра";
            this.dividDataGridViewComboBoxColumn.Name = "dividDataGridViewComboBoxColumn";
            this.dividDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dividDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dividDataGridViewComboBoxColumn.ToolTipText = "Кафедра, на которой работает этот научный руководитель";
            this.dividDataGridViewComboBoxColumn.ValueMember = "id";
            // 
            // acrankDataGridViewTextBoxColumn
            // 
            this.acrankDataGridViewTextBoxColumn.DataPropertyName = "acrank";
            this.acrankDataGridViewTextBoxColumn.HeaderText = "Учёное звание";
            this.acrankDataGridViewTextBoxColumn.Name = "acrankDataGridViewTextBoxColumn";
            this.acrankDataGridViewTextBoxColumn.ToolTipText = "Ученое звание научного руководителя";
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            this.degreeDataGridViewTextBoxColumn.DataPropertyName = "degree";
            this.degreeDataGridViewTextBoxColumn.HeaderText = "Учёная степень";
            this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            this.degreeDataGridViewTextBoxColumn.ToolTipText = "учёная степень научного руководителя";


            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    this.idDataGridViewTextBoxColumn,
                    this.nameDataGridViewTextBoxColumn,
                    this.surnameDataGridViewTextBoxColumn,
                    this.fathernameDataGridViewTextBoxColumn,
                    this.workDataGridViewTextBoxColumn,
                    this.acrankDataGridViewTextBoxColumn,
                    this.degreeDataGridViewTextBoxColumn,
                    this.dividDataGridViewComboBoxColumn});
        }
	}
}
