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
    public partial class MüsteriİslemleriEkle : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public void Listele()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=MarketSatisTakipProgrami;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select * From Müsteriİslemleri", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
        }
        public MüsteriİslemleriEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into Müsteriİslemleri (MüsteriAd,MüsteriSoyad,TcKimlik, CepTel, EvTel, Adres) values (@MüsteriAd,@MüsteriSoyad,@TcKimlik, @CepTel, @EvTel, @Adres)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@MüsteriAd", (textBox1.Text));
            komut.Parameters.AddWithValue("@MüsteriSoyad", textBox2.Text);
            komut.Parameters.AddWithValue("@TcKimlik", textBox3.Text);
            komut.Parameters.AddWithValue("@CepTel", textBox4.Text);
            komut.Parameters.AddWithValue("@EvTel", textBox5.Text);
            komut.Parameters.AddWithValue("@Adres", textBox6.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();

            MessageBox.Show("Ekleme başarıyla tamamlandı!");

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=GorselProgramlamaOdev;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();

            Listele();
        }
    }
}
