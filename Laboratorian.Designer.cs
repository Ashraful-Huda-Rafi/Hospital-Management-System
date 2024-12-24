
namespace G5_HMS
{
    partial class Laboratorian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laboratorian));
            this.label_hello = new System.Windows.Forms.Label();
            this.label_laboName = new System.Windows.Forms.Label();
            this.button_find = new System.Windows.Forms.Button();
            this.textBox_pid = new System.Windows.Forms.TextBox();
            this.label_exitingPatient = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_top = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_pGender = new System.Windows.Forms.Label();
            this.comboBox_pGender = new System.Windows.Forms.ComboBox();
            this.textBox_pContract = new System.Windows.Forms.TextBox();
            this.textBox_pName = new System.Windows.Forms.TextBox();
            this.label_pContract = new System.Windows.Forms.Label();
            this.label_pname = new System.Windows.Forms.Label();
            this.comboBox_pBlood = new System.Windows.Forms.ComboBox();
            this.label_pBlood = new System.Windows.Forms.Label();
            this.textBox_tests = new System.Windows.Forms.TextBox();
            this.label_pTests = new System.Windows.Forms.Label();
            this.button_dLogout = new System.Windows.Forms.Button();
            this.button_changePassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hello.Location = new System.Drawing.Point(12, 80);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(63, 23);
            this.label_hello.TabIndex = 11;
            this.label_hello.Text = "Hello ,";
            // 
            // label_laboName
            // 
            this.label_laboName.AutoSize = true;
            this.label_laboName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_laboName.Location = new System.Drawing.Point(12, 250);
            this.label_laboName.Name = "label_laboName";
            this.label_laboName.Size = new System.Drawing.Size(58, 23);
            this.label_laboName.TabIndex = 12;
            this.label_laboName.Text = "name";
            // 
            // button_find
            // 
            this.button_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_find.Location = new System.Drawing.Point(237, 192);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(75, 33);
            this.button_find.TabIndex = 15;
            this.button_find.Text = "Find";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // textBox_pid
            // 
            this.textBox_pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_pid.Location = new System.Drawing.Point(217, 159);
            this.textBox_pid.Name = "textBox_pid";
            this.textBox_pid.Size = new System.Drawing.Size(121, 27);
            this.textBox_pid.TabIndex = 14;
            // 
            // label_exitingPatient
            // 
            this.label_exitingPatient.AutoSize = true;
            this.label_exitingPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exitingPatient.Location = new System.Drawing.Point(213, 136);
            this.label_exitingPatient.Name = "label_exitingPatient";
            this.label_exitingPatient.Size = new System.Drawing.Size(83, 20);
            this.label_exitingPatient.TabIndex = 13;
            this.label_exitingPatient.Text = "Patient ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_pBlood);
            this.panel1.Controls.Add(this.label_pBlood);
            this.panel1.Controls.Add(this.textBox_tests);
            this.panel1.Controls.Add(this.label_pTests);
            this.panel1.Controls.Add(this.label_pGender);
            this.panel1.Controls.Add(this.comboBox_pGender);
            this.panel1.Controls.Add(this.textBox_pContract);
            this.panel1.Controls.Add(this.textBox_pName);
            this.panel1.Controls.Add(this.label_pContract);
            this.panel1.Controls.Add(this.label_pname);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(421, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 508);
            this.panel1.TabIndex = 16;
            // 
            // label_top
            // 
            this.label_top.AutoSize = true;
            this.label_top.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_top.Location = new System.Drawing.Point(339, 20);
            this.label_top.Name = "label_top";
            this.label_top.Size = new System.Drawing.Size(321, 39);
            this.label_top.TabIndex = 0;
            this.label_top.Text = "Welcome Laboratorian";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel_top.Controls.Add(this.label_top);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1030, 77);
            this.panel_top.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 372);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_pGender
            // 
            this.label_pGender.AutoSize = true;
            this.label_pGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pGender.Location = new System.Drawing.Point(37, 86);
            this.label_pGender.Name = "label_pGender";
            this.label_pGender.Size = new System.Drawing.Size(64, 20);
            this.label_pGender.TabIndex = 24;
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
            this.comboBox_pGender.Location = new System.Drawing.Point(158, 78);
            this.comboBox_pGender.Name = "comboBox_pGender";
            this.comboBox_pGender.Size = new System.Drawing.Size(155, 28);
            this.comboBox_pGender.TabIndex = 23;
            // 
            // textBox_pContract
            // 
            this.textBox_pContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_pContract.Location = new System.Drawing.Point(158, 123);
            this.textBox_pContract.Name = "textBox_pContract";
            this.textBox_pContract.Size = new System.Drawing.Size(298, 27);
            this.textBox_pContract.TabIndex = 21;
            // 
            // textBox_pName
            // 
            this.textBox_pName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_pName.Location = new System.Drawing.Point(158, 39);
            this.textBox_pName.Name = "textBox_pName";
            this.textBox_pName.Size = new System.Drawing.Size(298, 27);
            this.textBox_pName.TabIndex = 22;
            // 
            // label_pContract
            // 
            this.label_pContract.AutoSize = true;
            this.label_pContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pContract.Location = new System.Drawing.Point(37, 125);
            this.label_pContract.Name = "label_pContract";
            this.label_pContract.Size = new System.Drawing.Size(56, 20);
            this.label_pContract.TabIndex = 19;
            this.label_pContract.Text = "Phone";
            // 
            // label_pname
            // 
            this.label_pname.AutoSize = true;
            this.label_pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pname.Location = new System.Drawing.Point(37, 41);
            this.label_pname.Name = "label_pname";
            this.label_pname.Size = new System.Drawing.Size(53, 20);
            this.label_pname.TabIndex = 20;
            this.label_pname.Text = "Name";
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
            this.comboBox_pBlood.Location = new System.Drawing.Point(158, 174);
            this.comboBox_pBlood.Name = "comboBox_pBlood";
            this.comboBox_pBlood.Size = new System.Drawing.Size(155, 28);
            this.comboBox_pBlood.TabIndex = 27;
            // 
            // label_pBlood
            // 
            this.label_pBlood.AutoSize = true;
            this.label_pBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pBlood.Location = new System.Drawing.Point(37, 174);
            this.label_pBlood.Name = "label_pBlood";
            this.label_pBlood.Size = new System.Drawing.Size(103, 20);
            this.label_pBlood.TabIndex = 28;
            this.label_pBlood.Text = "Blood Group";
            // 
            // textBox_tests
            // 
            this.textBox_tests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_tests.Location = new System.Drawing.Point(158, 224);
            this.textBox_tests.Multiline = true;
            this.textBox_tests.Name = "textBox_tests";
            this.textBox_tests.Size = new System.Drawing.Size(317, 142);
            this.textBox_tests.TabIndex = 26;
            // 
            // label_pTests
            // 
            this.label_pTests.AutoSize = true;
            this.label_pTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pTests.Location = new System.Drawing.Point(50, 277);
            this.label_pTests.Name = "label_pTests";
            this.label_pTests.Size = new System.Drawing.Size(51, 20);
            this.label_pTests.TabIndex = 25;
            this.label_pTests.Text = "Tests";
            // 
            // button_dLogout
            // 
            this.button_dLogout.BackColor = System.Drawing.Color.IndianRed;
            this.button_dLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_dLogout.Location = new System.Drawing.Point(0, 619);
            this.button_dLogout.Name = "button_dLogout";
            this.button_dLogout.Size = new System.Drawing.Size(96, 33);
            this.button_dLogout.TabIndex = 18;
            this.button_dLogout.Text = "LogOut";
            this.button_dLogout.UseVisualStyleBackColor = false;
            this.button_dLogout.Click += new System.EventHandler(this.button_dLogout_Click);
            // 
            // button_changePassword
            // 
            this.button_changePassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_changePassword.Location = new System.Drawing.Point(0, 580);
            this.button_changePassword.Name = "button_changePassword";
            this.button_changePassword.Size = new System.Drawing.Size(179, 33);
            this.button_changePassword.TabIndex = 19;
            this.button_changePassword.Text = "Update Passowrd";
            this.button_changePassword.UseVisualStyleBackColor = false;
            this.button_changePassword.Click += new System.EventHandler(this.button_changePassword_Click);
            // 
            // Laboratorian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 654);
            this.Controls.Add(this.button_dLogout);
            this.Controls.Add(this.button_changePassword);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.textBox_pid);
            this.Controls.Add(this.label_exitingPatient);
            this.Controls.Add(this.label_laboName);
            this.Controls.Add(this.label_hello);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Laboratorian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorian";
            this.Load += new System.EventHandler(this.Laboratorian_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.Label label_laboName;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.TextBox textBox_pid;
        private System.Windows.Forms.Label label_exitingPatient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_pGender;
        private System.Windows.Forms.ComboBox comboBox_pGender;
        private System.Windows.Forms.TextBox textBox_pContract;
        private System.Windows.Forms.TextBox textBox_pName;
        private System.Windows.Forms.Label label_pContract;
        private System.Windows.Forms.Label label_pname;
        private System.Windows.Forms.ComboBox comboBox_pBlood;
        private System.Windows.Forms.Label label_pBlood;
        private System.Windows.Forms.TextBox textBox_tests;
        private System.Windows.Forms.Label label_pTests;
        private System.Windows.Forms.Button button_dLogout;
        private System.Windows.Forms.Button button_changePassword;
    }
}