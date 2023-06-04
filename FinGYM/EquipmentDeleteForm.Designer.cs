namespace FinGYM
{
    partial class EquipmentDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentDeleteForm));
            this.grdDeleteEquipment = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEquipmentDelete = new System.Windows.Forms.TextBox();
            this.btnDeleteEquipment = new System.Windows.Forms.Button();
            this.btnBask = new System.Windows.Forms.Button();
            this.grdEqupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleivryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblErrorMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeleteEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDeleteEquipment
            // 
            this.grdDeleteEquipment.AutoGenerateColumns = false;
            this.grdDeleteEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDeleteEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeleteEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdEqupID,
            this.nameDataGridViewTextBoxColumn,
            this.totalNumberDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.deleivryDateDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn});
            this.grdDeleteEquipment.DataSource = this.equipmentsBindingSource;
            this.grdDeleteEquipment.Location = new System.Drawing.Point(103, 226);
            this.grdDeleteEquipment.Name = "grdDeleteEquipment";
            this.grdDeleteEquipment.RowHeadersWidth = 51;
            this.grdDeleteEquipment.RowTemplate.Height = 24;
            this.grdDeleteEquipment.Size = new System.Drawing.Size(1006, 313);
            this.grdDeleteEquipment.TabIndex = 183;
            this.grdDeleteEquipment.DoubleClick += new System.EventHandler(this.grdDeleteEquipment_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 182;
            this.label1.Text = "Equepment ID";
            // 
            // txtEquipmentDelete
            // 
            this.txtEquipmentDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentDelete.Location = new System.Drawing.Point(411, 127);
            this.txtEquipmentDelete.Multiline = true;
            this.txtEquipmentDelete.Name = "txtEquipmentDelete";
            this.txtEquipmentDelete.Size = new System.Drawing.Size(355, 51);
            this.txtEquipmentDelete.TabIndex = 181;
            // 
            // btnDeleteEquipment
            // 
            this.btnDeleteEquipment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeleteEquipment.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEquipment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEquipment.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEquipment.Image")));
            this.btnDeleteEquipment.Location = new System.Drawing.Point(804, 127);
            this.btnDeleteEquipment.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeleteEquipment.Name = "btnDeleteEquipment";
            this.btnDeleteEquipment.Size = new System.Drawing.Size(159, 51);
            this.btnDeleteEquipment.TabIndex = 180;
            this.btnDeleteEquipment.Text = "Delete";
            this.btnDeleteEquipment.UseVisualStyleBackColor = false;
            this.btnDeleteEquipment.Click += new System.EventHandler(this.btnDeleteEquipment_Click);
            // 
            // btnBask
            // 
            this.btnBask.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBask.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBask.ForeColor = System.Drawing.Color.White;
            this.btnBask.Image = ((System.Drawing.Image)(resources.GetObject("btnBask.Image")));
            this.btnBask.Location = new System.Drawing.Point(82, 599);
            this.btnBask.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBask.Name = "btnBask";
            this.btnBask.Size = new System.Drawing.Size(159, 52);
            this.btnBask.TabIndex = 179;
            this.btnBask.Text = "BACK";
            this.btnBask.UseVisualStyleBackColor = false;
            this.btnBask.Click += new System.EventHandler(this.btnBask_Click);
            // 
            // grdEqupID
            // 
            this.grdEqupID.DataPropertyName = "ID";
            this.grdEqupID.HeaderText = "ID";
            this.grdEqupID.MinimumWidth = 6;
            this.grdEqupID.Name = "grdEqupID";
            this.grdEqupID.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // totalNumberDataGridViewTextBoxColumn
            // 
            this.totalNumberDataGridViewTextBoxColumn.DataPropertyName = "totalNumber";
            this.totalNumberDataGridViewTextBoxColumn.HeaderText = "totalNumber";
            this.totalNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalNumberDataGridViewTextBoxColumn.Name = "totalNumberDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deleivryDateDataGridViewTextBoxColumn
            // 
            this.deleivryDateDataGridViewTextBoxColumn.DataPropertyName = "DeleivryDate";
            this.deleivryDateDataGridViewTextBoxColumn.HeaderText = "DeleivryDate";
            this.deleivryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deleivryDateDataGridViewTextBoxColumn.Name = "deleivryDateDataGridViewTextBoxColumn";
            // 
            // managerDataGridViewTextBoxColumn
            // 
            this.managerDataGridViewTextBoxColumn.DataPropertyName = "manager";
            this.managerDataGridViewTextBoxColumn.HeaderText = "manager";
            this.managerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.managerDataGridViewTextBoxColumn.Name = "managerDataGridViewTextBoxColumn";
            this.managerDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipmentsBindingSource
            // 
            this.equipmentsBindingSource.DataSource = typeof(FinGYM.Equipments);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblErrorMsg.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.White;
            this.lblErrorMsg.Location = new System.Drawing.Point(539, 599);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(83, 33);
            this.lblErrorMsg.TabIndex = 187;
            this.lblErrorMsg.Text = "label2";
            this.lblErrorMsg.Visible = false;
            // 
            // EquipmentDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1226, 703);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.grdDeleteEquipment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEquipmentDelete);
            this.Controls.Add(this.btnDeleteEquipment);
            this.Controls.Add(this.btnBask);
            this.Name = "EquipmentDeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EquipmentDeleteForm";
            this.Load += new System.EventHandler(this.EquipmentDeleteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDeleteEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDeleteEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEquipmentDelete;
        private System.Windows.Forms.Button btnDeleteEquipment;
        private System.Windows.Forms.Button btnBask;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdEqupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleivryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource equipmentsBindingSource;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}