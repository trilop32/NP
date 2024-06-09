namespace dz_MASK
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_MASK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_IP = new System.Windows.Forms.Label();
            this.label_SH = new System.Windows.Forms.Label();
            this.label_KOL = new System.Windows.Forms.Label();
            this.label_Yz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("0");
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("7");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("9");
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Items.Add("11");
            this.domainUpDown1.Items.Add("12");
            this.domainUpDown1.Items.Add("13");
            this.domainUpDown1.Items.Add("14");
            this.domainUpDown1.Items.Add("15");
            this.domainUpDown1.Items.Add("16");
            this.domainUpDown1.Items.Add("17");
            this.domainUpDown1.Items.Add("18");
            this.domainUpDown1.Items.Add("19");
            this.domainUpDown1.Items.Add("20");
            this.domainUpDown1.Items.Add("21");
            this.domainUpDown1.Items.Add("22");
            this.domainUpDown1.Items.Add("23");
            this.domainUpDown1.Items.Add("24");
            this.domainUpDown1.Items.Add("25");
            this.domainUpDown1.Items.Add("26");
            this.domainUpDown1.Items.Add("27");
            this.domainUpDown1.Items.Add("28");
            this.domainUpDown1.Items.Add("29");
            this.domainUpDown1.Items.Add("30");
            this.domainUpDown1.Items.Add("31");
            this.domainUpDown1.Items.Add("32");
            this.domainUpDown1.Location = new System.Drawing.Point(203, 70);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.domainUpDown1.Size = new System.Drawing.Size(45, 20);
            this.domainUpDown1.TabIndex = 0;
            this.domainUpDown1.Click += new System.EventHandler(this.domainUpDown1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox_MASK
            // 
            this.textBox_MASK.Location = new System.Drawing.Point(82, 70);
            this.textBox_MASK.Name = "textBox_MASK";
            this.textBox_MASK.Size = new System.Drawing.Size(100, 20);
            this.textBox_MASK.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mask:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Адресс сети:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Широковещательный адресс:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Количество IP - адрессов:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Количество узлов:";
            // 
            // label_IP
            // 
            this.label_IP.Location = new System.Drawing.Point(203, 108);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(100, 15);
            this.label_IP.TabIndex = 9;
            // 
            // label_SH
            // 
            this.label_SH.Location = new System.Drawing.Point(203, 130);
            this.label_SH.Name = "label_SH";
            this.label_SH.Size = new System.Drawing.Size(100, 13);
            this.label_SH.TabIndex = 10;
            // 
            // label_KOL
            // 
            this.label_KOL.Location = new System.Drawing.Point(203, 152);
            this.label_KOL.Name = "label_KOL";
            this.label_KOL.Size = new System.Drawing.Size(100, 13);
            this.label_KOL.TabIndex = 11;
            // 
            // label_Yz
            // 
            this.label_Yz.Location = new System.Drawing.Point(203, 174);
            this.label_Yz.Name = "label_Yz";
            this.label_Yz.Size = new System.Drawing.Size(100, 13);
            this.label_Yz.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 233);
            this.Controls.Add(this.label_Yz);
            this.Controls.Add(this.label_KOL);
            this.Controls.Add(this.label_SH);
            this.Controls.Add(this.label_IP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_MASK);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.domainUpDown1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_MASK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Label label_SH;
        private System.Windows.Forms.Label label_KOL;
        private System.Windows.Forms.Label label_Yz;
    }
}

