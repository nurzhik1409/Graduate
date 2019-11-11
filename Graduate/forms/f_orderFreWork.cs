using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Graduate.databse;
using System.Drawing;

namespace Graduate.forms
{
    public partial class f_OrderFreeWork : MetroForm
    {
        int idUser = 0;
       public int idOreder = 0;
        public f_OrderFreeWork(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        #region Заполнение таблицы
        public void funDGV()
        {
            using (DataBase db = new DataBase())
            {
                dgv_freeWork.Columns.Clear();
                dgv_freeWork.Rows.Clear();
                var ser = db.freeWork;
                dgv_freeWork.Columns.Add("id", "id"); // 0
                dgv_freeWork.Columns.Add("nameFreeWork", "Название приказа"); // 1
                dgv_freeWork.Columns[0].Visible = false; // id не видим
                
                int i = 0;

                dgv_freeWork.Rows.Add(ser.Count());
                foreach (freeWork fW in ser) // Заполнение таблицы 
                {
                    dgv_freeWork[0, i].Value = fW.id;
                    dgv_freeWork[1, i].Value = fW.nameFreeWork;
                    i++;
                }
                countOrders.Text = "Всего записей: " + dgv_freeWork.Rows.Count.ToString();
            }
            dgv_freeWork.Rows[0].Visible = false;
        }
        #endregion

        private void F_OrderFreeWork_Load(object sender, EventArgs e)
        {
            funDGV();
            mTextB_editFreeWork.Visible = false;
            mBut_editFreeWork.Visible = false;
        }

        #region Del
        private void Dgv_freeWork_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) { contextDVG_freeWork.Show(Cursor.Position.X, Cursor.Position.Y); }
        }
        
        private void Menu_delFreeWork_Click(object sender, EventArgs e)
        {
            // ToolStripItem clickedItem = sender as ToolStripItem;
            using (DataBase db = new DataBase())
            {
                var Result = MessageBox.Show("Вы уверены что хотите удалить данную запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                freeWork fw = db.freeWork.FirstOrDefault(obj => obj.id == idOreder);
                try
                {
                    if (Result == DialogResult.Yes)
                    {
                        db.freeWork.Remove(fw);
                        db.SaveChanges();
                        funDGV();
                        MessageBox.Show("Запись удалена");
                    }
                }
                catch { MessageBox.Show("Данного приказа уже нет"); }
            }
        }

      
        #endregion

        #region Update Insert
        private void MBut_addFreeWork_Click(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                try
                {
                    if (idOreder == 0)
                    {
                        freeWork fs = new freeWork();
                        fs.nameFreeWork = mTextB_addFreeWork.Text.Trim();

                        logs lg = new logs();
                        lg.idUser = this.idUser;
                        lg.typeSql = "Insert";
                        lg.nameTable = "FreeWork";
                        lg.fielTable = "id, nameFreeWork";
                        lg.newValue = mTextB_addFreeWork.Text.Trim();
                        lg.dateCrt = DateTime.Now;
                        db.logs.Add(lg);

                        db.freeWork.Add(fs);
                        db.SaveChanges();
                        funDGV();
                        MessageBox.Show("Запись добавлена");
                        mTextB_addFreeWork.Clear();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        
        public void MBut_editFreeWork_Click(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                try
                {
                    if (idOreder != 0)
                    {
                        freeWork fs = db.freeWork.FirstOrDefault(p => p.id == idOreder);
                        logs lg = new logs();
                        lg.oldValue = idOreder + " " + mTextB_editFreeWork.Text.Trim();
                        fs.nameFreeWork = mTextB_editFreeWork.Text.Trim();
                        
                        lg.idUser = this.idUser;
                        lg.typeSql = "Update";
                        lg.nameTable = "FreeWork";
                        lg.fielTable = "id, nameFreeWork";
                        lg.newValue = mTextB_editFreeWork.Text.Trim();
                        lg.dateCrt = DateTime.Now;
                        db.logs.Add(lg);

                        db.SaveChanges();
                        funDGV();
                        MessageBox.Show("Данные изменены");
                        mTextB_editFreeWork.Clear();
                    }
                }
                catch { MessageBox.Show("Данного приказа уже нет"); }
            }
        }
        #endregion

        private void Dgv_freeWork_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                int idOreders = (int)dgv_freeWork["id", e.RowIndex].Value;
                freeWork fs = db.freeWork.FirstOrDefault(p => p.id == idOreders);
                mTextB_editFreeWork.Visible = true;
                mTextB_editFreeWork.Text = fs.nameFreeWork;
                mBut_editFreeWork.Visible = true;
                idOreder = idOreders;
            }
        }

        #region Нумерация строк
        // Старася
       /* private void setRowNumber(ns1.BunifuCustomDataGrid dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells.Count != dgv_freeWork.Rows.Count)
                    row.HeaderCell.Value = String.Format("{0}", row.Index - 1);
                else
                    break;
            }
        }*/

        #endregion

        private void Dgv_freeWork_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {

                    dgv_freeWork.CurrentCell = dgv_freeWork.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgv_freeWork.Rows[e.RowIndex].Selected = true;
                    dgv_freeWork.Focus();
                    idOreder = (int)dgv_freeWork["id", e.RowIndex].Value;
                    Click += new EventHandler(Menu_delFreeWork_Click);


                }
                catch (ArgumentOutOfRangeException) { MessageBox.Show("Выберите ячейку"); }
            }
        }
        //  }
    }
}
