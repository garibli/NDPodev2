﻿namespace soru2_
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.islemler_groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.carpbutton2 = new System.Windows.Forms.Button();
            this.toplabutton1 = new System.Windows.Forms.Button();
            this.matris1_groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.matris2_groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.sonuc_groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tekrar_button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.boyut_button1 = new System.Windows.Forms.Button();
            this.islemler_groupBox1.SuspendLayout();
            this.matris1_groupBox1.SuspendLayout();
            this.matris2_groupBox1.SuspendLayout();
            this.sonuc_groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // islemler_groupBox1
            // 
            this.islemler_groupBox1.Controls.Add(this.button6);
            this.islemler_groupBox1.Controls.Add(this.button5);
            this.islemler_groupBox1.Controls.Add(this.button4);
            this.islemler_groupBox1.Controls.Add(this.button3);
            this.islemler_groupBox1.Controls.Add(this.carpbutton2);
            this.islemler_groupBox1.Controls.Add(this.toplabutton1);
            this.islemler_groupBox1.Location = new System.Drawing.Point(16, 15);
            this.islemler_groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.islemler_groupBox1.Name = "islemler_groupBox1";
            this.islemler_groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.islemler_groupBox1.Size = new System.Drawing.Size(669, 74);
            this.islemler_groupBox1.TabIndex = 1;
            this.islemler_groupBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(561, 20);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 43);
            this.button6.TabIndex = 5;
            this.button6.Text = "dosyadan oku";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(441, 20);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 43);
            this.button5.TabIndex = 4;
            this.button5.Text = "transpoze al";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(333, 20);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "iz bul";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 20);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "ters al";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // carpbutton2
            // 
            this.carpbutton2.Location = new System.Drawing.Point(117, 20);
            this.carpbutton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carpbutton2.Name = "carpbutton2";
            this.carpbutton2.Size = new System.Drawing.Size(100, 43);
            this.carpbutton2.TabIndex = 1;
            this.carpbutton2.Text = "carp";
            this.carpbutton2.UseVisualStyleBackColor = true;
            this.carpbutton2.Click += new System.EventHandler(this.carpbutton2_Click);
            // 
            // toplabutton1
            // 
            this.toplabutton1.Location = new System.Drawing.Point(9, 20);
            this.toplabutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toplabutton1.Name = "toplabutton1";
            this.toplabutton1.Size = new System.Drawing.Size(100, 43);
            this.toplabutton1.TabIndex = 0;
            this.toplabutton1.Text = "topla";
            this.toplabutton1.UseVisualStyleBackColor = true;
            this.toplabutton1.Click += new System.EventHandler(this.toplabutton1_Click);
            // 
            // matris1_groupBox1
            // 
            this.matris1_groupBox1.Controls.Add(this.textBox7);
            this.matris1_groupBox1.Controls.Add(this.textBox8);
            this.matris1_groupBox1.Controls.Add(this.textBox9);
            this.matris1_groupBox1.Controls.Add(this.textBox4);
            this.matris1_groupBox1.Controls.Add(this.textBox5);
            this.matris1_groupBox1.Controls.Add(this.textBox6);
            this.matris1_groupBox1.Controls.Add(this.textBox3);
            this.matris1_groupBox1.Controls.Add(this.textBox2);
            this.matris1_groupBox1.Controls.Add(this.textBox1);
            this.matris1_groupBox1.Enabled = false;
            this.matris1_groupBox1.Location = new System.Drawing.Point(16, 193);
            this.matris1_groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matris1_groupBox1.Name = "matris1_groupBox1";
            this.matris1_groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matris1_groupBox1.Size = new System.Drawing.Size(149, 123);
            this.matris1_groupBox1.TabIndex = 2;
            this.matris1_groupBox1.TabStop = false;
            this.matris1_groupBox1.Text = "A.matris";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(95, 89);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(33, 22);
            this.textBox7.TabIndex = 8;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(52, 89);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(33, 22);
            this.textBox8.TabIndex = 7;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(9, 89);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(33, 22);
            this.textBox9.TabIndex = 6;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(95, 57);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(33, 22);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(52, 57);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(33, 22);
            this.textBox5.TabIndex = 4;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(9, 57);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(33, 22);
            this.textBox6.TabIndex = 3;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 25);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(33, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 25);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matris2_groupBox1
            // 
            this.matris2_groupBox1.Controls.Add(this.textBox10);
            this.matris2_groupBox1.Controls.Add(this.textBox11);
            this.matris2_groupBox1.Controls.Add(this.textBox18);
            this.matris2_groupBox1.Controls.Add(this.textBox12);
            this.matris2_groupBox1.Controls.Add(this.textBox17);
            this.matris2_groupBox1.Controls.Add(this.textBox13);
            this.matris2_groupBox1.Controls.Add(this.textBox16);
            this.matris2_groupBox1.Controls.Add(this.textBox14);
            this.matris2_groupBox1.Controls.Add(this.textBox15);
            this.matris2_groupBox1.Enabled = false;
            this.matris2_groupBox1.Location = new System.Drawing.Point(16, 324);
            this.matris2_groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matris2_groupBox1.Name = "matris2_groupBox1";
            this.matris2_groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matris2_groupBox1.Size = new System.Drawing.Size(149, 123);
            this.matris2_groupBox1.TabIndex = 3;
            this.matris2_groupBox1.TabStop = false;
            this.matris2_groupBox1.Text = "B.matris";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(95, 91);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(33, 22);
            this.textBox10.TabIndex = 17;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(52, 91);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(33, 22);
            this.textBox11.TabIndex = 16;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(9, 27);
            this.textBox18.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(33, 22);
            this.textBox18.TabIndex = 9;
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(9, 91);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(33, 22);
            this.textBox12.TabIndex = 15;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(52, 27);
            this.textBox17.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(33, 22);
            this.textBox17.TabIndex = 10;
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(95, 59);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(33, 22);
            this.textBox13.TabIndex = 14;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(95, 27);
            this.textBox16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(33, 22);
            this.textBox16.TabIndex = 11;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(52, 59);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(33, 22);
            this.textBox14.TabIndex = 13;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(9, 59);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(33, 22);
            this.textBox15.TabIndex = 12;
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sonuc_groupBox1
            // 
            this.sonuc_groupBox1.Controls.Add(this.textBox19);
            this.sonuc_groupBox1.Controls.Add(this.textBox20);
            this.sonuc_groupBox1.Controls.Add(this.textBox27);
            this.sonuc_groupBox1.Controls.Add(this.textBox22);
            this.sonuc_groupBox1.Controls.Add(this.textBox25);
            this.sonuc_groupBox1.Controls.Add(this.textBox21);
            this.sonuc_groupBox1.Controls.Add(this.textBox26);
            this.sonuc_groupBox1.Controls.Add(this.textBox23);
            this.sonuc_groupBox1.Controls.Add(this.textBox24);
            this.sonuc_groupBox1.Enabled = false;
            this.sonuc_groupBox1.Location = new System.Drawing.Point(216, 263);
            this.sonuc_groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sonuc_groupBox1.Name = "sonuc_groupBox1";
            this.sonuc_groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sonuc_groupBox1.Size = new System.Drawing.Size(177, 123);
            this.sonuc_groupBox1.TabIndex = 4;
            this.sonuc_groupBox1.TabStop = false;
            this.sonuc_groupBox1.Text = "sonuc matris";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(120, 91);
            this.textBox19.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(51, 22);
            this.textBox19.TabIndex = 26;
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(60, 91);
            this.textBox20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(51, 22);
            this.textBox20.TabIndex = 25;
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(0, 27);
            this.textBox27.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox27.Name = "textBox27";
            this.textBox27.ReadOnly = true;
            this.textBox27.Size = new System.Drawing.Size(51, 22);
            this.textBox27.TabIndex = 18;
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(120, 59);
            this.textBox22.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(51, 22);
            this.textBox22.TabIndex = 23;
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(120, 27);
            this.textBox25.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox25.Name = "textBox25";
            this.textBox25.ReadOnly = true;
            this.textBox25.Size = new System.Drawing.Size(51, 22);
            this.textBox25.TabIndex = 20;
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(0, 91);
            this.textBox21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(51, 22);
            this.textBox21.TabIndex = 24;
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(60, 27);
            this.textBox26.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox26.Name = "textBox26";
            this.textBox26.ReadOnly = true;
            this.textBox26.Size = new System.Drawing.Size(51, 22);
            this.textBox26.TabIndex = 19;
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(60, 59);
            this.textBox23.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(51, 22);
            this.textBox23.TabIndex = 22;
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(0, 59);
            this.textBox24.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(51, 22);
            this.textBox24.TabIndex = 21;
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(212, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "sonuc";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(441, 96);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(235, 350);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // tekrar_button1
            // 
            this.tekrar_button1.Enabled = false;
            this.tekrar_button1.Location = new System.Drawing.Point(300, 405);
            this.tekrar_button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tekrar_button1.Name = "tekrar_button1";
            this.tekrar_button1.Size = new System.Drawing.Size(93, 42);
            this.tekrar_button1.TabIndex = 11;
            this.tekrar_button1.Text = "yeniden islem yap";
            this.tekrar_button1.UseVisualStyleBackColor = true;
            this.tekrar_button1.Click += new System.EventHandler(this.tekrar_button1_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(216, 405);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 42);
            this.button7.TabIndex = 10;
            this.button7.Text = "deger gir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.degerAl);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Maris boyutu gir";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(137, 128);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown1.TabIndex = 47;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // boyut_button1
            // 
            this.boyut_button1.Enabled = false;
            this.boyut_button1.Location = new System.Drawing.Point(220, 128);
            this.boyut_button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boyut_button1.Name = "boyut_button1";
            this.boyut_button1.Size = new System.Drawing.Size(91, 27);
            this.boyut_button1.TabIndex = 46;
            this.boyut_button1.Text = "boyut seç";
            this.boyut_button1.UseVisualStyleBackColor = true;
            this.boyut_button1.Click += new System.EventHandler(this.boyut_button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.boyut_button1);
            this.Controls.Add(this.tekrar_button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sonuc_groupBox1);
            this.Controls.Add(this.matris2_groupBox1);
            this.Controls.Add(this.matris1_groupBox1);
            this.Controls.Add(this.islemler_groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.islemler_groupBox1.ResumeLayout(false);
            this.matris1_groupBox1.ResumeLayout(false);
            this.matris1_groupBox1.PerformLayout();
            this.matris2_groupBox1.ResumeLayout(false);
            this.matris2_groupBox1.PerformLayout();
            this.sonuc_groupBox1.ResumeLayout(false);
            this.sonuc_groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox islemler_groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button carpbutton2;
        private System.Windows.Forms.Button toplabutton1;
        private System.Windows.Forms.GroupBox matris1_groupBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox matris2_groupBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.GroupBox sonuc_groupBox1;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button tekrar_button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button boyut_button1;
    }
}

