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
	partial class fix_problem_in_student
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fix_problem_in_student));
			this.tools = new System.Windows.Forms.ToolStrip();
			this.toolStripFixed = new System.Windows.Forms.ToolStripButton();
			this.toolsStepBack = new System.Windows.Forms.ToolStripButton();
			this.dataGridView_student = new System.Windows.Forms.DataGridView();
			this.bind_student = new NIRS_Viewer.bind();
			this.bind_mentor_helpful = new NIRS_Viewer.bind();
			this.bind_group_helpful = new NIRS_Viewer.bind();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fathernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.mentoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.bornDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tools.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_student)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_mentor_helpful)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_group_helpful)).BeginInit();
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
			this.toolStripFixed.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripFixed.Name = "toolStripFixed";
			this.toolStripFixed.Size = new System.Drawing.Size(76, 22);
			this.toolStripFixed.Text = "Исправлено";
			this.toolStripFixed.Click += new System.EventHandler(this.ToolStripFixedClick);
			// 
			// toolsStepBack
			// 
			this.toolsStepBack.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolsStepBack.Name = "toolsStepBack";
			this.toolsStepBack.Size = new System.Drawing.Size(63, 22);
			this.toolsStepBack.Text = "Шаг назад";
			this.toolsStepBack.Click += new System.EventHandler(this.ToolsStepBackClick);
			// 
			// dataGridView_student
			// 
			this.dataGridView_student.AllowUserToAddRows = false;
			this.dataGridView_student.AllowUserToDeleteRows = false;
			this.dataGridView_student.AutoGenerateColumns = false;
			this.dataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idDataGridViewTextBoxColumn,
									this.nameDataGridViewTextBoxColumn,
									this.surnameDataGridViewTextBoxColumn,
									this.fathernameDataGridViewTextBoxColumn,
									this.groupidDataGridViewTextBoxColumn,
									this.mentoridDataGridViewTextBoxColumn,
									this.bornDataGridViewTextBoxColumn});
			this.dataGridView_student.DataSource = this.bind_student;
			this.dataGridView_student.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_student.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_student.Name = "dataGridView_student";
			this.dataGridView_student.Size = new System.Drawing.Size(688, 252);
			this.dataGridView_student.TabIndex = 1;
			this.dataGridView_student.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_studentCellValueChanged);
			this.dataGridView_student.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_studentCellBeginEdit);
			this.dataGridView_student.Resize += new System.EventHandler(this.DataGridView_studentResize);
			// 
			// bind_student
			// 
			this.bind_student.DataMember = "student";
			this.bind_student.Position = 0;
			// 
			// bind_mentor_helpful
			// 
			this.bind_mentor_helpful.DataMember = "mentor";
			this.bind_mentor_helpful.Position = 0;
			// 
			// bind_group_helpful
			// 
			this.bind_group_helpful.DataMember = "group";
			this.bind_group_helpful.Position = 0;
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
			this.nameDataGridViewTextBoxColumn.ToolTipText = "Имя студента";
			// 
			// surnameDataGridViewTextBoxColumn
			// 
			this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
			this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
			this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
			// 
			// fathernameDataGridViewTextBoxColumn
			// 
			this.fathernameDataGridViewTextBoxColumn.DataPropertyName = "fathername";
			this.fathernameDataGridViewTextBoxColumn.HeaderText = "fathername";
			this.fathernameDataGridViewTextBoxColumn.Name = "fathernameDataGridViewTextBoxColumn";
			// 
			// groupidDataGridViewTextBoxColumn
			// 
			this.groupidDataGridViewTextBoxColumn.DataPropertyName = "group_id";
			this.groupidDataGridViewTextBoxColumn.DataSource = this.bind_group_helpful;
			this.groupidDataGridViewTextBoxColumn.DisplayMember = "code";
			this.groupidDataGridViewTextBoxColumn.HeaderText = "group_id";
			this.groupidDataGridViewTextBoxColumn.Name = "groupidDataGridViewTextBoxColumn";
			this.groupidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.groupidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.groupidDataGridViewTextBoxColumn.ValueMember = "id";
			// 
			// mentoridDataGridViewTextBoxColumn
			// 
			this.mentoridDataGridViewTextBoxColumn.DataPropertyName = "mentor_id";
			this.mentoridDataGridViewTextBoxColumn.DataSource = this.bind_mentor_helpful;
			this.mentoridDataGridViewTextBoxColumn.DisplayMember = "surname";
			this.mentoridDataGridViewTextBoxColumn.HeaderText = "mentor_id";
			this.mentoridDataGridViewTextBoxColumn.Name = "mentoridDataGridViewTextBoxColumn";
			this.mentoridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.mentoridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.mentoridDataGridViewTextBoxColumn.ValueMember = "id";
			// 
			// bornDataGridViewTextBoxColumn
			// 
			this.bornDataGridViewTextBoxColumn.DataPropertyName = "born";
			this.bornDataGridViewTextBoxColumn.HeaderText = "born";
			this.bornDataGridViewTextBoxColumn.Name = "bornDataGridViewTextBoxColumn";
			// 
			// fix_problem_in_student
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(688, 277);
			this.Controls.Add(this.dataGridView_student);
			this.Controls.Add(this.tools);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "fix_problem_in_student";
			this.Text = "fix_problem_in_student";
			this.Load += new System.EventHandler(this.Fix_problem_in_studentLoad);
			this.tools.ResumeLayout(false);
			this.tools.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_student)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_mentor_helpful)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_group_helpful)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private NIRS_Viewer.bind bind_group_helpful;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bornDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn mentoridDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn groupidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private NIRS_Viewer.bind bind_mentor_helpful;
		private System.Windows.Forms.ToolStripButton toolsStepBack;
		private System.Windows.Forms.ToolStrip tools;
		private System.Windows.Forms.ToolStripButton toolStripFixed;
		private System.Windows.Forms.DataGridView dataGridView_student;
		private NIRS_Viewer.bind bind_student;
	}
}
