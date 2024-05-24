namespace projem
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(159, 110);
            label1.Name = "label1";
            label1.Size = new Size(1287, 95);
            label1.TabIndex = 0;
            label1.Text = "MONOHAİR KUAFÖR SALONU";
            // 
            // button1
            // 
            button1.Location = new Point(278, 379);
            button1.Name = "button1";
            button1.Size = new Size(193, 116);
            button1.TabIndex = 1;
            button1.Text = "Müşteri Ekleme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(680, 379);
            button2.Name = "button2";
            button2.Size = new Size(193, 116);
            button2.TabIndex = 2;
            button2.Text = "Randevu planlama";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1063, 379);
            button3.Name = "button3";
            button3.Size = new Size(193, 116);
            button3.TabIndex = 3;
            button3.Text = "Çalışan yönetimi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(278, 577);
            button4.Name = "button4";
            button4.Size = new Size(193, 112);
            button4.TabIndex = 4;
            button4.Text = "Hizmet yönetimi";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(661, 556);
            button5.Name = "button5";
            button5.Size = new Size(224, 154);
            button5.TabIndex = 5;
            button5.Text = "Müşteri,   Personel,  Hizmet";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1051, 597);
            button6.Name = "button6";
            button6.Size = new Size(246, 73);
            button6.TabIndex = 6;
            button6.Text = "Randevular";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(23F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1637, 1040);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
