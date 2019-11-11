using System;

using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Graduate.databse;

namespace Graduate.forms
{
    public partial class f_clearPersYear : MetroForm
    {
        int idUser = 0;
        public f_clearPersYear(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        //int id = 0;

        private void MBut_delPersYear_Click(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                var Result = MessageBox.Show("Вы уверены что хотите удалить всех студентов в данном году?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                var ser = db.persons.Where(obj => mTextB_yearIssue.Text.Contains(obj.yeatIssue.Value.ToString())).ToList();

                try
                {
                    if (Result == DialogResult.Yes)
                    {
                        logs lg = new logs();
                        lg.idUser = this.idUser;
                        lg.typeSql = "Delete";
                        lg.nameTable = "perstToWork, persons";
                        lg.fielTable = "all";
                        lg.oldValue = "Удаление всех студентов " + mTextB_yearIssue.Text + " года";
                        lg.dateCrt = DateTime.Now;
                        db.logs.Add(lg);
                        db.persons.RemoveRange(ser);
                        db.SaveChanges();
                        MessageBox.Show("Запись удалена");
                    }
                }
                catch { MessageBox.Show("В этом году не было выпускников или в БД нет записей за этот год"); }
            }
        }
    }
}





