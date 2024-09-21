using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UchetTelecom
{
    partial class UserAddEditForm
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
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.CurrentPasswtextBox = new System.Windows.Forms.TextBox();
            this.NewPasswtextBox = new System.Windows.Forms.TextBox();
            this.NewPassw2textBox = new System.Windows.Forms.TextBox();
            this.GrantcomboBox = new System.Windows.Forms.ComboBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.CurrentPasswlabel = new System.Windows.Forms.Label();
            this.NewPasswlabel = new System.Windows.Forms.Label();
            this.NewPassw2label = new System.Windows.Forms.Label();
            this.Grantlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogintextBox
            // 
            this.LogintextBox.Location = new System.Drawing.Point(13, 22);
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(155, 20);
            this.LogintextBox.TabIndex = 0;
            // 
            // CurrentPasswtextBox
            // 
            this.CurrentPasswtextBox.Location = new System.Drawing.Point(13, 62);
            this.CurrentPasswtextBox.Name = "CurrentPasswtextBox";
            this.CurrentPasswtextBox.PasswordChar = '*';
            this.CurrentPasswtextBox.Size = new System.Drawing.Size(155, 20);
            this.CurrentPasswtextBox.TabIndex = 1;
            // 
            // NewPasswtextBox
            // 
            this.NewPasswtextBox.Location = new System.Drawing.Point(13, 101);
            this.NewPasswtextBox.Name = "NewPasswtextBox";
            this.NewPasswtextBox.PasswordChar = '*';
            this.NewPasswtextBox.Size = new System.Drawing.Size(155, 20);
            this.NewPasswtextBox.TabIndex = 2;
            // 
            // NewPassw2textBox
            // 
            this.NewPassw2textBox.Location = new System.Drawing.Point(13, 141);
            this.NewPassw2textBox.Name = "NewPassw2textBox";
            this.NewPassw2textBox.PasswordChar = '*';
            this.NewPassw2textBox.Size = new System.Drawing.Size(155, 20);
            this.NewPassw2textBox.TabIndex = 3;
            // 
            // GrantcomboBox
            // 
            this.GrantcomboBox.FormattingEnabled = true;
            this.GrantcomboBox.Location = new System.Drawing.Point(13, 181);
            this.GrantcomboBox.Name = "GrantcomboBox";
            this.GrantcomboBox.Size = new System.Drawing.Size(155, 21);
            this.GrantcomboBox.TabIndex = 4;
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(13, 215);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(64, 20);
            this.OkBtn.TabIndex = 5;
            this.OkBtn.Text = "ОК";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(103, 215);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(64, 20);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.Location = new System.Drawing.Point(10, 8);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(103, 13);
            this.Loginlabel.TabIndex = 7;
            this.Loginlabel.Text = "Имя пользователя";
            // 
            // CurrentPasswlabel
            // 
            this.CurrentPasswlabel.AutoSize = true;
            this.CurrentPasswlabel.Location = new System.Drawing.Point(10, 48);
            this.CurrentPasswlabel.Name = "CurrentPasswlabel";
            this.CurrentPasswlabel.Size = new System.Drawing.Size(91, 13);
            this.CurrentPasswlabel.TabIndex = 8;
            this.CurrentPasswlabel.Text = "Текущий пароль";
            // 
            // NewPasswlabel
            // 
            this.NewPasswlabel.AutoSize = true;
            this.NewPasswlabel.Location = new System.Drawing.Point(10, 88);
            this.NewPasswlabel.Name = "NewPasswlabel";
            this.NewPasswlabel.Size = new System.Drawing.Size(80, 13);
            this.NewPasswlabel.TabIndex = 9;
            this.NewPasswlabel.Text = "Новый пароль";
            // 
            // NewPassw2label
            // 
            this.NewPassw2label.AutoSize = true;
            this.NewPassw2label.Location = new System.Drawing.Point(10, 127);
            this.NewPassw2label.Name = "NewPassw2label";
            this.NewPassw2label.Size = new System.Drawing.Size(121, 13);
            this.NewPassw2label.TabIndex = 10;
            this.NewPassw2label.Text = "Повтор нового пароля";
            // 
            // Grantlabel
            // 
            this.Grantlabel.AutoSize = true;
            this.Grantlabel.Location = new System.Drawing.Point(10, 167);
            this.Grantlabel.Name = "Grantlabel";
            this.Grantlabel.Size = new System.Drawing.Size(94, 13);
            this.Grantlabel.TabIndex = 11;
            this.Grantlabel.Text = "Уровень доступа";
            // 
            // UserAddEditForm
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(178, 244);
            this.Controls.Add(this.Grantlabel);
            this.Controls.Add(this.NewPassw2label);
            this.Controls.Add(this.NewPasswlabel);
            this.Controls.Add(this.CurrentPasswlabel);
            this.Controls.Add(this.Loginlabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.GrantcomboBox);
            this.Controls.Add(this.NewPassw2textBox);
            this.Controls.Add(this.NewPasswtextBox);
            this.Controls.Add(this.CurrentPasswtextBox);
            this.Controls.Add(this.LogintextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAddEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserAddEditForm_FormClosing);
            this.Load += new System.EventHandler(this.UserAddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox LogintextBox;
        private TextBox CurrentPasswtextBox;
        private TextBox NewPasswtextBox;
        private TextBox NewPassw2textBox;
        private ComboBox GrantcomboBox;
        private Button OkBtn;
        private Button CancelBtn;
        private Label Loginlabel;
        private Label CurrentPasswlabel;
        private Label NewPasswlabel;
        private Label NewPassw2label;
        private Label Grantlabel;
    }
}