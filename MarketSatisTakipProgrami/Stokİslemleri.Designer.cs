namespace MarketSatisTakipProgrami
{
    partial class Stokİslemleri
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
            this.stokİslemleriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.marketSatisTakipProgramiDataSet9 = new MarketSatisTakipProgrami.MarketSatisTakipProgramiDataSet9();
            this.stokİslemleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketSatisTakipProgramiDataSet3 = new MarketSatisTakipProgrami.MarketSatisTakipProgramiDataSet3();
            this.stokİslemleriTableAdapter = new MarketSatisTakipProgrami.MarketSatisTakipProgramiDataSet3TableAdapters.StokİslemleriTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.stokİslemleriTableAdapter1 = new MarketSatisTakipProgrami.MarketSatisTakipProgramiDataSet9TableAdapters.StokİslemleriTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokİslemleriBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.marketSatisTakipProgramiDataSet11 = new MarketSatisTakipProgrami.MarketSatisTakipProgramiDataSet11();
            this.stokİslemleriTableAdapter2 = new MarketSatisTakipProgrami.MarketSatisTakipProgramiDataSet11TableAdapters.StokİslemleriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stokİslemleriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketSatisTakipProgramiDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokİslemleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketSatisTakipProgramiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokİslemleriBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketSatisTakipProgramiDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // stokİslemleriBindingSource1
            // 
            this.stokİslemleriBindingSource1.DataMember = "Stokİslemleri";
            this.stokİslemleriBindingSource1.DataSource = this.marketSatisTakipProgramiDataSet9;
            // 
            // marketSatisTakipProgramiDataSet9
            // 
            this.marketSatisTakipProgramiDataSet9.DataSetName = "MarketSatisTakipProgramiDataSet9";
            this.marketSatisTakipProgramiDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokİslemleriBindingSource
            // 
            this.stokİslemleriBindingSource.DataMember = "Stokİslemleri";
            this.stokİslemleriBindingSource.DataSource = this.marketSatisTakipProgramiDataSet3;
            // 
            // marketSatisTakipProgramiDataSet3
            // 
            this.marketSatisTakipProgramiDataSet3.DataSetName = "MarketSatisTakipProgramiDataSet3";
            this.marketSatisTakipProgramiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokİslemleriTableAdapter
            // 
            this.stokİslemleriTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 85);
            this.button2.TabIndex = 2;
            this.button2.Text = "Yenile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(471, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 85);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(632, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 85);
            this.button4.TabIndex = 4;
            this.button4.Text = "Kapat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 33);
            this.button5.TabIndex = 5;
            this.button5.Text = "Geri Çık";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // stokİslemleriTableAdapter1
            // 
            this.stokİslemleriTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunNoDataGridViewTextBoxColumn,
            this.ürünAdiDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.birimFiyatDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn,
            this.satisFiyatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stokİslemleriBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(815, 148);
            this.dataGridView1.TabIndex = 6;
            // 
            // urunNoDataGridViewTextBoxColumn
            // 
            this.urunNoDataGridViewTextBoxColumn.DataPropertyName = "UrunNo";
            this.urunNoDataGridViewTextBoxColumn.HeaderText = "UrunNo";
            this.urunNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunNoDataGridViewTextBoxColumn.Name = "urunNoDataGridViewTextBoxColumn";
            this.urunNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünAdiDataGridViewTextBoxColumn
            // 
            this.ürünAdiDataGridViewTextBoxColumn.DataPropertyName = "ÜrünAdi";
            this.ürünAdiDataGridViewTextBoxColumn.HeaderText = "ÜrünAdi";
            this.ürünAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünAdiDataGridViewTextBoxColumn.Name = "ürünAdiDataGridViewTextBoxColumn";
            this.ürünAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "Adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.adetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            this.adetDataGridViewTextBoxColumn.Width = 125;
            // 
            // birimFiyatDataGridViewTextBoxColumn
            // 
            this.birimFiyatDataGridViewTextBoxColumn.DataPropertyName = "BirimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.HeaderText = "BirimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birimFiyatDataGridViewTextBoxColumn.Name = "birimFiyatDataGridViewTextBoxColumn";
            this.birimFiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // kdvDataGridViewTextBoxColumn
            // 
            this.kdvDataGridViewTextBoxColumn.DataPropertyName = "Kdv";
            this.kdvDataGridViewTextBoxColumn.HeaderText = "Kdv";
            this.kdvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kdvDataGridViewTextBoxColumn.Name = "kdvDataGridViewTextBoxColumn";
            this.kdvDataGridViewTextBoxColumn.Width = 125;
            // 
            // satisFiyatiDataGridViewTextBoxColumn
            // 
            this.satisFiyatiDataGridViewTextBoxColumn.DataPropertyName = "SatisFiyati";
            this.satisFiyatiDataGridViewTextBoxColumn.HeaderText = "SatisFiyati";
            this.satisFiyatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satisFiyatiDataGridViewTextBoxColumn.Name = "satisFiyatiDataGridViewTextBoxColumn";
            this.satisFiyatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokİslemleriBindingSource2
            // 
            this.stokİslemleriBindingSource2.DataMember = "Stokİslemleri";
            this.stokİslemleriBindingSource2.DataSource = this.marketSatisTakipProgramiDataSet11;
            // 
            // marketSatisTakipProgramiDataSet11
            // 
            this.marketSatisTakipProgramiDataSet11.DataSetName = "MarketSatisTakipProgramiDataSet11";
            this.marketSatisTakipProgramiDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokİslemleriTableAdapter2
            // 
            this.stokİslemleriTableAdapter2.ClearBeforeFill = true;
            // 
            // Stokİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Stokİslemleri";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stokİslemleriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketSatisTakipProgramiDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokİslemleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketSatisTakipProgramiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokİslemleriBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketSatisTakipProgramiDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MarketSatisTakipProgramiDataSet3 marketSatisTakipProgramiDataSet3;
        private System.Windows.Forms.BindingSource stokİslemleriBindingSource;
        private MarketSatisTakipProgramiDataSet3TableAdapters.StokİslemleriTableAdapter stokİslemleriTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private MarketSatisTakipProgramiDataSet9 marketSatisTakipProgramiDataSet9;
        private System.Windows.Forms.BindingSource stokİslemleriBindingSource1;
        private MarketSatisTakipProgramiDataSet9TableAdapters.StokİslemleriTableAdapter stokİslemleriTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MarketSatisTakipProgramiDataSet11 marketSatisTakipProgramiDataSet11;
        private System.Windows.Forms.BindingSource stokİslemleriBindingSource2;
        private MarketSatisTakipProgramiDataSet11TableAdapters.StokİslemleriTableAdapter stokİslemleriTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisFiyatiDataGridViewTextBoxColumn;
    }
}