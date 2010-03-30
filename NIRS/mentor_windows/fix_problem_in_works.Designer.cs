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
	partial class fix_problem_in_works
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fix_problem_in_works));
			this.tools = new System.Windows.Forms.ToolStrip();
			this.toolStripFixed = new System.Windows.Forms.ToolStripButton();
			this.toolsStepBack = new System.Windows.Forms.ToolStripButton();
			this.dataGridView_works = new System.Windows.Forms.DataGridView();
			this.bind_works = new NIRS_Viewer.bind();
			this.bind_mentor_helpful = new NIRS_Viewer.bind();
			this.bind_student_helpful = new NIRS_Viewer.bind();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mentoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.tools.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_works)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_works)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_mentor_helpful)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_student_helpful)).BeginInit();
			this.SuspendLayout();
			// 
			// tools
			// 
			this.tools.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripFixed,
									this.toolsStepBack});
			this.tools.Location = new System.Drawing.Point(0, 252);
			this.tools.Name = "tools";
			this.tools.Size = new System.Drawing.Size(688, 25);
			this.tools.TabIndex = 0;
			this.tools.Text = "toolStrip1";
			// 
			// toolStripFixed
			// 
			this.toolStripFixed.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFixed.Image")));
			this.toolStripFixed.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripFixed.Name = "toolStripFixed";
			this.toolStripFixed.Size = new System.Drawing.Size(92, 22);
			this.toolStripFixed.Text = "Исправлено";
			this.toolStripFixed.Click += new System.EventHandler(this.ToolStripFixedClick);
			// 
			// toolsStepBack
			// 
			this.toolsStepBack.Image = ((System.Drawing.Image)(resources.GetObject("toolsStepBack.Image")));
			this.toolsStepBack.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolsStepBack.Name = "toolsStepBack";
			this.toolsStepBack.Size = new System.Drawing.Size(79, 22);
			this.toolsStepBack.Text = "Шаг назад";
			this.toolsStepBack.Click += new System.EventHandler(this.ToolsStepBackClick);
			// 
			// dataGridView_works
			// 
			this.dataGridView_works.AllowUserToAddRows = false;
			this.dataGridView_works.AllowUserToDeleteRows = false;
			this.dataGridView_works.AutoGenerateColumns = false;
			this.dataGridView_works.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_works.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idDataGridViewTextBoxColumn,
									this.studentidDataGridViewTextBoxColumn,
									this.nameDataGridViewTextBoxColumn,
									this.descDataGridViewTextBoxColumn,
									this.mentoridDataGridViewTextBoxColumn});
			this.dataGridView_works.DataSource = this.bind_works;
			this.dataGridView_works.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_works.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_works.Name = "dataGridView_works";
			this.dataGridView_works.Size = new System.Drawing.Size(688, 252);
			this.dataGridView_works.TabIndex = 1;
			this.dataGridView_works.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_worksCellValueChanged);
			this.dataGridView_works.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_worksCellBeginEdit);
			this.dataGridView_works.Resize += new System.EventHandler(this.DataGridView_worksResize);
			// 
			// bind_works
			// 
			this.bind_works.DataMember = "works";
			// 
			// bind_mentor_helpful
			// 
			this.bind_mentor_helpful.DataMember = "mentor";
			this.bind_mentor_helpful.Position = 0;
			// 
			// bind_student_helpful
			// 
			this.bind_student_helpful.DataMember = "student";
			this.bind_student_helpful.Position = 0;
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
			this.studentidDataGridViewTextBoxColumn.ToolTipText = "выбор студента, сделавшего работу";
			this.studentidDataGridViewTextBoxColumn.ValueMember = "id";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ToolTipText = "название научной работы";
			// 
			// descDataGridViewTextBoxColumn
			// 
			this.descDataGridViewTextBoxColumn.DataPropertyName = "desc";
			this.descDataGridViewTextBoxColumn.HeaderText = "Описание";
			this.descDataGridViewTextBoxColumn.Name = "descDataGridViewTextBoxColumn";
			this.descDataGridViewTextBoxColumn.ToolTipText = "описание научной работы";
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
			this.mentoridDataGridViewTextBoxColumn.ToolTipText = "научный руководитель работы";
			this.mentoridDataGridViewTextBoxColumn.ValueMember = "id";
			// 
			// fix_problem_in_works
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(688, 277);
			this.Controls.Add(this.dataGridView_works);
			this.Controls.Add(this.tools);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "fix_problem_in_works";
			this.Text = "fix_problem_in_works";
			this.Load += new System.EventHandler(this.Fix_problem_in_worksLoad);
			this.tools.ResumeLayout(false);
			this.tools.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_works)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_works)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_mentor_helpful)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_student_helpful)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private NIRS_Viewer.bind bind_student_helpful;
		private NIRS_Viewer.bind bind_mentor_helpful;
		private System.Windows.Forms.DataGridViewComboBoxColumn mentoridDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn studentidDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewTextBoxColumn specidDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewComboBoxColumn dividDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewTextBoxColumn acrankDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewTextBoxColumn workDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripButton toolsStepBack;
		private System.Windows.Forms.ToolStrip tools;
		private System.Windows.Forms.ToolStripButton toolStripFixed;
		private System.Windows.Forms.DataGridView dataGridView_works;
		private NIRS_Viewer.bind bind_works;
//		private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewComboBoxColumn facidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
	}
}
