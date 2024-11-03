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
    public partial class FormChild2 : Form
    {
        public FormChild2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> textBoxContents = new List<string>(); 
            textBoxContents.Add(textBox5.Text);
            textBoxContents.Add(textBox1.Text);
            textBoxContents.Add(textBox2.Text);
            textBoxContents.Add(textBox3.Text);
            textBoxContents.Add(textBox4.Text);

            string filePath = "C:\\Users\\User\\Documents\\Visual Studio 2022\\HotelReceptionistsSystem\\HotelReceptionistsSystem\\Guest Wishlist.txt";

            string content = string.Join(", ", textBoxContents); 

            File.AppendAllText(filePath, content + Environment.NewLine + Environment.NewLine);

            MessageBox.Show("Wishlist Successfully Added.");

        }

        private void FormChild2_Load(object sender, EventArgs e)
        {

        }
    }
    }
