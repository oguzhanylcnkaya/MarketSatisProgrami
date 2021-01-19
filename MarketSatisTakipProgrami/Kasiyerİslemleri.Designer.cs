namespace MarketSatisTakipProgrami
{
    partial class Kasiyerİslemleri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kayitNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcKimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.görevKasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasiyerEklemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketSatisTakipProgramiDataSet2 = new MarketSatisTakipProgrami.MarketSatisTakipProgramiDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.kasiyerEklemeTableAdapter = new MarketSatisTakipProgrami.MarketSatisTakipProgramiDataSet2TableAdapters.KasiyerEklemeTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerEklemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketSatisTakipProgramiDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kayitNoDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.tcKimlikDataGridViewTextBoxColumn,
            this.cepTelDataGridViewTextBoxColumn,
            this.evTelDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.maasDataGridViewTextBoxColumn,
            this.görevKasaDataGridViewTextBoxColumn,
            this.basTarihiDataGridViewTextBoxColumn,
            this.bitTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kasiyerEklemeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(993, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // kayitNoDataGridViewTextBoxColumn
            // 
            this.kayitNoDataGridViewTextBoxColumn.DataPropertyName = "KayitNo";
            this.kayitNoDataGridViewTextBoxColumn.HeaderText = "KayitNo";
            this.kayitNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayitNoDataGridViewTextBoxColumn.Name = "kayitNoDataGridViewTextBoxColumn";
            this.kayitNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.kayitNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // adiDataGridViewTextBoxColumn
            // 
            this.adiDataGridViewTextBoxColumn.DataPropertyName = "Adi";
            this.adiDataGridViewTextBoxColumn.HeaderText = "Adi";
            this.adiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
            this.adiDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadiDataGridViewTextBoxColumn
            // 
            this.soyadiDataGridViewTextBoxColumn.DataPropertyName = "Soyadi";
            this.soyadiDataGridViewTextBoxColumn.HeaderText = "Soyadi";
            this.soyadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadiDataGridViewTextBoxColumn.Name = "soyadiDataGridViewTextBoxColumn";
            this.soyadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tcKimlikDataGridViewTextBoxColumn
            // 
            this.tcKimlikDataGridViewTextBoxColumn.DataPropertyName = "TcKimlik";
            this.tcKimlikDataGridViewTextBoxColumn.HeaderText = "TcKimlik";
            this.tcKimlikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcKimlikDataGridViewTextBoxColumn.Name = "tcKimlikDataGridViewTextBoxColumn";
            this.tcKimlikDataGridViewTextBoxColumn.Width = 125;
            // 
            // cepTelDataGridViewTextBoxColumn
            // 
            this.cepTelDataGridViewTextBoxColumn.DataPropertyName = "CepTel";
            this.cepTelDataGridViewTextBoxColumn.HeaderText = "CepTel";
            this.cepTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cepTelDataGridViewTextBoxColumn.Name = "cepTelDataGridViewTextBoxColumn";
            this.cepTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // evTelDataGridViewTextBoxColumn
            // 
            this.evTelDataGridViewTextBoxColumn.DataPropertyName = "EvTel";
            this.evTelDataGridViewTextBoxColumn.HeaderText = "EvTel";
            this.evTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evTelDataGridViewTextBoxColumn.Name = "evTelDataGridViewTextBoxColumn";
            this.evTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // maasDataGridViewTextBoxColumn
            // 
            this.maasDataGridViewTextBoxColumn.DataPropertyName = "Maas";
            this.maasDataGridViewTextBoxColumn.HeaderText = "Maas";
            this.maasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maasDataGridViewTextBoxColumn.Name = "maasDataGridViewTextBoxColumn";
            this.maasDataGridViewTextBoxColumn.Width = 125;
            // 
            // görevKasaDataGridViewTextBoxColumn
            // 
            this.görevKasaDataGridViewTextBoxColumn.DataPropertyName = "GörevKasa";
            this.görevKasaDataGridViewTextBoxColumn.HeaderText = "GörevKasa";
            this.görevKasaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.görevKasaDataGridViewTextBoxColumn.Name = "görevKasaDataGridViewTextBoxColumn";
            this.görevKasaDataGridViewTextBoxColumn.Width = 125;
            // 
            // basTarihiDataGridViewTextBoxColumn
            // 
            this.basTarihiDataGridViewTextBoxColumn.DataPropertyName = "BasTarihi";
            this.basTarihiDataGridViewTextBoxColumn.HeaderText = "BasTarihi";
            this.basTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.basTarihiDataGridViewTextBoxColumn.Name = "basTarihiDataGridViewTextBoxColumn";
            this.basTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // bitTarihiDataGridViewTextBoxColumn
            // 
            this.bitTarihiDataGridViewTextBoxColumn.DataPropertyName = "BitTarihi";
            this.bitTarihiDataGridViewTextBoxColumn.HeaderText = "BitTarihi";
            this.bitTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bitTarihiDataGridViewTextBoxColumn.Name = "bitTarihiDataGridViewTextBoxColumn";
            this.bitTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kasiyerEklemeBindingSource
            // 
            this.kasiyerEklemeBindingSource.DataMember = "KasiyerEkleme";
            this.kasiyerEklemeBindingSource.DataSource = this.marketSatisTakipProgramiDataSet2;
            // 
            // marketSatisTakipProgramiDataSet2
            // 
            this.marketSatisTakipProgramiDataSet2.DataSetName = "MarketSatisTakipProgramiDataSet2";
            this.marketSatisTakipProgramiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kasiyerEklemeTableAdapter
            // 
            this.kasiyerEklemeTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 76);
            this.button2.TabIndex = 2;
            this.button2.Text = "Yenile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(556, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 77);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(728, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 79);
            this.button4.TabIndex = 4;
            this.button4.Text = "Kapat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "Geri Çık ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1042, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerEklemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketSatisTakipProgramiDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private MarketSatisTakipProgramiDataSet2 marketSatisTakipProgramiDataSet2;
        private System.Windows.Forms.BindingSource kasiyerEklemeBindingSource;
        private MarketSatisTakipProgramiDataSet2TableAdapters.KasiyerEklemeTableAdapter kasiyerEklemeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcKimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn görevKasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}