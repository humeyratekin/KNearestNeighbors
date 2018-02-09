using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KNNDataMining
{
    public partial class Form1 : Form



    {


        public Form1()
        {


            InitializeComponent();


            DataGridViewTextBoxColumn Nitelik1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Nitelik2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn SinifColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn SinifColumn2 = new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn DurumSinifColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn DurumNitelik1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn DurumNitelik2 = new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn UzaklikColumn = new DataGridViewTextBoxColumn();

            //Datagride alanlarımızı ekliyoruz.
            dataGridView1.Columns.Add(Nitelik1);
            dataGridView1.Columns.Add(Nitelik2);
            dataGridView1.Columns.Add(SinifColumn);
            dataGridView1.Columns.Add(UzaklikColumn);

            dataGridView2.Columns.Add(DurumNitelik1);
            dataGridView2.Columns.Add(DurumNitelik2);
            dataGridView2.Columns.Add(SinifColumn2);
            dataGridView2.Columns.Add(DurumSinifColumn);

            //Sütun başlıklarını ayarlıyoruz.
            Nitelik1.HeaderText = "1.Nitelik";
            Nitelik2.HeaderText = "2.Nitelik";
            SinifColumn.HeaderText = "Sinif";
            UzaklikColumn.HeaderText = "Uzaklik";

            DurumNitelik1.HeaderText = "Nitelik 1";
            DurumNitelik2.HeaderText = "Nitelik 2";
            SinifColumn2.HeaderText = "Sınıf";
            DurumSinifColumn.HeaderText = "Durum";
            

            //tablo.Columns.Add("Ozellik 1", typeof(double));
            //tablo.Columns.Add("Ozellik 2", typeof(double));
            //tablo.Columns.Add("Sınıf", typeof(string));
            //tablo.Columns.Add("Uzaklik", typeof(double));

            for (int i = 0; i < 101; i++)
            {
                dataGridView1.Rows.Add();
            }

            for (int i=0; i<50; i++) {

                dataGridView2.Rows.Add();
            }
        }

        DataTable tablo = new DataTable();


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        public double[] bubble_sort(double[] dizi)
        {
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int j = 1; j < dizi.Length - i; j++)
                {
                    if (dizi[j] < dizi[j - 1])
                    {
                        double gecici = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = gecici;
                    }
                }
            }

            return dizi;
        }


        private void btnOku_Click(object sender, EventArgs e)
        {


            double[] Ozellik1 = new double[50];
            double[] Ozellik2 = new double[50];
            String[] Sinif1 = new string[50];
            double[] Uzaklik = new double[50];
            double[] SiraliUzaklik = new double[50];
            double[] TempArray = new double[50];
            int sinif = 0;
            Random rnd = new Random();

            for (int i = 0; i < Ozellik1.Length; i++)
            {

                Ozellik1[i] = Math.Round(rnd.NextDouble(), 2);


                sinif = rnd.Next(10);
                if (sinif < 5)
                {
                    Sinif1[i] = "IYI";


                }
                else
                    Sinif1[i] = "KOTU";
                sinif = 0;

            }
            
            for (int i = 0; i < Ozellik2.Length; i++) {

                Ozellik2[i] = Math.Round(rnd.NextDouble(), 2);
            }


            int k = Convert.ToInt16(KNumber.Value);
            double X1 = Convert.ToDouble(textBox1.Text);
            double X2 = Convert.ToDouble(textBox2.Text);
            String TahminSinif = textBox3.Text;

            
       


            for (int i = 0; i < Ozellik1.Length; i++)
            {


                Uzaklik[i] = (X1 - Ozellik1[i]) * (X1 - Ozellik1[i]) + (X2 - Ozellik2[i]) * (X2 - Ozellik2[i]);

                Uzaklik[i] = Math.Sqrt(Uzaklik[i]);
                Uzaklik[i] = Math.Round(Uzaklik[i], 2);

            }

            for (int i = 0; i < 50; i++)
            {
                //dataGridView1.Rows[0].Cells[0].Value = "Ahmet";

                dataGridView1.Rows[i].Cells[0].Value = Ozellik1[i];
                dataGridView1.Rows[i].Cells[1].Value = Ozellik2[i];
                dataGridView1.Rows[i].Cells[2].Value = Sinif1[i];
                dataGridView1.Rows[i].Cells[3].Value = Uzaklik[i];


            }




            Array.Copy(Uzaklik, TempArray, Uzaklik.Length);

            SiraliUzaklik = Uzaklik;

            SiraliUzaklik = bubble_sort(Uzaklik);


            double[,] Sonuc = new double[k, 2];
            double temp = 0;
            


            for (int i = 0; i < k; i++) {
                temp = SiraliUzaklik[i];
                Sonuc[i, 0] = temp;
                for (int j = 0; j < Uzaklik.Length; j++) {

                    if (temp == TempArray[j])
                    {
                        Sonuc[i, 1] = j;
                    }

                }



            }

            String HesaplananSinif;
            int dene, IyiSayisi = 0, KotuSayisi = 0;

            for (int i = 0; i < Sonuc.GetLength(0); i++) {
                dene = Convert.ToInt32(Sonuc[i, 1]);
                if (Sinif1[dene] == "IYI")
                {

                    IyiSayisi++;
                }
                else
                    KotuSayisi++;


            }

            if (KotuSayisi > IyiSayisi)
            {

                HesaplananSinif = "IYI";
            }
            else {
                HesaplananSinif = "KOTU";
            }
            textBox4.Text = HesaplananSinif;


            double gecici = 0;
            String Temp1;
            double Temp2, Temp3;
            for (int p = 0; p < 50; p++)
            {
                for (int p2 = 0; p2 <50; p2++)
                {
                    if (TempArray[p2] > TempArray[p])
                    {
                        gecici = TempArray[p];
                        TempArray[p] = TempArray[p2];
                        TempArray[p2] = gecici;
                        Temp1 = Sinif1[p];
                        Temp2 = Ozellik1[p];
                        Temp3 = Ozellik2[p];
                        Ozellik1[p] = Ozellik1[p2];
                        Ozellik1[p2] = Temp2;
                        Ozellik2[p] = Ozellik2[p2];
                        Ozellik2[p2] = Temp3;
                        Sinif1[p] = Sinif1[p2];
                        Sinif1[p2] = Temp1;


                    }
                }
            }



            for (int i = 0; i < 50; i++)
            {
                //dataGridView1.Rows[0].Cells[0].Value = "Ahmet";

                dataGridView1.Rows[i+51].Cells[0].Value = Ozellik1[i];
                dataGridView1.Rows[i+51].Cells[1].Value = Ozellik2[i];
                dataGridView1.Rows[i+51].Cells[2].Value = Sinif1[i];
                dataGridView1.Rows[i+51].Cells[3].Value = Uzaklik[i];


            }



            //------------DURUM TABLOSU---------

            double tp = 0, tn = 0, fp = 0, fn = 0;

            double dogruluk, hataOrani, kesinlik, duyarlilik, fOlcutu;
            int CountIyi = 0, CountKotu = 0;

            for (int i = 0; i < 50-k; i++)
            {
                //System.out.println("GERÇEK: " + x1[i] + "  ||  " + x2[i] + "  ||  " + y[i]);

                dataGridView2.Rows[i].Cells[0].Value = Ozellik1[i];
                dataGridView2.Rows[i].Cells[1].Value = Ozellik2[i];
                dataGridView2.Rows[i].Cells[2].Value = Sinif1[i];


                for (int j = i + 1; j <= i+k; j++)
                {  //o sayıdan sonra kaç tane iyi-kötü var
                    if (Sinif1[j] == "IYI")
                    {
                        CountIyi++;
                    }
                    else
                    {
                        CountKotu++;
                    }
                }

                if (Sinif1[i] == "IYI")
                {
                    if (CountIyi > CountKotu)
                    {
                        dataGridView2.Rows[i].Cells[3].Value = "IYI";

                        //System.out.println("DURUM: İYİ");
                        tp++;
                    }

                    else if (CountIyi <= CountKotu)
                    {
                        dataGridView2.Rows[i].Cells[3].Value = "KOTU";
                        //System.out.println("DURUM: KÖTÜ");
                        fp++;
                    }
                }

                else
                {

                    if (CountIyi > CountKotu)
                    {
                        dataGridView2.Rows[i].Cells[3].Value = "IYI";
                        fn++;
                    }
                    else if (CountIyi <= CountKotu)
                    {
                        dataGridView2.Rows[i].Cells[3].Value = "KOTU";
                        tn++;
                    }

                }

                CountIyi = 0;
                CountKotu = 0;

            }

            TruePositive_label4.Text = Convert.ToString(tp);
            TrueNegative_label.Text = Convert.ToString(tn);
            FalsePositive_label.Text = Convert.ToString(fp);
            FalseNegative_label10.Text = Convert.ToString(fn);

            if (tp+fn+tn+fn==0) {
                dogruluk = 0;
                Dogruluk_textBox5.Text = "Tanımsız";
                HataOrani_textBox9.Text = "Tanımsız";
            }
            else { 
            dogruluk = (tp + tn) / (tp + fp + tn + fn);

            Dogruluk_textBox5.Text = Convert.ToString(dogruluk);

            hataOrani = (fp + fn) / (tp + fp + tn + fn);
            HataOrani_textBox9.Text = Convert.ToString(hataOrani);
		   }

            if (tp+fp==0) {
                kesinlik = 0;
                Kesinlik_textBox8.Text = "Tanımsız";
            }
            else {
            kesinlik = tp / (tp + fp);
            Kesinlik_textBox8.Text = Convert.ToString(kesinlik);
            }

            if (tp+fn==0) {
                duyarlilik = 0;
                Duyarlik_textBox7.Text = "Tanımsız";
            }
            else { 
            duyarlilik = tp / (tp + fn);
            Duyarlik_textBox7.Text = Convert.ToString(duyarlilik); 
		  }

            fOlcutu = (2 * duyarlilik * kesinlik) / (duyarlilik + kesinlik);
            fOlcutu_textBox6.Text = Convert.ToString(fOlcutu);


        }


       





        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

