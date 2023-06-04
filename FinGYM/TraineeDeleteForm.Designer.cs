namespace FinGYM
{
    partial class TraineeDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraineeDeleteForm));
            this.btnBask = new System.Windows.Forms.Button();
            this.btnDeleteTrainee = new System.Windows.Forms.Button();
            this.txtTraineeDelete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdDeleteTrainee = new System.Windows.Forms.DataGridView();
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
            this.lblErrorMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeleteTrainee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBask
            // 
            this.btnBask.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBask.ForeColor = System.Drawing.Color.White;
            this.btnBask.Image = ((System.Drawing.Image)(resources.GetObject("btnBask.Image")));
            this.btnBask.Location = new System.Drawing.Point(52, 626);
            this.btnBask.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBask.Name = "btnBask";
            this.btnBask.Size = new System.Drawing.Size(159, 52);
            this.btnBask.TabIndex = 174;
            this.btnBask.Text = "BACK";
            this.btnBask.UseVisualStyleBackColor = true;
            this.btnBask.Click += new System.EventHandler(this.btnBask_Click);
            // 
            // btnDeleteTrainee
            // 
            this.btnDeleteTrainee.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTrainee.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTrainee.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTrainee.Image")));
            this.btnDeleteTrainee.Location = new System.Drawing.Point(803, 128);
            this.btnDeleteTrainee.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeleteTrainee.Name = "btnDeleteTrainee";
            this.btnDeleteTrainee.Size = new System.Drawing.Size(159, 51);
            this.btnDeleteTrainee.TabIndex = 175;
            this.btnDeleteTrainee.Text = "Delete";
            this.btnDeleteTrainee.UseVisualStyleBackColor = true;
            this.btnDeleteTrainee.Click += new System.EventHandler(this.btnDeleteTrainee_Click);
            // 
            // txtTraineeDelete
            // 
            this.txtTraineeDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraineeDelete.Location = new System.Drawing.Point(410, 128);
            this.txtTraineeDelete.Multiline = true;
            this.txtTraineeDelete.Name = "txtTraineeDelete";
            this.txtTraineeDelete.Size = new System.Drawing.Size(355, 51);
            this.txtTraineeDelete.TabIndex = 176;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 33);
            this.label1.TabIndex = 177;
            this.label1.Text = "Trainee ID";
            // 
            // grdDeleteTrainee
            // 
            this.grdDeleteTrainee.AutoGenerateColumns = false;
            this.grdDeleteTrainee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDeleteTrainee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeleteTrainee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.grdDeleteTrainee.DataSource = this.traineeBindingSource;
            this.grdDeleteTrainee.Location = new System.Drawing.Point(52, 227);
            this.grdDeleteTrainee.Name = "grdDeleteTrainee";
            this.grdDeleteTrainee.RowHeadersWidth = 51;
            this.grdDeleteTrainee.RowTemplate.Height = 24;
            this.grdDeleteTrainee.Size = new System.Drawing.Size(1110, 373);
            this.grdDeleteTrainee.TabIndex = 178;
            this.grdDeleteTrainee.DoubleClick += new System.EventHandler(this.grdDeleteTrainee_DoubleClick);
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
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblErrorMsg.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(299, 661);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(83, 33);
            this.lblErrorMsg.TabIndex = 185;
            this.lblErrorMsg.Text = "label2";
            this.lblErrorMsg.Visible = false;
            // 
            // TraineeDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1226, 703);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.grdDeleteTrainee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTraineeDelete);
            this.Controls.Add(this.btnDeleteTrainee);
            this.Controls.Add(this.btnBask);
            this.Name = "TraineeDeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraineeDeleteForm";
            this.Load += new System.EventHandler(this.TraineeDeleteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDeleteTrainee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBask;
        private System.Windows.Forms.Button btnDeleteTrainee;
        private System.Windows.Forms.TextBox txtTraineeDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdDeleteTrainee;
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