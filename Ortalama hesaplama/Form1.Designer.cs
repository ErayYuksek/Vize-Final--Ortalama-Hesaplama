namespace Ortalama_hesaplama
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtortalama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdurum = new System.Windows.Forms.TextBox();
            this.btnkayıt = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lstboxclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(587, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(457, 308);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ad soyad";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(206, 135);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(100, 22);
            this.txtadsoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(72, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "vize";
            // 
            // txtvize
            // 
            this.txtvize.Location = new System.Drawing.Point(206, 206);
            this.txtvize.Name = "txtvize";
            this.txtvize.Size = new System.Drawing.Size(100, 22);
            this.txtvize.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(72, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "final";
            // 
            // txtfinal
            // 
            this.txtfinal.Location = new System.Drawing.Point(206, 270);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.Size = new System.Drawing.Size(100, 22);
            this.txtfinal.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(76, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "ortalma";
            // 
            // txtortalama
            // 
            this.txtortalama.Location = new System.Drawing.Point(206, 390);
            this.txtortalama.Name = "txtortalama";
            this.txtortalama.Size = new System.Drawing.Size(100, 22);
            this.txtortalama.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(76, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Durum";
            // 
            // txtdurum
            // 
            this.txtdurum.Location = new System.Drawing.Point(206, 337);
            this.txtdurum.Name = "txtdurum";
            this.txtdurum.Size = new System.Drawing.Size(100, 22);
            this.txtdurum.TabIndex = 3;
            // 
            // btnkayıt
            // 
            this.btnkayıt.Location = new System.Drawing.Point(371, 210);
            this.btnkayıt.Name = "btnkayıt";
            this.btnkayıt.Size = new System.Drawing.Size(132, 43);
            this.btnkayıt.TabIndex = 4;
            this.btnkayıt.Text = "Kayıt";
            this.btnkayıt.UseVisualStyleBackColor = true;
            this.btnkayıt.Click += new System.EventHandler(this.btnkayıt_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(371, 269);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(75, 23);
            this.btntemizle.TabIndex = 5;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(402, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(401, 52);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ortalama Hesapla";
            // 
            // lstboxclear
            // 
            this.lstboxclear.Location = new System.Drawing.Point(932, 467);
            this.lstboxclear.Name = "lstboxclear";
            this.lstboxclear.Size = new System.Drawing.Size(112, 23);
            this.lstboxclear.TabIndex = 6;
            this.lstboxclear.Text = "kayıtları Sil";
            this.lstboxclear.UseVisualStyleBackColor = true;
            this.lstboxclear.Click += new System.EventHandler(this.lstboxclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1075, 565);
            this.Controls.Add(this.lstboxclear);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnkayıt);
            this.Controls.Add(this.txtdurum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtortalama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtvize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtortalama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdurum;
        private System.Windows.Forms.Button btnkayıt;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button lstboxclear;
    }
}

