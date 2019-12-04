namespace Kumeleme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_yonetim = new System.Windows.Forms.GroupBox();
            this.groupBox_cizim = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adet = new System.Windows.Forms.TextBox();
            this.rastgele_nokta_ekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kume_sayisi = new System.Windows.Forms.NumericUpDown();
            this.calistir = new System.Windows.Forms.Button();
            this.istatistikler = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_yonetim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kume_sayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_yonetim
            // 
            this.groupBox_yonetim.Controls.Add(this.label3);
            this.groupBox_yonetim.Controls.Add(this.istatistikler);
            this.groupBox_yonetim.Controls.Add(this.calistir);
            this.groupBox_yonetim.Controls.Add(this.kume_sayisi);
            this.groupBox_yonetim.Controls.Add(this.label2);
            this.groupBox_yonetim.Controls.Add(this.rastgele_nokta_ekle);
            this.groupBox_yonetim.Controls.Add(this.adet);
            this.groupBox_yonetim.Controls.Add(this.label1);
            this.groupBox_yonetim.Location = new System.Drawing.Point(12, 12);
            this.groupBox_yonetim.Name = "groupBox_yonetim";
            this.groupBox_yonetim.Size = new System.Drawing.Size(200, 426);
            this.groupBox_yonetim.TabIndex = 0;
            this.groupBox_yonetim.TabStop = false;
            this.groupBox_yonetim.Text = "Yönetim";
            // 
            // groupBox_cizim
            // 
            this.groupBox_cizim.Location = new System.Drawing.Point(218, 12);
            this.groupBox_cizim.Name = "groupBox_cizim";
            this.groupBox_cizim.Size = new System.Drawing.Size(570, 426);
            this.groupBox_cizim.TabIndex = 1;
            this.groupBox_cizim.TabStop = false;
            this.groupBox_cizim.Text = "Çizim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adet: ";
            // 
            // adet
            // 
            this.adet.Location = new System.Drawing.Point(47, 19);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(147, 20);
            this.adet.TabIndex = 3;
            // 
            // rastgele_nokta_ekle
            // 
            this.rastgele_nokta_ekle.Location = new System.Drawing.Point(9, 45);
            this.rastgele_nokta_ekle.Name = "rastgele_nokta_ekle";
            this.rastgele_nokta_ekle.Size = new System.Drawing.Size(185, 23);
            this.rastgele_nokta_ekle.TabIndex = 4;
            this.rastgele_nokta_ekle.Text = "Rastgele Nokta Ekle";
            this.rastgele_nokta_ekle.UseVisualStyleBackColor = true;
            this.rastgele_nokta_ekle.Click += new System.EventHandler(this.rastgele_nokta_ekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Küme Sayısı";
            // 
            // kume_sayisi
            // 
            this.kume_sayisi.Location = new System.Drawing.Point(74, 86);
            this.kume_sayisi.Name = "kume_sayisi";
            this.kume_sayisi.Size = new System.Drawing.Size(120, 20);
            this.kume_sayisi.TabIndex = 6;
            // 
            // calistir
            // 
            this.calistir.Location = new System.Drawing.Point(9, 113);
            this.calistir.Name = "calistir";
            this.calistir.Size = new System.Drawing.Size(185, 52);
            this.calistir.TabIndex = 7;
            this.calistir.Text = "Çalıştır";
            this.calistir.UseVisualStyleBackColor = true;
            // 
            // istatistikler
            // 
            this.istatistikler.HideSelection = false;
            this.istatistikler.Location = new System.Drawing.Point(9, 184);
            this.istatistikler.Name = "istatistikler";
            this.istatistikler.Size = new System.Drawing.Size(185, 236);
            this.istatistikler.TabIndex = 8;
            this.istatistikler.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "İSTATİSTİKLER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_cizim);
            this.Controls.Add(this.groupBox_yonetim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_yonetim.ResumeLayout(false);
            this.groupBox_yonetim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kume_sayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_yonetim;
        private System.Windows.Forms.GroupBox groupBox_cizim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView istatistikler;
        private System.Windows.Forms.Button calistir;
        private System.Windows.Forms.NumericUpDown kume_sayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rastgele_nokta_ekle;
        private System.Windows.Forms.TextBox adet;
        private System.Windows.Forms.Label label1;
    }
}

