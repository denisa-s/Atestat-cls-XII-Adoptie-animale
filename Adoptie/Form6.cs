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
    public partial class Form6 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\XII  MI\Proiecte\Proiect de Atestat\Adoptie\Adoptie\Adoptie.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rd;
        public Form6()
        {
            InitializeComponent();
        }
        private void ÎnapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        int x = 1;
        private void InapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                Form1 f1 = new Form1();
                f1.f6 = this;
                f1.Show();
                this.Hide();
                x = 0;
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

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adoptieDataSet.Fisa_medicala' table. You can move, or remove it, as needed.
            this.fisa_medicalaTableAdapter.Fill(this.adoptieDataSet.Fisa_medicala);
            // TODO: This line of code loads data into the 'adoptieDataSet.Animal' table. You can move, or remove it, as needed.
            this.animalTableAdapter.Fill(this.adoptieDataSet.Animal);
            cmd.Connection = con;
            numeTextBox.Clear();
            rasaTextBox.Clear();
            numar_cuscaTextBox.Clear();
            culoareTextBox.Clear();
            varstaTextBox.Clear();
            sexulTextBox.Clear();
            tipTextBox.Clear();
            iDTextBox.Clear();
            afectiuneTextBox.Clear();
        }

        private void IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "insert into animal (id,nume,rasa,numar_cusca,culoare,varsta,sexul,tip) values (" + iDTextBox.Text + ",'" + numeTextBox.Text + "','" + rasaTextBox.Text + "'," + numar_cuscaTextBox.Text + ",'" + culoareTextBox.Text + "','" + varstaTextBox.Text + "','" + sexulTextBox.Text + "','" + tipTextBox.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Clone();
            con.Close();
            con.Open();
            cmd.CommandText = "insert into fisa_medicala (id,id_animal,afectiune) values (" + iDTextBox.Text + "," + iDTextBox.Text + ",'" + afectiuneTextBox.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Clone();
            con.Close();
            MessageBox.Show("Inserare reușită");
            numeTextBox.Clear();
            rasaTextBox.Clear();
            numar_cuscaTextBox.Clear();
            culoareTextBox.Clear();
            varstaTextBox.Clear();
            sexulTextBox.Clear();
            tipTextBox.Clear();
            iDTextBox.Clear();
            afectiuneTextBox.Clear();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "delete from animal where id= " + comboBox1.Text + "";
            cmd.ExecuteNonQuery();
            cmd.Clone();
            con.Close();
            con.Open();
            cmd.CommandText = "delete from Fisa_medicala where id= " + comboBox1.Text + "";
            cmd.ExecuteNonQuery();
            cmd.Clone();
            con.Close();
            MessageBox.Show("Ștergere reușită");
            numeTextBox.Clear();
            rasaTextBox.Clear();
            numar_cuscaTextBox.Clear();
            culoareTextBox.Clear();
            varstaTextBox.Clear();
            sexulTextBox.Clear();
            tipTextBox.Clear();
            afectiuneTextBox.Clear();
            iDTextBox.Clear();
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        string b;
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            b = comboBox1.Text;
            cmd.CommandText = "select * from Animal where id=" + b + "";
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                iDTextBox.Text = rd[0].ToString();
                numeTextBox.Text = rd[1].ToString();
                rasaTextBox.Text = rd[2].ToString();
                numar_cuscaTextBox.Text = rd[3].ToString();
                culoareTextBox.Text = rd[4].ToString();
                varstaTextBox.Text = rd[5].ToString();
                sexulTextBox.Text = rd[6].ToString();
                tipTextBox.Text = rd[7].ToString();
            }
            con.Close();
            con.Open();
            b = comboBox1.Text;
            cmd.CommandText = "select * from Fisa_medicala where id=" + b + " ";
            rd = cmd.ExecuteReader();
            while (rd.Read())
            afectiuneTextBox.Text = rd[3].ToString();
            con.Close();
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void AfectiuneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
