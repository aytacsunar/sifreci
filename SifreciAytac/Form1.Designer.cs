namespace SifreciAytac
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnahtar = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSifrelenmisMetin = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSifreCozulmusMetin = new System.Windows.Forms.TextBox();
            this.txtSifreCozulecekMetin = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtSifrelenecekMetin = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtDosyaIcerigi = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtSifreciDosya = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anahtar";
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.Location = new System.Drawing.Point(56, 6);
            this.txtAnahtar.Name = "txtAnahtar";
            this.txtAnahtar.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtAnahtar.Size = new System.Drawing.Size(457, 20);
            this.txtAnahtar.TabIndex = 3;
            this.txtAnahtar.Text = "Anahtar Kelimeniz";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 534);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Tag = "Denemem";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSifrelenecekMetin);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtSifrelenmisMetin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(500, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Şifrele";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(487, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Şifrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSifrelenmisMetin
            // 
            this.txtSifrelenmisMetin.Location = new System.Drawing.Point(7, 214);
            this.txtSifrelenmisMetin.Multiline = true;
            this.txtSifrelenmisMetin.Name = "txtSifrelenmisMetin";
            this.txtSifrelenmisMetin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSifrelenmisMetin.Size = new System.Drawing.Size(487, 172);
            this.txtSifrelenmisMetin.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.txtSifreCozulmusMetin);
            this.tabPage2.Controls.Add(this.txtSifreCozulecekMetin);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(500, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Şifreyi Çöz";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(487, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Şifreyi Çöz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSifreCozulmusMetin
            // 
            this.txtSifreCozulmusMetin.Location = new System.Drawing.Point(7, 214);
            this.txtSifreCozulmusMetin.Multiline = true;
            this.txtSifreCozulmusMetin.Name = "txtSifreCozulmusMetin";
            this.txtSifreCozulmusMetin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSifreCozulmusMetin.Size = new System.Drawing.Size(487, 172);
            this.txtSifreCozulmusMetin.TabIndex = 4;
            // 
            // txtSifreCozulecekMetin
            // 
            this.txtSifreCozulecekMetin.Location = new System.Drawing.Point(7, 7);
            this.txtSifreCozulecekMetin.Multiline = true;
            this.txtSifreCozulecekMetin.Name = "txtSifreCozulecekMetin";
            this.txtSifreCozulecekMetin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSifreCozulecekMetin.Size = new System.Drawing.Size(487, 172);
            this.txtSifreCozulecekMetin.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(500, 508);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hakkında";
            // 
            // txtSifrelenecekMetin
            // 
            this.txtSifrelenecekMetin.Location = new System.Drawing.Point(7, 7);
            this.txtSifrelenecekMetin.Multiline = true;
            this.txtSifrelenecekMetin.Name = "txtSifrelenecekMetin";
            this.txtSifrelenecekMetin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSifrelenecekMetin.Size = new System.Drawing.Size(487, 172);
            this.txtSifrelenecekMetin.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(438, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "ÇIKIŞ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtDosyaIcerigi);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(500, 508);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dosya\'dan Aç";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(401, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Gözat...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtDosyaIcerigi
            // 
            this.txtDosyaIcerigi.Location = new System.Drawing.Point(7, 34);
            this.txtDosyaIcerigi.Multiline = true;
            this.txtDosyaIcerigi.Name = "txtDosyaIcerigi";
            this.txtDosyaIcerigi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDosyaIcerigi.Size = new System.Drawing.Size(487, 468);
            this.txtDosyaIcerigi.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.textBox3);
            this.tabPage5.Controls.Add(this.txtSifreciDosya);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(500, 508);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Dosyaya Kaydet";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtSifreciDosya
            // 
            this.txtSifreciDosya.Location = new System.Drawing.Point(4, 4);
            this.txtSifreciDosya.Multiline = true;
            this.txtSifreciDosya.Name = "txtSifreciDosya";
            this.txtSifreciDosya.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSifreciDosya.Size = new System.Drawing.Size(493, 464);
            this.txtSifreciDosya.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(4, 480);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(332, 20);
            this.textBox3.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(343, 478);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Dosyaya Kaydet";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 590);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtAnahtar);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Şifreci Aytaç";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnahtar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSifrelenmisMetin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSifreCozulmusMetin;
        private System.Windows.Forms.TextBox txtSifreCozulecekMetin;
        private System.Windows.Forms.TextBox txtSifrelenecekMetin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtDosyaIcerigi;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtSifreciDosya;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}