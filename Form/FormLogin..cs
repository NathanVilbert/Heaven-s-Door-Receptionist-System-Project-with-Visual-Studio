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
using AMRConnector;

namespace HotelReceptionistsSystem
{
    public partial class Form1 : Form
    {
   
        public Form1()
        {
            InitializeComponent();

        }
            public string db = "Data Source=DESKTOP-J8PP8MD;Initial Catalog=HeavensDoor;Integrated Security=True";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(db);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM User_Table", con); 
            SqlDataReader reader = command.ExecuteReader();

            bool check = false;

            while (reader.Read())
            {
                string username = reader["User_Name"].ToString(); 
                string password = reader["User_Password"].ToString();

                if (textBoxUsername.Text.Trim() == username && textBoxPassword.Text.Trim() == password)
                {
                    check = true;
                    break;
                }
            }

            if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill The Field.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check)
                {
                    FormDashboard fd = new FormDashboard();
                    fd.Username = textBoxUsername.Text;
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    fd.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username/Password.", "Username/Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            con.Close();

        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHidden.Show();
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHidden_Click(object sender, EventArgs e)
        {
            pictureBoxHidden.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private void pictureBoxHidden_MouseHover(object sender, EventArgs e)
        {
                toolTip1.SetToolTip(pictureBoxHidden, "Hide Password");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
