namespace Celikoor_Insomiac
{
    partial class FormTambahFilm
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSinopsis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxJudul = new System.Windows.Forms.TextBox();
            this.textBoxDurasi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxKelompok = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxActor = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddGenre = new System.Windows.Forms.Button();
            this.buttonAddAktor = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBoxDiskon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.dataGridViewFilm = new System.Windows.Forms.DataGridView();
            this.textBoxTahun = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonCari = new System.Windows.Forms.Button();
            this.labelCoverPath = new System.Windows.Forms.Label();
            this.comboBoxBahasa = new System.Windows.Forms.ComboBox();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJudul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSinopsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTahun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDurasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKelompok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBahasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubIndo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoverImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiskon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 100;
            this.label1.Text = "Judul Film : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 101;
            this.label2.Text = "Sinopsis : ";
            // 
            // textBoxSinopsis
            // 
            this.textBoxSinopsis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSinopsis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSinopsis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxSinopsis.Location = new System.Drawing.Point(137, 99);
            this.textBoxSinopsis.Multiline = true;
            this.textBoxSinopsis.Name = "textBoxSinopsis";
            this.textBoxSinopsis.Size = new System.Drawing.Size(303, 118);
            this.textBoxSinopsis.TabIndex = 102;
            this.textBoxSinopsis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 103;
            this.label3.Text = "Tahun Rilis: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 105;
            this.label4.Text = "Durasi: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxJudul
            // 
            this.textBoxJudul.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxJudul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJudul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxJudul.Location = new System.Drawing.Point(137, 64);
            this.textBoxJudul.Name = "textBoxJudul";
            this.textBoxJudul.Size = new System.Drawing.Size(303, 29);
            this.textBoxJudul.TabIndex = 99;
            this.textBoxJudul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDurasi
            // 
            this.textBoxDurasi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxDurasi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDurasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxDurasi.Location = new System.Drawing.Point(137, 258);
            this.textBoxDurasi.Name = "textBoxDurasi";
            this.textBoxDurasi.Size = new System.Drawing.Size(303, 29);
            this.textBoxDurasi.TabIndex = 107;
            this.textBoxDurasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 108;
            this.label5.Text = "Kelompok: ";
            // 
            // comboBoxKelompok
            // 
            this.comboBoxKelompok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKelompok.FormattingEnabled = true;
            this.comboBoxKelompok.Location = new System.Drawing.Point(137, 294);
            this.comboBoxKelompok.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKelompok.Name = "comboBoxKelompok";
            this.comboBoxKelompok.Size = new System.Drawing.Size(303, 21);
            this.comboBoxKelompok.TabIndex = 109;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 110;
            this.label7.Text = "Bahasa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 21);
            this.label8.TabIndex = 112;
            this.label8.Text = "Subtitle Indo: ";
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Checked = true;
            this.radioButtonYes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButtonYes.Location = new System.Drawing.Point(137, 355);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(51, 25);
            this.radioButtonYes.TabIndex = 113;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButtonNo.Location = new System.Drawing.Point(200, 355);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(49, 25);
            this.radioButtonNo.TabIndex = 114;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(191)))), ((int)(((byte)(245)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1040, 42);
            this.label6.TabIndex = 115;
            this.label6.Text = "T A M B A H   F I L M ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(451, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 21);
            this.label9.TabIndex = 116;
            this.label9.Text = "Genre: ";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(517, 69);
            this.comboBoxGenre.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(199, 21);
            this.comboBoxGenre.TabIndex = 117;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(456, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 21);
            this.label10.TabIndex = 118;
            this.label10.Text = "Aktor: ";
            // 
            // comboBoxActor
            // 
            this.comboBoxActor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActor.FormattingEnabled = true;
            this.comboBoxActor.Location = new System.Drawing.Point(517, 248);
            this.comboBoxActor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxActor.Name = "comboBoxActor";
            this.comboBoxActor.Size = new System.Drawing.Size(199, 21);
            this.comboBoxActor.TabIndex = 119;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(455, 101);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(307, 136);
            this.dataGridView1.TabIndex = 120;
            // 
            // buttonAddGenre
            // 
            this.buttonAddGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.buttonAddGenre.FlatAppearance.BorderSize = 0;
            this.buttonAddGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGenre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGenre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddGenre.Location = new System.Drawing.Point(721, 69);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(41, 21);
            this.buttonAddGenre.TabIndex = 126;
            this.buttonAddGenre.Text = "+";
            this.buttonAddGenre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddGenre.UseVisualStyleBackColor = false;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // buttonAddAktor
            // 
            this.buttonAddAktor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddAktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.buttonAddAktor.FlatAppearance.BorderSize = 0;
            this.buttonAddAktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAktor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAktor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddAktor.Location = new System.Drawing.Point(721, 248);
            this.buttonAddAktor.Name = "buttonAddAktor";
            this.buttonAddAktor.Size = new System.Drawing.Size(41, 21);
            this.buttonAddAktor.TabIndex = 127;
            this.buttonAddAktor.Text = "+";
            this.buttonAddAktor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddAktor.UseVisualStyleBackColor = false;
            this.buttonAddAktor.Click += new System.EventHandler(this.buttonAddAktor_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(455, 279);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(307, 136);
            this.dataGridView2.TabIndex = 128;
            // 
            // textBoxDiskon
            // 
            this.textBoxDiskon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxDiskon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiskon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxDiskon.Location = new System.Drawing.Point(137, 386);
            this.textBoxDiskon.Name = "textBoxDiskon";
            this.textBoxDiskon.Size = new System.Drawing.Size(295, 29);
            this.textBoxDiskon.TabIndex = 144;
            this.textBoxDiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(46, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 21);
            this.label11.TabIndex = 143;
            this.label11.Text = "Diskon:";
            // 
            // buttonTambah
            // 
            this.buttonTambah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.buttonTambah.FlatAppearance.BorderSize = 0;
            this.buttonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambah.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTambah.Location = new System.Drawing.Point(676, 627);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(118, 45);
            this.buttonTambah.TabIndex = 147;
            this.buttonTambah.Text = "TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonKeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.buttonKeluar.FlatAppearance.BorderSize = 0;
            this.buttonKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeluar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKeluar.Location = new System.Drawing.Point(494, 627);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(118, 45);
            this.buttonKeluar.TabIndex = 146;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.buttonSimpan.FlatAppearance.BorderSize = 0;
            this.buttonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSimpan.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSimpan.Location = new System.Drawing.Point(319, 627);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(118, 45);
            this.buttonSimpan.TabIndex = 145;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // dataGridViewFilm
            // 
            this.dataGridViewFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colJudul,
            this.colSinopsis,
            this.colTahun,
            this.colDurasi,
            this.colKelompok,
            this.colBahasa,
            this.colSubIndo,
            this.colCoverImage,
            this.colDiskon});
            this.dataGridViewFilm.Location = new System.Drawing.Point(10, 433);
            this.dataGridViewFilm.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFilm.Name = "dataGridViewFilm";
            this.dataGridViewFilm.RowHeadersWidth = 62;
            this.dataGridViewFilm.RowTemplate.Height = 28;
            this.dataGridViewFilm.Size = new System.Drawing.Size(1039, 179);
            this.dataGridViewFilm.TabIndex = 148;
            this.dataGridViewFilm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFilm_CellContentClick);
            // 
            // textBoxTahun
            // 
            this.textBoxTahun.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTahun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTahun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxTahun.Location = new System.Drawing.Point(137, 223);
            this.textBoxTahun.Name = "textBoxTahun";
            this.textBoxTahun.Size = new System.Drawing.Size(303, 29);
            this.textBoxTahun.TabIndex = 149;
            this.textBoxTahun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(772, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 21);
            this.label12.TabIndex = 150;
            this.label12.Text = "Cover :";
            // 
            // buttonCari
            // 
            this.buttonCari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.buttonCari.FlatAppearance.BorderSize = 0;
            this.buttonCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCari.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCari.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCari.Location = new System.Drawing.Point(776, 99);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(272, 35);
            this.buttonCari.TabIndex = 152;
            this.buttonCari.Text = "CARI";
            this.buttonCari.UseVisualStyleBackColor = false;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // labelCoverPath
            // 
            this.labelCoverPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoverPath.Location = new System.Drawing.Point(836, 70);
            this.labelCoverPath.Name = "labelCoverPath";
            this.labelCoverPath.Size = new System.Drawing.Size(212, 21);
            this.labelCoverPath.TabIndex = 153;
            this.labelCoverPath.Text = "-";
            // 
            // comboBoxBahasa
            // 
            this.comboBoxBahasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBahasa.FormattingEnabled = true;
            this.comboBoxBahasa.Items.AddRange(new object[] {
            "ID",
            "EN",
            "CHN",
            "KOR",
            "JPN",
            "OTH"});
            this.comboBoxBahasa.Location = new System.Drawing.Point(137, 323);
            this.comboBoxBahasa.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBahasa.Name = "comboBoxBahasa";
            this.comboBoxBahasa.Size = new System.Drawing.Size(303, 21);
            this.comboBoxBahasa.TabIndex = 154;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            // 
            // colJudul
            // 
            this.colJudul.HeaderText = "Judul";
            this.colJudul.Name = "colJudul";
            // 
            // colSinopsis
            // 
            this.colSinopsis.HeaderText = "Sinopsis";
            this.colSinopsis.Name = "colSinopsis";
            // 
            // colTahun
            // 
            this.colTahun.HeaderText = "Tahun";
            this.colTahun.Name = "colTahun";
            // 
            // colDurasi
            // 
            this.colDurasi.HeaderText = "Durasi";
            this.colDurasi.Name = "colDurasi";
            // 
            // colKelompok
            // 
            this.colKelompok.HeaderText = "Kelompok";
            this.colKelompok.Name = "colKelompok";
            // 
            // colBahasa
            // 
            this.colBahasa.HeaderText = "Bahasa";
            this.colBahasa.Name = "colBahasa";
            // 
            // colSubIndo
            // 
            this.colSubIndo.HeaderText = "Sub Indo";
            this.colSubIndo.Name = "colSubIndo";
            // 
            // colCoverImage
            // 
            this.colCoverImage.HeaderText = "Cover Image";
            this.colCoverImage.Name = "colCoverImage";
            // 
            // colDiskon
            // 
            this.colDiskon.HeaderText = "Diskon Nominal";
            this.colDiskon.Name = "colDiskon";
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxCover.Location = new System.Drawing.Point(776, 149);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(273, 266);
            this.pictureBoxCover.TabIndex = 106;
            this.pictureBoxCover.TabStop = false;
            // 
            // FormTambahFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 684);
            this.Controls.Add(this.comboBoxBahasa);
            this.Controls.Add(this.labelCoverPath);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxTahun);
            this.Controls.Add(this.dataGridViewFilm);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.textBoxDiskon);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonAddAktor);
            this.Controls.Add(this.buttonAddGenre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxActor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonYes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxKelompok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDurasi);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSinopsis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxJudul);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTambahFilm";
            this.Text = "FormTambahFilm";
            this.Load += new System.EventHandler(this.FormTambahFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSinopsis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.TextBox textBoxJudul;
        private System.Windows.Forms.TextBox textBoxDurasi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxKelompok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxActor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddGenre;
        private System.Windows.Forms.Button buttonAddAktor;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBoxDiskon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.DataGridView dataGridViewFilm;
        private System.Windows.Forms.TextBox textBoxTahun;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.Label labelCoverPath;
        private System.Windows.Forms.ComboBox comboBoxBahasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJudul;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSinopsis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTahun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDurasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKelompok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBahasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubIndo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoverImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiskon;
    }
}