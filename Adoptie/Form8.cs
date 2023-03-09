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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            pictureBox1.Parent = pictureBox2;
            pictureBox1.BackColor = Color.Transparent;
            label1.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox2;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox2;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox2;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox2;
            label5.BackColor = Color.Transparent;
            label6.Parent = pictureBox2;
            label6.BackColor = Color.Transparent;
            label7.Parent = pictureBox2;
            label7.BackColor = Color.Transparent;
            label8.Parent = pictureBox2;
            label8.BackColor = Color.Transparent;
            label9.Parent = pictureBox2;
            label9.BackColor = Color.Transparent;
            label10.Parent = pictureBox2;
            label10.BackColor = Color.Transparent;
            label11.Parent = pictureBox2;
            label11.BackColor = Color.Transparent;
        }
        int ct = 1;
        private void InapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ct == 1)
            {
                Form1 f1 = new Form1();
                f1.f8 = this;
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

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
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
