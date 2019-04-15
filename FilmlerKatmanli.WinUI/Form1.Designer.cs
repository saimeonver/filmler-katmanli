namespace FilmlerKatmanli.WinUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbFilmler = new System.Windows.Forms.TabPage();
            this.tbYonetmenler = new System.Windows.Forms.TabPage();
            this.tbOyuncular = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtYayinTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbYonetmenler = new System.Windows.Forms.ComboBox();
            this.btnFilmGuncelle = new System.Windows.Forms.Button();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnFilmSil = new System.Windows.Forms.Button();
            this.lnkYonetmenEkle = new System.Windows.Forms.LinkLabel();
            this.dgvFilmler = new System.Windows.Forms.DataGridView();
            this.dgvYonetmenler = new System.Windows.Forms.DataGridView();
            this.btnYonetmenSil = new System.Windows.Forms.Button();
            this.btnYonetmenEkle = new System.Windows.Forms.Button();
            this.btnYonetmenGuncelle = new System.Windows.Forms.Button();
            this.txtYonetmenAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYonetmenSoyadi = new System.Windows.Forms.TextBox();
            this.dgvOyuncular = new System.Windows.Forms.DataGridView();
            this.btnOyuncuSil = new System.Windows.Forms.Button();
            this.btnOyuncuEkle = new System.Windows.Forms.Button();
            this.btnOyuncuGuncelle = new System.Windows.Forms.Button();
            this.txtOyuncuSoyadi = new System.Windows.Forms.TextBox();
            this.txtOyuncuAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbFilmler.SuspendLayout();
            this.tbYonetmenler.SuspendLayout();
            this.tbOyuncular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYonetmenler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncular)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbFilmler);
            this.tabControl1.Controls.Add(this.tbYonetmenler);
            this.tabControl1.Controls.Add(this.tbOyuncular);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 439);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbFilmler
            // 
            this.tbFilmler.Controls.Add(this.dgvFilmler);
            this.tbFilmler.Controls.Add(this.lnkYonetmenEkle);
            this.tbFilmler.Controls.Add(this.btnFilmSil);
            this.tbFilmler.Controls.Add(this.btnFilmEkle);
            this.tbFilmler.Controls.Add(this.btnFilmGuncelle);
            this.tbFilmler.Controls.Add(this.cmbYonetmenler);
            this.tbFilmler.Controls.Add(this.dtYayinTarihi);
            this.tbFilmler.Controls.Add(this.txtFilmAdi);
            this.tbFilmler.Controls.Add(this.label3);
            this.tbFilmler.Controls.Add(this.label2);
            this.tbFilmler.Controls.Add(this.label1);
            this.tbFilmler.Location = new System.Drawing.Point(4, 29);
            this.tbFilmler.Name = "tbFilmler";
            this.tbFilmler.Padding = new System.Windows.Forms.Padding(3);
            this.tbFilmler.Size = new System.Drawing.Size(680, 406);
            this.tbFilmler.TabIndex = 0;
            this.tbFilmler.Text = "Filmler";
            this.tbFilmler.UseVisualStyleBackColor = true;
            // 
            // tbYonetmenler
            // 
            this.tbYonetmenler.Controls.Add(this.dgvYonetmenler);
            this.tbYonetmenler.Controls.Add(this.btnYonetmenSil);
            this.tbYonetmenler.Controls.Add(this.btnYonetmenEkle);
            this.tbYonetmenler.Controls.Add(this.btnYonetmenGuncelle);
            this.tbYonetmenler.Controls.Add(this.txtYonetmenSoyadi);
            this.tbYonetmenler.Controls.Add(this.txtYonetmenAdi);
            this.tbYonetmenler.Controls.Add(this.label5);
            this.tbYonetmenler.Controls.Add(this.label6);
            this.tbYonetmenler.Location = new System.Drawing.Point(4, 29);
            this.tbYonetmenler.Name = "tbYonetmenler";
            this.tbYonetmenler.Padding = new System.Windows.Forms.Padding(3);
            this.tbYonetmenler.Size = new System.Drawing.Size(680, 406);
            this.tbYonetmenler.TabIndex = 1;
            this.tbYonetmenler.Text = "Yonetmenler";
            this.tbYonetmenler.UseVisualStyleBackColor = true;
            // 
            // tbOyuncular
            // 
            this.tbOyuncular.Controls.Add(this.dgvOyuncular);
            this.tbOyuncular.Controls.Add(this.btnOyuncuSil);
            this.tbOyuncular.Controls.Add(this.btnOyuncuEkle);
            this.tbOyuncular.Controls.Add(this.btnOyuncuGuncelle);
            this.tbOyuncular.Controls.Add(this.txtOyuncuSoyadi);
            this.tbOyuncular.Controls.Add(this.txtOyuncuAdi);
            this.tbOyuncular.Controls.Add(this.label4);
            this.tbOyuncular.Controls.Add(this.label7);
            this.tbOyuncular.Location = new System.Drawing.Point(4, 29);
            this.tbOyuncular.Name = "tbOyuncular";
            this.tbOyuncular.Size = new System.Drawing.Size(680, 406);
            this.tbOyuncular.TabIndex = 2;
            this.tbOyuncular.Text = "Oyuncular";
            this.tbOyuncular.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adi:";
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(125, 24);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(200, 26);
            this.txtFilmAdi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yayin Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yonetmeni:";
            // 
            // dtYayinTarihi
            // 
            this.dtYayinTarihi.Location = new System.Drawing.Point(125, 61);
            this.dtYayinTarihi.Name = "dtYayinTarihi";
            this.dtYayinTarihi.Size = new System.Drawing.Size(200, 26);
            this.dtYayinTarihi.TabIndex = 1;
            // 
            // cmbYonetmenler
            // 
            this.cmbYonetmenler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYonetmenler.FormattingEnabled = true;
            this.cmbYonetmenler.Location = new System.Drawing.Point(125, 93);
            this.cmbYonetmenler.Name = "cmbYonetmenler";
            this.cmbYonetmenler.Size = new System.Drawing.Size(200, 28);
            this.cmbYonetmenler.TabIndex = 2;
            // 
            // btnFilmGuncelle
            // 
            this.btnFilmGuncelle.Location = new System.Drawing.Point(125, 127);
            this.btnFilmGuncelle.Name = "btnFilmGuncelle";
            this.btnFilmGuncelle.Size = new System.Drawing.Size(98, 30);
            this.btnFilmGuncelle.TabIndex = 3;
            this.btnFilmGuncelle.Text = "Guncelle";
            this.btnFilmGuncelle.UseVisualStyleBackColor = true;
            this.btnFilmGuncelle.Click += new System.EventHandler(this.btnFilmGuncelle_Click);
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Location = new System.Drawing.Point(227, 127);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(98, 30);
            this.btnFilmEkle.TabIndex = 4;
            this.btnFilmEkle.Text = "Ekle";
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // btnFilmSil
            // 
            this.btnFilmSil.Location = new System.Drawing.Point(574, 127);
            this.btnFilmSil.Name = "btnFilmSil";
            this.btnFilmSil.Size = new System.Drawing.Size(98, 30);
            this.btnFilmSil.TabIndex = 6;
            this.btnFilmSil.Text = "Sil";
            this.btnFilmSil.UseVisualStyleBackColor = true;
            this.btnFilmSil.Click += new System.EventHandler(this.btnFilmSil_Click);
            // 
            // lnkYonetmenEkle
            // 
            this.lnkYonetmenEkle.AutoSize = true;
            this.lnkYonetmenEkle.Location = new System.Drawing.Point(332, 100);
            this.lnkYonetmenEkle.Name = "lnkYonetmenEkle";
            this.lnkYonetmenEkle.Size = new System.Drawing.Size(131, 20);
            this.lnkYonetmenEkle.TabIndex = 5;
            this.lnkYonetmenEkle.TabStop = true;
            this.lnkYonetmenEkle.Text = "Yonetmen Ekle";
            this.lnkYonetmenEkle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkYonetmenEkle_LinkClicked);
            // 
            // dgvFilmler
            // 
            this.dgvFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFilmler.Location = new System.Drawing.Point(3, 163);
            this.dgvFilmler.MultiSelect = false;
            this.dgvFilmler.Name = "dgvFilmler";
            this.dgvFilmler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmler.Size = new System.Drawing.Size(674, 240);
            this.dgvFilmler.TabIndex = 7;
            this.dgvFilmler.DoubleClick += new System.EventHandler(this.dgvFilmler_DoubleClick);
            // 
            // dgvYonetmenler
            // 
            this.dgvYonetmenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYonetmenler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvYonetmenler.Location = new System.Drawing.Point(3, 122);
            this.dgvYonetmenler.MultiSelect = false;
            this.dgvYonetmenler.Name = "dgvYonetmenler";
            this.dgvYonetmenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYonetmenler.Size = new System.Drawing.Size(674, 281);
            this.dgvYonetmenler.TabIndex = 17;
            this.dgvYonetmenler.DoubleClick += new System.EventHandler(this.dgvYonetmenler_DoubleClick);
            // 
            // btnYonetmenSil
            // 
            this.btnYonetmenSil.Location = new System.Drawing.Point(574, 83);
            this.btnYonetmenSil.Name = "btnYonetmenSil";
            this.btnYonetmenSil.Size = new System.Drawing.Size(98, 30);
            this.btnYonetmenSil.TabIndex = 13;
            this.btnYonetmenSil.Text = "Sil";
            this.btnYonetmenSil.UseVisualStyleBackColor = true;
            this.btnYonetmenSil.Click += new System.EventHandler(this.btnYonetmenSil_Click);
            // 
            // btnYonetmenEkle
            // 
            this.btnYonetmenEkle.Location = new System.Drawing.Point(274, 86);
            this.btnYonetmenEkle.Name = "btnYonetmenEkle";
            this.btnYonetmenEkle.Size = new System.Drawing.Size(98, 30);
            this.btnYonetmenEkle.TabIndex = 14;
            this.btnYonetmenEkle.Text = "Ekle";
            this.btnYonetmenEkle.UseVisualStyleBackColor = true;
            this.btnYonetmenEkle.Click += new System.EventHandler(this.btnYonetmenEkle_Click);
            // 
            // btnYonetmenGuncelle
            // 
            this.btnYonetmenGuncelle.Location = new System.Drawing.Point(172, 86);
            this.btnYonetmenGuncelle.Name = "btnYonetmenGuncelle";
            this.btnYonetmenGuncelle.Size = new System.Drawing.Size(98, 30);
            this.btnYonetmenGuncelle.TabIndex = 15;
            this.btnYonetmenGuncelle.Text = "Guncelle";
            this.btnYonetmenGuncelle.UseVisualStyleBackColor = true;
            this.btnYonetmenGuncelle.Click += new System.EventHandler(this.btnYonetmenGuncelle_Click);
            // 
            // txtYonetmenAdi
            // 
            this.txtYonetmenAdi.Location = new System.Drawing.Point(172, 17);
            this.txtYonetmenAdi.Name = "txtYonetmenAdi";
            this.txtYonetmenAdi.Size = new System.Drawing.Size(200, 26);
            this.txtYonetmenAdi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yonetmen Soyadi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Yonetmen adi:";
            // 
            // txtYonetmenSoyadi
            // 
            this.txtYonetmenSoyadi.Location = new System.Drawing.Point(172, 49);
            this.txtYonetmenSoyadi.Name = "txtYonetmenSoyadi";
            this.txtYonetmenSoyadi.Size = new System.Drawing.Size(200, 26);
            this.txtYonetmenSoyadi.TabIndex = 10;
            // 
            // dgvOyuncular
            // 
            this.dgvOyuncular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOyuncular.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOyuncular.Location = new System.Drawing.Point(0, 114);
            this.dgvOyuncular.MultiSelect = false;
            this.dgvOyuncular.Name = "dgvOyuncular";
            this.dgvOyuncular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOyuncular.Size = new System.Drawing.Size(680, 292);
            this.dgvOyuncular.TabIndex = 25;
            this.dgvOyuncular.DoubleClick += new System.EventHandler(this.dgvOyuncular_DoubleClick);
            // 
            // btnOyuncuSil
            // 
            this.btnOyuncuSil.Location = new System.Drawing.Point(574, 75);
            this.btnOyuncuSil.Name = "btnOyuncuSil";
            this.btnOyuncuSil.Size = new System.Drawing.Size(98, 30);
            this.btnOyuncuSil.TabIndex = 22;
            this.btnOyuncuSil.Text = "Sil";
            this.btnOyuncuSil.UseVisualStyleBackColor = true;
            this.btnOyuncuSil.Click += new System.EventHandler(this.btnOyuncuSil_Click);
            // 
            // btnOyuncuEkle
            // 
            this.btnOyuncuEkle.Location = new System.Drawing.Point(274, 78);
            this.btnOyuncuEkle.Name = "btnOyuncuEkle";
            this.btnOyuncuEkle.Size = new System.Drawing.Size(98, 30);
            this.btnOyuncuEkle.TabIndex = 23;
            this.btnOyuncuEkle.Text = "Ekle";
            this.btnOyuncuEkle.UseVisualStyleBackColor = true;
            this.btnOyuncuEkle.Click += new System.EventHandler(this.btnOyuncuEkle_Click);
            // 
            // btnOyuncuGuncelle
            // 
            this.btnOyuncuGuncelle.Location = new System.Drawing.Point(172, 78);
            this.btnOyuncuGuncelle.Name = "btnOyuncuGuncelle";
            this.btnOyuncuGuncelle.Size = new System.Drawing.Size(98, 30);
            this.btnOyuncuGuncelle.TabIndex = 24;
            this.btnOyuncuGuncelle.Text = "Guncelle";
            this.btnOyuncuGuncelle.UseVisualStyleBackColor = true;
            this.btnOyuncuGuncelle.Click += new System.EventHandler(this.btnOyuncuGuncelle_Click);
            // 
            // txtOyuncuSoyadi
            // 
            this.txtOyuncuSoyadi.Location = new System.Drawing.Point(172, 41);
            this.txtOyuncuSoyadi.Name = "txtOyuncuSoyadi";
            this.txtOyuncuSoyadi.Size = new System.Drawing.Size(200, 26);
            this.txtOyuncuSoyadi.TabIndex = 20;
            // 
            // txtOyuncuAdi
            // 
            this.txtOyuncuAdi.Location = new System.Drawing.Point(172, 9);
            this.txtOyuncuAdi.Name = "txtOyuncuAdi";
            this.txtOyuncuAdi.Size = new System.Drawing.Size(200, 26);
            this.txtOyuncuAdi.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Oyuncu Soyadi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Oyuncu Adi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 439);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbFilmler.ResumeLayout(false);
            this.tbFilmler.PerformLayout();
            this.tbYonetmenler.ResumeLayout(false);
            this.tbYonetmenler.PerformLayout();
            this.tbOyuncular.ResumeLayout(false);
            this.tbOyuncular.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYonetmenler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbFilmler;
        private System.Windows.Forms.DataGridView dgvFilmler;
        private System.Windows.Forms.LinkLabel lnkYonetmenEkle;
        private System.Windows.Forms.Button btnFilmSil;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnFilmGuncelle;
        private System.Windows.Forms.ComboBox cmbYonetmenler;
        private System.Windows.Forms.DateTimePicker dtYayinTarihi;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbYonetmenler;
        private System.Windows.Forms.DataGridView dgvYonetmenler;
        private System.Windows.Forms.Button btnYonetmenSil;
        private System.Windows.Forms.Button btnYonetmenEkle;
        private System.Windows.Forms.Button btnYonetmenGuncelle;
        private System.Windows.Forms.TextBox txtYonetmenSoyadi;
        private System.Windows.Forms.TextBox txtYonetmenAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tbOyuncular;
        private System.Windows.Forms.DataGridView dgvOyuncular;
        private System.Windows.Forms.Button btnOyuncuSil;
        private System.Windows.Forms.Button btnOyuncuEkle;
        private System.Windows.Forms.Button btnOyuncuGuncelle;
        private System.Windows.Forms.TextBox txtOyuncuSoyadi;
        private System.Windows.Forms.TextBox txtOyuncuAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}

