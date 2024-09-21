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
    public partial class ClientAddEditForm : Form
    {
        bool SuccessFlag, Edit_Flag;
        string FormHeader, FIO, Phone;
        int Edit_ID;
        DateTime DrDate;

        public ClientAddEditForm(string FormHeader, string FIO, string Phone, DateTime DrDate, int Edit_ID, bool Edit_Flag)
        {
            InitializeComponent();
            this.FormHeader = FormHeader;
            this.FIO = FIO;
            this.Phone = Phone;
            this.DrDate = DrDate;
            this.Edit_ID = Edit_ID;
            this.Edit_Flag = Edit_Flag;
        }
        private void ClientAddEditForm_Load(object sendr, EventArgs e)
        {
            SuccessFlag = false;
            this.Text = FormHeader;
            FIOtextBox.Text = FIO;
            PhoneTextBox.Text = Phone;
            DrDTP.Value = DrDate;
            FIOtextBox.Select();
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            bool Err = false;
            string new_FIO = FIOtextBox.Text.Trim(), new_Phone = PhoneTextBox.Text.Trim();
            MainDataSet ds = new MainDataSet();
            DataTable ClientTable = ds.Client;
            MainDataSetTableAdapters.ClientTableAdapter clientTA =
                new MainDataSetTableAdapters.ClientTableAdapter();
            clientTA.Connection.ConnectionString = DBStatus.DBConnectString;
            clientTA.Fill(ds.Client);

            if (string.IsNullOrWhiteSpace(new_FIO) == true)
            {
                MessageBox.Show("Не указано ФИО клиента!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Err = true;
                FIOtextBox.Select();
            }

            if (Err == false && (new_Phone == "+7(   )   -  -"))
            {
                MessageBox.Show("Не указан номер телефона клиента!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Err = true;
                PhoneTextBox.Select();
            }

            if (Err == false && Edit_Flag == false)
            {
                clientTA.Adapter.SelectCommand.CommandText = "SELECT Client_ID FROM Client " +
                    "WHERE UPPER(Client_Name)='" + new_FIO.ToUpper() + "' AND Client_Date='" +
                    DrDTP.Value.ToShortDateString() + "' AND Client_Phone='" +
                    new_Phone.ToUpper() + "'";
                clientTA.Fill(ds.Client);
                DataRow[] foundRows = ClientTable.Select();
                if (foundRows.Length > 0)
                {
                    MessageBox.Show("Такой клиент уже есть в базе!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Err = true;
                    FIOtextBox.Select();
                }
            }
            if (Err == false)
            {
                if (Edit_Flag == false)
                    clientTA.Insert(new_FIO, DrDTP.Value.Date, new_Phone);
                else
                    clientTA.UpdateQuery(new_FIO, DrDTP.Value.Date, new_Phone, Edit_ID);
                SuccessFlag = true;
                this.Close();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientAddEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SuccessFlag == false)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения?", "Вопрос",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    FIOtextBox.Select();
                }
            }
        }
    }
}