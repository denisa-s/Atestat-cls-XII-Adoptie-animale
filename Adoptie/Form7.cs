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
    public partial class Form7 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\XII  MI\Proiecte\Proiect de Atestat\Adoptie\Adoptie\Adoptie.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rd;
        public string cnpul3;
        public Form7(string numar, string cnpul2)
        {
            InitializeComponent();
            textBox1.Text = numar;
            cnpul3 = cnpul2;
        }
        int x = 1;
        private void IesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                Form5 f5 = new Form5(cnpul3);
                f5.f7 = this;
                f5.Show();
                this.Hide();
                x = 0;
            }
            else
            {
                f5.Show();
                this.Hide();
            }
        }

        private void IesireToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cerere_AdoptieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cerere_AdoptieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adoptieDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            cmd.Connection = con;
            // TODO: This line of code loads data into the 'adoptieDataSet.Fisa_medicala' table. You can move, or remove it, as needed.
            this.fisa_medicalaTableAdapter.Fill(this.adoptieDataSet.Fisa_medicala);
            // TODO: This line of code loads data into the 'adoptieDataSet.Vizitator' table. You can move, or remove it, as needed.
            this.vizitatorTableAdapter.Fill(this.adoptieDataSet.Vizitator);
            // TODO: This line of code loads data into the 'adoptieDataSet.Cerere_Adoptie' table. You can move, or remove it, as needed.
            this.cerere_AdoptieTableAdapter.Fill(this.adoptieDataSet.Cerere_Adoptie);
            afectiuneTextBox.Clear();
            cNPTextBox.Clear();
            localitateTextBox.Clear();
            telefonTextBox.Clear();
            stradaTextBox.Clear();
            button1.Hide();
            textBox1.Hide();
            afectiuneTextBox.Hide();
            cNPTextBox.Hide();
        }
        int y = 1;
        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "delete from animal where id = "+ textBox1.Text+"";
            cmd.ExecuteNonQuery();
            cmd.Clone();
            con.Close();
            MessageBox.Show("Ai finalizat cu succes adoptia!");
            MessageBox.Show("Te rugăm să te prezinți la adăpostul nostru de pe strada Labradorului numărul 36  în intervalul orar 10:00 - 18:00  pentru a lua prietenul tău acasă.");
            if (y == 1)
            {
                Form1 f1 = new Form1();
                f1.f7 = this;
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
        private void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            textBox1.Show();
            afectiuneTextBox.Show();
            cNPTextBox.Show();
            textBox1.Text = f5.numar;
            cNPTextBox.Text = f5.cnpul2;
            cmd.CommandText = "select * from fisa_medicala where id=" + textBox1.Text + "";
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {   afectiuneTextBox.Text = rd[3].ToString();
                data_afectiuniiDateTimePicker.Text = rd[2].ToString();
                if (afectiuneTextBox.Text == "da")
                { 
                    if (rd[2].ToString() == "null")
                        dataDateTimePicker.Text = Convert.ToString(DateTime.Today);
                    data_afectiuniiDateTimePicker.Show();
                }
                else data_afectiuniiDateTimePicker.Hide();
            }
            con.Close();
        }
        private void AfectiuneLabel_Click(object sender, EventArgs e)
        {

        }

        private void AfectiuneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Data_afectiuniiDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CNPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "insert into cerere_adoptie (id_animal,cnp_stapan) values (" + textBox1.Text + ",'" + cNPTextBox.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Clone();
            con.Close();
            con.Open();
            cmd.CommandText = "update vizitator set localitate= '" + localitateTextBox.Text + "',strada= '" + stradaTextBox.Text + "',telefon= '" + telefonTextBox.Text + "' where (cnp='" + cNPTextBox.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Clone();
            con.Close();
            MessageBox.Show("Inserare reusita!");
            button1.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
