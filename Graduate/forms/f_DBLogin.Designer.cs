namespace Graduate.forms
{
    partial class f_DBLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_DBLogin));
            this.but_enter = new MetroFramework.Controls.MetroButton();
            this.tb_Pin = new MetroFramework.Controls.MetroTextBox();
            this.but_cancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // but_enter
            // 
            this.but_enter.BackColor = System.Drawing.Color.SeaGreen;
            this.but_enter.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.but_enter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.but_enter.Location = new System.Drawing.Point(14, 82);
            this.but_enter.Name = "but_enter";
            this.but_enter.Size = new System.Drawing.Size(75, 26);
            this.but_enter.TabIndex = 2;
            this.but_enter.Text = "Вход";
            this.but_enter.Theme = MetroFramework.MetroThemeStyle.Light;
            this.but_enter.UseCustomBackColor = true;
            this.but_enter.UseCustomForeColor = true;
            this.but_enter.UseSelectable = true;
            this.but_enter.Click += new System.EventHandler(this.But_enter_Click);
            // 
            // tb_Pin
            // 
            this.tb_Pin.BackColor = System.Drawing.Color.SpringGreen;
            // 
            // 
            // 
            this.tb_Pin.CustomButton.Image = null;
            this.tb_Pin.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.tb_Pin.CustomButton.Name = "";
            this.tb_Pin.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_Pin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Pin.CustomButton.TabIndex = 1;
            this.tb_Pin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Pin.CustomButton.UseSelectable = true;
            this.tb_Pin.Lines = new string[0];
            this.tb_Pin.Location = new System.Drawing.Point(14, 51);
            this.tb_Pin.MaxLength = 32767;
            this.tb_Pin.Name = "tb_Pin";
            this.tb_Pin.PasswordChar = '*';
            //this.tb_Pin.PromptText = "Пин";
            this.tb_Pin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Pin.SelectedText = "";
            this.tb_Pin.SelectionLength = 0;
            this.tb_Pin.SelectionStart = 0;
            this.tb_Pin.ShortcutsEnabled = true;
            this.tb_Pin.ShowButton = true;
            this.tb_Pin.ShowClearButton = true;
            this.tb_Pin.Size = new System.Drawing.Size(210, 25);
            this.tb_Pin.TabIndex = 0;
            this.tb_Pin.UseSelectable = true;
            this.tb_Pin.WaterMark = "Пин";
            this.tb_Pin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Pin.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Pin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_Pin_KeyDown);
            // 
            // but_cancel
            // 
            this.but_cancel.BackColor = System.Drawing.Color.SeaGreen;
            this.but_cancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.but_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.but_cancel.Location = new System.Drawing.Point(149, 82);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(75, 26);
            this.but_cancel.TabIndex = 3;
            this.but_cancel.Text = "Отмена";
            this.but_cancel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.but_cancel.UseCustomBackColor = true;
            this.but_cancel.UseCustomForeColor = true;
            this.but_cancel.UseSelectable = true;
            this.but_cancel.Click += new System.EventHandler(this.But_cancel_Click_1);
            // 
            // f_DBLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 148);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.tb_Pin);
            this.Controls.Add(this.but_enter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_DBLogin";
            this.Text = "Авторизация";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton but_enter;
        private MetroFramework.Controls.MetroTextBox tb_Pin;
        private MetroFramework.Controls.MetroButton but_cancel;
    }
}