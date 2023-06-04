namespace FinGYM
{
    partial class CoachAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoachAddForm));
            this.txtAddCoachPhone = new System.Windows.Forms.TextBox();
            this.txtAddCoachSalary = new System.Windows.Forms.TextBox();
            this.txtAddCoachAge = new System.Windows.Forms.TextBox();
            this.CoachHireDate = new System.Windows.Forms.DateTimePicker();
            this.radioCoachFemale = new System.Windows.Forms.RadioButton();
            this.radioCoachMale = new System.Windows.Forms.RadioButton();
            this.txtAddCoachName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSubscriptionFee = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnTraineeBack = new System.Windows.Forms.Button();
            this.btnTraineeReset = new System.Windows.Forms.Button();
            this.btnTraineeSave = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.comboxCoachMAng = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.comboxCoachClass = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtAddCoachPhone
            // 
            this.txtAddCoachPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCoachPhone.Location = new System.Drawing.Point(550, 270);
            this.txtAddCoachPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddCoachPhone.Multiline = true;
            this.txtAddCoachPhone.Name = "txtAddCoachPhone";
            this.txtAddCoachPhone.Size = new System.Drawing.Size(247, 30);
            this.txtAddCoachPhone.TabIndex = 209;
            // 
            // txtAddCoachSalary
            // 
            this.txtAddCoachSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCoachSalary.Location = new System.Drawing.Point(551, 387);
            this.txtAddCoachSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddCoachSalary.Multiline = true;
            this.txtAddCoachSalary.Name = "txtAddCoachSalary";
            this.txtAddCoachSalary.Size = new System.Drawing.Size(246, 32);
            this.txtAddCoachSalary.TabIndex = 207;
            // 
            // txtAddCoachAge
            // 
            this.txtAddCoachAge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCoachAge.Location = new System.Drawing.Point(551, 206);
            this.txtAddCoachAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddCoachAge.Multiline = true;
            this.txtAddCoachAge.Name = "txtAddCoachAge";
            this.txtAddCoachAge.Size = new System.Drawing.Size(247, 34);
            this.txtAddCoachAge.TabIndex = 206;
            // 
            // CoachHireDate
            // 
            this.CoachHireDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CoachHireDate.Location = new System.Drawing.Point(550, 331);
            this.CoachHireDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CoachHireDate.Name = "CoachHireDate";
            this.CoachHireDate.Size = new System.Drawing.Size(247, 30);
            this.CoachHireDate.TabIndex = 205;
            this.CoachHireDate.Value = new System.DateTime(2023, 5, 19, 5, 6, 0, 0);
            // 
            // radioCoachFemale
            // 
            this.radioCoachFemale.AutoSize = true;
            this.radioCoachFemale.BackColor = System.Drawing.Color.Transparent;
            this.radioCoachFemale.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCoachFemale.ForeColor = System.Drawing.Color.White;
            this.radioCoachFemale.Location = new System.Drawing.Point(670, 150);
            this.radioCoachFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioCoachFemale.Name = "radioCoachFemale";
            this.radioCoachFemale.Size = new System.Drawing.Size(108, 30);
            this.radioCoachFemale.TabIndex = 204;
            this.radioCoachFemale.TabStop = true;
            this.radioCoachFemale.Text = "Female";
            this.radioCoachFemale.UseVisualStyleBackColor = false;
            // 
            // radioCoachMale
            // 
            this.radioCoachMale.AutoSize = true;
            this.radioCoachMale.BackColor = System.Drawing.Color.Transparent;
            this.radioCoachMale.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCoachMale.ForeColor = System.Drawing.Color.White;
            this.radioCoachMale.Location = new System.Drawing.Point(557, 150);
            this.radioCoachMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioCoachMale.Name = "radioCoachMale";
            this.radioCoachMale.Size = new System.Drawing.Size(86, 30);
            this.radioCoachMale.TabIndex = 203;
            this.radioCoachMale.TabStop = true;
            this.radioCoachMale.Text = "Male";
            this.radioCoachMale.UseVisualStyleBackColor = false;
            // 
            // txtAddCoachName
            // 
            this.txtAddCoachName.BackColor = System.Drawing.Color.White;
            this.txtAddCoachName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCoachName.Location = new System.Drawing.Point(553, 89);
            this.txtAddCoachName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddCoachName.Multiline = true;
            this.txtAddCoachName.Name = "txtAddCoachName";
            this.txtAddCoachName.Size = new System.Drawing.Size(247, 33);
            this.txtAddCoachName.TabIndex = 202;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.CausesValidation = false;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Image = ((System.Drawing.Image)(resources.GetObject("lblPhone.Image")));
            this.lblPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhone.Location = new System.Drawing.Point(338, 273);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(146, 27);
            this.lblPhone.TabIndex = 200;
            this.lblPhone.Text = "Phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubscriptionFee
            // 
            this.lblSubscriptionFee.BackColor = System.Drawing.Color.Transparent;
            this.lblSubscriptionFee.CausesValidation = false;
            this.lblSubscriptionFee.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubscriptionFee.ForeColor = System.Drawing.Color.White;
            this.lblSubscriptionFee.Image = ((System.Drawing.Image)(resources.GetObject("lblSubscriptionFee.Image")));
            this.lblSubscriptionFee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSubscriptionFee.Location = new System.Drawing.Point(338, 392);
            this.lblSubscriptionFee.Name = "lblSubscriptionFee";
            this.lblSubscriptionFee.Size = new System.Drawing.Size(157, 27);
            this.lblSubscriptionFee.TabIndex = 198;
            this.lblSubscriptionFee.Text = "Salary";
            this.lblSubscriptionFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAge
            // 
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.CausesValidation = false;
            this.lblAge.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Image = ((System.Drawing.Image)(resources.GetObject("lblAge.Image")));
            this.lblAge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAge.Location = new System.Drawing.Point(341, 198);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(153, 42);
            this.lblAge.TabIndex = 197;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.BackColor = System.Drawing.Color.Transparent;
            this.lblJoinDate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinDate.ForeColor = System.Drawing.Color.White;
            this.lblJoinDate.Image = ((System.Drawing.Image)(resources.GetObject("lblJoinDate.Image")));
            this.lblJoinDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJoinDate.Location = new System.Drawing.Point(334, 333);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(157, 27);
            this.lblJoinDate.TabIndex = 196;
            this.lblJoinDate.Text = "Hire Date";
            this.lblJoinDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Image = ((System.Drawing.Image)(resources.GetObject("lblGender.Image")));
            this.lblGender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGender.Location = new System.Drawing.Point(331, 152);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(160, 27);
            this.lblGender.TabIndex = 195;
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Image = ((System.Drawing.Image)(resources.GetObject("lblName.Image")));
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Location = new System.Drawing.Point(331, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(164, 32);
            this.lblName.TabIndex = 193;
            this.lblName.Text = "Full Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTraineeBack
            // 
            this.btnTraineeBack.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraineeBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTraineeBack.Image = ((System.Drawing.Image)(resources.GetObject("btnTraineeBack.Image")));
            this.btnTraineeBack.Location = new System.Drawing.Point(222, 638);
            this.btnTraineeBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTraineeBack.Name = "btnTraineeBack";
            this.btnTraineeBack.Size = new System.Drawing.Size(162, 43);
            this.btnTraineeBack.TabIndex = 214;
            this.btnTraineeBack.Text = "BACK";
            this.btnTraineeBack.UseVisualStyleBackColor = true;
            this.btnTraineeBack.Click += new System.EventHandler(this.btnTraineeBack_Click);
            // 
            // btnTraineeReset
            // 
            this.btnTraineeReset.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraineeReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTraineeReset.Image = ((System.Drawing.Image)(resources.GetObject("btnTraineeReset.Image")));
            this.btnTraineeReset.Location = new System.Drawing.Point(924, 636);
            this.btnTraineeReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTraineeReset.Name = "btnTraineeReset";
            this.btnTraineeReset.Size = new System.Drawing.Size(162, 43);
            this.btnTraineeReset.TabIndex = 213;
            this.btnTraineeReset.Text = "Reset";
            this.btnTraineeReset.UseVisualStyleBackColor = true;
            this.btnTraineeReset.Click += new System.EventHandler(this.btnTraineeReset_Click);
            // 
            // btnTraineeSave
            // 
            this.btnTraineeSave.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraineeSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTraineeSave.Image = ((System.Drawing.Image)(resources.GetObject("btnTraineeSave.Image")));
            this.btnTraineeSave.Location = new System.Drawing.Point(581, 636);
            this.btnTraineeSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTraineeSave.Name = "btnTraineeSave";
            this.btnTraineeSave.Size = new System.Drawing.Size(172, 47);
            this.btnTraineeSave.TabIndex = 212;
            this.btnTraineeSave.Text = "ADD";
            this.btnTraineeSave.UseVisualStyleBackColor = true;
            this.btnTraineeSave.Click += new System.EventHandler(this.btnTraineeSave_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMsg.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.White;
            this.lblErrorMsg.Location = new System.Drawing.Point(471, 595);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(90, 35);
            this.lblErrorMsg.TabIndex = 234;
            this.lblErrorMsg.Text = "label2";
            this.lblErrorMsg.Visible = false;
            // 
            // comboxCoachMAng
            // 
            this.comboxCoachMAng.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxCoachMAng.FormattingEnabled = true;
            this.comboxCoachMAng.Location = new System.Drawing.Point(547, 525);
            this.comboxCoachMAng.Name = "comboxCoachMAng";
            this.comboxCoachMAng.Size = new System.Drawing.Size(250, 34);
            this.comboxCoachMAng.TabIndex = 238;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(330, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 34);
            this.label2.TabIndex = 237;
            this.label2.Text = "Manger Name";
            // 
            // lblClassName
            // 
            this.lblClassName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClassName.AutoSize = true;
            this.lblClassName.BackColor = System.Drawing.Color.Transparent;
            this.lblClassName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.White;
            this.lblClassName.Location = new System.Drawing.Point(328, 453);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(156, 34);
            this.lblClassName.TabIndex = 235;
            this.lblClassName.Text = "Class Name";
            // 
            // comboxCoachClass
            // 
            this.comboxCoachClass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxCoachClass.FormattingEnabled = true;
            this.comboxCoachClass.Location = new System.Drawing.Point(547, 457);
            this.comboxCoachClass.Name = "comboxCoachClass";
            this.comboxCoachClass.Size = new System.Drawing.Size(250, 34);
            this.comboxCoachClass.TabIndex = 239;
            // 
            // CoachAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1238, 775);
            this.Controls.Add(this.comboxCoachClass);
            this.Controls.Add(this.comboxCoachMAng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.btnTraineeBack);
            this.Controls.Add(this.btnTraineeReset);
            this.Controls.Add(this.btnTraineeSave);
            this.Controls.Add(this.txtAddCoachPhone);
            this.Controls.Add(this.txtAddCoachSalary);
            this.Controls.Add(this.txtAddCoachAge);
            this.Controls.Add(this.CoachHireDate);
            this.Controls.Add(this.radioCoachFemale);
            this.Controls.Add(this.radioCoachMale);
            this.Controls.Add(this.txtAddCoachName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSubscriptionFee);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblJoinDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Name = "CoachAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoachAddForm";
            this.Load += new System.EventHandler(this.CoachAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddCoachPhone;
        private System.Windows.Forms.TextBox txtAddCoachSalary;
        private System.Windows.Forms.TextBox txtAddCoachAge;
        private System.Windows.Forms.DateTimePicker CoachHireDate;
        private System.Windows.Forms.RadioButton radioCoachFemale;
        private System.Windows.Forms.RadioButton radioCoachMale;
        private System.Windows.Forms.TextBox txtAddCoachName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSubscriptionFee;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnTraineeBack;
        private System.Windows.Forms.Button btnTraineeReset;
        private System.Windows.Forms.Button btnTraineeSave;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.ComboBox comboxCoachMAng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.ComboBox comboxCoachClass;
    }
}