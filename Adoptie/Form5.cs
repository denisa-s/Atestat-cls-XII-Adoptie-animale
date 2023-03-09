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
    public partial class Form5 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\XII  MI\Proiecte\Proiect de Atestat\Adoptie\Adoptie\Adoptie.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rd;
        public string cnpul2;
        public Form5(string cnpul)
        {
            InitializeComponent();
            cnpul2 = cnpul;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
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
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();
            pictureBox14.Hide();
            pictureBox15.Hide();
            pictureBox16.Hide();
            pictureBox17.Hide();
            pictureBox18.Hide();
            pictureBox19.Hide();
            pictureBox20.Hide();
            pictureBox22.Hide();
        }
        private void ÎnapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        int ct = 1;
        private void Button2_Click(object sender, EventArgs e)
        {
            if (ct == 1)
            {
                Form7 f7 = new Form7(numar,cnpul2);
                f7.f5 = this;
                f7.Show();
                this.Hide();
                ct = 0;
            }
            else
            {
                f7.Show();
                this.Hide();
            }
        }
        int x = 1;
        private void InapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                Form2 f2 = new Form2();
                f2.f5 = this;
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
        private void NumeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        string a;
        public string numar;
        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            con.Open();
            a = comboBox1.Text;
            cmd.CommandText = "select * from Animal where id=" + a + "";
            rd = cmd.ExecuteReader();
            if (comboBox1.Text == "1")
            { pictureBox1.Show(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "2")
            { pictureBox1.Hide(); pictureBox2.Show(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "3")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Show(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "4")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Show(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "5")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Show(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "6")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Show(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "7")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Show(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "8")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Show(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "9")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Show(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "10")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Show(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "11")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Show(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "12")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Show(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "13")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Show(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "14")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Show(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "15")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Show(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "16")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Show(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "17")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Show(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "18")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Show(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "19")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Show(); pictureBox20.Hide(); pictureBox22.Hide(); }
            if (comboBox1.Text == "20")
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Show(); pictureBox22.Hide(); }
            if (Convert.ToInt32(comboBox1.Text) > 20)
            { pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide(); pictureBox20.Hide(); pictureBox22.Show(); }

            while (rd.Read())
            {
                numeTextBox.Text = rd[1].ToString();
                rasaTextBox.Text = rd[2].ToString();
                numar_cuscaTextBox.Text = rd[3].ToString();
                culoareTextBox.Text = rd[4].ToString();
                varstaTextBox.Text = rd[5].ToString();
                sexulTextBox.Text = rd[6].ToString();
                tipTextBox.Text = rd[7].ToString();
                data_inregistrareDateTimePicker.Text = rd[8].ToString();
                if (rd[8].ToString() == "null")
                { data_inregistrareDateTimePicker.Text= Convert.ToString(DateTime.Today); }
            }
            numar = comboBox1.Text;
            con.Close();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox22_Click(object sender, EventArgs e)
        {

        }

    }
}
