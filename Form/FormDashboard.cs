using HotelReceptionistsSystem.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReceptionistsSystem
{
    public partial class FormDashboard : Form
    {
        public string Username;
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            userControlClient1.Hide();
            userControlCheckOut1.Hide();
            userControlRoom1.Hide();
            userControlFilter1.Hide();
            userControlDashboard1.Show();
         
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DialogResult result = MessageBox.Show("Do You Really Want To Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                timer1.Stop();
                 this.Close();
            }
        }

        private void labeldate_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeldate.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
            labelUsername.Text = Username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovePanel(button1);
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlCheckOut1.Hide();
            userControlFilter1.Hide();
            userControlDashboard1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovePanel(button2);
            userControlClient1.Hide();
            userControlRoom1.Show();
            userControlRoom1.Clear();
            userControlRoom1.PerformLayout();
            userControlCheckOut1.Hide();
            userControlFilter1.Hide();
            userControlDashboard1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MovePanel(button3);
            userControlClient1.Clear();
            userControlClient1.Show();
            userControlRoom1.Hide() ;
            userControlCheckOut1.Hide();
            userControlFilter1.Hide();
            userControlDashboard1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MovePanel(button4);
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlCheckOut1.Show();
            userControlFilter1.Hide();
            userControlDashboard1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MovePanel(button5);
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlCheckOut1.Hide();
            userControlDashboard1.Hide();
            userControlFilter1.Show();
        }

        private void userControlClient1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControlRoom1_Load(object sender, EventArgs e)
        {

        }

        private void userControlCheckOut1_Load(object sender, EventArgs e)
        {

        }

        private void userControlReports1_Load(object sender, EventArgs e)
        {
          
        }

        private void userControlReports1_Load_1(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void userControlDashboard1_Load(object sender, EventArgs e)
        {
            
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlDashboard1.Show();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void guestNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlDashboard1.Hide();
        }

        private void roomAvailableToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userControlFilter1_Load(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roomDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
           roomDetailToolStripMenuItem.Click += new EventHandler(roomDetailToolStripMenuItem_Click);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild formChild = new FormChild();
            formChild.MdiParent = this;
         

       
            int parentWidth = this.ClientSize.Width;
            int parentHeight = this.ClientSize.Height;

            int childWidth = formChild.Width;
            int childHeight = formChild.Height;

            int childX = (parentWidth - childWidth) / 2 + 50;
            int childY = (parentHeight - childHeight) / 2 + 50;

            formChild.StartPosition = FormStartPosition.Manual;
            formChild.Location = new Point(childX, childY);

            formChild.Show();


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild2 formChild = new FormChild2();
            formChild.MdiParent = this;

            int parentWidth = this.ClientSize.Width;
            int parentHeight = this.ClientSize.Height;

            int childWidth = formChild.Width;
            int childHeight = formChild.Height;

            int childX = (parentWidth - childWidth) / 2 + 50;
            int childY = (parentHeight - childHeight) / 2 + 50;

            formChild.StartPosition = FormStartPosition.Manual;
            formChild.Location = new Point(childX, childY);

            formChild.Show();
        }

        private void guestWishlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChildWishlist formChild = new FormChildWishlist();
            formChild.MdiParent = this;

            int parentWidth = this.ClientSize.Width;
            int parentHeight = this.ClientSize.Height;

            int childWidth = formChild.Width;
            int childHeight = formChild.Height;

            int childX = (parentWidth - childWidth) / 2 + 50;
            int childY = (parentHeight - childHeight) / 2 + 50;

            formChild.StartPosition = FormStartPosition.Manual;
            formChild.Location = new Point(childX, childY);

            formChild.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void roomDetailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormChildRoom formChild = new FormChildRoom();
            formChild.MdiParent = this;

            int parentWidth = this.ClientSize.Width;
            int parentHeight = this.ClientSize.Height;

            int childWidth = formChild.Width;
            int childHeight = formChild.Height;

            int childX = (parentWidth - childWidth) / 2 + 50;
            int childY = (parentHeight - childHeight) / 2 + 50;

            formChild.StartPosition = FormStartPosition.Manual;
            formChild.Location = new Point(childX, childY);

            formChild.Show();
        }

        private void notificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
