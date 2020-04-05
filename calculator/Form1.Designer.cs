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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GoButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.StatButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButtonDown = new System.Windows.Forms.RadioButton();
            this.radioButtonUp = new System.Windows.Forms.RadioButton();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelOutputStringLength = new System.Windows.Forms.Label();
            this.labelInputStringLength = new System.Windows.Forms.Label();
            this.TBOutputLine = new System.Windows.Forms.TextBox();
            this.TBInputLine = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxIn1
            // 
            this.TextBoxIn1.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxIn1.Location = new System.Drawing.Point(6, 12);
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
            this.PlusButton.Location = new System.Drawing.Point(169, 204);
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
            this.MinusButton.Location = new System.Drawing.Point(169, 155);
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
            this.MultiplyButton.Location = new System.Drawing.Point(169, 57);
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
            this.DivideButton.Location = new System.Drawing.Point(169, 106);
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
            this.ClearButton.Location = new System.Drawing.Point(25, 204);
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
            this.EqualsButton.Location = new System.Drawing.Point(121, 204);
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
            this.bOne.Location = new System.Drawing.Point(25, 57);
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
            this.bTwo.Location = new System.Drawing.Point(73, 57);
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
            this.bThree.Location = new System.Drawing.Point(121, 57);
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
            this.bFour.Location = new System.Drawing.Point(25, 106);
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
            this.bFive.Location = new System.Drawing.Point(73, 106);
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
            this.bSix.Location = new System.Drawing.Point(121, 106);
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
            this.bSeven.Location = new System.Drawing.Point(25, 155);
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
            this.bEight.Location = new System.Drawing.Point(73, 155);
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
            this.bNine.Location = new System.Drawing.Point(121, 155);
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
            this.bZero.Location = new System.Drawing.Point(73, 204);
            this.bZero.Name = "bZero";
            this.bZero.Size = new System.Drawing.Size(42, 43);
            this.bZero.TabIndex = 17;
            this.bZero.Text = "0";
            this.bZero.UseVisualStyleBackColor = true;
            this.bZero.Click += new System.EventHandler(this.bZero_Click);
            // 
            // newFuncButt
            // 
            this.newFuncButt.Location = new System.Drawing.Point(217, 57);
            this.newFuncButt.Name = "newFuncButt";
            this.newFuncButt.Size = new System.Drawing.Size(16, 190);
            this.newFuncButt.TabIndex = 18;
            this.newFuncButt.UseVisualStyleBackColor = true;
            this.newFuncButt.Click += new System.EventHandler(this.newFuncButt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 190);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sqrtButton
            // 
            this.sqrtButton.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.sqrtButton.Location = new System.Drawing.Point(25, 253);
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
            this.radioButtonto10.Location = new System.Drawing.Point(74, 254);
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
            this.radioButtonto8.Location = new System.Drawing.Point(74, 274);
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
            this.radioButtonto2.Location = new System.Drawing.Point(121, 254);
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
            this.labelSysS.Location = new System.Drawing.Point(121, 274);
            this.labelSysS.Name = "labelSysS";
            this.labelSysS.Size = new System.Drawing.Size(112, 22);
            this.labelSysS.TabIndex = 24;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(250, 334);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.TextBoxIn1);
            this.tabPage1.Controls.Add(this.labelSysS);
            this.tabPage1.Controls.Add(this.PlusButton);
            this.tabPage1.Controls.Add(this.radioButtonto2);
            this.tabPage1.Controls.Add(this.MinusButton);
            this.tabPage1.Controls.Add(this.radioButtonto8);
            this.tabPage1.Controls.Add(this.MultiplyButton);
            this.tabPage1.Controls.Add(this.radioButtonto10);
            this.tabPage1.Controls.Add(this.DivideButton);
            this.tabPage1.Controls.Add(this.sqrtButton);
            this.tabPage1.Controls.Add(this.ClearButton);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.EqualsButton);
            this.tabPage1.Controls.Add(this.newFuncButt);
            this.tabPage1.Controls.Add(this.bOne);
            this.tabPage1.Controls.Add(this.bZero);
            this.tabPage1.Controls.Add(this.bTwo);
            this.tabPage1.Controls.Add(this.bNine);
            this.tabPage1.Controls.Add(this.bThree);
            this.tabPage1.Controls.Add(this.bEight);
            this.tabPage1.Controls.Add(this.bFour);
            this.tabPage1.Controls.Add(this.bSeven);
            this.tabPage1.Controls.Add(this.bFive);
            this.tabPage1.Controls.Add(this.bSix);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(242, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Калькулятор";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.GoButton);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.StatButton);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.radioButtonDown);
            this.tabPage2.Controls.Add(this.radioButtonUp);
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.labelOutputStringLength);
            this.tabPage2.Controls.Add(this.labelInputStringLength);
            this.tabPage2.Controls.Add(this.TBOutputLine);
            this.tabPage2.Controls.Add(this.TBInputLine);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(242, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Строки";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(173, 247);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(47, 34);
            this.GoButton.TabIndex = 4;
            this.GoButton.Text = "->";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(173, 207);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "button2";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // StatButton
            // 
            this.StatButton.Location = new System.Drawing.Point(120, 247);
            this.StatButton.Name = "StatButton";
            this.StatButton.Size = new System.Drawing.Size(47, 34);
            this.StatButton.TabIndex = 4;
            this.StatButton.Text = "%";
            this.StatButton.UseVisualStyleBackColor = true;
            this.StatButton.Click += new System.EventHandler(this.StatButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(120, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "button2";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(67, 247);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(47, 34);
            this.button7.TabIndex = 4;
            this.button7.Text = "button2";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "button 2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 247);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 34);
            this.button6.TabIndex = 4;
            this.button6.Text = "button2";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "button 2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(134, 167);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton1";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButtonDown
            // 
            this.radioButtonDown.AutoSize = true;
            this.radioButtonDown.Location = new System.Drawing.Point(134, 144);
            this.radioButtonDown.Name = "radioButtonDown";
            this.radioButtonDown.Size = new System.Drawing.Size(53, 17);
            this.radioButtonDown.TabIndex = 3;
            this.radioButtonDown.TabStop = true;
            this.radioButtonDown.Text = "Down";
            this.radioButtonDown.UseVisualStyleBackColor = true;
            // 
            // radioButtonUp
            // 
            this.radioButtonUp.AutoSize = true;
            this.radioButtonUp.Location = new System.Drawing.Point(134, 122);
            this.radioButtonUp.Name = "radioButtonUp";
            this.radioButtonUp.Size = new System.Drawing.Size(39, 17);
            this.radioButtonUp.TabIndex = 3;
            this.radioButtonUp.TabStop = true;
            this.radioButtonUp.Text = "Up";
            this.radioButtonUp.UseVisualStyleBackColor = true;
            this.radioButtonUp.CheckedChanged += new System.EventHandler(this.radioButtonUp_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(25, 168);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox1";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(25, 145);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "checkBox1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelOutputStringLength
            // 
            this.labelOutputStringLength.AutoSize = true;
            this.labelOutputStringLength.Location = new System.Drawing.Point(214, 95);
            this.labelOutputStringLength.Name = "labelOutputStringLength";
            this.labelOutputStringLength.Size = new System.Drawing.Size(0, 13);
            this.labelOutputStringLength.TabIndex = 1;
            // 
            // labelInputStringLength
            // 
            this.labelInputStringLength.AutoSize = true;
            this.labelInputStringLength.Location = new System.Drawing.Point(3, 43);
            this.labelInputStringLength.Name = "labelInputStringLength";
            this.labelInputStringLength.Size = new System.Drawing.Size(0, 13);
            this.labelInputStringLength.TabIndex = 1;
            // 
            // TBOutputLine
            // 
            this.TBOutputLine.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.TBOutputLine.Location = new System.Drawing.Point(5, 69);
            this.TBOutputLine.Name = "TBOutputLine";
            this.TBOutputLine.Size = new System.Drawing.Size(228, 23);
            this.TBOutputLine.TabIndex = 0;
            this.TBOutputLine.TextChanged += new System.EventHandler(this.TBOutputLine_TextChanged);
            // 
            // TBInputLine
            // 
            this.TBInputLine.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBInputLine.Location = new System.Drawing.Point(5, 17);
            this.TBInputLine.Name = "TBInputLine";
            this.TBInputLine.Size = new System.Drawing.Size(228, 23);
            this.TBInputLine.TabIndex = 0;
            this.TBInputLine.TextChanged += new System.EventHandler(this.TBInputLine_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(250, 332);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Калькулятор Елисеева";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelOutputStringLength;
        private System.Windows.Forms.Label labelInputStringLength;
        private System.Windows.Forms.TextBox TBOutputLine;
        private System.Windows.Forms.TextBox TBInputLine;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButtonDown;
        private System.Windows.Forms.RadioButton radioButtonUp;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button StatButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
    }
}

