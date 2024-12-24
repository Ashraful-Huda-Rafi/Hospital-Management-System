
namespace G5_HMS
{
    partial class updatePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updatePass));
            this.button_close = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.label_current = new System.Windows.Forms.Label();
            this.label_newpass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.IndianRed;
            this.button_close.Location = new System.Drawing.Point(12, 244);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(63, 39);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(213, 192);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 36);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label_current
            // 
            this.label_current.AutoSize = true;
            this.label_current.Location = new System.Drawing.Point(12, 82);
            this.label_current.Name = "label_current";
            this.label_current.Size = new System.Drawing.Size(144, 20);
            this.label_current.TabIndex = 2;
            this.label_current.Text = "Current Password";
            // 
            // label_newpass
            // 
            this.label_newpass.AutoSize = true;
            this.label_newpass.Location = new System.Drawing.Point(12, 151);
            this.label_newpass.Name = "label_newpass";
            this.label_newpass.Size = new System.Drawing.Size(121, 20);
            this.label_newpass.TabIndex = 2;
            this.label_newpass.Text = "New Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 27);
            this.textBox2.TabIndex = 3;
            // 
            // updatePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(453, 300);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_newpass);
            this.Controls.Add(this.label_current);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_close);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "updatePass";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updatePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label_current;
        private System.Windows.Forms.Label label_newpass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}