using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Graduate.databse;

namespace Graduate.forms
{
    public partial class f_addUser : MetroForm
    {
        int idUser = 0;
        int userRole = 0;
        public int idOreder = 0;
        public f_addUser(int idUser, int usersRole)
        {
            InitializeComponent();
            this.idUser = idUser;
            this.userRole = usersRole;
        }

        #region Заполнение таблицы
        public void funDGV()
        {
            using (DataBase db = new DataBase())
            {
                dgv_usersRole.Columns.Clear();
                dgv_usersRole.Rows.Clear();
                var ser = db.usersRole;
                dgv_usersRole.Columns.Add("id", "id"); // 0
                dgv_usersRole.Columns.Add("fio", "ФИО"); // 1
                dgv_usersRole.Columns.Add("name", "Статус"); // 2
                dgv_usersRole.Columns[0].Visible = false; // id не видим
                int i = 0;

                dgv_usersRole.Rows.Add(ser.Count());
                foreach (usersRole ur in ser) // Заполнение таблицы 
                {
                    dgv_usersRole[0, i].Value = ur.id;
                    dgv_usersRole[1, i].Value = ur.users.fio;
                    dgv_usersRole[1, 2].Value = ur.role.name;
                    i++;
                }
                countOrders.Text = "Всего записей: " + dgv_usersRole.Rows.Count.ToString();
            }
        }
        #endregion

        #region Нумерация строк
        private void Dgv_freeWork_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.dgv_usersRole.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dgv_usersRole.Rows[index].HeaderCell.Value = indexStr;
        }

        #endregion

        private void F_addUser_Load(object sender, EventArgs e)
        {
            funDGV();
            mTextB_edituserFIO.Visible = false;
            mComB_editdRole.Visible = false;
            mBut_editFreeWork.Visible = false;
        }

        #region Del
        private void Dgv_usersRole_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) { contextDVG_UserRole.Show(Cursor.Position.X, Cursor.Position.Y); }
        }

        private void Menu_delUserRole_Click(object sender, EventArgs e)
        {
            // ToolStripItem clickedItem = sender as ToolStripItem;
            using (DataBase db = new DataBase())
            {
                var Result = MessageBox.Show("Вы уверены что хотите удалить данную запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                usersRole ur = db.usersRole.FirstOrDefault(obj => obj.id == idOreder);
                try
                {
                    if (Result == DialogResult.Yes)
                    {
                        db.usersRole.Remove(ur);
                        db.SaveChanges();
                        funDGV();
                        MessageBox.Show("Запись удалена");
                    }
                }
                catch { MessageBox.Show("Данного приказа уже нет"); }
            }
        }

        private void Dgv_usersRole_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgv_usersRole.CurrentCell = dgv_usersRole.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgv_usersRole.Rows[e.RowIndex].Selected = true;
                    dgv_usersRole.Focus();
                    idOreder = (int)dgv_usersRole["id", e.RowIndex].Value;
                    Click += new EventHandler(Menu_delUserRole_Click);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            }
        }

        private void Dgv_usersRole_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                int idOreders = (int)dgv_usersRole["id", e.RowIndex].Value;
                usersRole fs = db.usersRole.FirstOrDefault(p => p.id == idOreders);
                mTextB_edituserFIO.Visible = true;
                mTextB_edituserFIO.Text = fs.users.fio;
                mBut_editFreeWork.Visible = true;
                idOreder = idOreders;
            }
        }
        #endregion

        #region Update Insert
        private void MBut_addFreeWork_Click_1(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                try
                {
                    if (idOreder == 0)
                    {
                        usersRole ur = new usersRole();
                        ur.users.fio = mTextB_adduserFIO.Text.Trim();
                        ur.role.name = mComB_addRole.Text.Trim(); 

                        logs lg = new logs();
                        lg.idUser = this.idUser;
                        lg.typeSql = "Insert";
                        lg.nameTable = "FreeWork";
                        lg.fielTable = "id, nameFreeWork";
                        lg.newValue = mTextB_adduserFIO.Text.Trim() + " "+ mComB_addRole.Text.Trim();
                        lg.dateCrt = DateTime.Now;
                        db.logs.Add(lg);

                        db.usersRole.Add(ur);
                        db.SaveChanges();
                        funDGV();
                        MessageBox.Show("Запись добавлена");
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void MBut_editFreeWork_Click_1(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                try
                {
                    if (idOreder != 0)
                    {
                        usersRole fs = db.usersRole.FirstOrDefault(p => p.id == idOreder);
                        logs lg = new logs();
                        lg.oldValue = idOreder + " " + mTextB_edituserFIO.Text.Trim();
                        fs.users.fio = mTextB_edituserFIO.Text.Trim();

                        lg.idUser = this.idUser;
                        lg.typeSql = "Update";
                        lg.nameTable = "FreeWork";
                        lg.fielTable = "id, nameFreeWork";
                        lg.newValue = mTextB_edituserFIO.Text.Trim();
                        lg.dateCrt = DateTime.Now;
                        db.logs.Add(lg);

                        db.SaveChanges();
                        funDGV();
                        MessageBox.Show("Данные изменены");
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        #endregion

       
    }
}
