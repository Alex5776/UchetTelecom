using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UchetTelecom.MainDataSetTableAdapters;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UchetTelecom
{
    public partial class DBConnectForm : Form
    {
        public DBConnectForm()
        {
            InitializeComponent();
        }

        private void DBConnectForm_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("dbset.txt"))
            {
                FileStream DBFile = new FileStream("dbset.txt", FileMode.Open, FileAccess.Read); 
                StreamReader reader = new StreamReader(DBFile); 
                DBtextBox.Text = reader.ReadLine();
                reader.Close();
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DBtextBox.Text) == false)
            {
                string DBConnectString = DBtextBox.Text.Trim();
                try
                {
                    MainDataSet ds = new MainDataSet();
                    MainDataSetTableAdapters.AuthTableAdapter authTA =
                        new MainDataSetTableAdapters.AuthTableAdapter();
                    authTA.Connection.ConnectionString = DBConnectString;
                    authTA.Fill(ds.Auth);
                    FileStream DBFile = new FileStream("dbset.txt", FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(DBFile);
                    writer.WriteLine(DBtextBox.Text);
                    writer.Close();
                    DBStatus.DBConnectString = DBConnectString;
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Строка подключения указана некорректно!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DBtextBox.Select();
                }
            }
            else
            {
                MessageBox.Show("Строка подключения не указана!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DBtextBox.Select();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
