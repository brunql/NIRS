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
	partial class faculty_windows
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(faculty_windows));
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
			this.dataGridView_faculty = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip_faculty = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.удалитьВыбранныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bind_faculty = new nirs_viewer.bind();
			this.bind_division_del_helpful = new nirs_viewer.bind();
			this.tools.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_faculty)).BeginInit();
			this.contextMenuStrip_faculty.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bind_faculty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_division_del_helpful)).BeginInit();
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
			// dataGridView_faculty
			// 
			this.dataGridView_faculty.AutoGenerateColumns = false;
			this.dataGridView_faculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_faculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idDataGridViewTextBoxColumn,
									this.nameDataGridViewTextBoxColumn,
									this.fullnameDataGridViewTextBoxColumn});
			this.dataGridView_faculty.ContextMenuStrip = this.contextMenuStrip_faculty;
			this.dataGridView_faculty.DataSource = this.bind_faculty;
			this.dataGridView_faculty.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_faculty.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_faculty.Name = "dataGridView_faculty";
			this.dataGridView_faculty.Size = new System.Drawing.Size(609, 361);
			this.dataGridView_faculty.TabIndex = 1;
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
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// fullnameDataGridViewTextBoxColumn
			// 
			this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
			this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
			this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
			// 
			// contextMenuStrip_faculty
			// 
			this.contextMenuStrip_faculty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.удалитьВыбранныеToolStripMenuItem});
			this.contextMenuStrip_faculty.Name = "contextMenuStrip_faculty";
			this.contextMenuStrip_faculty.Size = new System.Drawing.Size(188, 26);
			// 
			// удалитьВыбранныеToolStripMenuItem
			// 
			this.удалитьВыбранныеToolStripMenuItem.Name = "удалитьВыбранныеToolStripMenuItem";
			this.удалитьВыбранныеToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.удалитьВыбранныеToolStripMenuItem.Text = "удалить выбранное";
			this.удалитьВыбранныеToolStripMenuItem.Click += new System.EventHandler(this.УдалитьВыбранныеToolStripMenuItemClick);
			// 
			// bind_faculty
			// 
			this.bind_faculty.DataMember = "faculty";
			this.bind_faculty.Position = 0;
			// 
			// bind_division_del_helpful
			// 
			this.bind_division_del_helpful.DataMember = "division";
			this.bind_division_del_helpful.Position = 0;
			// 
			// faculty_windows
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 386);
			this.Controls.Add(this.dataGridView_faculty);
			this.Controls.Add(this.tools);
			this.Name = "faculty_windows";
			this.Text = "faculty_windows";
			this.Load += new System.EventHandler(this.Faculty_windowsLoad);
			this.tools.ResumeLayout(false);
			this.tools.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_faculty)).EndInit();
			this.contextMenuStrip_faculty.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bind_faculty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_division_del_helpful)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private nirs_viewer.bind bind_division_del_helpful;
		private System.Windows.Forms.ToolStripMenuItem удалитьВыбранныеToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_faculty;
		private System.Windows.Forms.DataGridView dataGridView_faculty;
		private System.Windows.Forms.ToolStripButton toolsTransparencyPlus;
		private System.Windows.Forms.ToolStripProgressBar toolsTransparencyStatus;
		private System.Windows.Forms.ToolStripButton toolStripTransparencyMinus;
		private System.Windows.Forms.ToolStripLabel toolStripTransparency;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripComboBox toolsFindIn;
		private System.Windows.Forms.ToolStripTextBox toolsFindIt;
		private nirs_viewer.bind bind_faculty;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripButton toolStripSave;
		private System.Windows.Forms.ToolStripLabel toolsFindLabel;
		private System.Windows.Forms.ToolStrip tools;
	}
}
