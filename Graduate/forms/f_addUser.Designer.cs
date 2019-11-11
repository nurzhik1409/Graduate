namespace Graduate.forms
{
    partial class f_addUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_usersRole = new ns1.BunifuCustomDataGrid();
            this.mBut_editFreeWork = new MetroFramework.Controls.MetroButton();
            this.mBut_addFreeWork = new MetroFramework.Controls.MetroButton();
            this.mTextB_adduserFIO = new MetroFramework.Controls.MetroTextBox();
            this.mComB_addRole = new MetroFramework.Controls.MetroComboBox();
            this.mComB_editdRole = new MetroFramework.Controls.MetroComboBox();
            this.mTextB_edituserFIO = new MetroFramework.Controls.MetroTextBox();
            this.contextDVG_UserRole = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.countOrders = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usersRole)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_usersRole
            // 
            this.dgv_usersRole.AllowUserToAddRows = false;
            this.dgv_usersRole.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_usersRole.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_usersRole.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_usersRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_usersRole.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_usersRole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_usersRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usersRole.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_usersRole.DoubleBuffered = true;
            this.dgv_usersRole.EnableHeadersVisualStyles = false;
            this.dgv_usersRole.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv_usersRole.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv_usersRole.Location = new System.Drawing.Point(20, 60);
            this.dgv_usersRole.Name = "dgv_usersRole";
            this.dgv_usersRole.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_usersRole.Size = new System.Drawing.Size(221, 370);
            this.dgv_usersRole.TabIndex = 37;
            this.dgv_usersRole.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_usersRole_CellDoubleClick);
            this.dgv_usersRole.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_usersRole_CellMouseDown);
            this.dgv_usersRole.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_usersRole_MouseClick);
            // 
            // mBut_editFreeWork
            // 
            this.mBut_editFreeWork.BackColor = System.Drawing.Color.SeaGreen;
            this.mBut_editFreeWork.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mBut_editFreeWork.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mBut_editFreeWork.Location = new System.Drawing.Point(532, 121);
            this.mBut_editFreeWork.Name = "mBut_editFreeWork";
            this.mBut_editFreeWork.Size = new System.Drawing.Size(153, 32);
            this.mBut_editFreeWork.TabIndex = 36;
            this.mBut_editFreeWork.Text = "Редактировать";
            this.mBut_editFreeWork.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mBut_editFreeWork.UseCustomBackColor = true;
            this.mBut_editFreeWork.UseCustomForeColor = true;
            this.mBut_editFreeWork.UseSelectable = true;
            this.mBut_editFreeWork.Click += new System.EventHandler(this.MBut_editFreeWork_Click_1);
            // 
            // mBut_addFreeWork
            // 
            this.mBut_addFreeWork.BackColor = System.Drawing.Color.SeaGreen;
            this.mBut_addFreeWork.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mBut_addFreeWork.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mBut_addFreeWork.Location = new System.Drawing.Point(252, 121);
            this.mBut_addFreeWork.Name = "mBut_addFreeWork";
            this.mBut_addFreeWork.Size = new System.Drawing.Size(153, 32);
            this.mBut_addFreeWork.TabIndex = 34;
            this.mBut_addFreeWork.Text = "Новый приказ";
            this.mBut_addFreeWork.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mBut_addFreeWork.UseCustomBackColor = true;
            this.mBut_addFreeWork.UseCustomForeColor = true;
            this.mBut_addFreeWork.UseSelectable = true;
            this.mBut_addFreeWork.Click += new System.EventHandler(this.MBut_addFreeWork_Click_1);
            // 
            // mTextB_adduserFIO
            // 
            this.mTextB_adduserFIO.BackColor = System.Drawing.Color.SpringGreen;
            // 
            // 
            // 
            this.mTextB_adduserFIO.CustomButton.Image = null;
            this.mTextB_adduserFIO.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.mTextB_adduserFIO.CustomButton.Name = "";
            this.mTextB_adduserFIO.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTextB_adduserFIO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextB_adduserFIO.CustomButton.TabIndex = 1;
            this.mTextB_adduserFIO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextB_adduserFIO.CustomButton.UseSelectable = true;
            this.mTextB_adduserFIO.Lines = new string[0];
            this.mTextB_adduserFIO.Location = new System.Drawing.Point(252, 58);
            this.mTextB_adduserFIO.MaxLength = 32767;
            this.mTextB_adduserFIO.Name = "mTextB_adduserFIO";
            this.mTextB_adduserFIO.PasswordChar = '\0';
            //this.mTextB_adduserFIO.PromptText = "Название приказа";
            this.mTextB_adduserFIO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextB_adduserFIO.SelectedText = "";
            this.mTextB_adduserFIO.SelectionLength = 0;
            this.mTextB_adduserFIO.SelectionStart = 0;
            this.mTextB_adduserFIO.ShortcutsEnabled = true;
            this.mTextB_adduserFIO.ShowButton = true;
            this.mTextB_adduserFIO.ShowClearButton = true;
            this.mTextB_adduserFIO.Size = new System.Drawing.Size(219, 25);
            this.mTextB_adduserFIO.TabIndex = 33;
            this.mTextB_adduserFIO.UseSelectable = true;
            this.mTextB_adduserFIO.WaterMark = "Название приказа";
            this.mTextB_adduserFIO.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextB_adduserFIO.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // mComB_addRole
            // 
            this.mComB_addRole.FormattingEnabled = true;
            this.mComB_addRole.ItemHeight = 20;
            this.mComB_addRole.Location = new System.Drawing.Point(252, 89);
            this.mComB_addRole.Name = "mComB_addRole";
            this.mComB_addRole.Size = new System.Drawing.Size(153, 26);
            this.mComB_addRole.TabIndex = 38;
            this.mComB_addRole.UseSelectable = true;
            // 
            // mComB_editdRole
            // 
            this.mComB_editdRole.FormattingEnabled = true;
            this.mComB_editdRole.ItemHeight = 20;
            this.mComB_editdRole.Location = new System.Drawing.Point(532, 89);
            this.mComB_editdRole.Name = "mComB_editdRole";
            this.mComB_editdRole.Size = new System.Drawing.Size(153, 26);
            this.mComB_editdRole.TabIndex = 40;
            this.mComB_editdRole.UseSelectable = true;
            // 
            // mTextB_edituserFIO
            // 
            this.mTextB_edituserFIO.BackColor = System.Drawing.Color.SpringGreen;
            // 
            // 
            // 
            this.mTextB_edituserFIO.CustomButton.Image = null;
            this.mTextB_edituserFIO.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.mTextB_edituserFIO.CustomButton.Name = "";
            this.mTextB_edituserFIO.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTextB_edituserFIO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextB_edituserFIO.CustomButton.TabIndex = 1;
            this.mTextB_edituserFIO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextB_edituserFIO.CustomButton.UseSelectable = true;
            this.mTextB_edituserFIO.Lines = new string[0];
            this.mTextB_edituserFIO.Location = new System.Drawing.Point(532, 58);
            this.mTextB_edituserFIO.MaxLength = 32767;
            this.mTextB_edituserFIO.Name = "mTextB_edituserFIO";
            this.mTextB_edituserFIO.PasswordChar = '\0';
            //this.mTextB_edituserFIO.PromptText = "Название приказа";
            this.mTextB_edituserFIO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextB_edituserFIO.SelectedText = "";
            this.mTextB_edituserFIO.SelectionLength = 0;
            this.mTextB_edituserFIO.SelectionStart = 0;
            this.mTextB_edituserFIO.ShortcutsEnabled = true;
            this.mTextB_edituserFIO.ShowButton = true;
            this.mTextB_edituserFIO.ShowClearButton = true;
            this.mTextB_edituserFIO.Size = new System.Drawing.Size(219, 25);
            this.mTextB_edituserFIO.TabIndex = 39;
            this.mTextB_edituserFIO.UseSelectable = true;
            this.mTextB_edituserFIO.WaterMark = "Название приказа";
            this.mTextB_edituserFIO.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextB_edituserFIO.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // contextDVG_UserRole
            // 
            this.contextDVG_UserRole.Name = "contextDVG_UserRole";
            this.contextDVG_UserRole.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countOrders});
            this.statusStrip1.Location = new System.Drawing.Point(241, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(539, 22);
            this.statusStrip1.TabIndex = 42;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // countOrders
            // 
            this.countOrders.Name = "countOrders";
            this.countOrders.Size = new System.Drawing.Size(110, 17);
            this.countOrders.Text = "Количество записей";
            // 
            // f_addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mComB_editdRole);
            this.Controls.Add(this.mTextB_edituserFIO);
            this.Controls.Add(this.mComB_addRole);
            this.Controls.Add(this.dgv_usersRole);
            this.Controls.Add(this.mBut_editFreeWork);
            this.Controls.Add(this.mBut_addFreeWork);
            this.Controls.Add(this.mTextB_adduserFIO);
            this.Name = "f_addUser";
            this.Text = "f_addUser";
            this.Load += new System.EventHandler(this.F_addUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usersRole)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCustomDataGrid dgv_usersRole;
        private MetroFramework.Controls.MetroButton mBut_editFreeWork;
        private MetroFramework.Controls.MetroButton mBut_addFreeWork;
        private MetroFramework.Controls.MetroTextBox mTextB_adduserFIO;
        private MetroFramework.Controls.MetroComboBox mComB_addRole;
        private MetroFramework.Controls.MetroComboBox mComB_editdRole;
        private MetroFramework.Controls.MetroTextBox mTextB_edituserFIO;
        private System.Windows.Forms.ContextMenuStrip contextDVG_UserRole;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel countOrders;
    }
}