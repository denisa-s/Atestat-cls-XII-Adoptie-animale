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
    public partial class Form3 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\XII  MI\Proiecte\Proiect de Atestat\Adoptie\Adoptie\Adoptie.accdb");
        OleDbCommand cmd = new OleDbCommand();
        public Form3()
        {
            InitializeComponent();
        }
        private void ÎnapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adoptieDataSet.Vizitator' table. You can move, or remove it, as needed.
            this.vizitatorTableAdapter.Fill(this.adoptieDataSet.Vizitator);
            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.Transparent;
            cmd.Connection = con;
            numeTextBox.Clear();
            prenumeTextBox.Clear();
            cNPTextBox.Clear();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        int x = 1;
        private void InapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                Form2 f2 = new Form2();
                f2.f3 = this;
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

        private void VizitatorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vizitatorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adoptieDataSet);

        }

        private void NumeTextBox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PrenumeTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        public string cnpul;
        private void Button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "insert into vizitator (nume,prenume,cnp) values ('" + numeTextBox.Text + "','" + prenumeTextBox.Text + "','" + cNPTextBox.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Clone();
            con.Close();
            cnpul = Convert.ToString(cNPTextBox.Text);
            Form5 f5 = new Form5(cnpul);
            f5.f3 = this;
            f5.Show();
            this.Hide();
        }

        private void CNPLabel_Click(object sender, EventArgs e)
        {

        }

        private void CNPTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
