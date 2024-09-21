using System.Drawing;
using System.Windows.Forms;

namespace UchetTelecom
{
    partial class UsersForm
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
            this.components = new System.ComponentModel.Container();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.UsersDGV = new System.Windows.Forms.DataGridView();
            this.authIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authGrantsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new UchetTelecom.MainDataSet();
            this.authTableAdapter = new UchetTelecom.MainDataSetTableAdapters.AuthTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 230);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(93, 230);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Изменить";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(174, 230);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(255, 230);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // UsersDGV
            // 
            this.UsersDGV.AllowUserToAddRows = false;
            this.UsersDGV.AllowUserToDeleteRows = false;
            this.UsersDGV.AutoGenerateColumns = false;
            this.UsersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authIDDataGridViewTextBoxColumn,
            this.authLoginDataGridViewTextBoxColumn,
            this.authPasswordDataGridViewTextBoxColumn,
            this.authGrantsDataGridViewTextBoxColumn});
            this.UsersDGV.DataSource = this.authBindingSource;
            this.UsersDGV.Location = new System.Drawing.Point(10, 10);
            this.UsersDGV.MultiSelect = false;
            this.UsersDGV.Name = "UsersDGV";
            this.UsersDGV.ReadOnly = true;
            this.UsersDGV.RowHeadersVisible = false;
            this.UsersDGV.RowTemplate.Height = 25;
            this.UsersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDGV.Size = new System.Drawing.Size(320, 200);
            this.UsersDGV.TabIndex = 0;
            this.UsersDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDGV_CellDoubleClick);
            // 
            // authIDDataGridViewTextBoxColumn
            // 
            this.authIDDataGridViewTextBoxColumn.DataPropertyName = "Auth_ID";
            this.authIDDataGridViewTextBoxColumn.HeaderText = "Auth_ID";
            this.authIDDataGridViewTextBoxColumn.Name = "authIDDataGridViewTextBoxColumn";
            this.authIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.authIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // authLoginDataGridViewTextBoxColumn
            // 
            this.authLoginDataGridViewTextBoxColumn.DataPropertyName = "Auth_Login";
            this.authLoginDataGridViewTextBoxColumn.HeaderText = "Имя пользователя";
            this.authLoginDataGridViewTextBoxColumn.Name = "authLoginDataGridViewTextBoxColumn";
            this.authLoginDataGridViewTextBoxColumn.ReadOnly = true;
            this.authLoginDataGridViewTextBoxColumn.Width = 150;
            // 
            // authPasswordDataGridViewTextBoxColumn
            // 
            this.authPasswordDataGridViewTextBoxColumn.DataPropertyName = "Auth_Password";
            this.authPasswordDataGridViewTextBoxColumn.HeaderText = "Auth_Password";
            this.authPasswordDataGridViewTextBoxColumn.Name = "authPasswordDataGridViewTextBoxColumn";
            this.authPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.authPasswordDataGridViewTextBoxColumn.Visible = false;
            // 
            // authGrantsDataGridViewTextBoxColumn
            // 
            this.authGrantsDataGridViewTextBoxColumn.DataPropertyName = "Auth_Grants";
            this.authGrantsDataGridViewTextBoxColumn.HeaderText = "Уровень доступа";
            this.authGrantsDataGridViewTextBoxColumn.Name = "authGrantsDataGridViewTextBoxColumn";
            this.authGrantsDataGridViewTextBoxColumn.ReadOnly = true;
            this.authGrantsDataGridViewTextBoxColumn.Width = 150;
            // 
            // authBindingSource
            // 
            this.authBindingSource.DataMember = "Auth";
            this.authBindingSource.DataSource = this.mainDataSet;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authTableAdapter
            // 
            this.authTableAdapter.ClearBeforeFill = true;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.UsersDGV);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsersForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private Button CloseBtn;
        private DataGridView UsersDGV;
        private MainDataSet mainDataSet;
        private BindingSource authBindingSource;
        private MainDataSetTableAdapters.AuthTableAdapter authTableAdapter;
        private DataGridViewTextBoxColumn authIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authLoginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authPasswordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authGrantsDataGridViewTextBoxColumn;
    }
}