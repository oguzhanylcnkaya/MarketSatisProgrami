using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketSatisTakipProgrami
{
    public partial class GirisSayfasi : Form
    {
        string KullaniciAdi;
        string Sifre;
        public GirisSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciAdi = textBox1.Text;
            Sifre = textBox2.Text;

            if (KullaniciAdi == "admin" && Sifre == "admin")
            {
                MessageBox.Show("Kullanıcı Girişi Başarılı");
                AnaSayfa form2 = new AnaSayfa();
                this.Hide();
                form2.Show();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();
        }

  

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
