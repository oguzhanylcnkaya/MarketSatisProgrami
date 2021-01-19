using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketSatisTakipProgrami
{
    public partial class StokİslemleriEkle : Form
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

            }
            baglanti.Close();

        }
        public StokİslemleriEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into Stokİslemleri (ÜrünAdi,Adet,BirimFiyat, Kdv, SatisFiyati) values (@ÜrünAdi,@Adet,@BirimFiyat, @Kdv, @SatisFiyati)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ÜrünAdi", (comboBox1.Text));
            komut.Parameters.AddWithValue("@Adet", textBox2.Text);
            komut.Parameters.AddWithValue("@BirimFiyat", textBox3.Text);
            komut.Parameters.AddWithValue("@Kdv", textBox4.Text);
            komut.Parameters.AddWithValue("@SatisFiyati", textBox5.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();

            MessageBox.Show("Ekleme başarıyla tamamlandı!");
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=GorselProgramlamaOdev;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();

            Listele();
            tablogoster();
        }
    }
}
