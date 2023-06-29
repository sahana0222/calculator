namespace calculator
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
            txtTotal = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonPlus = new Button();
            buttonMin = new Button();
            buttonMul = new Button();
            buttonDivi = new Button();
            buttonClear = new Button();
            buttonEqual = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(12, 29);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(376, 49);
            txtTotal.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 84);
            button1.Name = "button1";
            button1.Size = new Size(68, 52);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(86, 84);
            button2.Name = "button2";
            button2.Size = new Size(68, 52);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(160, 84);
            button3.Name = "button3";
            button3.Size = new Size(68, 52);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(234, 84);
            button4.Name = "button4";
            button4.Size = new Size(68, 52);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(308, 84);
            button5.Name = "button5";
            button5.Size = new Size(68, 52);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 142);
            button6.Name = "button6";
            button6.Size = new Size(68, 52);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(86, 142);
            button7.Name = "button7";
            button7.Size = new Size(68, 52);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(160, 142);
            button8.Name = "button8";
            button8.Size = new Size(68, 52);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(234, 142);
            button9.Name = "button9";
            button9.Size = new Size(68, 52);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(308, 142);
            button0.Name = "button0";
            button0.Size = new Size(68, 52);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(12, 199);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(68, 52);
            buttonPlus.TabIndex = 11;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMin
            // 
            buttonMin.Location = new Point(86, 199);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new Size(68, 52);
            buttonMin.TabIndex = 12;
            buttonMin.Text = "-";
            buttonMin.UseVisualStyleBackColor = true;
            buttonMin.Click += buttonMin_Click;
            // 
            // buttonMul
            // 
            buttonMul.Location = new Point(160, 200);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(68, 52);
            buttonMul.TabIndex = 13;
            buttonMul.Text = "*";
            buttonMul.UseVisualStyleBackColor = true;
            buttonMul.Click += buttonMul_Click;
            // 
            // buttonDivi
            // 
            buttonDivi.Location = new Point(234, 200);
            buttonDivi.Name = "buttonDivi";
            buttonDivi.Size = new Size(68, 52);
            buttonDivi.TabIndex = 14;
            buttonDivi.Text = "/";
            buttonDivi.UseVisualStyleBackColor = true;
            buttonDivi.Click += buttonDivi_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(308, 199);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(68, 52);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(12, 287);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(364, 52);
            buttonEqual.TabIndex = 16;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 418);
            Controls.Add(buttonEqual);
            Controls.Add(buttonClear);
            Controls.Add(buttonDivi);
            Controls.Add(buttonMul);
            Controls.Add(buttonMin);
            Controls.Add(buttonPlus);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTotal);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonPlus;
        private Button buttonMin;
        private Button buttonMul;
        private Button buttonDivi;
        private Button buttonClear;
        private Button buttonEqual;
    }
}