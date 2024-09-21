using System.Drawing;
using System.Windows.Forms;

namespace UchetTelecom
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UchetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UslToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DealAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DealEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DealDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainstatusStrip = new System.Windows.Forms.StatusStrip();
            this.Bottompanel = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DealDGV = new System.Windows.Forms.DataGridView();
            this.Deal_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deal_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usl_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deal_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deal_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogintoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.GrantstoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.MainstatusStrip.SuspendLayout();
            this.Bottompanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DealDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.UchetToolStripMenuItem,
            this.настройкаToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RelogToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // RelogToolStripMenuItem
            // 
            this.RelogToolStripMenuItem.Name = "RelogToolStripMenuItem";
            this.RelogToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RelogToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.RelogToolStripMenuItem.Text = "Войти под другим именем";
            this.RelogToolStripMenuItem.Click += new System.EventHandler(this.RelogToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // UchetToolStripMenuItem
            // 
            this.UchetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientToolStripMenuItem,
            this.UslToolStripMenuItem,
            this.StaffToolStripMenuItem,
            this.PostToolStripMenuItem,
            this.DealToolStripMenuItem});
            this.UchetToolStripMenuItem.Name = "UchetToolStripMenuItem";
            this.UchetToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.UchetToolStripMenuItem.Text = "Учет";
            // 
            // ClientToolStripMenuItem
            // 
            this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
            this.ClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ClientToolStripMenuItem.Text = "Клиенты";
            this.ClientToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // UslToolStripMenuItem
            // 
            this.UslToolStripMenuItem.Name = "UslToolStripMenuItem";
            this.UslToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UslToolStripMenuItem.Text = "Услуги";
            this.UslToolStripMenuItem.Click += new System.EventHandler(this.UslToolStripMenuItem_Click);
            // 
            // StaffToolStripMenuItem
            // 
            this.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem";
            this.StaffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StaffToolStripMenuItem.Text = "Сотрудники";
            this.StaffToolStripMenuItem.Click += new System.EventHandler(this.StaffToolStripMenuItem_Click);
            // 
            // PostToolStripMenuItem
            // 
            this.PostToolStripMenuItem.Name = "PostToolStripMenuItem";
            this.PostToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PostToolStripMenuItem.Text = "Должности";
            this.PostToolStripMenuItem.Click += new System.EventHandler(this.PostToolStripMenuItem_Click);
            // 
            // DealToolStripMenuItem
            // 
            this.DealToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DealAddToolStripMenuItem,
            this.DealEditToolStripMenuItem,
            this.DealDeleteToolStripMenuItem});
            this.DealToolStripMenuItem.Name = "DealToolStripMenuItem";
            this.DealToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DealToolStripMenuItem.Text = "Сделки";
            // 
            // DealAddToolStripMenuItem
            // 
            this.DealAddToolStripMenuItem.Name = "DealAddToolStripMenuItem";
            this.DealAddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DealAddToolStripMenuItem.Text = "Добавить";
            this.DealAddToolStripMenuItem.Click += new System.EventHandler(this.DealAddToolStripMenuItem_Click);
            // 
            // DealEditToolStripMenuItem
            // 
            this.DealEditToolStripMenuItem.Name = "DealEditToolStripMenuItem";
            this.DealEditToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DealEditToolStripMenuItem.Text = "Изменить";
            this.DealEditToolStripMenuItem.Click += new System.EventHandler(this.DealEditToolStripMenuItem_Click);
            // 
            // DealDeleteToolStripMenuItem
            // 
            this.DealDeleteToolStripMenuItem.Name = "DealDeleteToolStripMenuItem";
            this.DealDeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DealDeleteToolStripMenuItem.Text = "Удалить";
            this.DealDeleteToolStripMenuItem.Click += new System.EventHandler(this.DealDeleteToolStripMenuItem_Click);
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.UsersToolStripMenuItem});
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SettingsToolStripMenuItem.Text = "Параметры...";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // UsersToolStripMenuItem
            // 
            this.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            this.UsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UsersToolStripMenuItem.Text = "Пользователи...";
            this.UsersToolStripMenuItem.Click += new System.EventHandler(this.UsersToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainstatusStrip
            // 
            this.MainstatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogintoolStripStatusLabel,
            this.GrantstoolStripStatusLabel});
            this.MainstatusStrip.Location = new System.Drawing.Point(0, 368);
            this.MainstatusStrip.Name = "MainstatusStrip";
            this.MainstatusStrip.Size = new System.Drawing.Size(686, 22);
            this.MainstatusStrip.TabIndex = 2;
            // 
            // Bottompanel
            // 
            this.Bottompanel.Controls.Add(this.SearchBtn);
            this.Bottompanel.Controls.Add(this.DeleteBtn);
            this.Bottompanel.Controls.Add(this.EditBtn);
            this.Bottompanel.Controls.Add(this.AddBtn);
            this.Bottompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottompanel.Location = new System.Drawing.Point(0, 308);
            this.Bottompanel.Name = "Bottompanel";
            this.Bottompanel.Size = new System.Drawing.Size(686, 60);
            this.Bottompanel.TabIndex = 1;
            this.Bottompanel.Resize += new System.EventHandler(this.Bottompanel_Resize);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(517, 16);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Поиск…";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(386, 16);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(252, 16);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Изменить";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(121, 16);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DealDGV
            // 
            this.DealDGV.AllowUserToAddRows = false;
            this.DealDGV.AllowUserToDeleteRows = false;
            this.DealDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DealDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deal_ID,
            this.Deal_Num,
            this.Usl_Name,
            this.Client_Name,
            this.Staff_Name,
            this.Deal_Address,
            this.Deal_Date});
            this.DealDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DealDGV.Location = new System.Drawing.Point(0, 24);
            this.DealDGV.MultiSelect = false;
            this.DealDGV.Name = "DealDGV";
            this.DealDGV.ReadOnly = true;
            this.DealDGV.RowHeadersVisible = false;
            this.DealDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DealDGV.Size = new System.Drawing.Size(686, 284);
            this.DealDGV.TabIndex = 0;
            this.DealDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DealDGV_CellDoubleClick);
            this.DealDGV.Resize += new System.EventHandler(this.DealDGV_Resize);
            // 
            // Deal_ID
            // 
            this.Deal_ID.HeaderText = "Deal_ID";
            this.Deal_ID.Name = "Deal_ID";
            this.Deal_ID.ReadOnly = true;
            this.Deal_ID.Visible = false;
            // 
            // Deal_Num
            // 
            this.Deal_Num.HeaderText = "Номер записи";
            this.Deal_Num.Name = "Deal_Num";
            this.Deal_Num.ReadOnly = true;
            // 
            // Usl_Name
            // 
            this.Usl_Name.HeaderText = "Услуга";
            this.Usl_Name.Name = "Usl_Name";
            this.Usl_Name.ReadOnly = true;
            // 
            // Client_Name
            // 
            this.Client_Name.HeaderText = "Клиент";
            this.Client_Name.Name = "Client_Name";
            this.Client_Name.ReadOnly = true;
            // 
            // Staff_Name
            // 
            this.Staff_Name.HeaderText = "Сотрудник";
            this.Staff_Name.Name = "Staff_Name";
            this.Staff_Name.ReadOnly = true;
            // 
            // Deal_Address
            // 
            this.Deal_Address.HeaderText = "Адрес";
            this.Deal_Address.Name = "Deal_Address";
            this.Deal_Address.ReadOnly = true;
            // 
            // Deal_Date
            // 
            this.Deal_Date.HeaderText = "Дата";
            this.Deal_Date.Name = "Deal_Date";
            this.Deal_Date.ReadOnly = true;
            // 
            // LogintoolStripStatusLabel
            // 
            this.LogintoolStripStatusLabel.Name = "LogintoolStripStatusLabel";
            this.LogintoolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // GrantstoolStripStatusLabel
            // 
            this.GrantstoolStripStatusLabel.Name = "GrantstoolStripStatusLabel";
            this.GrantstoolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.DealDGV);
            this.Controls.Add(this.Bottompanel);
            this.Controls.Add(this.MainstatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainstatusStrip.ResumeLayout(false);
            this.MainstatusStrip.PerformLayout();
            this.Bottompanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DealDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem RelogToolStripMenuItem;
        private ToolStripMenuItem UchetToolStripMenuItem;
        private ToolStripMenuItem настройкаToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem SettingsToolStripMenuItem;
        private ToolStripMenuItem UsersToolStripMenuItem;
        private ToolStripMenuItem ClientToolStripMenuItem;
        private ToolStripMenuItem UslToolStripMenuItem;
        private ToolStripMenuItem StaffToolStripMenuItem;
        private ToolStripMenuItem PostToolStripMenuItem;
        private StatusStrip MainstatusStrip;
        private Panel Bottompanel;
        private Button SearchBtn;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private DataGridView DealDGV;
        private DataGridViewTextBoxColumn Deal_ID;
        private DataGridViewTextBoxColumn Deal_Num;
        private DataGridViewTextBoxColumn Usl_Name;
        private DataGridViewTextBoxColumn Client_Name;
        private DataGridViewTextBoxColumn Staff_Name;
        private DataGridViewTextBoxColumn Deal_Address;
        private DataGridViewTextBoxColumn Deal_Date;
        private ToolStripMenuItem DealToolStripMenuItem;
        private ToolStripMenuItem DealAddToolStripMenuItem;
        private ToolStripMenuItem DealEditToolStripMenuItem;
        private ToolStripMenuItem DealDeleteToolStripMenuItem;
        private ToolStripStatusLabel LogintoolStripStatusLabel;
        private ToolStripStatusLabel GrantstoolStripStatusLabel;
    }
}