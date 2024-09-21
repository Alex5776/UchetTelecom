namespace UchetTelecom
{
    partial class StaffForm
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
            this.StaffDGV = new System.Windows.Forms.DataGridView();
            this.Staff_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffDGV
            // 
            this.StaffDGV.AllowUserToAddRows = false;
            this.StaffDGV.AllowUserToDeleteRows = false;
            this.StaffDGV.AllowUserToResizeColumns = false;
            this.StaffDGV.AllowUserToResizeRows = false;
            this.StaffDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Staff_ID,
            this.Staff_Num,
            this.Staff_Name,
            this.Staff_Date,
            this.Staff_Phone,
            this.Post});
            this.StaffDGV.Location = new System.Drawing.Point(12, 12);
            this.StaffDGV.MultiSelect = false;
            this.StaffDGV.Name = "StaffDGV";
            this.StaffDGV.ReadOnly = true;
            this.StaffDGV.RowHeadersVisible = false;
            this.StaffDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffDGV.Size = new System.Drawing.Size(460, 250);
            this.StaffDGV.TabIndex = 0;
            this.StaffDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffDGV_CellDoubleClick);
            // 
            // Staff_ID
            // 
            this.Staff_ID.HeaderText = "Staff_ID";
            this.Staff_ID.Name = "Staff_ID";
            this.Staff_ID.ReadOnly = true;
            this.Staff_ID.Visible = false;
            // 
            // Staff_Num
            // 
            this.Staff_Num.HeaderText = "Номер записи";
            this.Staff_Num.Name = "Staff_Num";
            this.Staff_Num.ReadOnly = true;
            this.Staff_Num.Visible = false;
            // 
            // Staff_Name
            // 
            this.Staff_Name.HeaderText = "Имя сотрудника";
            this.Staff_Name.Name = "Staff_Name";
            this.Staff_Name.ReadOnly = true;
            this.Staff_Name.Width = 110;
            // 
            // Staff_Date
            // 
            this.Staff_Date.HeaderText = "Дата рождения";
            this.Staff_Date.Name = "Staff_Date";
            this.Staff_Date.ReadOnly = true;
            this.Staff_Date.Width = 110;
            // 
            // Staff_Phone
            // 
            this.Staff_Phone.HeaderText = "Номер телефона";
            this.Staff_Phone.Name = "Staff_Phone";
            this.Staff_Phone.ReadOnly = true;
            this.Staff_Phone.Width = 110;
            // 
            // Post
            // 
            this.Post.HeaderText = "Должность";
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            this.Post.Width = 110;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(19, 276);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(112, 276);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Изменить";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(206, 276);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(390, 276);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Закрыть";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(298, 276);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Поиск";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SerchBtn_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.StaffDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StaffDGV;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.Button SearchBtn;
    }
}