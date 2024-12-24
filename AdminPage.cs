using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G5_HMS
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void button_admin_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginFrom = new Login();
            loginFrom.Show();
        }

        private void button_Doctor_Click(object sender, EventArgs e)
        {
            UserAdd new_useradd = new UserAdd();
            new_useradd.Show();
            this.Close();
        }
        void showUsers()
        {
            MyConnection DB = new MyConnection();
            try
            {
                DB.connection.Open();
                string queryCMD = "  SELECT user_id AS ID ,user_pass AS Password, role_name As Role, name AS Name, address AS Address, gender AS Gender, phone As Contract, nid AS NID, schedule AS Schedule From user_table , role_table WHERE role_type=role_id";
                SqlCommand cmd = new SqlCommand(queryCMD, DB.connection);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                DB.connection.Close();
                dataGridView_adminPage.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something Went worng in showData()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.connection.Close();
            }
        }
        private void AdminPage_Load(object sender, EventArgs e)
        {
            showUsers();
        }

        private void button_updatepass_Click(object sender, EventArgs e)
        {
            updatePass up = new updatePass();
            up.Show();
        }
    }
}
