using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace NIRS
{
    public partial class EditWorks : WindowsEditBaseForm
    {
        public EditWorks() : base() { }

        private NIRS_Viewer.bind bind_mentor_helpful = new NIRS_Viewer.bind();
        private NIRS_Viewer.bind bind_student_helpful = new NIRS_Viewer.bind();

        private System.Windows.Forms.DataGridViewComboBoxColumn mentoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Редактирование научных работ";

            bind_student_helpful.DataMember = "student";
            bind_mentor_helpful.DataMember = "mentor";
            dataBinding.DataMember = "works";

            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mentoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();

            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.DataSource = this.bind_student_helpful;
            this.studentidDataGridViewTextBoxColumn.DisplayMember = "surname";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "Студент";
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            this.studentidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.studentidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.studentidDataGridViewTextBoxColumn.ToolTipText = "Выбор студента, сделавшего работу";
            this.studentidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ToolTipText = "Название научной работы";
            // 
            // descDataGridViewTextBoxColumn
            // 
            this.descDataGridViewTextBoxColumn.DataPropertyName = "desc";
            this.descDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descDataGridViewTextBoxColumn.Name = "descDataGridViewTextBoxColumn";
            this.descDataGridViewTextBoxColumn.ToolTipText = "Описание научной работы";
            // 
            // mentoridDataGridViewTextBoxColumn
            // 
            this.mentoridDataGridViewTextBoxColumn.DataPropertyName = "mentor_id";
            this.mentoridDataGridViewTextBoxColumn.DataSource = this.bind_mentor_helpful;
            this.mentoridDataGridViewTextBoxColumn.DisplayMember = "surname";
            this.mentoridDataGridViewTextBoxColumn.HeaderText = "Руководитель";
            this.mentoridDataGridViewTextBoxColumn.Name = "mentoridDataGridViewTextBoxColumn";
            this.mentoridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mentoridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mentoridDataGridViewTextBoxColumn.ToolTipText = "Научный руководитель работы";
            this.mentoridDataGridViewTextBoxColumn.ValueMember = "id";



            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idDataGridViewTextBoxColumn,
									this.studentidDataGridViewTextBoxColumn,
									this.nameDataGridViewTextBoxColumn,
									this.descDataGridViewTextBoxColumn,
									this.mentoridDataGridViewTextBoxColumn});
        }

        protected override void DataGridView_RowsRemoving()
        {
            Console.WriteLine("Hello from 08-K-PO1! :)");
        }
    }
}
