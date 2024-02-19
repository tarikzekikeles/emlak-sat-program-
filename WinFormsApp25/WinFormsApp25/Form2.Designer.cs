namespace WinFormsApp25
{
    partial class Form2
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox3 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            label12 = new Label();
            btnZambak = new Button();
            label13 = new Label();
            btnGul = new Button();
            btnMenekse = new Button();
            btnPapatya = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            buttonGoruntule = new Button();
            buttonKaydet = new Button();
            buttonSil = new Button();
            buttonDuzelt = new Button();
            label14 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            comboBox4 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 24);
            label1.TabIndex = 0;
            label1.Text = "gayrimenkul bilgiler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 72);
            label2.Name = "label2";
            label2.Size = new Size(34, 23);
            label2.TabIndex = 1;
            label2.Text = "site";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Zambak Sitesi", "Papatya Sitesi", "Gül Sİtesi", "Menekşe Sitesi" });
            comboBox1.Location = new Point(101, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "satılık", "kiralık" });
            comboBox2.Location = new Point(101, 121);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 122);
            label3.Name = "label3";
            label3.Size = new Size(72, 23);
            label3.TabIndex = 3;
            label3.Text = "sat/kira";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1 + 1", "2 + 1", "3 + 1", "4 + 1" });
            comboBox3.Location = new Point(101, 173);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calisto MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 173);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 5;
            label4.Text = "oda sayısı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calisto MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 226);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 7;
            label5.Text = "metrekare";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calisto MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(51, 275);
            label6.Name = "label6";
            label6.Size = new Size(44, 23);
            label6.TabIndex = 9;
            label6.Text = "fiyat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(411, 9);
            label8.Name = "label8";
            label8.Size = new Size(137, 24);
            label8.TabIndex = 13;
            label8.Text = "iletişim bilgileri";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calisto MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(328, 72);
            label9.Name = "label9";
            label9.Size = new Size(77, 23);
            label9.TabIndex = 14;
            label9.Text = "ad soyad";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calisto MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(346, 124);
            label10.Name = "label10";
            label10.Size = new Size(59, 23);
            label10.TabIndex = 16;
            label10.Text = "telefon";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calisto MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(349, 170);
            label11.Name = "label11";
            label11.Size = new Size(56, 23);
            label11.TabIndex = 18;
            label11.Text = "notlar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 275);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(411, 166);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 91);
            textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(411, 72);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 27);
            textBox4.TabIndex = 21;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(411, 120);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(151, 27);
            textBox5.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calisto MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(53, 327);
            label7.Name = "label7";
            label7.Size = new Size(42, 23);
            label7.TabIndex = 23;
            label7.Text = "blok";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calisto MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(188, 323);
            label12.Name = "label12";
            label12.Size = new Size(29, 23);
            label12.TabIndex = 26;
            label12.Text = "no";
            // 
            // btnZambak
            // 
            btnZambak.BackColor = SystemColors.ActiveBorder;
            btnZambak.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZambak.Location = new Point(707, 16);
            btnZambak.Name = "btnZambak";
            btnZambak.Size = new Size(98, 41);
            btnZambak.TabIndex = 27;
            btnZambak.Text = "ZAMBAK";
            btnZambak.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calisto MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(743, 72);
            label13.Name = "label13";
            label13.Size = new Size(34, 23);
            label13.TabIndex = 28;
            label13.Text = "site";
            // 
            // btnGul
            // 
            btnGul.BackColor = SystemColors.ActiveBorder;
            btnGul.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGul.Location = new Point(620, 58);
            btnGul.Name = "btnGul";
            btnGul.Size = new Size(98, 41);
            btnGul.TabIndex = 29;
            btnGul.Text = "GÜL";
            btnGul.UseVisualStyleBackColor = false;
            // 
            // btnMenekse
            // 
            btnMenekse.BackColor = SystemColors.ActiveBorder;
            btnMenekse.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenekse.Location = new Point(707, 102);
            btnMenekse.Name = "btnMenekse";
            btnMenekse.Size = new Size(98, 41);
            btnMenekse.TabIndex = 30;
            btnMenekse.Text = "MENEKŞE";
            btnMenekse.UseVisualStyleBackColor = false;
            // 
            // btnPapatya
            // 
            btnPapatya.BackColor = SystemColors.ActiveBorder;
            btnPapatya.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPapatya.Location = new Point(808, 59);
            btnPapatya.Name = "btnPapatya";
            btnPapatya.Size = new Size(98, 41);
            btnPapatya.TabIndex = 30;
            btnPapatya.Text = "PAPATYA";
            btnPapatya.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.Location = new Point(101, 372);
            listView1.Name = "listView1";
            listView1.Size = new Size(725, 183);
            listView1.TabIndex = 31;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "site";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "oda";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "metre";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "fiyat";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "blok";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "no";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "adsoyad";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "telefon";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "notlar";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "satkira";
            // 
            // buttonGoruntule
            // 
            buttonGoruntule.Location = new Point(386, 323);
            buttonGoruntule.Name = "buttonGoruntule";
            buttonGoruntule.Size = new Size(94, 29);
            buttonGoruntule.TabIndex = 32;
            buttonGoruntule.Text = "Görüntüle";
            buttonGoruntule.UseVisualStyleBackColor = true;
            buttonGoruntule.Click += buttonGoruntule_Click;
            // 
            // buttonKaydet
            // 
            buttonKaydet.Location = new Point(486, 323);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(94, 29);
            buttonKaydet.TabIndex = 33;
            buttonKaydet.Text = "kaydet";
            buttonKaydet.UseVisualStyleBackColor = true;
            buttonKaydet.Click += buttonKaydet_Click;
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(586, 323);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(94, 29);
            buttonSil.TabIndex = 34;
            buttonSil.Text = "sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // buttonDuzelt
            // 
            buttonDuzelt.Location = new Point(686, 323);
            buttonDuzelt.Name = "buttonDuzelt";
            buttonDuzelt.Size = new Size(94, 29);
            buttonDuzelt.TabIndex = 35;
            buttonDuzelt.Text = "düzelt";
            buttonDuzelt.UseVisualStyleBackColor = true;
            buttonDuzelt.Click += buttonDuzelt_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calisto MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(61, 40);
            label14.Name = "label14";
            label14.Size = new Size(25, 23);
            label14.TabIndex = 36;
            label14.Text = "id";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(101, 36);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(151, 27);
            textBox6.TabIndex = 37;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(232, 322);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(45, 27);
            textBox7.TabIndex = 38;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(101, 222);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(151, 27);
            textBox8.TabIndex = 39;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "A", "B", "C" });
            comboBox4.Location = new Point(101, 322);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(53, 28);
            comboBox4.TabIndex = 40;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1247, 627);
            Controls.Add(comboBox4);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label14);
            Controls.Add(buttonDuzelt);
            Controls.Add(buttonSil);
            Controls.Add(buttonKaydet);
            Controls.Add(buttonGoruntule);
            Controls.Add(listView1);
            Controls.Add(btnPapatya);
            Controls.Add(btnMenekse);
            Controls.Add(btnGul);
            Controls.Add(label13);
            Controls.Add(btnZambak);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox3);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
        private Label label12;
        private Button btnZambak;
        private Label label13;
        private Button btnGul;
        private Button btnMenekse;
        private Button btnPapatya;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Button buttonGoruntule;
        private Button buttonKaydet;
        private Button buttonSil;
        private Button buttonDuzelt;
        private Label label14;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private ComboBox comboBox4;
    }
}