using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Graduate.databse;

namespace Graduate.forms
{
    public partial class f_DBLogin : MetroForm
    {
        public bool Pin = false;
        public int idUser = 0;
        public string userRole = "";
        public string userPin = "";

        public f_DBLogin()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void But_enter_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataBase db = new DataBase())
                {
                    string pingpass = tb_Pin.Text;
                    usersRole ur = db.usersRole.FirstOrDefault(p => p.users.pin == pingpass);
                    if (ur == null)
                    {
                        MessageBox.Show("У данного пользователя нет прав для работы с данной программой!");
                    }
                    else
                    {
                        idUser = ur.users.id;
                        Pin = true;
                        userRole = ur.role.name;
                        userPin = pingpass;
                        Close();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void But_cancel_Click_1(object sender, EventArgs e)
        {
            Pin = false;
            Close();
        }

        private void Tb_Pin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                but_enter.PerformClick();
            }
        }
    }
}


