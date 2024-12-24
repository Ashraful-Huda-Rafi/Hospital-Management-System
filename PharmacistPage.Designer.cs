
namespace G5_HMS
{
    partial class PharmacistPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacistPage));
            this.label_top = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_Name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_hello = new System.Windows.Forms.Label();
            this.button_dLogout = new System.Windows.Forms.Button();
            this.button_changePassword = new System.Windows.Forms.Button();
            this.panel_addDrugs = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Dname = new System.Windows.Forms.Label();
            this.label_dprice = new System.Windows.Forms.Label();
            this.textBox_Dname = new System.Windows.Forms.TextBox();
            this.textBox_dPrice = new System.Windows.Forms.TextBox();
            this.button_dAdd = new System.Windows.Forms.Button();
            this.label_Fdname = new System.Windows.Forms.Label();
            this.textBox_F_dname = new System.Windows.Forms.TextBox();
            this.button_find = new System.Windows.Forms.Button();
            this.label_Dstock = new System.Windows.Forms.Label();
            this.textBox_dStock = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_addDrugs.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_top
            // 
            this.label_top.AutoSize = true;
            this.label_top.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_top.Location = new System.Drawing.Point(445, 26);
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
            this.panel_top.Size = new System.Drawing.Size(1083, 77);
            this.panel_top.TabIndex = 5;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(12, 262);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(58, 23);
            this.label_Name.TabIndex = 20;
            this.label_Name.Text = "name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hello.Location = new System.Drawing.Point(12, 88);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(63, 23);
            this.label_hello.TabIndex = 19;
            this.label_hello.Text = "Hello ,";
            // 
            // button_dLogout
            // 
            this.button_dLogout.BackColor = System.Drawing.Color.IndianRed;
            this.button_dLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_dLogout.Location = new System.Drawing.Point(0, 533);
            this.button_dLogout.Name = "button_dLogout";
            this.button_dLogout.Size = new System.Drawing.Size(96, 33);
            this.button_dLogout.TabIndex = 21;
            this.button_dLogout.Text = "LogOut";
            this.button_dLogout.UseVisualStyleBackColor = false;
            this.button_dLogout.Click += new System.EventHandler(this.button_dLogout_Click);
            // 
            // button_changePassword
            // 
            this.button_changePassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_changePassword.Location = new System.Drawing.Point(0, 494);
            this.button_changePassword.Name = "button_changePassword";
            this.button_changePassword.Size = new System.Drawing.Size(179, 33);
            this.button_changePassword.TabIndex = 22;
            this.button_changePassword.Text = "Update Passowrd";
            this.button_changePassword.UseVisualStyleBackColor = false;
            this.button_changePassword.Click += new System.EventHandler(this.button_changePassword_Click);
            // 
            // panel_addDrugs
            // 
            this.panel_addDrugs.BackColor = System.Drawing.Color.Tan;
            this.panel_addDrugs.Controls.Add(this.button_dAdd);
            this.panel_addDrugs.Controls.Add(this.textBox_dStock);
            this.panel_addDrugs.Controls.Add(this.textBox_dPrice);
            this.panel_addDrugs.Controls.Add(this.label_Dstock);
            this.panel_addDrugs.Controls.Add(this.textBox_Dname);
            this.panel_addDrugs.Controls.Add(this.label_dprice);
            this.panel_addDrugs.Controls.Add(this.label_Dname);
            this.panel_addDrugs.Location = new System.Drawing.Point(673, 83);
            this.panel_addDrugs.Name = "panel_addDrugs";
            this.panel_addDrugs.Size = new System.Drawing.Size(410, 202);
            this.panel_addDrugs.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.button_find);
            this.panel1.Controls.Add(this.textBox_F_dname);
            this.panel1.Controls.Add(this.label_Fdname);
            this.panel1.Location = new System.Drawing.Point(225, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 202);
            this.panel1.TabIndex = 24;
            // 
            // label_Dname
            // 
            this.label_Dname.AutoSize = true;
            this.label_Dname.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dname.Location = new System.Drawing.Point(31, 16);
            this.label_Dname.Name = "label_Dname";
            this.label_Dname.Size = new System.Drawing.Size(61, 23);
            this.label_Dname.TabIndex = 19;
            this.label_Dname.Text = "Name";
            // 
            // label_dprice
            // 
            this.label_dprice.AutoSize = true;
            this.label_dprice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dprice.Location = new System.Drawing.Point(31, 63);
            this.label_dprice.Name = "label_dprice";
            this.label_dprice.Size = new System.Drawing.Size(54, 23);
            this.label_dprice.TabIndex = 19;
            this.label_dprice.Text = "Price";
            // 
            // textBox_Dname
            // 
            this.textBox_Dname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_Dname.Location = new System.Drawing.Point(122, 16);
            this.textBox_Dname.Name = "textBox_Dname";
            this.textBox_Dname.Size = new System.Drawing.Size(257, 27);
            this.textBox_Dname.TabIndex = 20;
            // 
            // textBox_dPrice
            // 
            this.textBox_dPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_dPrice.Location = new System.Drawing.Point(122, 59);
            this.textBox_dPrice.Name = "textBox_dPrice";
            this.textBox_dPrice.Size = new System.Drawing.Size(257, 27);
            this.textBox_dPrice.TabIndex = 20;
            // 
            // button_dAdd
            // 
            this.button_dAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_dAdd.Location = new System.Drawing.Point(181, 142);
            this.button_dAdd.Name = "button_dAdd";
            this.button_dAdd.Size = new System.Drawing.Size(102, 34);
            this.button_dAdd.TabIndex = 25;
            this.button_dAdd.Text = "Add";
            this.button_dAdd.UseVisualStyleBackColor = true;
            this.button_dAdd.Click += new System.EventHandler(this.button_dAdd_Click);
            // 
            // label_Fdname
            // 
            this.label_Fdname.AutoSize = true;
            this.label_Fdname.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fdname.Location = new System.Drawing.Point(30, 32);
            this.label_Fdname.Name = "label_Fdname";
            this.label_Fdname.Size = new System.Drawing.Size(61, 23);
            this.label_Fdname.TabIndex = 19;
            this.label_Fdname.Text = "Name";
            // 
            // textBox_F_dname
            // 
            this.textBox_F_dname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_F_dname.Location = new System.Drawing.Point(121, 32);
            this.textBox_F_dname.Name = "textBox_F_dname";
            this.textBox_F_dname.Size = new System.Drawing.Size(257, 27);
            this.textBox_F_dname.TabIndex = 20;
            // 
            // button_find
            // 
            this.button_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_find.Location = new System.Drawing.Point(177, 87);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(102, 34);
            this.button_find.TabIndex = 25;
            this.button_find.Text = "Find";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // label_Dstock
            // 
            this.label_Dstock.AutoSize = true;
            this.label_Dstock.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dstock.Location = new System.Drawing.Point(31, 98);
            this.label_Dstock.Name = "label_Dstock";
            this.label_Dstock.Size = new System.Drawing.Size(57, 23);
            this.label_Dstock.TabIndex = 19;
            this.label_Dstock.Text = "Stock";
            // 
            // textBox_dStock
            // 
            this.textBox_dStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox_dStock.Location = new System.Drawing.Point(122, 98);
            this.textBox_dStock.Name = "textBox_dStock";
            this.textBox_dStock.Size = new System.Drawing.Size(257, 27);
            this.textBox_dStock.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(402, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(493, 217);
            this.dataGridView1.TabIndex = 25;
            // 
            // PharmacistPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 556);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_addDrugs);
            this.Controls.Add(this.button_dLogout);
            this.Controls.Add(this.button_changePassword);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_hello);
            this.Controls.Add(this.panel_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PharmacistPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PharmacistPage";
            this.Load += new System.EventHandler(this.PharmacistPage_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_addDrugs.ResumeLayout(false);
            this.panel_addDrugs.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.Button button_dLogout;
        private System.Windows.Forms.Button button_changePassword;
        private System.Windows.Forms.Panel panel_addDrugs;
        private System.Windows.Forms.Label label_dprice;
        private System.Windows.Forms.Label label_Dname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_dPrice;
        private System.Windows.Forms.TextBox textBox_Dname;
        private System.Windows.Forms.Button button_dAdd;
        private System.Windows.Forms.TextBox textBox_dStock;
        private System.Windows.Forms.Label label_Dstock;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.TextBox textBox_F_dname;
        private System.Windows.Forms.Label label_Fdname;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}