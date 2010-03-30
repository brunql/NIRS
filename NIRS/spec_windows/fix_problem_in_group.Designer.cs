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
	partial class fix_problem_in_group
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fix_problem_in_group));
			this.tools = new System.Windows.Forms.ToolStrip();
			this.toolStripFixed = new System.Windows.Forms.ToolStripButton();
			this.toolsStepBack = new System.Windows.Forms.ToolStripButton();
			this.dataGridView_group = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.specidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bind_group = new NIRS_Viewer.bind();
			this.bind_spec_helpful = new NIRS_Viewer.bind();
			this.tools.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_group)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_group)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_spec_helpful)).BeginInit();
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
			// dataGridView_group
			// 
			this.dataGridView_group.AllowUserToAddRows = false;
			this.dataGridView_group.AllowUserToDeleteRows = false;
			this.dataGridView_group.AutoGenerateColumns = false;
			this.dataGridView_group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_group.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idDataGridViewTextBoxColumn,
									this.specidDataGridViewTextBoxColumn,
									this.codeDataGridViewTextBoxColumn});
			this.dataGridView_group.DataSource = this.bind_group;
			this.dataGridView_group.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_group.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_group.Name = "dataGridView_group";
			this.dataGridView_group.Size = new System.Drawing.Size(688, 252);
			this.dataGridView_group.TabIndex = 1;
			this.dataGridView_group.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_groupCellValueChanged);
			this.dataGridView_group.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_groupCellBeginEdit);
			this.dataGridView_group.Resize += new System.EventHandler(this.DataGridView_groupResize);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// specidDataGridViewTextBoxColumn
			// 
			this.specidDataGridViewTextBoxColumn.DataPropertyName = "spec_id";
			this.specidDataGridViewTextBoxColumn.HeaderText = "spec_id";
			this.specidDataGridViewTextBoxColumn.Name = "specidDataGridViewTextBoxColumn";
			// 
			// codeDataGridViewTextBoxColumn
			// 
			this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
			this.codeDataGridViewTextBoxColumn.HeaderText = "code";
			this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
			// 
			// bind_group
			// 
			this.bind_group.DataMember = "group";
			this.bind_group.Position = 0;
			// 
			// bind_spec_helpful
			// 
			this.bind_spec_helpful.DataMember = "spec";
			this.bind_spec_helpful.Position = 0;
			// 
			// fix_problem_in_group
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(688, 277);
			this.Controls.Add(this.dataGridView_group);
			this.Controls.Add(this.tools);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "fix_problem_in_group";
			this.Text = "fix_problem_in_group";
			this.Load += new System.EventHandler(this.Fix_problem_in_groupLoad);
			this.tools.ResumeLayout(false);
			this.tools.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_group)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_group)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_spec_helpful)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private NIRS_Viewer.bind bind_spec_helpful;
		private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn specidDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewComboBoxColumn dividDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewTextBoxColumn acrankDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewTextBoxColumn workDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripButton toolsStepBack;
		private System.Windows.Forms.ToolStrip tools;
		private System.Windows.Forms.ToolStripButton toolStripFixed;
		private System.Windows.Forms.DataGridView dataGridView_group;
		private NIRS_Viewer.bind bind_group;
//		private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewComboBoxColumn facidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
	}
}
