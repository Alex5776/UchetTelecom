using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UchetTelecom;

namespace Library
{
    public partial class AuthForm : Form
    {
        bool FastStart;

        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            DBStatus.DBConnectString = "";
            if (File.Exists("dbset.txt") == true)
            {
                try
                {
                    FileStream DBFile = new FileStream("dbset.txt", FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(DBFile);
                    DBStatus.DBConnectString = reader.ReadLine();
                    reader.Close();
                    FastStart = false;
                    MainDataSet ds = new MainDataSet();
                    DataTable AuthTable = ds.Auth;
                    UchetTelecom.MainDataSetTableAdapters.AuthTableAdapter authTA =
                        new UchetTelecom.MainDataSetTableAdapters.AuthTableAdapter();
                    authTA.Connection.ConnectionString = DBStatus.DBConnectString;
                    authTA.Fill(ds.Auth);
                    authTA.Adapter.SelectCommand.CommandText = "SELECT * FROM Auth";
                    authTA.Fill(ds.Auth);
                    DataRow[] foundRows = AuthTable.Select();
                    if (foundRows.Length == 0)
                    {
                        FastStart = true;
                        UserStatus.Login = "отсутствует";
                        UserStatus.Grants = "Администратор";
                        this.Close();
                    }
                    else LogintextBox.Select();
                }
                catch
                {
                    MessageBox.Show("Не удалось выполнить подключение к базе данных! " +
                        "Возможно некорректно указана строка подключения.", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            { 
                MessageBox.Show("He найден файл dbset.txt сo строкой подключения к базе данных!", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FastStart == false) Application.Exit();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DBStatus.DBConnectString) == true)
            {
                MessageBox.Show("Строка подключения не указана!", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string new_login = LogintextBox.Text.Trim();
                MainDataSet ds = new MainDataSet();
                DataTable AuthTable = ds.Auth;
                UchetTelecom.MainDataSetTableAdapters.AuthTableAdapter authTA =
                    new UchetTelecom.MainDataSetTableAdapters.AuthTableAdapter();
                authTA.Connection.ConnectionString = DBStatus.DBConnectString;
                authTA.Fill(ds.Auth);
                authTA.Adapter.SelectCommand.CommandText =
                    "SELECT * FROM Auth WHERE UPPER(Auth_Login)='" + new_login.ToUpper() + "'";
                authTA.Fill(ds.Auth);
                DataRow[] foundRows = AuthTable.Select();
                if (foundRows.Length == 0)
                {
                    MessageBox.Show("Пользователь не найден! Попробуйте перезапустить приложение.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LogintextBox.Select();
                }
                else
                {
                    if (PasswtextBox.Text != foundRows[0]["Auth_Password"].ToString())
                    {
                        MessageBox.Show("Неверный пароль!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PasswtextBox.Select();
                    }
                    else
                    {
                        FastStart = true;
                        UserStatus.Login = foundRows[0]["Auth_Login"].ToString();
                        UserStatus.Grants = foundRows[0]["Auth_Grants"].ToString();
                        this.Close();
                    }
                }
            }
        }

        private void DBBtn_Click(object sender, EventArgs e)
        {
            DBConnectForm a = new DBConnectForm();
            a.ShowDialog();
        }
    }
}
