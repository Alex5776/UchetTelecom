using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UchetTelecom
{
    public partial class UslAddEditForm : Form
    {
        bool SuccessFlag, Edit_Flag;
        string FormHeader, Usl_Name;
        int Edit_ID,Usl_Price;

        public UslAddEditForm(string FormHeader, string Usl_Name, int Usl_Price, int Edit_ID, bool Edit_Flag)
        {
            InitializeComponent();
            this.FormHeader = FormHeader;
            this.Usl_Name = Usl_Name;
            this.Usl_Price = Usl_Price;
            this.Edit_ID = Edit_ID;
            this.Edit_Flag = Edit_Flag;
        }

        private void UslAddEditForm_Load(object sender, EventArgs e)
        {
            SuccessFlag = false;
            this.Text = FormHeader;
            NameTextBox.Text = Usl_Name;
            PriceNUD.Value = (decimal)Usl_Price;
            NameTextBox.Select();
        }

        private void UslAddEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SuccessFlag == false)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения?", "Вопрос",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    NameTextBox.Select();
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            bool Err = false;
            string new_Name = NameTextBox.Text.Trim();
            int new_Price = (int)PriceNUD.Value;
            MainDataSet ds = new MainDataSet();
            DataTable UslTable = ds.Usl;
            MainDataSetTableAdapters.UslTableAdapter uslTA =
                new MainDataSetTableAdapters.UslTableAdapter();
            uslTA.Connection.ConnectionString = DBStatus.DBConnectString;
            uslTA.Fill(ds.Usl);

            if (string.IsNullOrWhiteSpace(new_Name) == true)
            {
                MessageBox.Show("Не указано название улсуги!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Err = true;
                NameTextBox.Select();
            }

            if (Err == false && (new_Price == 0))
            {
                MessageBox.Show("Не указана стоимость услуги!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Err = true;
                PriceNUD.Select();
            }

            if (Err == false && Edit_Flag == false)
            {
                uslTA.Adapter.SelectCommand.CommandText = "SELECT Usl_ID FROM Usl " +
                    "WHERE UPPER(Usl_Name)='" + new_Name.ToUpper() + "' AND Usl_Price='" +
                    (int)PriceNUD.Value + "'";
                uslTA.Fill(ds.Usl);
                DataRow[] foundRows = UslTable.Select();
                if (foundRows.Length > 0)
                {
                    MessageBox.Show("Такая услуга уже есть в базе!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Err = true;
                    NameTextBox.Select();
                }
            }
            if (Err == false)
            {
                if (Edit_Flag == false)
                    uslTA.Insert(new_Name, new_Price);
                else
                    uslTA.UpdateQuery(new_Name, new_Price, Edit_ID);
                SuccessFlag = true;
                this.Close();
            }
        }
    }
}
