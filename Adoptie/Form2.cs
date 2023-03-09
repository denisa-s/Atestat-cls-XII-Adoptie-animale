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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
        }
        int ok = 1;
        int x= 1;
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        int ct = 1;
        private void InapoiLaPaginaPrincipalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (ct == 1)
                {
                    Form1 f1 = new Form1();
                    f1.f2 = this;
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

        private void IesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ÎnapoiLaPaginaPrincipalăToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click_1(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                Form3 f3 = new Form3();
                f3.f2 = this;
                f3.Show();
                this.Hide();
                ok = 0;
            }
            else
            {
                f3.Show();
                this.Hide();
            }
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                Form4 f4 = new Form4();
                f4.f2 = this;
                f4.Show();
                this.Hide();
                x = 0;
            }
            else
            {
                f4.Show();
                this.Hide();
            }

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
