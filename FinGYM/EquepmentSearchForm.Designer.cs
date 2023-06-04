namespace FinGYM
{
    partial class EquepmentSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquepmentSearchForm));
            this.Btn_equipment_back_equipment = new System.Windows.Forms.Button();
            this.btnEquRefresh = new System.Windows.Forms.Button();
            this.grdEqupSearch = new System.Windows.Forms.DataGridView();
            this.txtEqupSearch = new System.Windows.Forms.TextBox();
            this.btnEquSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.grdEqupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleivryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdEqupSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_equipment_back_equipment
            // 
            this.Btn_equipment_back_equipment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_equipment_back_equipment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_equipment_back_equipment.ForeColor = System.Drawing.Color.White;
            this.Btn_equipment_back_equipment.Location = new System.Drawing.Point(115, 700);
            this.Btn_equipment_back_equipment.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_equipment_back_equipment.Name = "Btn_equipment_back_equipment";
            this.Btn_equipment_back_equipment.Size = new System.Drawing.Size(197, 52);
            this.Btn_equipment_back_equipment.TabIndex = 19;
            this.Btn_equipment_back_equipment.Text = "Back ";
            this.Btn_equipment_back_equipment.UseVisualStyleBackColor = false;
            this.Btn_equipment_back_equipment.Click += new System.EventHandler(this.Btn_equipment_back_equipment_Click);
            // 
            // btnEquRefresh
            // 
            this.btnEquRefresh.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEquRefresh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquRefresh.ForeColor = System.Drawing.Color.White;
            this.btnEquRefresh.Location = new System.Drawing.Point(899, 128);
            this.btnEquRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquRefresh.Name = "btnEquRefresh";
            this.btnEquRefresh.Size = new System.Drawing.Size(140, 44);
            this.btnEquRefresh.TabIndex = 18;
            this.btnEquRefresh.Text = "Refresh";
            this.btnEquRefresh.UseVisualStyleBackColor = false;
            this.btnEquRefresh.Click += new System.EventHandler(this.btnEquRefresh_Click);
            // 
            // grdEqupSearch
            // 
            this.grdEqupSearch.AutoGenerateColumns = false;
            this.grdEqupSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEqupSearch.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdEqupSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEqupSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdEqupID,
            this.nameDataGridViewTextBoxColumn,
            this.totalNumberDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.deleivryDateDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn});
            this.grdEqupSearch.DataSource = this.equipmentsBindingSource;
            this.grdEqupSearch.Location = new System.Drawing.Point(189, 200);
            this.grdEqupSearch.Margin = new System.Windows.Forms.Padding(4);
            this.grdEqupSearch.Name = "grdEqupSearch";
            this.grdEqupSearch.RowHeadersWidth = 51;
            this.grdEqupSearch.Size = new System.Drawing.Size(971, 446);
            this.grdEqupSearch.TabIndex = 17;
            // 
            // txtEqupSearch
            // 
            this.txtEqupSearch.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEqupSearch.Location = new System.Drawing.Point(445, 64);
            this.txtEqupSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtEqupSearch.Multiline = true;
            this.txtEqupSearch.Name = "txtEqupSearch";
            this.txtEqupSearch.Size = new System.Drawing.Size(425, 44);
            this.txtEqupSearch.TabIndex = 16;
            // 
            // btnEquSearch
            // 
            this.btnEquSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEquSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquSearch.ForeColor = System.Drawing.Color.White;
            this.btnEquSearch.Location = new System.Drawing.Point(899, 64);
            this.btnEquSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquSearch.Name = "btnEquSearch";
            this.btnEquSearch.Size = new System.Drawing.Size(140, 44);
            this.btnEquSearch.TabIndex = 15;
            this.btnEquSearch.Text = "Search";
            this.btnEquSearch.UseVisualStyleBackColor = false;
            this.btnEquSearch.Click += new System.EventHandler(this.btnEquSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 183;
            this.label1.Text = "Equepment ID";
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblErrorMsg.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.White;
            this.lblErrorMsg.Location = new System.Drawing.Point(500, 711);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(83, 33);
            this.lblErrorMsg.TabIndex = 186;
            this.lblErrorMsg.Text = "label2";
            this.lblErrorMsg.Visible = false;
            // 
            // grdEqupID
            // 
            this.grdEqupID.DataPropertyName = "ID";
            this.grdEqupID.HeaderText = "ID";
            this.grdEqupID.MinimumWidth = 6;
            this.grdEqupID.Name = "grdEqupID";
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
            // EquepmentSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1296, 817);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_equipment_back_equipment);
            this.Controls.Add(this.btnEquRefresh);
            this.Controls.Add(this.grdEqupSearch);
            this.Controls.Add(this.txtEqupSearch);
            this.Controls.Add(this.btnEquSearch);
            this.Name = "EquepmentSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EquepmentSearchForm";
            this.Load += new System.EventHandler(this.EquepmentSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEqupSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_equipment_back_equipment;
        private System.Windows.Forms.Button btnEquRefresh;
        private System.Windows.Forms.DataGridView grdEqupSearch;
        private System.Windows.Forms.TextBox txtEqupSearch;
        private System.Windows.Forms.Button btnEquSearch;
        private System.Windows.Forms.Label label1;
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