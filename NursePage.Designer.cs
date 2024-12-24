
namespace G5_HMS
{
    partial class NursePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NursePage));
            this.button_find = new System.Windows.Forms.Button();
            this.textBox_pid = new System.Windows.Forms.TextBox();
            this.label_exitingPatient = new System.Windows.Forms.Label();
            this.label_top = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nurseName = new System.Windows.Forms.Label();
            this.panel_patient = new System.Windows.Forms.Panel();
            this.comboBox_pBlood = new System.Windows.Forms.ComboBox();
            this.label_pBlood = new System.Windows.Forms.Label();
            this.label_pGender = new System.Windows.Forms.Label();
            this.comboBox_pGender = new System.Windows.Forms.ComboBox();
            this.textBox_tests = new System.Windows.Forms.TextBox();
            this.textBox_drugs = new System.Windows.Forms.TextBox();
            this.textBox_pDisease = new System.Windows.Forms.TextBox();
            this.textBox_pContract = new System.Windows.Forms.TextBox();
            this.textBox_pAddress = new System.Windows.Forms.TextBox();
            this.textBox_pName = new System.Windows.Forms.TextBox();
            this.label_pTests = new System.Windows.Forms.Label();
            this.label_pDrugs = new System.Windows.Forms.Label();
            this.label_pDisease = new System.Windows.Forms.Label();
            this.label_pContract = new System.Windows.Forms.Label();
            this.label_pAddress = new System.Windows.Forms.Label();
            this.label_pname = new System.Windows.Forms.Label();
            this.button_dLogout = new System.Windows.Forms.Button();
            this.button_changePassword = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox_nurse = new System.Windows.Forms.PictureBox();
            this.panel_top.SuspendLayout();
            this.panel_patient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_nurse)).BeginInit();
            this.SuspendLayout();
            // 
            // button_find
            // 
            this.button_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_find.Location = new System.Drawing.Point(32, 377);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(75, 33);
            this.button_find.TabIndex = 8;
            this.button_find.Text = "Find";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // textBox_pid
            // 
            this.textBox_pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_pid.Location = new System.Drawing.Point(12, 344);
            this.textBox_pid.Name = "textBox_pid";
            this.textBox_pid.Size = new System.Drawing.Size(121, 27);
            this.textBox_pid.TabIndex = 7;
            // 
            // label_exitingPatient
            // 
            this.label_exitingPatient.AutoSize = true;
            this.label_exitingPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exitingPatient.Location = new System.Drawing.Point(8, 321);
            this.label_exitingPatient.Name = "label_exitingPatient";
            this.label_exitingPatient.Size = new System.Drawing.Size(113, 20);
            this.label_exitingPatient.TabIndex = 6;
            this.label_exitingPatient.Text = "Check Patient";
            // 
            // label_top
            // 
            this.label_top.AutoSize = true;
            this.label_top.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_top.Location = new System.Drawing.Point(388, 19);
            this.label_top.Name = "label_top";
            this.label_top.Size = new System.Drawing.Size(230, 39);
            this.label_top.TabIndex = 0;
            this.label_top.Text = "Welcome Nurse";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel_top.Controls.Add(this.label_top);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1079, 77);
            this.panel_top.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hello ,";
            // 
            // label_nurseName
            // 
            this.label_nurseName.AutoSize = true;
            this.label_nurseName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nurseName.Location = new System.Drawing.Point(13, 268);
            this.label_nurseName.Name = "label_nurseName";
            this.label_nurseName.Size = new System.Drawing.Size(58, 23);
            this.label_nurseName.TabIndex = 10;
            this.label_nurseName.Text = "name";
            // 
            // panel_patient
            // 
            this.panel_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(216)))), ((int)(((byte)(126)))));
            this.panel_patient.Controls.Add(this.comboBox_pBlood);
            this.panel_patient.Controls.Add(this.label_pBlood);
            this.panel_patient.Controls.Add(this.label_pGender);
            this.panel_patient.Controls.Add(this.comboBox_pGender);
            this.panel_patient.Controls.Add(this.textBox_tests);
            this.panel_patient.Controls.Add(this.textBox_drugs);
            this.panel_patient.Controls.Add(this.textBox_pDisease);
            this.panel_patient.Controls.Add(this.textBox_pContract);
            this.panel_patient.Controls.Add(this.textBox_pAddress);
            this.panel_patient.Controls.Add(this.textBox_pName);
            this.panel_patient.Controls.Add(this.label_pTests);
            this.panel_patient.Controls.Add(this.label_pDrugs);
            this.panel_patient.Controls.Add(this.label_pDisease);
            this.panel_patient.Controls.Add(this.label_pContract);
            this.panel_patient.Controls.Add(this.label_pAddress);
            this.panel_patient.Controls.Add(this.label_pname);
            this.panel_patient.Location = new System.Drawing.Point(261, 87);
            this.panel_patient.Name = "panel_patient";
            this.panel_patient.Size = new System.Drawing.Size(550, 529);
            this.panel_patient.TabIndex = 11;
            // 
            // comboBox_pBlood
            // 
            this.comboBox_pBlood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.comboBox_pBlood.FormattingEnabled = true;
            this.comboBox_pBlood.Items.AddRange(new object[] {
            "A+ve",
            "B+ve",
            "AB+ve",
            "O+ve",
            "O-ve",
            "AB-ve",
            "A-ve",
            "B-ve"});
            this.comboBox_pBlood.Location = new System.Drawing.Point(153, 241);
            this.comboBox_pBlood.Name = "comboBox_pBlood";
            this.comboBox_pBlood.Size = new System.Drawing.Size(155, 28);
            this.comboBox_pBlood.TabIndex = 7;
            // 
            // label_pBlood
            // 
            this.label_pBlood.AutoSize = true;
            this.label_pBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pBlood.Location = new System.Drawing.Point(32, 241);
            this.label_pBlood.Name = "label_pBlood";
            this.label_pBlood.Size = new System.Drawing.Size(103, 20);
            this.label_pBlood.TabIndex = 8;
            this.label_pBlood.Text = "Blood Group";
            // 
            // label_pGender
            // 
            this.label_pGender.AutoSize = true;
            this.label_pGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pGender.Location = new System.Drawing.Point(30, 111);
            this.label_pGender.Name = "label_pGender";
            this.label_pGender.Size = new System.Drawing.Size(64, 20);
            this.label_pGender.TabIndex = 7;
            this.label_pGender.Text = "Gender";
            // 
            // comboBox_pGender
            // 
            this.comboBox_pGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.comboBox_pGender.FormattingEnabled = true;
            this.comboBox_pGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comboBox_pGender.Location = new System.Drawing.Point(151, 103);
            this.comboBox_pGender.Name = "comboBox_pGender";
            this.comboBox_pGender.Size = new System.Drawing.Size(155, 28);
            this.comboBox_pGender.TabIndex = 6;
            // 
            // textBox_tests
            // 
            this.textBox_tests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_tests.Location = new System.Drawing.Point(151, 423);
            this.textBox_tests.Multiline = true;
            this.textBox_tests.Name = "textBox_tests";
            this.textBox_tests.Size = new System.Drawing.Size(298, 45);
            this.textBox_tests.TabIndex = 2;
            // 
            // textBox_drugs
            // 
            this.textBox_drugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_drugs.Location = new System.Drawing.Point(151, 356);
            this.textBox_drugs.Multiline = true;
            this.textBox_drugs.Name = "textBox_drugs";
            this.textBox_drugs.Size = new System.Drawing.Size(298, 45);
            this.textBox_drugs.TabIndex = 2;
            // 
            // textBox_pDisease
            // 
            this.textBox_pDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_pDisease.Location = new System.Drawing.Point(151, 287);
            this.textBox_pDisease.Multiline = true;
            this.textBox_pDisease.Name = "textBox_pDisease";
            this.textBox_pDisease.Size = new System.Drawing.Size(298, 45);
            this.textBox_pDisease.TabIndex = 2;
            // 
            // textBox_pContract
            // 
            this.textBox_pContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_pContract.Location = new System.Drawing.Point(151, 192);
            this.textBox_pContract.Name = "textBox_pContract";
            this.textBox_pContract.Size = new System.Drawing.Size(298, 27);
            this.textBox_pContract.TabIndex = 2;
            // 
            // textBox_pAddress
            // 
            this.textBox_pAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_pAddress.Location = new System.Drawing.Point(151, 151);
            this.textBox_pAddress.Name = "textBox_pAddress";
            this.textBox_pAddress.Size = new System.Drawing.Size(298, 27);
            this.textBox_pAddress.TabIndex = 2;
            // 
            // textBox_pName
            // 
            this.textBox_pName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_pName.Location = new System.Drawing.Point(151, 64);
            this.textBox_pName.Name = "textBox_pName";
            this.textBox_pName.Size = new System.Drawing.Size(298, 27);
            this.textBox_pName.TabIndex = 2;
            // 
            // label_pTests
            // 
            this.label_pTests.AutoSize = true;
            this.label_pTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pTests.Location = new System.Drawing.Point(32, 432);
            this.label_pTests.Name = "label_pTests";
            this.label_pTests.Size = new System.Drawing.Size(51, 20);
            this.label_pTests.TabIndex = 1;
            this.label_pTests.Text = "Tests";
            // 
            // label_pDrugs
            // 
            this.label_pDrugs.AutoSize = true;
            this.label_pDrugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pDrugs.Location = new System.Drawing.Point(32, 369);
            this.label_pDrugs.Name = "label_pDrugs";
            this.label_pDrugs.Size = new System.Drawing.Size(55, 20);
            this.label_pDrugs.TabIndex = 1;
            this.label_pDrugs.Text = "Drugs";
            // 
            // label_pDisease
            // 
            this.label_pDisease.AutoSize = true;
            this.label_pDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pDisease.Location = new System.Drawing.Point(30, 299);
            this.label_pDisease.Name = "label_pDisease";
            this.label_pDisease.Size = new System.Drawing.Size(71, 20);
            this.label_pDisease.TabIndex = 1;
            this.label_pDisease.Text = "Disease";
            // 
            // label_pContract
            // 
            this.label_pContract.AutoSize = true;
            this.label_pContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pContract.Location = new System.Drawing.Point(30, 194);
            this.label_pContract.Name = "label_pContract";
            this.label_pContract.Size = new System.Drawing.Size(56, 20);
            this.label_pContract.TabIndex = 1;
            this.label_pContract.Text = "Phone";
            // 
            // label_pAddress
            // 
            this.label_pAddress.AutoSize = true;
            this.label_pAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pAddress.Location = new System.Drawing.Point(30, 153);
            this.label_pAddress.Name = "label_pAddress";
            this.label_pAddress.Size = new System.Drawing.Size(71, 20);
            this.label_pAddress.TabIndex = 1;
            this.label_pAddress.Text = "Address";
            // 
            // label_pname
            // 
            this.label_pname.AutoSize = true;
            this.label_pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pname.Location = new System.Drawing.Point(30, 66);
            this.label_pname.Name = "label_pname";
            this.label_pname.Size = new System.Drawing.Size(53, 20);
            this.label_pname.TabIndex = 1;
            this.label_pname.Text = "Name";
            // 
            // button_dLogout
            // 
            this.button_dLogout.BackColor = System.Drawing.Color.IndianRed;
            this.button_dLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_dLogout.Location = new System.Drawing.Point(0, 595);
            this.button_dLogout.Name = "button_dLogout";
            this.button_dLogout.Size = new System.Drawing.Size(96, 33);
            this.button_dLogout.TabIndex = 12;
            this.button_dLogout.Text = "LogOut";
            this.button_dLogout.UseVisualStyleBackColor = false;
            this.button_dLogout.Click += new System.EventHandler(this.button_dLogout_Click);
            // 
            // button_changePassword
            // 
            this.button_changePassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_changePassword.Location = new System.Drawing.Point(0, 556);
            this.button_changePassword.Name = "button_changePassword";
            this.button_changePassword.Size = new System.Drawing.Size(179, 33);
            this.button_changePassword.TabIndex = 13;
            this.button_changePassword.Text = "Update Passowrd";
            this.button_changePassword.UseVisualStyleBackColor = false;
            this.button_changePassword.Click += new System.EventHandler(this.button_changePassword_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(836, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Visible = false;
            // 
            // pictureBox_nurse
            // 
            this.pictureBox_nurse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_nurse.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_nurse.Image")));
            this.pictureBox_nurse.Location = new System.Drawing.Point(12, 113);
            this.pictureBox_nurse.Name = "pictureBox_nurse";
            this.pictureBox_nurse.Size = new System.Drawing.Size(167, 152);
            this.pictureBox_nurse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_nurse.TabIndex = 15;
            this.pictureBox_nurse.TabStop = false;
            // 
            // NursePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 628);
            this.Controls.Add(this.pictureBox_nurse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_dLogout);
            this.Controls.Add(this.button_changePassword);
            this.Controls.Add(this.panel_patient);
            this.Controls.Add(this.label_nurseName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.textBox_pid);
            this.Controls.Add(this.label_exitingPatient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NursePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NursePage";
            this.Load += new System.EventHandler(this.NursePage_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_patient.ResumeLayout(false);
            this.panel_patient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_nurse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.TextBox textBox_pid;
        private System.Windows.Forms.Label label_exitingPatient;
        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nurseName;
        private System.Windows.Forms.Panel panel_patient;
        private System.Windows.Forms.ComboBox comboBox_pBlood;
        private System.Windows.Forms.Label label_pBlood;
        private System.Windows.Forms.Label label_pGender;
        private System.Windows.Forms.ComboBox comboBox_pGender;
        private System.Windows.Forms.TextBox textBox_tests;
        private System.Windows.Forms.TextBox textBox_drugs;
        private System.Windows.Forms.TextBox textBox_pDisease;
        private System.Windows.Forms.TextBox textBox_pContract;
        private System.Windows.Forms.TextBox textBox_pAddress;
        private System.Windows.Forms.TextBox textBox_pName;
        private System.Windows.Forms.Label label_pTests;
        private System.Windows.Forms.Label label_pDrugs;
        private System.Windows.Forms.Label label_pDisease;
        private System.Windows.Forms.Label label_pContract;
        private System.Windows.Forms.Label label_pAddress;
        private System.Windows.Forms.Label label_pname;
        private System.Windows.Forms.Button button_dLogout;
        private System.Windows.Forms.Button button_changePassword;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox_nurse;
    }
}