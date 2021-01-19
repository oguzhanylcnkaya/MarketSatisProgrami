namespace MarketSatisTakipProgrami
{
    partial class AnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marketSatisTakipProgramiDataSet12 = new MarketSatisTakipProgrami.MarketSatisTakipProgramiDataSet12();
            this.satisİslemleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satisİslemleriTableAdapter = new MarketSatisTakipProgrami.MarketSatisTakipProgramiDataSet12TableAdapters.SatisİslemleriTableAdapter();
            this.müsteriSiraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcKimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketSatisTakipProgramiDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisİslemleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Müşteri İşlemleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ürün İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(319, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kasiyer İşlemleri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(583, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 66);
            this.button4.TabIndex = 3;
            this.button4.Text = "Stok İşlemleri";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(494, 143);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 66);
            this.button5.TabIndex = 4;
            this.button5.Text = "Satış İşlemleri";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.müsteriSiraDataGridViewTextBoxColumn,
            this.faturaNoDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.tcKimlikDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.satisFiyatiDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.toplamTutarDataGridViewTextBoxColumn,
            this.kasaNoDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.satisİslemleriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 217);
            this.dataGridView1.TabIndex = 5;
            // 
            // marketSatisTakipProgramiDataSet12
            // 
            this.marketSatisTakipProgramiDataSet12.DataSetName = "MarketSatisTakipProgramiDataSet12";
            this.marketSatisTakipProgramiDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satisİslemleriBindingSource
            // 
            this.satisİslemleriBindingSource.DataMember = "Satisİslemleri";
            this.satisİslemleriBindingSource.DataSource = this.marketSatisTakipProgramiDataSet12;
            // 
            // satisİslemleriTableAdapter
            // 
            this.satisİslemleriTableAdapter.ClearBeforeFill = true;
            // 
            // müsteriSiraDataGridViewTextBoxColumn
            // 
            this.müsteriSiraDataGridViewTextBoxColumn.DataPropertyName = "MüsteriSira";
            this.müsteriSiraDataGridViewTextBoxColumn.HeaderText = "MüsteriSira";
            this.müsteriSiraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.müsteriSiraDataGridViewTextBoxColumn.Name = "müsteriSiraDataGridViewTextBoxColumn";
            this.müsteriSiraDataGridViewTextBoxColumn.ReadOnly = true;
            this.müsteriSiraDataGridViewTextBoxColumn.Width = 125;
            // 
            // faturaNoDataGridViewTextBoxColumn
            // 
            this.faturaNoDataGridViewTextBoxColumn.DataPropertyName = "FaturaNo";
            this.faturaNoDataGridViewTextBoxColumn.HeaderText = "FaturaNo";
            this.faturaNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturaNoDataGridViewTextBoxColumn.Name = "faturaNoDataGridViewTextBoxColumn";
            this.faturaNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // tcKimlikDataGridViewTextBoxColumn
            // 
            this.tcKimlikDataGridViewTextBoxColumn.DataPropertyName = "TcKimlik";
            this.tcKimlikDataGridViewTextBoxColumn.HeaderText = "TcKimlik";
            this.tcKimlikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcKimlikDataGridViewTextBoxColumn.Name = "tcKimlikDataGridViewTextBoxColumn";
            this.tcKimlikDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            this.urunAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // satisFiyatiDataGridViewTextBoxColumn
            // 
            this.satisFiyatiDataGridViewTextBoxColumn.DataPropertyName = "SatisFiyati";
            this.satisFiyatiDataGridViewTextBoxColumn.HeaderText = "SatisFiyati";
            this.satisFiyatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satisFiyatiDataGridViewTextBoxColumn.Name = "satisFiyatiDataGridViewTextBoxColumn";
            this.satisFiyatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "Adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.adetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            this.adetDataGridViewTextBoxColumn.Width = 125;
            // 
            // toplamTutarDataGridViewTextBoxColumn
            // 
            this.toplamTutarDataGridViewTextBoxColumn.DataPropertyName = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.HeaderText = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamTutarDataGridViewTextBoxColumn.Name = "toplamTutarDataGridViewTextBoxColumn";
            this.toplamTutarDataGridViewTextBoxColumn.Width = 125;
            // 
            // kasaNoDataGridViewTextBoxColumn
            // 
            this.kasaNoDataGridViewTextBoxColumn.DataPropertyName = "KasaNo";
            this.kasaNoDataGridViewTextBoxColumn.HeaderText = "KasaNo";
            this.kasaNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kasaNoDataGridViewTextBoxColumn.Name = "kasaNoDataGridViewTextBoxColumn";
            this.kasaNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 520);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketSatisTakipProgramiDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisİslemleriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MarketSatisTakipProgramiDataSet12 marketSatisTakipProgramiDataSet12;
        private System.Windows.Forms.BindingSource satisİslemleriBindingSource;
        private MarketSatisTakipProgramiDataSet12TableAdapters.SatisİslemleriTableAdapter satisİslemleriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn müsteriSiraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcKimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
    }
}