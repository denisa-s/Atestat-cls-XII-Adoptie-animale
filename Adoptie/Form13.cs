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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        int urm = 1;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (urm == 1)
            {
                Form14 f14 = new Form14();
                f14.f13 = this;
                f14.Show();
                this.Hide();
                urm = 0;
            }
            else
            {
                f14.Show();
                this.Hide();
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            f12.caine++;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            f12.pisica++;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
