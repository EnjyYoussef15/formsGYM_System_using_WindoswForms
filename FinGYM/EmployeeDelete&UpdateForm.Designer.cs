namespace FinGYM
{
    partial class EmployeeDelete_UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDelete_UpdateForm));
            this.txtDUEmployeePhone = new System.Windows.Forms.TextBox();
            this.txtDUEmployeeJob = new System.Windows.Forms.TextBox();
            this.txtDUEmployeeAge = new System.Windows.Forms.TextBox();
            this.EmployeeHireDate = new System.Windows.Forms.DateTimePicker();
            this.radioTraineeFemale = new System.Windows.Forms.RadioButton();
            this.radioTraineeMale = new System.Windows.Forms.RadioButton();
            this.txtDUEmployeeName = new System.Windows.Forms.TextBox();
            this.txtDUEmployeeID = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTraineeClass = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grdUpdateEmployee = new System.Windows.Forms.DataGridView();
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
            this.btnDeleteAndUpdate_Back = new System.Windows.Forms.Button();
            this.btnDeleteAndUpdate_Reset = new System.Windows.Forms.Button();
            this.btnDeleteAndUpdate_Update = new System.Windows.Forms.Button();
            this.txtDUEmployeeSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDUEmployeePhone
            // 
            this.txtDUEmployeePhone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUEmployeePhone.Location = new System.Drawing.Point(236, 285);
            this.txtDUEmployeePhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDUEmployeePhone.Multiline = true;
            this.txtDUEmployeePhone.Name = "txtDUEmployeePhone";
            this.txtDUEmployeePhone.Size = new System.Drawing.Size(247, 30);
            this.txtDUEmployeePhone.TabIndex = 212;
            // 
            // txtDUEmployeeJob
            // 
            this.txtDUEmployeeJob.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUEmployeeJob.Location = new System.Drawing.Point(236, 404);
            this.txtDUEmployeeJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDUEmployeeJob.Multiline = true;
            this.txtDUEmployeeJob.Name = "txtDUEmployeeJob";
            this.txtDUEmployeeJob.Size = new System.Drawing.Size(247, 32);
            this.txtDUEmployeeJob.TabIndex = 211;
            // 
            // txtDUEmployeeAge
            // 
            this.txtDUEmployeeAge.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUEmployeeAge.Location = new System.Drawing.Point(239, 341);
            this.txtDUEmployeeAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDUEmployeeAge.Multiline = true;
            this.txtDUEmployeeAge.Name = "txtDUEmployeeAge";
            this.txtDUEmployeeAge.Size = new System.Drawing.Size(247, 34);
            this.txtDUEmployeeAge.TabIndex = 209;
            // 
            // EmployeeHireDate
            // 
            this.EmployeeHireDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EmployeeHireDate.Location = new System.Drawing.Point(238, 229);
            this.EmployeeHireDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeeHireDate.Name = "EmployeeHireDate";
            this.EmployeeHireDate.Size = new System.Drawing.Size(247, 34);
            this.EmployeeHireDate.TabIndex = 208;
            this.EmployeeHireDate.Value = new System.DateTime(2023, 5, 19, 5, 6, 0, 0);
            // 
            // radioTraineeFemale
            // 
            this.radioTraineeFemale.AutoSize = true;
            this.radioTraineeFemale.BackColor = System.Drawing.Color.Transparent;
            this.radioTraineeFemale.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTraineeFemale.ForeColor = System.Drawing.Color.White;
            this.radioTraineeFemale.Location = new System.Drawing.Point(356, 176);
            this.radioTraineeFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioTraineeFemale.Name = "radioTraineeFemale";
            this.radioTraineeFemale.Size = new System.Drawing.Size(106, 29);
            this.radioTraineeFemale.TabIndex = 207;
            this.radioTraineeFemale.TabStop = true;
            this.radioTraineeFemale.Text = "Female";
            this.radioTraineeFemale.UseVisualStyleBackColor = false;
            // 
            // radioTraineeMale
            // 
            this.radioTraineeMale.AutoSize = true;
            this.radioTraineeMale.BackColor = System.Drawing.Color.Transparent;
            this.radioTraineeMale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTraineeMale.ForeColor = System.Drawing.Color.White;
            this.radioTraineeMale.Location = new System.Drawing.Point(243, 176);
            this.radioTraineeMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioTraineeMale.Name = "radioTraineeMale";
            this.radioTraineeMale.Size = new System.Drawing.Size(74, 27);
            this.radioTraineeMale.TabIndex = 206;
            this.radioTraineeMale.TabStop = true;
            this.radioTraineeMale.Text = "Male";
            this.radioTraineeMale.UseVisualStyleBackColor = false;
            // 
            // txtDUEmployeeName
            // 
            this.txtDUEmployeeName.BackColor = System.Drawing.Color.White;
            this.txtDUEmployeeName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUEmployeeName.Location = new System.Drawing.Point(239, 115);
            this.txtDUEmployeeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDUEmployeeName.Multiline = true;
            this.txtDUEmployeeName.Name = "txtDUEmployeeName";
            this.txtDUEmployeeName.Size = new System.Drawing.Size(247, 33);
            this.txtDUEmployeeName.TabIndex = 205;
            // 
            // txtDUEmployeeID
            // 
            this.txtDUEmployeeID.BackColor = System.Drawing.Color.White;
            this.txtDUEmployeeID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUEmployeeID.Location = new System.Drawing.Point(239, 58);
            this.txtDUEmployeeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDUEmployeeID.Multiline = true;
            this.txtDUEmployeeID.Name = "txtDUEmployeeID";
            this.txtDUEmployeeID.ReadOnly = true;
            this.txtDUEmployeeID.Size = new System.Drawing.Size(247, 36);
            this.txtDUEmployeeID.TabIndex = 204;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.CausesValidation = false;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Image = ((System.Drawing.Image)(resources.GetObject("lblPhone.Image")));
            this.lblPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhone.Location = new System.Drawing.Point(34, 288);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(146, 27);
            this.lblPhone.TabIndex = 203;
            this.lblPhone.Text = "Phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTraineeClass
            // 
            this.lblTraineeClass.BackColor = System.Drawing.Color.Transparent;
            this.lblTraineeClass.CausesValidation = false;
            this.lblTraineeClass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraineeClass.ForeColor = System.Drawing.Color.White;
            this.lblTraineeClass.Image = ((System.Drawing.Image)(resources.GetObject("lblTraineeClass.Image")));
            this.lblTraineeClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTraineeClass.Location = new System.Drawing.Point(34, 409);
            this.lblTraineeClass.Name = "lblTraineeClass";
            this.lblTraineeClass.Size = new System.Drawing.Size(146, 27);
            this.lblTraineeClass.TabIndex = 202;
            this.lblTraineeClass.Text = "Job Title";
            this.lblTraineeClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAge
            // 
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.CausesValidation = false;
            this.lblAge.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Image = ((System.Drawing.Image)(resources.GetObject("lblAge.Image")));
            this.lblAge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAge.Location = new System.Drawing.Point(31, 345);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(153, 42);
            this.lblAge.TabIndex = 200;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.BackColor = System.Drawing.Color.Transparent;
            this.lblJoinDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinDate.ForeColor = System.Drawing.Color.White;
            this.lblJoinDate.Image = ((System.Drawing.Image)(resources.GetObject("lblJoinDate.Image")));
            this.lblJoinDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJoinDate.Location = new System.Drawing.Point(30, 227);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(157, 27);
            this.lblJoinDate.TabIndex = 199;
            this.lblJoinDate.Text = "Hire Date";
            this.lblJoinDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Image = ((System.Drawing.Image)(resources.GetObject("lblGender.Image")));
            this.lblGender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGender.Location = new System.Drawing.Point(27, 178);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(160, 27);
            this.lblGender.TabIndex = 198;
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblid
            // 
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.CausesValidation = false;
            this.lblid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Image = ((System.Drawing.Image)(resources.GetObject("lblid.Image")));
            this.lblid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblid.Location = new System.Drawing.Point(27, 58);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(120, 27);
            this.lblid.TabIndex = 197;
            this.lblid.Text = "ID";
            this.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Image = ((System.Drawing.Image)(resources.GetObject("lblName.Image")));
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Location = new System.Drawing.Point(27, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(164, 32);
            this.lblName.TabIndex = 196;
            this.lblName.Text = "Full Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grdUpdateEmployee
            // 
            this.grdUpdateEmployee.AutoGenerateColumns = false;
            this.grdUpdateEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdUpdateEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUpdateEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdEmpID,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn});
            this.grdUpdateEmployee.DataSource = this.employeeBindingSource;
            this.grdUpdateEmployee.Location = new System.Drawing.Point(529, 58);
            this.grdUpdateEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.grdUpdateEmployee.Name = "grdUpdateEmployee";
            this.grdUpdateEmployee.RowHeadersWidth = 51;
            this.grdUpdateEmployee.Size = new System.Drawing.Size(842, 354);
            this.grdUpdateEmployee.TabIndex = 195;
            this.grdUpdateEmployee.DoubleClick += new System.EventHandler(this.grdUpdateEmployee_DoubleClick);
            // 
            // grdEmpID
            // 
            this.grdEmpID.DataPropertyName = "ID";
            this.grdEmpID.HeaderText = "ID";
            this.grdEmpID.MinimumWidth = 6;
            this.grdEmpID.Name = "grdEmpID";
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
            // btnDeleteAndUpdate_Back
            // 
            this.btnDeleteAndUpdate_Back.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAndUpdate_Back.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAndUpdate_Back.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAndUpdate_Back.Image")));
            this.btnDeleteAndUpdate_Back.Location = new System.Drawing.Point(76, 660);
            this.btnDeleteAndUpdate_Back.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeleteAndUpdate_Back.Name = "btnDeleteAndUpdate_Back";
            this.btnDeleteAndUpdate_Back.Size = new System.Drawing.Size(159, 52);
            this.btnDeleteAndUpdate_Back.TabIndex = 193;
            this.btnDeleteAndUpdate_Back.Text = "BACK";
            this.btnDeleteAndUpdate_Back.UseVisualStyleBackColor = true;
            this.btnDeleteAndUpdate_Back.Click += new System.EventHandler(this.btnDeleteAndUpdate_Back_Click);
            // 
            // btnDeleteAndUpdate_Reset
            // 
            this.btnDeleteAndUpdate_Reset.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAndUpdate_Reset.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAndUpdate_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAndUpdate_Reset.Image")));
            this.btnDeleteAndUpdate_Reset.Location = new System.Drawing.Point(907, 516);
            this.btnDeleteAndUpdate_Reset.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeleteAndUpdate_Reset.Name = "btnDeleteAndUpdate_Reset";
            this.btnDeleteAndUpdate_Reset.Size = new System.Drawing.Size(159, 52);
            this.btnDeleteAndUpdate_Reset.TabIndex = 192;
            this.btnDeleteAndUpdate_Reset.Text = "Reset";
            this.btnDeleteAndUpdate_Reset.UseVisualStyleBackColor = true;
            this.btnDeleteAndUpdate_Reset.Click += new System.EventHandler(this.btnDeleteAndUpdate_Reset_Click);
            // 
            // btnDeleteAndUpdate_Update
            // 
            this.btnDeleteAndUpdate_Update.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAndUpdate_Update.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAndUpdate_Update.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAndUpdate_Update.Image")));
            this.btnDeleteAndUpdate_Update.Location = new System.Drawing.Point(685, 516);
            this.btnDeleteAndUpdate_Update.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeleteAndUpdate_Update.Name = "btnDeleteAndUpdate_Update";
            this.btnDeleteAndUpdate_Update.Size = new System.Drawing.Size(159, 52);
            this.btnDeleteAndUpdate_Update.TabIndex = 191;
            this.btnDeleteAndUpdate_Update.Text = "Update";
            this.btnDeleteAndUpdate_Update.UseVisualStyleBackColor = true;
            this.btnDeleteAndUpdate_Update.Click += new System.EventHandler(this.btnDeleteAndUpdate_Update_Click);
            // 
            // txtDUEmployeeSalary
            // 
            this.txtDUEmployeeSalary.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUEmployeeSalary.Location = new System.Drawing.Point(236, 467);
            this.txtDUEmployeeSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDUEmployeeSalary.Multiline = true;
            this.txtDUEmployeeSalary.Name = "txtDUEmployeeSalary";
            this.txtDUEmployeeSalary.Size = new System.Drawing.Size(247, 32);
            this.txtDUEmployeeSalary.TabIndex = 234;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(34, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 233;
            this.label1.Text = "Salary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMsg.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.White;
            this.lblErrorMsg.Location = new System.Drawing.Point(532, 624);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(90, 35);
            this.lblErrorMsg.TabIndex = 235;
            this.lblErrorMsg.Text = "label2";
            this.lblErrorMsg.Visible = false;
            // 
            // EmployeeDelete_UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1436, 829);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.txtDUEmployeeSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDUEmployeePhone);
            this.Controls.Add(this.txtDUEmployeeJob);
            this.Controls.Add(this.txtDUEmployeeAge);
            this.Controls.Add(this.EmployeeHireDate);
            this.Controls.Add(this.radioTraineeFemale);
            this.Controls.Add(this.radioTraineeMale);
            this.Controls.Add(this.txtDUEmployeeName);
            this.Controls.Add(this.txtDUEmployeeID);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblTraineeClass);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblJoinDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grdUpdateEmployee);
            this.Controls.Add(this.btnDeleteAndUpdate_Back);
            this.Controls.Add(this.btnDeleteAndUpdate_Reset);
            this.Controls.Add(this.btnDeleteAndUpdate_Update);
            this.Name = "EmployeeDelete_UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDelete_UpdateForm";
            this.Load += new System.EventHandler(this.EmployeeDelete_UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDUEmployeePhone;
        private System.Windows.Forms.TextBox txtDUEmployeeJob;
        private System.Windows.Forms.TextBox txtDUEmployeeAge;
        private System.Windows.Forms.DateTimePicker EmployeeHireDate;
        private System.Windows.Forms.RadioButton radioTraineeFemale;
        private System.Windows.Forms.RadioButton radioTraineeMale;
        private System.Windows.Forms.TextBox txtDUEmployeeName;
        private System.Windows.Forms.TextBox txtDUEmployeeID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTraineeClass;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView grdUpdateEmployee;
        private System.Windows.Forms.Button btnDeleteAndUpdate_Back;
        private System.Windows.Forms.Button btnDeleteAndUpdate_Reset;
        private System.Windows.Forms.Button btnDeleteAndUpdate_Update;
        private System.Windows.Forms.TextBox txtDUEmployeeSalary;
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