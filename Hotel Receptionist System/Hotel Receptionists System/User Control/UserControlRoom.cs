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

namespace HotelReceptionistsSystem.User_Control
{
    public partial class UserControlRoom : UserControl
    {
        public UserControlRoom()
        {
            InitializeComponent();
        }
        private string No = "", Free = "";

        public string db = "Data Source = DESKTOP-J8PP8MD; Initial Catalog = HeavensDoor; Integrated Security = True";
        private void UserControlRoom_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Room_Table";

            try
            {
                using (SqlConnection connection = new SqlConnection(db))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewRoom.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menampilkan data: " + ex.Message);
            }
        }

        public void Clear()
        {
            comboBoxType.SelectedIndex= -1;
            textBoxPhoneNo.Clear();
            radioButtonYes.Checked=false;
            radioButtonNo.Checked=false;
            No = "";
        }

         

        private void tabPageSearchRoom_Click(object sender, EventArgs e)
        {

        }

        private void tabPageUpdateRoom_Enter(object sender, EventArgs e)
        {
           
        }

        private void tabPageSearchRoom_Enter(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Room_Table";

            try
            {
                using (SqlConnection connection = new SqlConnection(db))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewRoom.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menampilkan data: " + ex.Message);
            }

        }

        private void textBoxSearchName_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Room_Table WHERE Room_Phone LIKE '%" + textBoxSearchNo.Text + "%'";

            try
            {
                using (SqlConnection connection = new SqlConnection(db))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewRoom.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menampilkan data: " + ex.Message);
            }

        }

        private void tabPageSearchRoom_Leave(object sender, EventArgs e)
        {
         
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == -1 || textBoxPhoneNo.Text.Trim() == string.Empty || Free == "")

            {
                MessageBox.Show("Please Fill The Field.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                string query = "DELETE FROM Room_Table WHERE Room_Phone = @Phone";

                try
                {
                    using (SqlConnection connection = new SqlConnection(db))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Phone", textBoxPhoneNo.Text.Trim());

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Delete Room Succesfuly Done!");
                        }
                        else
                        {
                            MessageBox.Show("Failed To Delete. Please Try Again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Happens: " + ex.Message);
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (radioButtonNo.Checked = true)
            {
                Free = "Yes";
            }
            if (radioButtonYes.Checked = true)
            {
                Free = "No";
            }
            
            if (comboBoxType.SelectedIndex == -1 || textBoxPhoneNo.Text.Trim() == string.Empty || Free == "")
               
            {
                MessageBox.Show("Please Fill The Field.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = "UPDATE Room_Table SET Room_Type = @Type, Room_Phone = @Phone, Room_Booked = @Booked WHERE Room_Phone = @Phone";

                try
                {
                    using (SqlConnection connection = new SqlConnection(db))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Type", comboBoxType.SelectedItem.ToString().Trim());
                        command.Parameters.AddWithValue("@Phone", textBoxPhoneNo.Text.Trim());
                        command.Parameters.AddWithValue("@Booked", Free);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room Succesfully Updated!");
                        }
                        else
                        {
                            MessageBox.Show("Failed To Update Room. Please Try Again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Happens: " + ex.Message);
                }


            }
        }

        private void dataGridViewRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPageUpdateRoom_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewRoom_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
                if(e.RowIndex != -1) 
            { 
                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];
                No = row.Cells[0].Value.ToString();
                comboBoxType.SelectedItem = row.Cells[1].Value.ToString();
                textBoxPhoneNo.Text = row.Cells[2].Value.ToString();
                Free = row.Cells[3].Value.ToString();
                if (Free == "Yes")
                    radioButtonNo.Checked = true;
                if (Free == "No")
                    radioButtonYes.Checked = true;

            }
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
