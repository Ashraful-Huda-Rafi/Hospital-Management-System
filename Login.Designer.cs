
namespace G5_HMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label_Login_ID = new System.Windows.Forms.Label();
            this.textBox_LoginID = new System.Windows.Forms.TextBox();
            this.label_Login_passwor = new System.Windows.Forms.Label();
            this.textBox_LoginPassword = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Login_ID
            // 
            this.label_Login_ID.AutoSize = true;
            this.label_Login_ID.Location = new System.Drawing.Point(215, 83);
            this.label_Login_ID.Name = "label_Login_ID";
            this.label_Login_ID.Size = new System.Drawing.Size(37, 28);
            this.label_Login_ID.TabIndex = 0;
            this.label_Login_ID.Text = "ID";
            // 
            // textBox_LoginID
            // 
            this.textBox_LoginID.Location = new System.Drawing.Point(330, 77);
            this.textBox_LoginID.Name = "textBox_LoginID";
            this.textBox_LoginID.Size = new System.Drawing.Size(166, 34);
            this.textBox_LoginID.TabIndex = 1;
            this.textBox_LoginID.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_LoginID_Validating);
            // 
            // label_Login_passwor
            // 
            this.label_Login_passwor.AutoSize = true;
            this.label_Login_passwor.Location = new System.Drawing.Point(192, 133);
            this.label_Login_passwor.Name = "label_Login_passwor";
            this.label_Login_passwor.Size = new System.Drawing.Size(118, 28);
            this.label_Login_passwor.TabIndex = 0;
            this.label_Login_passwor.Text = "Password";
            // 
            // textBox_LoginPassword
            // 
            this.textBox_LoginPassword.Location = new System.Drawing.Point(330, 127);
            this.textBox_LoginPassword.Name = "textBox_LoginPassword";
            this.textBox_LoginPassword.Size = new System.Drawing.Size(166, 34);
            this.textBox_LoginPassword.TabIndex = 1;
            this.textBox_LoginPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_LoginPassword_Validating);
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.Transparent;
            this.button_Login.Location = new System.Drawing.Point(373, 212);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(109, 47);
            this.button_Login.TabIndex = 2;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.Location = new System.Drawing.Point(220, 212);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(109, 47);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 383);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_LoginPassword);
            this.Controls.Add(this.label_Login_passwor);
            this.Controls.Add(this.textBox_LoginID);
            this.Controls.Add(this.label_Login_ID);
            this.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Login_ID;
        private System.Windows.Forms.TextBox textBox_LoginID;
        private System.Windows.Forms.Label label_Login_passwor;
        private System.Windows.Forms.TextBox textBox_LoginPassword;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}