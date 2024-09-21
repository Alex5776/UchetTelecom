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
    public partial class PostAddEditForm : Form
    {
        bool SuccessFlag, Edit_Flag;
        string FormHeader, Post_Name;
        int Edit_ID, Post_ZP;

        public PostAddEditForm(string FormHeader, string Post_Name, int Post_ZP, int Edit_ID, bool Edit_Flag)
        {
            InitializeComponent();
            this.FormHeader = FormHeader;
            this.Post_Name = Post_Name;
            this.Post_ZP = Post_ZP;
            this.Edit_ID = Edit_ID;
            this.Edit_Flag = Edit_Flag;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            bool Err = false;
            string new_Name = NameTextBox.Text.Trim();
            int new_ZP = (int)ZpNUD.Value;
            MainDataSet ds = new MainDataSet();
            DataTable PostTable = ds.Post;
            MainDataSetTableAdapters.PostTableAdapter postTA =
                new MainDataSetTableAdapters.PostTableAdapter();
            postTA.Connection.ConnectionString = DBStatus.DBConnectString;
            postTA.Fill(ds.Post);

            if (string.IsNullOrWhiteSpace(new_Name) == true)
            {
                MessageBox.Show("Не указано наименование должности!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Err = true;
                NameTextBox.Select();
            }

            if (Err == false && (new_ZP == 0))
            {
                MessageBox.Show("Не указана заработная плата!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Err = true;
                ZpNUD.Select();
            }

            if (Err == false && Edit_Flag == false)
            {
                postTA.Adapter.SelectCommand.CommandText = "SELECT Post_ID FROM Post " +
                    "WHERE UPPER(Post_Name)='" + new_Name.ToUpper() + "' AND Post_ZP='" +
                    (int)ZpNUD.Value + "'";
                postTA.Fill(ds.Post);
                DataRow[] foundRows = PostTable.Select();
                if (foundRows.Length > 0)
                {
                    MessageBox.Show("Такая должность уже есть в базе!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Err = true;
                    NameTextBox.Select();
                }
            }
            if (Err == false)
            {
                if (Edit_Flag == false)
                    postTA.Insert(new_Name, new_ZP);
                else
                    postTA.UpdateQuery(new_Name, new_ZP, Edit_ID);
                SuccessFlag = true;
                this.Close();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PostAddEditForm_Load(object sender, EventArgs e)
        {
            SuccessFlag = false;
            this.Text = FormHeader;
            NameTextBox.Text = Post_Name;
            ZpNUD.Value = (decimal)Post_ZP;
            NameTextBox.Select();
        }

        private void PostAddEditForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
