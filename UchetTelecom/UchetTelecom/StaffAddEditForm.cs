using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchetTelecom
{
    public partial class StaffAddEditForm : Form
    {
        bool SuccessFlag, EditFlag;
        int Edit_ID;
        string FormHeader, Staff_Name, Staff_Phone, Post_Name;
        DateTime Staff_Date;

        private void StaffAddEditForm_Load(object sender, EventArgs e)
        {
            MainDataSet ds = new MainDataSet();
            DataTable PostTable = ds.Post;
            MainDataSetTableAdapters.PostTableAdapter postTA =
                new MainDataSetTableAdapters.PostTableAdapter();
            postTA.Fill(ds.Post);
            postTA.Adapter.SelectCommand.CommandText = "SELECT * " +
                "FROM Post ORDER BY Post_Name DESC";
            postTA.Fill(ds.Post);
            DataRow[] foundPost = PostTable.Select();
            PostComboBox.Items.Clear();
            if (foundPost.Length > 0)
                foreach (DataRow row in foundPost)
                {
                    string Name = row["Post_Name"].ToString();
                    PostComboBox.Items.Add(Name);
                }
            this.Text = FormHeader;
            NameTextBox.Text = Staff_Name;
            DateDTP.Value = Staff_Date;
            PhoneTextBox.Text = Staff_Phone;
            PostComboBox.Text = Post_Name;
            SuccessFlag = false;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PostComboBox.Text) == false)
            {
                string PostName = PostComboBox.Text;
                int Post_ID = 0, Staff_Num = 1;
                MainDataSet ds = new MainDataSet();
                DataTable PostTable = ds.Post,
                    StaffTable = ds.Staff;
                MainDataSetTableAdapters.PostTableAdapter postTA =
                    new MainDataSetTableAdapters.PostTableAdapter();
                MainDataSetTableAdapters.StaffTableAdapter staffTA =
                    new MainDataSetTableAdapters.StaffTableAdapter();
                postTA.Connection.ConnectionString = DBStatus.DBConnectString;
                staffTA.Connection.ConnectionString = DBStatus.DBConnectString;
                postTA.Fill(ds.Post);
                staffTA.Fill(ds.Staff);
                postTA.Adapter.SelectCommand.CommandText = "SELECT * FROM Post " +
                    "WHERE UPPER(Post_Name)='" + PostName.ToUpper() + "'";
                postTA.Fill(ds.Post);
                DataRow[] foundRows = PostTable.Select();
                if (foundRows.Length > 0) Post_ID = int.Parse(foundRows[0]["Post_ID"].ToString());
                if (EditFlag == false)
                {
                    staffTA.Adapter.SelectCommand.CommandText = "SELECT TOP 1 Staff_Num FROM Staff " +
                        "ORDER BY Staff_Num DESC";
                    staffTA.Fill(ds.Staff);
                    foundRows = StaffTable.Select();
                    if (foundRows.Length > 0) Staff_Num = int.Parse(foundRows[0]["Staff_Num"].ToString()) + 1;
                }
                else
                {
                    staffTA.Adapter.SelectCommand.CommandText = "SELECT Staff_Num FROM Staff " +
                        "WHERE Staff_ID=" + Edit_ID.ToString();
                    staffTA.Fill(ds.Staff);
                    foundRows = StaffTable.Select();
                    if (foundRows.Length > 0) Staff_Num = int.Parse(foundRows[0]["Staff_Num"].ToString());
                }
                if (Post_ID == 0)
                {
                    MessageBox.Show("Ошибка выбора сотрудника. Проверьте правильность ввода данних!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (EditFlag == false)
                    {
                        staffTA.Insert(Staff_Num, NameTextBox.Text, DateDTP.Value.Date, PhoneTextBox.Text, Post_ID);
                    }
                    else
                    {
                        staffTA.UpdateQuery(Staff_Num, NameTextBox.Text, DateDTP.Value.Date, PhoneTextBox.Text, Post_ID, Edit_ID);
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

        public StaffAddEditForm(string FormHeader, DateTime Staff_Date, string Staff_Name,
            string Staff_Phone, string Post_Name, int Edit_ID, bool EditFlag)
        {
            InitializeComponent();
            this.FormHeader = FormHeader;
            this.Staff_Date = Staff_Date;
            this.Staff_Name = Staff_Name;
            this.Staff_Phone = Staff_Phone;
            this.Post_Name = Post_Name;
            this.Edit_ID = Edit_ID;
            this.EditFlag = EditFlag;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StaffAddEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SuccessFlag != true) 
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения?", "Вопрос",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) e.Cancel = true;
            }
        }
    }
}
