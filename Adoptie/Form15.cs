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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
         
        }
        int urm = 1;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (urm == 1)
            {
                Form16 f16 = new Form16();
                f16.f15 = this;
                f16.Show();
                this.Hide();
                urm = 0;
            }
            else
            {
                f16.Show();
                this.Hide();
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            f14.f13.f12.caine++;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            f14.f13.f12.pisica++;
        }
    }
}
