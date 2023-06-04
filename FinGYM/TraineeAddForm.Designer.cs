namespace FinGYM
{
    partial class TraineeAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraineeAddForm));
            this.btnTraineeBack = new System.Windows.Forms.Button();
            this.txtTraineePhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnTraineeReset = new System.Windows.Forms.Button();
            this.btnTraineeSave = new System.Windows.Forms.Button();
            this.txtTraineeSubscriptionFee = new System.Windows.Forms.TextBox();
            this.txtTraineeAge = new System.Windows.Forms.TextBox();
            this.TraineeJoinDate = new System.Windows.Forms.DateTimePicker();
            this.radioTraineeFemale = new System.Windows.Forms.RadioButton();
            this.radioTraineeMale = new System.Windows.Forms.RadioButton();
            this.txtTraineeName = new System.Windows.Forms.TextBox();
            this.lblSubscriptionFee = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtTraineeDuration = new System.Windows.Forms.TextBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.comboxCoachClass = new System.Windows.Forms.ComboBox();
            this.comboxCoachMAng = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.comboxTrainCoach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraineeBack
            // 
            this.btnTraineeBack.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraineeBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTraineeBack.Image = ((System.Drawing.Image)(resources.GetObject("btnTraineeBack.Image")));
            this.btnTraineeBack.Location = new System.Drawing.Point(248, 734);
            this.btnTraineeBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTraineeBack.Name = "btnTraineeBack";
            this.btnTraineeBack.Size = new System.Drawing.Size(161, 43);
            this.btnTraineeBack.TabIndex = 122;
            this.btnTraineeBack.Text = "BACK";
            this.btnTraineeBack.UseVisualStyleBackColor = true;
            this.btnTraineeBack.Click += new System.EventHandler(this.btnTraineeBack_Click);
            // 
            // txtTraineePhone
            // 
            this.txtTraineePhone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraineePhone.Location = new System.Drawing.Point(604, 238);
            this.txtTraineePhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTraineePhone.Name = "txtTraineePhone";
            this.txtTraineePhone.Size = new System.Drawing.Size(247, 34);
            this.txtTraineePhone.TabIndex = 120;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.CausesValidation = false;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Image = ((System.Drawing.Image)(resources.GetObject("lblPhone.Image")));
            this.lblPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhone.Location = new System.Drawing.Point(400, 239);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(146, 27);
            this.lblPhone.TabIndex = 119;
            this.lblPhone.Text = "Phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTraineeReset
            // 
            this.btnTraineeReset.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraineeReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTraineeReset.Image = ((System.Drawing.Image)(resources.GetObject("btnTraineeReset.Image")));
            this.btnTraineeReset.Location = new System.Drawing.Point(950, 732);
            this.btnTraineeReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTraineeReset.Name = "btnTraineeReset";
            this.btnTraineeReset.Size = new System.Drawing.Size(161, 43);
            this.btnTraineeReset.TabIndex = 121;
            this.btnTraineeReset.Text = "Reset";
            this.btnTraineeReset.UseVisualStyleBackColor = true;
            this.btnTraineeReset.Click += new System.EventHandler(this.btnTraineeReset_Click);
            // 
            // btnTraineeSave
            // 
            this.btnTraineeSave.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraineeSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTraineeSave.Image = ((System.Drawing.Image)(resources.GetObject("btnTraineeSave.Image")));
            this.btnTraineeSave.Location = new System.Drawing.Point(607, 732);
            this.btnTraineeSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTraineeSave.Name = "btnTraineeSave";
            this.btnTraineeSave.Size = new System.Drawing.Size(171, 47);
            this.btnTraineeSave.TabIndex = 118;
            this.btnTraineeSave.Text = "ADD";
            this.btnTraineeSave.UseVisualStyleBackColor = true;
            this.btnTraineeSave.Click += new System.EventHandler(this.btnTraineeSave_Click);
            // 
            // txtTraineeSubscriptionFee
            // 
            this.txtTraineeSubscriptionFee.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraineeSubscriptionFee.Location = new System.Drawing.Point(608, 422);
            this.txtTraineeSubscriptionFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTraineeSubscriptionFee.Name = "txtTraineeSubscriptionFee";
            this.txtTraineeSubscriptionFee.Size = new System.Drawing.Size(246, 34);
            this.txtTraineeSubscriptionFee.TabIndex = 115;
            // 
            // txtTraineeAge
            // 
            this.txtTraineeAge.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraineeAge.Location = new System.Drawing.Point(605, 173);
            this.txtTraineeAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTraineeAge.Name = "txtTraineeAge";
            this.txtTraineeAge.Size = new System.Drawing.Size(247, 34);
            this.txtTraineeAge.TabIndex = 114;
            // 
            // TraineeJoinDate
            // 
            this.TraineeJoinDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraineeJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TraineeJoinDate.Location = new System.Drawing.Point(610, 492);
            this.TraineeJoinDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TraineeJoinDate.Name = "TraineeJoinDate";
            this.TraineeJoinDate.Size = new System.Drawing.Size(247, 34);
            this.TraineeJoinDate.TabIndex = 113;
            this.TraineeJoinDate.Value = new System.DateTime(2023, 5, 19, 5, 6, 0, 0);
            // 
            // radioTraineeFemale
            // 
            this.radioTraineeFemale.AutoSize = true;
            this.radioTraineeFemale.BackColor = System.Drawing.Color.Transparent;
            this.radioTraineeFemale.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTraineeFemale.ForeColor = System.Drawing.Color.White;
            this.radioTraineeFemale.Location = new System.Drawing.Point(724, 125);
            this.radioTraineeFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioTraineeFemale.Name = "radioTraineeFemale";
            this.radioTraineeFemale.Size = new System.Drawing.Size(100, 30);
            this.radioTraineeFemale.TabIndex = 112;
            this.radioTraineeFemale.TabStop = true;
            this.radioTraineeFemale.Text = "Female";
            this.radioTraineeFemale.UseVisualStyleBackColor = false;
            // 
            // radioTraineeMale
            // 
            this.radioTraineeMale.AutoSize = true;
            this.radioTraineeMale.BackColor = System.Drawing.Color.Transparent;
            this.radioTraineeMale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTraineeMale.ForeColor = System.Drawing.Color.White;
            this.radioTraineeMale.Location = new System.Drawing.Point(611, 125);
            this.radioTraineeMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioTraineeMale.Name = "radioTraineeMale";
            this.radioTraineeMale.Size = new System.Drawing.Size(74, 27);
            this.radioTraineeMale.TabIndex = 111;
            this.radioTraineeMale.TabStop = true;
            this.radioTraineeMale.Text = "Male";
            this.radioTraineeMale.UseVisualStyleBackColor = false;
            // 
            // txtTraineeName
            // 
            this.txtTraineeName.BackColor = System.Drawing.Color.White;
            this.txtTraineeName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraineeName.Location = new System.Drawing.Point(607, 64);
            this.txtTraineeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTraineeName.Name = "txtTraineeName";
            this.txtTraineeName.Size = new System.Drawing.Size(247, 34);
            this.txtTraineeName.TabIndex = 109;
            // 
            // lblSubscriptionFee
            // 
            this.lblSubscriptionFee.BackColor = System.Drawing.Color.Transparent;
            this.lblSubscriptionFee.CausesValidation = false;
            this.lblSubscriptionFee.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubscriptionFee.ForeColor = System.Drawing.Color.White;
            this.lblSubscriptionFee.Image = ((System.Drawing.Image)(resources.GetObject("lblSubscriptionFee.Image")));
            this.lblSubscriptionFee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSubscriptionFee.Location = new System.Drawing.Point(403, 425);
            this.lblSubscriptionFee.Name = "lblSubscriptionFee";
            this.lblSubscriptionFee.Size = new System.Drawing.Size(157, 27);
            this.lblSubscriptionFee.TabIndex = 107;
            this.lblSubscriptionFee.Text = "Sub fee";
            this.lblSubscriptionFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAge
            // 
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.CausesValidation = false;
            this.lblAge.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Image = ((System.Drawing.Image)(resources.GetObject("lblAge.Image")));
            this.lblAge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAge.Location = new System.Drawing.Point(395, 175);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(153, 42);
            this.lblAge.TabIndex = 105;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEndDate
            // 
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Image = ((System.Drawing.Image)(resources.GetObject("lblEndDate.Image")));
            this.lblEndDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEndDate.Location = new System.Drawing.Point(403, 552);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(157, 43);
            this.lblEndDate.TabIndex = 104;
            this.lblEndDate.Text = "Duration";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEndDate.Click += new System.EventHandler(this.lblEndDate_Click);
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.BackColor = System.Drawing.Color.Transparent;
            this.lblJoinDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinDate.ForeColor = System.Drawing.Color.White;
            this.lblJoinDate.Image = ((System.Drawing.Image)(resources.GetObject("lblJoinDate.Image")));
            this.lblJoinDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJoinDate.Location = new System.Drawing.Point(400, 488);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(157, 27);
            this.lblJoinDate.TabIndex = 103;
            this.lblJoinDate.Text = "Join Date";
            this.lblJoinDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Image = ((System.Drawing.Image)(resources.GetObject("lblGender.Image")));
            this.lblGender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGender.Location = new System.Drawing.Point(393, 125);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(160, 27);
            this.lblGender.TabIndex = 102;
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Image = ((System.Drawing.Image)(resources.GetObject("lblName.Image")));
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Location = new System.Drawing.Point(393, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(164, 32);
            this.lblName.TabIndex = 100;
            this.lblName.Text = "Full Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTraineeDuration
            // 
            this.txtTraineeDuration.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraineeDuration.Location = new System.Drawing.Point(608, 552);
            this.txtTraineeDuration.Multiline = true;
            this.txtTraineeDuration.Name = "txtTraineeDuration";
            this.txtTraineeDuration.Size = new System.Drawing.Size(244, 33);
            this.txtTraineeDuration.TabIndex = 123;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMsg.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.White;
            this.lblErrorMsg.Location = new System.Drawing.Point(503, 681);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(90, 35);
            this.lblErrorMsg.TabIndex = 235;
            this.lblErrorMsg.Text = "label2";
            this.lblErrorMsg.Visible = false;
            // 
            // comboxCoachClass
            // 
            this.comboxCoachClass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxCoachClass.FormattingEnabled = true;
            this.comboxCoachClass.Location = new System.Drawing.Point(604, 299);
            this.comboxCoachClass.Name = "comboxCoachClass";
            this.comboxCoachClass.Size = new System.Drawing.Size(250, 34);
            this.comboxCoachClass.TabIndex = 243;
            // 
            // comboxCoachMAng
            // 
            this.comboxCoachMAng.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxCoachMAng.FormattingEnabled = true;
            this.comboxCoachMAng.Location = new System.Drawing.Point(608, 623);
            this.comboxCoachMAng.Name = "comboxCoachMAng";
            this.comboxCoachMAng.Size = new System.Drawing.Size(250, 34);
            this.comboxCoachMAng.TabIndex = 242;
            this.comboxCoachMAng.SelectedIndexChanged += new System.EventHandler(this.comboxCoachMAng_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(391, 619);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 34);
            this.label2.TabIndex = 241;
            this.label2.Text = "Manger Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblClassName
            // 
            this.lblClassName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClassName.AutoSize = true;
            this.lblClassName.BackColor = System.Drawing.Color.Transparent;
            this.lblClassName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.White;
            this.lblClassName.Location = new System.Drawing.Point(385, 295);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(156, 34);
            this.lblClassName.TabIndex = 240;
            this.lblClassName.Text = "Class Name";
            // 
            // comboxTrainCoach
            // 
            this.comboxTrainCoach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxTrainCoach.FormattingEnabled = true;
            this.comboxTrainCoach.Location = new System.Drawing.Point(607, 363);
            this.comboxTrainCoach.Name = "comboxTrainCoach";
            this.comboxTrainCoach.Size = new System.Drawing.Size(250, 34);
            this.comboxTrainCoach.TabIndex = 245;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(390, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 34);
            this.label1.TabIndex = 244;
            this.label1.Text = "Coach Name";
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataSource = typeof(FinGYM.Classes);
            // 
            // coachBindingSource
            // 
            this.coachBindingSource.DataSource = typeof(FinGYM.Coach);
            // 
            // TraineeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 801);
            this.Controls.Add(this.comboxTrainCoach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboxCoachClass);
            this.Controls.Add(this.comboxCoachMAng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.txtTraineeDuration);
            this.Controls.Add(this.btnTraineeBack);
            this.Controls.Add(this.txtTraineePhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.btnTraineeReset);
            this.Controls.Add(this.btnTraineeSave);
            this.Controls.Add(this.txtTraineeSubscriptionFee);
            this.Controls.Add(this.txtTraineeAge);
            this.Controls.Add(this.TraineeJoinDate);
            this.Controls.Add(this.radioTraineeFemale);
            this.Controls.Add(this.radioTraineeMale);
            this.Controls.Add(this.txtTraineeName);
            this.Controls.Add(this.lblSubscriptionFee);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblJoinDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Name = "TraineeAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraineeAddForm";
            this.Load += new System.EventHandler(this.TraineeAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTraineeBack;
        private System.Windows.Forms.TextBox txtTraineePhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnTraineeReset;
        private System.Windows.Forms.Button btnTraineeSave;
        private System.Windows.Forms.TextBox txtTraineeSubscriptionFee;
        private System.Windows.Forms.TextBox txtTraineeAge;
        private System.Windows.Forms.DateTimePicker TraineeJoinDate;
        private System.Windows.Forms.RadioButton radioTraineeFemale;
        private System.Windows.Forms.RadioButton radioTraineeMale;
        private System.Windows.Forms.TextBox txtTraineeName;
        private System.Windows.Forms.Label lblSubscriptionFee;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTraineeDuration;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private System.Windows.Forms.BindingSource coachBindingSource;
        private System.Windows.Forms.ComboBox comboxCoachClass;
        private System.Windows.Forms.ComboBox comboxCoachMAng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.ComboBox comboxTrainCoach;
        private System.Windows.Forms.Label label1;
    }
}