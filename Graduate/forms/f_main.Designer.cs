﻿namespace Graduate
{
    partial class f_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_filter = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_addPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_exportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Сatalogue = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Order = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_FreeWork = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_delYearIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_aboutProg = new System.Windows.Forms.ToolStripMenuItem();
            this.mButSerch = new MetroFramework.Controls.MetroButton();
            this.contextDVG = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mRadio_Surname = new MetroFramework.Controls.MetroRadioButton();
            this.mRadio_NumOrg = new MetroFramework.Controls.MetroRadioButton();
            this.mRadio_FreeWork = new MetroFramework.Controls.MetroRadioButton();
            this.mRadio_YearIssue = new MetroFramework.Controls.MetroRadioButton();
            this.mRadio_Post = new MetroFramework.Controls.MetroRadioButton();
            this.mRadio_Birthday = new MetroFramework.Controls.MetroRadioButton();
            this.mRadio_TrainingDirection = new MetroFramework.Controls.MetroRadioButton();
            this.mTextB_Search = new MetroFramework.Controls.MetroTextBox();
            this.mRadio_all = new MetroFramework.Controls.MetroRadioButton();
            this.mRadio_gender = new MetroFramework.Controls.MetroRadioButton();
            this.mRadio_qualification = new MetroFramework.Controls.MetroRadioButton();
            this.mRadio_profile = new MetroFramework.Controls.MetroRadioButton();
            this.group_Search = new System.Windows.Forms.GroupBox();
            this.mRadio_addressCity = new MetroFramework.Controls.MetroRadioButton();
            this.mRadio_cityOrg = new MetroFramework.Controls.MetroRadioButton();
            this.mRadio_educational = new MetroFramework.Controls.MetroRadioButton();
            this.mRadio_nameStateOrg = new MetroFramework.Controls.MetroRadioButton();
            this.dgv_persons = new ns1.BunifuCustomDataGrid();
            this.ProgressExcele = new ns1.BunifuCircleProgressbar();
            this.countPersons = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label_excele = new System.Windows.Forms.Label();
            this.MenuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_addUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextDVG.SuspendLayout();
            this.group_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_persons)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.Menu_addPerson,
            this.Menu_exportExcel,
            this.Menu_Сatalogue,
            this.Menu_aboutProg,
            this.MenuAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_filter,
            this.Menu_exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // Menu_filter
            // 
            this.Menu_filter.Name = "Menu_filter";
            this.Menu_filter.Size = new System.Drawing.Size(112, 22);
            this.Menu_filter.Text = "Фильтр";
            this.Menu_filter.Click += new System.EventHandler(this.Menu_filter_Click);
            // 
            // Menu_exit
            // 
            this.Menu_exit.Name = "Menu_exit";
            this.Menu_exit.Size = new System.Drawing.Size(112, 22);
            this.Menu_exit.Text = "Выход";
            this.Menu_exit.Click += new System.EventHandler(this.Menu_exit_Click);
            // 
            // Menu_addPerson
            // 
            this.Menu_addPerson.Name = "Menu_addPerson";
            this.Menu_addPerson.Size = new System.Drawing.Size(113, 20);
            this.Menu_addPerson.Text = "Добавить персону";
            this.Menu_addPerson.Click += new System.EventHandler(this.Menu_addPerson_Click);
            // 
            // Menu_exportExcel
            // 
            this.Menu_exportExcel.Name = "Menu_exportExcel";
            this.Menu_exportExcel.Size = new System.Drawing.Size(98, 20);
            this.Menu_exportExcel.Text = "Экспорт в Excel";
            this.Menu_exportExcel.Click += new System.EventHandler(this.Menu_exportExcel_Click);
            // 
            // Menu_Сatalogue
            // 
            this.Menu_Сatalogue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Order,
            this.Menu_delYearIssue});
            this.Menu_Сatalogue.Name = "Menu_Сatalogue";
            this.Menu_Сatalogue.Size = new System.Drawing.Size(86, 20);
            this.Menu_Сatalogue.Text = "Справочники";
            // 
            // Menu_Order
            // 
            this.Menu_Order.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_FreeWork});
            this.Menu_Order.Name = "Menu_Order";
            this.Menu_Order.Size = new System.Drawing.Size(185, 22);
            this.Menu_Order.Text = "приказ";
            // 
            // Menu_FreeWork
            // 
            this.Menu_FreeWork.Name = "Menu_FreeWork";
            this.Menu_FreeWork.Size = new System.Drawing.Size(256, 22);
            this.Menu_FreeWork.Text = "Самостоятельное трудоустройство";
            this.Menu_FreeWork.Click += new System.EventHandler(this.Menu_FreeWork_Click);
            // 
            // Menu_delYearIssue
            // 
            this.Menu_delYearIssue.Name = "Menu_delYearIssue";
            this.Menu_delYearIssue.Size = new System.Drawing.Size(185, 22);
            this.Menu_delYearIssue.Text = "Удалить год выпуска";
            this.Menu_delYearIssue.Click += new System.EventHandler(this.Menu_delYearIssue_Click);
            // 
            // Menu_aboutProg
            // 
            this.Menu_aboutProg.Name = "Menu_aboutProg";
            this.Menu_aboutProg.Size = new System.Drawing.Size(83, 20);
            this.Menu_aboutProg.Text = "О программе";
            this.Menu_aboutProg.Click += new System.EventHandler(this.Menu_aboutProg_Click);
            // 
            // mButSerch
            // 
            this.mButSerch.BackColor = System.Drawing.Color.SeaGreen;
            this.mButSerch.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mButSerch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mButSerch.Location = new System.Drawing.Point(596, 38);
            this.mButSerch.Name = "mButSerch";
            this.mButSerch.Size = new System.Drawing.Size(220, 43);
            this.mButSerch.TabIndex = 28;
            this.mButSerch.Text = "Поиск";
            this.mButSerch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mButSerch.UseCustomBackColor = true;
            this.mButSerch.UseCustomForeColor = true;
            this.mButSerch.UseSelectable = true;
            this.mButSerch.Click += new System.EventHandler(this.MButSerch_Click);
            // 
            // contextDVG
            // 
            this.contextDVG.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextDVG.Name = "contextDVG";
            this.contextDVG.Size = new System.Drawing.Size(118, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.удалитьToolStripMenuItem.Text = "удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // mRadio_Surname
            // 
            this.mRadio_Surname.AutoSize = true;
            this.mRadio_Surname.Location = new System.Drawing.Point(5, 30);
            this.mRadio_Surname.Name = "mRadio_Surname";
            this.mRadio_Surname.Size = new System.Drawing.Size(72, 13);
            this.mRadio_Surname.TabIndex = 45;
            this.mRadio_Surname.Text = "Фамилия";
            this.mRadio_Surname.UseSelectable = true;
            this.mRadio_Surname.CheckedChanged += new System.EventHandler(this.MRadio_sSurname_CheckedChanged);
            // 
            // mRadio_NumOrg
            // 
            this.mRadio_NumOrg.AutoSize = true;
            this.mRadio_NumOrg.Location = new System.Drawing.Point(300, 49);
            this.mRadio_NumOrg.Name = "mRadio_NumOrg";
            this.mRadio_NumOrg.Size = new System.Drawing.Size(90, 13);
            this.mRadio_NumOrg.TabIndex = 46;
            this.mRadio_NumOrg.Text = "Предприятие";
            this.mRadio_NumOrg.UseSelectable = true;
            this.mRadio_NumOrg.CheckedChanged += new System.EventHandler(this.MRadio_sSurname_CheckedChanged);
            // 
            // mRadio_FreeWork
            // 
            this.mRadio_FreeWork.AutoSize = true;
            this.mRadio_FreeWork.Location = new System.Drawing.Point(493, 11);
            this.mRadio_FreeWork.Name = "mRadio_FreeWork";
            this.mRadio_FreeWork.Size = new System.Drawing.Size(86, 13);
            this.mRadio_FreeWork.TabIndex = 47;
            this.mRadio_FreeWork.Text = "Самост устр";
            this.mRadio_FreeWork.UseSelectable = true;
            this.mRadio_FreeWork.CheckedChanged += new System.EventHandler(this.MRadio_sSurname_CheckedChanged);
            // 
            // mRadio_YearIssue
            // 
            this.mRadio_YearIssue.AutoSize = true;
            this.mRadio_YearIssue.Location = new System.Drawing.Point(128, 87);
            this.mRadio_YearIssue.Name = "mRadio_YearIssue";
            this.mRadio_YearIssue.Size = new System.Drawing.Size(87, 13);
            this.mRadio_YearIssue.TabIndex = 50;
            this.mRadio_YearIssue.Text = "Год выпуска";
            this.mRadio_YearIssue.UseSelectable = true;
            this.mRadio_YearIssue.CheckedChanged += new System.EventHandler(this.MRadio_sSurname_CheckedChanged);
            // 
            // mRadio_Post
            // 
            this.mRadio_Post.AutoSize = true;
            this.mRadio_Post.Location = new System.Drawing.Point(300, 68);
            this.mRadio_Post.Name = "mRadio_Post";
            this.mRadio_Post.Size = new System.Drawing.Size(81, 13);
            this.mRadio_Post.TabIndex = 49;
            this.mRadio_Post.Text = "Должность";
            this.mRadio_Post.UseSelectable = true;
            this.mRadio_Post.CheckedChanged += new System.EventHandler(this.MRadio_sSurname_CheckedChanged);
            // 
            // mRadio_Birthday
            // 
            this.mRadio_Birthday.AutoSize = true;
            this.mRadio_Birthday.Location = new System.Drawing.Point(5, 49);
            this.mRadio_Birthday.Name = "mRadio_Birthday";
            this.mRadio_Birthday.Size = new System.Drawing.Size(94, 13);
            this.mRadio_Birthday.TabIndex = 52;
            this.mRadio_Birthday.Text = "Год рождения";
            this.mRadio_Birthday.UseSelectable = true;
            this.mRadio_Birthday.CheckedChanged += new System.EventHandler(this.MRadio_sSurname_CheckedChanged);
            // 
            // mRadio_TrainingDirection
            // 
            this.mRadio_TrainingDirection.AutoSize = true;
            this.mRadio_TrainingDirection.Location = new System.Drawing.Point(128, 49);
            this.mRadio_TrainingDirection.Name = "mRadio_TrainingDirection";
            this.mRadio_TrainingDirection.Size = new System.Drawing.Size(152, 13);
            this.mRadio_TrainingDirection.TabIndex = 51;
            this.mRadio_TrainingDirection.Text = "Направление подготовки";
            this.mRadio_TrainingDirection.UseSelectable = true;
            this.mRadio_TrainingDirection.CheckedChanged += new System.EventHandler(this.MRadio_sSurname_CheckedChanged);
            // 
            // mTextB_Search
            // 
            this.mTextB_Search.BackColor = System.Drawing.Color.SpringGreen;
            // 
            // 
            // 
            this.mTextB_Search.CustomButton.Image = null;
            this.mTextB_Search.CustomButton.Location = new System.Drawing.Point(202, 2);
            this.mTextB_Search.CustomButton.Name = "";
            this.mTextB_Search.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.mTextB_Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextB_Search.CustomButton.TabIndex = 1;
            this.mTextB_Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextB_Search.CustomButton.UseSelectable = true;
            this.mTextB_Search.CustomButton.Visible = false;
            this.mTextB_Search.Lines = new string[0];
            this.mTextB_Search.Location = new System.Drawing.Point(596, 11);
            this.mTextB_Search.MaxLength = 32767;
            this.mTextB_Search.Name = "mTextB_Search";
            this.mTextB_Search.PasswordChar = '\0';
            this.mTextB_Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextB_Search.SelectedText = "";
            this.mTextB_Search.SelectionLength = 0;
            this.mTextB_Search.SelectionStart = 0;
            this.mTextB_Search.ShortcutsEnabled = true;
            this.mTextB_Search.ShowClearButton = true;
            this.mTextB_Search.Size = new System.Drawing.Size(220, 20);
            this.mTextB_Search.TabIndex = 53;
            this.mTextB_Search.UseSelectable = true;
            this.mTextB_Search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextB_Search.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mTextB_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MTextB_Search_KeyDown);
            // 
            // mRadio_all
            // 
            this.mRadio_all.AutoSize = true;
            this.mRadio_all.Location = new System.Drawing.Point(493, 30);
            this.mRadio_all.Name = "mRadio_all";
            this.mRadio_all.Size = new System.Drawing.Size(93, 13);
            this.mRadio_all.TabIndex = 54;
            this.mRadio_all.Text = "Вывести всех";
            this.mRadio_all.UseSelectable = true;
            this.mRadio_all.CheckedChanged += new System.EventHandler(this.MRadio_sSurname_CheckedChanged);
            // 
            // mRadio_gender
            // 
            this.mRadio_gender.AutoSize = true;
            this.mRadio_gender.Location = new System.Drawing.Point(5, 68);
            this.mRadio_gender.Name = "mRadio_gender";
            this.mRadio_gender.Size = new System.Drawing.Size(43, 13);
            this.mRadio_gender.TabIndex = 55;
            this.mRadio_gender.Text = "Пол";
            this.mRadio_gender.UseSelectable = true;
            this.mRadio_gender.CheckedChanged += new System.EventHandler(this.MRadio_sSurname_CheckedChanged);
            // 
            // mRadio_qualification
            // 
            this.mRadio_qualification.AutoSize = true;
            this.mRadio_qualification.Location = new System.Drawing.Point(128, 30);
            this.mRadio_qualification.Name = "mRadio_qualification";
            this.mRadio_qualification.Size = new System.Drawing.Size(168, 13);
            this.mRadio_qualification.TabIndex = 57;
            this.mRadio_qualification.Text = "Квалификационный уровень";
            this.mRadio_qualification.UseSelectable = true;
            this.mRadio_qualification.CheckedChanged += new System.EventHandler(this.MRadio_sSurname_CheckedChanged);
            // 
            // mRadio_profile
            // 
            this.mRadio_profile.AutoSize = true;
            this.mRadio_profile.Location = new System.Drawing.Point(128, 68);
            this.mRadio_profile.Name = "mRadio_profile";
            this.mRadio_profile.Size = new System.Drawing.Size(69, 13);
            this.mRadio_profile.TabIndex = 59;
            this.mRadio_profile.Text = "Профиль";
            this.mRadio_profile.UseSelectable = true;
            this.mRadio_profile.CheckedChanged += new System.EventHandler(this.MRadio_sSurname_CheckedChanged);
            // 
            // group_Search
            // 
            this.group_Search.Controls.Add(this.mRadio_addressCity);
            this.group_Search.Controls.Add(this.mRadio_cityOrg);
            this.group_Search.Controls.Add(this.mRadio_educational);
            this.group_Search.Controls.Add(this.mRadio_nameStateOrg);
            this.group_Search.Controls.Add(this.mRadio_NumOrg);
            this.group_Search.Controls.Add(this.mRadio_Surname);
            this.group_Search.Controls.Add(this.mButSerch);
            this.group_Search.Controls.Add(this.mTextB_Search);
            this.group_Search.Controls.Add(this.mRadio_profile);
            this.group_Search.Controls.Add(this.mRadio_FreeWork);
            this.group_Search.Controls.Add(this.mRadio_qualification);
            this.group_Search.Controls.Add(this.mRadio_Post);
            this.group_Search.Controls.Add(this.mRadio_gender);
            this.group_Search.Controls.Add(this.mRadio_YearIssue);
            this.group_Search.Controls.Add(this.mRadio_all);
            this.group_Search.Controls.Add(this.mRadio_TrainingDirection);
            this.group_Search.Controls.Add(this.mRadio_Birthday);
            this.group_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.group_Search.Location = new System.Drawing.Point(20, 84);
            this.group_Search.Name = "group_Search";
            this.group_Search.Size = new System.Drawing.Size(971, 111);
            this.group_Search.TabIndex = 60;
            this.group_Search.TabStop = false;
            this.group_Search.Text = "Фильтр поиска";
            // 
            // mRadio_addressCity
            // 
            this.mRadio_addressCity.AutoSize = true;
            this.mRadio_addressCity.Location = new System.Drawing.Point(5, 87);
            this.mRadio_addressCity.Name = "mRadio_addressCity";
            this.mRadio_addressCity.Size = new System.Drawing.Size(118, 13);
            this.mRadio_addressCity.TabIndex = 63;
            this.mRadio_addressCity.Text = "Город проживания";
            this.mRadio_addressCity.UseSelectable = true;
            this.mRadio_addressCity.CheckedChanged += new System.EventHandler(this.MRadio_sSurname_CheckedChanged);
            // 
            // mRadio_cityOrg
            // 
            this.mRadio_cityOrg.AutoSize = true;
            this.mRadio_cityOrg.Location = new System.Drawing.Point(300, 87);
            this.mRadio_cityOrg.Name = "mRadio_cityOrg";
            this.mRadio_cityOrg.Size = new System.Drawing.Size(121, 13);
            this.mRadio_cityOrg.TabIndex = 62;
            this.mRadio_cityOrg.Text = "Город организации";
            this.mRadio_cityOrg.UseSelectable = true;
            this.mRadio_cityOrg.CheckedChanged += new System.EventHandler(this.MRadio_sSurname_CheckedChanged);
            // 
            // mRadio_educational
            // 
            this.mRadio_educational.AutoSize = true;
            this.mRadio_educational.Location = new System.Drawing.Point(300, 30);
            this.mRadio_educational.Name = "mRadio_educational";
            this.mRadio_educational.Size = new System.Drawing.Size(177, 13);
            this.mRadio_educational.TabIndex = 61;
            this.mRadio_educational.Text = "Образовательное учреждение";
            this.mRadio_educational.UseSelectable = true;
            this.mRadio_educational.CheckedChanged += new System.EventHandler(this.MRadio_sSurname_CheckedChanged);
            // 
            // mRadio_nameStateOrg
            // 
            this.mRadio_nameStateOrg.AutoSize = true;
            this.mRadio_nameStateOrg.Location = new System.Drawing.Point(300, 11);
            this.mRadio_nameStateOrg.Name = "mRadio_nameStateOrg";
            this.mRadio_nameStateOrg.Size = new System.Drawing.Size(174, 13);
            this.mRadio_nameStateOrg.TabIndex = 60;
            this.mRadio_nameStateOrg.Text = "Государственное учреждение";
            this.mRadio_nameStateOrg.UseSelectable = true;
            this.mRadio_nameStateOrg.CheckedChanged += new System.EventHandler(this.MRadio_sSurname_CheckedChanged);
            // 
            // dgv_persons
            // 
            this.dgv_persons.AllowUserToAddRows = false;
            this.dgv_persons.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_persons.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_persons.BackgroundColor = System.Drawing.Color.White;
            this.dgv_persons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_persons.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_persons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_persons.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_persons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_persons.DoubleBuffered = true;
            this.dgv_persons.EnableHeadersVisualStyles = false;
            this.dgv_persons.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_persons.HeaderBgColor = System.Drawing.Color.Green;
            this.dgv_persons.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_persons.Location = new System.Drawing.Point(20, 195);
            this.dgv_persons.MultiSelect = false;
            this.dgv_persons.Name = "dgv_persons";
            this.dgv_persons.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_persons.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_persons.Size = new System.Drawing.Size(971, 342);
            this.dgv_persons.TabIndex = 64;
            this.dgv_persons.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_persons_CellDoubleClick_1);
            this.dgv_persons.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_persons_CellMouseDown_1);
            this.dgv_persons.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.Dgv_persons_RowPrePaint_1);
            this.dgv_persons.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_persons_MouseClick_1);
            // 
            // ProgressExcele
            // 
            this.ProgressExcele.animated = false;
            this.ProgressExcele.animationIterval = 5;
            this.ProgressExcele.animationSpeed = 300;
            this.ProgressExcele.BackColor = System.Drawing.Color.White;
            this.ProgressExcele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProgressExcele.BackgroundImage")));
            this.ProgressExcele.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.ProgressExcele.ForeColor = System.Drawing.Color.SeaGreen;
            this.ProgressExcele.LabelVisible = true;
            this.ProgressExcele.LineProgressThickness = 8;
            this.ProgressExcele.LineThickness = 5;
            this.ProgressExcele.Location = new System.Drawing.Point(383, 207);
            this.ProgressExcele.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ProgressExcele.MaxValue = 100;
            this.ProgressExcele.Name = "ProgressExcele";
            this.ProgressExcele.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.ProgressExcele.ProgressColor = System.Drawing.Color.SeaGreen;
            this.ProgressExcele.Size = new System.Drawing.Size(201, 201);
            this.ProgressExcele.TabIndex = 65;
            this.ProgressExcele.Value = 0;
            // 
            // countPersons
            // 
            this.countPersons.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countPersons.Name = "countPersons";
            this.countPersons.Size = new System.Drawing.Size(12, 17);
            this.countPersons.Text = "_";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countPersons});
            this.statusStrip1.Location = new System.Drawing.Point(20, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(971, 22);
            this.statusStrip1.TabIndex = 61;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label_excele
            // 
            this.label_excele.AutoSize = true;
            this.label_excele.Location = new System.Drawing.Point(438, 406);
            this.label_excele.Name = "label_excele";
            this.label_excele.Size = new System.Drawing.Size(87, 13);
            this.label_excele.TabIndex = 66;
            this.label_excele.Text = "Экспорт в Excel";
            // 
            // MenuAdmin
            // 
            this.MenuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_addUser});
            this.MenuAdmin.Name = "MenuAdmin";
            this.MenuAdmin.Size = new System.Drawing.Size(51, 20);
            this.MenuAdmin.Text = "Админ";
            // 
            // Menu_addUser
            // 
            this.Menu_addUser.Name = "Menu_addUser";
            this.Menu_addUser.Size = new System.Drawing.Size(198, 22);
            this.Menu_addUser.Text = "Добавить пользователя";
            // 
            // f_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 579);
            this.Controls.Add(this.label_excele);
            this.Controls.Add(this.ProgressExcele);
            this.Controls.Add(this.dgv_persons);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.group_Search);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_main";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextDVG.ResumeLayout(false);
            this.group_Search.ResumeLayout(false);
            this.group_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_persons)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_addPerson;
        private System.Windows.Forms.ToolStripMenuItem Menu_exportExcel;
        private System.Windows.Forms.ToolStripMenuItem Menu_aboutProg;
        private MetroFramework.Controls.MetroButton mButSerch;
        private System.Windows.Forms.ContextMenuStrip contextDVG;
        private MetroFramework.Controls.MetroRadioButton mRadio_Surname;
        private MetroFramework.Controls.MetroRadioButton mRadio_NumOrg;
        private MetroFramework.Controls.MetroRadioButton mRadio_FreeWork;
        private MetroFramework.Controls.MetroRadioButton mRadio_YearIssue;
        private MetroFramework.Controls.MetroRadioButton mRadio_Post;
        private MetroFramework.Controls.MetroRadioButton mRadio_Birthday;
        private MetroFramework.Controls.MetroRadioButton mRadio_TrainingDirection;
        private MetroFramework.Controls.MetroTextBox mTextB_Search;
        private MetroFramework.Controls.MetroRadioButton mRadio_all;
        private MetroFramework.Controls.MetroRadioButton mRadio_gender;
        private MetroFramework.Controls.MetroRadioButton mRadio_qualification;
        private MetroFramework.Controls.MetroRadioButton mRadio_profile;
        private System.Windows.Forms.GroupBox group_Search;
        private System.Windows.Forms.ToolStripMenuItem Menu_filter;
        private System.Windows.Forms.ToolStripMenuItem Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Сatalogue;
        private System.Windows.Forms.ToolStripMenuItem Menu_Order;
        private System.Windows.Forms.ToolStripMenuItem Menu_FreeWork;
        private MetroFramework.Controls.MetroRadioButton mRadio_nameStateOrg;
        private MetroFramework.Controls.MetroRadioButton mRadio_cityOrg;
        private MetroFramework.Controls.MetroRadioButton mRadio_educational;
        private MetroFramework.Controls.MetroRadioButton mRadio_addressCity;
        private ns1.BunifuCustomDataGrid dgv_persons;
        private ns1.BunifuCircleProgressbar ProgressExcele;
        private System.Windows.Forms.ToolStripStatusLabel countPersons;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label_excele;
        private System.Windows.Forms.ToolStripMenuItem Menu_delYearIssue;
        private System.Windows.Forms.ToolStripMenuItem MenuAdmin;
        private System.Windows.Forms.ToolStripMenuItem Menu_addUser;
    }
}

