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
            this.SuspendLayout();
            // 
            // TextBoxIn1
            // 
            this.TextBoxIn1.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxIn1.Location = new System.Drawing.Point(12, 28);
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
            this.PlusButton.Location = new System.Drawing.Point(174, 226);
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
            this.MinusButton.Location = new System.Drawing.Point(174, 177);
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
            this.MultiplyButton.Location = new System.Drawing.Point(174, 79);
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
            this.DivideButton.Location = new System.Drawing.Point(174, 128);
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
            this.ClearButton.Location = new System.Drawing.Point(30, 226);
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
            this.EqualsButton.Location = new System.Drawing.Point(126, 226);
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
            this.bOne.Location = new System.Drawing.Point(30, 79);
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
            this.bTwo.Location = new System.Drawing.Point(78, 79);
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
            this.bThree.Location = new System.Drawing.Point(126, 79);
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
            this.bFour.Location = new System.Drawing.Point(30, 128);
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
            this.bFive.Location = new System.Drawing.Point(78, 128);
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
            this.bSix.Location = new System.Drawing.Point(126, 128);
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
            this.bSeven.Location = new System.Drawing.Point(30, 177);
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
            this.bEight.Location = new System.Drawing.Point(78, 177);
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
            this.bNine.Location = new System.Drawing.Point(126, 177);
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
            this.bZero.Location = new System.Drawing.Point(78, 226);
            this.bZero.Name = "bZero";
            this.bZero.Size = new System.Drawing.Size(42, 43);
            this.bZero.TabIndex = 17;
            this.bZero.Text = "0";
            this.bZero.UseVisualStyleBackColor = true;
            this.bZero.Click += new System.EventHandler(this.bZero_Click);
            // 
            // newFuncButt
            // 
            this.newFuncButt.Location = new System.Drawing.Point(222, 79);
            this.newFuncButt.Name = "newFuncButt";
            this.newFuncButt.Size = new System.Drawing.Size(16, 190);
            this.newFuncButt.TabIndex = 18;
            this.newFuncButt.UseVisualStyleBackColor = true;
            this.newFuncButt.Click += new System.EventHandler(this.newFuncButt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 190);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sqrtButton
            // 
            this.sqrtButton.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.sqrtButton.Location = new System.Drawing.Point(30, 275);
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
            this.radioButtonto10.Location = new System.Drawing.Point(79, 276);
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
            this.radioButtonto8.Location = new System.Drawing.Point(79, 296);
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
            this.radioButtonto2.Location = new System.Drawing.Point(126, 276);
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
            this.labelSysS.Location = new System.Drawing.Point(126, 296);
            this.labelSysS.Name = "labelSysS";
            this.labelSysS.Size = new System.Drawing.Size(112, 22);
            this.labelSysS.TabIndex = 24;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(250, 332);
            this.Controls.Add(this.labelSysS);
            this.Controls.Add(this.radioButtonto2);
            this.Controls.Add(this.radioButtonto8);
            this.Controls.Add(this.radioButtonto10);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newFuncButt);
            this.Controls.Add(this.bZero);
            this.Controls.Add(this.bNine);
            this.Controls.Add(this.bEight);
            this.Controls.Add(this.bSeven);
            this.Controls.Add(this.bSix);
            this.Controls.Add(this.bFive);
            this.Controls.Add(this.bFour);
            this.Controls.Add(this.bThree);
            this.Controls.Add(this.bTwo);
            this.Controls.Add(this.bOne);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.TextBoxIn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Калькулятор Елисеева";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

