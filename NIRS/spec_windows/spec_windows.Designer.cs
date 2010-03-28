/*
 * Created by SharpDevelop.
 * User: Администратор
 * Date: 21.03.2010
 * Time: 6:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NIRS
{
	partial class spec_windows
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spec_windows));
			this.tools = new System.Windows.Forms.ToolStrip();
			this.toolsFindLabel = new System.Windows.Forms.ToolStripLabel();
			this.toolsFindIt = new System.Windows.Forms.ToolStripTextBox();
			this.toolsFindIn = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripTransparency = new System.Windows.Forms.ToolStripLabel();
			this.toolStripOpacityMinus = new System.Windows.Forms.ToolStripButton();
			this.toolsOpacityStatus = new System.Windows.Forms.ToolStripProgressBar();
			this.toolsOpacityPlus = new System.Windows.Forms.ToolStripButton();
			this.dataGridView_spec = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip_spec = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.удалитьВыбранныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bind_spec = new NIRS_Viewer.bind();
			this.bind_father_division = new NIRS_Viewer.bind();
			this.bind_spec_in_group_helpful = new NIRS_Viewer.bind();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dividDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tools.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_spec)).BeginInit();
			this.contextMenuStrip_spec.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bind_spec)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_father_division)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_spec_in_group_helpful)).BeginInit();
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
									this.toolStripOpacityMinus,
									this.toolsOpacityStatus,
									this.toolsOpacityPlus});
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
			// toolStripOpacityMinus
			// 
			this.toolStripOpacityMinus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripOpacityMinus.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpacityMinus.Image")));
			this.toolStripOpacityMinus.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripOpacityMinus.Name = "toolStripOpacityMinus";
			this.toolStripOpacityMinus.Size = new System.Drawing.Size(23, 22);
			this.toolStripOpacityMinus.Click += new System.EventHandler(this.ToolStripOpacityMinusClick);
			// 
			// toolsOpacityStatus
			// 
			this.toolsOpacityStatus.Name = "toolsOpacityStatus";
			this.toolsOpacityStatus.Size = new System.Drawing.Size(100, 22);
			// 
			// toolsOpacityPlus
			// 
			this.toolsOpacityPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolsOpacityPlus.Image = ((System.Drawing.Image)(resources.GetObject("toolsOpacityPlus.Image")));
			this.toolsOpacityPlus.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolsOpacityPlus.Name = "toolsOpacityPlus";
			this.toolsOpacityPlus.Size = new System.Drawing.Size(23, 22);
			this.toolsOpacityPlus.Click += new System.EventHandler(this.ToolsOpacityPlusClick);
			// 
			// dataGridView_spec
			// 
			this.dataGridView_spec.AutoGenerateColumns = false;
			this.dataGridView_spec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_spec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idDataGridViewTextBoxColumn,
									this.dividDataGridViewTextBoxColumn,
									this.codeDataGridViewTextBoxColumn,
									this.nameDataGridViewTextBoxColumn});
			this.dataGridView_spec.ContextMenuStrip = this.contextMenuStrip_spec;
			this.dataGridView_spec.DataSource = this.bind_spec;
			this.dataGridView_spec.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_spec.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_spec.Name = "dataGridView_spec";
			this.dataGridView_spec.Size = new System.Drawing.Size(609, 361);
			this.dataGridView_spec.TabIndex = 1;
			this.dataGridView_spec.Resize += new System.EventHandler(this.DataGridView_specResize);
			this.dataGridView_spec.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridView_specRowsRemoved);
			// 
			// contextMenuStrip_spec
			// 
			this.contextMenuStrip_spec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.удалитьВыбранныеToolStripMenuItem});
			this.contextMenuStrip_spec.Name = "contextMenuStrip_spec";
			this.contextMenuStrip_spec.Size = new System.Drawing.Size(228, 26);
			// 
			// удалитьВыбранныеToolStripMenuItem
			// 
			this.удалитьВыбранныеToolStripMenuItem.Name = "удалитьВыбранныеToolStripMenuItem";
			this.удалитьВыбранныеToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.удалитьВыбранныеToolStripMenuItem.Text = "удалить выбранные строки";
			this.удалитьВыбранныеToolStripMenuItem.Click += new System.EventHandler(this.УдалитьВыбранныеToolStripMenuItemClick);
			// 
			// bind_spec
			// 
			this.bind_spec.DataMember = "spec";
			this.bind_spec.Position = 0;
			// 
			// bind_father_division
			// 
			this.bind_father_division.DataMember = "division";
			this.bind_father_division.Position = 0;
			// 
			// bind_spec_in_group_helpful
			// 
			this.bind_spec_in_group_helpful.DataMember = "group";
			this.bind_spec_in_group_helpful.Position = 0;
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
			this.dividDataGridViewTextBoxColumn.DataSource = this.bind_father_division;
			this.dividDataGridViewTextBoxColumn.DisplayMember = "name";
			this.dividDataGridViewTextBoxColumn.HeaderText = "Кафедра";
			this.dividDataGridViewTextBoxColumn.Name = "dividDataGridViewTextBoxColumn";
			this.dividDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dividDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dividDataGridViewTextBoxColumn.ToolTipText = "кафедра, на которой обучают специальности";
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
			// spec_windows
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 386);
			this.Controls.Add(this.dataGridView_spec);
			this.Controls.Add(this.tools);
			this.Name = "spec_windows";
			this.Text = "spec_windows";
			this.Load += new System.EventHandler(this.spec_windowsLoad);
			this.tools.ResumeLayout(false);
			this.tools.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_spec)).EndInit();
			this.contextMenuStrip_spec.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bind_spec)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_father_division)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_spec_in_group_helpful)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private NIRS_Viewer.bind bind_spec_in_group_helpful;
		private NIRS_Viewer.bind bind_father_division;
		private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn dividDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripButton toolStripOpacityMinus;
		private System.Windows.Forms.ToolStripProgressBar toolsOpacityStatus;
		private System.Windows.Forms.ToolStripButton toolsOpacityPlus;
//		private System.Windows.Forms.DataGridViewComboBoxColumn facidDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripMenuItem удалитьВыбранныеToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_spec;
		private System.Windows.Forms.DataGridView dataGridView_spec;
		private System.Windows.Forms.ToolStripLabel toolStripTransparency;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripComboBox toolsFindIn;
		private System.Windows.Forms.ToolStripTextBox toolsFindIt;
		private NIRS_Viewer.bind bind_spec;
//		private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripButton toolStripSave;
		private System.Windows.Forms.ToolStripLabel toolsFindLabel;
		private System.Windows.Forms.ToolStrip tools;
	}
}
