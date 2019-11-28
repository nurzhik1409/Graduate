namespace Graduate
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
            this.MenuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_addUser = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDVG = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgressExcele = new ns1.BunifuCircleProgressbar();
            this.countPersons = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label_excele = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.contextDVG.SuspendLayout();
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
            this.ProgressExcele.Location = new System.Drawing.Point(373, 207);
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
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(20, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 453);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // f_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_excele);
            this.Controls.Add(this.ProgressExcele);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_main";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextDVG.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip contextDVG;
        private System.Windows.Forms.ToolStripMenuItem Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Сatalogue;
        private System.Windows.Forms.ToolStripMenuItem Menu_Order;
        private System.Windows.Forms.ToolStripMenuItem Menu_FreeWork;
        private ns1.BunifuCircleProgressbar ProgressExcele;
        private System.Windows.Forms.ToolStripStatusLabel countPersons;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label_excele;
        private System.Windows.Forms.ToolStripMenuItem Menu_delYearIssue;
        private System.Windows.Forms.ToolStripMenuItem MenuAdmin;
        private System.Windows.Forms.ToolStripMenuItem Menu_addUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem Menu_filter;
    }
}

