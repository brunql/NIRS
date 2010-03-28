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
	partial class fix_problem_in_spec
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fix_problem_in_spec));
			this.tools = new System.Windows.Forms.ToolStrip();
			this.toolStripFixed = new System.Windows.Forms.ToolStripButton();
			this.toolsStepBack = new System.Windows.Forms.ToolStripButton();
			this.dataGridView_spec = new System.Windows.Forms.DataGridView();
			this.bind_division_helpful = new NIRS_Viewer.bind();
			this.bind_spec = new NIRS_Viewer.bind();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dividDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tools.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_spec)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_division_helpful)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_spec)).BeginInit();
			this.SuspendLayout();
			// 
			// tools
			// 
			this.tools.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripFixed,
									this.toolsStepBack});
			this.tools.Location = new System.Drawing.Point(0, 254);
			this.tools.Name = "tools";
			this.tools.Size = new System.Drawing.Size(492, 25);
			this.tools.TabIndex = 0;
			this.tools.Text = "toolStrip1";
			// 
			// toolStripFixed
			// 
			this.toolStripFixed.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFixed.Image")));
			this.toolStripFixed.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripFixed.Name = "toolStripFixed";
			this.toolStripFixed.Size = new System.Drawing.Size(92, 22);
			this.toolStripFixed.Text = "исправленно";
			this.toolStripFixed.Click += new System.EventHandler(this.ToolStripFixedClick);
			// 
			// toolsStepBack
			// 
			this.toolsStepBack.Image = ((System.Drawing.Image)(resources.GetObject("toolsStepBack.Image")));
			this.toolsStepBack.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolsStepBack.Name = "toolsStepBack";
			this.toolsStepBack.Size = new System.Drawing.Size(79, 22);
			this.toolsStepBack.Text = "шаг назад";
			this.toolsStepBack.Click += new System.EventHandler(this.ToolsStepBackClick);
			// 
			// dataGridView_spec
			// 
			this.dataGridView_spec.AllowUserToAddRows = false;
			this.dataGridView_spec.AllowUserToDeleteRows = false;
			this.dataGridView_spec.AutoGenerateColumns = false;
			this.dataGridView_spec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_spec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idDataGridViewTextBoxColumn,
									this.dividDataGridViewTextBoxColumn,
									this.codeDataGridViewTextBoxColumn,
									this.nameDataGridViewTextBoxColumn});
			this.dataGridView_spec.DataSource = this.bind_spec;
			this.dataGridView_spec.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_spec.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_spec.Name = "dataGridView_spec";
			this.dataGridView_spec.Size = new System.Drawing.Size(492, 254);
			this.dataGridView_spec.TabIndex = 1;
			this.dataGridView_spec.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_specCellValueChanged);
			this.dataGridView_spec.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_specCellBeginEdit);
			this.dataGridView_spec.Resize += new System.EventHandler(this.DataGridView_specResize);
			// 
			// bind_division_helpful
			// 
			this.bind_division_helpful.DataMember = "division";
			this.bind_division_helpful.Position = 0;
			// 
			// bind_spec
			// 
			this.bind_spec.DataMember = "spec";
			this.bind_spec.Position = 0;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
			this.dividDataGridViewTextBoxColumn.ToolTipText = "кафедра, к которой относится специальность";
			this.dividDataGridViewTextBoxColumn.ValueMember = "id";
			// 
			// codeDataGridViewTextBoxColumn
			// 
			this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
			this.codeDataGridViewTextBoxColumn.HeaderText = "Код";
			this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
			this.codeDataGridViewTextBoxColumn.ToolTipText = "код специальности";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ToolTipText = "название специальности";
			// 
			// fix_problem_in_spec
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 279);
			this.Controls.Add(this.dataGridView_spec);
			this.Controls.Add(this.tools);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "fix_problem_in_spec";
			this.Text = "fix_problem_in_spec";
			this.Load += new System.EventHandler(this.Fix_problem_in_specLoad);
			this.tools.ResumeLayout(false);
			this.tools.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_spec)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_division_helpful)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_spec)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn dividDataGridViewTextBoxColumn;
		private NIRS_Viewer.bind bind_division_helpful;
		private System.Windows.Forms.ToolStripButton toolsStepBack;
		private System.Windows.Forms.ToolStrip tools;
		private System.Windows.Forms.ToolStripButton toolStripFixed;
		private System.Windows.Forms.DataGridView dataGridView_spec;
		private NIRS_Viewer.bind bind_spec;
//		private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewComboBoxColumn facidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
	}
}
