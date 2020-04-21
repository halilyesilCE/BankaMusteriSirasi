namespace MusteriTakip
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
            this.btnDaireselKuyruk = new System.Windows.Forms.Button();
            this.btnOncelikKuyruk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDaireselKuyruk
            // 
            this.btnDaireselKuyruk.Location = new System.Drawing.Point(45, 70);
            this.btnDaireselKuyruk.Name = "btnDaireselKuyruk";
            this.btnDaireselKuyruk.Size = new System.Drawing.Size(200, 65);
            this.btnDaireselKuyruk.TabIndex = 0;
            this.btnDaireselKuyruk.Text = "Dairesel Kuyruk";
            this.btnDaireselKuyruk.UseVisualStyleBackColor = true;
            this.btnDaireselKuyruk.Click += new System.EventHandler(this.btnDaireselKuyruk_Click);
            // 
            // btnOncelikKuyruk
            // 
            this.btnOncelikKuyruk.Location = new System.Drawing.Point(45, 197);
            this.btnOncelikKuyruk.Name = "btnOncelikKuyruk";
            this.btnOncelikKuyruk.Size = new System.Drawing.Size(200, 65);
            this.btnOncelikKuyruk.TabIndex = 1;
            this.btnOncelikKuyruk.Text = "Öncelik Kuyruk";
            this.btnOncelikKuyruk.UseVisualStyleBackColor = true;
            this.btnOncelikKuyruk.Click += new System.EventHandler(this.btnOncelikKuyruk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 359);
            this.Controls.Add(this.btnOncelikKuyruk);
            this.Controls.Add(this.btnDaireselKuyruk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDaireselKuyruk;
        private System.Windows.Forms.Button btnOncelikKuyruk;
    }
}

