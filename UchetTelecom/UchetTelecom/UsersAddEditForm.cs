using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchetTelecom
{
    public partial class UserAddEditForm : Form
    {
        public bool SuccessFlag, Edit_Flag;
        string FormHeader, login, password, grants;
        int Edit_ID;
        public UserAddEditForm(string FormHeader, string login, string password,
            string grants, int Edit_ID, bool Edit_Flag)
        {
            InitializeComponent();
            this.FormHeader = FormHeader;
            this.login = login;
            this.password = password;
            this.grants = grants;
            this.Edit_ID = Edit_ID;
            this.Edit_Flag = Edit_Flag;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserAddEditForm_Load(object sender, EventArgs e)
        {
            this.Text = FormHeader;
            LogintextBox.Text = login;
            GrantcomboBox.Text = grants;
            if (Edit_Flag == false)
            {
                LogintextBox.Select();
                CurrentPasswlabel.Enabled = false;
                CurrentPasswtextBox.Enabled = false;
            }
            else CurrentPasswtextBox.Select();
            if (UserStatus.Grants == "Администратор") GrantcomboBox.Items.Add("Администратор");
            GrantcomboBox.Items.Add("Пользователь");
            SuccessFlag = false;
        }

        private void UserAddEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SuccessFlag != true)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения?", "Вопрос",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) e.Cancel = true;
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            bool Err = false;
            string new_login = LogintextBox.Text.Trim();
            MainDataSet ds = new MainDataSet();
            DataTable AuthTable = ds.Auth;
            MainDataSetTableAdapters.AuthTableAdapter authTA = new MainDataSetTableAdapters.AuthTableAdapter();
            authTA.Connection.ConnectionString = DBStatus.DBConnectString;
            authTA.Fill(ds.Auth);
            if (Edit_Flag == true)
            {
                if (string.IsNullOrWhiteSpace(CurrentPasswtextBox.Text) == false)
                {
                    if (CurrentPasswtextBox.Text != password)
                    {
                        MessageBox.Show("Текущий пароль неверный!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Err = true;
                        CurrentPasswtextBox.Select();
                        CurrentPasswtextBox.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Текущий пароль не указан!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Err = true;
                    CurrentPasswtextBox.Select();
                }
            }
            if (Err == false)
            {
                if (string.IsNullOrWhiteSpace(LogintextBox.Text) == false &&
                    string.IsNullOrWhiteSpace(NewPasswtextBox.Text) == false &&
                    string.IsNullOrWhiteSpace(NewPassw2textBox.Text) == false &&
                    string.IsNullOrWhiteSpace(GrantcomboBox.Text) == false)
                {
                    if (NewPasswtextBox.Text != NewPassw2textBox.Text)
                    {
                        MessageBox.Show("Пароли не совпадают!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Err = true;
                    }
                }
                else
                {
                    MessageBox.Show("Заполнены не все поля!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Err = true;
                }
            }
            if (Err == false && Edit_Flag == false)
            {
                authTA.Adapter.SelectCommand.CommandText =
                    "SELECT Auth_ID FROM Auth WHERE UPPER(Auth_Login)='" + new_login.ToUpper() + "'";
                authTA.Fill(ds.Auth);
                DataRow[] foundRows = AuthTable.Select();
                if (foundRows.Length > 0)
                {
                    MessageBox.Show("Такой пользователь уже существует!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Err = true;
                }
            }
            if (Err == false)
            {
                if (Edit_Flag == false)
                {
                    authTA.Insert(new_login, NewPassw2textBox.Text, GrantcomboBox.Text);
                }
                else
                {
                    authTA.UpdateQuery(new_login, NewPassw2textBox.Text, GrantcomboBox.Text, Edit_ID);
                }
                SuccessFlag = true;
                this.Close();
            }
        }
    }
}