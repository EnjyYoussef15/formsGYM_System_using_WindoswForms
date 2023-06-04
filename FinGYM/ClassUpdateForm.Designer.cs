namespace FinGYM
{
    partial class ClassUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassUpdateForm));
            this.btnUpdateClassReset = new System.Windows.Forms.Button();
            this.btnUpdateClassSave = new System.Windows.Forms.Button();
            this.grdClassUpdate = new System.Windows.Forms.DataGridView();
            this.btnUpdateClassBack = new System.Windows.Forms.Button();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtClassNme = new System.Windows.Forms.TextBox();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mangerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ErrorMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdClassUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateClassReset
            // 
            this.btnUpdateClassReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateClassReset.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateClassReset.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClassReset.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateClassReset.Location = new System.Drawing.Point(898, 454);
            this.btnUpdateClassReset.Name = "btnUpdateClassReset";
            this.btnUpdateClassReset.Size = new System.Drawing.Size(148, 51);
            this.btnUpdateClassReset.TabIndex = 18;
            this.btnUpdateClassReset.Text = "Delete";
            this.btnUpdateClassReset.UseVisualStyleBackColor = false;
            this.btnUpdateClassReset.Click += new System.EventHandler(this.btnUpdateClassReset_Click);
            // 
            // btnUpdateClassSave
            // 
            this.btnUpdateClassSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateClassSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateClassSave.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClassSave.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateClassSave.Location = new System.Drawing.Point(685, 454);
            this.btnUpdateClassSave.Name = "btnUpdateClassSave";
            this.btnUpdateClassSave.Size = new System.Drawing.Size(148, 51);
            this.btnUpdateClassSave.TabIndex = 17;
            this.btnUpdateClassSave.Text = "Update";
            this.btnUpdateClassSave.UseVisualStyleBackColor = false;
            this.btnUpdateClassSave.Click += new System.EventHandler(this.btnUpdateClassSave_Click);
            // 
            // grdClassUpdate
            // 
            this.grdClassUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdClassUpdate.AutoGenerateColumns = false;
            this.grdClassUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdClassUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClassUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdClassID,
            this.nameDataGridViewTextBoxColumn,
            this.mangerDataGridViewTextBoxColumn});
            this.grdClassUpdate.DataSource = this.classesBindingSource;
            this.grdClassUpdate.Location = new System.Drawing.Point(593, 108);
            this.grdClassUpdate.Name = "grdClassUpdate";
            this.grdClassUpdate.RowHeadersWidth = 51;
            this.grdClassUpdate.RowTemplate.Height = 24;
            this.grdClassUpdate.Size = new System.Drawing.Size(585, 262);
            this.grdClassUpdate.TabIndex = 21;
            this.grdClassUpdate.DoubleClick += new System.EventHandler(this.grdClassUpdate_DoubleClick);
            // 
            // btnUpdateClassBack
            // 
            this.btnUpdateClassBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateClassBack.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateClassBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClassBack.Location = new System.Drawing.Point(99, 551);
            this.btnUpdateClassBack.Name = "btnUpdateClassBack";
            this.btnUpdateClassBack.Size = new System.Drawing.Size(148, 51);
            this.btnUpdateClassBack.TabIndex = 22;
            this.btnUpdateClassBack.Text = "Back";
            this.btnUpdateClassBack.UseVisualStyleBackColor = false;
            this.btnUpdateClassBack.Click += new System.EventHandler(this.btnUpdateClassBack_Click);
            // 
            // lblClassName
            // 
            this.lblClassName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClassName.AutoSize = true;
            this.lblClassName.BackColor = System.Drawing.Color.Transparent;
            this.lblClassName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.Black;
            this.lblClassName.Location = new System.Drawing.Point(94, 281);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(153, 32);
            this.lblClassName.TabIndex = 14;
            this.lblClassName.Text = "Class Name";
            // 
            // txtClassNme
            // 
            this.txtClassNme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClassNme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassNme.Location = new System.Drawing.Point(298, 281);
            this.txtClassNme.Multiline = true;
            this.txtClassNme.Name = "txtClassNme";
            this.txtClassNme.Size = new System.Drawing.Size(203, 35);
            this.txtClassNme.TabIndex = 23;
            // 
            // txtClassID
            // 
            this.txtClassID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClassID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassID.Location = new System.Drawing.Point(298, 211);
            this.txtClassID.Multiline = true;
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.ReadOnly = true;
            this.txtClassID.Size = new System.Drawing.Size(203, 35);
            this.txtClassID.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(94, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Class ID";
            // 
            // grdClassID
            // 
            this.grdClassID.DataPropertyName = "ID";
            this.grdClassID.HeaderText = "ID";
            this.grdClassID.MinimumWidth = 6;
            this.grdClassID.Name = "grdClassID";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mangerDataGridViewTextBoxColumn
            // 
            this.mangerDataGridViewTextBoxColumn.DataPropertyName = "manger";
            this.mangerDataGridViewTextBoxColumn.HeaderText = "manger";
            this.mangerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mangerDataGridViewTextBoxColumn.Name = "mangerDataGridViewTextBoxColumn";
            this.mangerDataGridViewTextBoxColumn.Visible = false;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataSource = typeof(FinGYM.Classes);
            // 
            // ErrorMsg
            // 
            this.ErrorMsg.AutoSize = true;
            this.ErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.ErrorMsg.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsg.ForeColor = System.Drawing.Color.Khaki;
            this.ErrorMsg.Location = new System.Drawing.Point(635, 559);
            this.ErrorMsg.Name = "ErrorMsg";
            this.ErrorMsg.Size = new System.Drawing.Size(83, 33);
            this.ErrorMsg.TabIndex = 42;
            this.ErrorMsg.Text = "label3";
            this.ErrorMsg.Visible = false;
            // 
            // ClassUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1245, 639);
            this.Controls.Add(this.ErrorMsg);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClassNme);
            this.Controls.Add(this.btnUpdateClassBack);
            this.Controls.Add(this.grdClassUpdate);
            this.Controls.Add(this.btnUpdateClassReset);
            this.Controls.Add(this.btnUpdateClassSave);
            this.Controls.Add(this.lblClassName);
            this.Name = "ClassUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassUpdateForm";
            this.Load += new System.EventHandler(this.ClassUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdClassUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateClassReset;
        private System.Windows.Forms.Button btnUpdateClassSave;
        private System.Windows.Forms.DataGridView grdClassUpdate;
        private System.Windows.Forms.Button btnUpdateClassBack;
        //private System.Windows.Forms.DataGridViewTextBoxColumn grdClassCoach;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClassNme;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private System.Windows.Forms.Label ErrorMsg;
    }
}