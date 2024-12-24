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
    public partial class ReceptionistPage : Form
    {
        public ReceptionistPage()
        {
            InitializeComponent();
        }
        void showDoctors()
        {
            MyConnection DB = new MyConnection();
            SqlCommand cmd;
            try
            {
                string q = "SELECT user_id AS ID, name AS Doctors, schedule AS Schedule FROM user_table WHERE role_type=2";
                DB.connection.Open();
                cmd = new SqlCommand(q, DB.connection);
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in show Doctors list", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.connection.Close();
            }
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
                MessageBox.Show(ex.Message,"Error in Doctor show", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.connection.Close();
            }
        }
        private void ReceptionistPage_Load(object sender, EventArgs e)
        {
            showName();
            showDoctors();
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

        private void button_register_Click(object sender, EventArgs e)
        {
            MyConnection DB = new MyConnection();
            SqlCommand cmd;
            try
            {
                string PIreciption = "INSERT INTO Patient_table(p_name, p_gender, p_phone, p_address, D_reff) VALUES(@name, @gender, @contract, @address, @reff)";
                cmd = new SqlCommand(PIreciption, DB.connection);
                DB.connection.Open();
                cmd.Parameters.AddWithValue("@name", textBox_pName.Text);
                cmd.Parameters.AddWithValue("@gender", comboBox_pGender.Text);
                cmd.Parameters.AddWithValue("@contract", textBox_pContract.Text);
                cmd.Parameters.AddWithValue("@address", textBox_pAddress.Text);
                cmd.Parameters.AddWithValue("@reff", int.Parse(textBox_docRef.Text));
                cmd.ExecuteNonQuery();
                DB.connection.Close();

                MessageBox.Show("Saved");
                clearTextfiled();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.connection.Close();
            }
        }

        private void clearTextfiled()
        {
            textBox_docRef.Clear();
            textBox_pAddress.Clear();
            textBox_pContract.Clear();
            textBox_pName.Clear();
            comboBox_pGender.ResetText();
        }
    }
}
