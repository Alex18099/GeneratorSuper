namespace GeneratorSuper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbComputer = new System.Windows.Forms.RadioButton();
            this.rbSegmented = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkUppercase = new System.Windows.Forms.CheckBox();
            this.chkLowercase = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericLength = new System.Windows.Forms.NumericUpDown();
            this.numericSegmentSize = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkPovtorenie = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericSegmentCount = new System.Windows.Forms.NumericUpDown();
            this.picture_box1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSegmentSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSegmentCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbComputer
            // 
            this.rbComputer.AutoSize = true;
            this.rbComputer.BackColor = System.Drawing.SystemColors.Window;
            this.rbComputer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rbComputer.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbComputer.Location = new System.Drawing.Point(65, 235);
            this.rbComputer.Name = "rbComputer";
            this.rbComputer.Size = new System.Drawing.Size(143, 24);
            this.rbComputer.TabIndex = 0;
            this.rbComputer.TabStop = true;
            this.rbComputer.Text = "Компьютерный";
            this.rbComputer.UseVisualStyleBackColor = false;
            // 
            // rbSegmented
            // 
            this.rbSegmented.AutoSize = true;
            this.rbSegmented.BackColor = System.Drawing.SystemColors.Window;
            this.rbSegmented.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rbSegmented.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbSegmented.Location = new System.Drawing.Point(65, 310);
            this.rbSegmented.Name = "rbSegmented";
            this.rbSegmented.Size = new System.Drawing.Size(122, 24);
            this.rbSegmented.TabIndex = 1;
            this.rbSegmented.TabStop = true;
            this.rbSegmented.Text = "Сегментный";
            this.rbSegmented.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Black", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtPassword.Location = new System.Drawing.Point(257, 57);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(470, 38);
            this.txtPassword.TabIndex = 2;
            // 
            // chkUppercase
            // 
            this.chkUppercase.AutoSize = true;
            this.chkUppercase.BackColor = System.Drawing.SystemColors.Window;
            this.chkUppercase.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkUppercase.ForeColor = System.Drawing.Color.SteelBlue;
            this.chkUppercase.Location = new System.Drawing.Point(563, 256);
            this.chkUppercase.Name = "chkUppercase";
            this.chkUppercase.Size = new System.Drawing.Size(137, 23);
            this.chkUppercase.TabIndex = 3;
            this.chkUppercase.Text = "Заглавные буквы";
            this.chkUppercase.UseVisualStyleBackColor = false;
            // 
            // chkLowercase
            // 
            this.chkLowercase.AutoSize = true;
            this.chkLowercase.BackColor = System.Drawing.SystemColors.Window;
            this.chkLowercase.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkLowercase.ForeColor = System.Drawing.Color.SteelBlue;
            this.chkLowercase.Location = new System.Drawing.Point(721, 256);
            this.chkLowercase.Name = "chkLowercase";
            this.chkLowercase.Size = new System.Drawing.Size(135, 23);
            this.chkLowercase.TabIndex = 4;
            this.chkLowercase.Text = "Строчные буквы";
            this.chkLowercase.UseVisualStyleBackColor = false;
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.BackColor = System.Drawing.SystemColors.Window;
            this.chkNumbers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkNumbers.ForeColor = System.Drawing.Color.SteelBlue;
            this.chkNumbers.Location = new System.Drawing.Point(872, 256);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(74, 23);
            this.chkNumbers.TabIndex = 5;
            this.chkNumbers.Text = "Цифры";
            this.chkNumbers.UseVisualStyleBackColor = false;
            // 
            // chkSymbols
            // 
            this.chkSymbols.AutoSize = true;
            this.chkSymbols.BackColor = System.Drawing.SystemColors.Window;
            this.chkSymbols.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkSymbols.ForeColor = System.Drawing.Color.SteelBlue;
            this.chkSymbols.Location = new System.Drawing.Point(563, 292);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Size = new System.Drawing.Size(122, 23);
            this.chkSymbols.TabIndex = 6;
            this.chkSymbols.Text = "Спец.Символы";
            this.chkSymbols.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(563, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Параметры:";
            // 
            // numericLength
            // 
            this.numericLength.ForeColor = System.Drawing.Color.SteelBlue;
            this.numericLength.Location = new System.Drawing.Point(563, 381);
            this.numericLength.Name = "numericLength";
            this.numericLength.Size = new System.Drawing.Size(120, 23);
            this.numericLength.TabIndex = 8;
            // 
            // numericSegmentSize
            // 
            this.numericSegmentSize.ForeColor = System.Drawing.Color.SteelBlue;
            this.numericSegmentSize.Location = new System.Drawing.Point(721, 381);
            this.numericSegmentSize.Name = "numericSegmentSize";
            this.numericSegmentSize.Size = new System.Drawing.Size(120, 23);
            this.numericSegmentSize.TabIndex = 9;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(377, 108);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(222, 34);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Создай свой пароль";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(65, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "Составляет сложные пароли. \r\nЧем они длинее, тем труднее их подобрать.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(65, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 57);
            this.label3.TabIndex = 12;
            this.label3.Text = "Составляет сложные пароли. \r\nАналог компьютерного, но с добавлением разделителя в" +
    " виде тире, \r\nчтобы было легче запомнить";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(563, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Наборы символов:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(65, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Тип генератора:";
            // 
            // chkPovtorenie
            // 
            this.chkPovtorenie.AutoSize = true;
            this.chkPovtorenie.BackColor = System.Drawing.SystemColors.Window;
            this.chkPovtorenie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkPovtorenie.ForeColor = System.Drawing.Color.SteelBlue;
            this.chkPovtorenie.Location = new System.Drawing.Point(721, 292);
            this.chkPovtorenie.Name = "chkPovtorenie";
            this.chkPovtorenie.Size = new System.Drawing.Size(177, 23);
            this.chkPovtorenie.TabIndex = 15;
            this.chkPovtorenie.Text = "Исключить повторения";
            this.chkPovtorenie.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(563, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Сегменты:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(721, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Количество:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(563, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Длина";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(323, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(345, 45);
            this.label9.TabIndex = 19;
            this.label9.Text = "Генератор паролей";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // numericSegmentCount
            // 
            this.numericSegmentCount.ForeColor = System.Drawing.Color.SteelBlue;
            this.numericSegmentCount.Location = new System.Drawing.Point(563, 410);
            this.numericSegmentCount.Name = "numericSegmentCount";
            this.numericSegmentCount.Size = new System.Drawing.Size(120, 23);
            this.numericSegmentCount.TabIndex = 20;
            // 
            // picture_box1
            // 
            this.picture_box1.BackgroundImage = global::GeneratorSuper.Properties.Resources.back3;
            this.picture_box1.Location = new System.Drawing.Point(12, 170);
            this.picture_box1.Name = "picture_box1";
            this.picture_box1.Size = new System.Drawing.Size(946, 286);
            this.picture_box1.TabIndex = 22;
            this.picture_box1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::GeneratorSuper.Properties.Resources.fonsiniy;
            this.ClientSize = new System.Drawing.Size(970, 498);
            this.Controls.Add(this.numericSegmentCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkPovtorenie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.numericSegmentSize);
            this.Controls.Add(this.numericLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkSymbols);
            this.Controls.Add(this.chkNumbers);
            this.Controls.Add(this.chkLowercase);
            this.Controls.Add(this.chkUppercase);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.rbSegmented);
            this.Controls.Add(this.rbComputer);
            this.Controls.Add(this.picture_box1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSegmentSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSegmentCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbComputer;
        private RadioButton rbSegmented;
        private TextBox txtPassword;
        private CheckBox chkUppercase;
        private CheckBox chkLowercase;
        private CheckBox chkNumbers;
        private CheckBox chkSymbols;
        private Label label1;
        private NumericUpDown numericLength;
        private NumericUpDown numericUpDown2;
        private Button btnGenerate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox chkPovtorenie;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private NumericUpDown numericSegmentSize;
        private NumericUpDown numericSegmentCount;
        private PictureBox picture_box1;
    }
}