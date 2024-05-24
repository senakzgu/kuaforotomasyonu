namespace projem
{
    partial class Randevu
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
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBoxhizmet = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(528, 237);
            label2.Name = "label2";
            label2.Size = new Size(485, 63);
            label2.TabIndex = 4;
            label2.Text = "Randevu Planlama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(121, 102);
            label1.Name = "label1";
            label1.Size = new Size(1287, 95);
            label1.TabIndex = 3;
            label1.Text = "MONOHAİR KUAFÖR SALONU";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(315, 552);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(343, 56);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 398);
            label3.Name = "label3";
            label3.Size = new Size(143, 48);
            label3.TabIndex = 6;
            label3.Text = "Hizmet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 552);
            label4.Name = "label4";
            label4.Size = new Size(111, 48);
            label4.TabIndex = 7;
            label4.Text = "Tarih";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 708);
            label5.Name = "label5";
            label5.Size = new Size(93, 48);
            label5.TabIndex = 8;
            label5.Text = "Saat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(881, 398);
            label6.Name = "label6";
            label6.Size = new Size(164, 48);
            label6.TabIndex = 9;
            label6.Text = "Personel";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(881, 542);
            label7.Name = "label7";
            label7.Size = new Size(151, 48);
            label7.TabIndex = 10;
            label7.Text = "Müşteri";
            // 
            // comboBoxhizmet
            // 
            comboBoxhizmet.FormattingEnabled = true;
            comboBoxhizmet.Location = new Point(315, 398);
            comboBoxhizmet.Name = "comboBoxhizmet";
            comboBoxhizmet.Size = new Size(379, 56);
            comboBoxhizmet.TabIndex = 11;
            comboBoxhizmet.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "09:00", "10:00", "11:00", "12:00", "15:00", "16:00", "17:00", "16:00" });
            comboBox2.Location = new Point(315, 708);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(379, 56);
            comboBox2.TabIndex = 12;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(1125, 398);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(375, 56);
            comboBox3.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(629, 846);
            button1.Name = "button1";
            button1.Size = new Size(233, 81);
            button1.TabIndex = 15;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1125, 534);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(375, 56);
            comboBox1.TabIndex = 16;
            // 
            // Randevu
            // 
            AutoScaleDimensions = new SizeF(23F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1625, 1062);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBoxhizmet);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Randevu";
            Text = "Randevu";
            Load += Randevu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public ComboBox comboBoxhizmet;
        public ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button1;
        private ComboBox comboBox1;
    }
}