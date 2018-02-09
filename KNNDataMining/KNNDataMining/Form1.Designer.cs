namespace KNNDataMining
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
            this.btnOku = new System.Windows.Forms.Button();
            this.KNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FalseNegative_label10 = new System.Windows.Forms.Label();
            this.FalsePositive_label = new System.Windows.Forms.Label();
            this.TrueNegative_label = new System.Windows.Forms.Label();
            this.TruePositive_label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Dogruluk_textBox5 = new System.Windows.Forms.TextBox();
            this.fOlcutu_textBox6 = new System.Windows.Forms.TextBox();
            this.Duyarlik_textBox7 = new System.Windows.Forms.TextBox();
            this.Kesinlik_textBox8 = new System.Windows.Forms.TextBox();
            this.HataOrani_textBox9 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.KNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(25, 436);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(161, 46);
            this.btnOku.TabIndex = 0;
            this.btnOku.Text = "Test";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // KNumber
            // 
            this.KNumber.Location = new System.Drawing.Point(237, 462);
            this.KNumber.Name = "KNumber";
            this.KNumber.Size = new System.Drawing.Size(84, 20);
            this.KNumber.TabIndex = 1;
            this.KNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.KNumber.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "K sayısını seçiniz";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 372);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(410, 418);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "4";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(410, 462);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "5";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(581, 422);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "KOTU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ozellik 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ozellik 2";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tahmin Edilen Sınıf";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(581, 462);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(60, 20);
            this.textBox4.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hesaplanan Sınıf";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.FalseNegative_label10);
            this.groupBox1.Controls.Add(this.FalsePositive_label);
            this.groupBox1.Controls.Add(this.TrueNegative_label);
            this.groupBox1.Controls.Add(this.TruePositive_label4);
            this.groupBox1.Location = new System.Drawing.Point(557, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 137);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Karmaşıklık Tablosu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(19, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(19, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(128, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(67, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "1";
            // 
            // FalseNegative_label10
            // 
            this.FalseNegative_label10.AutoSize = true;
            this.FalseNegative_label10.Location = new System.Drawing.Point(126, 99);
            this.FalseNegative_label10.Name = "FalseNegative_label10";
            this.FalseNegative_label10.Size = new System.Drawing.Size(21, 13);
            this.FalseNegative_label10.TabIndex = 3;
            this.FalseNegative_label10.Text = "FN";
            // 
            // FalsePositive_label
            // 
            this.FalsePositive_label.AutoSize = true;
            this.FalsePositive_label.Location = new System.Drawing.Point(69, 99);
            this.FalsePositive_label.Name = "FalsePositive_label";
            this.FalsePositive_label.Size = new System.Drawing.Size(20, 13);
            this.FalsePositive_label.TabIndex = 2;
            this.FalsePositive_label.Text = "FP";
            // 
            // TrueNegative_label
            // 
            this.TrueNegative_label.AutoSize = true;
            this.TrueNegative_label.Location = new System.Drawing.Point(125, 55);
            this.TrueNegative_label.Name = "TrueNegative_label";
            this.TrueNegative_label.Size = new System.Drawing.Size(22, 13);
            this.TrueNegative_label.TabIndex = 1;
            this.TrueNegative_label.Text = "TN";
            // 
            // TruePositive_label4
            // 
            this.TruePositive_label4.AutoSize = true;
            this.TruePositive_label4.Location = new System.Drawing.Point(69, 53);
            this.TruePositive_label4.Name = "TruePositive_label4";
            this.TruePositive_label4.Size = new System.Drawing.Size(21, 13);
            this.TruePositive_label4.TabIndex = 0;
            this.TruePositive_label4.Text = "TP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Doğruluk:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "F Ölçütü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Duyarlık:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(561, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Kesinlik:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(546, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Hata Oranı:";
            // 
            // Dogruluk_textBox5
            // 
            this.Dogruluk_textBox5.Location = new System.Drawing.Point(613, 199);
            this.Dogruluk_textBox5.Name = "Dogruluk_textBox5";
            this.Dogruluk_textBox5.Size = new System.Drawing.Size(100, 20);
            this.Dogruluk_textBox5.TabIndex = 20;
            // 
            // fOlcutu_textBox6
            // 
            this.fOlcutu_textBox6.Location = new System.Drawing.Point(613, 324);
            this.fOlcutu_textBox6.Name = "fOlcutu_textBox6";
            this.fOlcutu_textBox6.Size = new System.Drawing.Size(100, 20);
            this.fOlcutu_textBox6.TabIndex = 21;
            // 
            // Duyarlik_textBox7
            // 
            this.Duyarlik_textBox7.Location = new System.Drawing.Point(613, 293);
            this.Duyarlik_textBox7.Name = "Duyarlik_textBox7";
            this.Duyarlik_textBox7.Size = new System.Drawing.Size(100, 20);
            this.Duyarlik_textBox7.TabIndex = 22;
            // 
            // Kesinlik_textBox8
            // 
            this.Kesinlik_textBox8.Location = new System.Drawing.Point(613, 267);
            this.Kesinlik_textBox8.Name = "Kesinlik_textBox8";
            this.Kesinlik_textBox8.Size = new System.Drawing.Size(100, 20);
            this.Kesinlik_textBox8.TabIndex = 23;
            // 
            // HataOrani_textBox9
            // 
            this.HataOrani_textBox9.Location = new System.Drawing.Point(613, 234);
            this.HataOrani_textBox9.Name = "HataOrani_textBox9";
            this.HataOrani_textBox9.Size = new System.Drawing.Size(100, 20);
            this.HataOrani_textBox9.TabIndex = 24;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(756, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(484, 372);
            this.dataGridView2.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 502);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.HataOrani_textBox9);
            this.Controls.Add(this.Kesinlik_textBox8);
            this.Controls.Add(this.Duyarlik_textBox7);
            this.Controls.Add(this.fOlcutu_textBox6);
            this.Controls.Add(this.Dogruluk_textBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KNumber);
            this.Controls.Add(this.btnOku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.NumericUpDown KNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label FalseNegative_label10;
        private System.Windows.Forms.Label FalsePositive_label;
        private System.Windows.Forms.Label TrueNegative_label;
        private System.Windows.Forms.Label TruePositive_label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Dogruluk_textBox5;
        private System.Windows.Forms.TextBox fOlcutu_textBox6;
        private System.Windows.Forms.TextBox Duyarlik_textBox7;
        private System.Windows.Forms.TextBox Kesinlik_textBox8;
        private System.Windows.Forms.TextBox HataOrani_textBox9;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

