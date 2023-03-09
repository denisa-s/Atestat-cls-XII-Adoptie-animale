using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Adoptie
{
    public partial class Form4 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\XII  MI\Proiecte\Proiect de Atestat\Adoptie\Adoptie\Adoptie.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rd;
        public Form4()
        {
            InitializeComponent();
            
        }

        private void IeșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    
        private void ÎnapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adoptieDataSet.Angajat' table. You can move, or remove it, as needed.
            this.angajatTableAdapter.Fill(this.adoptieDataSet.Angajat);
            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.Transparent;
            cmd.Connection = con;
            utilizatorTextBox.Clear();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="532002" || textBox1.Text=="952001" || textBox1.Text=="8122001")
            {
                Form6 f6 = new Form6();
                f6.f4 = this;
                f6.Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Parolă greșită!"); }
        }
        int x = 1;
        private void InapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                Form2 f2 = new Form2();
                f2.f4 = this;
                f2.Show();
                this.Hide();
                x = 0;
            }
            else
            {
                f2.Show();
                this.Hide();
            }
        }

        private void IesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AngajatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.angajatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adoptieDataSet);

        }

        private void ParolaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "select * from angajat where id=" + comboBox1.Text + " ";
            rd = cmd.ExecuteReader();
            while (rd.Read())
                utilizatorTextBox.Text = rd[1].ToString();
            con.Close();
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UtilizatorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
