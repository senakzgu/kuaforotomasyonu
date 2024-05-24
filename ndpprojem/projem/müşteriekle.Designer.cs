namespace projem
{
    partial class müşteriekle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(184, 97);
            label1.Name = "label1";
            label1.Size = new Size(1287, 95);
            label1.TabIndex = 1;
            label1.Text = "MONOHAİR KUAFÖR SALONU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(591, 232);
            label2.Name = "label2";
            label2.Size = new Size(403, 63);
            label2.TabIndex = 2;
            label2.Text = "Müşteri ekleme";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 404);
            label3.Name = "label3";
            label3.Size = new Size(71, 48);
            label3.TabIndex = 3;
            label3.Text = "Ad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 522);
            label4.Name = "label4";
            label4.Size = new Size(122, 48);
            label4.TabIndex = 4;
            label4.Text = "Soyad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(464, 645);
            label5.Name = "label5";
            label5.Size = new Size(146, 48);
            label5.TabIndex = 5;
            label5.Text = "Telefon";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(702, 404);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 56);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(702, 514);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(364, 56);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(702, 637);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(364, 56);
            textBox3.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(645, 859);
            button1.Name = "button1";
            button1.Size = new Size(215, 70);
            button1.TabIndex = 9;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(702, 739);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(364, 56);
            textBox4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(464, 747);
            label6.Name = "label6";
            label6.Size = new Size(61, 48);
            label6.TabIndex = 10;
            label6.Text = "Tc";
            // 
            // müşteriekle
            // 
            AutoScaleDimensions = new SizeF(23F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1656, 1053);
            Controls.Add(textBox4);
            Controls.Add(label6);
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
            Name = "müşteriekle";
            Text = "müşteriekle";
            Load += müşteriekle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private TextBox textBox4;
        private Label label6;
    }
}