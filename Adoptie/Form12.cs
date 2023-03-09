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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
        int urm = 1;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (urm == 1)
            {
                Form13 f13 = new Form13();
                f13.f12 = this;
                f13.Show();
                this.Hide();
                urm = 0;
            }
            else
            {
                f13.Show();
                this.Hide();
            }
        }
        
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        public int caine = 0;
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            caine++;
        }
        public int pisica = 0;
        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pisica++;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
