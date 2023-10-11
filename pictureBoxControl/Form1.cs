using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureBoxControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Visible = false;

        }

        int brojac = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            if (brojac == 0)
            {
                pictureBox1.Visible = true;
                brojac++;
            }

            else if(brojac == 1)
            {
                pictureBox1.Visible = false;

                brojac = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
