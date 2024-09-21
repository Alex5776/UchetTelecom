using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using UchetTelecom;

namespace UchetTelecom
{
    public partial class SettingsForm : Form
    {
        MainForm mainForm;
        bool SuccessFlag;
        public SettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            FileStream ParamFile = new FileStream("Settings.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(ParamFile);
            writer.WriteLine(TextParam.Text); mainForm.Text = TextParam.Text;
            if (CheckBox1.Checked) { writer.WriteLine("true"); mainForm.ShowIcon = true; } else { writer.WriteLine("false"); mainForm.ShowIcon = false; }
            if (CheckBox2.Checked) { writer.WriteLine("true"); mainForm.FormBorderStyle = FormBorderStyle.Sizable; } else { writer.WriteLine("false"); mainForm.FormBorderStyle = FormBorderStyle.FixedSingle; ; }
            if (RadioBtn1.Checked) { writer.WriteLine("Radio1"); mainForm.WindowState = FormWindowState.Maximized; }
            else if (RadioBtn2.Checked) { writer.WriteLine("Radio2"); mainForm.WindowState = FormWindowState.Normal; }
            writer.Close();
            SuccessFlag = true;
            this.Close();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SuccessFlag)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения?", "Вопрос",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    TextParam.Select();
                }
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            FileStream ParamFile = new FileStream("Settings.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(ParamFile);
            TextParam.Text = reader.ReadLine();
            if (reader.ReadLine() == "true") { CheckBox1.Checked = true; } else { CheckBox1.Checked = false; }
            if (reader.ReadLine() == "true") { CheckBox2.Checked = true; } else { CheckBox2.Checked = false; }
            switch (reader.ReadLine())
            {
                case "Radio1": RadioBtn1.Checked = true; break;
                case "Radio2": RadioBtn2.Checked = true; break;
            }
            reader.Close();
            SuccessFlag = false;
            TextParam.Select();
        }
    }
}