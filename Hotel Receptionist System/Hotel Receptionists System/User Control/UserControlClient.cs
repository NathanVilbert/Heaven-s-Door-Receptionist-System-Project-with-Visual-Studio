using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace HotelReceptionistsSystem.User_Control
{
    public partial class UserControlClient : UserControl
    {
        public UserControlClient()
        {
            InitializeComponent();
        }
        private string ID = "";

        public string db = "Data Source = DESKTOP-J8PP8MD; Initial Catalog = HeavensDoor; Integrated Security = True";
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
        public void DisplayAndSearch(string query, DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(db))
                {
                    con.Open();

                    SqlCommand command = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menampilkan data: " + ex.Message);
            }
        }
        public void Clear()
        {

        }

        private void Clear1()
        {
            textBoxName1.Clear();
            textBoxGender1.Clear();
            textBoxAge1.Clear();
            textBoxPhone1.Clear();
            textBoxAddress1.Clear();
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(db);
            con.Open();

            string insertQuery = "INSERT INTO Guest_table (Guest_Name, Guest_Gender, Guest_Age, Guest_Phone, Guest_Address) VALUES (@Name, @Gender, @Age, @Phone, @Address)";
            SqlCommand insertCommand = new SqlCommand(insertQuery, con);
            insertCommand.Parameters.AddWithValue("@Name", textBoxName.Text.Trim());
            insertCommand.Parameters.AddWithValue("@Gender", textBoxGender.Text.Trim());
            insertCommand.Parameters.AddWithValue("@Age", textBoxAge.Text.Trim());
            insertCommand.Parameters.AddWithValue("@Phone", textBoxPhone.Text.Trim());
            insertCommand.Parameters.AddWithValue("@Address", textBoxAddress.Text.Trim());

            int rowsAffected = insertCommand.ExecuteNonQuery();



            if (textBoxName.Text.Trim() == string.Empty || textBoxGender.Text.Trim() == string.Empty || textBoxAge.Text.Trim() == string.Empty
                || textBoxPhone.Text.Trim() == string.Empty || textBoxAddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill The Field.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Guest Registration Succesfully Done!");
                }
                else
                {
                    MessageBox.Show("Guest Registration Failed. Please Try Again.");
                }


            }





        }

        private void tabPageAddGuest_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControlClient_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Guest_Table";

            try
            {
                using (SqlConnection connection = new SqlConnection(db))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewGuest.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menampilkan data: " + ex.Message);
            }

        }

        private void tabPage2_Leave(object sender, EventArgs e)
        {
            textBoxSearchName.Clear();
        }

        private void tabControlClient_Leave(object sender, EventArgs e)
        {

        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearchName_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Guest_Table WHERE Guest_Name LIKE '%" + textBoxSearchName.Text + "%'";

            try
            {
                using (SqlConnection connection = new SqlConnection(db))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewGuest.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menampilkan data: " + ex.Message);
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {


            if (textBoxName1.Text.Trim() == string.Empty || textBoxGender1.Text.Trim() == string.Empty || textBoxAge1.Text.Trim() == string.Empty
               || textBoxPhone1.Text.Trim() == string.Empty || textBoxAddress1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill The Field.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {


                string query = "UPDATE Guest_Table SET Guest_Name = @Name, Guest_Gender = @Gender, Guest_Age = @Age, Guest_Phone = @Phone," +
                    " Guest_Address = @Address WHERE Guest_Name = @Name";

                try
                {
                    using (SqlConnection connection = new SqlConnection(db))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Name", textBoxName1.Text.Trim());
                        command.Parameters.AddWithValue("@Gender", textBoxGender1.Text.Trim());
                        command.Parameters.AddWithValue("@Age", textBoxAge1.Text.Trim());
                        command.Parameters.AddWithValue("@Phone", textBoxPhone1.Text.Trim());
                        command.Parameters.AddWithValue("@Address", textBoxAddress1.Text.Trim());


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Succesfully Updated!");
                        }
                        else
                        {
                            MessageBox.Show("Failed To Update Data. Please Try Again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Happens: " + ex.Message);
                }


            }


        }
        private void Clear2()
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewGuest.Rows[e.RowIndex];

                textBoxName1.Text = row.Cells[1].Value.ToString();
                textBoxGender1.Text = row.Cells[2].Value.ToString();
                textBoxAge1.Text = row.Cells[3].Value.ToString();
                textBoxPhone1.Text = row.Cells[4].Value.ToString();
                textBoxAddress1.Text = row.Cells[5].Value.ToString();
                textBoxGuestID.Text = row.Cells[0].Value.ToString();
                textBoxName2.Text = row.Cells[1].Value.ToString(); 

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxName1.Text.Trim() == string.Empty || textBoxGender1.Text.Trim() == string.Empty || textBoxAge1.Text.Trim() == string.Empty
                || textBoxPhone1.Text.Trim() == string.Empty || textBoxAddress1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill The Field.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = "DELETE FROM Guest_Table WHERE Guest_Name = @Name";

                try
                {
                    using (SqlConnection connection = new SqlConnection(db))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Name", textBoxName1.Text.Trim());

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Guest Data Deleted!");
                        }
                        else
                        {
                            MessageBox.Show("Failed To Delete Guest Data. Please Try Again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Happens: " + ex.Message);
                }
            }

        }

        private void textBoxSearchName_Leave(object sender, EventArgs e)
        {
            textBoxSearchName.Clear();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPageReserve_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear2();
            Clear1();
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(db);
            con.Open();

            string insertQuery = "INSERT INTO Reservation_Table (Reservation_Room_Type, Reservation_Room_Number, Reservation_Guest_ID," +
                " Reservation_In, Reservation_Out) VALUES (@Type, @Number, @ID, @In, @Out)";
            SqlCommand insertCommand = new SqlCommand(insertQuery, con);
            insertCommand.Parameters.AddWithValue("@Type", comboBoxType.SelectedItem.ToString().Trim());
            insertCommand.Parameters.AddWithValue("@Number", comboBoxNo.SelectedItem.ToString().Trim());
            insertCommand.Parameters.AddWithValue("@ID", textBoxGuestID.Text.Trim());
            insertCommand.Parameters.AddWithValue("@In", dateTimePickerIn.Text.Trim());
            insertCommand.Parameters.AddWithValue("@Out", dateTimePickerOut.Text.Trim());
            

            int rowsAffected = insertCommand.ExecuteNonQuery();

            if (comboBoxType.SelectedIndex == -1 || comboBoxNo.SelectedIndex == -1 || textBoxGuestID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill The Field.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (rowsAffected > 0)
                {
                    string updateQuery = "UPDATE Room_Table SET Room_Booked = 'Yes' WHERE Room_Number = @Number";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                    updateCommand.Parameters.AddWithValue("@Number", comboBoxNo.SelectedItem.ToString().Trim());
                    updateCommand.ExecuteNonQuery();

                    string insertQuery2 = "INSERT INTO Report_Table (Report_Room_Type, Report_Guest_Name, Report_Guest_ID, Report_Room_Number, Report_Check_In, " +
                        "Report_Check_Out, Report_Price) VALUES (@Type, @Name, @ID, @Number, @In, @Out, @Price)";
                    SqlCommand insertCommand2 = new SqlCommand(insertQuery2, con);
                    insertCommand2.Parameters.AddWithValue("@Type", comboBoxType.SelectedItem.ToString().Trim());
                    insertCommand2.Parameters.AddWithValue("@Number", comboBoxNo.SelectedItem.ToString().Trim());
                    insertCommand2.Parameters.AddWithValue("@Name", textBoxName2.Text.Trim());
                    insertCommand2.Parameters.AddWithValue("@ID", textBoxGuestID.Text.Trim());
                    insertCommand2.Parameters.AddWithValue("@In", dateTimePickerIn.Text.Trim());
                    insertCommand2.Parameters.AddWithValue("@Out", dateTimePickerOut.Text.Trim());
                    insertCommand2.Parameters.AddWithValue("@Price", textBoxPrice.Text.Trim());
                    insertCommand2.ExecuteNonQuery();

                    MessageBox.Show("Reservation Succesfully Done!");
                }
                else
                {
                    MessageBox.Show("Reservation Failed. Please Try Again.");
                }
            }

            con.Close();



        }

        private void dateTimePickerOut_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate1 = dateTimePickerOut.Value;
            DateTime selectedDate2 = dateTimePickerIn.Value;
            TimeSpan difference = selectedDate1 - selectedDate2;
            int days = difference.Days;

            if (comboBoxType.SelectedItem == "Standard Room")
            {
                int totalprice = (days * 1500000);
                textBoxPrice.Text = "Rp." + totalprice.ToString();
            }
            else if (comboBoxType.SelectedItem == "Superior Room")
            {
                int totalprice = (days * 2000000);
                textBoxPrice.Text = "Rp." + totalprice.ToString();
            }
            else if (comboBoxType.SelectedItem == "Deluxe Room")
            {
                int totalprice = (days * 2500000);
                textBoxPrice.Text = "Rp." + totalprice.ToString();
            }
            else if (comboBoxType.SelectedItem == "Suite Room")
            {
                int totalprice = (days * 4000000);
                textBoxPrice.Text = "Rp." + totalprice.ToString();
            }
            else if (comboBoxType.SelectedItem == "Twin Room")
            {
                int totalprice = (days * 1700000);
                textBoxPrice.Text = "Rp." + totalprice.ToString();
            }
            else if (comboBoxType.SelectedItem == "Double Room")
            {
                int totalprice = (days * 1500000);
                textBoxPrice.Text = "Rp." + totalprice.ToString();
            }
            else if (comboBoxType.SelectedItem == "Family Room")
            {
                int totalprice = (days * 2200000);
                textBoxPrice.Text = "Rp." + totalprice.ToString();
            }
            else
            {
                MessageBox.Show("Error Calculating Price. Please Try Again.");
            }

            textBoxPrice.BackColor = Color.White;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGuestID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Please Pick a Date");
        }

        private void UserControlClient_Load(object sender, EventArgs e)
        {

        }
    }
}
    

