namespace FinGYM
{
    partial class CoachDelete_UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoachDelete_UpdateForm));
            this.grdCoachUpdate = new System.Windows.Forms.DataGridView();
            this.grdCoachID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mangerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteAndUpdate_Back = new System.Windows.Forms.Button();
            this.btnDeleteAndUpdate_Reset = new System.Windows.Forms.Button();
            this.btnDeleteAndUpdate_Update = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTraineeClass = new System.Windows.Forms.Label();
            this.lblSubscriptionFee = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDUCoachPhone = new System.Windows.Forms.TextBox();
            this.ttxtDUCoachSalry = new System.Windows.Forms.TextBox();
            this.txtDUCoachAge = new System.Windows.Forms.TextBox();
            this.CoachHireDate = new System.Windows.Forms.DateTimePicker();
            this.radCoachFemale = new System.Windows.Forms.RadioButton();
            this.radCoachMale = new System.Windows.Forms.RadioButton();
            this.txtDUCoachName = new System.Windows.Forms.TextBox();
            this.txtDUCoachID = new System.Windows.Forms.TextBox();
            this.comboxCoachClass = new System.Windows.Forms.ComboBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCoachUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCoachUpdate
            // 
            this.grdCoachUpdate.AutoGenerateColumns = false;
            this.grdCoachUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCoachUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCoachUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdCoachID,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.classIdDataGridViewTextBoxColumn,
            this.classsDataGridViewTextBoxColumn,
            this.classNameDataGridViewTextBoxColumn,
            this.mangerDataGridViewTextBoxColumn});
            this.grdCoachUpdate.DataSource = this.coachBindingSource;
            this.grdCoachUpdate.Location = new System.Drawing.Point(582, 93);
            this.grdCoachUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.grdCoachUpdate.Name = "grdCoachUpdate";
            this.grdCoachUpdate.RowHeadersWidth = 51;
            this.grdCoachUpdate.Size = new System.Drawing.Size(907, 354);
            this.grdCoachUpdate.TabIndex = 170;
            this.grdCoachUpdate.DoubleClick += new System.EventHandler(this.grdCoachUpdate_DoubleClick);
            // 
            // grdCoachID
            // 
            this.grdCoachID.DataPropertyName = "ID";
            this.grdCoachID.HeaderText = "ID";
            this.grdCoachID.MinimumWidth = 6;
            this.grdCoachID.Name = "grdCoachID";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
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
            // classIdDataGridViewTextBoxColumn
            // 
            this.classIdDataGridViewTextBoxColumn.DataPropertyName = "classId";
            this.classIdDataGridViewTextBoxColumn.HeaderText = "classId";
            this.classIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classIdDataGridViewTextBoxColumn.Name = "classIdDataGridViewTextBoxColumn";
            this.classIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // classsDataGridViewTextBoxColumn
            // 
            this.classsDataGridViewTextBoxColumn.DataPropertyName = "classs";
            this.classsDataGridViewTextBoxColumn.HeaderText = "classs";
            this.classsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classsDataGridViewTextBoxColumn.Name = "classsDataGridViewTextBoxColumn";
            this.classsDataGridViewTextBoxColumn.Visible = false;
            // 
            // classNameDataGridViewTextBoxColumn
            // 
            this.classNameDataGridViewTextBoxColumn.DataPropertyName = "ClassName";
            this.classNameDataGridViewTextBoxColumn.HeaderText = "ClassName";
            this.classNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classNameDataGridViewTextBoxColumn.Name = "classNameDataGridViewTextBoxColumn";
            this.classNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mangerDataGridViewTextBoxColumn
            // 
            this.mangerDataGridViewTextBoxColumn.DataPropertyName = "manger";
            this.mangerDataGridViewTextBoxColumn.HeaderText = "manger";
            this.mangerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mangerDataGridViewTextBoxColumn.Name = "mangerDataGridViewTextBoxColumn";
            this.mangerDataGridViewTextBoxColumn.Visible = false;
            // 
            // coachBindingSource
            // 
            this.coachBindingSource.DataSource = typeof(FinGYM.Coach);
            // 
            // btnDeleteAndUpdate_Back
            // 
            this.btnDeleteAndUpdate_Back.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAndUpdate_Back.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAndUpdate_Back.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAndUpdate_Back.Image")));
            this.btnDeleteAndUpdate_Back.Location = new System.Drawing.Point(86, 719);
            this.btnDeleteAndUpdate_Back.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeleteAndUpdate_Back.Name = "btnDeleteAndUpdate_Back";
            this.btnDeleteAndUpdate_Back.Size = new System.Drawing.Size(159, 52);
            this.btnDeleteAndUpdate_Back.TabIndex = 168;
            this.btnDeleteAndUpdate_Back.Text = "BACK";
            this.btnDeleteAndUpdate_Back.UseVisualStyleBackColor = true;
            this.btnDeleteAndUpdate_Back.Click += new System.EventHandler(this.btnDeleteAndUpdate_Back_Click);
            // 
            // btnDeleteAndUpdate_Reset
            // 
            this.btnDeleteAndUpdate_Reset.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAndUpdate_Reset.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAndUpdate_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAndUpdate_Reset.Image")));
            this.btnDeleteAndUpdate_Reset.Location = new System.Drawing.Point(970, 542);
            this.btnDeleteAndUpdate_Reset.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeleteAndUpdate_Reset.Name = "btnDeleteAndUpdate_Reset";
            this.btnDeleteAndUpdate_Reset.Size = new System.Drawing.Size(159, 52);
            this.btnDeleteAndUpdate_Reset.TabIndex = 167;
            this.btnDeleteAndUpdate_Reset.Text = "Reset";
            this.btnDeleteAndUpdate_Reset.UseVisualStyleBackColor = true;
            this.btnDeleteAndUpdate_Reset.Click += new System.EventHandler(this.btnDeleteAndUpdate_Reset_Click);
            // 
            // btnDeleteAndUpdate_Update
            // 
            this.btnDeleteAndUpdate_Update.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAndUpdate_Update.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAndUpdate_Update.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAndUpdate_Update.Image")));
            this.btnDeleteAndUpdate_Update.Location = new System.Drawing.Point(690, 542);
            this.btnDeleteAndUpdate_Update.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeleteAndUpdate_Update.Name = "btnDeleteAndUpdate_Update";
            this.btnDeleteAndUpdate_Update.Size = new System.Drawing.Size(159, 52);
            this.btnDeleteAndUpdate_Update.TabIndex = 164;
            this.btnDeleteAndUpdate_Update.Text = "Update";
            this.btnDeleteAndUpdate_Update.UseVisualStyleBackColor = true;
            this.btnDeleteAndUpdate_Update.Click += new System.EventHandler(this.btnDeleteAndUpdate_Update_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.CausesValidation = false;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Image = ((System.Drawing.Image)(resources.GetObject("lblPhone.Image")));
            this.lblPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhone.Location = new System.Drawing.Point(79, 299);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(146, 27);
            this.lblPhone.TabIndex = 181;
            this.lblPhone.Text = "Phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTraineeClass
            // 
            this.lblTraineeClass.BackColor = System.Drawing.Color.Transparent;
            this.lblTraineeClass.CausesValidation = false;
            this.lblTraineeClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraineeClass.ForeColor = System.Drawing.Color.White;
            this.lblTraineeClass.Image = ((System.Drawing.Image)(resources.GetObject("lblTraineeClass.Image")));
            this.lblTraineeClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTraineeClass.Location = new System.Drawing.Point(79, 489);
            this.lblTraineeClass.Name = "lblTraineeClass";
            this.lblTraineeClass.Size = new System.Drawing.Size(146, 27);
            this.lblTraineeClass.TabIndex = 180;
            this.lblTraineeClass.Text = "Class";
            this.lblTraineeClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubscriptionFee
            // 
            this.lblSubscriptionFee.BackColor = System.Drawing.Color.Transparent;
            this.lblSubscriptionFee.CausesValidation = false;
            this.lblSubscriptionFee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubscriptionFee.ForeColor = System.Drawing.Color.White;
            this.lblSubscriptionFee.Image = ((System.Drawing.Image)(resources.GetObject("lblSubscriptionFee.Image")));
            this.lblSubscriptionFee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSubscriptionFee.Location = new System.Drawing.Point(79, 422);
            this.lblSubscriptionFee.Name = "lblSubscriptionFee";
            this.lblSubscriptionFee.Size = new System.Drawing.Size(157, 27);
            this.lblSubscriptionFee.TabIndex = 179;
            this.lblSubscriptionFee.Text = "Salary";
            this.lblSubscriptionFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAge
            // 
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.CausesValidation = false;
            this.lblAge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Image = ((System.Drawing.Image)(resources.GetObject("lblAge.Image")));
            this.lblAge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAge.Location = new System.Drawing.Point(76, 356);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(153, 42);
            this.lblAge.TabIndex = 178;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.BackColor = System.Drawing.Color.Transparent;
            this.lblJoinDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinDate.ForeColor = System.Drawing.Color.White;
            this.lblJoinDate.Image = ((System.Drawing.Image)(resources.GetObject("lblJoinDate.Image")));
            this.lblJoinDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJoinDate.Location = new System.Drawing.Point(75, 238);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(157, 27);
            this.lblJoinDate.TabIndex = 176;
            this.lblJoinDate.Text = "Hire Date";
            this.lblJoinDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Image = ((System.Drawing.Image)(resources.GetObject("lblGender.Image")));
            this.lblGender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGender.Location = new System.Drawing.Point(72, 189);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(160, 27);
            this.lblGender.TabIndex = 175;
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblid
            // 
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.CausesValidation = false;
            this.lblid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Image = ((System.Drawing.Image)(resources.GetObject("lblid.Image")));
            this.lblid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblid.Location = new System.Drawing.Point(72, 69);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(120, 27);
            this.lblid.TabIndex = 174;
            this.lblid.Text = "ID";
            this.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Image = ((System.Drawing.Image)(resources.GetObject("lblName.Image")));
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Location = new System.Drawing.Point(72, 127);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(164, 32);
            this.lblName.TabIndex = 173;
            this.lblName.Text = "Full Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDUCoachPhone
            // 
            this.txtDUCoachPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUCoachPhone.Location = new System.Drawing.Point(281, 296);
            this.txtDUCoachPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDUCoachPhone.Multiline = true;
            this.txtDUCoachPhone.Name = "txtDUCoachPhone";
            this.txtDUCoachPhone.Size = new System.Drawing.Size(247, 30);
            this.txtDUCoachPhone.TabIndex = 190;
            // 
            // ttxtDUCoachSalry
            // 
            this.ttxtDUCoachSalry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttxtDUCoachSalry.Location = new System.Drawing.Point(282, 417);
            this.ttxtDUCoachSalry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ttxtDUCoachSalry.Multiline = true;
            this.ttxtDUCoachSalry.Name = "ttxtDUCoachSalry";
            this.ttxtDUCoachSalry.Size = new System.Drawing.Size(246, 32);
            this.ttxtDUCoachSalry.TabIndex = 188;
            // 
            // txtDUCoachAge
            // 
            this.txtDUCoachAge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUCoachAge.Location = new System.Drawing.Point(284, 352);
            this.txtDUCoachAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDUCoachAge.Multiline = true;
            this.txtDUCoachAge.Name = "txtDUCoachAge";
            this.txtDUCoachAge.Size = new System.Drawing.Size(247, 34);
            this.txtDUCoachAge.TabIndex = 187;
            // 
            // CoachHireDate
            // 
            this.CoachHireDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CoachHireDate.Location = new System.Drawing.Point(283, 240);
            this.CoachHireDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CoachHireDate.Name = "CoachHireDate";
            this.CoachHireDate.Size = new System.Drawing.Size(247, 30);
            this.CoachHireDate.TabIndex = 186;
            this.CoachHireDate.Value = new System.DateTime(2023, 5, 19, 5, 6, 0, 0);
            // 
            // radCoachFemale
            // 
            this.radCoachFemale.AutoSize = true;
            this.radCoachFemale.BackColor = System.Drawing.Color.Transparent;
            this.radCoachFemale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCoachFemale.ForeColor = System.Drawing.Color.White;
            this.radCoachFemale.Location = new System.Drawing.Point(401, 187);
            this.radCoachFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radCoachFemale.Name = "radCoachFemale";
            this.radCoachFemale.Size = new System.Drawing.Size(92, 27);
            this.radCoachFemale.TabIndex = 185;
            this.radCoachFemale.TabStop = true;
            this.radCoachFemale.Text = "Female";
            this.radCoachFemale.UseVisualStyleBackColor = false;
            // 
            // radCoachMale
            // 
            this.radCoachMale.AutoSize = true;
            this.radCoachMale.BackColor = System.Drawing.Color.Transparent;
            this.radCoachMale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCoachMale.ForeColor = System.Drawing.Color.White;
            this.radCoachMale.Location = new System.Drawing.Point(288, 187);
            this.radCoachMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radCoachMale.Name = "radCoachMale";
            this.radCoachMale.Size = new System.Drawing.Size(74, 27);
            this.radCoachMale.TabIndex = 184;
            this.radCoachMale.TabStop = true;
            this.radCoachMale.Text = "Male";
            this.radCoachMale.UseVisualStyleBackColor = false;
            // 
            // txtDUCoachName
            // 
            this.txtDUCoachName.BackColor = System.Drawing.Color.White;
            this.txtDUCoachName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUCoachName.Location = new System.Drawing.Point(284, 126);
            this.txtDUCoachName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDUCoachName.Multiline = true;
            this.txtDUCoachName.Name = "txtDUCoachName";
            this.txtDUCoachName.Size = new System.Drawing.Size(247, 33);
            this.txtDUCoachName.TabIndex = 183;
            // 
            // txtDUCoachID
            // 
            this.txtDUCoachID.BackColor = System.Drawing.Color.White;
            this.txtDUCoachID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUCoachID.Location = new System.Drawing.Point(284, 69);
            this.txtDUCoachID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDUCoachID.Multiline = true;
            this.txtDUCoachID.Name = "txtDUCoachID";
            this.txtDUCoachID.ReadOnly = true;
            this.txtDUCoachID.Size = new System.Drawing.Size(247, 36);
            this.txtDUCoachID.TabIndex = 182;
            // 
            // comboxCoachClass
            // 
            this.comboxCoachClass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxCoachClass.FormattingEnabled = true;
            this.comboxCoachClass.Location = new System.Drawing.Point(280, 489);
            this.comboxCoachClass.Name = "comboxCoachClass";
            this.comboxCoachClass.Size = new System.Drawing.Size(250, 34);
            this.comboxCoachClass.TabIndex = 241;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMsg.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.White;
            this.lblErrorMsg.Location = new System.Drawing.Point(637, 657);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(90, 35);
            this.lblErrorMsg.TabIndex = 242;
            this.lblErrorMsg.Text = "label2";
            this.lblErrorMsg.Visible = false;
            // 
            // CoachDelete_UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1572, 860);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.comboxCoachClass);
            this.Controls.Add(this.txtDUCoachPhone);
            this.Controls.Add(this.ttxtDUCoachSalry);
            this.Controls.Add(this.txtDUCoachAge);
            this.Controls.Add(this.CoachHireDate);
            this.Controls.Add(this.radCoachFemale);
            this.Controls.Add(this.radCoachMale);
            this.Controls.Add(this.txtDUCoachName);
            this.Controls.Add(this.txtDUCoachID);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblTraineeClass);
            this.Controls.Add(this.lblSubscriptionFee);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblJoinDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grdCoachUpdate);
            this.Controls.Add(this.btnDeleteAndUpdate_Back);
            this.Controls.Add(this.btnDeleteAndUpdate_Reset);
            this.Controls.Add(this.btnDeleteAndUpdate_Update);
            this.Name = "CoachDelete_UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoachDelete_UpdateForm";
            this.Load += new System.EventHandler(this.CoachDelete_UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCoachUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdCoachUpdate;
        private System.Windows.Forms.Button btnDeleteAndUpdate_Back;
        private System.Windows.Forms.Button btnDeleteAndUpdate_Reset;
        private System.Windows.Forms.Button btnDeleteAndUpdate_Update;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTraineeClass;
        private System.Windows.Forms.Label lblSubscriptionFee;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDUCoachPhone;
        private System.Windows.Forms.TextBox ttxtDUCoachSalry;
        private System.Windows.Forms.TextBox txtDUCoachAge;
        private System.Windows.Forms.DateTimePicker CoachHireDate;
        private System.Windows.Forms.RadioButton radCoachFemale;
        private System.Windows.Forms.RadioButton radCoachMale;
        private System.Windows.Forms.TextBox txtDUCoachName;
        private System.Windows.Forms.TextBox txtDUCoachID;
        private System.Windows.Forms.ComboBox comboxCoachClass;
        private System.Windows.Forms.BindingSource coachBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCoachID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}