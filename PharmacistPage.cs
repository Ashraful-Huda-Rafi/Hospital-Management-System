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
    public partial class PharmacistPage : Form
    {
        public PharmacistPage()
        {
            InitializeComponent();
        }
        void showName()
        {
            MyConnection DB = new MyConnection();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("SELECT name FROM user_table WHERE user_id = @id", DB.connection);
                DB.connection.Open();
                cmd.Parameters.AddWithValue("@id", MyConnection.CurrentUserID);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                    label_Name.Text = sdr[0].ToString();
                else
                    label_Name.Text = "";
                DB.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Doctor show", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.connection.Close();
            }
        }
        private void PharmacistPage_Load(object sender, EventArgs e)
        {
            showName();
            showDrugs();
        }

        private void button_dLogout_Click(object sender, EventArgs e)
        {
            Login lgin = new Login();
            lgin.Show();
            this.Close();
        }

        private void button_changePassword_Click(object sender, EventArgs e)
        {
            updatePass udtpass = new updatePass();
            udtpass.Show();
        }
        void showDrugs()
        {
            MyConnection DB = new MyConnection();
            SqlCommand cmd;
            try
            {
                DB.connection.Open();
                string s = "SELECT d_id AS ID, d_name AS Name, d_price AS Price, stock AS Available FROM drug_table";
                cmd = new SqlCommand(s, DB.connection);
                DataTable dt = new DataTable();
                SqlDataReader sd = cmd.ExecuteReader();
                dt.Load(sd);
                dataGridView1.DataSource = dt;
                DB.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in show", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.connection.Close();
            }
        }
        private void button_dAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Dname.Text) == false && string.IsNullOrWhiteSpace(textBox_dPrice.Text) == false && string.IsNullOrWhiteSpace(textBox_dStock.Text)) 
            {
                MyConnection DB = new MyConnection();
                SqlCommand cmd;
                try
                {
                    DB.connection.Open();
                    string add = "INSERT INTO drug_table(d_name, d_price, stock) VALUES(@name, @price, @stk)";
                    cmd = new SqlCommand(add, DB.connection);
                    cmd.Parameters.AddWithValue("@name", textBox_Dname.Text);
                    cmd.Parameters.AddWithValue("@price", textBox_dPrice.Text);
                    cmd.Parameters.AddWithValue("@stk", int.Parse(textBox_dStock.Text));
                    cmd.ExecuteNonQuery();
                    DB.connection.Close();
                    MessageBox.Show("Saved");
                    clearTextfiled();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in add drugs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DB.connection.Close();
                }
            }
        }

        private void clearTextfiled()
        {
            textBox_Dname.Clear();
            textBox_dPrice.Clear();
            textBox_dStock.Clear();
            textBox_F_dname.Clear();
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            MyConnection DB = new MyConnection();
            SqlCommand cmd;
            try
            {
                DB.connection.Open();
                string s = "SELECT * FROM drug_table WHERE d_name= '%@nam%'";
                cmd = new SqlCommand(s, DB.connection);
                cmd.Parameters.AddWithValue("@nam", textBox_F_dname.Text);
                DataTable dt = new DataTable();
                SqlDataReader sd = cmd.ExecuteReader();
                dt.Load(sd);
                dataGridView1.DataSource = dt;
                DB.connection.Close();
                clearTextfiled();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in find", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.connection.Close();
            }
        }
    }
}
