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
    public partial class NursePage : Form
    {
        public NursePage()
        {
            InitializeComponent();
        }

        private void NursePage_Load(object sender, EventArgs e)
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
                    label_nurseName.Text = sdr[0].ToString();
                else
                    label_nurseName.Text = "";
                DB.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DB.connection.Close();
            }
        }

        private void button_changePassword_Click(object sender, EventArgs e)
        {
            updatePass upass = new updatePass();
            upass.Show();
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_pid.Text) == false)
            {
                MyConnection DB = new MyConnection();
                SqlCommand cmd;
                try
                {
                    cmd = new SqlCommand("SELECT * FROM Patient_table WHERE p_id=@id", DB.connection);
                    DB.connection.Open();
                    cmd.Parameters.AddWithValue("@id", int.Parse(textBox_pid.Text));
                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(sdr);
                        dataGridView1.DataSource = dt;
                        //dataGridView1.Visible = true;
                        dataGridView1.Rows[0].Selected = true;

                        textBox_pName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                        comboBox_pGender.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                        textBox_pContract.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                        textBox_pAddress.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                        comboBox_pBlood.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                        textBox_pDisease.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                        textBox_drugs.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                        textBox_tests.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Patient not found");
                    }
                    DB.connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error in find", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DB.connection.Close();
                }
            }
            else
            {
                MessageBox.Show("ID is missing");
            }
        }

        private void button_dLogout_Click(object sender, EventArgs e)
        {
            Login nLog = new Login();
            nLog.Show();
            this.Close();
        }
    }
}
