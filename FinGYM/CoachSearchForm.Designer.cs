namespace FinGYM
{
    partial class CoachSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoachSearchForm));
            this.btnSearchRe = new System.Windows.Forms.Button();
            this.btnSearchBack = new System.Windows.Forms.Button();
            this.grdCoachSearch = new System.Windows.Forms.DataGridView();
            this.btnCoach_Search = new System.Windows.Forms.Button();
            this.txtCoach_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.coachBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdCoachSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchRe
            // 
            this.btnSearchRe.BackColor = System.Drawing.Color.Beige;
            this.btnSearchRe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRe.ForeColor = System.Drawing.Color.White;
            this.btnSearchRe.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchRe.Image")));
            this.btnSearchRe.Location = new System.Drawing.Point(911, 208);
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
            this.btnSearchBack.Location = new System.Drawing.Point(82, 618);
            this.btnSearchBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchBack.Name = "btnSearchBack";
            this.btnSearchBack.Size = new System.Drawing.Size(193, 44);
            this.btnSearchBack.TabIndex = 18;
            this.btnSearchBack.Text = "Back";
            this.btnSearchBack.UseVisualStyleBackColor = false;
            this.btnSearchBack.Click += new System.EventHandler(this.btnSearchBack_Click);
            // 
            // grdCoachSearch
            // 
            this.grdCoachSearch.AutoGenerateColumns = false;
            this.grdCoachSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCoachSearch.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdCoachSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCoachSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.grdCoachSearch.DataSource = this.coachBindingSource;
            this.grdCoachSearch.Location = new System.Drawing.Point(172, 272);
            this.grdCoachSearch.Margin = new System.Windows.Forms.Padding(4);
            this.grdCoachSearch.Name = "grdCoachSearch";
            this.grdCoachSearch.RowHeadersWidth = 51;
            this.grdCoachSearch.Size = new System.Drawing.Size(946, 302);
            this.grdCoachSearch.TabIndex = 17;
            // 
            // btnCoach_Search
            // 
            this.btnCoach_Search.BackColor = System.Drawing.Color.Beige;
            this.btnCoach_Search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoach_Search.ForeColor = System.Drawing.Color.White;
            this.btnCoach_Search.Image = ((System.Drawing.Image)(resources.GetObject("btnCoach_Search.Image")));
            this.btnCoach_Search.Location = new System.Drawing.Point(911, 145);
            this.btnCoach_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btnCoach_Search.Name = "btnCoach_Search";
            this.btnCoach_Search.Size = new System.Drawing.Size(193, 44);
            this.btnCoach_Search.TabIndex = 16;
            this.btnCoach_Search.Text = "Search";
            this.btnCoach_Search.UseVisualStyleBackColor = false;
            this.btnCoach_Search.Click += new System.EventHandler(this.btnCoach_Search_Click);
            // 
            // txtCoach_Search
            // 
            this.txtCoach_Search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoach_Search.Location = new System.Drawing.Point(359, 145);
            this.txtCoach_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoach_Search.Multiline = true;
            this.txtCoach_Search.Name = "txtCoach_Search";
            this.txtCoach_Search.Size = new System.Drawing.Size(533, 44);
            this.txtCoach_Search.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Coach ID";
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblErrorMsg.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(515, 697);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(83, 33);
            this.lblErrorMsg.TabIndex = 175;
            this.lblErrorMsg.Text = "label2";
            this.lblErrorMsg.Visible = false;
            // 
            // coachBindingSource
            // 
            this.coachBindingSource.DataSource = typeof(FinGYM.Coach);
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
            // CoachSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1288, 845);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchRe);
            this.Controls.Add(this.btnSearchBack);
            this.Controls.Add(this.grdCoachSearch);
            this.Controls.Add(this.btnCoach_Search);
            this.Controls.Add(this.txtCoach_Search);
            this.Name = "CoachSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoachSearchForm";
            this.Load += new System.EventHandler(this.CoachSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCoachSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchRe;
        private System.Windows.Forms.Button btnSearchBack;
        private System.Windows.Forms.DataGridView grdCoachSearch;
        private System.Windows.Forms.Button btnCoach_Search;
        private System.Windows.Forms.TextBox txtCoach_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorMsg;
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
        private System.Windows.Forms.BindingSource coachBindingSource;
    }
}