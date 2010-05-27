namespace NIRS
{
    partial class MainForm
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеЗаписейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToWordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.факультетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кафедрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специальностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.научныеРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помошьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryDataGridView = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.добавлениеСтудентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summaryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлБДToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.помошьToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(694, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // файлБДToolStripMenuItem
            // 
            this.файлБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеЗаписейToolStripMenuItem,
            this.добавлениеСтудентовToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.exportToWordToolStripMenuItem1,
            this.toolStripSeparator1,
            this.Exit_ToolStripMenuItem});
            this.файлБДToolStripMenuItem.Name = "файлБДToolStripMenuItem";
            this.файлБДToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлБДToolStripMenuItem.Text = "Файл";
            // 
            // добавлениеЗаписейToolStripMenuItem
            // 
            this.добавлениеЗаписейToolStripMenuItem.Name = "добавлениеЗаписейToolStripMenuItem";
            this.добавлениеЗаписейToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.добавлениеЗаписейToolStripMenuItem.Text = "Добавление записей";
            this.добавлениеЗаписейToolStripMenuItem.Click += new System.EventHandler(this.AddRecord_ToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентToolStripMenuItem,
            this.руководительToolStripMenuItem,
            this.нуToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // студентToolStripMenuItem
            // 
            this.студентToolStripMenuItem.Name = "студентToolStripMenuItem";
            this.студентToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.студентToolStripMenuItem.Text = "Студент";
            this.студентToolStripMenuItem.Click += new System.EventHandler(this.студентToolStripMenuItem_Click);
            // 
            // руководительToolStripMenuItem
            // 
            this.руководительToolStripMenuItem.Name = "руководительToolStripMenuItem";
            this.руководительToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.руководительToolStripMenuItem.Text = "Руководитель";
            this.руководительToolStripMenuItem.Click += new System.EventHandler(this.руководительToolStripMenuItem_Click);
            // 
            // нуToolStripMenuItem
            // 
            this.нуToolStripMenuItem.Name = "нуToolStripMenuItem";
            this.нуToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.нуToolStripMenuItem.Text = "Научные работы";
            this.нуToolStripMenuItem.Click += new System.EventHandler(this.нуToolStripMenuItem_Click);
            // 
            // exportToWordToolStripMenuItem1
            // 
            this.exportToWordToolStripMenuItem1.Name = "exportToWordToolStripMenuItem1";
            this.exportToWordToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.exportToWordToolStripMenuItem1.Text = "Экспорт в Word";
            this.exportToWordToolStripMenuItem1.Click += new System.EventHandler(this.exportToWordToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // Exit_ToolStripMenuItem
            // 
            this.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            this.Exit_ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.Exit_ToolStripMenuItem.Text = "Выход";
            this.Exit_ToolStripMenuItem.Click += new System.EventHandler(this.Exit_ToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.факультетыToolStripMenuItem,
            this.кафедрыToolStripMenuItem,
            this.группыToolStripMenuItem,
            this.специальностиToolStripMenuItem,
            this.руководителиToolStripMenuItem,
            this.студентыToolStripMenuItem,
            this.научныеРаботыToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // факультетыToolStripMenuItem
            // 
            this.факультетыToolStripMenuItem.Name = "факультетыToolStripMenuItem";
            this.факультетыToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.факультетыToolStripMenuItem.Text = "Факультеты";
            this.факультетыToolStripMenuItem.Click += new System.EventHandler(this.факультетыToolStripMenuItem_Click);
            // 
            // кафедрыToolStripMenuItem
            // 
            this.кафедрыToolStripMenuItem.Name = "кафедрыToolStripMenuItem";
            this.кафедрыToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.кафедрыToolStripMenuItem.Text = "Кафедры";
            this.кафедрыToolStripMenuItem.Click += new System.EventHandler(this.кафедрыToolStripMenuItem_Click);
            // 
            // группыToolStripMenuItem
            // 
            this.группыToolStripMenuItem.Name = "группыToolStripMenuItem";
            this.группыToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.группыToolStripMenuItem.Text = "Группы";
            this.группыToolStripMenuItem.Click += new System.EventHandler(this.группыToolStripMenuItem_Click);
            // 
            // специальностиToolStripMenuItem
            // 
            this.специальностиToolStripMenuItem.Name = "специальностиToolStripMenuItem";
            this.специальностиToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.специальностиToolStripMenuItem.Text = "Специальности";
            this.специальностиToolStripMenuItem.Click += new System.EventHandler(this.специальностиToolStripMenuItem_Click);
            // 
            // руководителиToolStripMenuItem
            // 
            this.руководителиToolStripMenuItem.Name = "руководителиToolStripMenuItem";
            this.руководителиToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.руководителиToolStripMenuItem.Text = "Руководители";
            this.руководителиToolStripMenuItem.Click += new System.EventHandler(this.руководителиToolStripMenuItem_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.студентыToolStripMenuItem.Text = "Студенты";
            this.студентыToolStripMenuItem.Click += new System.EventHandler(this.студентыToolStripMenuItem_Click);
            // 
            // научныеРаботыToolStripMenuItem
            // 
            this.научныеРаботыToolStripMenuItem.Name = "научныеРаботыToolStripMenuItem";
            this.научныеРаботыToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.научныеРаботыToolStripMenuItem.Text = "Научные работы";
            this.научныеРаботыToolStripMenuItem.Click += new System.EventHandler(this.научныеРаботыToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // подключениеToolStripMenuItem
            // 
            this.подключениеToolStripMenuItem.Name = "подключениеToolStripMenuItem";
            this.подключениеToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.подключениеToolStripMenuItem.Text = "Подключение";
            this.подключениеToolStripMenuItem.Click += new System.EventHandler(this.connectionsToolStripMenuItem_Click);
            // 
            // помошьToolStripMenuItem
            // 
            this.помошьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помошьToolStripMenuItem.Name = "помошьToolStripMenuItem";
            this.помошьToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.помошьToolStripMenuItem.Text = "Помошь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.About_ToolStripMenuItem_Click);
            // 
            // summaryDataGridView
            // 
            this.summaryDataGridView.AllowUserToAddRows = false;
            this.summaryDataGridView.AllowUserToDeleteRows = false;
            this.summaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summaryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryDataGridView.Location = new System.Drawing.Point(0, 24);
            this.summaryDataGridView.Name = "summaryDataGridView";
            this.summaryDataGridView.ReadOnly = true;
            this.summaryDataGridView.Size = new System.Drawing.Size(694, 306);
            this.summaryDataGridView.TabIndex = 0;
            this.summaryDataGridView.DataSourceChanged += new System.EventHandler(this.summaryDataGridView_DataSourceChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Word document (*.doc)|*.doc";
            // 
            // добавлениеСтудентовToolStripMenuItem
            // 
            this.добавлениеСтудентовToolStripMenuItem.Name = "добавлениеСтудентовToolStripMenuItem";
            this.добавлениеСтудентовToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.добавлениеСтудентовToolStripMenuItem.Text = "Добавление студентов";
            this.добавлениеСтудентовToolStripMenuItem.Click += new System.EventHandler(this.добавлениеСтудентовToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 330);
            this.Controls.Add(this.summaryDataGridView);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "MySQL DataBase Client, NIRS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summaryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеЗаписейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помошьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключениеToolStripMenuItem;
        private System.Windows.Forms.DataGridView summaryDataGridView;
        private System.Windows.Forms.ToolStripMenuItem exportToWordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководительToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem факультетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кафедрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специальностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem научныеРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеСтудентовToolStripMenuItem;
    }
}