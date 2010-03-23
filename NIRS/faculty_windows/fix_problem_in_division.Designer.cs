/*
 * Created by SharpDevelop.
 * User: Администратор
 * Date: 21.03.2010
 * Time: 7:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NIRS_database
{
	partial class fix_problem_in_division
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fix_problem_in_division));
			this.tools = new System.Windows.Forms.ToolStrip();
			this.toolStripFixed = new System.Windows.Forms.ToolStripButton();
			this.toolsStepBack = new System.Windows.Forms.ToolStripButton();
			this.dataGridView_division = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.facidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bind_faculty_helpful = new NIRS_Viewer.bind();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bind_division = new NIRS_Viewer.bind();
			this.tools.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_division)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_faculty_helpful)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_division)).BeginInit();
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
			// dataGridView_division
			// 
			this.dataGridView_division.AllowUserToAddRows = false;
			this.dataGridView_division.AutoGenerateColumns = false;
			this.dataGridView_division.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_division.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idDataGridViewTextBoxColumn,
									this.facidDataGridViewTextBoxColumn,
									this.nameDataGridViewTextBoxColumn,
									this.fullnameDataGridViewTextBoxColumn});
			this.dataGridView_division.DataSource = this.bind_division;
			this.dataGridView_division.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_division.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_division.Name = "dataGridView_division";
			this.dataGridView_division.Size = new System.Drawing.Size(492, 254);
			this.dataGridView_division.TabIndex = 1;
			this.dataGridView_division.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_divisionCellValueChanged);
			this.dataGridView_division.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_divisionCellBeginEdit);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// facidDataGridViewTextBoxColumn
			// 
			this.facidDataGridViewTextBoxColumn.DataPropertyName = "fac_id";
			this.facidDataGridViewTextBoxColumn.DataSource = this.bind_faculty_helpful;
			this.facidDataGridViewTextBoxColumn.DisplayMember = "name";
			this.facidDataGridViewTextBoxColumn.HeaderText = "fac_id";
			this.facidDataGridViewTextBoxColumn.Name = "facidDataGridViewTextBoxColumn";
			this.facidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.facidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.facidDataGridViewTextBoxColumn.ValueMember = "id";
			// 
			// bind_faculty_helpful
			// 
			this.bind_faculty_helpful.DataMember = "faculty";
			this.bind_faculty_helpful.Position = 0;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// fullnameDataGridViewTextBoxColumn
			// 
			this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
			this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
			this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
			// 
			// bind_division
			// 
			this.bind_division.DataMember = "division";
			this.bind_division.Position = 0;
			// 
			// fix_problem_in_division
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 279);
			this.Controls.Add(this.dataGridView_division);
			this.Controls.Add(this.tools);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "fix_problem_in_division";
			this.Text = "fix_problem_in_division";
			this.Load += new System.EventHandler(this.Fix_problem_in_divisionLoad);
			this.tools.ResumeLayout(false);
			this.tools.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_division)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_faculty_helpful)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_division)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private NIRS_Viewer.bind bind_faculty_helpful;
		private System.Windows.Forms.ToolStripButton toolsStepBack;
		private System.Windows.Forms.ToolStrip tools;
		private System.Windows.Forms.ToolStripButton toolStripFixed;
		private System.Windows.Forms.DataGridView dataGridView_division;
        private NIRS_Viewer.bind bind_division;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn facidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
	}
}
