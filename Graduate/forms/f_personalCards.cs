using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Graduate.databse;

namespace Graduate
{
    public partial class f_personalCards : MetroForm
    {
        int idUser = 0;
        int idPers = 0;
        //int idFreeWork = 0; // для спраки, свидетельства и самостоятельного трудоустройства

        private void loadFreeWork()
        {
            mComboB_freeWork.Items.Clear();
            using (DataBase db = new DataBase())
            {
                //int idFreWork;
                var FW = db.freeWork;
                if (FW.Count() > 0)
                {
                    foreach (freeWork ff in FW)
                        mComboB_freeWork.Items.Add(ff.nameFreeWork);
                    //mComboB_freeWork.SelectedIndex = -1;
                }

                /*freeWork fw = db.freeWork.FirstOrDefault(obj => obj.id == idFreeWork);
                try
                {
                    if (mComboB_freeWork.SelectedIndex == 1)
                    {
                        mTextB_numCertificate.Enabled = true; // Свидетельство
                        mTextB_numReference.Enabled = false; // Спрака
                    }
                    else
                    {
                        mTextB_numCertificate.Enabled = false; // Свидетельство
                        mTextB_numReference.Enabled = true; // Спрака
                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }*/

            }
        }
        public f_personalCards(int idUser, int idPers)
        {
            InitializeComponent();
            this.idUser = idUser;
            this.idPers = idPers;
        }

