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

namespace HotelReceptionistsSystem.User_Control
{
    public partial class UserControlCheckOut : UserControl
    {
        public UserControlCheckOut()
        {
            InitializeComponent();
        }
        private string RID = "", No;
        public string db = "Data Source = DESKTOP-J8PP8MD; Initial Catalog = HeavensDoor; Integrated Security = True";

        private void Clear()
        {
            
            textBoxGuestID.Clear();
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            RID = "";
        }
        private void tabPageCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void UserControlCheckOut_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Reservation_Table WHERE Reservation_Guest_ID LIKE '%" + textBoxGuestID.Text + "%'";

            try
            {
                using (SqlConnection connection = new SqlConnection(db))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewReservation.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menampilkan data: " + ex.Message);
            }
        }

        private void dataGridViewReservation_Enter(object sender, EventArgs e)
        {

        }

        private void tabControlCheckOut_Enter(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Reservation_Table WHERE Reservation_Guest_ID LIKE '%" + textBoxGuestID.Text + "%'";

            try
            {
                using (SqlConnection connection = new SqlConnection(db))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewReservation.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menampilkan data: " + ex.Message);
            }
        }

        private void tabPageSearchReserve_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxGuestID_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Reservation_Table WHERE Reservation_Guest_ID LIKE '%" 
                + textBoxGuestID.Text + "%'";

            try
            {
                using (SqlConnection connection = new SqlConnection(db))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewReservation.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menampilkan data: " + ex.Message);
            }
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];
                RID = row.Cells[0].Value.ToString();
                textBoxRoomType.Text = row.Cells[1].Value.ToString();
                textBoxRoomNumber.Text = row.Cells[2].Value.ToString();
                textBoxGuestID1.Text = row.Cells[3].Value.ToString();
                dateTimePickerIn.Text = row.Cells[4].Value.ToString();
                dateTimePickerOut.Text = row.Cells[5].Value.ToString();
            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            if (textBoxRoomType.Text.Trim() == string.Empty || textBoxGuestID1.Text.Trim() == string.Empty)
               
            {
                MessageBox.Show("Please Fill The Field.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = "DELETE FROM Reservation_Table WHERE Reservation_Guest_ID = @ID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(db))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID", textBoxGuestID1.Text.Trim());

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            string updateQuery = "UPDATE Room_Table SET Room_Booked = 'No' WHERE Room_Number = @Number";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                            updateCommand.Parameters.AddWithValue("@Number", textBoxRoomNumber.Text.ToString().Trim());
                            updateCommand.ExecuteNonQuery();
                            MessageBox.Show("Check-Out Succesfully Done!");
                        }
                        else
                        {
                            MessageBox.Show("Failed To Check-Out. Please Try Again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Happens: " + ex.Message);
                }
            }

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageSearchReserve_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.room_TableTableAdapter.FillBy(this.heavensDoorDataSet.Room_Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPageCheckOut_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
