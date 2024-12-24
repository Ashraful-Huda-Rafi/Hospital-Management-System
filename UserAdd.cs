using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G5_HMS
{
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private void comboBox_user_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_user_type.Text == "Doctor")
            {

            }
        }

        private void button_accessUser_close_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
        }
        void showData()
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
                dataGridView_userAdd.DataSource = dt;
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
        private void UserAdd_Load(object sender, EventArgs e)
        {
            showData();
        }
        bool ValidInfo()
        {
            if (string.IsNullOrWhiteSpace(textBox_password.Text) || string.IsNullOrWhiteSpace(textBox_name.Text) || string.IsNullOrWhiteSpace(comboBox_user_type.Text) || string.IsNullOrWhiteSpace(textBox_contract.Text) || string.IsNullOrWhiteSpace(textBox_nid.Text)||string.IsNullOrWhiteSpace(comboBox_schedule.Text))
            {
                return false;
            }
            return true;
        }
        private void button_add_user_Click(object sender, EventArgs e)
        {
            MyConnection DB = new MyConnection();
            SqlCommand cmd;
            if(ValidInfo())
            {
                try
                {
                    string insertQuery = "INSERT INTO user_table(user_pass,role_type,name,address,gender,phone,nid,schedule) VALUES(@pass,@role,@name,@address,@gender,@phone,@nid,@schedule)";
                    cmd = new SqlCommand(insertQuery, DB.connection);

                    cmd.Parameters.AddWithValue("@pass", textBox_password.Text);
                    int r = 0;
                    string U = comboBox_user_type.Text;
                    if (U == "Doctor")
                        r = 2;
                    else if (U == "Nurse")
                        r = 3;
                    else if (U == "Laboratorian")
                        r = 4;
                    else if (U == "Receptionist")
                        r = 5;
                    else if (U == "Pharmacist")
                        r = 6;
                    cmd.Parameters.AddWithValue("@role", r);
                    cmd.Parameters.AddWithValue("@name", textBox_name.Text);
                    cmd.Parameters.AddWithValue("@address", textBox_address.Text);
                    cmd.Parameters.AddWithValue("@gender", comboBox_gender.Text);
                    cmd.Parameters.AddWithValue("@phone", textBox_contract.Text);
                    cmd.Parameters.AddWithValue("@nid", textBox_nid.Text);
                    cmd.Parameters.AddWithValue("@schedule", comboBox_schedule.Text);
                    DB.connection.Open();
                    cmd.ExecuteNonQuery();
                    DB.connection.Close();
                    showData();
                    MessageBox.Show("Successfully Data Inserted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTextBoxs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in INSERTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DB.connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Missing valuable information", "MISSING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearTextBoxs()
        {
            textBox_password.Clear();
            textBox_name.Clear();
            textBox_address.Clear();
            textBox_contract.Clear();
            textBox_nid.Clear();
            textBox_User_id.Clear();
            comboBox_gender.ResetText();
            comboBox_schedule.ResetText();
            comboBox_user_type.ResetText();
        }

        private void button_deleteUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_User_id.Text))
            {
                MyConnection DB = new MyConnection();
                SqlCommand cmd;
                try
                {
                    DB.connection.Open();
                    SqlDataAdapter SDA = new SqlDataAdapter("SELECT COUNT(*) FROM user_table WHERE user_id='" + int.Parse(textBox_User_id.Text) + "' AND user_pass='" + textBox_password.Text + "' ", DB.connection);
                    DataTable dt = new DataTable();
                    SDA.Fill(dt);
                    DB.connection.Close();
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        string deletequery = "Delete user_table WHERE user_id=@id";
                        cmd = new SqlCommand(deletequery, DB.connection);
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBox_User_id.Text));
                        DB.connection.Open();
                        cmd.ExecuteNonQuery();
                        DB.connection.Close();
                        showData();
                        MessageBox.Show("Successfully Data Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User doesn't exits", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something wentwrong in Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DB.connection.Close();
                }
            }
            else
            {
                MessageBox.Show("ID not selected","Unspacipied ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_update_user_Click(object sender, EventArgs e)
        {
            if(ValidInfo() && !string.IsNullOrWhiteSpace(textBox_User_id.Text))
            {
                MyConnection DB = new MyConnection();
                SqlCommand cmd;
                try
                {
                    DB.connection.Open();
                    SqlDataAdapter SDA = new SqlDataAdapter("SELECT COUNT(*) FROM user_table WHERE user_id='"+ int.Parse(textBox_User_id.Text) +"' AND user_pass='"+ textBox_password.Text +"' ", DB.connection);
                    DataTable dt = new DataTable();
                    SDA.Fill(dt);
                    DB.connection.Close();

                    if (dt.Rows[0][0].ToString()=="1")
                    {
                        string updatequery = "UPDATE user_table SET user_pass=@pass,role_type=@role,name=@NewName,address=@NewAddress,gender=@newGender,phone=@newPhone,nid=@newNid,schedule=@newsche WHERE user_id=@id";
                        cmd = new SqlCommand(updatequery, DB.connection);
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBox_User_id.Text));
                        cmd.Parameters.AddWithValue("@pass", textBox_password.Text);
                        int r = 0;
                        string U = comboBox_user_type.Text;
                        if (U == "Doctor")
                            r = 2;
                        else if (U == "Nurse")
                            r = 3;
                        else if (U == "Laboratorian")
                            r = 4;
                        else if (U == "Receptionist")
                            r = 5;
                        else if (U == "Pharmacist")
                            r = 6;
                        cmd.Parameters.AddWithValue("@role", r);
                        cmd.Parameters.AddWithValue("@NewName", textBox_name.Text);
                        cmd.Parameters.AddWithValue("@NewAddress", textBox_address.Text);
                        cmd.Parameters.AddWithValue("@newGender", comboBox_gender.Text);
                        cmd.Parameters.AddWithValue("@newPhone", textBox_contract.Text);
                        cmd.Parameters.AddWithValue("@newNid", textBox_nid.Text);
                        cmd.Parameters.AddWithValue("@newsche", comboBox_schedule.Text);
                        DB.connection.Open();
                        cmd.ExecuteNonQuery();
                        DB.connection.Close();
                        showData();
                        MessageBox.Show("Successfully Data Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearTextBoxs();
                    }
                    else
                    {
                        MessageBox.Show("User doesn't exits", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something wentwrong in Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DB.connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Select any rows or specify the user to update");
            }
        }
        private void dataGridView_userAdd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_userAdd.CurrentRow.Selected = true;
            //textBox_User_id.Text = dataGridView_userAdd.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox_password.Text = dataGridView_userAdd.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox_user_type.Text = dataGridView_userAdd.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_name.Text = dataGridView_userAdd.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox_address.Text = dataGridView_userAdd.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox_gender.Text = dataGridView_userAdd.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox_contract.Text = dataGridView_userAdd.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox_nid.Text = dataGridView_userAdd.Rows[e.RowIndex].Cells[7].Value.ToString();
            comboBox_schedule.Text = dataGridView_userAdd.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void button_find_user_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_User_id.Text))
            {
                MyConnection DB = new MyConnection();
                SqlCommand cmd;
                try
                {
                    cmd = new SqlCommand("SELECT * FROM user_table WHERE user_id=@id", DB.connection);
                    DB.connection.Open();
                    cmd.Parameters.AddWithValue("@id", textBox_User_id.Text);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        dt.Load(sdr);
                        dataGridView_userAdd.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Not found");
                    }
                    DB.connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something wentwrong in Find", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DB.connection.Close();
                    clearTextBoxs();
                }
            }
            else
            {
                MessageBox.Show("ID is missing");
            }
        }
    }
}
