namespace UchetTelecom
{
    partial class UslForm
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
            this.UslDGV = new System.Windows.Forms.DataGridView();
            this.uslIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new UchetTelecom.MainDataSet();
            this.uslTableAdapter = new UchetTelecom.MainDataSetTableAdapters.UslTableAdapter();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UslDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UslDGV
            // 
            this.UslDGV.AllowUserToAddRows = false;
            this.UslDGV.AllowUserToDeleteRows = false;
            this.UslDGV.AutoGenerateColumns = false;
            this.UslDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UslDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uslIDDataGridViewTextBoxColumn,
            this.uslNameDataGridViewTextBoxColumn,
            this.uslPriceDataGridViewTextBoxColumn});
            this.UslDGV.DataSource = this.uslBindingSource;
            this.UslDGV.Location = new System.Drawing.Point(12, 12);
            this.UslDGV.MultiSelect = false;
            this.UslDGV.Name = "UslDGV";
            this.UslDGV.ReadOnly = true;
            this.UslDGV.RowHeadersVisible = false;
            this.UslDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UslDGV.Size = new System.Drawing.Size(360, 250);
            this.UslDGV.TabIndex = 0;
            this.UslDGV.DoubleClick += new System.EventHandler(this.UslDGV_DoubleClick);
            // 
            // uslIDDataGridViewTextBoxColumn
            // 
            this.uslIDDataGridViewTextBoxColumn.DataPropertyName = "Usl_ID";
            this.uslIDDataGridViewTextBoxColumn.HeaderText = "Usl_ID";
            this.uslIDDataGridViewTextBoxColumn.Name = "uslIDDataGridViewTextBoxColumn";
            this.uslIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uslIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // uslNameDataGridViewTextBoxColumn
            // 
            this.uslNameDataGridViewTextBoxColumn.DataPropertyName = "Usl_Name";
            this.uslNameDataGridViewTextBoxColumn.HeaderText = "Название услуги";
            this.uslNameDataGridViewTextBoxColumn.Name = "uslNameDataGridViewTextBoxColumn";
            this.uslNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.uslNameDataGridViewTextBoxColumn.Width = 170;
            // 
            // uslPriceDataGridViewTextBoxColumn
            // 
            this.uslPriceDataGridViewTextBoxColumn.DataPropertyName = "Usl_Price";
            this.uslPriceDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.uslPriceDataGridViewTextBoxColumn.Name = "uslPriceDataGridViewTextBoxColumn";
            this.uslPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.uslPriceDataGridViewTextBoxColumn.Width = 170;
            // 
            // uslBindingSource
            // 
            this.uslBindingSource.DataMember = "Usl";
            this.uslBindingSource.DataSource = this.mainDataSet;
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
            // UslForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.UslDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UslForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Услуги";
            this.Load += new System.EventHandler(this.UslForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UslDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UslDGV;
        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource uslBindingSource;
        private MainDataSetTableAdapters.UslTableAdapter uslTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uslIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uslNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uslPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}