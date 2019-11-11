using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using Graduate.databse;
using Graduate.forms;
//using System.Drawing;

namespace Graduate
{
    public partial class f_main : MetroForm
    {
        public f_main() { InitializeComponent(); }

        // авторизация
        public int idUser = 0;
        public string userRole = "";
        public string userPin = "";

        int ExcelClickOk = 0; // Закрытие процесса Excel используеться в Экпорте
        int id = 0; // Для фильтра поиска

        #region 2Клик по таблице, открывает личную карту с информацие о выбранном студенте
        private void Dgv_persons_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                new f_personalCards(idUser, (int)dgv_persons["id", e.RowIndex].Value).ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region DELETE Правый клик по таблице вызывает Контексное меню - удалить

        // контесное меню таблицы
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

        #region Фильтр поиска
        // Файл-Фильтры скрыть/покзать панель
        private void Menu_filter_Click(object sender, EventArgs e)
        {
            if (group_Search.Visible == true)
                group_Search.Visible = false;
            else
                group_Search.Visible = true;
            return;
        }

        public void funFilter()
        {
            dgv_persons.Columns.Clear();
            dgv_persons.Rows.Clear();
            dgv_persons.Columns.Add("id", "id"); // 0
            dgv_persons.Columns.Add("surname, name, patronymic", "ФИО"); // 1
            //dgv_persons.Columns.Add("name", "Имя"); // 2
            //dgv_persons.Columns.Add("patronymic", "Отчество"); //  3
            dgv_persons.Columns.Add("birthday", "Дата рождения"); // 2
            dgv_persons.Columns.Add("gender", "Пол"); // 3

           // dgv_persons.Columns.Add("addressRegion", "Область"); // 7
            //dgv_persons.Columns.Add("addressArea", "Район"); // 8
            dgv_persons.Columns.Add("addressCountry, addressCity, addressStreet, addressHome", "Адрес проживания"); // 4
          //  dgv_persons.Columns.Add("addressStreet", "Улица"); // 4
          //  dgv_persons.Columns.Add("addressHome", "дом"); // 5
            //dgv_persons.Columns.Add("addressFlat", "квартира"); // 12

            dgv_persons.Columns.Add("nameQualification", "Квалификационный уровень"); // 5
            dgv_persons.Columns.Add("trainingDirection", "Направление подготовки"); // 6
            dgv_persons.Columns.Add("profile", "Профиль"); // 7
            dgv_persons.Columns.Add("yeatIssue", "Год выпуска"); // 8

            dgv_persons.Columns.Add("nameStateOrg", "Название государственной организации"); // 9
            dgv_persons.Columns.Add("educational", "Образовательное учреждение"); // 10
            dgv_persons.Columns.Add("nameOrg", "Название организации(предприятия)"); // 11
            dgv_persons.Columns.Add("post", "Должность"); // 12
            dgv_persons.Columns.Add("cityOrg", "Город организации"); // 13

            dgv_persons.Columns.Add("numCertificate", "№ свидетельства"); // 14
            dgv_persons.Columns.Add("nameFreeWork", "Самостоятельное трудоустройство"); // 15
            dgv_persons.Columns.Add("numReference", "№ справки"); // 16
            dgv_persons.Columns.Add("verificationArrival", "Подтверждение прибытия"); // 17
            dgv_persons.Columns.Add("commentary", "Дополнительная информация"); // 18
            dgv_persons.Columns[0].Visible = false; // id не видим
        }
        private void MButSerch_Click(object sender, EventArgs e)
        {
            int i = 0;
            using (DataBase db = new DataBase())
            {
                if (mRadio_Surname.Checked == true)
                {
                    funFilter();
                    //dgv_persons[20, i].Value = "\"" + pTW.freeWork.nameFreeWork + "\""; 
                    //var ser = db.persToWork.Where(obj => mTextB_Search.Text.Contains(obj.persons.surname)).ToList();
                    var ser = db.persToWork.Where(obj => obj.persons.surname == mTextB_Search.Text).ToList();
                    if (ser.Count() > 0)
                    {
                        dgv_persons.Rows.Add(ser.Count());
                        foreach (persToWork pTW in ser) // Заполнение таблицы 
                        {
                            dgv_persons[0, i].Value = pTW.id;
                            dgv_persons[1, i].Value = pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic;
                            dgv_persons[2, i].Value = pTW.persons.birthday.Value.Date.ToShortDateString(); // longDate для месяца
                            dgv_persons[3, i].Value = pTW.persons.gender;

                            //dgv_persons[5, i].Value = pTW.persons.addressRegion;
                            // dgv_persons[6, i].Value = pTW.persons.addressArea;
                            dgv_persons[4, i].Value = pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome;
                            //dgv_persons[10, i].Value = pTW.persons.addressFlat;

                            dgv_persons[5, i].Value = pTW.persons.typeQualification.nameQualification;
                            dgv_persons[6, i].Value = pTW.persons.trainingDirection;
                            dgv_persons[7, i].Value = pTW.persons.profile;
                            dgv_persons[8, i].Value = pTW.persons.yeatIssue;
                            dgv_persons[9, i].Value = pTW.nameStateOrg;
                            dgv_persons[10, i].Value = pTW.educational;
                            dgv_persons[11, i].Value = pTW.nameOrg;
                            dgv_persons[12, i].Value = pTW.post;
                            dgv_persons[13, i].Value = pTW.cityOrg;
                            dgv_persons[14, i].Value = pTW.numCertificate;
                            dgv_persons[15, i].Value = pTW.freeWork.nameFreeWork;
                            dgv_persons[16, i].Value = pTW.numReference;
                            dgv_persons[17, i].Value = pTW.verificationArrival == "T" ? "В наличии" : "отсутствует"; ;
                            dgv_persons[18, i].Value = pTW.commentary;
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Человека с такой Фамилией нет");
                        mTextB_Search.Text = "";
                    }
                }
                if (mRadio_Birthday.Checked == true)
                {
                    funFilter();
                    var ser = db.persToWork.Where(obj => mTextB_Search.Text.Contains(obj.persons.birthday.Value.Year.ToString())).ToList();
                    if (ser.Count() > 0)
                    {
                        dgv_persons.Rows.Add(ser.Count());
                        foreach (persToWork pTW in ser) // Заполнение таблицы 
                        {
                            dgv_persons[0, i].Value = pTW.id;
                            dgv_persons[1, i].Value = pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic;
                            dgv_persons[2, i].Value = pTW.persons.birthday.Value.Date.ToShortDateString(); // longDate для месяца
                            dgv_persons[3, i].Value = pTW.persons.gender;
                            dgv_persons[4, i].Value = pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome;
                            dgv_persons[5, i].Value = pTW.persons.typeQualification.nameQualification;
                            dgv_persons[6, i].Value = pTW.persons.trainingDirection;
                            dgv_persons[7, i].Value = pTW.persons.profile;
                            dgv_persons[8, i].Value = pTW.persons.yeatIssue;
                            dgv_persons[9, i].Value = pTW.nameStateOrg;
                            dgv_persons[10, i].Value = pTW.educational;
                            dgv_persons[11, i].Value = pTW.nameOrg;
                            dgv_persons[12, i].Value = pTW.post;
                            dgv_persons[13, i].Value = pTW.cityOrg;
                            dgv_persons[14, i].Value = pTW.numCertificate;
                            dgv_persons[15, i].Value = pTW.freeWork.nameFreeWork;
                            dgv_persons[16, i].Value = pTW.numReference;
                            dgv_persons[17, i].Value = pTW.verificationArrival == "T" ? "В наличии" : "отсутствует"; ;
                            dgv_persons[18, i].Value = pTW.commentary;
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Человека с такой датой нет");
                        mTextB_Search.Text = "";
                    }
                }
                if (mRadio_gender.Checked == true)
                {
                    funFilter();
                    var ser = db.persToWork.Where(obj => mTextB_Search.Text.Contains(obj.persons.gender)).ToList();
                    if (ser.Count() > 0)
                    {
                        dgv_persons.Rows.Add(ser.Count());
                        foreach (persToWork pTW in ser) // Заполнение таблицы 
                        {
                            dgv_persons[0, i].Value = pTW.id;
                            dgv_persons[1, i].Value = pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic;
                            dgv_persons[2, i].Value = pTW.persons.birthday.Value.Date.ToShortDateString(); // longDate для месяца
                            dgv_persons[3, i].Value = pTW.persons.gender;
                            dgv_persons[4, i].Value = pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome;
                            dgv_persons[5, i].Value = pTW.persons.typeQualification.nameQualification;
                            dgv_persons[6, i].Value = pTW.persons.trainingDirection;
                            dgv_persons[7, i].Value = pTW.persons.profile;
                            dgv_persons[8, i].Value = pTW.persons.yeatIssue;
                            dgv_persons[9, i].Value = pTW.nameStateOrg;
                            dgv_persons[10, i].Value = pTW.educational;
                            dgv_persons[11, i].Value = pTW.nameOrg;
                            dgv_persons[12, i].Value = pTW.post;
                            dgv_persons[13, i].Value = pTW.cityOrg;
                            dgv_persons[14, i].Value = pTW.numCertificate;
                            dgv_persons[15, i].Value = pTW.freeWork.nameFreeWork;
                            dgv_persons[16, i].Value = pTW.numReference;
                            dgv_persons[17, i].Value = pTW.verificationArrival == "T" ? "В наличии" : "отсутствует"; ;
                            dgv_persons[18, i].Value = pTW.commentary;
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Человек данного пола отсутсвуют. Правильно вводить 'муж' или 'жен' в строку поиска");
                        mTextB_Search.Text = "";
                    }
                }
                if (mRadio_addressCity.Checked == true)
                {
                    funFilter();
                    var ser = db.persToWork.Where(obj => obj.persons.addressCity == mTextB_Search.Text).ToList();
                    if (ser.Count() > 0)
                    {
                        dgv_persons.Rows.Add(ser.Count());
                        foreach (persToWork pTW in ser) // Заполнение таблицы 
                        {
                            dgv_persons[0, i].Value = pTW.id;
                            dgv_persons[1, i].Value = pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic;
                            dgv_persons[2, i].Value = pTW.persons.birthday.Value.Date.ToShortDateString(); // longDate для месяца
                            dgv_persons[3, i].Value = pTW.persons.gender;
                            dgv_persons[4, i].Value = pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome;
                            dgv_persons[5, i].Value = pTW.persons.typeQualification.nameQualification;
                            dgv_persons[6, i].Value = pTW.persons.trainingDirection;
                            dgv_persons[7, i].Value = pTW.persons.profile;
                            dgv_persons[8, i].Value = pTW.persons.yeatIssue;
                            dgv_persons[9, i].Value = pTW.nameStateOrg;
                            dgv_persons[10, i].Value = pTW.educational;
                            dgv_persons[11, i].Value = pTW.nameOrg;
                            dgv_persons[12, i].Value = pTW.post;
                            dgv_persons[13, i].Value = pTW.cityOrg;
                            dgv_persons[14, i].Value = pTW.numCertificate;
                            dgv_persons[15, i].Value = pTW.freeWork.nameFreeWork;
                            dgv_persons[16, i].Value = pTW.numReference;
                            dgv_persons[17, i].Value = pTW.verificationArrival == "T" ? "В наличии" : "отсутствует"; ;
                            dgv_persons[18, i].Value = pTW.commentary;
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Данного города нет или в базе отсутсвуют людей, которые в нем проживают");
                        mTextB_Search.Text = "";
                    }
                }

                if (mRadio_qualification.Checked == true)
                {
                    funFilter();
                    var ser = db.persToWork.Where(obj => mTextB_Search.Text.Contains(obj.persons.typeQualification.nameQualification)).ToList();
                    if (ser.Count() > 0)
                    {
                        dgv_persons.Rows.Add(ser.Count());
                        foreach (persToWork pTW in ser) // Заполнение таблицы 
                        {
                            dgv_persons[0, i].Value = pTW.id;
                            dgv_persons[1, i].Value = pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic;
                            dgv_persons[2, i].Value = pTW.persons.birthday.Value.Date.ToShortDateString(); // longDate для месяца
                            dgv_persons[3, i].Value = pTW.persons.gender;
                            dgv_persons[4, i].Value = pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome;
                            dgv_persons[5, i].Value = pTW.persons.typeQualification.nameQualification;
                            dgv_persons[6, i].Value = pTW.persons.trainingDirection;
                            dgv_persons[7, i].Value = pTW.persons.profile;
                            dgv_persons[8, i].Value = pTW.persons.yeatIssue;
                            dgv_persons[9, i].Value = pTW.nameStateOrg;
                            dgv_persons[10, i].Value = pTW.educational;
                            dgv_persons[11, i].Value = pTW.nameOrg;
                            dgv_persons[12, i].Value = pTW.post;
                            dgv_persons[13, i].Value = pTW.cityOrg;
                            dgv_persons[14, i].Value = pTW.numCertificate;
                            dgv_persons[15, i].Value = pTW.freeWork.nameFreeWork;
                            dgv_persons[16, i].Value = pTW.numReference;
                            dgv_persons[17, i].Value = pTW.verificationArrival == "T" ? "В наличии" : "отсутствует"; ;
                            dgv_persons[18, i].Value = pTW.commentary;
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Человека с такой датой нет");
                        mTextB_Search.Text = "";
                    }
                }
                if (mRadio_TrainingDirection.Checked == true)
                {
                    funFilter();
                    var ser = db.persToWork.Where(obj => mTextB_Search.Text.Contains(obj.persons.trainingDirection)).ToList();
                    if (ser.Count() > 0)
                    {
                        dgv_persons.Rows.Add(ser.Count());
                        foreach (persToWork pTW in ser) // Заполнение таблицы 
                        {
                            dgv_persons[0, i].Value = pTW.id;
                            dgv_persons[1, i].Value = pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic;
                            dgv_persons[2, i].Value = pTW.persons.birthday.Value.Date.ToShortDateString(); // longDate для месяца
                            dgv_persons[3, i].Value = pTW.persons.gender;
                            dgv_persons[4, i].Value = pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome;
                            dgv_persons[5, i].Value = pTW.persons.typeQualification.nameQualification;
                            dgv_persons[6, i].Value = pTW.persons.trainingDirection;
                            dgv_persons[7, i].Value = pTW.persons.profile;
                            dgv_persons[8, i].Value = pTW.persons.yeatIssue;
                            dgv_persons[9, i].Value = pTW.nameStateOrg;
                            dgv_persons[10, i].Value = pTW.educational;
                            dgv_persons[11, i].Value = pTW.nameOrg;
                            dgv_persons[12, i].Value = pTW.post;
                            dgv_persons[13, i].Value = pTW.cityOrg;
                            dgv_persons[14, i].Value = pTW.numCertificate;
                            dgv_persons[15, i].Value = pTW.freeWork.nameFreeWork;
                            dgv_persons[16, i].Value = pTW.numReference;
                            dgv_persons[17, i].Value = pTW.verificationArrival == "T" ? "В наличии" : "отсутствует"; ;
                            dgv_persons[18, i].Value = pTW.commentary;
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Человека с такой датой нет");
                        mTextB_Search.Text = "";
                    }
                }
                if (mRadio_profile.Checked == true)
                {
                    funFilter();
                    var ser = db.persToWork.Where(obj => mTextB_Search.Text.Contains(obj.persons.profile)).ToList();
                    if (ser.Count() > 0)
                    {
                        dgv_persons.Rows.Add(ser.Count());
                        foreach (persToWork pTW in ser) // Заполнение таблицы 
                        {
                            dgv_persons[0, i].Value = pTW.id;
                            dgv_persons[1, i].Value = pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic;
                            dgv_persons[2, i].Value = pTW.persons.birthday.Value.Date.ToShortDateString(); // longDate для месяца
                            dgv_persons[3, i].Value = pTW.persons.gender;
                            dgv_persons[4, i].Value = pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome;
                            dgv_persons[5, i].Value = pTW.persons.typeQualification.nameQualification;
                            dgv_persons[6, i].Value = pTW.persons.trainingDirection;
                            dgv_persons[7, i].Value = pTW.persons.profile;
                            dgv_persons[8, i].Value = pTW.persons.yeatIssue;
                            dgv_persons[9, i].Value = pTW.nameStateOrg;
                            dgv_persons[10, i].Value = pTW.educational;
                            dgv_persons[11, i].Value = pTW.nameOrg;
                            dgv_persons[12, i].Value = pTW.post;
                            dgv_persons[13, i].Value = pTW.cityOrg;
                            dgv_persons[14, i].Value = pTW.numCertificate;
                            dgv_persons[15, i].Value = pTW.freeWork.nameFreeWork;
                            dgv_persons[16, i].Value = pTW.numReference;
                            dgv_persons[17, i].Value = pTW.verificationArrival == "T" ? "В наличии" : "отсутствует"; ;
                            dgv_persons[18, i].Value = pTW.commentary;
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Человека с таким профилем нет");
                        mTextB_Search.Text = "";
                    }
                }
                if (mRadio_YearIssue.Checked == true)
                {
                    funFilter();
                    var ser = db.persToWork.Where(obj => mTextB_Search.Text.Contains(obj.persons.yeatIssue.Value.ToString())).ToList();
                    if (ser.Count() > 0)
                    {
                        dgv_persons.Rows.Add(ser.Count());
                        foreach (persToWork pTW in ser) // Заполнение таблицы 
                        {
                            dgv_persons[0, i].Value = pTW.id;
                            dgv_persons[1, i].Value = pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic;
                            dgv_persons[2, i].Value = pTW.persons.birthday.Value.Date.ToShortDateString(); // longDate для месяца
                            dgv_persons[3, i].Value = pTW.persons.gender;
                            dgv_persons[4, i].Value = pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome;
                            dgv_persons[5, i].Value = pTW.persons.typeQualification.nameQualification;
                            dgv_persons[6, i].Value = pTW.persons.trainingDirection;
                            dgv_persons[7, i].Value = pTW.persons.profile;
                            dgv_persons[8, i].Value = pTW.persons.yeatIssue;
                            dgv_persons[9, i].Value = pTW.nameStateOrg;
                            dgv_persons[10, i].Value = pTW.educational;
                            dgv_persons[11, i].Value = pTW.nameOrg;
                            dgv_persons[12, i].Value = pTW.post;
                            dgv_persons[13, i].Value = pTW.cityOrg;
                            dgv_persons[14, i].Value = pTW.numCertificate;
                            dgv_persons[15, i].Value = pTW.freeWork.nameFreeWork;
                            dgv_persons[16, i].Value = pTW.numReference;
                            dgv_persons[17, i].Value = pTW.verificationArrival == "T" ? "В наличии" : "отсутствует"; ;
                            dgv_persons[18, i].Value = pTW.commentary;
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("В этом году нет выпускников");
                        mTextB_Search.Text = "";
                    }
                }

                if (mRadio_nameStateOrg.Checked == true)
                {
                    funFilter();
                    var ser = db.persToWork.Where(obj => mTextB_Search.Text.Contains(obj.nameStateOrg)).ToList();
                    if (ser.Count() > 0)
                    {
                        dgv_persons.Rows.Add(ser.Count());
                        foreach (persToWork pTW in ser) // Заполнение таблицы 
                        {
                            dgv_persons[0, i].Value = pTW.id;
                            dgv_persons[1, i].Value = pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic;
                            dgv_persons[2, i].Value = pTW.persons.birthday.Value.Date.ToShortDateString(); // longDate для месяца
                            dgv_persons[3, i].Value = pTW.persons.gender;
                            dgv_persons[4, i].Value = pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome;
                            dgv_persons[5, i].Value = pTW.persons.typeQualification.nameQualification;
                            dgv_persons[6, i].Value = pTW.persons.trainingDirection;
                            dgv_persons[7, i].Value = pTW.persons.profile;
                            dgv_persons[8, i].Value = pTW.persons.yeatIssue;
                            dgv_persons[9, i].Value = pTW.nameStateOrg;
                            dgv_persons[10, i].Value = pTW.educational;
                            dgv_persons[11, i].Value = pTW.nameOrg;
                            dgv_persons[12, i].Value = pTW.post;
                            dgv_persons[13, i].Value = pTW.cityOrg;
                            dgv_persons[14, i].Value = pTW.numCertificate;
                            dgv_persons[15, i].Value = pTW.freeWork.nameFreeWork;
                            dgv_persons[16, i].Value = pTW.numReference;
                            dgv_persons[17, i].Value = pTW.verificationArrival == "T" ? "В наличии" : "отсутствует"; ;
                            dgv_persons[18, i].Value = pTW.commentary;
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Человека с таким профилем нет");
                        mTextB_Search.Text = "";
                    }
                }
                if (mRadio_educational.Checked == true)
                {
                    funFilter();
                    var ser = db.persToWork.Where(obj => mTextB_Search.Text.Contains(obj.educational)).ToList();
                    if (ser.Count() > 0)
                    {
                        dgv_persons.Rows.Add(ser.Count());
                        foreach (persToWork pTW in ser) // Заполнение таблицы 
                        {
                            dgv_persons[0, i].Value = pTW.id;
                            dgv_persons[1, i].Value = pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic;
                            dgv_persons[2, i].Value = pTW.persons.birthday.Value.Date.ToShortDateString(); // longDate для месяца
                            dgv_persons[3, i].Value = pTW.persons.gender;
                            dgv_persons[4, i].Value = pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome;
                            dgv_persons[5, i].Value = pTW.persons.typeQualification.nameQualification;
                            dgv_persons[6, i].Value = pTW.persons.trainingDirection;
                            dgv_persons[7, i].Value = pTW.persons.profile;
                            dgv_persons[8, i].Value = pTW.persons.yeatIssue;
                            dgv_persons[9, i].Value = pTW.nameStateOrg;
                            dgv_persons[10, i].Value = pTW.educational;
                            dgv_persons[11, i].Value = pTW.nameOrg;
                            dgv_persons[12, i].Value = pTW.post;
                            dgv_persons[13, i].Value = pTW.cityOrg;
                            dgv_persons[14, i].Value = pTW.numCertificate;
                            dgv_persons[15, i].Value = pTW.freeWork.nameFreeWork;
                            dgv_persons[16, i].Value = pTW.numReference;
                            dgv_persons[17, i].Value = pTW.verificationArrival == "T" ? "В наличии" : "отсутствует"; ;
                            dgv_persons[18, i].Value = pTW.commentary;
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Данного образовательного учреждения нет или в базе отсутсвуют людей, которые в нем работают");
                        mTextB_Search.Text = "";
                    }
                }
                if (mRadio_NumOrg.Checked == true)
                {
                    funFilter();
                    var ser = db.persToWork.Where(obj => mTextB_Search.Text.Contains(obj.nameOrg)).ToList();
                    if (ser.Count() > 0)
                    {
                        dgv_persons.Rows.Add(ser.Count());
                        foreach (persToWork pTW in ser) // Заполнение таблицы 
                        {
                            dgv_persons[0, i].Value = pTW.id;
                            dgv_persons[1, i].Value = pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic;
                            dgv_persons[2, i].Value = pTW.persons.birthday.Value.Date.ToShortDateString(); // longDate для месяца
                            dgv_persons[3, i].Value = pTW.persons.gender;
                            dgv_persons[4, i].Value = pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome;
                            dgv_persons[5, i].Value = pTW.persons.typeQualification.nameQualification;
                            dgv_persons[6, i].Value = pTW.persons.trainingDirection;
                            dgv_persons[7, i].Value = pTW.persons.profile;
                            dgv_persons[8, i].Value = pTW.persons.yeatIssue;
                            dgv_persons[9, i].Value = pTW.nameStateOrg;
                            dgv_persons[10, i].Value = pTW.educational;
                            dgv_persons[11, i].Value = pTW.nameOrg;
                            dgv_persons[12, i].Value = pTW.post;
                            dgv_persons[13, i].Value = pTW.cityOrg;
                            dgv_persons[14, i].Value = pTW.numCertificate;
                            dgv_persons[15, i].Value = pTW.freeWork.nameFreeWork;
                            dgv_persons[16, i].Value = pTW.numReference;
                            dgv_persons[17, i].Value = pTW.verificationArrival == "T" ? "В наличии" : "отсутствует"; ;
                            dgv_persons[18, i].Value = pTW.commentary;
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Человека с таким профилем нет");
                        mTextB_Search.Text = "";
                    }
                }
                if (mRadio_Post.Checked == true)
                {
                    funFilter();
                    var ser = db.persToWork.Where(obj => mTextB_Search.Text.Contains(obj.post)).ToList();
                    if (ser.Count() > 0)
                    {
                        dgv_persons.Rows.Add(ser.Count());
                        foreach (persToWork pTW in ser) // Заполнение таблицы 
                        {
                            dgv_persons[0, i].Value = pTW.id;
                            dgv_persons[1, i].Value = pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic;
                            dgv_persons[2, i].Value = pTW.persons.birthday.Value.Date.ToShortDateString(); // longDate для месяца
                            dgv_persons[3, i].Value = pTW.persons.gender;
                            dgv_persons[4, i].Value = pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome;
                            dgv_persons[5, i].Value = pTW.persons.typeQualification.nameQualification;
                            dgv_persons[6, i].Value = pTW.persons.trainingDirection;
                            dgv_persons[7, i].Value = pTW.persons.profile;
                            dgv_persons[8, i].Value = pTW.persons.yeatIssue;
                            dgv_persons[9, i].Value = pTW.nameStateOrg;
                            dgv_persons[10, i].Value = pTW.educational;
                            dgv_persons[11, i].Value = pTW.nameOrg;
                            dgv_persons[12, i].Value = pTW.post;
                            dgv_persons[13, i].Value = pTW.cityOrg;
                            dgv_persons[14, i].Value = pTW.numCertificate;
                            dgv_persons[15, i].Value = pTW.freeWork.nameFreeWork;
                            dgv_persons[16, i].Value = pTW.numReference;
                            dgv_persons[17, i].Value = pTW.verificationArrival == "T" ? "В наличии" : "отсутствует"; ;
                            dgv_persons[18, i].Value = pTW.commentary;
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Человека с таким профилем нет");
                        mTextB_Search.Text = "";
                    }
                }
                if (mRadio_cityOrg.Checked == true)
                {
                    funFilter();
                    var ser = db.persToWork.Where(obj => mTextB_Search.Text.Contains(obj.cityOrg)).ToList();
                    if (ser.Count() > 0)
                    {
                        dgv_persons.Rows.Add(ser.Count());
                        foreach (persToWork pTW in ser) // Заполнение таблицы 
                        {
                            dgv_persons[0, i].Value = pTW.id;
                            dgv_persons[1, i].Value = pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic;
                            dgv_persons[2, i].Value = pTW.persons.birthday.Value.Date.ToShortDateString(); // longDate для месяца
                            dgv_persons[3, i].Value = pTW.persons.gender;
                            dgv_persons[4, i].Value = pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome;
                            dgv_persons[5, i].Value = pTW.persons.typeQualification.nameQualification;
                            dgv_persons[6, i].Value = pTW.persons.trainingDirection;
                            dgv_persons[7, i].Value = pTW.persons.profile;
                            dgv_persons[8, i].Value = pTW.persons.yeatIssue;
                            dgv_persons[9, i].Value = pTW.nameStateOrg;
                            dgv_persons[10, i].Value = pTW.educational;
                            dgv_persons[11, i].Value = pTW.nameOrg;
                            dgv_persons[12, i].Value = pTW.post;
                            dgv_persons[13, i].Value = pTW.cityOrg;
                            dgv_persons[14, i].Value = pTW.numCertificate;
                            dgv_persons[15, i].Value = pTW.freeWork.nameFreeWork;
                            dgv_persons[16, i].Value = pTW.numReference;
                            dgv_persons[17, i].Value = pTW.verificationArrival == "T" ? "В наличии" : "отсутствует"; ;
                            dgv_persons[18, i].Value = pTW.commentary;
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Данного горда нет или в базе отсутсвуют людей, которые в нем проживают");
                        mTextB_Search.Text = "";
                    }
                }
                if (mRadio_FreeWork.Checked == true)
                {
                    funFilter();
                    var ser = db.persToWork.Where(obj => mTextB_Search.Text.Contains(obj.freeWork.nameFreeWork)).ToList();
                    if (ser.Count() > 0)
                    {
                        dgv_persons.Rows.Add(ser.Count());
                        foreach (persToWork pTW in ser) // Заполнение таблицы 
                        {
                            dgv_persons[0, i].Value = pTW.id;
                            dgv_persons[1, i].Value = pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic;
                            dgv_persons[2, i].Value = pTW.persons.birthday.Value.Date.ToShortDateString(); // longDate для месяца
                            dgv_persons[3, i].Value = pTW.persons.gender;
                            dgv_persons[4, i].Value = pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome;
                            dgv_persons[5, i].Value = pTW.persons.typeQualification.nameQualification;
                            dgv_persons[6, i].Value = pTW.persons.trainingDirection;
                            dgv_persons[7, i].Value = pTW.persons.profile;
                            dgv_persons[8, i].Value = pTW.persons.yeatIssue;
                            dgv_persons[9, i].Value = pTW.nameStateOrg;
                            dgv_persons[10, i].Value = pTW.educational;
                            dgv_persons[11, i].Value = pTW.nameOrg;
                            dgv_persons[12, i].Value = pTW.post;
                            dgv_persons[13, i].Value = pTW.cityOrg;
                            dgv_persons[14, i].Value = pTW.numCertificate;
                            dgv_persons[15, i].Value = pTW.freeWork.nameFreeWork;
                            dgv_persons[16, i].Value = pTW.numReference;
                            dgv_persons[17, i].Value = pTW.verificationArrival == "T" ? "В наличии" : "отсутствует"; ;
                            dgv_persons[18, i].Value = pTW.commentary;
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Человека с таким самоустройством нет");
                        mTextB_Search.Text = "";
                    }
                }
                if (mRadio_all.Checked == true)
                {
                    funFilter();
                    var ser = db.persToWork;
          
                    if (ser.Count() > 0)
                    {
                        dgv_persons.Rows.Add(ser.Count());
                        foreach (persToWork pTW in ser) // Заполнение таблицы 
                        {
                            dgv_persons[0, i].Value = pTW.id;
                            dgv_persons[1, i].Value = pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic;
                            dgv_persons[2, i].Value = pTW.persons.birthday.Value.Date.ToShortDateString(); // longDate для месяца
                            dgv_persons[3, i].Value = pTW.persons.gender;
                            dgv_persons[4, i].Value = pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome;
                            dgv_persons[5, i].Value = pTW.persons.typeQualification.nameQualification;
                            dgv_persons[6, i].Value = pTW.persons.trainingDirection;
                            dgv_persons[7, i].Value = pTW.persons.profile;
                            dgv_persons[8, i].Value = pTW.persons.yeatIssue;
                            dgv_persons[9, i].Value = pTW.nameStateOrg;
                            dgv_persons[10, i].Value = pTW.educational;
                            dgv_persons[11, i].Value = pTW.nameOrg;
                            dgv_persons[12, i].Value = pTW.post;
                            dgv_persons[13, i].Value = pTW.cityOrg;
                            dgv_persons[14, i].Value = pTW.numCertificate;
                            dgv_persons[15, i].Value = pTW.freeWork.nameFreeWork;
                            dgv_persons[16, i].Value = pTW.numReference;
                            dgv_persons[17, i].Value = pTW.verificationArrival == "T" ? "В наличии" : "отсутствует"; ;
                            dgv_persons[18, i].Value = pTW.commentary;
                            i++;
                            // dgv_persons.Columns[1].Width = 150;
                        }
                    }
                    else
                    {
                        MessageBox.Show("БД пустая");
                        mTextB_Search.Text = "";
                    }
                }
                countPersons.Text = "Всего записей: " + dgv_persons.Rows.Count.ToString();
            }
        }

        private void MTextB_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mButSerch.PerformClick();
            }
        }
        #endregion

        #region Выбор 1 RadioButton из фильтра поиска
        public void funRadio()
        {
            dgv_persons.Columns.Clear();
            dgv_persons.Rows.Clear();
            mTextB_Search.Enabled = true;
            mButSerch.Visible = true;
            mTextB_Search.Visible = true;
            countPersons.Text = "";
            mTextB_Search.Text = "";
        }
        private void MRadio_sSurname_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                switch (radio.Name)
                {
                    case "mRadio_Surname": funRadio(); break;
                    case "mRadio_Birthday": funRadio(); break;
                    case "mRadio_gender": funRadio(); break;
                    case "mRadio_addressCity": funRadio(); break;

                    case "mRadio_qualification": funRadio(); break;
                    case "mRadio_TrainingDirection": funRadio(); break;
                    case "mRadio_profile": funRadio(); break;
                    case "mRadio_YearIssue": funRadio(); break;
                  
                    case "mRadio_nameStateOrg": funRadio(); break;
                    case "mRadio_educational": funRadio(); break;
                    case "mRadio_NumOrg": funRadio(); break;
                    case "mRadio_Post": funRadio(); break;
                    case "mRadio_cityOrg": funRadio(); break;

                    case "mRadio_FreeWork": funRadio(); break;
                    case "mRadio_all":
                        dgv_persons.Columns.Clear();
                        dgv_persons.Rows.Clear();
                        mTextB_Search.Text = "";
                        mTextB_Search.Enabled = false;
                        mTextB_Search.Visible = false;
                        mButSerch.Visible = true;
                        break;
                    default:break;
                }
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
            mTextB_Search.Visible = false;// поле поиска
            mButSerch.Visible = false; // кнопка поиска

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
    
        // Выход из програмы
        private void Menu_exit_Click(object sender, EventArgs e){ Close(); }

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

        private void Menu_delYearIssue_Click(object sender, EventArgs e)
        {
            new f_clearPersYear(idUser).ShowDialog();
        }
    }
}
