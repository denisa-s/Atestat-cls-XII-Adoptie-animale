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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        int urm = 1;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (urm == 1)
            {
                Form17 f17 = new Form17();
                f17.f16 = this;
                f17.Show();
                this.Hide();
                urm = 0;
            }
            else
            {
                f17.Show();
                this.Hide();
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            f15.f14.f13.f12.caine++;
        }
        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            f15.f14.f13.f12.pisica++;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
