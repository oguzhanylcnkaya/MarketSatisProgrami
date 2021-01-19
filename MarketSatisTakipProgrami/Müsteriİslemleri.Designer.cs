namespace MarketSatisTakipProgrami
{
    partial class Müsteriİslemleri
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
            this.müsteriAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müsteriSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcKimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müsteriİslemleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketSatisTakipProgramiDataSet = new MarketSatisTakipProgrami.MarketSatisTakipProgramiDataSet();
            this.müsteriİslemleriTableAdapter = new MarketSatisTakipProgrami.MarketSatisTakipProgramiDataSetTableAdapters.MüsteriİslemleriTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsteriİslemleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketSatisTakipProgramiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kayitNoDataGridViewTextBoxColumn,
            this.müsteriAdDataGridViewTextBoxColumn,
            this.müsteriSoyadDataGridViewTextBoxColumn,
            this.tcKimlikDataGridViewTextBoxColumn,
            this.cepTelDataGridViewTextBoxColumn,
            this.evTelDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.müsteriİslemleriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(938, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kayitNoDataGridViewTextBoxColumn
            // 
            this.kayitNoDataGridViewTextBoxColumn.DataPropertyName = "KayitNo";
            this.kayitNoDataGridViewTextBoxColumn.HeaderText = "KayitNo";
            this.kayitNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayitNoDataGridViewTextBoxColumn.Name = "kayitNoDataGridViewTextBoxColumn";
            this.kayitNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // müsteriAdDataGridViewTextBoxColumn
            // 
            this.müsteriAdDataGridViewTextBoxColumn.DataPropertyName = "MüsteriAd";
            this.müsteriAdDataGridViewTextBoxColumn.HeaderText = "MüsteriAd";
            this.müsteriAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.müsteriAdDataGridViewTextBoxColumn.Name = "müsteriAdDataGridViewTextBoxColumn";
            this.müsteriAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // müsteriSoyadDataGridViewTextBoxColumn
            // 
            this.müsteriSoyadDataGridViewTextBoxColumn.DataPropertyName = "MüsteriSoyad";
            this.müsteriSoyadDataGridViewTextBoxColumn.HeaderText = "MüsteriSoyad";
            this.müsteriSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.müsteriSoyadDataGridViewTextBoxColumn.Name = "müsteriSoyadDataGridViewTextBoxColumn";
            this.müsteriSoyadDataGridViewTextBoxColumn.Width = 125;
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
            // müsteriİslemleriBindingSource
            // 
            this.müsteriİslemleriBindingSource.DataMember = "Müsteriİslemleri";
            this.müsteriİslemleriBindingSource.DataSource = this.marketSatisTakipProgramiDataSet;
            // 
            // marketSatisTakipProgramiDataSet
            // 
            this.marketSatisTakipProgramiDataSet.DataSetName = "MarketSatisTakipProgramiDataSet";
            this.marketSatisTakipProgramiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // müsteriİslemleriTableAdapter
            // 
            this.müsteriİslemleriTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "Yenile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(500, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 69);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(669, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 69);
            this.button4.TabIndex = 4;
            this.button4.Text = "Kapat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "Geri Çık ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(994, 514);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsteriİslemleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketSatisTakipProgramiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MarketSatisTakipProgramiDataSet marketSatisTakipProgramiDataSet;
        private System.Windows.Forms.BindingSource müsteriİslemleriBindingSource;
        private MarketSatisTakipProgramiDataSetTableAdapters.MüsteriİslemleriTableAdapter müsteriİslemleriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müsteriAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müsteriSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcKimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}