using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;


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
                firstnum = InputString(TextBoxIn1.Text);
                todo = "plus";
                TextBoxIn1.Text = "";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
                firstnum = InputString(TextBoxIn1.Text);
                todo = "minus";
                TextBoxIn1.Text = "";
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
                firstnum = InputString(TextBoxIn1.Text);
                todo = "multiply";
                TextBoxIn1.Text = "";
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
                firstnum = InputString(TextBoxIn1.Text);
                todo = "divide";
                TextBoxIn1.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            todo = "";
            TextBoxIn1.Text = "";
        }

        private string cleaner = "";
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            double t = 0;
                switch (todo)
                {
                    case "plus":
                    t = InputString(TextBoxIn1.Text);
                    TextBoxIn1.Text = ((firstnum) + (t)).ToString();
                    break;
                    case "minus":
                    t = InputString(TextBoxIn1.Text);
                    TextBoxIn1.Text = ((firstnum) - (t)).ToString();
                    break;
                    case "multiply":
                    t = InputString(TextBoxIn1.Text);
                    TextBoxIn1.Text = ((firstnum) * (t)).ToString();
                    break;
                    case "divide":
                    t = InputString(TextBoxIn1.Text);
                    TextBoxIn1.Text = ((firstnum) / (t)).ToString();
                    break;
                }

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

        private void TBInputLine_TextChanged(object sender, EventArgs e)
        {
            labelInputStringLength.Text = TBInputLine.Text.Length.ToString();

        }

        private void TBOutputLine_TextChanged(object sender, EventArgs e)
        {
            labelOutputStringLength.Text = TBOutputLine.Text.Length.ToString();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (radioButtonUp.Checked) { TBOutputLine.Text = TBInputLine.Text.ToUpper(); }
            if (radioButtonDown.Checked) { TBOutputLine.Text = TBInputLine.Text.ToLower(); }
            if (CBCorrecting.Checked) { TBOutputLine.Text = Correcting(TBInputLine.Text); }
        }

        private void StatButton_Click(object sender, EventArgs e)
        {
            int a = TBOutputLine.Text.Length;
            const string glas = "УуЕеЫыАаОоЭэЯяИиЮю";
            const string sogl = "ЙйЦцКкНнГгШшЩщЗзХхФфВвПпРрЛлДдЖжЧчСсМмТтБб";
            int soglcount = 0;
            int glascount = 0;
            for (int i = 0; i < TBOutputLine.Text.Length; ++i)
            {
                for (int j = 0; j < glas.Length; ++j)
                    if (TBOutputLine.Text[i] == glas[j])
                        ++glascount;
                for (int j = 0; j < sogl.Length; ++j)
                    if (TBOutputLine.Text[i] == sogl[j])
                        ++soglcount;
            }
            MessageBox.Show(
                $"Количество символов: {a}\r\n" +
                $"Количество гласных: {glascount}\r\n" +
                $"Количество согласных: {soglcount}\r\n" +
                $"Количество цифр: {NumStat(TBOutputLine.Text)}"
                );
        }

        public static int NumStat(string Input) //метод подсчёта символов по их ASCII-номеру
        {
            byte[] ascii = Encoding.ASCII.GetBytes(Input); //получаем массив из аски символов
            int numcounter = 0;
            for (int i = 0; i < Input.Length; i++) //перебираем строку, разбитую на номера символов, на совпадения
            {
                if (ascii[i] > 47 && ascii[i] < 58) ++numcounter;
            }
            return numcounter;
        }

        public static string Correcting(string Input)
        {
            string output = "";

            output = Input.Replace("чю", "чу");

            output = Input.Replace("щю", "щу");

            output = Input.Replace("чя", "ча");

            output = Input.Replace("щя", "ща");

            output = Input.Replace("жы", "жи");

            output = Input.Replace("шы", "ши");

            output = Input.Replace("чьн", "чн");

            output = Input.Replace("чьк", "чк");

            return output;
        }

        private void radioButtonUp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void CBCorrecting_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GenderFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GenderMale_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ConvButton_Click(object sender, EventArgs e)
        {
            double weight = double.Parse(TBweight.Text); // вес
            double height = double.Parse(TBheight.Text); // рост
            int age = int.Parse(TBage.Text); // возраст

            double a = 1;
            if (IntensifyBox.SelectedItem.ToString() == "Физ. нагрузки нет") { a = 1.2; }
            if (IntensifyBox.SelectedItem.ToString() == "Трен. ср. тяж. 3 в неделю") { a = 1.38; }
            if (IntensifyBox.SelectedItem.ToString() == "Трен. ср. тяж. 5 в неделю") { a = 1.46; }
            if (IntensifyBox.SelectedItem.ToString() == "Интенс. трен. 5 в неделю") { a = 1.55; }
            if (IntensifyBox.SelectedItem.ToString() == "Трен. ежедневно") { a = 1.64; }
            if (IntensifyBox.SelectedItem.ToString() == "Интенс. трен. ежедневно") { a = 1.73; }
            if (IntensifyBox.SelectedItem.ToString() == "Физ нагр. + физ. работа ежедневно") { a = 1.9; }

            double q = (weight * 10) + (height * 6.25) - (age * 5);
            if (GenderMale.Checked) { q += 5; }
            else { q = q - 161; }
            double dci = q * a;
            ConvOutLabel.Text = dci.ToString();
        }
    }

}
