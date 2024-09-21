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
    public partial class SearchForm : Form
    {
        public string SearchStr { get; set; }
        
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            SearchStr = "";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchtextBox.Text) == false)
            {
                SearchStr = SearchtextBox.Text;
                this.Close();
            }
            else
            { 
                MessageBox.Show("В строку поиска ничего не ввудено!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SearchtextBox.Select();
            }
        }
    }
}
