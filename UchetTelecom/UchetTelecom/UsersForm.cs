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
    public partial class UsersForm : Form
    {

        public UsersForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            this.authTableAdapter.Fill(this.mainDataSet.Auth);

            if (UserStatus.Grants != "Администратор")
            {
                EditBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            UserAddEditForm a = new UserAddEditForm("Добавление пользователя", "", "", "", 0, false);
            a.ShowDialog();
            this.authTableAdapter.Fill(this.mainDataSet.Auth);

            MainDataSet ds = new MainDataSet();
            DataTable AuthTable = ds.Auth;
            MainDataSetTableAdapters.AuthTableAdapter uslTA =
                new MainDataSetTableAdapters.AuthTableAdapter();
            uslTA.Fill(ds.Auth);
            uslTA.Adapter.SelectCommand.CommandText = "SELECT TOP 1 * FROM Auth ORDER BY Auth_ID DESC";
            uslTA.Fill(ds.Auth);
            DataRow[] foundRows = AuthTable.Select();
            if (foundRows.Length > 0)
            {
                int Auth_ID = int.Parse(foundRows[0]["Auth_ID"].ToString());
                for (int i = 0; i < UsersDGV.Rows.Count; i++)
                    if (int.Parse(UsersDGV.Rows[i].Cells[0].Value.ToString()) == Auth_ID)
                    {
                        UsersDGV.Rows[i].Selected = true;
                        break;
                    }
            }
        }

        private void UsersDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (UsersDGV.SelectedRows.Count > 0)
            {
                EditBtn.Enabled = true;
                DeleteBtn.Enabled = true;
            }
            else
            {
                EditBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            string login = UsersDGV.SelectedRows[0].Cells[1].Value.ToString(),
                password = UsersDGV.SelectedRows[0].Cells[2].Value.ToString(),
                grants = UsersDGV.SelectedRows[0].Cells[3].Value.ToString();
            int Edit_ID = int.Parse(UsersDGV.SelectedRows[0].Cells[0].Value.ToString());

            UserAddEditForm a = new UserAddEditForm("Изменение пользователя", login, password, grants, Edit_ID, true);
            a.ShowDialog();
            this.authTableAdapter.Fill(this.mainDataSet.Auth);

            for (int i = 0; i < UsersDGV.Rows.Count; i++)
                if (int.Parse(UsersDGV.Rows[i].Cells[0].Value.ToString()) == Edit_ID)
                {
                    UsersDGV.Rows[i].Selected = true;
                    break;
                }
        }

        private void UsersDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EditBtn.Enabled) EditBtn_Click(sender, e);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int ID_for_delete = int.Parse(UsersDGV.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить данного пользователя?",
                "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MainDataSet ds = new MainDataSet();
                MainDataSetTableAdapters.AuthTableAdapter authTA =
                    new MainDataSetTableAdapters.AuthTableAdapter();
                authTA.Fill(ds.Auth);
                authTA.DeleteQuery(ID_for_delete);
                this.authTableAdapter.Fill(this.mainDataSet.Auth);
            }
        }
    }
}
