namespace projem
{
    partial class kaydedilmişrandevular
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(629, 194);
            label2.Name = "label2";
            label2.Size = new Size(310, 63);
            label2.TabIndex = 8;
            label2.Text = "Randevular";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(146, 72);
            label1.Name = "label1";
            label1.Size = new Size(1287, 95);
            label1.TabIndex = 7;
            label1.Text = "MONOHAİR KUAFÖR SALONU";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 48;
            listBox1.Location = new Point(52, 285);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(1494, 676);
            listBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(295, 999);
            button1.Name = "button1";
            button1.Size = new Size(169, 63);
            button1.TabIndex = 10;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1142, 999);
            button2.Name = "button2";
            button2.Size = new Size(193, 59);
            button2.TabIndex = 11;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(332, 1114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1254, 56);
            textBox1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 1122);
            label3.Name = "label3";
            label3.Size = new Size(288, 48);
            label3.TabIndex = 13;
            label3.Text = "Güncel randevu";
            // 
            // button3
            // 
            button3.Location = new Point(601, 1001);
            button3.Name = "button3";
            button3.Size = new Size(428, 59);
            button3.TabIndex = 14;
            button3.Text = "Seçilen metni yazdır";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // kaydedilmişrandevular
            // 
            AutoScaleDimensions = new SizeF(23F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1666, 1199);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "kaydedilmişrandevular";
            Text = "kaydedilmişrandevular";
            Load += kaydedilmişrandevular_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label3;
        private Button button3;
    }
}