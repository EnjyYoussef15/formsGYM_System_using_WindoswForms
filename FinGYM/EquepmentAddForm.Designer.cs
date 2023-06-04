namespace FinGYM
{
    partial class EquepmentAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquepmentAddForm));
            this.Btn_equipment_back_equipment = new System.Windows.Forms.Button();
            this.Btn_equipment_reset = new System.Windows.Forms.Button();
            this.Btn_equipment_add = new System.Windows.Forms.Button();
            this.Txt_equipment_price = new System.Windows.Forms.TextBox();
            this.Txt_equipment_delivery = new System.Windows.Forms.DateTimePicker();
            this.Txt_equipment_product_num = new System.Windows.Forms.TextBox();
            this.Txt_equipment_equipmentname = new System.Windows.Forms.TextBox();
            this.Lbl_equipment_price = new System.Windows.Forms.Label();
            this.Lbl_Delivery_date = new System.Windows.Forms.Label();
            this.Lbl_equipment_product_number = new System.Windows.Forms.Label();
            this.Lbl_equipment_equipment_name = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.ComboxEqupMAng = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_equipment_back_equipment
            // 
            this.Btn_equipment_back_equipment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_equipment_back_equipment.Location = new System.Drawing.Point(49, 602);
            this.Btn_equipment_back_equipment.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_equipment_back_equipment.Name = "Btn_equipment_back_equipment";
            this.Btn_equipment_back_equipment.Size = new System.Drawing.Size(216, 49);
            this.Btn_equipment_back_equipment.TabIndex = 26;
            this.Btn_equipment_back_equipment.Text = "Back ";
            this.Btn_equipment_back_equipment.UseVisualStyleBackColor = true;
            this.Btn_equipment_back_equipment.Click += new System.EventHandler(this.Btn_equipment_back_equipment_Click);
            // 
            // Btn_equipment_reset
            // 
            this.Btn_equipment_reset.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_equipment_reset.Location = new System.Drawing.Point(960, 602);
            this.Btn_equipment_reset.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_equipment_reset.Name = "Btn_equipment_reset";
            this.Btn_equipment_reset.Size = new System.Drawing.Size(194, 49);
            this.Btn_equipment_reset.TabIndex = 25;
            this.Btn_equipment_reset.Text = "Reset";
            this.Btn_equipment_reset.UseVisualStyleBackColor = true;
            this.Btn_equipment_reset.Click += new System.EventHandler(this.Btn_equipment_reset_Click);
            // 
            // Btn_equipment_add
            // 
            this.Btn_equipment_add.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_equipment_add.Location = new System.Drawing.Point(539, 602);
            this.Btn_equipment_add.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_equipment_add.Name = "Btn_equipment_add";
            this.Btn_equipment_add.Size = new System.Drawing.Size(179, 49);
            this.Btn_equipment_add.TabIndex = 24;
            this.Btn_equipment_add.Text = "Add";
            this.Btn_equipment_add.UseVisualStyleBackColor = true;
            this.Btn_equipment_add.Click += new System.EventHandler(this.Btn_equipment_add_Click);
            // 
            // Txt_equipment_price
            // 
            this.Txt_equipment_price.BackColor = System.Drawing.Color.Silver;
            this.Txt_equipment_price.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_equipment_price.ForeColor = System.Drawing.Color.Black;
            this.Txt_equipment_price.Location = new System.Drawing.Point(569, 175);
            this.Txt_equipment_price.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_equipment_price.Name = "Txt_equipment_price";
            this.Txt_equipment_price.Size = new System.Drawing.Size(286, 35);
            this.Txt_equipment_price.TabIndex = 23;
            // 
            // Txt_equipment_delivery
            // 
            this.Txt_equipment_delivery.CalendarMonthBackground = System.Drawing.Color.White;
            this.Txt_equipment_delivery.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_equipment_delivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Txt_equipment_delivery.Location = new System.Drawing.Point(572, 365);
            this.Txt_equipment_delivery.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_equipment_delivery.Name = "Txt_equipment_delivery";
            this.Txt_equipment_delivery.Size = new System.Drawing.Size(286, 35);
            this.Txt_equipment_delivery.TabIndex = 22;
            // 
            // Txt_equipment_product_num
            // 
            this.Txt_equipment_product_num.BackColor = System.Drawing.Color.LightGray;
            this.Txt_equipment_product_num.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_equipment_product_num.Location = new System.Drawing.Point(572, 266);
            this.Txt_equipment_product_num.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_equipment_product_num.Name = "Txt_equipment_product_num";
            this.Txt_equipment_product_num.Size = new System.Drawing.Size(280, 35);
            this.Txt_equipment_product_num.TabIndex = 21;
            // 
            // Txt_equipment_equipmentname
            // 
            this.Txt_equipment_equipmentname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_equipment_equipmentname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_equipment_equipmentname.Location = new System.Drawing.Point(572, 90);
            this.Txt_equipment_equipmentname.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_equipment_equipmentname.Name = "Txt_equipment_equipmentname";
            this.Txt_equipment_equipmentname.Size = new System.Drawing.Size(283, 35);
            this.Txt_equipment_equipmentname.TabIndex = 20;
            // 
            // Lbl_equipment_price
            // 
            this.Lbl_equipment_price.AutoSize = true;
            this.Lbl_equipment_price.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_equipment_price.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_equipment_price.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_equipment_price.Location = new System.Drawing.Point(392, 176);
            this.Lbl_equipment_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_equipment_price.Name = "Lbl_equipment_price";
            this.Lbl_equipment_price.Size = new System.Drawing.Size(75, 31);
            this.Lbl_equipment_price.TabIndex = 19;
            this.Lbl_equipment_price.Text = "Price";
            // 
            // Lbl_Delivery_date
            // 
            this.Lbl_Delivery_date.AutoSize = true;
            this.Lbl_Delivery_date.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Delivery_date.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Delivery_date.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Delivery_date.Location = new System.Drawing.Point(318, 365);
            this.Lbl_Delivery_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Delivery_date.Name = "Lbl_Delivery_date";
            this.Lbl_Delivery_date.Size = new System.Drawing.Size(170, 31);
            this.Lbl_Delivery_date.TabIndex = 18;
            this.Lbl_Delivery_date.Text = "Delivery date";
            // 
            // Lbl_equipment_product_number
            // 
            this.Lbl_equipment_product_number.AutoSize = true;
            this.Lbl_equipment_product_number.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_equipment_product_number.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_equipment_product_number.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_equipment_product_number.Location = new System.Drawing.Point(323, 267);
            this.Lbl_equipment_product_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_equipment_product_number.Name = "Lbl_equipment_product_number";
            this.Lbl_equipment_product_number.Size = new System.Drawing.Size(206, 31);
            this.Lbl_equipment_product_number.TabIndex = 17;
            this.Lbl_equipment_product_number.Text = "Product number";
            // 
            // Lbl_equipment_equipment_name
            // 
            this.Lbl_equipment_equipment_name.AutoSize = true;
            this.Lbl_equipment_equipment_name.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_equipment_equipment_name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_equipment_equipment_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_equipment_equipment_name.Location = new System.Drawing.Point(318, 91);
            this.Lbl_equipment_equipment_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_equipment_equipment_name.Name = "Lbl_equipment_equipment_name";
            this.Lbl_equipment_equipment_name.Size = new System.Drawing.Size(218, 31);
            this.Lbl_equipment_equipment_name.TabIndex = 16;
            this.Lbl_equipment_equipment_name.Text = "Equipment Name";
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMsg.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.White;
            this.lblErrorMsg.Location = new System.Drawing.Point(467, 515);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(90, 35);
            this.lblErrorMsg.TabIndex = 234;
            this.lblErrorMsg.Text = "label2";
            this.lblErrorMsg.Visible = false;
            // 
            // ComboxEqupMAng
            // 
            this.ComboxEqupMAng.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboxEqupMAng.FormattingEnabled = true;
            this.ComboxEqupMAng.Location = new System.Drawing.Point(569, 440);
            this.ComboxEqupMAng.Name = "ComboxEqupMAng";
            this.ComboxEqupMAng.Size = new System.Drawing.Size(289, 34);
            this.ComboxEqupMAng.TabIndex = 237;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(323, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 34);
            this.label2.TabIndex = 236;
            this.label2.Text = "Manger Name";
            // 
            // EquepmentAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1251, 746);
            this.Controls.Add(this.ComboxEqupMAng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.Btn_equipment_back_equipment);
            this.Controls.Add(this.Btn_equipment_reset);
            this.Controls.Add(this.Btn_equipment_add);
            this.Controls.Add(this.Txt_equipment_price);
            this.Controls.Add(this.Txt_equipment_delivery);
            this.Controls.Add(this.Txt_equipment_product_num);
            this.Controls.Add(this.Txt_equipment_equipmentname);
            this.Controls.Add(this.Lbl_equipment_price);
            this.Controls.Add(this.Lbl_Delivery_date);
            this.Controls.Add(this.Lbl_equipment_product_number);
            this.Controls.Add(this.Lbl_equipment_equipment_name);
            this.Name = "EquepmentAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EquepmentAddForm";
            this.Load += new System.EventHandler(this.EquepmentAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_equipment_back_equipment;
        private System.Windows.Forms.Button Btn_equipment_reset;
        private System.Windows.Forms.Button Btn_equipment_add;
        private System.Windows.Forms.TextBox Txt_equipment_price;
        private System.Windows.Forms.DateTimePicker Txt_equipment_delivery;
        private System.Windows.Forms.TextBox Txt_equipment_product_num;
        private System.Windows.Forms.TextBox Txt_equipment_equipmentname;
        private System.Windows.Forms.Label Lbl_equipment_price;
        private System.Windows.Forms.Label Lbl_Delivery_date;
        private System.Windows.Forms.Label Lbl_equipment_product_number;
        private System.Windows.Forms.Label Lbl_equipment_equipment_name;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.ComboBox ComboxEqupMAng;
        private System.Windows.Forms.Label label2;
    }
}