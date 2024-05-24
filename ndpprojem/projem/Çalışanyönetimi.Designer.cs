namespace projem
{
    partial class Çalışanyönetimi
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
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(520, 257);
            label2.Name = "label2";
            label2.Size = new Size(432, 63);
            label2.TabIndex = 6;
            label2.Text = "Çalışan yönetimi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(113, 122);
            label1.Name = "label1";
            label1.Size = new Size(1287, 95);
            label1.TabIndex = 5;
            label1.Text = "MONOHAİR KUAFÖR SALONU";
            // 
            // button1
            // 
            button1.Location = new Point(625, 758);
            button1.Name = "button1";
            button1.Size = new Size(215, 70);
            button1.TabIndex = 16;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(677, 628);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(364, 56);
            textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(677, 505);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(364, 56);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(677, 395);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 56);
            textBox1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(439, 636);
            label5.Name = "label5";
            label5.Size = new Size(146, 48);
            label5.TabIndex = 12;
            label5.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 513);
            label4.Name = "label4";
            label4.Size = new Size(122, 48);
            label4.TabIndex = 11;
            label4.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 395);
            label3.Name = "label3";
            label3.Size = new Size(71, 48);
            label3.TabIndex = 10;
            label3.Text = "Ad";
            // 
            // Çalışanyönetimi
            // 
            AutoScaleDimensions = new SizeF(23F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1533, 1013);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Çalışanyönetimi";
            Text = "Çalışanyönetimi";
            Load += Çalışanyönetimi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}