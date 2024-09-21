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
    public partial class PostForm : Form
    {
        public PostForm()
        {
            InitializeComponent();
        }

        private void PostForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.mainDataSet.Post);

            if (UserStatus.Grants != "Администратор")
            {
                EditBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }
        }

        private void PostDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EditBtn.Enabled) EditBtn_Click(sender, e);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            PostAddEditForm a = new PostAddEditForm("Добавление должности", "", 0, 0, false);
            a.ShowDialog();
            this.postTableAdapter.Fill(this.mainDataSet.Post);

            MainDataSet ds = new MainDataSet();
            DataTable PostTable = ds.Post;
            MainDataSetTableAdapters.PostTableAdapter postTA =
                new MainDataSetTableAdapters.PostTableAdapter();
            postTA.Fill(ds.Post);
            postTA.Adapter.SelectCommand.CommandText = "SELECT TOP 1 * FROM Post ORDER BY Post_ID DESC";
            postTA.Fill(ds.Post);
            DataRow[] foundRows = PostTable.Select();
            if (foundRows.Length > 0)
            {
                int Post_ID = int.Parse(foundRows[0]["Post_ID"].ToString());
                for (int i = 0; i < PostDGV.Rows.Count; i++)
                    if (int.Parse(PostDGV.Rows[i].Cells[0].Value.ToString()) == Post_ID)
                    {
                        PostDGV.Rows[i].Selected = true;
                        break;
                    }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int Edit_ID = int.Parse(PostDGV.SelectedRows[0].Cells[0].Value.ToString());
            string Post_Name = PostDGV.SelectedRows[0].Cells[1].Value.ToString();
            int Post_ZP = int.Parse(PostDGV.SelectedRows[0].Cells[2].Value.ToString());

            PostAddEditForm a = new PostAddEditForm("Изменение должности", Post_Name, Post_ZP, Edit_ID, true);
            a.ShowDialog();
            this.postTableAdapter.Fill(this.mainDataSet.Post);

            for (int i = 0; i < PostDGV.Rows.Count; i++)
                if (int.Parse(PostDGV.Rows[i].Cells[0].Value.ToString()) == Edit_ID)
                {
                    PostDGV.Rows[i].Selected = true;
                    break;
                }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int ID_for_del = int.Parse(PostDGV.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить данную должность?",
                "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MainDataSet ds = new MainDataSet();
                MainDataSetTableAdapters.PostTableAdapter postTA =
                    new MainDataSetTableAdapters.PostTableAdapter();
                postTA.Fill(ds.Post);
                postTA.DeleteQuery(ID_for_del);
                this.postTableAdapter.Fill(this.mainDataSet.Post);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
