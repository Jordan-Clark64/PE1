using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save button has been clicked");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Load button has been clicked");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete button has been clicked");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Dragon thanks thee for clicking on him");
        }
    }
}
