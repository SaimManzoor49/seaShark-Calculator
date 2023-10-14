namespace calcalutor_forReal
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button15 = new Button();
            button16 = new Button();
            button14 = new Button();
            button17 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(11, 83);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(444, 55);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(11, 165);
            button1.Name = "button1";
            button1.Size = new Size(94, 53);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += getInt;
            // 
            // button2
            // 
            button2.Location = new Point(127, 165);
            button2.Name = "button2";
            button2.Size = new Size(94, 53);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += getInt;
            // 
            // button3
            // 
            button3.Location = new Point(361, 165);
            button3.Name = "button3";
            button3.Size = new Size(94, 53);
            button3.TabIndex = 2;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += getOp;
            // 
            // button4
            // 
            button4.Location = new Point(245, 165);
            button4.Name = "button4";
            button4.Size = new Size(94, 53);
            button4.TabIndex = 2;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += getInt;
            // 
            // button5
            // 
            button5.Location = new Point(11, 238);
            button5.Name = "button5";
            button5.Size = new Size(94, 53);
            button5.TabIndex = 2;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += getInt;
            // 
            // button6
            // 
            button6.Location = new Point(127, 238);
            button6.Name = "button6";
            button6.Size = new Size(94, 53);
            button6.TabIndex = 2;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += getInt;
            // 
            // button7
            // 
            button7.Location = new Point(361, 238);
            button7.Name = "button7";
            button7.Size = new Size(94, 53);
            button7.TabIndex = 2;
            button7.Text = "-";
            button7.UseVisualStyleBackColor = true;
            button7.Click += getOp;
            // 
            // button8
            // 
            button8.Location = new Point(245, 238);
            button8.Name = "button8";
            button8.Size = new Size(94, 53);
            button8.TabIndex = 2;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = true;
            button8.Click += getInt;
            // 
            // button9
            // 
            button9.Location = new Point(11, 319);
            button9.Name = "button9";
            button9.Size = new Size(94, 53);
            button9.TabIndex = 2;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            button9.Click += getInt;
            // 
            // button10
            // 
            button10.Location = new Point(127, 319);
            button10.Name = "button10";
            button10.Size = new Size(94, 53);
            button10.TabIndex = 2;
            button10.Text = "8";
            button10.UseVisualStyleBackColor = true;
            button10.Click += getInt;
            // 
            // button11
            // 
            button11.Location = new Point(361, 319);
            button11.Name = "button11";
            button11.Size = new Size(94, 53);
            button11.TabIndex = 2;
            button11.Text = "*";
            button11.UseVisualStyleBackColor = true;
            button11.Click += getOp;
            // 
            // button12
            // 
            button12.Location = new Point(245, 319);
            button12.Name = "button12";
            button12.Size = new Size(94, 53);
            button12.TabIndex = 2;
            button12.Text = "9";
            button12.UseVisualStyleBackColor = true;
            button12.Click += getInt;
            // 
            // button13
            // 
            button13.Location = new Point(11, 398);
            button13.Name = "button13";
            button13.Size = new Size(94, 53);
            button13.TabIndex = 2;
            button13.Text = "0";
            button13.UseVisualStyleBackColor = true;
            button13.Click += getInt;
            // 
            // button15
            // 
            button15.Location = new Point(361, 468);
            button15.Name = "button15";
            button15.Size = new Size(94, 53);
            button15.TabIndex = 2;
            button15.Text = "C";
            button15.UseVisualStyleBackColor = true;
            button15.Click += clear;
            // 
            // button16
            // 
            button16.Location = new Point(127, 399);
            button16.Name = "button16";
            button16.Size = new Size(212, 53);
            button16.TabIndex = 2;
            button16.Text = "=";
            button16.UseVisualStyleBackColor = true;
            button16.Click += equalTofun;
            // 
            // button14
            // 
            button14.Location = new Point(12, 468);
            button14.Name = "button14";
            button14.Size = new Size(327, 53);
            button14.TabIndex = 2;
            button14.Text = "AC";
            button14.UseVisualStyleBackColor = true;
            button14.Click += allClear;
            // 
            // button17
            // 
            button17.Location = new Point(361, 398);
            button17.Name = "button17";
            button17.Size = new Size(94, 53);
            button17.TabIndex = 2;
            button17.Text = "/";
            button17.UseVisualStyleBackColor = true;
            button17.Click += getOp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(148, 39);
            label1.Name = "label1";
            label1.Size = new Size(0, 41);
            label1.TabIndex = 3;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(473, 548);
            Controls.Add(label1);
            Controls.Add(button14);
            Controls.Add(button16);
            Controls.Add(button12);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button17);
            Controls.Add(button15);
            Controls.Add(button11);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button13);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "😁 Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button15;
        private Button button16;
        private Button button14;
        private Button button17;
        private Label label1;
    }
}