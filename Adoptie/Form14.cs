using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adoptie
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }
        int urm = 1;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (urm == 1)
            {
                Form15 f15 = new Form15();
                f15.f14 = this;
                f15.Show();
                this.Hide();
                urm = 0;
            }
            else
            {
                f15.Show();
                this.Hide();
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            f13.f12.caine++;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            f13.f12.pisica++;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
