﻿namespace HelloCsharpwin
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            Num1 = new Button();
            Num2 = new Button();
            NumScreen = new Label();
            plus = new Button();
            Num3 = new Button();
            Num4 = new Button();
            Num5 = new Button();
            Num6 = new Button();
            Num7 = new Button();
            Num8 = new Button();
            Num9 = new Button();
            Num0 = new Button();
            minus = new Button();
            equalsBtn = new Button();
            multi = new Button();
            div = new Button();
            dotBtn = new Button();
            switchPM = new Button();
            ClearBtn = new Button();
            button4 = new Button();
            SqrBtn = new Button();
            OneOverXBtn = new Button();
            backBtn = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // Num1
            // 
            Num1.BackColor = Color.White;
            Num1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num1.Location = new Point(12, 344);
            Num1.Name = "Num1";
            Num1.Size = new Size(85, 55);
            Num1.TabIndex = 0;
            Num1.Text = "1";
            Num1.UseVisualStyleBackColor = false;
            Num1.Click += NumButton_Click;
            // 
            // Num2
            // 
            Num2.BackColor = Color.White;
            Num2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num2.Location = new Point(101, 344);
            Num2.Name = "Num2";
            Num2.Size = new Size(85, 55);
            Num2.TabIndex = 1;
            Num2.Text = "2";
            Num2.UseVisualStyleBackColor = false;
            Num2.Click += NumButton_Click;
            // 
            // NumScreen
            // 
            NumScreen.BackColor = Color.White;
            NumScreen.BorderStyle = BorderStyle.Fixed3D;
            NumScreen.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            NumScreen.Location = new Point(12, 21);
            NumScreen.Name = "NumScreen";
            NumScreen.Size = new Size(357, 69);
            NumScreen.TabIndex = 2;
            NumScreen.Text = "0";
            NumScreen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // plus
            // 
            plus.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            plus.Location = new Point(284, 344);
            plus.Name = "plus";
            plus.Size = new Size(85, 55);
            plus.TabIndex = 3;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += OptBtn_Click;
            // 
            // Num3
            // 
            Num3.BackColor = Color.White;
            Num3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num3.Location = new Point(192, 344);
            Num3.Name = "Num3";
            Num3.Size = new Size(85, 55);
            Num3.TabIndex = 4;
            Num3.Text = "3";
            Num3.UseVisualStyleBackColor = false;
            Num3.Click += NumButton_Click;
            // 
            // Num4
            // 
            Num4.BackColor = Color.White;
            Num4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num4.Location = new Point(12, 285);
            Num4.Name = "Num4";
            Num4.Size = new Size(85, 55);
            Num4.TabIndex = 5;
            Num4.Text = "4";
            Num4.UseVisualStyleBackColor = false;
            Num4.Click += NumButton_Click;
            // 
            // Num5
            // 
            Num5.BackColor = Color.White;
            Num5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num5.Location = new Point(101, 285);
            Num5.Name = "Num5";
            Num5.Size = new Size(85, 55);
            Num5.TabIndex = 6;
            Num5.Text = "5";
            Num5.UseVisualStyleBackColor = false;
            Num5.Click += NumButton_Click;
            // 
            // Num6
            // 
            Num6.BackColor = Color.White;
            Num6.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num6.Location = new Point(191, 285);
            Num6.Name = "Num6";
            Num6.Size = new Size(85, 55);
            Num6.TabIndex = 7;
            Num6.Text = "6";
            Num6.UseVisualStyleBackColor = false;
            Num6.Click += NumButton_Click;
            // 
            // Num7
            // 
            Num7.BackColor = Color.White;
            Num7.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num7.Location = new Point(12, 224);
            Num7.Name = "Num7";
            Num7.Size = new Size(85, 55);
            Num7.TabIndex = 8;
            Num7.Text = "7";
            Num7.UseVisualStyleBackColor = false;
            Num7.Click += NumButton_Click;
            // 
            // Num8
            // 
            Num8.BackColor = Color.White;
            Num8.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num8.Location = new Point(101, 224);
            Num8.Name = "Num8";
            Num8.Size = new Size(85, 55);
            Num8.TabIndex = 9;
            Num8.Text = "8";
            Num8.UseVisualStyleBackColor = false;
            Num8.Click += NumButton_Click;
            // 
            // Num9
            // 
            Num9.BackColor = Color.White;
            Num9.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num9.Location = new Point(191, 224);
            Num9.Name = "Num9";
            Num9.Size = new Size(85, 55);
            Num9.TabIndex = 10;
            Num9.Text = "9";
            Num9.UseVisualStyleBackColor = false;
            Num9.Click += NumButton_Click;
            // 
            // Num0
            // 
            Num0.BackColor = Color.White;
            Num0.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num0.Location = new Point(101, 404);
            Num0.Name = "Num0";
            Num0.Size = new Size(85, 55);
            Num0.TabIndex = 11;
            Num0.Text = "0";
            Num0.UseVisualStyleBackColor = false;
            Num0.Click += NumButton_Click;
            // 
            // minus
            // 
            minus.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold);
            minus.Location = new Point(284, 285);
            minus.Name = "minus";
            minus.Size = new Size(85, 55);
            minus.TabIndex = 12;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += OptBtn_Click;
            // 
            // equalsBtn
            // 
            equalsBtn.BackColor = Color.Black;
            equalsBtn.FlatStyle = FlatStyle.Flat;
            equalsBtn.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            equalsBtn.ForeColor = SystemColors.ButtonHighlight;
            equalsBtn.Location = new Point(284, 404);
            equalsBtn.Name = "equalsBtn";
            equalsBtn.Size = new Size(85, 55);
            equalsBtn.TabIndex = 13;
            equalsBtn.Text = "=";
            equalsBtn.UseVisualStyleBackColor = false;
            equalsBtn.Click += OptBtn_Click;
            // 
            // multi
            // 
            multi.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            multi.Location = new Point(284, 224);
            multi.Name = "multi";
            multi.Size = new Size(85, 55);
            multi.TabIndex = 14;
            multi.Text = "x";
            multi.UseVisualStyleBackColor = true;
            multi.Click += OptBtn_Click;
            // 
            // div
            // 
            div.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold);
            div.Location = new Point(284, 164);
            div.Name = "div";
            div.Size = new Size(85, 55);
            div.TabIndex = 15;
            div.Text = "÷";
            div.UseVisualStyleBackColor = true;
            div.Click += OptBtn_Click;
            // 
            // dotBtn
            // 
            dotBtn.BackColor = Color.White;
            dotBtn.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            dotBtn.Location = new Point(192, 404);
            dotBtn.Name = "dotBtn";
            dotBtn.Size = new Size(85, 55);
            dotBtn.TabIndex = 16;
            dotBtn.Text = ".";
            dotBtn.UseVisualStyleBackColor = false;
            dotBtn.Click += dotBtn_Click;
            // 
            // switchPM
            // 
            switchPM.BackColor = Color.White;
            switchPM.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            switchPM.Location = new Point(12, 403);
            switchPM.Name = "switchPM";
            switchPM.Size = new Size(85, 55);
            switchPM.TabIndex = 17;
            switchPM.Text = "+/-";
            switchPM.UseVisualStyleBackColor = false;
            switchPM.Click += switchPM_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            ClearBtn.Location = new Point(192, 103);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(85, 55);
            ClearBtn.TabIndex = 18;
            ClearBtn.Text = "C";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // button4
            // 
            button4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button4.Location = new Point(191, 164);
            button4.Name = "button4";
            button4.Size = new Size(85, 55);
            button4.TabIndex = 19;
            button4.Text = "²√𝓍";
            button4.UseVisualStyleBackColor = true;
            // 
            // SqrBtn
            // 
            SqrBtn.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            SqrBtn.Location = new Point(101, 164);
            SqrBtn.Name = "SqrBtn";
            SqrBtn.Size = new Size(85, 55);
            SqrBtn.TabIndex = 20;
            SqrBtn.Text = "𝓍²";
            SqrBtn.UseVisualStyleBackColor = true;
            SqrBtn.Click += SqrBtn_Click;
            // 
            // OneOverXBtn
            // 
            OneOverXBtn.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            OneOverXBtn.Location = new Point(12, 164);
            OneOverXBtn.Name = "OneOverXBtn";
            OneOverXBtn.Size = new Size(85, 55);
            OneOverXBtn.TabIndex = 21;
            OneOverXBtn.Text = "1/𝓍";
            OneOverXBtn.UseVisualStyleBackColor = true;
            OneOverXBtn.Click += OneOverXBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(283, 103);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(85, 55);
            backBtn.TabIndex = 22;
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // button8
            // 
            button8.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button8.Location = new Point(101, 103);
            button8.Name = "button8";
            button8.Size = new Size(85, 55);
            button8.TabIndex = 23;
            button8.Text = "CE";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button9.Location = new Point(12, 103);
            button9.Name = "button9";
            button9.Size = new Size(85, 55);
            button9.TabIndex = 24;
            button9.Text = "%";
            button9.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(386, 487);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(backBtn);
            Controls.Add(OneOverXBtn);
            Controls.Add(SqrBtn);
            Controls.Add(button4);
            Controls.Add(ClearBtn);
            Controls.Add(switchPM);
            Controls.Add(dotBtn);
            Controls.Add(div);
            Controls.Add(multi);
            Controls.Add(equalsBtn);
            Controls.Add(minus);
            Controls.Add(Num0);
            Controls.Add(Num9);
            Controls.Add(Num8);
            Controls.Add(Num7);
            Controls.Add(Num6);
            Controls.Add(Num5);
            Controls.Add(Num4);
            Controls.Add(Num3);
            Controls.Add(plus);
            Controls.Add(NumScreen);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Name = "Calculator";
            Text = "계산기";
            Load += Calculator_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Num1;
        private Button Num2;
        private Label NumScreen;
        private Button plus;
        private Button Num3;
        private Button Num4;
        private Button Num5;
        private Button Num6;
        private Button Num7;
        private Button Num8;
        private Button Num9;
        private Button Num0;
        private Button minus;
        private Button equalsBtn;
        private Button multi;
        private Button div;
        private Button dotBtn;
        private Button switchPM;
        private Button ClearBtn;
        private Button button4;
        private Button SqrBtn;
        private Button OneOverXBtn;
        private Button backBtn;
        private Button button8;
        private Button button9;
    }
}
