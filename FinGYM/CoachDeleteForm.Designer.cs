namespace FinGYM
{
    partial class CoachDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoachDeleteForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteCoach = new System.Windows.Forms.Button();
            this.txtDeleteCaoch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdCoachDelete = new System.Windows.Forms.DataGridView();
            this.lblErrorMsg = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdCoachDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(79, 591);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(159, 52);
            this.btnBack.TabIndex = 169;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnDeleteAndUpdate_Back_Click);
            // 
            // btnDeleteCoach
            // 
            this.btnDeleteCoach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCoach.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCoach.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCoach.Image")));
            this.btnDeleteCoach.Location = new System.Drawing.Point(826, 139);
            this.btnDeleteCoach.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeleteCoach.Name = "btnDeleteCoach";
            this.btnDeleteCoach.Size = new System.Drawing.Size(159, 51);
            this.btnDeleteCoach.TabIndex = 170;
            this.btnDeleteCoach.Text = "Delete";
            this.btnDeleteCoach.UseVisualStyleBackColor = true;
            this.btnDeleteCoach.Click += new System.EventHandler(this.btnDeleteAndUpdate_Delete_Click);
            // 
            // txtDeleteCaoch
            // 
            this.txtDeleteCaoch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteCaoch.Location = new System.Drawing.Point(433, 139);
            this.txtDeleteCaoch.Multiline = true;
            this.txtDeleteCaoch.Name = "txtDeleteCaoch";
            this.txtDeleteCaoch.Size = new System.Drawing.Size(355, 51);
            this.txtDeleteCaoch.TabIndex = 171;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 33);
            this.label1.TabIndex = 172;
            this.label1.Text = "Coach ID";
            // 
            // grdCoachDelete
            // 
            this.grdCoachDelete.AutoGenerateColumns = false;
            this.grdCoachDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCoachDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCoachDelete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.grdCoachDelete.DataSource = this.coachBindingSource;
            this.grdCoachDelete.Location = new System.Drawing.Point(89, 244);
            this.grdCoachDelete.Name = "grdCoachDelete";
            this.grdCoachDelete.RowHeadersWidth = 51;
            this.grdCoachDelete.RowTemplate.Height = 24;
            this.grdCoachDelete.Size = new System.Drawing.Size(1034, 291);
            this.grdCoachDelete.TabIndex = 173;
            this.grdCoachDelete.DoubleClick += new System.EventHandler(this.grdCoachDelete_DoubleClick);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblErrorMsg.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.White;
            this.lblErrorMsg.Location = new System.Drawing.Point(321, 610);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(83, 33);
            this.lblErrorMsg.TabIndex = 185;
            this.lblErrorMsg.Text = "label2";
            this.lblErrorMsg.Visible = false;
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
            this.classNameDataGridViewTextBoxColumn.Visible = false;
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
            // CoachDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1226, 703);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.grdCoachDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeleteCaoch);
            this.Controls.Add(this.btnDeleteCoach);
            this.Controls.Add(this.btnBack);
            this.Name = "CoachDeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoachDeleteForm";
            this.Load += new System.EventHandler(this.CoachDeleteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCoachDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteCoach;
        private System.Windows.Forms.TextBox txtDeleteCaoch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdCoachDelete;
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