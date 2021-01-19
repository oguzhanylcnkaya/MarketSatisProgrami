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
    public partial class Stokİslemleri : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        void Listele()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=MarketSatisTakipProgrami;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select * From Stokİslemleri", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
        }
        public Stokİslemleri()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'marketSatisTakipProgramiDataSet11.Stokİslemleri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stokİslemleriTableAdapter2.Fill(this.marketSatisTakipProgramiDataSet11.Stokİslemleri);


            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=MarketSatisTakipProgrami;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();

            Listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokİslemleriEkle form10 = new StokİslemleriEkle();
            form10.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AnaSayfa form2sec = new AnaSayfa();
            this.Hide();
            form2sec.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView1.Update();
            Form9_Load(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From Stokİslemleri Where KayitNo=@KayitNo";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@KayitNo", dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
            MessageBox.Show("Kayıt Silindi!");

            dataGridView1.Refresh();
            dataGridView1.Update();
            Form9_Load(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
