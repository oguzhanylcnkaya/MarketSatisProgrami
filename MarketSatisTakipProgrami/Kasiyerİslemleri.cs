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
    public partial class Kasiyerİslemleri : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        void Listele()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=MarketSatisTakipProgrami;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select * From KasiyerEkleme", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
        }
        public Kasiyerİslemleri()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'marketSatisTakipProgramiDataSet2.KasiyerEkleme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kasiyerEklemeTableAdapter.Fill(this.marketSatisTakipProgramiDataSet2.KasiyerEkleme);

            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=MarketSatisTakipProgrami;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();

            Listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KasiyerİslemleriEkle form8 = new KasiyerİslemleriEkle();
            form8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView1.Update();
            Form7_Load(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From KasiyerEkleme Where KayitNo=@KayitNo";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@KayitNo", dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
            MessageBox.Show("Kayıt Silindi!");

            dataGridView1.Refresh();
            dataGridView1.Update();
            Form7_Load(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AnaSayfa form2sec = new AnaSayfa();
            this.Hide();
            form2sec.Show();
        }
    }
}
