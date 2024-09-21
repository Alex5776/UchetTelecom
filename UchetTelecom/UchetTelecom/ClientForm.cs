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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

            private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.mainDataSet.Client);

            if (UserStatus.Grants != "Администратор")
            { 
                EditBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ClientAddEditForm a = new ClientAddEditForm("Добавление клиента", "", "", DateTime.Now, 0, false);
            a.ShowDialog();
            this.clientTableAdapter.Fill(this.mainDataSet.Client);

            MainDataSet ds = new MainDataSet();
            DataTable ClientTable = ds.Client;
            MainDataSetTableAdapters.ClientTableAdapter clientTA =
                new MainDataSetTableAdapters.ClientTableAdapter();
            clientTA.Fill(ds.Client);
            clientTA.Adapter.SelectCommand.CommandText = "SELECT TOP 1 * FROM Client ORDER BY Client_ID DESC";
            clientTA.Fill(ds.Client);
            DataRow[] foundRows = ClientTable.Select();
            if (foundRows.Length > 0)
            {
                int Client_ID = int.Parse(foundRows[0]["Client_ID"].ToString());
                for (int i = 0; i < ClientDGV.Rows.Count; i++)
                    if (int.Parse(ClientDGV.Rows[i].Cells[0].Value.ToString()) == Client_ID)
                    {
                        ClientDGV.Rows[i].Selected = true;
                        break;
                    }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int Edit_ID = int.Parse(ClientDGV.SelectedRows[0].Cells[0].Value.ToString()); 
            string FIO = ClientDGV.SelectedRows[0].Cells[1].Value.ToString();
            DateTime DrDate = DateTime.Parse(ClientDGV.SelectedRows[0].Cells[2].Value.ToString());
            string Phone = ClientDGV.SelectedRows[0].Cells[3].Value.ToString();
           
            ClientAddEditForm a = new ClientAddEditForm("Изменение клиента", FIO, Phone, DrDate, Edit_ID, true);
            a.ShowDialog();
            this.clientTableAdapter.Fill(this.mainDataSet.Client);

            for (int i = 0; i < ClientDGV.Rows.Count; i++)
                if (int.Parse(ClientDGV.Rows[i].Cells[0].Value.ToString()) == Edit_ID)
                {
                    ClientDGV.Rows[i].Selected = true;
                    break;
                }
        }

        private void ClientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (EditBtn.Enabled) EditBtn_Click(sender, e);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int ID_for_del = int.Parse(ClientDGV.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить данного клиента?",
                "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MainDataSet ds = new MainDataSet();
                MainDataSetTableAdapters.ClientTableAdapter clientTA =
                    new MainDataSetTableAdapters.ClientTableAdapter(); 
                clientTA.Fill(ds.Client); 
                clientTA.DeleteQuery(ID_for_del); 
                this.clientTableAdapter.Fill(this.mainDataSet.Client);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
