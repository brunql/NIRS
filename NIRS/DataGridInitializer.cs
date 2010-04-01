using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace NIRS
{
    public static class DataGridInitializer
    {
        public static void InitFaculty(DataGridView dataGridView)
        {
            System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;

            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "Факультет";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ToolTipText = "Название факультета";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            fullnameDataGridViewTextBoxColumn.HeaderText = "Полное название факультета";
            fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            fullnameDataGridViewTextBoxColumn.ToolTipText = "Полное название факультета";


            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    idDataGridViewTextBoxColumn,
                    nameDataGridViewTextBoxColumn,
                    fullnameDataGridViewTextBoxColumn
                });
        }


        public static void InitDivision(DataGridView dataGridView)
        {

            NIRS_Viewer.bind bind_father_fac = new NIRS_Viewer.bind();
            bind_father_fac.DataMember = "faculty";

            System.Windows.Forms.DataGridViewComboBoxColumn facidDataGridViewComboBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;

            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            facidDataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();

            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "Кафедра";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ToolTipText = "Название кафедры";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            fullnameDataGridViewTextBoxColumn.HeaderText = "Полное название кафедры";
            fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            fullnameDataGridViewTextBoxColumn.ToolTipText = "Полное название кафедры";
            // 
            // facidDataGridViewComboBoxColumn
            // 
            facidDataGridViewComboBoxColumn.DataPropertyName = "fac_id";
            facidDataGridViewComboBoxColumn.DataSource = bind_father_fac;
            facidDataGridViewComboBoxColumn.DisplayMember = "fullname";
            facidDataGridViewComboBoxColumn.HeaderText = "Факультет";
            facidDataGridViewComboBoxColumn.Name = "facidDataGridViewComboBoxColumn";
            facidDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            facidDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            facidDataGridViewComboBoxColumn.ToolTipText = "Факультет, к которому принадлежит кафедра";
            facidDataGridViewComboBoxColumn.ValueMember = "id";

            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    idDataGridViewTextBoxColumn,
                    facidDataGridViewComboBoxColumn,
                    nameDataGridViewTextBoxColumn,
                    fullnameDataGridViewTextBoxColumn
                });
        }

        public static void InitSpec(DataGridView dataGridView)
        {
            NIRS_Viewer.bind bind_father_division = new NIRS_Viewer.bind();
            bind_father_division.DataMember = "division";

            System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewComboBoxColumn dividDataGridViewTextBoxColumn;


            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dividDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dividDataGridViewTextBoxColumn
            // 
            dividDataGridViewTextBoxColumn.DataPropertyName = "div_id";
            dividDataGridViewTextBoxColumn.DataSource = bind_father_division;
            dividDataGridViewTextBoxColumn.DisplayMember = "name";
            dividDataGridViewTextBoxColumn.HeaderText = "Кафедра";
            dividDataGridViewTextBoxColumn.Name = "dividDataGridViewTextBoxColumn";
            dividDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dividDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dividDataGridViewTextBoxColumn.ToolTipText = "Кафедра, к которой принадлежит специальность";
            dividDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            codeDataGridViewTextBoxColumn.HeaderText = "Код";
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            codeDataGridViewTextBoxColumn.ToolTipText = "код специальности";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "Специальность";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ToolTipText = "Название специальности";

            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									idDataGridViewTextBoxColumn,
									dividDataGridViewTextBoxColumn,
									codeDataGridViewTextBoxColumn,
									nameDataGridViewTextBoxColumn});

        }


        public static void InitGroup(DataGridView dataGridView)
        {
            NIRS_Viewer.bind bind_father_spec = new NIRS_Viewer.bind();
            bind_father_spec.DataMember = "spec";
            System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewComboBoxColumn specidDataGridViewComboBoxColumn;

            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            specidDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // specidDataGridViewComboBoxColumn
            // 
            specidDataGridViewComboBoxColumn.DataPropertyName = "spec_id";
            specidDataGridViewComboBoxColumn.DataSource = bind_father_spec;
            specidDataGridViewComboBoxColumn.DisplayMember = "name";
            specidDataGridViewComboBoxColumn.HeaderText = "Специальность";
            specidDataGridViewComboBoxColumn.Name = "specidDataGridViewTextBoxColumn";
            specidDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            specidDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            specidDataGridViewComboBoxColumn.ToolTipText = "специальность, на которой обучается группа";
            specidDataGridViewComboBoxColumn.ValueMember = "id";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            codeDataGridViewTextBoxColumn.HeaderText = "Группа";
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            codeDataGridViewTextBoxColumn.ToolTipText = "название группы";


            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									idDataGridViewTextBoxColumn,
									specidDataGridViewComboBoxColumn,
									codeDataGridViewTextBoxColumn});
        }

        public static void InitMentor(DataGridView dataGridView)
        {
            NIRS_Viewer.bind bind_father_division = new NIRS_Viewer.bind();
            bind_father_division.DataMember = "division";

            System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn workDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewComboBoxColumn dividDataGridViewComboBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn acrankDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;


            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fathernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            workDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dividDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            acrankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ToolTipText = "Имя научного руководителя";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            surnameDataGridViewTextBoxColumn.ToolTipText = "Фамилия научного руководителя";
            // 
            // fathernameDataGridViewTextBoxColumn
            // 
            fathernameDataGridViewTextBoxColumn.DataPropertyName = "fathername";
            fathernameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            fathernameDataGridViewTextBoxColumn.Name = "fathernameDataGridViewTextBoxColumn";
            fathernameDataGridViewTextBoxColumn.ToolTipText = "Отчество научного руководителя";
            // 
            // workDataGridViewTextBoxColumn
            // 
            workDataGridViewTextBoxColumn.DataPropertyName = "work";
            workDataGridViewTextBoxColumn.HeaderText = "Место работы";
            workDataGridViewTextBoxColumn.Name = "workDataGridViewTextBoxColumn";
            workDataGridViewTextBoxColumn.ToolTipText = "Место работы куратора";
            // 
            // dividDataGridViewComboBoxColumn
            // 
            dividDataGridViewComboBoxColumn.DataPropertyName = "div_id";
            dividDataGridViewComboBoxColumn.DataSource = bind_father_division;
            dividDataGridViewComboBoxColumn.DisplayMember = "fullname";
            dividDataGridViewComboBoxColumn.HeaderText = "Кафедра";
            dividDataGridViewComboBoxColumn.Name = "dividDataGridViewComboBoxColumn";
            dividDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dividDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dividDataGridViewComboBoxColumn.ToolTipText = "Кафедра, на которой работает этот научный руководитель";
            dividDataGridViewComboBoxColumn.ValueMember = "id";
            // 
            // acrankDataGridViewTextBoxColumn
            // 
            acrankDataGridViewTextBoxColumn.DataPropertyName = "acrank";
            acrankDataGridViewTextBoxColumn.HeaderText = "Учёное звание";
            acrankDataGridViewTextBoxColumn.Name = "acrankDataGridViewTextBoxColumn";
            acrankDataGridViewTextBoxColumn.ToolTipText = "Ученое звание научного руководителя";
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            degreeDataGridViewTextBoxColumn.DataPropertyName = "degree";
            degreeDataGridViewTextBoxColumn.HeaderText = "Учёная степень";
            degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            degreeDataGridViewTextBoxColumn.ToolTipText = "Учёная степень научного руководителя";


            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    idDataGridViewTextBoxColumn,
                    nameDataGridViewTextBoxColumn,
                    surnameDataGridViewTextBoxColumn,
                    fathernameDataGridViewTextBoxColumn,
                    workDataGridViewTextBoxColumn,
                    acrankDataGridViewTextBoxColumn,
                    degreeDataGridViewTextBoxColumn,
                    dividDataGridViewComboBoxColumn});
        }

        public static void InitStudent(DataGridView dataGridView)
        {
            NIRS_Viewer.bind bind_father_group = new NIRS_Viewer.bind();
            bind_father_group.DataMember = "group";

            System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewComboBoxColumn groupidDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn bornDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn studyDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn grantDataGridViewTextBoxColumn;


            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fathernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            bornDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            studyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();


            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ToolTipText = "имя студента";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            surnameDataGridViewTextBoxColumn.ToolTipText = "фамилия студента";
            // 
            // fathernameDataGridViewTextBoxColumn
            // 
            fathernameDataGridViewTextBoxColumn.DataPropertyName = "fathername";
            fathernameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            fathernameDataGridViewTextBoxColumn.Name = "fathernameDataGridViewTextBoxColumn";
            fathernameDataGridViewTextBoxColumn.ToolTipText = "отчество студента";
            // 
            // groupidDataGridViewTextBoxColumn
            // 
            groupidDataGridViewTextBoxColumn.DataPropertyName = "group_id";
            groupidDataGridViewTextBoxColumn.DataSource = bind_father_group;
            groupidDataGridViewTextBoxColumn.DisplayMember = "code";
            groupidDataGridViewTextBoxColumn.HeaderText = "Группа";
            groupidDataGridViewTextBoxColumn.Name = "groupidDataGridViewTextBoxColumn";
            groupidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            groupidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            groupidDataGridViewTextBoxColumn.ToolTipText = "Группа, в которой учится студент";
            groupidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // bornDataGridViewTextBoxColumn
            // 
            bornDataGridViewTextBoxColumn.DataPropertyName = "born";
            bornDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            bornDataGridViewTextBoxColumn.Name = "bornDataGridViewTextBoxColumn";
            bornDataGridViewTextBoxColumn.ToolTipText = "Дата рождения студента";
            // 
            // studyDataGridViewTextBoxColumn
            // 
            studyDataGridViewTextBoxColumn.DataPropertyName = "study";
            studyDataGridViewTextBoxColumn.HeaderText = "Форма обучения";
            studyDataGridViewTextBoxColumn.Name = "grantDataGridViewTextBoxColumn";
            studyDataGridViewTextBoxColumn.ToolTipText = "Бюджет или СКЦ";
            // 
            // grantDataGridViewTextBoxColumn
            // 
            grantDataGridViewTextBoxColumn.DataPropertyName = "grant";
            grantDataGridViewTextBoxColumn.HeaderText = "Стипендия";
            grantDataGridViewTextBoxColumn.Name = "grantDataGridViewTextBoxColumn";
            grantDataGridViewTextBoxColumn.ToolTipText = "Получает ли студент стипендию, и какую?";


            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        idDataGridViewTextBoxColumn,
                        nameDataGridViewTextBoxColumn,
                        surnameDataGridViewTextBoxColumn,
                        fathernameDataGridViewTextBoxColumn,
                        groupidDataGridViewTextBoxColumn,
                        bornDataGridViewTextBoxColumn,
                        studyDataGridViewTextBoxColumn,
                        grantDataGridViewTextBoxColumn});
        }

        public static void InitWorks(DataGridView dataGridView)
        {

            NIRS_Viewer.bind bind_father_mentor = new NIRS_Viewer.bind();
            bind_father_mentor.DataMember = "mentor";

            NIRS_Viewer.bind bind_father_student = new NIRS_Viewer.bind();
            bind_father_student.DataMember = "student";

            System.Windows.Forms.DataGridViewComboBoxColumn mentoridDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewComboBoxColumn studentidDataGridViewTextBoxColumn;
            System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;


            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mentoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();

            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            studentidDataGridViewTextBoxColumn.DataSource = bind_father_student;
            studentidDataGridViewTextBoxColumn.DisplayMember = "surname";
            studentidDataGridViewTextBoxColumn.HeaderText = "Студент";
            studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            studentidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            studentidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            studentidDataGridViewTextBoxColumn.ToolTipText = "Выбор студента, сделавшего работу";
            studentidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "Название";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ToolTipText = "Название научной работы";
            // 
            // descDataGridViewTextBoxColumn
            // 
            descDataGridViewTextBoxColumn.DataPropertyName = "desc";
            descDataGridViewTextBoxColumn.HeaderText = "Описание";
            descDataGridViewTextBoxColumn.Name = "descDataGridViewTextBoxColumn";
            descDataGridViewTextBoxColumn.ToolTipText = "Описание научной работы";
            // 
            // mentoridDataGridViewTextBoxColumn
            // 
            mentoridDataGridViewTextBoxColumn.DataPropertyName = "mentor_id";
            mentoridDataGridViewTextBoxColumn.DataSource = bind_father_mentor;
            mentoridDataGridViewTextBoxColumn.DisplayMember = "surname";
            mentoridDataGridViewTextBoxColumn.HeaderText = "Руководитель";
            mentoridDataGridViewTextBoxColumn.Name = "mentoridDataGridViewTextBoxColumn";
            mentoridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            mentoridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            mentoridDataGridViewTextBoxColumn.ToolTipText = "Научный руководитель работы";
            mentoridDataGridViewTextBoxColumn.ValueMember = "id";



            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									idDataGridViewTextBoxColumn,
									studentidDataGridViewTextBoxColumn,
									nameDataGridViewTextBoxColumn,
									descDataGridViewTextBoxColumn,
									mentoridDataGridViewTextBoxColumn});
        }

    }
}
