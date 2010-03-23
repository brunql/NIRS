/*
 * Created by SharpDevelop.
 * User: Администратор
 * Date: 21.03.2010
 * Time: 6:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NIRS_database
{
	partial class division_windows
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(division_windows));
			this.tools = new System.Windows.Forms.ToolStrip();
			this.toolsFindLabel = new System.Windows.Forms.ToolStripLabel();
			this.toolsFindIt = new System.Windows.Forms.ToolStripTextBox();
			this.toolsFindIn = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripTransparency = new System.Windows.Forms.ToolStripLabel();
			this.toolStripTransparencyMinus = new System.Windows.Forms.ToolStripButton();
			this.toolsTransparencyStatus = new System.Windows.Forms.ToolStripProgressBar();
			this.toolsTransparencyPlus = new System.Windows.Forms.ToolStripButton();
			this.dataGridView_division = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.facidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bind_father_faculty = new NIRS_Viewer.bind();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip_division = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.удалитьВыбранныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bind_division = new NIRS_Viewer.bind();
            this.bind_division_spec_helpful = new NIRS_Viewer.bind();
            this.bind_division_mentor_helpful = new NIRS_Viewer.bind();
			this.tools.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_division)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_father_faculty)).BeginInit();
			this.contextMenuStrip_division.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bind_division)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_division_spec_helpful)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_division_mentor_helpful)).BeginInit();
			this.SuspendLayout();
			// 
			// tools
			// 
			this.tools.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolsFindLabel,
									this.toolsFindIt,
									this.toolsFindIn,
									this.toolStripSeparator1,
									this.toolStripSave,
									this.toolStripSeparator2,
									this.toolStripTransparency,
									this.toolStripTransparencyMinus,
									this.toolsTransparencyStatus,
									this.toolsTransparencyPlus});
			this.tools.Location = new System.Drawing.Point(0, 361);
			this.tools.Name = "tools";
			this.tools.Size = new System.Drawing.Size(609, 25);
			this.tools.TabIndex = 0;
			this.tools.Text = "toolStrip1";
			// 
			// toolsFindLabel
			// 
			this.toolsFindLabel.Name = "toolsFindLabel";
			this.toolsFindLabel.Size = new System.Drawing.Size(45, 22);
			this.toolsFindLabel.Text = "Найти :";
			// 
			// toolsFindIt
			// 
			this.toolsFindIt.Name = "toolsFindIt";
			this.toolsFindIt.Size = new System.Drawing.Size(100, 25);
			this.toolsFindIt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ToolsFindItKeyUp);
			// 
			// toolsFindIn
			// 
			this.toolsFindIn.Items.AddRange(new object[] {
									"none"});
			this.toolsFindIn.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
			this.toolsFindIn.Name = "toolsFindIn";
			this.toolsFindIn.Size = new System.Drawing.Size(121, 25);
			this.toolsFindIn.SelectedIndexChanged += new System.EventHandler(this.ToolsFindInSelectedIndexChanged);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSave
			// 
			this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
			this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSave.Name = "toolStripSave";
			this.toolStripSave.Size = new System.Drawing.Size(51, 22);
			this.toolStripSave.Text = "Save";
			this.toolStripSave.Click += new System.EventHandler(this.ToolStripSaveClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripTransparency
			// 
			this.toolStripTransparency.Name = "toolStripTransparency";
			this.toolStripTransparency.Size = new System.Drawing.Size(85, 22);
			this.toolStripTransparency.Text = "Прозрачность :";
			// 
			// toolStripTransparencyMinus
			// 
			this.toolStripTransparencyMinus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripTransparencyMinus.Image = ((System.Drawing.Image)(resources.GetObject("toolStripTransparencyMinus.Image")));
			this.toolStripTransparencyMinus.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripTransparencyMinus.Name = "toolStripTransparencyMinus";
			this.toolStripTransparencyMinus.Size = new System.Drawing.Size(23, 22);
			// 
			// toolsTransparencyStatus
			// 
			this.toolsTransparencyStatus.Name = "toolsTransparencyStatus";
			this.toolsTransparencyStatus.Size = new System.Drawing.Size(100, 22);
			// 
			// toolsTransparencyPlus
			// 
			this.toolsTransparencyPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolsTransparencyPlus.Image = ((System.Drawing.Image)(resources.GetObject("toolsTransparencyPlus.Image")));
			this.toolsTransparencyPlus.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolsTransparencyPlus.Name = "toolsTransparencyPlus";
			this.toolsTransparencyPlus.Size = new System.Drawing.Size(23, 22);
			// 
			// dataGridView_division
			// 
			this.dataGridView_division.AutoGenerateColumns = false;
			this.dataGridView_division.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_division.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idDataGridViewTextBoxColumn,
									this.facidDataGridViewTextBoxColumn,
									this.nameDataGridViewTextBoxColumn,
									this.fullnameDataGridViewTextBoxColumn});
			this.dataGridView_division.ContextMenuStrip = this.contextMenuStrip_division;
			this.dataGridView_division.DataSource = this.bind_division;
			this.dataGridView_division.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_division.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_division.Name = "dataGridView_division";
			this.dataGridView_division.Size = new System.Drawing.Size(609, 361);
			this.dataGridView_division.TabIndex = 1;
			this.dataGridView_division.Resize += new System.EventHandler(this.DataGridView_divisionResize);
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
			this.facidDataGridViewTextBoxColumn.DataSource = this.bind_father_faculty;
			this.facidDataGridViewTextBoxColumn.DisplayMember = "name";
			this.facidDataGridViewTextBoxColumn.HeaderText = "fac_id";
			this.facidDataGridViewTextBoxColumn.Name = "facidDataGridViewTextBoxColumn";
			this.facidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.facidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.facidDataGridViewTextBoxColumn.ValueMember = "id";
			// 
			// bind_father_faculty
			// 
			this.bind_father_faculty.DataMember = "faculty";
			this.bind_father_faculty.Position = 0;
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
			// contextMenuStrip_division
			// 
			this.contextMenuStrip_division.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.удалитьВыбранныеToolStripMenuItem});
			this.contextMenuStrip_division.Name = "contextMenuStrip_division";
			this.contextMenuStrip_division.Size = new System.Drawing.Size(188, 26);
			// 
			// удалитьВыбранныеToolStripMenuItem
			// 
			this.удалитьВыбранныеToolStripMenuItem.Name = "удалитьВыбранныеToolStripMenuItem";
			this.удалитьВыбранныеToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.удалитьВыбранныеToolStripMenuItem.Text = "удалить выбранное";
			this.удалитьВыбранныеToolStripMenuItem.Click += new System.EventHandler(this.УдалитьВыбранныеToolStripMenuItemClick);
			// 
			// bind_division
			// 
			this.bind_division.DataMember = "division";
			this.bind_division.Position = 0;
			// 
			// bind_division_spec_helpful
			// 
			this.bind_division_spec_helpful.DataMember = "spec";
			this.bind_division_spec_helpful.Position = 0;
			// 
			// bind_division_mentor_helpful
			// 
			this.bind_division_mentor_helpful.DataMember = "mentor";
			this.bind_division_mentor_helpful.Position = 0;
			// 
			// division_windows
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 386);
			this.Controls.Add(this.dataGridView_division);
			this.Controls.Add(this.tools);
			this.Name = "division_windows";
			this.Text = "division_windows";
			this.Load += new System.EventHandler(this.division_windowsLoad);
			this.tools.ResumeLayout(false);
			this.tools.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_division)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_father_faculty)).EndInit();
			this.contextMenuStrip_division.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bind_division)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_division_spec_helpful)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_division_mentor_helpful)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
        private NIRS_Viewer.bind bind_father_faculty;
		private System.Windows.Forms.DataGridViewComboBoxColumn facidDataGridViewTextBoxColumn;
        private NIRS_Viewer.bind bind_division_spec_helpful;
        private NIRS_Viewer.bind bind_division_mentor_helpful;
		private System.Windows.Forms.ToolStripMenuItem удалитьВыбранныеToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_division;
		private System.Windows.Forms.DataGridView dataGridView_division;
		private System.Windows.Forms.ToolStripButton toolsTransparencyPlus;
		private System.Windows.Forms.ToolStripProgressBar toolsTransparencyStatus;
		private System.Windows.Forms.ToolStripButton toolStripTransparencyMinus;
		private System.Windows.Forms.ToolStripLabel toolStripTransparency;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripComboBox toolsFindIn;
		private System.Windows.Forms.ToolStripTextBox toolsFindIt;
        private NIRS_Viewer.bind bind_division;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripButton toolStripSave;
		private System.Windows.Forms.ToolStripLabel toolsFindLabel;
		private System.Windows.Forms.ToolStrip tools;
	}
}
