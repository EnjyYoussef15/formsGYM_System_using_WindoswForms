namespace FinGYM
{
    partial class EquepmentDelete_UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquepmentDelete_UpdateForm));
            this.Btn_equipment_Back = new System.Windows.Forms.Button();
            this.Txt_equipment_total_price = new System.Windows.Forms.TextBox();
            this.Txt_equipment_price = new System.Windows.Forms.TextBox();
            this.Txt_equipment_delivery = new System.Windows.Forms.DateTimePicker();
            this.Txt_equipment_product_num = new System.Windows.Forms.TextBox();
            this.Txt_equipment_equipmentname = new System.Windows.Forms.TextBox();
            this.Lbl_equipment_price = new System.Windows.Forms.Label();
            this.Lbl_Delivery_date = new System.Windows.Forms.Label();
            this.Lbl_equipment_product_number = new System.Windows.Forms.Label();
            this.Lbl_equipment_equipment_name = new System.Windows.Forms.Label();
            this.Lbl_equipment_total_price = new System.Windows.Forms.Label();
            this.Btn_equipment_update = new System.Windows.Forms.Button();
            this.grdEqupUpdate = new System.Windows.Forms.DataGridView();
            this.txtEqupmentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEqupReset = new System.Windows.Forms.Button();
            this.gedEqupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleivryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblErrorMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdEqupUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_equipment_Back
            // 
            this.Btn_equipment_Back.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_equipment_Back.Location = new System.Drawing.Point(130, 628);
            this.Btn_equipment_Back.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_equipment_Back.Name = "Btn_equipment_Back";
            this.Btn_equipment_Back.Size = new System.Drawing.Size(147, 39);
            this.Btn_equipment_Back.TabIndex = 53;
            this.Btn_equipment_Back.Text = "Back";
            this.Btn_equipment_Back.UseVisualStyleBackColor = true;
            this.Btn_equipment_Back.Click += new System.EventHandler(this.Btn_equipment_Back_Click);
            // 
            // Txt_equipment_total_price
            // 
            this.Txt_equipment_total_price.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_equipment_total_price.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_equipment_total_price.Location = new System.Drawing.Point(208, 402);
            this.Txt_equipment_total_price.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_equipment_total_price.Name = "Txt_equipment_total_price";
            this.Txt_equipment_total_price.Size = new System.Drawing.Size(251, 35);
            this.Txt_equipment_total_price.TabIndex = 51;
            // 
            // Txt_equipment_price
            // 
            this.Txt_equipment_price.BackColor = System.Drawing.Color.Silver;
            this.Txt_equipment_price.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_equipment_price.ForeColor = System.Drawing.Color.Black;
            this.Txt_equipment_price.Location = new System.Drawing.Point(208, 321);
            this.Txt_equipment_price.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_equipment_price.Name = "Txt_equipment_price";
            this.Txt_equipment_price.Size = new System.Drawing.Size(251, 35);
            this.Txt_equipment_price.TabIndex = 49;
            // 
            // Txt_equipment_delivery
            // 
            this.Txt_equipment_delivery.CalendarMonthBackground = System.Drawing.Color.White;
            this.Txt_equipment_delivery.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_equipment_delivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Txt_equipment_delivery.Location = new System.Drawing.Point(208, 482);
            this.Txt_equipment_delivery.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_equipment_delivery.Name = "Txt_equipment_delivery";
            this.Txt_equipment_delivery.Size = new System.Drawing.Size(251, 35);
            this.Txt_equipment_delivery.TabIndex = 48;
            // 
            // Txt_equipment_product_num
            // 
            this.Txt_equipment_product_num.BackColor = System.Drawing.Color.LightGray;
            this.Txt_equipment_product_num.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_equipment_product_num.Location = new System.Drawing.Point(208, 234);
            this.Txt_equipment_product_num.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_equipment_product_num.Name = "Txt_equipment_product_num";
            this.Txt_equipment_product_num.Size = new System.Drawing.Size(247, 35);
            this.Txt_equipment_product_num.TabIndex = 47;
            // 
            // Txt_equipment_equipmentname
            // 
            this.Txt_equipment_equipmentname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_equipment_equipmentname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_equipment_equipmentname.Location = new System.Drawing.Point(211, 153);
            this.Txt_equipment_equipmentname.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_equipment_equipmentname.Name = "Txt_equipment_equipmentname";
            this.Txt_equipment_equipmentname.Size = new System.Drawing.Size(248, 35);
            this.Txt_equipment_equipmentname.TabIndex = 46;
            // 
            // Lbl_equipment_price
            // 
            this.Lbl_equipment_price.AutoSize = true;
            this.Lbl_equipment_price.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_equipment_price.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_equipment_price.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_equipment_price.Location = new System.Drawing.Point(30, 321);
            this.Lbl_equipment_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_equipment_price.Name = "Lbl_equipment_price";
            this.Lbl_equipment_price.Size = new System.Drawing.Size(73, 31);
            this.Lbl_equipment_price.TabIndex = 43;
            this.Lbl_equipment_price.Text = "price";
            // 
            // Lbl_Delivery_date
            // 
            this.Lbl_Delivery_date.AutoSize = true;
            this.Lbl_Delivery_date.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Delivery_date.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Delivery_date.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Delivery_date.Location = new System.Drawing.Point(30, 482);
            this.Lbl_Delivery_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Delivery_date.Name = "Lbl_Delivery_date";
            this.Lbl_Delivery_date.Size = new System.Drawing.Size(170, 31);
            this.Lbl_Delivery_date.TabIndex = 42;
            this.Lbl_Delivery_date.Text = "Delivery date";
            // 
            // Lbl_equipment_product_number
            // 
            this.Lbl_equipment_product_number.AutoSize = true;
            this.Lbl_equipment_product_number.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_equipment_product_number.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_equipment_product_number.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_equipment_product_number.Location = new System.Drawing.Point(15, 237);
            this.Lbl_equipment_product_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_equipment_product_number.Name = "Lbl_equipment_product_number";
            this.Lbl_equipment_product_number.Size = new System.Drawing.Size(181, 26);
            this.Lbl_equipment_product_number.TabIndex = 41;
            this.Lbl_equipment_product_number.Text = "Product number";
            // 
            // Lbl_equipment_equipment_name
            // 
            this.Lbl_equipment_equipment_name.AutoSize = true;
            this.Lbl_equipment_equipment_name.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_equipment_equipment_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_equipment_equipment_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_equipment_equipment_name.Location = new System.Drawing.Point(18, 153);
            this.Lbl_equipment_equipment_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_equipment_equipment_name.Name = "Lbl_equipment_equipment_name";
            this.Lbl_equipment_equipment_name.Size = new System.Drawing.Size(186, 26);
            this.Lbl_equipment_equipment_name.TabIndex = 40;
            this.Lbl_equipment_equipment_name.Text = "Equipment name";
            // 
            // Lbl_equipment_total_price
            // 
            this.Lbl_equipment_total_price.AutoSize = true;
            this.Lbl_equipment_total_price.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_equipment_total_price.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_equipment_total_price.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_equipment_total_price.Location = new System.Drawing.Point(30, 402);
            this.Lbl_equipment_total_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_equipment_total_price.Name = "Lbl_equipment_total_price";
            this.Lbl_equipment_total_price.Size = new System.Drawing.Size(134, 31);
            this.Lbl_equipment_total_price.TabIndex = 45;
            this.Lbl_equipment_total_price.Text = "total price";
            // 
            // Btn_equipment_update
            // 
            this.Btn_equipment_update.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_equipment_update.Location = new System.Drawing.Point(783, 447);
            this.Btn_equipment_update.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_equipment_update.Name = "Btn_equipment_update";
            this.Btn_equipment_update.Size = new System.Drawing.Size(147, 39);
            this.Btn_equipment_update.TabIndex = 44;
            this.Btn_equipment_update.Text = "Update";
            this.Btn_equipment_update.UseVisualStyleBackColor = true;
            this.Btn_equipment_update.Click += new System.EventHandler(this.Btn_equipment_update_Click);
            // 
            // grdEqupUpdate
            // 
            this.grdEqupUpdate.AutoGenerateColumns = false;
            this.grdEqupUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEqupUpdate.BackgroundColor = System.Drawing.Color.White;
            this.grdEqupUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEqupUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gedEqupID,
            this.nameDataGridViewTextBoxColumn,
            this.totalNumberDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.deleivryDateDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn});
            this.grdEqupUpdate.DataSource = this.equipmentsBindingSource;
            this.grdEqupUpdate.Location = new System.Drawing.Point(531, 111);
            this.grdEqupUpdate.Name = "grdEqupUpdate";
            this.grdEqupUpdate.RowHeadersWidth = 51;
            this.grdEqupUpdate.RowTemplate.Height = 24;
            this.grdEqupUpdate.Size = new System.Drawing.Size(768, 311);
            this.grdEqupUpdate.TabIndex = 54;
            this.grdEqupUpdate.DoubleClick += new System.EventHandler(this.grdEqupUpdate_DoubleClick);
            // 
            // txtEqupmentID
            // 
            this.txtEqupmentID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEqupmentID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEqupmentID.Location = new System.Drawing.Point(211, 71);
            this.txtEqupmentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEqupmentID.Name = "txtEqupmentID";
            this.txtEqupmentID.ReadOnly = true;
            this.txtEqupmentID.Size = new System.Drawing.Size(248, 35);
            this.txtEqupmentID.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 55;
            this.label1.Text = "Equipment ID";
            // 
            // btnEqupReset
            // 
            this.btnEqupReset.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqupReset.Location = new System.Drawing.Point(1016, 447);
            this.btnEqupReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnEqupReset.Name = "btnEqupReset";
            this.btnEqupReset.Size = new System.Drawing.Size(147, 39);
            this.btnEqupReset.TabIndex = 57;
            this.btnEqupReset.Text = "Reset";
            this.btnEqupReset.UseVisualStyleBackColor = true;
            this.btnEqupReset.Click += new System.EventHandler(this.btnEqupReset_Click);
            // 
            // gedEqupID
            // 
            this.gedEqupID.DataPropertyName = "ID";
            this.gedEqupID.HeaderText = "ID";
            this.gedEqupID.MinimumWidth = 6;
            this.gedEqupID.Name = "gedEqupID";
            this.gedEqupID.ReadOnly = true;
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
            this.lblErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMsg.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.White;
            this.lblErrorMsg.Location = new System.Drawing.Point(571, 567);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(90, 35);
            this.lblErrorMsg.TabIndex = 235;
            this.lblErrorMsg.Text = "label2";
            this.lblErrorMsg.Visible = false;
            // 
            // EquepmentDelete_UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1325, 696);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.btnEqupReset);
            this.Controls.Add(this.txtEqupmentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdEqupUpdate);
            this.Controls.Add(this.Btn_equipment_Back);
            this.Controls.Add(this.Txt_equipment_total_price);
            this.Controls.Add(this.Txt_equipment_price);
            this.Controls.Add(this.Txt_equipment_delivery);
            this.Controls.Add(this.Txt_equipment_product_num);
            this.Controls.Add(this.Txt_equipment_equipmentname);
            this.Controls.Add(this.Btn_equipment_update);
            this.Controls.Add(this.Lbl_equipment_price);
            this.Controls.Add(this.Lbl_Delivery_date);
            this.Controls.Add(this.Lbl_equipment_product_number);
            this.Controls.Add(this.Lbl_equipment_equipment_name);
            this.Controls.Add(this.Lbl_equipment_total_price);
            this.Name = "EquepmentDelete_UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EquepmentDelete_UpdateForm";
            this.Load += new System.EventHandler(this.EquepmentDelete_UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEqupUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_equipment_Back;
        private System.Windows.Forms.TextBox Txt_equipment_total_price;
        private System.Windows.Forms.TextBox Txt_equipment_price;
        private System.Windows.Forms.DateTimePicker Txt_equipment_delivery;
        private System.Windows.Forms.TextBox Txt_equipment_product_num;
        private System.Windows.Forms.TextBox Txt_equipment_equipmentname;
        private System.Windows.Forms.Label Lbl_equipment_price;
        private System.Windows.Forms.Label Lbl_Delivery_date;
        private System.Windows.Forms.Label Lbl_equipment_product_number;
        private System.Windows.Forms.Label Lbl_equipment_equipment_name;
        private System.Windows.Forms.Label Lbl_equipment_total_price;
        private System.Windows.Forms.Button Btn_equipment_update;
        private System.Windows.Forms.DataGridView grdEqupUpdate;
        private System.Windows.Forms.TextBox txtEqupmentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEqupReset;
        private System.Windows.Forms.BindingSource equipmentsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn gedEqupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleivryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}