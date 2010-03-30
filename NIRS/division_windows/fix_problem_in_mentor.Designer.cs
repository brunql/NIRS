/*
 * Created by SharpDevelop.
 * User: Администратор
 * Date: 21.03.2010
 * Time: 7:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NIRS
{
	partial class fix_problem_in_mentor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fix_problem_in_mentor));
            this.tools = new System.Windows.Forms.ToolStrip();
            this.toolStripFixed = new System.Windows.Forms.ToolStripButton();
            this.toolsStepBack = new System.Windows.Forms.ToolStripButton();
            this.dataGridView_mentor = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acrankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dividDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bind_division_helpful = new NIRS_Viewer.bind();
            this.bind_mentor = new NIRS_Viewer.bind();
            this.tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mentor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind_division_helpful)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind_mentor)).BeginInit();
            this.SuspendLayout();
            // 
            // tools
            // 
            this.tools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFixed,
            this.toolsStepBack});
            this.tools.Location = new System.Drawing.Point(0, 311);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(882, 25);
            this.tools.TabIndex = 0;
            this.tools.Text = "toolStrip1";
            // 
            // toolStripFixed
            // 
            this.toolStripFixed.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFixed.Image")));
            this.toolStripFixed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFixed.Name = "toolStripFixed";
            this.toolStripFixed.Size = new System.Drawing.Size(95, 22);
            this.toolStripFixed.Text = "Исправлено";
            this.toolStripFixed.Click += new System.EventHandler(this.ToolStripFixedClick);
            // 
            // toolsStepBack
            // 
            this.toolsStepBack.Image = ((System.Drawing.Image)(resources.GetObject("toolsStepBack.Image")));
            this.toolsStepBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsStepBack.Name = "toolsStepBack";
            this.toolsStepBack.Size = new System.Drawing.Size(82, 22);
            this.toolsStepBack.Text = "Шаг назад";
            this.toolsStepBack.Click += new System.EventHandler(this.ToolsStepBackClick);
            // 
            // dataGridView_mentor
            // 
            this.dataGridView_mentor.AllowUserToAddRows = false;
            this.dataGridView_mentor.AllowUserToDeleteRows = false;
            this.dataGridView_mentor.AutoGenerateColumns = false;
            this.dataGridView_mentor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mentor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.fathernameDataGridViewTextBoxColumn,
            this.workDataGridViewTextBoxColumn,
            this.acrankDataGridViewTextBoxColumn,
            this.degreeDataGridViewTextBoxColumn,
            this.dividDataGridViewTextBoxColumn});
            this.dataGridView_mentor.DataSource = this.bind_mentor;
            this.dataGridView_mentor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_mentor.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_mentor.Name = "dataGridView_mentor";
            this.dataGridView_mentor.Size = new System.Drawing.Size(882, 311);
            this.dataGridView_mentor.TabIndex = 1;
            this.dataGridView_mentor.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_mentorCellValueChanged);
            this.dataGridView_mentor.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_mentorCellBeginEdit);
            this.dataGridView_mentor.Resize += new System.EventHandler(this.DataGridView_mentorResize);
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
            this.nameDataGridViewTextBoxColumn.ToolTipText = "имя научного руководителя";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ToolTipText = "фамилия научного руководителя";
            // 
            // fathernameDataGridViewTextBoxColumn
            // 
            this.fathernameDataGridViewTextBoxColumn.DataPropertyName = "fathername";
            this.fathernameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.fathernameDataGridViewTextBoxColumn.Name = "fathernameDataGridViewTextBoxColumn";
            this.fathernameDataGridViewTextBoxColumn.ToolTipText = "отчество научного руководителя";
            // 
            // workDataGridViewTextBoxColumn
            // 
            this.workDataGridViewTextBoxColumn.DataPropertyName = "work";
            this.workDataGridViewTextBoxColumn.HeaderText = "Названия Работ";
            this.workDataGridViewTextBoxColumn.Name = "workDataGridViewTextBoxColumn";
            this.workDataGridViewTextBoxColumn.ToolTipText = "названия работ, курируемых данным научным руководителем";
            // 
            // acrankDataGridViewTextBoxColumn
            // 
            this.acrankDataGridViewTextBoxColumn.DataPropertyName = "acrank";
            this.acrankDataGridViewTextBoxColumn.HeaderText = "Академический Ранг";
            this.acrankDataGridViewTextBoxColumn.Name = "acrankDataGridViewTextBoxColumn";
            this.acrankDataGridViewTextBoxColumn.ToolTipText = "ранг научного руководителя";
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            this.degreeDataGridViewTextBoxColumn.DataPropertyName = "degree";
            this.degreeDataGridViewTextBoxColumn.HeaderText = "Учённая Степень";
            this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            this.degreeDataGridViewTextBoxColumn.ToolTipText = "учённая степень научного руководителя";
            // 
            // dividDataGridViewTextBoxColumn
            // 
            this.dividDataGridViewTextBoxColumn.DataPropertyName = "div_id";
            this.dividDataGridViewTextBoxColumn.DataSource = this.bind_division_helpful;
            this.dividDataGridViewTextBoxColumn.DisplayMember = "name";
            this.dividDataGridViewTextBoxColumn.HeaderText = "Кафедра";
            this.dividDataGridViewTextBoxColumn.Name = "dividDataGridViewTextBoxColumn";
            this.dividDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dividDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dividDataGridViewTextBoxColumn.ToolTipText = "кафедра, на которой работает научный руководитель";
            this.dividDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // bind_division_helpful
            // 
            this.bind_division_helpful.DataMember = "division";
            this.bind_division_helpful.Position = 0;
            // 
            // bind_mentor
            // 
            this.bind_mentor.DataMember = "mentor";
            this.bind_mentor.Position = 0;
            // 
            // fix_problem_in_mentor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 336);
            this.Controls.Add(this.dataGridView_mentor);
            this.Controls.Add(this.tools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "fix_problem_in_mentor";
            this.Text = "fix_problem_in_mentor";
            this.Load += new System.EventHandler(this.Fix_problem_in_mentorLoad);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mentor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind_division_helpful)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind_mentor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.DataGridViewComboBoxColumn dividDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn acrankDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn workDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
		private NIRS_Viewer.bind bind_division_helpful;
		private System.Windows.Forms.ToolStripButton toolsStepBack;
		private System.Windows.Forms.ToolStrip tools;
		private System.Windows.Forms.ToolStripButton toolStripFixed;
		private System.Windows.Forms.DataGridView dataGridView_mentor;
		private NIRS_Viewer.bind bind_mentor;
//		private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewComboBoxColumn facidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
	}
}