        public f_personalCards(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        #region Размер GroupBox адресс проживания
        private void autoSizeGroupB_address()/////////////////////////////////////////////////////////////////////////////////
        {
            groupBox3.Height = 175; //95
            foreach (MetroFramework.Controls.MetroTextBox textBox in groupBox3.Controls.OfType<MetroFramework.Controls.MetroTextBox>())
                groupBox3.Height -= textBox.Visible ? 0 : 25;
        }
        #endregion

        private void F_personalCards_Load(object sender, EventArgs e)
        {
            
            //dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";

            mTextB_addressRegion.Visible = false; // В БД есть, но не используються в программе по желанию заказчика
            mTextB_addressArea.Visible = false; // В БД есть, но не используються в программе по желанию заказчика
            mTextB_addressFlat.Visible = false; // В БД есть, но не используються в программе по желанию заказчика

            mTextB_numCertificate.Enabled = true; // Свидетельство
            mTextB_numReference.Enabled = false; // Спрака

            loadFreeWork();
            autoSizeGroupB_address();
            if (idPers != 0) loadPersons();
        }

        #region загрузка бд уже существующего студента по клике на основную таблицу
        private void loadPersons()
        {
            using (DataBase db = new DataBase())
            {
                persToWork pTW = db.persToWork.FirstOrDefault(p => p.id == idPers);
                if (pTW != null)
                {
                    mTextB_surname.Text = pTW.persons.surname;
                    mTextB_name.Text = pTW.persons.name;
                    mTextB_patronymic.Text = pTW.persons.patronymic;
                    dateTime_birthday.Value = pTW.persons.birthday.Value;
                    mComboB_gender.Text = pTW.persons.gender;

                    mTextB_addressCountry.Text = pTW.persons.addressCountry;
                    // mTextB_addressRegion.Text = pTW.persons.addressRegion;
                    // mTextB_addressArea.Text = pTW.persons.addressArea;
                    mTextB_addressCity.Text = pTW.persons.addressCity;
                    mTextB_addressStreet.Text = pTW.persons.addressStreet;
                    mTextB_addressHome.Text = pTW.persons.addressHome;
                    //mTextB_addressFlat.Text = pTW.persons.addressFlat;

                    mComboB_qualificationLevel.Text = pTW.persons.typeQualification.nameQualification;
                    mTextB_trainingDirection.Text = pTW.persons.trainingDirection;
                    mTextB_profile.Text = pTW.persons.profile;
                    mTextB_yearIssue.Text = Convert.ToInt16(pTW.persons.yeatIssue).ToString();

                    mTextB_nameStateOrg.Text = pTW.nameStateOrg;
                    mTextB_educational.Text = pTW.educational;
                    mTextB_nameOrg.Text = pTW.nameOrg;
                    mTextB_cityOrg.Text = pTW.cityOrg;
                    mTextB_post.Text = pTW.post;
                    mComboB_freeWork.SelectedItem = pTW.freeWork.nameFreeWork;
                    mTextB_numCertificate.Text = pTW.numCertificate;
                    mTextB_numReference.Text = pTW.numReference;
                    mComboB_verificationArrival.Text = pTW.verificationArrival == "T" ? "в наличии" : "отсутствует";
                    mTextB_commentary.Text = pTW.commentary;
                }
                else MessageBox.Show("Ошибка открытития персоны");
            }
        }
        #endregion

        private void MBut_savePersCard_Click_1(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                try
                {
                    if (idPers == 0 && idUser != 0)
                    {
                        #region INSERT новая персона
                       
                        int qid = mComboB_qualificationLevel.Text == "бакалавр" ? 1 : 2;
                        typeQualification TQ = new typeQualification();
                        TQ.nameQualification = qid.ToString();

                        persons ps = new persons();
                        ps.idTypeQualification = qid;
                        ps.surname = mTextB_surname.Text.Trim();
                        ps.name = mTextB_name.Text.Trim();
                        ps.patronymic = mTextB_patronymic.Text.Trim();
                        ps.birthday = dateTime_birthday.Value;
                        ps.gender = mComboB_gender.Text.Trim();
                        ps.addressCountry = mTextB_addressCountry.Text.Trim();
                        // ps.addressRegion = mTextB_addressRegion.Text.Trim();
                        // ps.addressArea = mTextB_addressArea.Text.Trim();
                        ps.addressCity = mTextB_addressCity.Text.Trim();
                        ps.addressStreet = mTextB_addressStreet.Text.Trim();
                        ps.addressHome = mTextB_addressHome.Text.Trim();
                        // ps.addressFlat = mTextB_addressFlat.Text.Trim();
                        ps.trainingDirection = mTextB_trainingDirection.Text.Trim();
                        ps.profile = mTextB_profile.Text.Trim();
                        ps.yeatIssue = mTextB_yearIssue.Text == "" ? ps.yeatIssue = 1970 : Convert.ToInt16(mTextB_yearIssue.Text.Trim());
                        db.persons.Add(ps);
                        idPers = ps.id;
                        
                        int IDFW = db.freeWork.FirstOrDefault(p => p.nameFreeWork == mComboB_freeWork.Text.Trim()).id;
                        freeWork fW = new freeWork();
                        fW.nameFreeWork = IDFW.ToString();

                        persToWork pTW = new persToWork();
                        pTW.idPers = idPers;
                        pTW.idFreeWork = IDFW;
                        pTW.nameStateOrg = mTextB_nameStateOrg.Text.Trim();
                        pTW.educational = mTextB_educational.Text.Trim();
                        pTW.nameOrg = mTextB_nameOrg.Text.Trim();
                        pTW.cityOrg = mTextB_cityOrg.Text.Trim();
                        pTW.post = mTextB_post.Text.Trim();
                        pTW.numCertificate = mTextB_numCertificate.Text.Trim();
                        pTW.numReference = mTextB_numReference.Text.Trim();
                     
                        pTW.verificationArrival = mComboB_verificationArrival.Text == "в наличии" ? "T" : "F";
                        pTW.commentary = mTextB_commentary.Text.Trim();
                        pTW.dateCrt = DateTime.Now;
                        db.persToWork.Add(pTW);

                        logs lg = new logs();
                        lg.idUser = this.idUser;
                        lg.typeSql = "Insert";
                        lg.nameTable = "typeQualification, persons, freeWork, persToWork";
                        lg.newValue = idPers + " " + mTextB_surname.Text.Trim() + " " + mTextB_name.Text.Trim() + " " + mTextB_patronymic.Text.Trim() + " " + dateTime_birthday.Value + " " + mComboB_gender.Text.Trim() +
                              " " + mTextB_addressCountry.Text  + " " + mTextB_addressCity.Text.Trim() + " " + mTextB_addressStreet.Text.Trim() + " " + mTextB_addressHome.Text.Trim() +
                              //+" "+mTextB_addressRegion.Text+" "+mTextB_addressArea.Text+" "+mTextB_addressArea.Text+" "+mTextB_addressCity.Text+" " +mTextB_addressStreet.Text+ " "+mTextB_addressHome.Text+" "+mTextB_addressFlat.Text +
                              " " + mComboB_qualificationLevel.Text.Trim() + " " + mTextB_trainingDirection.Text.Trim() + " " + mTextB_profile.Text.Trim() + " " + mTextB_yearIssue.Text.Trim() + " " + mComboB_freeWork.Text.Trim() +
                              " " + mTextB_nameStateOrg.Text.Trim() + " " + mTextB_educational.Text.Trim() + "" + mTextB_nameOrg.Text.Trim() + " " + mTextB_cityOrg.Text.Trim() + " " + mTextB_post.Text.Trim() + " " + mTextB_numCertificate.Text.Trim() + " " + mTextB_numReference.Text.Trim() + " " + mComboB_verificationArrival.Text.Trim() + " " + mTextB_commentary.Text.Trim();
                        lg.dateCrt = DateTime.Now;
                        db.logs.Add(lg);
                        MessageBox.Show("Запись добавлена");
                        #endregion
                    }

                    else
                    {
                        #region UPDATE Изменение информации о персоне
                        persToWork pTW = db.persToWork.FirstOrDefault(p => p.id == idPers);
                        logs lg = new logs();
                        lg.idUser = this.idUser;
                        lg.typeSql = "Update";
                        //lg.fielTable = pTW;
                        // lg.nametable = "typeQualification, persons, freeWork, persToWork";
                        lg.oldValue = pTW.id + " " + pTW.persons.surname + " " + pTW.persons.name + " " + pTW.persons.patronymic + " " + pTW.persons.birthday + " " + pTW.persons.gender +
                           //" " + pTW.persons.addressRegion + " " + pTW.persons.addressArea + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome + " " + pTW.persons.addressFlat +
                           " " + pTW.persons.addressCountry + " " + pTW.persons.addressCity + " " + pTW.persons.addressStreet + " " + pTW.persons.addressHome + " " +
                        " " + pTW.persons.typeQualification.nameQualification + " " + pTW.persons.trainingDirection + " " + pTW.persons.profile + " " + pTW.persons.yeatIssue +
                            " " + pTW.nameStateOrg + " " + pTW.educational + " " + pTW.nameOrg + " " + pTW.cityOrg + " " + pTW.post + " " + pTW.freeWork.nameFreeWork + " " + pTW.numCertificate + " " + pTW.numReference + " " + pTW.verificationArrival + " " + pTW.commentary;
                        lg.dateCrt = DateTime.Now;

                        pTW.persons.surname = mTextB_surname.Text.Trim();
                        pTW.persons.name = mTextB_name.Text.Trim();
                        pTW.persons.patronymic = mTextB_patronymic.Text.Trim();
                        pTW.persons.birthday = dateTime_birthday.Value;
                        pTW.persons.gender = mComboB_gender.Text.Trim();

                        pTW.persons.addressCountry = mTextB_addressCountry.Text;
                        // pTW.persons.addressRegion = mTextB_addressRegion.Text;
                        // pTW.persons.addressArea = mTextB_addressArea.Text;
                        pTW.persons.addressCity = mTextB_addressCity.Text.Trim();
                        pTW.persons.addressStreet = mTextB_addressStreet.Text.Trim();
                        pTW.persons.addressHome = mTextB_addressHome.Text.Trim();
                        //  pTW.persons.addressFlat = mTextB_addressFlat.Text;

                        pTW.persons.typeQualification.nameQualification = mComboB_qualificationLevel.Text.Trim();
                        pTW.persons.trainingDirection = mTextB_trainingDirection.Text.Trim();
                        pTW.persons.profile = mTextB_profile.Text.Trim();
                        //pTW.persons.yeatIssue = Convert.ToInt16(mTextB_yearIssue.Text.Trim());
                        pTW.persons.yeatIssue = mTextB_yearIssue.Text == "" ? pTW.persons.yeatIssue = 1970 : Convert.ToInt16(mTextB_yearIssue.Text.Trim());

                        pTW.nameStateOrg = mTextB_nameStateOrg.Text.Trim();
                        pTW.educational = mTextB_educational.Text.Trim();
                        pTW.nameOrg = mTextB_nameOrg.Text.Trim();
                        pTW.cityOrg = mTextB_cityOrg.Text.Trim();
                        pTW.post = mTextB_post.Text.Trim();

                        //pTW.freeWork.nameFreeWork = mComboB_freeWork.Text.Trim();
                        string fw2 = mComboB_freeWork.SelectedItem.ToString().Trim();
                        pTW.idFreeWork = db.freeWork.FirstOrDefault(pp => pp.nameFreeWork == fw2).id;
                        pTW.numCertificate = mTextB_numCertificate.Text.Trim();
                        pTW.numReference = mTextB_numReference.Text.Trim();
                        pTW.verificationArrival = mComboB_verificationArrival.Text == "в наличии" ? "T" : "F";
                        pTW.commentary = mTextB_commentary.Text.Trim();
                        pTW.dateCrt = DateTime.Now;

                        lg.newValue = idPers + " " + mTextB_surname.Text.Trim() + " " + mTextB_name.Text.Trim() + " " + mTextB_patronymic.Text.Trim() + " " + dateTime_birthday.Value + " " + mComboB_gender.Text.Trim() +
                            // " " + mTextB_addressRegion.Text + " " + mTextB_addressArea.Text + " " + mTextB_addressArea.Text + " " + mTextB_addressCity.Text + " " + mTextB_addressStreet.Text + " " + mTextB_addressHome.Text + " " + mTextB_addressFlat.Text +
                            " " + mTextB_addressCountry.Text + " " + mTextB_addressCity.Text.Trim() + " " + mTextB_addressStreet.Text.Trim() + " " + mTextB_addressHome.Text.Trim() + " " +
                            " " + mComboB_qualificationLevel.Text.Trim() + " " + mTextB_trainingDirection.Text.Trim() + " " + mTextB_profile.Text.Trim() + " " + mTextB_yearIssue.Text.Trim() + " " + mComboB_freeWork.Text.Trim() +
                            " " + mTextB_nameStateOrg.Text.Trim() + " " + mTextB_educational.Text.Trim() + " " + mTextB_nameOrg.Text.Trim() + " " + mTextB_cityOrg.Text.Trim() + " " + mTextB_post.Text.Trim() + " " + mTextB_numCertificate.Text.Trim() + " " + mTextB_numReference.Text.Trim() + " " + mComboB_verificationArrival.Text.Trim() + " " + mTextB_commentary.Text.Trim();
                        db.logs.Add(lg);
                        MessageBox.Show("Данные изменены");
                        #endregion
                    }
                    db.SaveChanges();
                    Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void MComboB_freeWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mComboB_freeWork.SelectedIndex == 0)
            {
                mTextB_numCertificate.Enabled = true; // Свидетельство
                mTextB_numReference.Enabled = false; // Спрака
                mTextB_numReference.Clear();
            }
            else
            {
                mTextB_numCertificate.Enabled = false; // Свидетельство
                mTextB_numCertificate.Clear();
                mTextB_numReference.Enabled = true; // Спрака
            }
        }
    }
}

