
namespace G5_HMS
{
    partial class ReceptionistPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistPage));
            this.panel_patient = new System.Windows.Forms.Panel();
            this.label_Docname = new System.Windows.Forms.Label();
            this.label_pGender = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.comboBox_pGender = new System.Windows.Forms.ComboBox();
            this.textBox_docRef = new System.Windows.Forms.TextBox();
            this.textBox_pContract = new System.Windows.Forms.TextBox();
            this.textBox_pAddress = new System.Windows.Forms.TextBox();
            this.textBox_pName = new System.Windows.Forms.TextBox();
            this.label_pContract = new System.Windows.Forms.Label();
            this.label_pAddress = new System.Windows.Forms.Label();
            this.label_pname = new System.Windows.Forms.Label();
            this.label_top = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_dLogout = new System.Windows.Forms.Button();
            this.button_changePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.panel_patient.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_patient
            // 
            this.panel_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(216)))), ((int)(((byte)(126)))));
            this.panel_patient.Controls.Add(this.label_Docname);
            this.panel_patient.Controls.Add(this.label_pGender);
            this.panel_patient.Controls.Add(this.button_register);
            this.panel_patient.Controls.Add(this.comboBox_pGender);
            this.panel_patient.Controls.Add(this.textBox_docRef);
            this.panel_patient.Controls.Add(this.textBox_pContract);
            this.panel_patient.Controls.Add(this.textBox_pAddress);
            this.panel_patient.Controls.Add(this.textBox_pName);
            this.panel_patient.Controls.Add(this.label_pContract);
            this.panel_patient.Controls.Add(this.label_pAddress);
            this.panel_patient.Controls.Add(this.label_pname);
            this.panel_patient.Location = new System.Drawing.Point(317, 83);
            this.panel_patient.Name = "panel_patient";
            this.panel_patient.Size = new System.Drawing.Size(550, 306);
            this.panel_patient.TabIndex = 3;
            // 
            // label_Docname
            // 
            this.label_Docname.AutoSize = true;
            this.label_Docname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Docname.Location = new System.Drawing.Point(45, 210);
            this.label_Docname.Name = "label_Docname";
            this.label_Docname.Size = new System.Drawing.Size(129, 20);
            this.label_Docname.TabIndex = 8;
            this.label_Docname.Text = "Reffered Doctor";
            // 
            // label_pGender
            // 
            this.label_pGender.AutoSize = true;
            this.label_pGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pGender.Location = new System.Drawing.Point(43, 80);
            this.label_pGender.Name = "label_pGender";
            this.label_pGender.Size = new System.Drawing.Size(64, 20);
            this.label_pGender.TabIndex = 7;
            this.label_pGender.Text = "Gender";
            // 
            // button_register
            // 
            this.button_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_register.Location = new System.Drawing.Point(227, 261);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(102, 34);
            this.button_register.TabIndex = 3;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
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
            this.comboBox_pGender.Location = new System.Drawing.Point(164, 72);
            this.comboBox_pGender.Name = "comboBox_pGender";
            this.comboBox_pGender.Size = new System.Drawing.Size(155, 28);
            this.comboBox_pGender.TabIndex = 6;
            // 
            // textBox_docRef
            // 
            this.textBox_docRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_docRef.Location = new System.Drawing.Point(199, 207);
            this.textBox_docRef.Name = "textBox_docRef";
            this.textBox_docRef.Size = new System.Drawing.Size(149, 27);
            this.textBox_docRef.TabIndex = 2;
            // 
            // textBox_pContract
            // 
            this.textBox_pContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_pContract.Location = new System.Drawing.Point(164, 161);
            this.textBox_pContract.Name = "textBox_pContract";
            this.textBox_pContract.Size = new System.Drawing.Size(298, 27);
            this.textBox_pContract.TabIndex = 2;
            // 
            // textBox_pAddress
            // 
            this.textBox_pAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_pAddress.Location = new System.Drawing.Point(164, 120);
            this.textBox_pAddress.Name = "textBox_pAddress";
            this.textBox_pAddress.Size = new System.Drawing.Size(298, 27);
            this.textBox_pAddress.TabIndex = 2;
            // 
            // textBox_pName
            // 
            this.textBox_pName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_pName.Location = new System.Drawing.Point(164, 33);
            this.textBox_pName.Name = "textBox_pName";
            this.textBox_pName.Size = new System.Drawing.Size(298, 27);
            this.textBox_pName.TabIndex = 2;
            // 
            // label_pContract
            // 
            this.label_pContract.AutoSize = true;
            this.label_pContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pContract.Location = new System.Drawing.Point(43, 163);
            this.label_pContract.Name = "label_pContract";
            this.label_pContract.Size = new System.Drawing.Size(56, 20);
            this.label_pContract.TabIndex = 1;
            this.label_pContract.Text = "Phone";
            // 
            // label_pAddress
            // 
            this.label_pAddress.AutoSize = true;
            this.label_pAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pAddress.Location = new System.Drawing.Point(43, 122);
            this.label_pAddress.Name = "label_pAddress";
            this.label_pAddress.Size = new System.Drawing.Size(71, 20);
            this.label_pAddress.TabIndex = 1;
            this.label_pAddress.Text = "Address";
            // 
            // label_pname
            // 
            this.label_pname.AutoSize = true;
            this.label_pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pname.Location = new System.Drawing.Point(43, 35);
            this.label_pname.Name = "label_pname";
            this.label_pname.Size = new System.Drawing.Size(53, 20);
            this.label_pname.TabIndex = 1;
            this.label_pname.Text = "Name";
            // 
            // label_top
            // 
            this.label_top.AutoSize = true;
            this.label_top.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_top.Location = new System.Drawing.Point(407, 9);
            this.label_top.Name = "label_top";
            this.label_top.Size = new System.Drawing.Size(149, 39);
            this.label_top.TabIndex = 0;
            this.label_top.Text = "Welcome ";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel_top.Controls.Add(this.label_top);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(980, 77);
            this.panel_top.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(317, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 179);
            this.dataGridView1.TabIndex = 5;
            // 
            // button_dLogout
            // 
            this.button_dLogout.BackColor = System.Drawing.Color.IndianRed;
            this.button_dLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_dLogout.Location = new System.Drawing.Point(12, 552);
            this.button_dLogout.Name = "button_dLogout";
            this.button_dLogout.Size = new System.Drawing.Size(96, 33);
            this.button_dLogout.TabIndex = 14;
            this.button_dLogout.Text = "LogOut";
            this.button_dLogout.UseVisualStyleBackColor = false;
            this.button_dLogout.Click += new System.EventHandler(this.button_dLogout_Click);
            // 
            // button_changePassword
            // 
            this.button_changePassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_changePassword.Location = new System.Drawing.Point(12, 513);
            this.button_changePassword.Name = "button_changePassword";
            this.button_changePassword.Size = new System.Drawing.Size(179, 33);
            this.button_changePassword.TabIndex = 15;
            this.button_changePassword.Text = "Update Passowrd";
            this.button_changePassword.UseVisualStyleBackColor = false;
            this.button_changePassword.Click += new System.EventHandler(this.button_changePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hello ,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(8, 269);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(58, 23);
            this.label_Name.TabIndex = 17;
            this.label_Name.Text = "name";
            // 
            // ReceptionistPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 586);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_dLogout);
            this.Controls.Add(this.button_changePassword);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_patient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReceptionistPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceptionistPage";
            this.Load += new System.EventHandler(this.ReceptionistPage_Load);
            this.panel_patient.ResumeLayout(false);
            this.panel_patient.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_patient;
        private System.Windows.Forms.Label label_Docname;
        private System.Windows.Forms.Label label_pGender;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.ComboBox comboBox_pGender;
        private System.Windows.Forms.TextBox textBox_pContract;
        private System.Windows.Forms.TextBox textBox_pAddress;
        private System.Windows.Forms.TextBox textBox_pName;
        private System.Windows.Forms.Label label_pContract;
        private System.Windows.Forms.Label label_pAddress;
        private System.Windows.Forms.Label label_pname;
        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.TextBox textBox_docRef;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_dLogout;
        private System.Windows.Forms.Button button_changePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Name;
    }
}