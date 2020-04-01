namespace calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxIn1 = new System.Windows.Forms.TextBox();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.bOne = new System.Windows.Forms.Button();
            this.bTwo = new System.Windows.Forms.Button();
            this.bThree = new System.Windows.Forms.Button();
            this.bFour = new System.Windows.Forms.Button();
            this.bFive = new System.Windows.Forms.Button();
            this.bSix = new System.Windows.Forms.Button();
            this.bSeven = new System.Windows.Forms.Button();
            this.bEight = new System.Windows.Forms.Button();
            this.bNine = new System.Windows.Forms.Button();
            this.bZero = new System.Windows.Forms.Button();
            this.newFuncButt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.radioButtonto10 = new System.Windows.Forms.RadioButton();
            this.radioButtonto8 = new System.Windows.Forms.RadioButton();
            this.radioButtonto2 = new System.Windows.Forms.RadioButton();
            this.labelSysS = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxIn1
            // 
            this.TextBoxIn1.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxIn1.Location = new System.Drawing.Point(6, 7);
            this.TextBoxIn1.MaxLength = 25;
            this.TextBoxIn1.Name = "TextBoxIn1";
            this.TextBoxIn1.Size = new System.Drawing.Size(226, 31);
            this.TextBoxIn1.TabIndex = 0;
            this.TextBoxIn1.TextChanged += new System.EventHandler(this.TextBoxIn1_TextChanged);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.Transparent;
            this.PlusButton.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.Location = new System.Drawing.Point(171, 202);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(42, 43);
            this.PlusButton.TabIndex = 2;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.Transparent;
            this.MinusButton.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.MinusButton.Location = new System.Drawing.Point(171, 153);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(42, 43);
            this.MinusButton.TabIndex = 3;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.MultiplyButton.Location = new System.Drawing.Point(171, 55);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(42, 43);
            this.MultiplyButton.TabIndex = 4;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.DivideButton.Location = new System.Drawing.Point(171, 104);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(42, 43);
            this.DivideButton.TabIndex = 5;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.ClearButton.Location = new System.Drawing.Point(27, 202);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(42, 43);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.EqualsButton.Location = new System.Drawing.Point(123, 202);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(42, 43);
            this.EqualsButton.TabIndex = 7;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // bOne
            // 
            this.bOne.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.bOne.Location = new System.Drawing.Point(27, 55);
            this.bOne.Name = "bOne";
            this.bOne.Size = new System.Drawing.Size(42, 43);
            this.bOne.TabIndex = 8;
            this.bOne.Text = "1";
            this.bOne.UseMnemonic = false;
            this.bOne.UseVisualStyleBackColor = true;
            this.bOne.Click += new System.EventHandler(this.BOne);
            // 
            // bTwo
            // 
            this.bTwo.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.bTwo.Location = new System.Drawing.Point(75, 55);
            this.bTwo.Name = "bTwo";
            this.bTwo.Size = new System.Drawing.Size(42, 43);
            this.bTwo.TabIndex = 9;
            this.bTwo.Text = "2";
            this.bTwo.UseVisualStyleBackColor = true;
            this.bTwo.Click += new System.EventHandler(this.BTwo);
            // 
            // bThree
            // 
            this.bThree.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.bThree.Location = new System.Drawing.Point(123, 55);
            this.bThree.Name = "bThree";
            this.bThree.Size = new System.Drawing.Size(42, 43);
            this.bThree.TabIndex = 10;
            this.bThree.Text = "3";
            this.bThree.UseVisualStyleBackColor = true;
            this.bThree.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bFour
            // 
            this.bFour.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.bFour.Location = new System.Drawing.Point(27, 104);
            this.bFour.Name = "bFour";
            this.bFour.Size = new System.Drawing.Size(42, 43);
            this.bFour.TabIndex = 11;
            this.bFour.Text = "4";
            this.bFour.UseVisualStyleBackColor = true;
            this.bFour.Click += new System.EventHandler(this.bFour_Click);
            // 
            // bFive
            // 
            this.bFive.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.bFive.Location = new System.Drawing.Point(75, 104);
            this.bFive.Name = "bFive";
            this.bFive.Size = new System.Drawing.Size(42, 43);
            this.bFive.TabIndex = 12;
            this.bFive.Text = "5";
            this.bFive.UseVisualStyleBackColor = true;
            this.bFive.Click += new System.EventHandler(this.bFive_Click);
            // 
            // bSix
            // 
            this.bSix.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.bSix.Location = new System.Drawing.Point(123, 104);
            this.bSix.Name = "bSix";
            this.bSix.Size = new System.Drawing.Size(42, 43);
            this.bSix.TabIndex = 13;
            this.bSix.Text = "6";
            this.bSix.UseVisualStyleBackColor = true;
            this.bSix.Click += new System.EventHandler(this.bSix_Click);
            // 
            // bSeven
            // 
            this.bSeven.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.bSeven.Location = new System.Drawing.Point(27, 153);
            this.bSeven.Name = "bSeven";
            this.bSeven.Size = new System.Drawing.Size(42, 43);
            this.bSeven.TabIndex = 14;
            this.bSeven.Text = "7";
            this.bSeven.UseVisualStyleBackColor = true;
            this.bSeven.Click += new System.EventHandler(this.bSeven_Click);
            // 
            // bEight
            // 
            this.bEight.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.bEight.Location = new System.Drawing.Point(75, 153);
            this.bEight.Name = "bEight";
            this.bEight.Size = new System.Drawing.Size(42, 43);
            this.bEight.TabIndex = 15;
            this.bEight.Text = "8";
            this.bEight.UseVisualStyleBackColor = true;
            this.bEight.Click += new System.EventHandler(this.bEight_Click);
            // 
            // bNine
            // 
            this.bNine.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.bNine.Location = new System.Drawing.Point(123, 153);
            this.bNine.Name = "bNine";
            this.bNine.Size = new System.Drawing.Size(42, 43);
            this.bNine.TabIndex = 16;
            this.bNine.Text = "9";
            this.bNine.UseVisualStyleBackColor = true;
            this.bNine.Click += new System.EventHandler(this.bNine_Click);
            // 
            // bZero
            // 
            this.bZero.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.bZero.Location = new System.Drawing.Point(75, 202);
            this.bZero.Name = "bZero";
            this.bZero.Size = new System.Drawing.Size(42, 43);
            this.bZero.TabIndex = 17;
            this.bZero.Text = "0";
            this.bZero.UseVisualStyleBackColor = true;
            this.bZero.Click += new System.EventHandler(this.bZero_Click);
            // 
            // newFuncButt
            // 
            this.newFuncButt.Location = new System.Drawing.Point(219, 55);
            this.newFuncButt.Name = "newFuncButt";
            this.newFuncButt.Size = new System.Drawing.Size(16, 190);
            this.newFuncButt.TabIndex = 18;
            this.newFuncButt.UseVisualStyleBackColor = true;
            this.newFuncButt.Click += new System.EventHandler(this.newFuncButt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 190);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sqrtButton
            // 
            this.sqrtButton.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.sqrtButton.Location = new System.Drawing.Point(27, 251);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(42, 43);
            this.sqrtButton.TabIndex = 20;
            this.sqrtButton.Text = "√";
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
            // 
            // radioButtonto10
            // 
            this.radioButtonto10.AutoSize = true;
            this.radioButtonto10.Location = new System.Drawing.Point(76, 252);
            this.radioButtonto10.Name = "radioButtonto10";
            this.radioButtonto10.Size = new System.Drawing.Size(46, 17);
            this.radioButtonto10.TabIndex = 21;
            this.radioButtonto10.TabStop = true;
            this.radioButtonto10.Text = "->10";
            this.radioButtonto10.UseVisualStyleBackColor = true;
            this.radioButtonto10.CheckedChanged += new System.EventHandler(this.radioButtonto10_CheckedChanged);
            // 
            // radioButtonto8
            // 
            this.radioButtonto8.AutoSize = true;
            this.radioButtonto8.Location = new System.Drawing.Point(76, 272);
            this.radioButtonto8.Name = "radioButtonto8";
            this.radioButtonto8.Size = new System.Drawing.Size(40, 17);
            this.radioButtonto8.TabIndex = 22;
            this.radioButtonto8.TabStop = true;
            this.radioButtonto8.Text = "->8";
            this.radioButtonto8.UseVisualStyleBackColor = true;
            this.radioButtonto8.CheckedChanged += new System.EventHandler(this.radioButtonto8_CheckedChanged);
            // 
            // radioButtonto2
            // 
            this.radioButtonto2.AutoSize = true;
            this.radioButtonto2.Location = new System.Drawing.Point(123, 252);
            this.radioButtonto2.Name = "radioButtonto2";
            this.radioButtonto2.Size = new System.Drawing.Size(40, 17);
            this.radioButtonto2.TabIndex = 23;
            this.radioButtonto2.TabStop = true;
            this.radioButtonto2.Text = "->2";
            this.radioButtonto2.UseVisualStyleBackColor = true;
            this.radioButtonto2.CheckedChanged += new System.EventHandler(this.radioButtonto2_CheckedChanged);
            // 
            // labelSysS
            // 
            this.labelSysS.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSysS.Location = new System.Drawing.Point(123, 272);
            this.labelSysS.Name = "labelSysS";
            this.labelSysS.Size = new System.Drawing.Size(112, 22);
            this.labelSysS.TabIndex = 24;
            this.labelSysS.Click += new System.EventHandler(this.labelSysS_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(0, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(249, 331);
            this.tabControl.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Lavender;
            this.tabPage1.Controls.Add(this.labelSysS);
            this.tabPage1.Controls.Add(this.TextBoxIn1);
            this.tabPage1.Controls.Add(this.radioButtonto2);
            this.tabPage1.Controls.Add(this.bOne);
            this.tabPage1.Controls.Add(this.radioButtonto8);
            this.tabPage1.Controls.Add(this.PlusButton);
            this.tabPage1.Controls.Add(this.radioButtonto10);
            this.tabPage1.Controls.Add(this.MinusButton);
            this.tabPage1.Controls.Add(this.sqrtButton);
            this.tabPage1.Controls.Add(this.MultiplyButton);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.DivideButton);
            this.tabPage1.Controls.Add(this.newFuncButt);
            this.tabPage1.Controls.Add(this.ClearButton);
            this.tabPage1.Controls.Add(this.bZero);
            this.tabPage1.Controls.Add(this.EqualsButton);
            this.tabPage1.Controls.Add(this.bNine);
            this.tabPage1.Controls.Add(this.bTwo);
            this.tabPage1.Controls.Add(this.bEight);
            this.tabPage1.Controls.Add(this.bThree);
            this.tabPage1.Controls.Add(this.bSeven);
            this.tabPage1.Controls.Add(this.bFour);
            this.tabPage1.Controls.Add(this.bSix);
            this.tabPage1.Controls.Add(this.bFive);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(241, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Калькулятор";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(241, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Строки";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 31);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(6, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 31);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "[кол-во символов]";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 129);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(14, 152);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(138, 129);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(138, 152);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "[кол-во символов]";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(14, 176);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(138, 176);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 38);
            this.button3.TabIndex = 10;
            this.button3.Text = "button2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(122, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 38);
            this.button4.TabIndex = 10;
            this.button4.Text = "button2";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(177, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 38);
            this.button5.TabIndex = 10;
            this.button5.Text = "button2";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 250);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 38);
            this.button6.TabIndex = 10;
            this.button6.Text = "button2";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(67, 250);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 38);
            this.button7.TabIndex = 10;
            this.button7.Text = "button2";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(122, 250);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 38);
            this.button8.TabIndex = 10;
            this.button8.Text = "button2";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(177, 250);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 38);
            this.button9.TabIndex = 10;
            this.button9.Text = "button2";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(248, 332);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Калькулятор Елисеева";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox TextBoxIn1;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button bOne;
        private System.Windows.Forms.Button bTwo;
        private System.Windows.Forms.Button bThree;
        private System.Windows.Forms.Button bFour;
        private System.Windows.Forms.Button bFive;
        private System.Windows.Forms.Button bSix;
        private System.Windows.Forms.Button bSeven;
        private System.Windows.Forms.Button bEight;
        private System.Windows.Forms.Button bNine;
        private System.Windows.Forms.Button bZero;
        private System.Windows.Forms.Button newFuncButt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.RadioButton radioButtonto10;
        private System.Windows.Forms.RadioButton radioButtonto8;
        private System.Windows.Forms.RadioButton radioButtonto2;
        private System.Windows.Forms.Label labelSysS;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
    }
}

