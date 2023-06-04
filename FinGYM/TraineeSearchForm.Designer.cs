namespace FinGYM
{
    partial class TraineeSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraineeSearchForm));
            this.btnSearchRe = new System.Windows.Forms.Button();
            this.btnSearchBack = new System.Windows.Forms.Button();
            this.grdTraineeSearch = new System.Windows.Forms.DataGridView();
            this.grdTraineeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startJoinDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endJoinDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtractionFeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mangerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch_Search = new System.Windows.Forms.Button();
            this.txtSearch_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdTraineeSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchRe
            // 
            this.btnSearchRe.BackColor = System.Drawing.Color.Beige;
            this.btnSearchRe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRe.ForeColor = System.Drawing.Color.White;
            this.btnSearchRe.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchRe.Image")));
            this.btnSearchRe.Location = new System.Drawing.Point(933, 162);
            this.btnSearchRe.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchRe.Name = "btnSearchRe";
            this.btnSearchRe.Size = new System.Drawing.Size(193, 44);
            this.btnSearchRe.TabIndex = 14;
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
            this.btnSearchBack.Location = new System.Drawing.Point(80, 572);
            this.btnSearchBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchBack.Name = "btnSearchBack";
            this.btnSearchBack.Size = new System.Drawing.Size(193, 44);
            this.btnSearchBack.TabIndex = 13;
            this.btnSearchBack.Text = "Back";
            this.btnSearchBack.UseVisualStyleBackColor = false;
            this.btnSearchBack.Click += new System.EventHandler(this.btnSearchBack_Click);
            // 
            // grdTraineeSearch
            // 
            this.grdTraineeSearch.AutoGenerateColumns = false;
            this.grdTraineeSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTraineeSearch.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdTraineeSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTraineeSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdTraineeID,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.startJoinDateDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.endJoinDateDataGridViewTextBoxColumn,
            this.subtractionFeesDataGridViewTextBoxColumn,
            this.coachIDDataGridViewTextBoxColumn,
            this.coachDataGridViewTextBoxColumn,
            this.mangerDataGridViewTextBoxColumn,
            this.clasIDDataGridViewTextBoxColumn,
            this.clasDataGridViewTextBoxColumn});
            this.grdTraineeSearch.DataSource = this.traineeBindingSource;
            this.grdTraineeSearch.Location = new System.Drawing.Point(150, 223);
            this.grdTraineeSearch.Margin = new System.Windows.Forms.Padding(4);
            this.grdTraineeSearch.Name = "grdTraineeSearch";
            this.grdTraineeSearch.RowHeadersWidth = 51;
            this.grdTraineeSearch.RowTemplate.ReadOnly = true;
            this.grdTraineeSearch.Size = new System.Drawing.Size(1043, 322);
            this.grdTraineeSearch.TabIndex = 12;
            // 
            // grdTraineeID
            // 
            this.grdTraineeID.DataPropertyName = "ID";
            this.grdTraineeID.HeaderText = "ID";
            this.grdTraineeID.MinimumWidth = 6;
            this.grdTraineeID.Name = "grdTraineeID";
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
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
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
            // startJoinDateDataGridViewTextBoxColumn
            // 
            this.startJoinDateDataGridViewTextBoxColumn.DataPropertyName = "StartJoinDate";
            this.startJoinDateDataGridViewTextBoxColumn.HeaderText = "StartJoinDate";
            this.startJoinDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startJoinDateDataGridViewTextBoxColumn.Name = "startJoinDateDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // endJoinDateDataGridViewTextBoxColumn
            // 
            this.endJoinDateDataGridViewTextBoxColumn.DataPropertyName = "EndJoinDate";
            this.endJoinDateDataGridViewTextBoxColumn.HeaderText = "EndJoinDate";
            this.endJoinDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endJoinDateDataGridViewTextBoxColumn.Name = "endJoinDateDataGridViewTextBoxColumn";
            this.endJoinDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subtractionFeesDataGridViewTextBoxColumn
            // 
            this.subtractionFeesDataGridViewTextBoxColumn.DataPropertyName = "SubtractionFees";
            this.subtractionFeesDataGridViewTextBoxColumn.HeaderText = "SubtractionFees";
            this.subtractionFeesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subtractionFeesDataGridViewTextBoxColumn.Name = "subtractionFeesDataGridViewTextBoxColumn";
            // 
            // coachIDDataGridViewTextBoxColumn
            // 
            this.coachIDDataGridViewTextBoxColumn.DataPropertyName = "coachID";
            this.coachIDDataGridViewTextBoxColumn.HeaderText = "coachID";
            this.coachIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coachIDDataGridViewTextBoxColumn.Name = "coachIDDataGridViewTextBoxColumn";
            // 
            // coachDataGridViewTextBoxColumn
            // 
            this.coachDataGridViewTextBoxColumn.DataPropertyName = "coach";
            this.coachDataGridViewTextBoxColumn.HeaderText = "coach";
            this.coachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coachDataGridViewTextBoxColumn.Name = "coachDataGridViewTextBoxColumn";
            this.coachDataGridViewTextBoxColumn.Visible = false;
            // 
            // mangerDataGridViewTextBoxColumn
            // 
            this.mangerDataGridViewTextBoxColumn.DataPropertyName = "manger";
            this.mangerDataGridViewTextBoxColumn.HeaderText = "manger";
            this.mangerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mangerDataGridViewTextBoxColumn.Name = "mangerDataGridViewTextBoxColumn";
            this.mangerDataGridViewTextBoxColumn.Visible = false;
            // 
            // clasIDDataGridViewTextBoxColumn
            // 
            this.clasIDDataGridViewTextBoxColumn.DataPropertyName = "clasID";
            this.clasIDDataGridViewTextBoxColumn.HeaderText = "clasID";
            this.clasIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clasIDDataGridViewTextBoxColumn.Name = "clasIDDataGridViewTextBoxColumn";
            // 
            // clasDataGridViewTextBoxColumn
            // 
            this.clasDataGridViewTextBoxColumn.DataPropertyName = "clas";
            this.clasDataGridViewTextBoxColumn.HeaderText = "clas";
            this.clasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clasDataGridViewTextBoxColumn.Name = "clasDataGridViewTextBoxColumn";
            this.clasDataGridViewTextBoxColumn.Visible = false;
            // 
            // traineeBindingSource
            // 
            this.traineeBindingSource.DataSource = typeof(FinGYM.Trainee);
            // 
            // btnSearch_Search
            // 
            this.btnSearch_Search.BackColor = System.Drawing.Color.Beige;
            this.btnSearch_Search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch_Search.ForeColor = System.Drawing.Color.White;
            this.btnSearch_Search.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch_Search.Image")));
            this.btnSearch_Search.Location = new System.Drawing.Point(933, 110);
            this.btnSearch_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch_Search.Name = "btnSearch_Search";
            this.btnSearch_Search.Size = new System.Drawing.Size(193, 44);
            this.btnSearch_Search.TabIndex = 11;
            this.btnSearch_Search.Text = "Search";
            this.btnSearch_Search.UseVisualStyleBackColor = false;
            this.btnSearch_Search.Click += new System.EventHandler(this.btnSearch_Search_Click);
            // 
            // txtSearch_Search
            // 
            this.txtSearch_Search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_Search.Location = new System.Drawing.Point(392, 116);
            this.txtSearch_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch_Search.Multiline = true;
            this.txtSearch_Search.Name = "txtSearch_Search";
            this.txtSearch_Search.Size = new System.Drawing.Size(533, 46);
            this.txtSearch_Search.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Trainee ID";
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblErrorMsg.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(516, 616);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(83, 33);
            this.lblErrorMsg.TabIndex = 186;
            this.lblErrorMsg.Text = "label2";
            this.lblErrorMsg.Visible = false;
            // 
            // TraineeSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1396, 792);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchRe);
            this.Controls.Add(this.btnSearchBack);
            this.Controls.Add(this.grdTraineeSearch);
            this.Controls.Add(this.btnSearch_Search);
            this.Controls.Add(this.txtSearch_Search);
            this.Name = "TraineeSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraineeSearchForm";
            this.Load += new System.EventHandler(this.TraineeSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTraineeSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchRe;
        private System.Windows.Forms.Button btnSearchBack;
        private System.Windows.Forms.DataGridView grdTraineeSearch;
        private System.Windows.Forms.Button btnSearch_Search;
        private System.Windows.Forms.TextBox txtSearch_Search;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn coachNAmeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn classNAmeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdTraineeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startJoinDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endJoinDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtractionFeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource traineeBindingSource;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}