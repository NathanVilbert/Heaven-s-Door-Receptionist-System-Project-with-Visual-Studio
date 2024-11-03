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
    public partial class FormChildWishlist : Form
    {
        public FormChildWishlist()
        {
            InitializeComponent();
        }

        private void FormChildWishlist_Load(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\User\\Documents\\Visual Studio 2022\\HotelReceptionistsSystem\\HotelReceptionistsSystem\\Guest Wishlist.txt";

            string[] fileLines = File.ReadAllLines(filePath);

            foreach (string line in fileLines)
            {
        
                textBox1.AppendText(line + Environment.NewLine);
            }
        }
    }
}
