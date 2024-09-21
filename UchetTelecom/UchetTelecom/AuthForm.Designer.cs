namespace Library
{
    partial class AuthForm
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.PasswtextBox = new System.Windows.Forms.TextBox();
            this.Passwlabel = new System.Windows.Forms.Label();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.DBBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(120, 114);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(15, 114);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 2;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // PasswtextBox
            // 
            this.PasswtextBox.Location = new System.Drawing.Point(15, 71);
            this.PasswtextBox.Name = "PasswtextBox";
            this.PasswtextBox.PasswordChar = '*';
            this.PasswtextBox.Size = new System.Drawing.Size(180, 20);
            this.PasswtextBox.TabIndex = 1;
            // 
            // Passwlabel
            // 
            this.Passwlabel.AutoSize = true;
            this.Passwlabel.Location = new System.Drawing.Point(12, 55);
            this.Passwlabel.Name = "Passwlabel";
            this.Passwlabel.Size = new System.Drawing.Size(45, 13);
            this.Passwlabel.TabIndex = 11;
            this.Passwlabel.Text = "Пароль";
            // 
            // LogintextBox
            // 
            this.LogintextBox.Location = new System.Drawing.Point(15, 25);
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(180, 20);
            this.LogintextBox.TabIndex = 0;
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.Location = new System.Drawing.Point(12, 9);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(103, 13);
            this.Loginlabel.TabIndex = 8;
            this.Loginlabel.Text = "Имя пользователя";
            // 
            // DBBtn
            // 
            this.DBBtn.Location = new System.Drawing.Point(48, 156);
            this.DBBtn.Name = "DBBtn";
            this.DBBtn.Size = new System.Drawing.Size(115, 23);
            this.DBBtn.TabIndex = 12;
            this.DBBtn.Text = "Параметры БД…";
            this.DBBtn.UseVisualStyleBackColor = true;
            this.DBBtn.Click += new System.EventHandler(this.DBBtn_Click);
            // 
            // AuthForm
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(208, 191);
            this.Controls.Add(this.DBBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.PasswtextBox);
            this.Controls.Add(this.Passwlabel);
            this.Controls.Add(this.LogintextBox);
            this.Controls.Add(this.Loginlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthForm_FormClosing);
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.TextBox PasswtextBox;
        private System.Windows.Forms.Label Passwlabel;
        private System.Windows.Forms.TextBox LogintextBox;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.Button DBBtn;
    }
}