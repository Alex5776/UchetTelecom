using System.Drawing;
using System.Windows.Forms;

namespace UchetTelecom
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextParam = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioBtn2 = new System.Windows.Forms.RadioButton();
            this.RadioBtn1 = new System.Windows.Forms.RadioButton();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.Textlabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextParam
            // 
            this.TextParam.Location = new System.Drawing.Point(10, 23);
            this.TextParam.Name = "TextParam";
            this.TextParam.Size = new System.Drawing.Size(308, 20);
            this.TextParam.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckBox2);
            this.groupBox1.Controls.Add(this.CheckBox1);
            this.groupBox1.Location = new System.Drawing.Point(10, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Группа параметров 1";
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(5, 41);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(145, 17);
            this.CheckBox2.TabIndex = 1;
            this.CheckBox2.Text = "Изменять размер окна";
            this.CheckBox2.UseVisualStyleBackColor = true;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(5, 19);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(126, 17);
            this.CheckBox1.TabIndex = 0;
            this.CheckBox1.Text = "Отображать иконку";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioBtn2);
            this.groupBox2.Controls.Add(this.RadioBtn1);
            this.groupBox2.Location = new System.Drawing.Point(173, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 63);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры окна";
            // 
            // RadioBtn2
            // 
            this.RadioBtn2.AutoSize = true;
            this.RadioBtn2.Location = new System.Drawing.Point(5, 41);
            this.RadioBtn2.Name = "RadioBtn2";
            this.RadioBtn2.Size = new System.Drawing.Size(71, 17);
            this.RadioBtn2.TabIndex = 1;
            this.RadioBtn2.TabStop = true;
            this.RadioBtn2.Text = "Оконный";
            this.RadioBtn2.UseVisualStyleBackColor = true;
            // 
            // RadioBtn1
            // 
            this.RadioBtn1.AutoSize = true;
            this.RadioBtn1.Location = new System.Drawing.Point(5, 19);
            this.RadioBtn1.Name = "RadioBtn1";
            this.RadioBtn1.Size = new System.Drawing.Size(99, 17);
            this.RadioBtn1.TabIndex = 0;
            this.RadioBtn1.TabStop = true;
            this.RadioBtn1.Text = "На весь экран";
            this.RadioBtn1.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(91, 143);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(64, 20);
            this.OKBtn.TabIndex = 3;
            this.OKBtn.Text = "ОК";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(173, 143);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(64, 20);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Textlabel
            // 
            this.Textlabel.AutoSize = true;
            this.Textlabel.Location = new System.Drawing.Point(10, 8);
            this.Textlabel.Name = "Textlabel";
            this.Textlabel.Size = new System.Drawing.Size(113, 13);
            this.Textlabel.TabIndex = 5;
            this.Textlabel.Text = "Текст главного окна";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(329, 182);
            this.Controls.Add(this.Textlabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextParam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextParam;
        private GroupBox groupBox1;
        private CheckBox CheckBox2;
        private CheckBox CheckBox1;
        private GroupBox groupBox2;
        private RadioButton RadioBtn2;
        private RadioButton RadioBtn1;
        private Button OKBtn;
        private Button CancelBtn;
        private Label Textlabel;
    }
}