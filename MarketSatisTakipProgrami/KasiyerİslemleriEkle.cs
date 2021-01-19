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
    public partial class KasiyerİslemleriEkle : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public void Listele()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=MarketSatisTakipProgrami;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select * From KasiyerEkleme", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
        }
        public KasiyerİslemleriEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into KasiyerEkleme (Adi,Soyadi,TcKimlik, CepTel, EvTel, Adres, Maas, GörevKasa, BasTarihi, BitTarihi) values (@Adi,@Soyadi,@TcKimlik, @CepTel, @EvTel, @Adres, @Maas, @GörevKasa, @BasTarihi, @BitTarihi)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Adi", (textBox1.Text));
            komut.Parameters.AddWithValue("@Soyadi", textBox2.Text);
            komut.Parameters.AddWithValue("@TcKimlik", textBox3.Text);
            komut.Parameters.AddWithValue("@CepTel", textBox4.Text);
            komut.Parameters.AddWithValue("@EvTel", textBox5.Text);
            komut.Parameters.AddWithValue("@Adres", textBox6.Text);
            komut.Parameters.AddWithValue("@Maas", textBox7.Text);
            komut.Parameters.AddWithValue("@GörevKasa", textBox8.Text);
            komut.Parameters.AddWithValue("@BasTarihi", Convert.ToDateTime(dateTimePicker1.Text));
            komut.Parameters.AddWithValue("@BitTarihi", Convert.ToDateTime(dateTimePicker2.Text));
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

        private void Form8_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=GorselProgramlamaOdev;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();

            Listele();
        }
    }
}
