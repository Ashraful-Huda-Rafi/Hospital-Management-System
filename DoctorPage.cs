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
    public partial class DoctorPage : Form
    {
        public DoctorPage()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (condition())
            {
                MyConnection DB = new MyConnection();
                SqlCommand cmd;
                try
                {
                    int rf = MyConnection.CurrentUserID;
                    string patientInsert = "INSERT INTO Patient_table(p_name, p_gender, p_phone, p_address, p_blood, p_disease, p_drugs, tests, D_reff) VALUES(@name, @gender, @contract, @address, @blood, @disease, @drugs, @tst, @reff)";
                    DB.connection.Open();
                    cmd = new SqlCommand(patientInsert, DB.connection);
                    cmd.Parameters.AddWithValue("@name", textBox_pName.Text);
                    cmd.Parameters.AddWithValue("@gender", comboBox_pGender.Text);
                    cmd.Parameters.AddWithValue("@contract", textBox_pContract.Text);
                    cmd.Parameters.AddWithValue("@address", textBox_pAddress.Text);
                    cmd.Parameters.AddWithValue("@blood", comboBox_pBlood.Text);
                    cmd.Parameters.AddWithValue("@disease", textBox_pDisease.Text);
                    cmd.Parameters.AddWithValue("@drugs", textBox_drugs.Text);
                    cmd.Parameters.AddWithValue("tst", textBox_tests.Text);
                    cmd.Parameters.AddWithValue("@reff", rf);

                    cmd.ExecuteNonQuery();
                    DB.connection.Close();
                    MessageBox.Show("Successfully Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTextBoxs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in save\n" + ex.ToString(), "Not saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DB.connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Information is missing");
            }
        }

        private void clearTextBoxs()
        {
            textBox_drugs.Clear();
            textBox_pAddress.Clear();
            textBox_pContract.Clear();
            textBox_pDisease.Clear();
            textBox_pid.Clear();
            textBox_pName.Clear();
            textBox_tests.Clear();
            comboBox_pBlood.ResetText();
            comboBox_pGender.ResetText();
        }

        private bool condition()
        {
            if (string.IsNullOrWhiteSpace(textBox_pName.Text)==true || string.IsNullOrWhiteSpace(textBox_pContract.Text)==true)
                return false;
            else
                return true;
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_pid.Text)==false)
            {
                MyConnection DB = new MyConnection();
                SqlCommand cmd;
                try
                {
                    cmd=new SqlCommand("SELECT * FROM Patient_table WHERE p_id=@id", DB.connection);
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
        
        private void DoctorPage_Load(object sender, EventArgs e)
        {
            MyConnection DB = new MyConnection();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("SELECT name FROM user_table WHERE user_id=@id", DB.connection);
                DB.connection.Open();
                cmd.Parameters.AddWithValue("@id", MyConnection.CurrentUserID);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                label_docName.Text = sdr[0].ToString();
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

        private void button_dLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login f = new Login();
            f.Show();
        }

        private void button_changePassword_Click(object sender, EventArgs e)
        {
            updatePass passUpdate = new updatePass();
            passUpdate.Show();
        }

        private void button_print_btn_Click(object sender, EventArgs e)
        {
            MyConnection.mypanel = panel_patient;
            //printPage pp = new printPage();
            //pp.Show();
        }
    }
}
