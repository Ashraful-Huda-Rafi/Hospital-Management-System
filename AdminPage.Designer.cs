
namespace G5_HMS
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.panel_AdminPageTop = new System.Windows.Forms.Panel();
            this.label_adminWellcome = new System.Windows.Forms.Label();
            this.dataGridView_adminPage = new System.Windows.Forms.DataGridView();
            this.button_Doctor = new System.Windows.Forms.Button();
            this.button_admin_logout = new System.Windows.Forms.Button();
            this.button_updatepass = new System.Windows.Forms.Button();
            this.panel_AdminPageTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adminPage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_AdminPageTop
            // 
            this.panel_AdminPageTop.BackColor = System.Drawing.Color.SlateBlue;
            this.panel_AdminPageTop.Controls.Add(this.label_adminWellcome);
            this.panel_AdminPageTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_AdminPageTop.Location = new System.Drawing.Point(0, 0);
            this.panel_AdminPageTop.Name = "panel_AdminPageTop";
            this.panel_AdminPageTop.Size = new System.Drawing.Size(1364, 97);
            this.panel_AdminPageTop.TabIndex = 0;
            // 
            // label_adminWellcome
            // 
            this.label_adminWellcome.AutoSize = true;
            this.label_adminWellcome.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adminWellcome.Location = new System.Drawing.Point(504, 28);
            this.label_adminWellcome.Name = "label_adminWellcome";
            this.label_adminWellcome.Size = new System.Drawing.Size(240, 36);
            this.label_adminWellcome.TabIndex = 0;
            this.label_adminWellcome.Text = "Welcome Admin";
            // 
            // dataGridView_adminPage
            // 
            this.dataGridView_adminPage.AllowUserToAddRows = false;
            this.dataGridView_adminPage.AllowUserToDeleteRows = false;
            this.dataGridView_adminPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_adminPage.Location = new System.Drawing.Point(259, 292);
            this.dataGridView_adminPage.Name = "dataGridView_adminPage";
            this.dataGridView_adminPage.ReadOnly = true;
            this.dataGridView_adminPage.RowHeadersWidth = 51;
            this.dataGridView_adminPage.RowTemplate.Height = 24;
            this.dataGridView_adminPage.Size = new System.Drawing.Size(1105, 440);
            this.dataGridView_adminPage.TabIndex = 2;
            // 
            // button_Doctor
            // 
            this.button_Doctor.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Doctor.Image = ((System.Drawing.Image)(resources.GetObject("button_Doctor.Image")));
            this.button_Doctor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Doctor.Location = new System.Drawing.Point(286, 133);
            this.button_Doctor.Name = "button_Doctor";
            this.button_Doctor.Size = new System.Drawing.Size(222, 57);
            this.button_Doctor.TabIndex = 1;
            this.button_Doctor.Text = "Access User";
            this.button_Doctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Doctor.UseVisualStyleBackColor = true;
            this.button_Doctor.Click += new System.EventHandler(this.button_Doctor_Click);
            // 
            // button_admin_logout
            // 
            this.button_admin_logout.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_admin_logout.Location = new System.Drawing.Point(22, 700);
            this.button_admin_logout.Name = "button_admin_logout";
            this.button_admin_logout.Size = new System.Drawing.Size(75, 32);
            this.button_admin_logout.TabIndex = 3;
            this.button_admin_logout.Text = "Logout";
            this.button_admin_logout.UseVisualStyleBackColor = false;
            this.button_admin_logout.Click += new System.EventHandler(this.button_admin_logout_Click);
            // 
            // button_updatepass
            // 
            this.button_updatepass.Location = new System.Drawing.Point(12, 661);
            this.button_updatepass.Name = "button_updatepass";
            this.button_updatepass.Size = new System.Drawing.Size(142, 33);
            this.button_updatepass.TabIndex = 4;
            this.button_updatepass.Text = "Change Password";
            this.button_updatepass.UseVisualStyleBackColor = true;
            this.button_updatepass.Click += new System.EventHandler(this.button_updatepass_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 735);
            this.Controls.Add(this.button_updatepass);
            this.Controls.Add(this.button_admin_logout);
            this.Controls.Add(this.dataGridView_adminPage);
            this.Controls.Add(this.button_Doctor);
            this.Controls.Add(this.panel_AdminPageTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.panel_AdminPageTop.ResumeLayout(false);
            this.panel_AdminPageTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adminPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_AdminPageTop;
        private System.Windows.Forms.Label label_adminWellcome;
        private System.Windows.Forms.DataGridView dataGridView_adminPage;
        private System.Windows.Forms.Button button_Doctor;
        private System.Windows.Forms.Button button_admin_logout;
        private System.Windows.Forms.Button button_updatepass;
    }
}