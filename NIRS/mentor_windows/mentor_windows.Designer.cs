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
	partial class mentor_windows
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mentor_windows));
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
			this.dataGridView_mentor = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip_mentor = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.удалитьВыбранныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bind_mentor = new NIRS_Viewer.bind();
			this.bind_father_division = new NIRS_Viewer.bind();
			this.bind_mentor_in_works_helpful = new NIRS_Viewer.bind();
			this.bind_mentor_in_student_helpful = new NIRS_Viewer.bind();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fathernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.workDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.acrankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dividDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tools.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_mentor)).BeginInit();
			this.contextMenuStrip_mentor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bind_mentor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_father_division)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_mentor_in_works_helpful)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_mentor_in_student_helpful)).BeginInit();
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
			// dataGridView_mentor
			// 
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
			this.dataGridView_mentor.ContextMenuStrip = this.contextMenuStrip_mentor;
			this.dataGridView_mentor.DataSource = this.bind_mentor;
			this.dataGridView_mentor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_mentor.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_mentor.Name = "dataGridView_mentor";
			this.dataGridView_mentor.Size = new System.Drawing.Size(609, 361);
			this.dataGridView_mentor.TabIndex = 1;
			this.dataGridView_mentor.Resize += new System.EventHandler(this.DataGridView_mentorResize);
			this.dataGridView_mentor.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridView_mentorRowsRemoved);
			// 
			// contextMenuStrip_mentor
			// 
			this.contextMenuStrip_mentor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.удалитьВыбранныеToolStripMenuItem});
			this.contextMenuStrip_mentor.Name = "contextMenuStrip_mentor";
			this.contextMenuStrip_mentor.Size = new System.Drawing.Size(228, 26);
			// 
			// удалитьВыбранныеToolStripMenuItem
			// 
			this.удалитьВыбранныеToolStripMenuItem.Name = "удалитьВыбранныеToolStripMenuItem";
			this.удалитьВыбранныеToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.удалитьВыбранныеToolStripMenuItem.Text = "удалить выбранные строки";
			this.удалитьВыбранныеToolStripMenuItem.Click += new System.EventHandler(this.УдалитьВыбранныеToolStripMenuItemClick);
			// 
			// bind_mentor
			// 
			this.bind_mentor.DataMember = "mentor";
			this.bind_mentor.Position = 0;
			// 
			// bind_father_division
			// 
			this.bind_father_division.DataMember = "division";
			this.bind_father_division.Position = 0;
			// 
			// bind_mentor_in_works_helpful
			// 
			this.bind_mentor_in_works_helpful.DataMember = "works";
			// 
			// bind_mentor_in_student_helpful
			// 
			this.bind_mentor_in_student_helpful.DataMember = "student";
			this.bind_mentor_in_student_helpful.Position = 0;
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
			this.workDataGridViewTextBoxColumn.HeaderText = "Работы";
			this.workDataGridViewTextBoxColumn.Name = "workDataGridViewTextBoxColumn";
			this.workDataGridViewTextBoxColumn.ToolTipText = "работы, курировавшиеся этим научным руководителем";
			// 
			// acrankDataGridViewTextBoxColumn
			// 
			this.acrankDataGridViewTextBoxColumn.DataPropertyName = "acrank";
			this.acrankDataGridViewTextBoxColumn.HeaderText = "Академический Ранг";
			this.acrankDataGridViewTextBoxColumn.Name = "acrankDataGridViewTextBoxColumn";
			this.acrankDataGridViewTextBoxColumn.ToolTipText = "академический ранг научного руководителя";
			// 
			// degreeDataGridViewTextBoxColumn
			// 
			this.degreeDataGridViewTextBoxColumn.DataPropertyName = "degree";
			this.degreeDataGridViewTextBoxColumn.HeaderText = "Учёная Степень";
			this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
			this.degreeDataGridViewTextBoxColumn.ToolTipText = "учёная степень научного руководителя";
			// 
			// dividDataGridViewTextBoxColumn
			// 
			this.dividDataGridViewTextBoxColumn.DataPropertyName = "div_id";
			this.dividDataGridViewTextBoxColumn.HeaderText = "Кафедра";
			this.dividDataGridViewTextBoxColumn.Name = "dividDataGridViewTextBoxColumn";
			this.dividDataGridViewTextBoxColumn.ToolTipText = "кафедра, на которой работает этот научный руководитель";
			// 
			// mentor_windows
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 386);
			this.Controls.Add(this.dataGridView_mentor);
			this.Controls.Add(this.tools);
			this.Name = "mentor_windows";
			this.Text = "mentor_windows";
			this.Load += new System.EventHandler(this.mentor_windowsLoad);
			this.tools.ResumeLayout(false);
			this.tools.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_mentor)).EndInit();
			this.contextMenuStrip_mentor.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bind_mentor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_father_division)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_mentor_in_works_helpful)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bind_mentor_in_student_helpful)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private NIRS_Viewer.bind bind_mentor_in_works_helpful;
		private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn acrankDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn workDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
		private NIRS_Viewer.bind bind_mentor_in_student_helpful;
		private NIRS_Viewer.bind bind_father_division;
//		private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dividDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripButton toolStripOpacityMinus;
		private System.Windows.Forms.ToolStripProgressBar toolsOpacityStatus;
		private System.Windows.Forms.ToolStripButton toolsOpacityPlus;
//		private System.Windows.Forms.DataGridViewComboBoxColumn facidDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripMenuItem удалитьВыбранныеToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_mentor;
		private System.Windows.Forms.DataGridView dataGridView_mentor;
		private System.Windows.Forms.ToolStripLabel toolStripTransparency;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripComboBox toolsFindIn;
		private System.Windows.Forms.ToolStripTextBox toolsFindIt;
		private NIRS_Viewer.bind bind_mentor;
//		private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripButton toolStripSave;
		private System.Windows.Forms.ToolStripLabel toolsFindLabel;
		private System.Windows.Forms.ToolStrip tools;
	}
}
