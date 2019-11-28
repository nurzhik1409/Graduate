using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using Graduate.databse;
using Graduate.forms;
using DGVWF;
using System.Drawing;

namespace Graduate
{
    public partial class f_main : MetroForm
    {
        public DataGridViewWithFilter dgv_persons = new DataGridViewWithFilter();
        //DataGridViewWithFilter DG = new DataGridViewWithFilter();

        public f_main()
        {
            InitializeComponent();


            dgv_persons.CellDoubleClick += new DataGridViewCellEventHandler(this.DataGrid);
            dgv_persons.VirtualMode = true;  
            
        }
        // авторизация
        public int idUser = 0;
        public string userRole = "";
        public string userPin = "";

        int ExcelClickOk = 0; // Закрытие процесса Excel используеться в Экпорте
        int id = 0; // Для фильтра поиска

        #region 2Клик по таблице, открывает личную карту с информацие о выбранном студенте
        private void DG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                new f_personalCards(idUser, (int)dgv_persons["id", e.RowIndex].Value).ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region DELETE Правый клик по таблице вызывает Контексное меню - удалить
        private void Dgv_persons_MouseClick_1(object sender, MouseEventArgs e)
        {
           if (e.Button == MouseButtons.Right) { contextDVG.Show(Cursor.Position.X, Cursor.Position.Y); }
        }

        // Выделить строку персоны
        private void Dgv_persons_CellMouseDown_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgv_persons.CurrentCell = dgv_persons.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgv_persons.Rows[e.RowIndex].Selected = true;
                    dgv_persons.Focus();
                    id = (int)dgv_persons["id", e.RowIndex].Value;
                    //Click += new EventHandler(ToolStripMenuItem_Click);
                }
                catch (ArgumentOutOfRangeException) { MessageBox.Show("Выберите ячейку"); }
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ToolStripItem clickedItem = sender as ToolStripItem;
            using (DataBase db = new DataBase())
            {
                var Result = MessageBox.Show("Вы уверены что хотите удалить данную запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                persToWork persW = db.persToWork.FirstOrDefault(obj => obj.id == id);
                try
                {
                    if (Result == DialogResult.Yes)
                    {
                        logs lg = new logs();
                        lg.idUser = this.idUser;
                        lg.typeSql = "Delete";
                        lg.nameTable = "perstToWork, persons";
                        lg.fielTable = "all";
                        lg.oldValue = persW.id + " " + persW.persons.surname + " " + persW.persons.name + " " + persW.persons.patronymic + " " + persW.persons.birthday + " " + persW.persons.gender + " " +
                            //persW.persons.addressCountry + " " + persW.persons.addressRegion + " " + persW.persons.addressArea + " " + persW.persons.addressCity + " " + persW.persons.addressStreet + " " + persW.persons.addressHome + " " + persW.persons.addressFlat + " " +
                            persW.persons.addressCity + " " + persW.persons.addressStreet + " " + persW.persons.addressHome  +
                            persW.persons.typeQualification.nameQualification + " " + persW.persons.trainingDirection + " " + persW.persons.profile + " " + persW.persons.yeatIssue + " " +
                            persW.nameStateOrg + " " + persW.nameOrg + " " + persW.post + " " + persW.freeWork.nameFreeWork + " " + persW.numCertificate + " " + persW.numReference + " " + persW.verificationArrival + " " + persW.commentary;
                        lg.dateCrt = DateTime.Now;
                        db.logs.Add(lg);

                        int id = persW.idPers.Value; 
                        persons pe = db.persons.FirstOrDefault(obj => obj.id == id);
                        db.persons.Remove(pe);

                        //db.persToWork.Remove(persW);
                        db.SaveChanges();
                        MessageBox.Show("Запись удалена");
                    }
                }
                catch { MessageBox.Show("Данной перосны уже нет обновит таблицу нажав на кнопку поиск"); }
            }
        }
        #endregion

        #region Добавить новую персону
        private void Menu_addPerson_Click(object sender, EventArgs e)
        {
            new f_personalCards(idUser).ShowDialog();
        }
        #endregion

        #region Form1_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            countPersons.Text = "Всего записей: " + dgv_persons.Rows.Count.ToString();
            label_excele.Visible = false;// Прогресс заполнения Excele
            ProgressExcele.Visible = false;// Прогресс заполнения Excele

            // авторизация
            String[] arguments = Environment.GetCommandLineArgs();
            Visible = false;
            f_DBLogin dBLogin = new f_DBLogin();
            dBLogin.ShowDialog();
            WindowState = FormWindowState.Maximized;
            if (dBLogin.Pin)
            {
                idUser = dBLogin.idUser;
                userRole = dBLogin.userRole;
                userPin = dBLogin.userPin;
                Visible = true;
            }
            else { Application.Exit(); }
            MenuAdmin.Visible = false;

            /*if (Convert.ToInt32(userRole) == 1)
            {
                MenuAdmin.Visible = true;
            }
            else {
                MenuAdmin.Visible = false;
            }*/
            #endregion

            #region Фильтр поиска
            groupBox1.Size = new Size(541, 513);
            dgv_persons.Bounds = new Rectangle(10, 10, 445, 420);
            dgv_persons.Dock = DockStyle.Fill;
            dgv_persons.AllowUserToAddRows = false;

            groupBox1.Controls.Add(dgv_persons);

