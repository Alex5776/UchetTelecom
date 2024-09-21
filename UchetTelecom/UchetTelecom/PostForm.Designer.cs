namespace UchetTelecom
{
    partial class PostForm
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
            this.PostDGV = new System.Windows.Forms.DataGridView();
            this.postIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postZPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new UchetTelecom.MainDataSet();
            this.uslTableAdapter = new UchetTelecom.MainDataSetTableAdapters.UslTableAdapter();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.postTableAdapter = new UchetTelecom.MainDataSetTableAdapters.PostTableAdapter();
            this.uslBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PostDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PostDGV
            // 
            this.PostDGV.AllowUserToAddRows = false;
            this.PostDGV.AllowUserToDeleteRows = false;
            this.PostDGV.AutoGenerateColumns = false;
            this.PostDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PostDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postIDDataGridViewTextBoxColumn,
            this.postNameDataGridViewTextBoxColumn,
            this.postZPDataGridViewTextBoxColumn});
            this.PostDGV.DataSource = this.postBindingSource;
            this.PostDGV.Location = new System.Drawing.Point(12, 12);
            this.PostDGV.MultiSelect = false;
            this.PostDGV.Name = "PostDGV";
            this.PostDGV.ReadOnly = true;
            this.PostDGV.RowHeadersVisible = false;
            this.PostDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PostDGV.Size = new System.Drawing.Size(360, 250);
            this.PostDGV.TabIndex = 0;
            this.PostDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PostDGV_CellDoubleClick);
            // 
            // postIDDataGridViewTextBoxColumn
            // 
            this.postIDDataGridViewTextBoxColumn.DataPropertyName = "Post_ID";
            this.postIDDataGridViewTextBoxColumn.HeaderText = "Post_ID";
            this.postIDDataGridViewTextBoxColumn.Name = "postIDDataGridViewTextBoxColumn";
            this.postIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.postIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // postNameDataGridViewTextBoxColumn
            // 
            this.postNameDataGridViewTextBoxColumn.DataPropertyName = "Post_Name";
            this.postNameDataGridViewTextBoxColumn.HeaderText = "Название должности";
            this.postNameDataGridViewTextBoxColumn.Name = "postNameDataGridViewTextBoxColumn";
            this.postNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.postNameDataGridViewTextBoxColumn.Width = 170;
            // 
            // postZPDataGridViewTextBoxColumn
            // 
            this.postZPDataGridViewTextBoxColumn.DataPropertyName = "Post_ZP";
            this.postZPDataGridViewTextBoxColumn.HeaderText = "Заработная плата";
            this.postZPDataGridViewTextBoxColumn.Name = "postZPDataGridViewTextBoxColumn";
            this.postZPDataGridViewTextBoxColumn.ReadOnly = true;
            this.postZPDataGridViewTextBoxColumn.Width = 170;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "Post";
            this.postBindingSource.DataSource = this.mainDataSet;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uslTableAdapter
            // 
            this.uslTableAdapter.ClearBeforeFill = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 276);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(107, 276);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Изменить";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(202, 276);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(297, 276);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Закрыть";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PostDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PostForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Должности";
            this.Load += new System.EventHandler(this.PostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PostDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView PostDGV;
        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource uslBindingSource;
        private MainDataSetTableAdapters.UslTableAdapter uslTableAdapter;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.BindingSource postBindingSource;
        private MainDataSetTableAdapters.PostTableAdapter postTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn postIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postZPDataGridViewTextBoxColumn;
    }
}