namespace NIRS
{
    partial class FindStudentDialogForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblSpecialize = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentFathername = new System.Windows.Forms.TextBox();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.labelCaption = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.lblKurs = new System.Windows.Forms.Label();
            this.cmbKurs = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSecondName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFaculty, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSpecialize, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblGroup, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtStudentName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtStudentFathername, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtStudentSurname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFaculty, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDivision, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtSpec, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtGroup, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblKurs, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmbKurs, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 255);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(200, 26);
            this.lblName.TabIndex = 78;
            this.lblName.Text = "Имя";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstName.Location = new System.Drawing.Point(3, 56);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(200, 26);
            this.lblFirstName.TabIndex = 76;
            this.lblFirstName.Text = "Фамилия";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSecondName.Location = new System.Drawing.Point(3, 82);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(200, 26);
            this.lblSecondName.TabIndex = 80;
            this.lblSecondName.Text = "Отчество";
            this.lblSecondName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFaculty.Location = new System.Drawing.Point(3, 108);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(200, 26);
            this.lblFaculty.TabIndex = 81;
            this.lblFaculty.Text = "Факультет";
            this.lblFaculty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSpecialize
            // 
            this.lblSpecialize.AutoSize = true;
            this.lblSpecialize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpecialize.Location = new System.Drawing.Point(3, 160);
            this.lblSpecialize.Name = "lblSpecialize";
            this.lblSpecialize.Size = new System.Drawing.Size(200, 26);
            this.lblSpecialize.TabIndex = 84;
            this.lblSpecialize.Text = "Специальность";
            this.lblSpecialize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 26);
            this.label15.TabIndex = 89;
            this.label15.Text = "Кафедра";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGroup.Location = new System.Drawing.Point(3, 186);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(200, 26);
            this.lblGroup.TabIndex = 85;
            this.lblGroup.Text = "Группа";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentName.Location = new System.Drawing.Point(209, 33);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(200, 20);
            this.txtStudentName.TabIndex = 1;
            // 
            // txtStudentFathername
            // 
            this.txtStudentFathername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentFathername.Location = new System.Drawing.Point(209, 85);
            this.txtStudentFathername.Name = "txtStudentFathername";
            this.txtStudentFathername.Size = new System.Drawing.Size(200, 20);
            this.txtStudentFathername.TabIndex = 3;
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentSurname.Location = new System.Drawing.Point(209, 59);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(200, 20);
            this.txtStudentSurname.TabIndex = 2;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFaculty.Location = new System.Drawing.Point(209, 111);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(200, 20);
            this.txtFaculty.TabIndex = 4;
            // 
            // txtDivision
            // 
            this.txtDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDivision.Location = new System.Drawing.Point(209, 137);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(200, 20);
            this.txtDivision.TabIndex = 5;
            // 
            // txtSpec
            // 
            this.txtSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSpec.Location = new System.Drawing.Point(209, 163);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(200, 20);
            this.txtSpec.TabIndex = 6;
            // 
            // txtGroup
            // 
            this.txtGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGroup.Location = new System.Drawing.Point(209, 189);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(200, 20);
            this.txtGroup.TabIndex = 7;
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCaption, 2);
            this.labelCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCaption.Location = new System.Drawing.Point(3, 0);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(406, 30);
            this.labelCaption.TabIndex = 94;
            this.labelCaption.Text = "Выборка студентов по следующим критериям:";
            this.labelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 274);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 55);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.buttonFind, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCancel, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(412, 36);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonFind
            // 
            this.buttonFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFind.Location = new System.Drawing.Point(106, 3);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(97, 30);
            this.buttonFind.TabIndex = 8;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Location = new System.Drawing.Point(209, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(97, 30);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // lblKurs
            // 
            this.lblKurs.AutoSize = true;
            this.lblKurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKurs.Location = new System.Drawing.Point(3, 212);
            this.lblKurs.Name = "lblKurs";
            this.lblKurs.Size = new System.Drawing.Size(200, 23);
            this.lblKurs.TabIndex = 96;
            this.lblKurs.Text = "Курс";
            this.lblKurs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbKurs
            // 
            this.cmbKurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbKurs.FormattingEnabled = true;
            this.cmbKurs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbKurs.Location = new System.Drawing.Point(209, 215);
            this.cmbKurs.Name = "cmbKurs";
            this.cmbKurs.Size = new System.Drawing.Size(200, 21);
            this.cmbKurs.TabIndex = 8;
            // 
            // FindStudentDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FindStudentDialogForm";
            this.Text = "Поиск среди студентов";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label lblSpecialize;
        private System.Windows.Forms.TextBox txtStudentFathername;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.Label lblKurs;
        private System.Windows.Forms.ComboBox cmbKurs;
    }
}