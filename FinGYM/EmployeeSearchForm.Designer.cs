namespace FinGYM
{
    partial class EmployeeSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSearchForm));
            this.btnSearchRe = new System.Windows.Forms.Button();
            this.btnSearchBack = new System.Windows.Forms.Button();
            this.grdEmpSearch = new System.Windows.Forms.DataGridView();
            this.btnEmployee_Search = new System.Windows.Forms.Button();
            this.txtEmployee_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblErrorMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchRe
            // 
            this.btnSearchRe.BackColor = System.Drawing.Color.Beige;
            this.btnSearchRe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRe.ForeColor = System.Drawing.Color.White;
            this.btnSearchRe.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchRe.Image")));
            this.btnSearchRe.Location = new System.Drawing.Point(919, 181);
            this.btnSearchRe.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchRe.Name = "btnSearchRe";
            this.btnSearchRe.Size = new System.Drawing.Size(193, 44);
            this.btnSearchRe.TabIndex = 19;
            this.btnSearchRe.Text = "Refresh";
            this.btnSearchRe.UseVisualStyleBackColor = false;
            this.btnSearchRe.Click += new System.EventHandler(this.btnSearchRe_Click);
            // 
            // btnSearchBack
            // 
            this.btnSearchBack.BackColor = System.Drawing.Color.Beige;
            this.btnSearchBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBack.ForeColor = System.Drawing.Color.White;
            this.btnSearchBack.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchBack.Image")));
            this.btnSearchBack.Location = new System.Drawing.Point(118, 631);
            this.btnSearchBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchBack.Name = "btnSearchBack";
            this.btnSearchBack.Size = new System.Drawing.Size(193, 44);
            this.btnSearchBack.TabIndex = 18;
            this.btnSearchBack.Text = "Back";
            this.btnSearchBack.UseVisualStyleBackColor = false;
            this.btnSearchBack.Click += new System.EventHandler(this.btnSearchBack_Click);
            // 
            // grdEmpSearch
            // 
            this.grdEmpSearch.AutoGenerateColumns = false;
            this.grdEmpSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEmpSearch.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdEmpSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdEmpID,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn});
            this.grdEmpSearch.DataSource = this.employeeBindingSource;
            this.grdEmpSearch.Location = new System.Drawing.Point(166, 245);
            this.grdEmpSearch.Margin = new System.Windows.Forms.Padding(4);
            this.grdEmpSearch.Name = "grdEmpSearch";
            this.grdEmpSearch.RowHeadersWidth = 51;
            this.grdEmpSearch.Size = new System.Drawing.Size(946, 319);
            this.grdEmpSearch.TabIndex = 17;
            // 
            // btnEmployee_Search
            // 
            this.btnEmployee_Search.BackColor = System.Drawing.Color.Beige;
            this.btnEmployee_Search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee_Search.ForeColor = System.Drawing.Color.White;
            this.btnEmployee_Search.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee_Search.Image")));
            this.btnEmployee_Search.Location = new System.Drawing.Point(919, 129);
            this.btnEmployee_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployee_Search.Name = "btnEmployee_Search";
            this.btnEmployee_Search.Size = new System.Drawing.Size(193, 44);
            this.btnEmployee_Search.TabIndex = 16;
            this.btnEmployee_Search.Text = "Search";
            this.btnEmployee_Search.UseVisualStyleBackColor = false;
            this.btnEmployee_Search.Click += new System.EventHandler(this.btnEmployee_Search_Click);
            // 
            // txtEmployee_Search
            // 
            this.txtEmployee_Search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee_Search.Location = new System.Drawing.Point(370, 129);
            this.txtEmployee_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployee_Search.Multiline = true;
            this.txtEmployee_Search.Name = "txtEmployee_Search";
            this.txtEmployee_Search.Size = new System.Drawing.Size(493, 40);
            this.txtEmployee_Search.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Employee ID";
            // 
            // grdEmpID
            // 
            this.grdEmpID.DataPropertyName = "ID";
            this.grdEmpID.HeaderText = "ID";
            this.grdEmpID.MinimumWidth = 6;
            this.grdEmpID.Name = "grdEmpID";
            this.grdEmpID.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "jobTitle";
            this.jobTitleDataGridViewTextBoxColumn.HeaderText = "jobTitle";
            this.jobTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            // 
            // hireDateDataGridViewTextBoxColumn
            // 
            this.hireDateDataGridViewTextBoxColumn.DataPropertyName = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.HeaderText = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hireDateDataGridViewTextBoxColumn.Name = "hireDateDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // managerDataGridViewTextBoxColumn
            // 
            this.managerDataGridViewTextBoxColumn.DataPropertyName = "manager";
            this.managerDataGridViewTextBoxColumn.HeaderText = "manager";
            this.managerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.managerDataGridViewTextBoxColumn.Name = "managerDataGridViewTextBoxColumn";
            this.managerDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(FinGYM.Employee);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblErrorMsg.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(528, 631);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(83, 33);
            this.lblErrorMsg.TabIndex = 185;
            this.lblErrorMsg.Text = "label2";
            this.lblErrorMsg.Visible = false;
            // 
            // EmployeeSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 764);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchRe);
            this.Controls.Add(this.btnSearchBack);
            this.Controls.Add(this.grdEmpSearch);
            this.Controls.Add(this.btnEmployee_Search);
            this.Controls.Add(this.txtEmployee_Search);
            this.Name = "EmployeeSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeSearchForm";
            this.Load += new System.EventHandler(this.EmployeeSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchRe;
        private System.Windows.Forms.Button btnSearchBack;
        private System.Windows.Forms.DataGridView grdEmpSearch;
        private System.Windows.Forms.Button btnEmployee_Search;
        private System.Windows.Forms.TextBox txtEmployee_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}