using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketSatisTakipProgrami
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Müsteriİslemleri form3sec = new Müsteriİslemleri();
            this.Hide();
            form3sec.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urunİslemleri form5sec = new Urunİslemleri();
            this.Hide();
            form5sec.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kasiyerİslemleri form7 = new Kasiyerİslemleri();
            this.Hide();
            form7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stokİslemleri form9 = new Stokİslemleri();
            this.Hide();
            form9.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Satisİslemleri form = new Satisİslemleri();
            this.Hide();
            form.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'marketSatisTakipProgramiDataSet12.Satisİslemleri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.satisİslemleriTableAdapter.Fill(this.marketSatisTakipProgramiDataSet12.Satisİslemleri);

        }
    }
}
