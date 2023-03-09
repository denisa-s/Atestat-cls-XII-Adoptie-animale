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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
            label1.Hide();
            label2.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            label3.Hide();
            
        }
        int pag = 1;
        private void PaginaPrincipalăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pag == 1)
            {
                Form1 f1 = new Form1();
                f1.f17 = this;
                f1.Show();
                this.Hide();
                pag = 0;
            }
            else
            {
                f1.Show();
                this.Hide();
            }
        }
        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click_1(object sender, EventArgs e)
        {
            if (f16.f15.f14.f13.f12.pisica < f16.f15.f14.f13.f12.caine)
            {
                label1.Show();
                label2.Show();
                pictureBox1.Show();
            }
            else
            {
                pictureBox2.Show();
                label2.Show();
                label3.Show();
            }
            pictureBox4.Hide();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
