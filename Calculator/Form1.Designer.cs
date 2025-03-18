namespace Calculator
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            button9 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            button13 = new Button();
            btn0 = new Button();
            button16 = new Button();
            btnAdd = new Button();
            button15 = new Button();
            button18 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(13, 65);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(274, 35);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 147);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 3;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn0_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(68, 147);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 3;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn0_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(124, 147);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 3;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btn0_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(180, 147);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 3;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += operation_Performed;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(236, 147);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 3;
            button5.Text = "CE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btn4
            // 
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(12, 203);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 50);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn0_Click;
            // 
            // btn5
            // 
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(68, 203);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 50);
            btn5.TabIndex = 3;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn0_Click;
            // 
            // btn6
            // 
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(124, 203);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 50);
            btn6.TabIndex = 3;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn0_Click;
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(180, 203);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 3;
            button9.Text = "*";
            button9.UseVisualStyleBackColor = true;
            button9.Click += operation_Performed;
            // 
            // btn1
            // 
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(12, 259);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 50);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn0_Click;
            // 
            // btn2
            // 
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(68, 259);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 50);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn0_Click;
            // 
            // btn3
            // 
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(124, 259);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 50);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn0_Click;
            // 
            // button13
            // 
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.Location = new Point(180, 259);
            button13.Name = "button13";
            button13.Size = new Size(50, 50);
            button13.TabIndex = 3;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = true;
            button13.Click += operation_Performed;
            // 
            // btn0
            // 
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(12, 315);
            btn0.Name = "btn0";
            btn0.Size = new Size(106, 50);
            btn0.TabIndex = 3;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // button16
            // 
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button16.Location = new Point(124, 315);
            button16.Name = "button16";
            button16.Size = new Size(50, 50);
            button16.TabIndex = 3;
            button16.Text = ".";
            button16.UseVisualStyleBackColor = true;
            button16.Click += btn0_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(180, 315);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(50, 50);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += operation_Performed;
            // 
            // button15
            // 
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.Location = new Point(236, 203);
            button15.Name = "button15";
            button15.Size = new Size(50, 50);
            button15.TabIndex = 3;
            button15.Text = "C";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button18
            // 
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button18.Location = new Point(236, 259);
            button18.Name = "button18";
            button18.Size = new Size(50, 106);
            button18.TabIndex = 3;
            button18.Text = "=";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 389);
            Controls.Add(button18);
            Controls.Add(button15);
            Controls.Add(button5);
            Controls.Add(btnAdd);
            Controls.Add(button13);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button16);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(button3);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(button2);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button button9;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button button13;
        private Button btn0;
        private Button button16;
        private Button btnAdd;
        private Button button15;
        private Button button18;
    }
}
