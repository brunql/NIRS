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
    partial class FixProblemsBaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixProblemsBaseForm));
            this.tools = new System.Windows.Forms.ToolStrip();
            this.toolStripFixed = new System.Windows.Forms.ToolStripButton();
            this.toolsStepBack = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataBinding = new NIRS_Viewer.bind();
            this.tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBinding)).BeginInit();
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
            this.toolStripFixed.Size = new System.Drawing.Size(95, 22);
            this.toolStripFixed.Text = "Исправлено";
            this.toolStripFixed.Click += new System.EventHandler(this.ToolStripFixed_Click);
            // 
            // toolsStepBack
            // 
            this.toolsStepBack.Image = ((System.Drawing.Image)(resources.GetObject("toolsStepBack.Image")));
            this.toolsStepBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsStepBack.Name = "toolsStepBack";
            this.toolsStepBack.Size = new System.Drawing.Size(82, 22);
            this.toolsStepBack.Text = "Шаг назад";
            this.toolsStepBack.Click += new System.EventHandler(this.ToolStepBack_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.DataSource = this.dataBinding;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(492, 254);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCellValueChanged);
            this.dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewCellBeginEdit);
            // 
            // dataBinding
            // 
            this.dataBinding.Position = 0;
            // 
            // FixProblemsBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 279);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.tools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FixProblemsBaseForm";
            this.Text = "FixProblemsBaseForm";
            this.Load += new System.EventHandler(this.FixProblemsBaseForm_Load);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		private System.Windows.Forms.ToolStripButton toolsStepBack;
		private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripButton toolStripFixed;

        protected System.Windows.Forms.DataGridView dataGridView;
        protected NIRS_Viewer.bind dataBinding;
	}
}
