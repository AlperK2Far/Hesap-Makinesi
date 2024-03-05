namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // KLAVYEDEN SAYI GÝRÝÞÝNÝ AYARLA **
        // buglar : hala iþlem tuþlarýna önce basmakla ilgili hatalar var
        // yazýp silip iþlem tuþlarýna basýnca hata veriyo
        // Formu büyütünce butonlarýn boyunun sabit kalmasýný ayarla
        // Bölme iþleminden sonra eþittire üst üste 2 kere basýldýðýnda sonuç tanýmsýz oluyo
        // Eþittire iki kere basýnca ikincinin iþlememesini saðla (if textboxta mesaj varsa buton çalýþma tarzý)
        // Sonuç olan sayýyý silemiyoruz
        // NEED BUGFIX A LOT


        string sayi1;
        string sayi2;
        int sayi1son = -19;
        int sayi2son = -19;
        string islem;


        private void button0_Click(object sender, EventArgs e)
        {
            if (sayi1son != Convert.ToInt32(sayi1))
            {
                sayi1 += "0";
                textBox1.Text = sayi1.ToString();
            }
            else
            {
                sayi2 += "0";
                textBox1.Text = sayi2.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (sayi1son != Convert.ToInt32(sayi1))
            {
                sayi1 += "1";
                textBox1.Text = sayi1.ToString();
            }
            else
            {
                sayi2 += "1";
                textBox1.Text = sayi2.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sayi1son != Convert.ToInt32(sayi1))
            {
                sayi1 += "2";
                textBox1.Text = sayi1.ToString();
            }
            else
            {
                sayi2 += "2";
                textBox1.Text = sayi2.ToString();

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sayi1son != Convert.ToInt32(sayi1))
            {
                sayi1 += "3";
                textBox1.Text = sayi1.ToString();
            }
            else
            {
                sayi2 += "3";
                textBox1.Text = sayi2.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sayi1son != Convert.ToInt32(sayi1))
            {
                sayi1 += "4";
                textBox1.Text = sayi1.ToString();
            }
            else
            {
                sayi2 += "4";
                textBox1.Text = sayi2.ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sayi1son != Convert.ToInt32(sayi1))
            {
                sayi1 += "5";
                textBox1.Text = sayi1.ToString();
            }
            else
            {
                sayi2 += "5";
                textBox1.Text = sayi2.ToString();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sayi1son != Convert.ToInt32(sayi1))
            {
                sayi1 += "6";
                textBox1.Text = sayi1.ToString();
            }
            else
            {
                sayi2 += "6";
                textBox1.Text = sayi2.ToString();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sayi1son != Convert.ToInt32(sayi1))
            {
                sayi1 += "7";
                textBox1.Text = sayi1.ToString();
            }
            else
            {
                sayi2 += "7";
                textBox1.Text = sayi2.ToString();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sayi1son != Convert.ToInt32(sayi1))
            {
                sayi1 += "8";
                textBox1.Text = sayi1.ToString();
            }
            else
            {
                sayi2 += "8";
                textBox1.Text = sayi2.ToString();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sayi1son != Convert.ToInt32(sayi1))
            {
                sayi1 += "9";
                textBox1.Text = sayi1.ToString();
            }
            else
            {
                sayi2 += "9";
                textBox1.Text = sayi2.ToString();

            }
        }

        private void butonToplama_Click(object sender, EventArgs e)
        {
            if (sayi1 == null && sayi1son == -19)
            {
                textBox1.Text = "Önce sayý giriniz";
                sayi1 = null;
                sayi1son = -19;
                sayi2 = null;
                sayi2son = -19;
            }

            if (sayi1 == null || sayi1.Length == 0)
            {

            }

            else if (sayi1son != Convert.ToInt32(sayi1))
            {
                sayi1son = Convert.ToInt32(sayi1);
                textBox1.Text = "";
            }
            else
            {
                sayi2son = Convert.ToInt32(sayi2);
            }
            islem = "toplama";

        }


        private void butonCikartma_Click(object sender, EventArgs e)
        {
            if (sayi1 == null && sayi1son == -19)
            {
                textBox1.Text = "Önce sayý giriniz";
                sayi1 = null;
                sayi1son = -19;
                sayi2 = null;
                sayi2son = -19;
            }

            if (sayi1 == null || sayi1.Length == 0)
            {

            }

            else if (sayi1son != Convert.ToInt32(sayi1))
            {
                sayi1son = Convert.ToInt32(sayi1);
                textBox1.Text = "";
            }
            else
            {
                sayi2son = Convert.ToInt32(sayi2);
            }
            islem = "cikartma";
        }

        private void butonCarpma_Click(object sender, EventArgs e)
        {
            if (sayi1 == null && sayi1son == -19)
            {
                textBox1.Text = "Önce sayý giriniz";
                sayi1 = null;
                sayi1son = -19;
                sayi2 = null;
                sayi2son = -19;
            }

            if (sayi1 == null || sayi1.Length == 0)
            {

            }

            else if (sayi1son != Convert.ToInt32(sayi1))
            {
                sayi1son = Convert.ToInt32(sayi1);
                textBox1.Text = "";
            }
            else
            {
                sayi2son = Convert.ToInt32(sayi2);
            }
            islem = "carpma";
        }

        private void butonBolme_Click(object sender, EventArgs e)
        {
            if (sayi1 == null && sayi1son == -19)
            {
                textBox1.Text = "Önce sayý giriniz";
                sayi1 = null;
                sayi1son = -19;
                sayi2 = null;
                sayi2son = -19;
            }

            if (sayi1 == null || sayi1.Length == 0)
            {

            }

            else if (sayi1son != Convert.ToInt32(sayi1))
            {
                sayi1son = Convert.ToInt32(sayi1);
                textBox1.Text = "";
            }
            else
            {
                sayi2son = Convert.ToInt32(sayi2);

            }
            islem = "bolme";
        }

        private void butonEsittir_Click(object sender, EventArgs e)
        {

            
            if (sayi2son != Convert.ToInt32(sayi2))
            {
                sayi2son = Convert.ToInt32(sayi2);
            }


            else if (islem == "toplama")
            {
                string sonuc = Convert.ToString(sayi1son + sayi2son);
                textBox1.Text = sonuc;
                sayi1 = sonuc;
                sayi1son = Convert.ToInt32(sonuc);
                sayi2 = null;
                sayi2son = -19;

            }
            else if (islem == "cikartma")
            {
                string sonuc = Convert.ToString(sayi1son - sayi2son);
                textBox1.Text = sonuc;
                sayi1 = sonuc;
                sayi1son = Convert.ToInt32(sonuc);
                sayi2 = null;
                sayi2son = -19;

            }

            else if (islem == "carpma")
            {
                string sonuc = Convert.ToString(sayi1son * sayi2son);
                textBox1.Text = sonuc;
                sayi1 = sonuc;
                sayi1son = Convert.ToInt32(sonuc);
                sayi2 = null;
                sayi2son = -19;
            }

            else if (islem == "bolme")
            {
                if (sayi1son == 0 && sayi2son == 0)
                {
                    textBox1.Text = "Belirsiz";
                    sayi1 = null;
                    sayi1son = -19;
                    sayi2 = null;
                    sayi2son = -19;
                }

                else if (sayi2son == 0)
                {
                    textBox1.Text = "Tanýmsýz";
                    sayi1 = null;
                    sayi1son = -19;
                    sayi2 = null;
                    sayi2son = -19;
                }

                else
                {
                    string sonuc = Convert.ToString(sayi1son / sayi2son);
                    textBox1.Text = sonuc + " Kalan = " + (sayi1son % sayi2son);
                    sayi1 = sonuc;
                    sayi1son = Convert.ToInt32(sonuc);
                    sayi2 = null;
                    sayi2son = -19;

                }
            }
        }

        private void buttonTemizleme_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            sayi1 = null;
            sayi1son = -19;
            sayi2 = null;
            sayi2son = -19;
        }

        private void buttonSilme_Click(object sender, EventArgs e)
        {
            if (sayi1 == null || sayi1.Length == 0)
            {

            }


            else if (sayi1son != Convert.ToInt32(sayi1))
            {
                sayi1 = sayi1.Remove(sayi1.Length - 1, 1);
                textBox1.Text = sayi1.ToString();
            }
            else if (sayi2 != null && sayi2.Length != 0)
            {
                sayi2 = sayi2.Remove(sayi2.Length - 1, 1);
                textBox1.Text = sayi2.ToString();
            }

        }

    }
}
