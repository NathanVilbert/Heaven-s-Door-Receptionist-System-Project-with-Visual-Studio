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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelReceptionistsSystem.User_Control
{
    public partial class UserControlDashboard : UserControl
    {
        public string Username;

        public UserControlDashboard()
        {
            InitializeComponent();
        }
        public string db = "Data Source = DESKTOP-J8PP8MD; Initial Catalog = HeavensDoor; Integrated Security = True";
        private void UserControl1_Load(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM Guest_Table";

            using (SqlConnection connection = new SqlConnection(db))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int guestCount = (int)command.ExecuteScalar();
                connection.Close();
                labelUsername.Text = (guestCount.ToString());
            }
            string query2 = "SELECT COUNT(*) FROM Room_Table WHERE Room_Booked = 'No'";

            using (SqlConnection connection = new SqlConnection(db))
            {
                SqlCommand command = new SqlCommand(query2, connection);
                connection.Open();
                int roomCount = (int)command.ExecuteScalar();
                connection.Close();
                labelroom.Text = (roomCount.ToString());
            }

            }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
          
        }
    }
}
