using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UchetTelecom.MainDataSetTableAdapters;

namespace UchetTelecom
{
    public partial class DealAddEditForm : Form
    {

        bool SuccessFlag, EditFlag;
        int Edit_ID;
        string FormHeader, Usl, Client, Staff, Address;
        DateTime Deal_Date;

        public DealAddEditForm(string FormHeader, DateTime Deal_Date, string Usl, 
            string Client, string Staff, string Address, int Edit_ID, bool EditFlag)
        {
            InitializeComponent();
            this.FormHeader = FormHeader;
            this.Deal_Date = Deal_Date;
            this.Usl = Usl;
            this.Client = Client;
            this.Staff = Staff;
            this.Address = Address;
            this.Edit_ID = Edit_ID;
            this.EditFlag = EditFlag;
        }

        private void DealAddEditForm_Load(object sender, EventArgs e)

        {
            MainDataSet ds = new MainDataSet();
            DataTable UslTable = ds.Usl, ClientTable = ds.Client,
                StaffTable = ds.Staff;
            MainDataSetTableAdapters.UslTableAdapter uslTA =
                new MainDataSetTableAdapters.UslTableAdapter();
            MainDataSetTableAdapters.ClientTableAdapter clientTA =
                new MainDataSetTableAdapters.ClientTableAdapter();
            MainDataSetTableAdapters.StaffTableAdapter staffTA =
                new MainDataSetTableAdapters.StaffTableAdapter();
            uslTA.Connection.ConnectionString = DBStatus.DBConnectString;
            clientTA.Connection.ConnectionString = DBStatus.DBConnectString;
            staffTA.Connection.ConnectionString = DBStatus.DBConnectString;
            uslTA.Fill(ds.Usl);
            clientTA.Fill(ds.Client);
            staffTA.Fill(ds.Staff);
            uslTA.Adapter.SelectCommand.CommandText = "SELECT * FROM Usl ORDER BY Usl_Name DESC";
            clientTA.Adapter.SelectCommand.CommandText = "SELECT * FROM Client ORDER BY Client_Name DESC";
            staffTA.Adapter.SelectCommand.CommandText = "SELECT * FROM Staff INNER JOIN Post ON Staff.Post_ID=Post.Post_ID ORDER BY Staff_Name DESC";
            uslTA.Fill(ds.Usl);
            clientTA.Fill(ds.Client);
            staffTA.Fill(ds.Staff);
            DataRow[] foundUsl = UslTable.Select(),
                foundClient = ClientTable.Select(), foundStaff = StaffTable.Select();
            UslcomboBox.Items.Clear();
            ClientcomboBox.Items.Clear();
            StaffcomboBox.Items.Clear();
            if (foundUsl.Length > 0)
                foreach (DataRow row in foundUsl)
                    UslcomboBox.Items.Add(row["Usl_Name"].ToString());
            if (foundClient.Length > 0)
                foreach (DataRow row in foundClient)
                    ClientcomboBox.Items.Add(row["Client_Name"].ToString());
            if (foundStaff.Length > 0)
                //Ошибка Post не относится к Staff
                foreach (DataRow row in foundStaff)
                {
                    string Post = row["Post_Name"].ToString(),
                            Staff = row["Staff_Name"].ToString();
                    StaffcomboBox.Items.Add(Staff + " (" + Post + ")");
                }
                //
            this.Text = FormHeader;
            UslcomboBox.Text = Usl;
            ClientcomboBox.Text = Client;
            StaffcomboBox.Text = Staff;
            AddresstextBox.Text = Address;
            DealDTP.Text = Deal_Date.ToShortDateString();
            SuccessFlag = false;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UslcomboBox.Text) == false &&
                string.IsNullOrWhiteSpace(ClientcomboBox.Text) == false &&
                string.IsNullOrWhiteSpace(StaffcomboBox.Text) == false)
            {
                int quot_index = StaffcomboBox.Text.IndexOf('(');
                string strPost = StaffcomboBox.Text.Substring(quot_index + 1);
                strPost = strPost.Remove(strPost.Length - 1);
                string Staff_Name = StaffcomboBox.Text.Substring(0, quot_index - 1);
                int Deal_ID = 0, Usl_ID = 0, Client_ID = 0, Staff_ID = 0, Deal_Num = 1;
                MainDataSet ds = new MainDataSet();
                DataTable DealTable = ds.Deal, UslTable = ds.Usl, ClientTable = ds.Client,
                    StaffTable = ds.Staff;
                MainDataSetTableAdapters.DealTableAdapter dealTA =
                    new MainDataSetTableAdapters.DealTableAdapter();
                MainDataSetTableAdapters.UslTableAdapter uslTA =
                    new MainDataSetTableAdapters.UslTableAdapter();
                MainDataSetTableAdapters.ClientTableAdapter clientTA =
                    new MainDataSetTableAdapters.ClientTableAdapter();
                MainDataSetTableAdapters.StaffTableAdapter staffTA =
                    new MainDataSetTableAdapters.StaffTableAdapter();
                dealTA.Connection.ConnectionString = DBStatus.DBConnectString;
                uslTA.Connection.ConnectionString = DBStatus.DBConnectString;
                clientTA.Connection.ConnectionString = DBStatus.DBConnectString;
                staffTA.Connection.ConnectionString = DBStatus.DBConnectString;
                dealTA.Fill(ds.Deal);
                uslTA.Fill(ds.Usl);
                clientTA.Fill(ds.Client);
                staffTA.Fill(ds.Staff);
                uslTA.Adapter.SelectCommand.CommandText = "SELECT Usl_ID FROM Usl WHERE UPPER(Usl_Name)='" + UslcomboBox.Text.ToUpper() + "'";
                uslTA.Fill(ds.Usl);
                DataRow[] foundRows = UslTable.Select();
                if (foundRows.Length > 0) Usl_ID = int.Parse(foundRows[0]["Usl_ID"].ToString());
                clientTA.Adapter.SelectCommand.CommandText = "SELECT * FROM Client WHERE UPPER(Client_Name)='" + ClientcomboBox.Text.ToUpper() + "'";
                clientTA.Fill(ds.Client);
                foundRows = ClientTable.Select();
                if (foundRows.Length > 0) Client_ID = int.Parse(foundRows[0]["Client_ID"].ToString());
                staffTA.Adapter.SelectCommand.CommandText = "SELECT Staff_ID FROM Staff WHERE UPPER(Staff_Name)='" + Staff_Name.ToUpper() + "'";
                staffTA.Fill(ds.Staff);
                foundRows = StaffTable.Select();
                if (foundRows.Length > 0) Staff_ID = int.Parse(foundRows[0]["Staff_ID"].ToString());
                if (EditFlag == false)
                {
                    dealTA.Adapter.SelectCommand.CommandText = "SELECT TOP 1 * FROM Deal ORDER BY Deal_Num DESC";
                    dealTA.Fill(ds.Deal);
                    foundRows = DealTable.Select();
                    if (foundRows.Length > 0) Deal_Num = int.Parse(foundRows[0]["Deal_Num"].ToString()) + 1;
                }
                else
                {
                    dealTA.Adapter.SelectCommand.CommandText = "SELECT * From Deal WHERE Deal_ID=" + Edit_ID.ToString();
                    dealTA.Fill(ds.Deal);
                    foundRows = DealTable.Select();
                    if (foundRows.Length > 0) Deal_Num = int.Parse(foundRows[0]["Deal_Num"].ToString());
                }
                if (Usl_ID == 0 || Client_ID == 0 || Staff_ID == 0)
                {
                    MessageBox.Show("Ошибка выбора услуги, клиента или сотрудника. Проверьте правильность ввода данных!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (EditFlag == false)
                    {
                        dealTA.Insert(Deal_Num, Usl_ID, Client_ID, Staff_ID, AddresstextBox.Text, DealDTP.Value.Date);
                    }
                    else
                    {
                        dealTA.UpdateQuery(Deal_Num, Usl_ID, Client_ID, Staff_ID, Address, Deal_Date, Edit_ID);
                    }
                    SuccessFlag = true;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Заполнены не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DealAddEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SuccessFlag == false)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения?", "Вопрос",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    UslcomboBox.Select();
                }
            }
        }
    }
}
