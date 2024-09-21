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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void FillStaffDGV(int strID)
        {
            MainDataSet ds = new MainDataSet();
            DataTable StaffTable = ds.Staff;
            MainDataSetTableAdapters.StaffTableAdapter staffTA = 
                new MainDataSetTableAdapters.StaffTableAdapter();
            staffTA.Fill(ds.Staff);
            staffTA.Adapter.SelectCommand.CommandText = "SELECT Staff_ID, Staff_Num, Staff_Name, " +
                "Staff_Date, Staff_Phone, Post.Post_Name FROM Staff INNER JOIN Post ON Staff.Post_ID=Post.Post_ID";
            staffTA.Fill(ds.Staff);
            StaffDGV.Rows.Clear();
            DataRow[] foundRows = StaffTable.Select();
            if (foundRows.Length > 0 ) 
            { 
                foreach (DataRow row in foundRows) 
                {
                    int Staff_ID = int.Parse(row["Staff_ID"].ToString()),
                        Staff_Num = int.Parse(row["Staff_Num"].ToString());
                    string Staff_Name = row["Staff_Name"].ToString(),
                        Staff_Phone = row["Staff_Phone"].ToString(),
                        Post_Name = row["Post_Name"].ToString();
                    DateTime Staff_Date = DateTime.Parse(row["Staff_Date"].ToString());
                    StaffDGV.Rows.Add(Staff_ID.ToString(), Staff_Num.ToString(), 
                        Staff_Name, Staff_Date.ToShortDateString(), Staff_Phone, Post_Name);
                }
            }

            if (strID == 0)
            {
                staffTA.Adapter.SelectCommand.CommandText = "SELECT TOP 1 * FROM Staff ORDER BY Staff_ID DESC";
                staffTA.Fill(ds.Staff);
                foundRows = StaffTable.Select();
                strID = int.Parse(foundRows[0]["Staff_ID"].ToString());
                for (int i = 0; i < StaffDGV.Rows.Count; i++)
                    if (int.Parse(StaffDGV.Rows[i].Cells[0].Value.ToString()) == strID)
                    {
                        StaffDGV.Rows[i].Selected = true;
                        break;
                    }
            }
            else if (strID > 0)
                for (int i = 0; i < StaffDGV.Rows.Count; i++)
                    if (int.Parse(StaffDGV.Rows[i].Cells[0].Value.ToString()) == strID)
                    {
                        StaffDGV.Rows[i].Selected = true;
                        break;
                    }
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            AppStatus.IsClose = true;
            FillStaffDGV(-1);

            if (UserStatus.Grants != "Администратор")
            {
                EditBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            StaffAddEditForm a = new StaffAddEditForm("Добавление сотрудника", DateTime.Now, "", "", "", 0, false);
            a.ShowDialog();
            FillStaffDGV(0);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StaffDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбраны данные для изменения!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int Staff_ID = int.Parse(StaffDGV.SelectedRows[0].Cells[0].Value.ToString());
                DateTime Staff_Date = DateTime.Parse(StaffDGV.SelectedRows[0].Cells[3].Value.ToString());
                string Staff_Name = StaffDGV.SelectedRows[0].Cells[2].Value.ToString(),
                    Staff_Phone = StaffDGV.SelectedRows[0].Cells[4].Value.ToString(),
                    Post_Name = StaffDGV.SelectedRows[0].Cells[5].Value.ToString();

                StaffAddEditForm a = new StaffAddEditForm("Изменение данных о сотруднике", Staff_Date, Staff_Name, Staff_Phone, Post_Name, Staff_ID, true);
                a.ShowDialog();
                FillStaffDGV(Staff_ID);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (StaffDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбраны данные для удаления!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?",
                    "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) 
                { 
                    int Staff_ID = int.Parse(StaffDGV.SelectedRows[0].Cells[0].Value.ToString());
                    MainDataSet ds = new MainDataSet();
                    MainDataSetTableAdapters.StaffTableAdapter staffTA =
                        new MainDataSetTableAdapters.StaffTableAdapter();
                    staffTA.Fill(ds.Staff);
                    staffTA.DeleteQuery(Staff_ID);
                    StaffDGV.Rows.RemoveAt(StaffDGV.SelectedRows[0].Index);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SerchBtn_Click(object sender, EventArgs e)
        {
            if (SearchBtn.Text == "Сброс")
            {
                SearchBtn.Text = "Поиск...";
                FillStaffDGV(-1);
            }
            else
            {
                SearchForm a = new SearchForm();
                a.ShowDialog();
                string SearchStr = a.SearchStr;
                if (string.IsNullOrEmpty(SearchStr) == false)
                { 
                    MainDataSet ds = new MainDataSet();
                    DataTable StaffTable = ds.Staff;
                    MainDataSetTableAdapters.StaffTableAdapter staffTA =
                        new MainDataSetTableAdapters.StaffTableAdapter();
                    staffTA.Fill(ds.Staff);
                    staffTA.Adapter.SelectCommand.CommandText = "SELECT Staff_ID, Staff_Num, Staff_Name, " +
                        "Staff_Date, Staff_Phone, Post.Post_Name FROM Staff INNER JOIN Post ON Staff.Post_ID=Post.Post_ID " +
                        "WHERE ((UPPER(Staff_Name) LIKE '%" + SearchStr.ToUpper() + "%') OR (Staff_Date LIKE '%" + SearchStr +
                        "%') OR (Staff_Phone LIKE '%" + SearchStr + "%') OR (UPPER(Post_Name) LIKE '%" + SearchStr.ToUpper() + "%'))";
                    staffTA.Fill(ds.Staff);
                    SearchBtn.Text = "Сброс";
                    StaffDGV.Rows.Clear();
                    DataRow[] foundRows = StaffTable.Select();
                    if (foundRows.Length > 0)
                    {
                        foreach (DataRow row in foundRows)
                        {
                            int Staff_ID = int.Parse(row["Staff_ID"].ToString()),
                                Staff_Num = int.Parse(row["Staff_Num"].ToString());
                            DateTime Staff_Date = DateTime.Parse(row["Staff_Date"].ToString());
                            string Staff_Name = row["Staff_Name"].ToString(),
                                Staff_Phone = row["Staff_Phone"].ToString(),
                                Post_Name = row["Post_Name"].ToString();
                            StaffDGV.Rows.Add(Staff_ID, Staff_Num, Staff_Name, Staff_Date.ToShortDateString(), 
                                Staff_Phone, Post_Name);
                        }
                    }
                    else 
                    {
                        MessageBox.Show("По поисковому запросу '" + SearchStr + "' ничего не найдено!", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void StaffDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EditBtn.Enabled) EditBtn_Click(sender, e);
        }
    }
}
