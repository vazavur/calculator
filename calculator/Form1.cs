using System;
using System.Windows.Forms;

// Каждая кнопка имеет обработку на входную строку 

namespace calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public string todo { get; set; } //переключатель действий
        public double firstnum { get; set; } //первая строка
        //List<string> mnogohodovochka = new List<string>(); //для парсера

        public static double InputString(string text) //обработка входящей строки на ошибку формата
        {
            try
            {
                double firstnum = double.Parse(text);
                return firstnum;
            }
            catch (FormatException) { MessageBox.Show("Ошибка формата данных"); double err = 0; return err; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                firstnum = InputString(TextBoxIn1.Text);
                todo = "plus";
                TextBoxIn1.Text = "";
            }
            catch (FormatException) { TextBoxIn1.Text = "Формат"; cleaner = "y"; }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            try
            {
                firstnum = InputString(TextBoxIn1.Text);
                todo = "minus";
                TextBoxIn1.Text = "";
            }
            catch (FormatException) { TextBoxIn1.Text = "Формат"; cleaner = "y"; }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                firstnum = InputString(TextBoxIn1.Text);
                todo = "multiply";
                TextBoxIn1.Text = "";
            }
            catch (FormatException) { TextBoxIn1.Text = "Формат"; cleaner = "y"; }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            try
            {
                firstnum = InputString(TextBoxIn1.Text);
                todo = "divide";
                TextBoxIn1.Text = "";
            }
            catch (FormatException) { TextBoxIn1.Text = "Формат"; cleaner = "y"; }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            todo = "";
            TextBoxIn1.Text = "";
        }

        private string cleaner = "";
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (todo)
                {
                    case "plus":
                        TextBoxIn1.Text = ((firstnum) + (double.Parse(TextBoxIn1.Text))).ToString();
                        break;
                    case "minus":
                        TextBoxIn1.Text = (firstnum - (double.Parse(TextBoxIn1.Text))).ToString();
                        break;
                    case "multiply":
                        TextBoxIn1.Text = ((firstnum) * (double.Parse(TextBoxIn1.Text))).ToString();
                        break;
                    case "divide":
                        TextBoxIn1.Text = ((firstnum) / (double.Parse(TextBoxIn1.Text))).ToString();
                        break;
                }
            }
            catch (FormatException) { TextBoxIn1.Text = "формат"; }

            cleaner = "y"; //точка для очистки

            /* вот это не трогать когда-нибудь это будет парсер
            char pl = '+';
            char min = '-';
            char mul = '*';
            char div = '/';
            string idk = "";
            try
            {

               foreach (char parse in TextBoxIn1.Text)
                {
                    idk += parse;
                    if (parse == pl) { mnogohodovochka.Add(idk); mnogohodovochka.Add("+"); }
                    if (parse == min) { mnogohodovochka.Add(idk); mnogohodovochka.Add("-"); }
                    if (parse == mul) { mnogohodovochka.Add(idk); mnogohodovochka.Add("*"); }
                    if (parse == div) { mnogohodovochka.Add(idk); mnogohodovochka.Add("/"); }
                }

                try
                {
                    double ari = 0;
                    foreach (string c in mnogohodovochka)
                    {
                        switch (c)
                        {
                            case "+":
                                int a = mnogohodovochka.IndexOf(c);
                                int w = a - 1;
                                int r = a + 1;
                                ari += double.Parse(mnogohodovochka.ElementAt(w) + mnogohodovochka.ElementAt(r));
                                break;
                            default:
                                break;
                        }
                    }
                    TextBoxIn1.Text = ari.ToString();
                }
                catch
                {
                    MessageBox.Show(
    "ошибка в перечислении списка",
    "Внимание");
                }

        }
            catch
            {
                MessageBox.Show(
                    "В введённых данных обнаружена ошибка",
                    "Внимание");
            }*/
        }
        //каждая кнопка обновляется переменной cleaner, которая активируется при нажатии на equals
        private void BOne(object sender, EventArgs e) //1
        {
            if (cleaner == "y") { TextBoxIn1.Text = ""; cleaner = ""; }
            TextBoxIn1.Text += "1";
        }

        private void BTwo(object sender, EventArgs e)
        {
            if (cleaner == "y") { TextBoxIn1.Text = ""; cleaner = ""; }
            TextBoxIn1.Text += "2";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cleaner == "y") { TextBoxIn1.Text = ""; cleaner = ""; }
            TextBoxIn1.Text += "3";
        }

        private void bFour_Click(object sender, EventArgs e)
        {
            if (cleaner == "y") { TextBoxIn1.Text = ""; cleaner = ""; }
            TextBoxIn1.Text += "4";
        }

        private void bFive_Click(object sender, EventArgs e)
        {
            if (cleaner == "y") { TextBoxIn1.Text = ""; cleaner = ""; }
            TextBoxIn1.Text += "5";
        }

        private void bSix_Click(object sender, EventArgs e)
        {
            if (cleaner == "y") { TextBoxIn1.Text = ""; cleaner = ""; }
            TextBoxIn1.Text += "6";
        }

        private void bSeven_Click(object sender, EventArgs e)
        {
            if (cleaner == "y") { TextBoxIn1.Text = ""; cleaner = ""; }
            TextBoxIn1.Text += "7";
        }

        private void bEight_Click(object sender, EventArgs e)
        {
            if (cleaner == "y") { TextBoxIn1.Text = ""; cleaner = ""; }
            TextBoxIn1.Text += "8";
        }

        private void bNine_Click(object sender, EventArgs e)
        {
            if (cleaner == "y") { TextBoxIn1.Text = ""; cleaner = ""; }
            TextBoxIn1.Text += "9";
        }

        private void bZero_Click(object sender, EventArgs e)
        {
            if (cleaner == "y") { TextBoxIn1.Text = ""; cleaner = ""; }
            TextBoxIn1.Text += "0";
        }

        private void TextBoxIn1_TextChanged(object sender, EventArgs e)
        {/* автоматический перевод в системы без необходимости трогать радиобатоны, убивает отрицательный ввод
            int i = int.Parse(TextBoxIn1.Text);
            if (radioButtonto10.Checked == true)
            {
                labelSysS.Text = Convert.ToString(i, 10);
            }
            if (radioButtonto8.Checked == true)
            {
                labelSysS.Text = Convert.ToString(i, 8);
            }
            if (radioButtonto2.Checked == true)
            {
                labelSysS.Text = Convert.ToString(i, 2);
            }*/
        }

        private void newFuncButt_Click(object sender, EventArgs e)
        { /*
            newFuncForm nFF = new newFuncForm(TextBoxIn1.Text);
            nFF.Show();*/
        }

        public string TextBoxValue
        {
            get { return TextBoxIn1.Text; }
            set { TextBoxIn1.Text = value; }
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            double sqrt = Math.Sqrt(double.Parse(TextBoxIn1.Text));
            if (sqrt < 0) { TextBoxIn1.Text = "Ошибка"; }
            else { TextBoxIn1.Text = sqrt.ToString(); }

        }

        private void radioButtonto10_CheckedChanged(object sender, EventArgs e)
        {
            int i = int.Parse(TextBoxIn1.Text);
            labelSysS.Text = Convert.ToString(i, 10);
        }

        private void radioButtonto8_CheckedChanged(object sender, EventArgs e)
        {
            int i = int.Parse(TextBoxIn1.Text);
            if (i < 0)
            {
                MessageBox.Show("К сожалению, в данный момент перевод отрицательных чисел не доступен.");
            }
            else
            {
                labelSysS.Text = Convert.ToString(i, 8);
            }
        }

        private void radioButtonto2_CheckedChanged(object sender, EventArgs e)
        {
            int i = int.Parse(TextBoxIn1.Text);
            if (i < 0)
            {
                MessageBox.Show("К сожалению, в данный момент перевод отрицательных чисел не доступен.");
            }
            else
            {
                labelSysS.Text = Convert.ToString(i, 2);
            }
        }
    }

}
