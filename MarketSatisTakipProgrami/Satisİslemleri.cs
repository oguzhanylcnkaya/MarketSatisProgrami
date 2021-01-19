using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketSatisTakipProgrami
{
    
    public partial class Satisİslemleri : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public void Listele()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=MarketSatisTakipProgrami;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select * From Stokİslemleri", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
        }
        void tablogoster()
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Ürünİslemleri";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;

            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["ÜrünAdi"]);
                comboBox2.Items.Add(dr["SatisFiyati"]);
            }
            baglanti.Close();

        }

        void tablogoster2()
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Müsteriİslemleri";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;

            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["MüsteriAd"]);
                comboBox4.Items.Add(dr["MüsteriSoyad"]);
                comboBox5.Items.Add(dr["TcKimlik"]);

            }
            baglanti.Close();

        }




        public Satisİslemleri()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'marketSatisTakipProgramiDataSet7.Müsteriİslemleri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.müsteriİslemleriTableAdapter.Fill(this.marketSatisTakipProgramiDataSet7.Müsteriİslemleri);

            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=GorselProgramlamaOdev;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();

            Listele();
            tablogoster();
            tablogoster2();

            



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into Satisİslemleri (FaturaNo, Ad, Soyad, TcKimlik, UrunAdi, SatisFiyati, Adet, ToplamTutar, KasaNo, Tarih) values (@FaturaNo, @Ad, @Soyad, @TcKimlik, @UrunAdi, @SatisFiyati, @Adet, @ToplamTutar, @KasaNo, @Tarih)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@FaturaNo", (textBox1.Text));
            komut.Parameters.AddWithValue("@Ad", (comboBox3.Text));
            komut.Parameters.AddWithValue("@Soyad", (comboBox4.Text));
            komut.Parameters.AddWithValue("@TcKimlik", (comboBox5.Text));
            komut.Parameters.AddWithValue("@UrunAdi", (comboBox1.Text));
            komut.Parameters.AddWithValue("@SatisFiyati", (comboBox2.Text));
            komut.Parameters.AddWithValue("@Adet", (textBox2.Text));
            komut.Parameters.AddWithValue("@ToplamTutar", (textBox3.Text));
            komut.Parameters.AddWithValue("@KasaNo", (textBox4.Text));
            komut.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(dateTimePicker1.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();

            MessageBox.Show("Ekleme başarıyla tamamlandı!");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(comboBox2.Text);
            textBox3.Text = Convert.ToString(a * b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnaSayfa form2sec = new AnaSayfa();
            this.Hide();
            form2sec.Show();
        }
    }
}
