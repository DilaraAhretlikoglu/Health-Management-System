namespace vtys_hastane
{
    partial class frmReceteYaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceteYaz));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHastaAdı = new System.Windows.Forms.TextBox();
            this.txtHastaSoyadı = new System.Windows.Forms.TextBox();
            this.txtMuayeneID = new System.Windows.Forms.TextBox();
            this.txtHastaTC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtReceteNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recete_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kutu_sayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbKutuSayısı = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hastanın Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(82, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hastanın Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(567, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Muayene ID:";
            // 
            // txtHastaAdı
            // 
            this.txtHastaAdı.BackColor = System.Drawing.SystemColors.Control;
            this.txtHastaAdı.Location = new System.Drawing.Point(268, 194);
            this.txtHastaAdı.Multiline = true;
            this.txtHastaAdı.Name = "txtHastaAdı";
            this.txtHastaAdı.Size = new System.Drawing.Size(203, 35);
            this.txtHastaAdı.TabIndex = 5;
            // 
            // txtHastaSoyadı
            // 
            this.txtHastaSoyadı.BackColor = System.Drawing.SystemColors.Control;
            this.txtHastaSoyadı.Location = new System.Drawing.Point(268, 272);
            this.txtHastaSoyadı.Multiline = true;
            this.txtHastaSoyadı.Name = "txtHastaSoyadı";
            this.txtHastaSoyadı.Size = new System.Drawing.Size(203, 35);
            this.txtHastaSoyadı.TabIndex = 6;
            // 
            // txtMuayeneID
            // 
            this.txtMuayeneID.BackColor = System.Drawing.SystemColors.Control;
            this.txtMuayeneID.Location = new System.Drawing.Point(747, 198);
            this.txtMuayeneID.Multiline = true;
            this.txtMuayeneID.Name = "txtMuayeneID";
            this.txtMuayeneID.Size = new System.Drawing.Size(257, 35);
            this.txtMuayeneID.TabIndex = 7;
            // 
            // txtHastaTC
            // 
            this.txtHastaTC.BackColor = System.Drawing.SystemColors.Control;
            this.txtHastaTC.Location = new System.Drawing.Point(747, 122);
            this.txtHastaTC.Multiline = true;
            this.txtHastaTC.Name = "txtHastaTC";
            this.txtHastaTC.Size = new System.Drawing.Size(257, 35);
            this.txtHastaTC.TabIndex = 9;
            this.txtHastaTC.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(567, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "TC Kimlik No:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(325, 693);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(429, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reçeteyi onayla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtReceteNo
            // 
            this.txtReceteNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtReceteNo.Location = new System.Drawing.Point(267, 122);
            this.txtReceteNo.Multiline = true;
            this.txtReceteNo.Name = "txtReceteNo";
            this.txtReceteNo.Size = new System.Drawing.Size(203, 35);
            this.txtReceteNo.TabIndex = 15;
            this.txtReceteNo.TextChanged += new System.EventHandler(this.txtReceteNo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(81, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Reçete No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(567, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 31);
            this.label8.TabIndex = 70;
            this.label8.Text = "Muayene Tarihi:";
            // 
            // txtTarih
            // 
            this.txtTarih.BackColor = System.Drawing.SystemColors.Control;
            this.txtTarih.Location = new System.Drawing.Point(747, 276);
            this.txtTarih.Multiline = true;
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(257, 35);
            this.txtTarih.TabIndex = 71;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recete_no,
            this.Barkod_no,
            this.Kutu_sayisi});
            this.dataGridView1.Location = new System.Drawing.Point(325, 490);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 177);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // recete_no
            // 
            this.recete_no.HeaderText = "Reçete No";
            this.recete_no.MinimumWidth = 6;
            this.recete_no.Name = "recete_no";
            this.recete_no.Width = 125;
            // 
            // Barkod_no
            // 
            this.Barkod_no.HeaderText = "Barkod No";
            this.Barkod_no.MinimumWidth = 6;
            this.Barkod_no.Name = "Barkod_no";
            this.Barkod_no.Width = 125;
            // 
            // Kutu_sayisi
            // 
            this.Kutu_sayisi.HeaderText = "Kutu Sayısı";
            this.Kutu_sayisi.MinimumWidth = 6;
            this.Kutu_sayisi.Name = "Kutu_sayisi";
            this.Kutu_sayisi.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(567, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 31);
            this.label4.TabIndex = 75;
            this.label4.Text = "Kutu Sayısı:";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtBarkodNo.Location = new System.Drawing.Point(268, 339);
            this.txtBarkodNo.Multiline = true;
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(203, 35);
            this.txtBarkodNo.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(82, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 31);
            this.label6.TabIndex = 73;
            this.label6.Text = "Barkod:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(325, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(440, 51);
            this.button2.TabIndex = 77;
            this.button2.Text = "İlacı ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 71);
            this.panel1.TabIndex = 78;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1082, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 90;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cmbKutuSayısı
            // 
            this.cmbKutuSayısı.BackColor = System.Drawing.SystemColors.Control;
            this.cmbKutuSayısı.FormattingEnabled = true;
            this.cmbKutuSayısı.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbKutuSayısı.Location = new System.Drawing.Point(747, 348);
            this.cmbKutuSayısı.Name = "cmbKutuSayısı";
            this.cmbKutuSayısı.Size = new System.Drawing.Size(257, 24);
            this.cmbKutuSayısı.TabIndex = 79;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(255, 306);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 10);
            this.textBox3.TabIndex = 82;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(255, 380);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(228, 10);
            this.textBox4.TabIndex = 83;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(255, 235);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 10);
            this.textBox1.TabIndex = 84;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(255, 163);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 10);
            this.textBox2.TabIndex = 85;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(736, 163);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(276, 10);
            this.textBox5.TabIndex = 86;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(736, 239);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(276, 10);
            this.textBox6.TabIndex = 87;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(736, 317);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(276, 10);
            this.textBox7.TabIndex = 88;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(736, 380);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(276, 10);
            this.textBox8.TabIndex = 89;
            // 
            // frmReceteYaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1143, 798);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cmbKutuSayısı);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtReceteNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHastaTC);
            this.Controls.Add(this.txtMuayeneID);
            this.Controls.Add(this.txtHastaSoyadı);
            this.Controls.Add(this.txtHastaAdı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReceteYaz";
            this.Text = "frmReceteYaz";
            this.Load += new System.EventHandler(this.frmReceteYaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHastaAdı;
        private System.Windows.Forms.TextBox txtHastaSoyadı;
        private System.Windows.Forms.TextBox txtMuayeneID;
        private System.Windows.Forms.TextBox txtHastaTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtReceteNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn recete_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kutu_sayisi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbKutuSayısı;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}