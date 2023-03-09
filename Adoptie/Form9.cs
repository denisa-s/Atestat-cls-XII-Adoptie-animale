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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            label1.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox2;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox2;
            label3.BackColor = Color.Transparent;
            pictureBox1.Parent = pictureBox2;
            pictureBox1.BackColor = Color.Transparent;
            
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            

        }
        int ct = 1;
        private void InapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ct == 1)
            {
                Form1 f1 = new Form1();
                f1.f9 = this;
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
