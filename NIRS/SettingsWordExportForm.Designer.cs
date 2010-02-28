namespace NIRS
{
    partial class SettingsWordExportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAdditionConfig1 = new System.Windows.Forms.Label();
            this.labelAdditionConfig2 = new System.Windows.Forms.Label();
            this.txtSaveFileName = new System.Windows.Forms.TextBox();
            this.checkBoxOpenFileAfterExport = new System.Windows.Forms.CheckBox();
            this.btnGetFileName = new System.Windows.Forms.Button();
            this.groupBoxOkCancel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxConfig.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxOkCancel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxConfig.Location = new System.Drawing.Point(0, 0);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(475, 231);
            this.groupBoxConfig.TabIndex = 0;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Настройка";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.23076F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.42735F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.95726F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelAdditionConfig1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelAdditionConfig2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtSaveFileName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxOpenFileAfterExport, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnGetFileName, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(469, 212);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь для сохранения:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Открыть файл после экспорта?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAdditionConfig1
            // 
            this.labelAdditionConfig1.AutoSize = true;
            this.labelAdditionConfig1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAdditionConfig1.Location = new System.Drawing.Point(3, 49);
            this.labelAdditionConfig1.Name = "labelAdditionConfig1";
            this.labelAdditionConfig1.Size = new System.Drawing.Size(201, 50);
            this.labelAdditionConfig1.TabIndex = 2;
            this.labelAdditionConfig1.Text = "labelAdditionConfig1";
            this.labelAdditionConfig1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAdditionConfig1.Visible = false;
            // 
            // labelAdditionConfig2
            // 
            this.labelAdditionConfig2.AutoSize = true;
            this.labelAdditionConfig2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAdditionConfig2.Location = new System.Drawing.Point(3, 99);
            this.labelAdditionConfig2.Name = "labelAdditionConfig2";
            this.labelAdditionConfig2.Size = new System.Drawing.Size(201, 50);
            this.labelAdditionConfig2.TabIndex = 3;
            this.labelAdditionConfig2.Text = "labelAdditionConfig2";
            this.labelAdditionConfig2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAdditionConfig2.Visible = false;
            // 
            // txtSaveFileName
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtSaveFileName, 2);
            this.txtSaveFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSaveFileName.Location = new System.Drawing.Point(210, 3);
            this.txtSaveFileName.Name = "txtSaveFileName";
            this.txtSaveFileName.Size = new System.Drawing.Size(185, 20);
            this.txtSaveFileName.TabIndex = 4;
            this.txtSaveFileName.Text = "C:\\Users\\Миха\\Documents\\test.doc";
            // 
            // checkBoxOpenFileAfterExport
            // 
            this.checkBoxOpenFileAfterExport.AutoSize = true;
            this.checkBoxOpenFileAfterExport.Checked = true;
            this.checkBoxOpenFileAfterExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOpenFileAfterExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxOpenFileAfterExport.Location = new System.Drawing.Point(210, 32);
            this.checkBoxOpenFileAfterExport.Name = "checkBoxOpenFileAfterExport";
            this.checkBoxOpenFileAfterExport.Size = new System.Drawing.Size(113, 14);
            this.checkBoxOpenFileAfterExport.TabIndex = 5;
            this.checkBoxOpenFileAfterExport.UseVisualStyleBackColor = true;
            // 
            // btnGetFileName
            // 
            this.btnGetFileName.Location = new System.Drawing.Point(401, 3);
            this.btnGetFileName.Name = "btnGetFileName";
            this.btnGetFileName.Size = new System.Drawing.Size(24, 23);
            this.btnGetFileName.TabIndex = 6;
            this.btnGetFileName.Text = "...";
            this.btnGetFileName.UseVisualStyleBackColor = true;
            this.btnGetFileName.Click += new System.EventHandler(this.btnGetFileName_Click);
            // 
            // groupBoxOkCancel
            // 
            this.groupBoxOkCancel.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxOkCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxOkCancel.Location = new System.Drawing.Point(0, 231);
            this.groupBoxOkCancel.Name = "groupBoxOkCancel";
            this.groupBoxOkCancel.Size = new System.Drawing.Size(475, 54);
            this.groupBoxOkCancel.TabIndex = 1;
            this.groupBoxOkCancel.TabStop = false;
            this.groupBoxOkCancel.Text = "Управление";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnOk, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(120, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(111, 29);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(237, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Word documents (*.doc)|*.doc";
            // 
            // SettingsWordExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 285);
            this.Controls.Add(this.groupBoxConfig);
            this.Controls.Add(this.groupBoxOkCancel);
            this.Name = "SettingsWordExportForm";
            this.Text = "SettingsWordExportForm";
            this.groupBoxConfig.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBoxOkCancel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.GroupBox groupBoxOkCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAdditionConfig1;
        private System.Windows.Forms.Label labelAdditionConfig2;
        private System.Windows.Forms.TextBox txtSaveFileName;
        private System.Windows.Forms.CheckBox checkBoxOpenFileAfterExport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGetFileName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}