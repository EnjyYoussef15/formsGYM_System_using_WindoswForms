namespace FinGYM
{
    partial class ClassAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassAddForm));
            this.txtClassNme = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.btnUpdateClassBack = new System.Windows.Forms.Button();
            this.btnClassAdd = new System.Windows.Forms.Button();
            this.btnAddClassReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboxClassMAng = new System.Windows.Forms.ComboBox();
            this.ErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtClassNme
            // 
            this.txtClassNme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClassNme.BackColor = System.Drawing.SystemColors.Info;
            this.txtClassNme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassNme.Location = new System.Drawing.Point(684, 149);
            this.txtClassNme.Multiline = true;
            this.txtClassNme.Name = "txtClassNme";
            this.txtClassNme.Size = new System.Drawing.Size(328, 44);
            this.txtClassNme.TabIndex = 31;
            // 
            // lblClassName
            // 
            this.lblClassName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClassName.AutoSize = true;
            this.lblClassName.BackColor = System.Drawing.Color.Transparent;
            this.lblClassName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.White;
            this.lblClassName.Location = new System.Drawing.Point(462, 149);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(156, 34);
            this.lblClassName.TabIndex = 26;
            this.lblClassName.Text = "Class Name";
            // 
            // btnUpdateClassBack
            // 
            this.btnUpdateClassBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateClassBack.BackColor = System.Drawing.Color.Khaki;
            this.btnUpdateClassBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClassBack.Location = new System.Drawing.Point(133, 535);
            this.btnUpdateClassBack.Name = "btnUpdateClassBack";
            this.btnUpdateClassBack.Size = new System.Drawing.Size(148, 51);
            this.btnUpdateClassBack.TabIndex = 36;
            this.btnUpdateClassBack.Text = "Back";
            this.btnUpdateClassBack.UseVisualStyleBackColor = false;
            this.btnUpdateClassBack.Click += new System.EventHandler(this.btnUpdateClassBack_Click);
            // 
            // btnClassAdd
            // 
            this.btnClassAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClassAdd.BackColor = System.Drawing.Color.Khaki;
            this.btnClassAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassAdd.ForeColor = System.Drawing.Color.Black;
            this.btnClassAdd.Location = new System.Drawing.Point(501, 338);
            this.btnClassAdd.Name = "btnClassAdd";
            this.btnClassAdd.Size = new System.Drawing.Size(148, 51);
            this.btnClassAdd.TabIndex = 34;
            this.btnClassAdd.Text = "Add";
            this.btnClassAdd.UseVisualStyleBackColor = false;
            this.btnClassAdd.Click += new System.EventHandler(this.btnClassAdd_Click);
            // 
            // btnAddClassReset
            // 
            this.btnAddClassReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddClassReset.BackColor = System.Drawing.Color.Khaki;
            this.btnAddClassReset.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClassReset.ForeColor = System.Drawing.Color.Black;
            this.btnAddClassReset.Location = new System.Drawing.Point(714, 338);
            this.btnAddClassReset.Name = "btnAddClassReset";
            this.btnAddClassReset.Size = new System.Drawing.Size(148, 51);
            this.btnAddClassReset.TabIndex = 35;
            this.btnAddClassReset.Text = "Reset";
            this.btnAddClassReset.UseVisualStyleBackColor = false;
            this.btnAddClassReset.Click += new System.EventHandler(this.btnAddClassReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(329, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 49);
            this.label1.TabIndex = 37;
            this.label1.Text = "Add  NEW Class To Fitness GYM";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(462, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 34);
            this.label2.TabIndex = 38;
            this.label2.Text = "Manger Name";
            // 
            // ComboxClassMAng
            // 
            this.ComboxClassMAng.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboxClassMAng.FormattingEnabled = true;
            this.ComboxClassMAng.Location = new System.Drawing.Point(684, 249);
            this.ComboxClassMAng.Name = "ComboxClassMAng";
            this.ComboxClassMAng.Size = new System.Drawing.Size(328, 34);
            this.ComboxClassMAng.TabIndex = 40;
            // 
            // ErrorMsg
            // 
            this.ErrorMsg.AutoSize = true;
            this.ErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.ErrorMsg.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsg.ForeColor = System.Drawing.Color.Khaki;
            this.ErrorMsg.Location = new System.Drawing.Point(367, 483);
            this.ErrorMsg.Name = "ErrorMsg";
            this.ErrorMsg.Size = new System.Drawing.Size(83, 33);
            this.ErrorMsg.TabIndex = 41;
            this.ErrorMsg.Text = "label3";
            this.ErrorMsg.Visible = false;
            // 
            // ClassAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 633);
            this.Controls.Add(this.ErrorMsg);
            this.Controls.Add(this.ComboxClassMAng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateClassBack);
            this.Controls.Add(this.btnAddClassReset);
            this.Controls.Add(this.btnClassAdd);
            this.Controls.Add(this.txtClassNme);
            this.Controls.Add(this.lblClassName);
            this.Name = "ClassAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassAddForm";
            this.Load += new System.EventHandler(this.ClassAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtClassNme;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Button btnUpdateClassBack;
        private System.Windows.Forms.Button btnClassAdd;
        private System.Windows.Forms.Button btnAddClassReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboxClassMAng;
        private System.Windows.Forms.Label ErrorMsg;
    }
}