
namespace G5_HMS
{
    partial class DoctorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorPage));
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_top = new System.Windows.Forms.Label();
            this.label_pname = new System.Windows.Forms.Label();
            this.panel_patient = new System.Windows.Forms.Panel();
            this.comboBox_pBlood = new System.Windows.Forms.ComboBox();
            this.label_pBlood = new System.Windows.Forms.Label();
            this.label_pGender = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
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
            this.label_exitingPatient = new System.Windows.Forms.Label();
            this.textBox_pid = new System.Windows.Forms.TextBox();
            this.button_find = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_changePassword = new System.Windows.Forms.Button();
            this.button_dLogout = new System.Windows.Forms.Button();
            this.label_docName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_top.SuspendLayout();
            this.panel_patient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel_top.Controls.Add(this.label_top);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1036, 77);
            this.panel_top.TabIndex = 0;
            // 
            // label_top
            // 
            this.label_top.AutoSize = true;
            this.label_top.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_top.Location = new System.Drawing.Point(360, 9);
            this.label_top.Name = "label_top";
            this.label_top.Size = new System.Drawing.Size(239, 39);
            this.label_top.TabIndex = 0;
            this.label_top.Text = "Welcome Doctor";
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
            // panel_patient
            // 
            this.panel_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(216)))), ((int)(((byte)(126)))));
            this.panel_patient.Controls.Add(this.comboBox_pBlood);
            this.panel_patient.Controls.Add(this.label_pBlood);
            this.panel_patient.Controls.Add(this.label_pGender);
            this.panel_patient.Controls.Add(this.button_save);
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
            this.panel_patient.Location = new System.Drawing.Point(256, 83);
            this.panel_patient.Name = "panel_patient";
            this.panel_patient.Size = new System.Drawing.Size(550, 529);
            this.panel_patient.TabIndex = 2;
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
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_save.Location = new System.Drawing.Point(232, 486);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 34);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
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
            this.comboBox_pGender.Location = new System.Drawing.Point(150, 103);
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
            // label_exitingPatient
            // 
            this.label_exitingPatient.AutoSize = true;
            this.label_exitingPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exitingPatient.Location = new System.Drawing.Point(808, 119);
            this.label_exitingPatient.Name = "label_exitingPatient";
            this.label_exitingPatient.Size = new System.Drawing.Size(116, 20);
            this.label_exitingPatient.TabIndex = 3;
            this.label_exitingPatient.Text = "Exiting Patient";
            // 
            // textBox_pid
            // 
            this.textBox_pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_pid.Location = new System.Drawing.Point(812, 142);
            this.textBox_pid.Name = "textBox_pid";
            this.textBox_pid.Size = new System.Drawing.Size(121, 27);
            this.textBox_pid.TabIndex = 4;
            // 
            // button_find
            // 
            this.button_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_find.Location = new System.Drawing.Point(832, 175);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(75, 33);
            this.button_find.TabIndex = 5;
            this.button_find.Text = "Find";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(622, 396);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(576, 267);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            // 
            // button_changePassword
            // 
            this.button_changePassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_changePassword.Location = new System.Drawing.Point(0, 591);
            this.button_changePassword.Name = "button_changePassword";
            this.button_changePassword.Size = new System.Drawing.Size(179, 33);
            this.button_changePassword.TabIndex = 7;
            this.button_changePassword.Text = "Update Passowrd";
            this.button_changePassword.UseVisualStyleBackColor = false;
            this.button_changePassword.Click += new System.EventHandler(this.button_changePassword_Click);
            // 
            // button_dLogout
            // 
            this.button_dLogout.BackColor = System.Drawing.Color.IndianRed;
            this.button_dLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_dLogout.Location = new System.Drawing.Point(0, 630);
            this.button_dLogout.Name = "button_dLogout";
            this.button_dLogout.Size = new System.Drawing.Size(96, 33);
            this.button_dLogout.TabIndex = 7;
            this.button_dLogout.Text = "LogOut";
            this.button_dLogout.UseVisualStyleBackColor = false;
            this.button_dLogout.Click += new System.EventHandler(this.button_dLogout_Click);
            // 
            // label_docName
            // 
            this.label_docName.AutoSize = true;
            this.label_docName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_docName.Location = new System.Drawing.Point(12, 259);
            this.label_docName.Name = "label_docName";
            this.label_docName.Size = new System.Drawing.Size(61, 23);
            this.label_docName.TabIndex = 8;
            this.label_docName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hello ,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Good day";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // DoctorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 660);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_docName);
            this.Controls.Add(this.button_dLogout);
            this.Controls.Add(this.button_changePassword);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.textBox_pid);
            this.Controls.Add(this.label_exitingPatient);
            this.Controls.Add(this.panel_patient);
            this.Controls.Add(this.panel_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DoctorPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorPage";
            this.Load += new System.EventHandler(this.DoctorPage_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_patient.ResumeLayout(false);
            this.panel_patient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.Label label_pname;
        private System.Windows.Forms.Panel panel_patient;
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
        private System.Windows.Forms.Label label_exitingPatient;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_pid;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.ComboBox comboBox_pBlood;
        private System.Windows.Forms.Label label_pBlood;
        private System.Windows.Forms.Label label_pGender;
        private System.Windows.Forms.ComboBox comboBox_pGender;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_changePassword;
        private System.Windows.Forms.Button button_dLogout;
        private System.Windows.Forms.Label label_docName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}