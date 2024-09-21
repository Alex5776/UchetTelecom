namespace UchetTelecom
{
    partial class DealAddEditForm
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
            this.UslcomboBox = new System.Windows.Forms.ComboBox();
            this.ClientcomboBox = new System.Windows.Forms.ComboBox();
            this.StaffcomboBox = new System.Windows.Forms.ComboBox();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.DealDTP = new System.Windows.Forms.DateTimePicker();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UslcomboBox
            // 
            this.UslcomboBox.FormattingEnabled = true;
            this.UslcomboBox.Location = new System.Drawing.Point(12, 25);
            this.UslcomboBox.Name = "UslcomboBox";
            this.UslcomboBox.Size = new System.Drawing.Size(254, 21);
            this.UslcomboBox.TabIndex = 0;
            // 
            // ClientcomboBox
            // 
            this.ClientcomboBox.FormattingEnabled = true;
            this.ClientcomboBox.Location = new System.Drawing.Point(12, 75);
            this.ClientcomboBox.Name = "ClientcomboBox";
            this.ClientcomboBox.Size = new System.Drawing.Size(254, 21);
            this.ClientcomboBox.TabIndex = 1;
            // 
            // StaffcomboBox
            // 
            this.StaffcomboBox.FormattingEnabled = true;
            this.StaffcomboBox.Location = new System.Drawing.Point(12, 125);
            this.StaffcomboBox.Name = "StaffcomboBox";
            this.StaffcomboBox.Size = new System.Drawing.Size(254, 21);
            this.StaffcomboBox.TabIndex = 2;
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(12, 175);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(254, 20);
            this.AddresstextBox.TabIndex = 3;
            // 
            // DealDTP
            // 
            this.DealDTP.Location = new System.Drawing.Point(12, 224);
            this.DealDTP.Name = "DealDTP";
            this.DealDTP.Size = new System.Drawing.Size(254, 20);
            this.DealDTP.TabIndex = 4;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(52, 267);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 5;
            this.OKBtn.Text = "ОК";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(160, 267);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Услуга";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Клиент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Сотрудник";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Адрес окозания услуги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата оказания услуги";
            // 
            // DealAddEditForm
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.DealDTP);
            this.Controls.Add(this.AddresstextBox);
            this.Controls.Add(this.StaffcomboBox);
            this.Controls.Add(this.ClientcomboBox);
            this.Controls.Add(this.UslcomboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DealAddEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DealAddEditForm_FormClosing);
            this.Load += new System.EventHandler(this.DealAddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UslcomboBox;
        private System.Windows.Forms.ComboBox ClientcomboBox;
        private System.Windows.Forms.ComboBox StaffcomboBox;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.DateTimePicker DealDTP;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}