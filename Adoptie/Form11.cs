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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            pictureBox1.Parent = pictureBox2;
            pictureBox1.BackColor = Color.Transparent;
            label1.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox2;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox2;
            label3.BackColor = Color.Transparent;
        }
        int ct = 1;
        private void ÎnapoiLaPaginaPrincipalăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ct == 1)
            {
                Form1 f1 = new Form1();
                f1.f11 = this;
                f1.Show();
                this.Hide();
                ct = 0;
            }
            else
            {
                f1.Show();
                this.Hide();
            }
        }
        int start = 1;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (start == 1)
            {
                Form12 f12 = new Form12();
                f12.f11 = this;
                f12.Show();
                this.Hide();
                start = 0;
            }
            else
            {
                f12.Show();
                this.Hide();
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
