namespace loginkuy
{
    partial class Temperatur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Temperature = new System.Windows.Forms.Label();
            this.tbnilai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pilihan = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.RadioButton();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperature.Location = new System.Drawing.Point(112, 21);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(284, 24);
            this.Temperature.TabIndex = 0;
            this.Temperature.Text = "TEMPERARTURE CONVERT";
            this.Temperature.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbnilai
            // 
            this.tbnilai.Location = new System.Drawing.Point(42, 98);
            this.tbnilai.Multiline = true;
            this.tbnilai.Name = "tbnilai";
            this.tbnilai.Size = new System.Drawing.Size(139, 21);
            this.tbnilai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Masukkan Nilainya";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suhu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pilih";
            // 
            // Pilihan
            // 
            this.Pilihan.FormattingEnabled = true;
            this.Pilihan.Items.AddRange(new object[] {
            "Celcius",
            "Farenheit",
            "Rearmur",
            "Kelvin"});
            this.Pilihan.Location = new System.Drawing.Point(292, 99);
            this.Pilihan.Name = "Pilihan";
            this.Pilihan.Size = new System.Drawing.Size(121, 21);
            this.Pilihan.TabIndex = 10;
            this.Pilihan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(33, 232);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 17);
            this.button5.TabIndex = 11;
            this.button5.TabStop = true;
            this.button5.Text = "Kelvin";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(33, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 17);
            this.button2.TabIndex = 12;
            this.button2.TabStop = true;
            this.button2.Text = "Farenheit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(33, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 17);
            this.button4.TabIndex = 13;
            this.button4.TabStop = true;
            this.button4.Text = "Rearmur";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(292, 185);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hasil";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Convert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Button1
            // 
            this.Button1.AutoSize = true;
            this.Button1.Location = new System.Drawing.Point(33, 165);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(59, 17);
            this.Button1.TabIndex = 18;
            this.Button1.TabStop = true;
            this.Button1.Text = "Celcius";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(324, 264);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Temperatur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(546, 329);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Pilihan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbnilai);
            this.Controls.Add(this.Temperature);
            this.Name = "Temperatur";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Temperatur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.TextBox tbnilai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox Pilihan;
        private System.Windows.Forms.RadioButton button5;
        private System.Windows.Forms.RadioButton button2;
        private System.Windows.Forms.RadioButton button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton Button1;
        private System.Windows.Forms.Button button6;
    }
}