            DataTable DT = new DataTable();
            DT.Columns.Add("id");
            DT.Columns.Add("ФИО");
            DT.Columns.Add("Дата рождения");
            DT.Columns.Add("Пол");
            DT.Columns.Add("Адресс проживания");
            DT.Columns.Add("Квалификационный уровень");
            DT.Columns.Add("Направление подготовки");
            DT.Columns.Add("Профиль");
            DT.Columns.Add("Год выпуска");
            DT.Columns.Add("Название государственной организации");
            DT.Columns.Add("Образовательное учреждение");
            DT.Columns.Add("Название организации(предприятия)");
            DT.Columns.Add("Должность");
            DT.Columns.Add("Город организации");
            DT.Columns.Add("№ свидетельства");
            DT.Columns.Add("Самостоятельное трудоустройство");
            DT.Columns.Add("№ справки");
            DT.Columns.Add("Подтверждение прибытия");
            DT.Columns.Add("Дополнительная информация");
            //DG.Columns[0].Visible = false; // id не видим

            //try
            // { Чтобы при фильтрации ошибка не вылетала index = -1 or 0 
            // if (e.RowIndex > 0)

            using (DataBase db = new DataBase())
            {
                var ser = db.persToWork;
                if (ser.Count() > 0)
                {
                    foreach (persToWork pTW in ser)
                    {
                        DT.Rows.Add(
                        pTW.id,
                        pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic,
                        pTW.persons.birthday,
                        pTW.persons.gender,
                        pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome,
                        pTW.persons.typeQualification.nameQualification,
                        pTW.persons.trainingDirection,
                        pTW.persons.profile,
                        pTW.persons.yeatIssue,
                        pTW.nameStateOrg,
                        pTW.educational,
                        pTW.nameOrg,
                        pTW.post,
                        pTW.cityOrg,
                        pTW.numCertificate,
                        pTW.freeWork.nameFreeWork,
                        pTW.numReference,
                        pTW.verificationArrival == "T" ? "В наличии" : "отсутствует",
                        pTW.commentary
                        );
                    }
                }
            }
            countPersons.Text = "Всего записей: " + DT.Rows.Count.ToString();
            DataSet DS = new DataSet();
            DS.Tables.Add(DT);
            dgv_persons.DataSource = DS.Tables[0];
        }
        #endregion
        

        #region О Программе
        private void Menu_aboutProg_Click(object sender, EventArgs e)
        {
            string path = /* Path.GetFullPath(@"TextFile1.txt");*/ //"E:\\Projects\\C#\\Graduate\\Graduate\\TextFile1.txt";
                "AboutGraduate.pdf";
            System.Diagnostics.Process.Start(path);
        }
        #endregion

        #region Экспорт из таблицы в Excel
        public void Menu_exportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_persons.Rows.Count != 0)
                {
                    label_excele.Visible = true;// Прогресс заполнения Excele
                    ProgressExcele.Visible = true;
                    ProgressExcele.Value = 0;
                    ProgressExcele.MaxValue = dgv_persons.Rows.Count;

                    Excel.Application excel = new Excel.Application();
                    Excel.Workbook workbook = excel.Workbooks.Add(Missing.Value);
                    Excel.Worksheet sheet1 = (Excel.Worksheet)workbook.Sheets[1];
                    Excel.Range ExcelRange;
                    int StartCol = 0; 
                    int StartRow = 1;// Скрыть 1 колонку где id
                    int j = 0, i = 0;

                    //Шапка в Excel. Начинаю с 1, что бы не видно было i                    
                    for (j = 1; j < dgv_persons.Columns.Count; j++)
                    {
                        ExcelRange = (Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                        sheet1.Cells[StartRow, StartCol + j].EntireRow.Font.Bold = true; // Жирная первая строка
                        ExcelRange.Value2 = dgv_persons.Columns[j].HeaderText;
                    }
                    StartRow++;

                    // Данные с таблицы.
                    for (i = 0; i < dgv_persons.Rows.Count; i++)
                    {
                        for (j = 1; j < dgv_persons.Columns.Count; j++)
                        {
                            ExcelRange = (Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            ExcelRange.Value2 = dgv_persons[j, i].Value == null ? "" : dgv_persons[j, i].Value;
                            ExcelRange = sheet1.UsedRange;
                        }
                        ProgressExcele.Value++;
                    }
                 
                    excel.Visible = true; // Открыть сам Excel
                    workbook.Close();
                    excel.Quit();
                    
                    ProgressExcele.Visible = false;// Прогресс заполнения Excele
                    label_excele.Visible = false;// Прогресс заполнения Excele
                }
                else { MessageBox.Show("Таблица пустая"); }
            }
            catch { MessageBox.Show("Ошибка импорта"); }
            ExcelClickOk = 1;// Если Excel открывали, передает переменную в F_main_FormClosing для ликвидации процесса
        }
        
       // При закрвтии программы. проверить. был ли экспорт в Excel, если да. то закрыть его
        private void F_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (ExcelClickOk == 1)
                {
                    System.Diagnostics.Process excelProc = System.Diagnostics.Process.GetProcessesByName("EXCEL").Last();
                    if (excelProc != null)
                    {
                        excelProc.Kill();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region Приказ Свободное трудоустройство
        private void Menu_FreeWork_Click(object sender, EventArgs e)
        {
            new f_OrderFreeWork(idUser).ShowDialog();
        }
        #endregion

        #region Выход из програмы
        private void Menu_exit_Click(object sender, EventArgs e)
        { Close(); }
        #endregion

        #region Нумерация строк
        private void Dgv_persons_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.dgv_persons.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dgv_persons.Rows[index].HeaderCell.Value = indexStr;
        }
        #endregion

        #region Удалить студентов с годом выпуска
        private void Menu_delYearIssue_Click(object sender, EventArgs e)
        {
            new f_clearPersYear(idUser).ShowDialog();
        }
        #endregion
    }
}
