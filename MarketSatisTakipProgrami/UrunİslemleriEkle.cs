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
    public partial class UrunİslemleriEkle : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        
        public void Listele()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=MarketSatisTakipProgrami;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select * From Ürünİslemleri", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
        }
        public UrunİslemleriEkle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into Ürünİslemleri (ÜrünAdi,UrunKodu,FirmaAdi, AlişFiyati, SatisFiyati, Kategori) values (@ÜrünAdi,@UrunKodu,@FirmaAdi, @AlişFiyati, @SatisFiyati, @Kategori)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ÜrünAdi", (textBox1.Text));
            komut.Parameters.AddWithValue("@UrunKodu", textBox2.Text);
            komut.Parameters.AddWithValue("@FirmaAdi", textBox5.Text);
            komut.Parameters.AddWithValue("@AlişFiyati", textBox3.Text);
            komut.Parameters.AddWithValue("@SatisFiyati", textBox4.Text);
            komut.Parameters.AddWithValue("@Kategori", textBox6.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();

            MessageBox.Show("Ekleme başarıyla tamamlandı!");
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=GorselProgramlamaOdev;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();

            Listele();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
