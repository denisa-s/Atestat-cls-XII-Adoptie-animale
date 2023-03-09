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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             label1.Parent = pictureBox1;
             label1.BackColor = Color.Transparent;
             pictureBox2.Parent = pictureBox1;
             pictureBox2.BackColor = Color.Transparent;
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void IesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int ok = 1;
        private void IntrareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                Form2 f2 = new Form2();
                f2.f1 = this;
                f2.Show();
                this.Hide();
                ok = 0;
            }
            else
            {
                f2.Show();
                this.Hide();
            }
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        int x = 1;
        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                Form8 f8 = new Form8();
                f8.f1 = this;
                f8.Show();
                this.Hide();
                x = 0;
            }
            else
            {
                f8.Show();
                this.Hide();
            }
        }
        int y = 1;
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (y == 1)
            {
                Form9 f9 = new Form9();
                f9.f1 = this;
                f9.Show();
                this.Hide();
                y = 0;
            }
            else
            {
                f9.Show();
                this.Hide();
            }
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        int chestionar = 1;
        private void ChestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chestionar == 1)
            {
                Form11 f11 = new Form11();
                f11.f1 = this;
                f11.Show();
                this.Hide();
                chestionar = 0;
            }
            else
            {
                f11.Show();
                this.Hide();
            }
        }
    }
}
