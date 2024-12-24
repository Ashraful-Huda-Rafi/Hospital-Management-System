
namespace G5_HMS
{
    partial class UserAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAdd));
            this.label_user_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.comboBox_user_type = new System.Windows.Forms.ComboBox();
            this.label_user_type = new System.Windows.Forms.Label();
            this.label_userName = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.textBox_contract = new System.Windows.Forms.TextBox();
            this.label_contract = new System.Windows.Forms.Label();
            this.textBox_nid = new System.Windows.Forms.TextBox();
            this.label_NID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_schedule = new System.Windows.Forms.ComboBox();
            this.button_accessUser_close = new System.Windows.Forms.Button();
            this.dataGridView_userAdd = new System.Windows.Forms.DataGridView();
            this.button_add_user = new System.Windows.Forms.Button();
            this.button_deleteUser = new System.Windows.Forms.Button();
            this.button_update_user = new System.Windows.Forms.Button();
            this.button_find_user = new System.Windows.Forms.Button();
            this.textBox_User_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // label_user_password
            // 
            this.label_user_password.AutoSize = true;
            this.label_user_password.Location = new System.Drawing.Point(16, 46);
            this.label_user_password.Name = "label_user_password";
            this.label_user_password.Size = new System.Drawing.Size(69, 17);
            this.label_user_password.TabIndex = 0;
            this.label_user_password.Text = "Password";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(91, 41);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(164, 22);
            this.textBox_password.TabIndex = 1;
            // 
            // comboBox_user_type
            // 
            this.comboBox_user_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_user_type.FormattingEnabled = true;
            this.comboBox_user_type.Items.AddRange(new object[] {
            "Doctor",
            "Nurse",
            "Laboratorian",
            "Receptionist",
            "Pharmacist"});
            this.comboBox_user_type.Location = new System.Drawing.Point(370, 37);
            this.comboBox_user_type.Name = "comboBox_user_type";
            this.comboBox_user_type.Size = new System.Drawing.Size(155, 24);
            this.comboBox_user_type.TabIndex = 2;
            this.comboBox_user_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_user_type_SelectedIndexChanged);
            // 
            // label_user_type
            // 
            this.label_user_type.AutoSize = true;
            this.label_user_type.Location = new System.Drawing.Point(274, 44);
            this.label_user_type.Name = "label_user_type";
            this.label_user_type.Size = new System.Drawing.Size(90, 17);
            this.label_user_type.TabIndex = 3;
            this.label_user_type.Text = "Type of User";
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(16, 93);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(45, 17);
            this.label_userName.TabIndex = 4;
            this.label_userName.Text = "Name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(91, 90);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(164, 22);
            this.textBox_name.TabIndex = 1;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comboBox_gender.Location = new System.Drawing.Point(370, 86);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(155, 24);
            this.comboBox_gender.TabIndex = 2;
            this.comboBox_gender.SelectedIndexChanged += new System.EventHandler(this.comboBox_user_type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gender";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(91, 137);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(164, 22);
            this.textBox_address.TabIndex = 1;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(16, 140);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(60, 17);
            this.label_address.TabIndex = 4;
            this.label_address.Text = "Address";
            // 
            // textBox_contract
            // 
            this.textBox_contract.Location = new System.Drawing.Point(361, 135);
            this.textBox_contract.Name = "textBox_contract";
            this.textBox_contract.Size = new System.Drawing.Size(164, 22);
            this.textBox_contract.TabIndex = 1;
            // 
            // label_contract
            // 
            this.label_contract.AutoSize = true;
            this.label_contract.Location = new System.Drawing.Point(274, 138);
            this.label_contract.Name = "label_contract";
            this.label_contract.Size = new System.Drawing.Size(61, 17);
            this.label_contract.TabIndex = 4;
            this.label_contract.Text = "Contract";
            // 
            // textBox_nid
            // 
            this.textBox_nid.Location = new System.Drawing.Point(91, 182);
            this.textBox_nid.Name = "textBox_nid";
            this.textBox_nid.Size = new System.Drawing.Size(164, 22);
            this.textBox_nid.TabIndex = 1;
            // 
            // label_NID
            // 
            this.label_NID.AutoSize = true;
            this.label_NID.Location = new System.Drawing.Point(16, 185);
            this.label_NID.Name = "label_NID";
            this.label_NID.Size = new System.Drawing.Size(31, 17);
            this.label_NID.TabIndex = 4;
            this.label_NID.Text = "NID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Schedule";
            // 
            // comboBox_schedule
            // 
            this.comboBox_schedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_schedule.FormattingEnabled = true;
            this.comboBox_schedule.Items.AddRange(new object[] {
            "Morning",
            "Evening",
            "Night"});
            this.comboBox_schedule.Location = new System.Drawing.Point(361, 180);
            this.comboBox_schedule.Name = "comboBox_schedule";
            this.comboBox_schedule.Size = new System.Drawing.Size(164, 24);
            this.comboBox_schedule.TabIndex = 5;
            // 
            // button_accessUser_close
            // 
            this.button_accessUser_close.Location = new System.Drawing.Point(12, 301);
            this.button_accessUser_close.Name = "button_accessUser_close";
            this.button_accessUser_close.Size = new System.Drawing.Size(75, 29);
            this.button_accessUser_close.TabIndex = 7;
            this.button_accessUser_close.Text = "Close";
            this.button_accessUser_close.UseVisualStyleBackColor = true;
            this.button_accessUser_close.Click += new System.EventHandler(this.button_accessUser_close_Click);
            // 
            // dataGridView_userAdd
            // 
            this.dataGridView_userAdd.AllowUserToAddRows = false;
            this.dataGridView_userAdd.AllowUserToDeleteRows = false;
            this.dataGridView_userAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_userAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_userAdd.Location = new System.Drawing.Point(0, 428);
            this.dataGridView_userAdd.Name = "dataGridView_userAdd";
            this.dataGridView_userAdd.ReadOnly = true;
            this.dataGridView_userAdd.RowHeadersWidth = 51;
            this.dataGridView_userAdd.RowTemplate.Height = 24;
            this.dataGridView_userAdd.Size = new System.Drawing.Size(1178, 284);
            this.dataGridView_userAdd.TabIndex = 8;
            this.dataGridView_userAdd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_userAdd_CellClick);
            // 
            // button_add_user
            // 
            this.button_add_user.Location = new System.Drawing.Point(232, 224);
            this.button_add_user.Name = "button_add_user";
            this.button_add_user.Size = new System.Drawing.Size(88, 39);
            this.button_add_user.TabIndex = 9;
            this.button_add_user.Text = "Add User";
            this.button_add_user.UseVisualStyleBackColor = true;
            this.button_add_user.Click += new System.EventHandler(this.button_add_user_Click);
            // 
            // button_deleteUser
            // 
            this.button_deleteUser.Location = new System.Drawing.Point(921, 119);
            this.button_deleteUser.Name = "button_deleteUser";
            this.button_deleteUser.Size = new System.Drawing.Size(99, 38);
            this.button_deleteUser.TabIndex = 9;
            this.button_deleteUser.Text = "Delete User";
            this.button_deleteUser.UseVisualStyleBackColor = true;
            this.button_deleteUser.Click += new System.EventHandler(this.button_deleteUser_Click);
            // 
            // button_update_user
            // 
            this.button_update_user.Location = new System.Drawing.Point(862, 172);
            this.button_update_user.Name = "button_update_user";
            this.button_update_user.Size = new System.Drawing.Size(101, 39);
            this.button_update_user.TabIndex = 9;
            this.button_update_user.Text = "Update Info";
            this.button_update_user.UseVisualStyleBackColor = true;
            this.button_update_user.Click += new System.EventHandler(this.button_update_user_Click);
            // 
            // button_find_user
            // 
            this.button_find_user.Location = new System.Drawing.Point(814, 118);
            this.button_find_user.Name = "button_find_user";
            this.button_find_user.Size = new System.Drawing.Size(88, 39);
            this.button_find_user.TabIndex = 9;
            this.button_find_user.Text = "Find User";
            this.button_find_user.UseVisualStyleBackColor = true;
            this.button_find_user.Click += new System.EventHandler(this.button_find_user_Click);
            // 
            // textBox_User_id
            // 
            this.textBox_User_id.Location = new System.Drawing.Point(829, 87);
            this.textBox_User_id.Name = "textBox_User_id";
            this.textBox_User_id.Size = new System.Drawing.Size(164, 22);
            this.textBox_User_id.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(826, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter ID to Find or Delete";
            // 
            // UserAdd
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1178, 712);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_User_id);
            this.Controls.Add(this.button_find_user);
            this.Controls.Add(this.button_update_user);
            this.Controls.Add(this.button_deleteUser);
            this.Controls.Add(this.button_add_user);
            this.Controls.Add(this.dataGridView_userAdd);
            this.Controls.Add(this.button_accessUser_close);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_schedule);
            this.Controls.Add(this.label_contract);
            this.Controls.Add(this.label_NID);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.label_user_type);
            this.Controls.Add(this.comboBox_user_type);
            this.Controls.Add(this.textBox_contract);
            this.Controls.Add(this.textBox_nid);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_user_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAdd";
            this.Load += new System.EventHandler(this.UserAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_user_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.ComboBox comboBox_user_type;
        private System.Windows.Forms.Label label_user_type;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.TextBox textBox_contract;
        private System.Windows.Forms.Label label_contract;
        private System.Windows.Forms.TextBox textBox_nid;
        private System.Windows.Forms.Label label_NID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_schedule;
        private System.Windows.Forms.Button button_accessUser_close;
        private System.Windows.Forms.DataGridView dataGridView_userAdd;
        private System.Windows.Forms.Button button_add_user;
        private System.Windows.Forms.Button button_deleteUser;
        private System.Windows.Forms.Button button_update_user;
        private System.Windows.Forms.Button button_find_user;
        private System.Windows.Forms.TextBox textBox_User_id;
        private System.Windows.Forms.Label label2;
    }
}