using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UchetTelecom.MainDataSetTableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace UchetTelecom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FillDealDGV(int strID)
        {
            MainDataSet ds = new MainDataSet();
            DataTable DealTable = ds.Deal;
            MainDataSetTableAdapters.DealTableAdapter dealTA =
                new MainDataSetTableAdapters.DealTableAdapter();
            dealTA.Fill(ds.Deal);
            dealTA.Adapter.SelectCommand.CommandText = "SELECT Deal_ID, Deal_Num, Usl.Usl_Name, Client.Client_Name, Staff.Staff_Name, Post.Post_Name, Deal_Address, Deal_Date " +
                "FROM Deal INNER JOIN Usl ON Deal.Usl_ID=Usl.Usl_ID INNER JOIN Client ON Deal.Client_ID=Client.Client_ID " +
                "INNER JOIN Staff ON Deal.Staff_ID=Staff.Staff_ID INNER JOIN Post ON Staff.Post_ID=Post.Post_ID";
            dealTA.Fill(ds.Deal);
            DealDGV.Rows.Clear();
            DataRow[] foundRows = DealTable.Select();
            if (foundRows.Length > 0)
            {
                foreach (DataRow row in foundRows)
                {
                    int Deal_ID = int.Parse(row["Deal_ID"].ToString()),
                        Deal_Num = int.Parse(row["Deal_Num"].ToString());
                    DateTime Deal_Date = DateTime.Parse(row["Deal_Date"].ToString());
                    string Usl_Name = row["Usl_Name"].ToString(),
                        Client_Name = row["Client_Name"].ToString(),
                        Staff_Name = row["Staff_Name"].ToString() + " (" +
                        row["Post_Name"].ToString() + ")",
                        Deal_Address = row["Deal_Address"].ToString();
                    DealDGV.Rows.Add(Deal_ID.ToString(), Deal_Num.ToString(), Usl_Name, Client_Name, Staff_Name,
                        Deal_Address, Deal_Date.ToShortDateString());
                }
            }

            if (strID == 0)
            {
                dealTA.Adapter.SelectCommand.CommandText = "SELECT TOP 1 * FROM Deal ORDER BY Deal_ID DESC";
                dealTA.Fill(ds.Deal);
                foundRows = DealTable.Select();
                strID = int.Parse(foundRows[0]["Deal_ID"].ToString());
                for (int i = 0; i < DealDGV.Rows.Count; i++)
                    if (int.Parse(DealDGV.Rows[i].Cells[0].Value.ToString()) == strID)
                    {
                        DealDGV.Rows[i].Selected = true;
                        break;
                    }
            }
            else if (strID > 0)
                for (int i = 0; i < DealDGV.Rows.Count; i++)
                    if (int.Parse(DealDGV.Rows[i].Cells[0].Value.ToString()) == strID)
                    {
                        DealDGV.Rows[i].Selected = true; 
                        break;
                    }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.ShowDialog();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm a = new SettingsForm(this);
            a.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogintoolStripStatusLabel.Text = "Пользователь: " + UserStatus.Login;
            GrantstoolStripStatusLabel.Text = "Уровень доступа: " + UserStatus.Grants;
            DealDGV_Resize(sender, e);
            FileStream ParamFile = new FileStream("Settings.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(ParamFile);
            this.Text = reader.ReadLine();
            if (reader.ReadLine() == "true") this.ShowIcon = true; else this.ShowIcon = false;
            if (reader.ReadLine() == "true") this.FormBorderStyle = FormBorderStyle.Sizable; else this.FormBorderStyle = FormBorderStyle.FixedSingle;
            switch (reader.ReadLine())
            {
                case "Radio1": this.WindowState = FormWindowState.Maximized; break;
                case "Radio2": this.WindowState = FormWindowState.Normal; break;
            }
            reader.Close();
            AppStatus.IsClose = true;
            FillDealDGV(-1);

            if (UserStatus.Grants != "Администратор")
            {
                EditBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm a = new UsersForm();
            a.ShowDialog();
        }

        private void RelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppStatus.IsClose = false;
            this.Close();
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm a = new ClientForm();
            a.ShowDialog(this);
        }

        private void UslToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UslForm a = new UslForm();
            a.ShowDialog(this);
        }

        private void PostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostForm a = new PostForm();
            a.ShowDialog();
        }

        private void StaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffForm a = new StaffForm();
            a.ShowDialog();
        }

        private void Bottompanel_Resize(object sender, EventArgs e)
        {
            AddBtn.Top = Bottompanel.Height / 2 - AddBtn.Height / 2;
            EditBtn.Top = AddBtn.Top;
            DeleteBtn.Top = AddBtn.Top;
            SearchBtn.Top = AddBtn.Top;

            DeleteBtn.Left = Bottompanel.Width / 2 - DeleteBtn.Width;
            EditBtn.Left = DeleteBtn.Left - EditBtn.Width - 30;
            AddBtn.Left = EditBtn.Left - AddBtn.Width - 30;
            SearchBtn.Left = Bottompanel.Width - SearchBtn.Width - 30;
        }

        private void DealDGV_Resize(object sender, EventArgs e)
        {
            int CurrentDGVWidth = DealDGV.Width - DealDGV.Columns[1].Width - 150 - 20;

            DealDGV.Columns[2].Width = 150;
            DealDGV.Columns[3].Width = CurrentDGVWidth / 4 + 50;
            DealDGV.Columns[4].Width = CurrentDGVWidth / 4 + 50;
            DealDGV.Columns[5].Width = CurrentDGVWidth / 4 - 50;
            DealDGV.Columns[6].Width = CurrentDGVWidth / 4 - 50;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DealAddEditForm a = new DealAddEditForm("Добавление запись об окозании услуги", DateTime.Now, "", "", "", "", 0, false);
            a.ShowDialog();
            FillDealDGV(0);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (DealDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбраны данные для изменения", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int Deal_ID = int.Parse(DealDGV.SelectedRows[0].Cells[0].Value.ToString());
                DateTime Reg_Date = DateTime.Parse(DealDGV.SelectedRows[0].Cells[6].Value.ToString());
                string Usl = DealDGV.SelectedRows[0].Cells[2].Value.ToString(),
                    Client = DealDGV.SelectedRows[0].Cells[3].Value.ToString(),
                    Staff = DealDGV.SelectedRows[0].Cells[4].Value.ToString(),
                    Address = DealDGV.SelectedRows[0].Cells[5].Value.ToString();

                DealAddEditForm a = new DealAddEditForm("Изменение запись об окозании услуги",
                    Reg_Date, Usl, Client, Staff, Address, Deal_ID, true);
                a.ShowDialog();
                FillDealDGV(Deal_ID);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (DealDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбраны данные для удаления", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?",
                    "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int Reg_ID = int.Parse(DealDGV.SelectedRows[0].Cells[0].Value.ToString());
                    MainDataSet ds = new MainDataSet();
                    MainDataSetTableAdapters.DealTableAdapter dealTA =
                        new MainDataSetTableAdapters.DealTableAdapter();
                    dealTA.Fill(ds.Deal);
                    dealTA.DeleteQuery(Reg_ID);
                    DealDGV.Rows.RemoveAt(DealDGV.SelectedRows[0].Index);
                }
            }
        }

        private void DealDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EditBtn.Enabled) EditBtn_Click(sender, e);
        }

        private void DealAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBtn_Click(sender, e);
        }

        private void DealEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EditBtn.Enabled) EditBtn_Click(sender, e);
        }

        private void DealDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EditBtn.Enabled) DeleteBtn_Click(sender, e);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchBtn.Text == "Сброс")
            {
                SearchBtn.Text = "Поиск...";
                FillDealDGV(-1);
            }
            else
            {
                SearchForm a = new SearchForm();
                a.ShowDialog();
                string SearchStr = a.SearchStr;
                if (string.IsNullOrEmpty(SearchStr) == false)
                {
                    MainDataSet ds = new MainDataSet();
                    DataTable DealTable = ds.Deal;
                    MainDataSetTableAdapters.DealTableAdapter dealTA =
                        new MainDataSetTableAdapters.DealTableAdapter();
                    dealTA.Fill(ds.Deal);
                    dealTA.Adapter.SelectCommand.CommandText = "SELECT Deal_ID, Deal_Num, Usl.Usl_Name, Client.Client_Name, Staff.Staff_Name,Post.Post_Name, Deal_Address, Deal_Date " +
                "FROM Deal INNER JOIN Usl ON Deal.Usl_ID=Usl.Usl_ID INNER JOIN Client ON Deal.Client_ID=Client.Client_ID " +
                "INNER JOIN Staff ON Deal.Staff_ID=Staff.Staff_ID INNER JOIN Post ON Staff.Post_ID=Post.Post_ID WHERE ((Deal_Num LIKE '%" +
                SearchStr + "%') OR (UPPER(Usl.Usl_Name) LIKE '%" +
                SearchStr.ToUpper() + "%') OR (UPPER(Client.Client_Name) LIKE '%" +
                SearchStr.ToUpper() + "%') OR (UPPER(Staff.Staff_Name) LIKE '%" +
                SearchStr.ToUpper() + "%') OR (UPPER(Deal_Address) LIKE '%" +
                SearchStr.ToUpper() + "%') OR (UPPER(Post_Name) LIKE '%" +
                SearchStr.ToUpper() + "%') OR (Deal_Date LIKE '%" +
                SearchStr + "%'))";
                    dealTA.Fill(ds.Deal);
                    SearchBtn.Text = "Сброс";
                    DealDGV.Rows.Clear();
                    DataRow[] foundRows = DealTable.Select();
                    if (foundRows.Length > 0)
                    {
                        foreach (DataRow row in foundRows)
                        {
                            int Deal_ID = int.Parse(row["Deal_ID"].ToString()),
                                Deal_Num = int.Parse(row["Deal_Num"].ToString());
                            DateTime Deal_Date = DateTime.Parse(row["Deal_Date"].ToString());
                            string Usl_Name = row["Usl_Name"].ToString(),
                                Client_Name = row["Client_Name"].ToString(),
                                Staff_Name = row["Staff_Name"].ToString() + " (" + row["Post_Name"] + ")",
                                Deal_Address = row["Deal_Address"].ToString();
                            DealDGV.Rows.Add(Deal_ID, Deal_Num, Usl_Name, Client_Name, Staff_Name, Deal_Address, Deal_Date);
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
    }
}