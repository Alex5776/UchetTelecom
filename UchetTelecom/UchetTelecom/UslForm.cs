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
    public partial class UslForm : Form
    {
        public UslForm()
        {
            InitializeComponent();
        }

        private void UslForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Usl". При необходимости она может быть перемещена или удалена.
            this.uslTableAdapter.Fill(this.mainDataSet.Usl);

            if (UserStatus.Grants != "Администратор")
            {
                EditBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            UslAddEditForm a = new UslAddEditForm("Добавление услуги", "", 0, 0, false);
            a.ShowDialog();
            this.uslTableAdapter.Fill(this.mainDataSet.Usl);

            MainDataSet ds = new MainDataSet();
            DataTable UslTable = ds.Usl;
            MainDataSetTableAdapters.UslTableAdapter uslTA =
                new MainDataSetTableAdapters.UslTableAdapter();
            uslTA.Fill(ds.Usl);
            uslTA.Adapter.SelectCommand.CommandText = "SELECT TOP 1 * FROM Usl ORDER BY Usl_ID DESC";
            uslTA.Fill(ds.Usl);
            DataRow[] foundRows = UslTable.Select();
            if (foundRows.Length > 0)
            {
                int Usl_ID = int.Parse(foundRows[0]["Usl_ID"].ToString());
                for (int i = 0; i < UslDGV.Rows.Count; i++)
                    if (int.Parse(UslDGV.Rows[i].Cells[0].Value.ToString()) == Usl_ID)
                    {
                        UslDGV.Rows[i].Selected = true;
                        break;
                    }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int Edit_ID = int.Parse(UslDGV.SelectedRows[0].Cells[0].Value.ToString());
            string Usl_Name = UslDGV.SelectedRows[0].Cells[1].Value.ToString();
            int Usl_Price = int.Parse(UslDGV.SelectedRows[0].Cells[2].Value.ToString());

            UslAddEditForm a = new UslAddEditForm("Изменение услуги", Usl_Name, Usl_Price, Edit_ID, true);
            a.ShowDialog();
            this.uslTableAdapter.Fill(this.mainDataSet.Usl);

            for (int i = 0; i < UslDGV.Rows.Count; i++)
                if (int.Parse(UslDGV.Rows[i].Cells[0].Value.ToString()) == Edit_ID)
                {
                    UslDGV.Rows[i].Selected = true;
                    break;
                }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int ID_for_del = int.Parse(UslDGV.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить данную услугу?",
                "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MainDataSet ds = new MainDataSet();
                MainDataSetTableAdapters.UslTableAdapter uslTA =
                    new MainDataSetTableAdapters.UslTableAdapter();
                uslTA.Fill(ds.Usl);
                uslTA.DeleteQuery(ID_for_del);
                this.uslTableAdapter.Fill(this.mainDataSet.Usl);
            }
        }

        private void UslDGV_DoubleClick(object sender, EventArgs e)
        {
           if (EditBtn.Enabled) EditBtn_Click(sender, e);
        }
    }
}
