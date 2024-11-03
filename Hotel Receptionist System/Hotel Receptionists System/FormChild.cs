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
    public partial class FormChild : Form
    {
        
        public FormChild()
        {
            InitializeComponent();
        }

        private void FormChild_Load(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.ReadOnly = false;
            textBox.Font = new Font("Century Gothic", 10);
            textBox.Size = new Size(597, 643);
            textBox.Multiline = true;
          
            this.Controls.Add(textBox);

        }
    }
}
