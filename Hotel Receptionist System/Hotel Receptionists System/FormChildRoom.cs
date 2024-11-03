using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReceptionistsSystem
{
    public partial class FormChildRoom : Form
    {
        public FormChildRoom()
        {
            InitializeComponent();
        }
        private string filePath1 = "C:\\Users\\User\\Documents\\Visual Studio 2022\\HotelReceptionistsSystem\\HotelReceptionistsSystem\\RoomType.txt";
        private string filePath2 = "C:\\Users\\User\\Documents\\Visual Studio 2022\\HotelReceptionistsSystem\\HotelReceptionistsSystem\\RoomPrice.txt";
        private string filePath3 = "C:\\Users\\User\\Documents\\Visual Studio 2022\\HotelReceptionistsSystem\\HotelReceptionistsSystem\\RoomDetail.txt";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly= false;
            textBox2.ReadOnly= false;
            textBox3.ReadOnly= false;
        }

        private void FormChildRoom_Load(object sender, EventArgs e)
        {
            if (File.Exists(filePath1))
            {
                string fileContent1 = File.ReadAllText(filePath1);
                textBox1.Text = fileContent1;
            }

            if (File.Exists(filePath2))
            {
                string fileContent2 = File.ReadAllText(filePath2);
                textBox2.Text = fileContent2;
            }

            if (File.Exists(filePath3))
            {
                string fileContent3 = File.ReadAllText(filePath3);
                textBox3.Text = fileContent3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileContent1 = textBox1.Text;
            File.WriteAllText(filePath1, fileContent1);
            string fileContent2 = textBox2.Text;
            File.WriteAllText(filePath2, fileContent2);
            string fileContent3 = textBox3.Text;
            File.WriteAllText(filePath3, fileContent3);
            MessageBox.Show("Room Detail Updated");

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }
    }
}
