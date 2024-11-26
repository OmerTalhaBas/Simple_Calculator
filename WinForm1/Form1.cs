namespace WinForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void islemyap_Click(object sender, EventArgs e)
        {
            double sayi1 = 0;
            double sayi2 = 0;
            double sonuc = 0;
            if (combobox.Text == "+")
            {
                sayi1 = Convert.ToDouble(mTxt_sayi.Text);
                sayi2 = Convert.ToDouble(mTxt_sayi2.Text);

                sonuc = sayi1 + sayi2;
                lst_Listele.Items.Add(sonuc.ToString());


            }
            else if (combobox.Text == "-")
            {
                sayi1 = Convert.ToDouble(mTxt_sayi.Text);
                sayi2 = Convert.ToDouble(mTxt_sayi2.Text);
                sonuc = sayi1 - sayi2;
                lst_Listele.Items.Add(sonuc);

            }
            else if (combobox.Text == "*")
            {
                sayi1 = Convert.ToDouble(mTxt_sayi.Text);
                sayi2 = Convert.ToDouble(mTxt_sayi2.Text);
                sonuc = sayi1 * sayi2;
                lst_Listele.Items.Add(sonuc.ToString());
            }
            else if (combobox.Text == "/")
            {
                sayi1 = Convert.ToDouble(mTxt_sayi.Text);
                sayi2 = Convert.ToDouble(mTxt_sayi2.Text);
                if (sayi2 == 0)
                {
                    MessageBox.Show("Sýfýra Bölünme Hatasý!");

                }
                else
                {
                    sonuc = sayi1 / sayi2;
                    lst_Listele.Items.Add(sonuc.ToString());
                }
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lst_Listele.Items.Clear();
        }
    }
}
