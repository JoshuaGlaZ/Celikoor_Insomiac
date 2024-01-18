
namespace Celikoor_Insomiac
{
    partial class FormLaporanFilmTerlarisPerBulan
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBoxBulan = new System.Windows.Forms.ComboBox();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.comboBoxUrut = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(218)))), ((int)(((byte)(245)))));
            this.panel5.Controls.Add(this.comboBoxBulan);
            this.panel5.Controls.Add(this.textBoxCari);
            this.panel5.Controls.Add(this.comboBoxUrut);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.comboBoxCari);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(16, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(817, 54);
            this.panel5.TabIndex = 26;
            // 
            // comboBoxBulan
            // 
            this.comboBoxBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBulan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBulan.FormattingEnabled = true;
            this.comboBoxBulan.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxBulan.Location = new System.Drawing.Point(289, 17);
            this.comboBoxBulan.Name = "comboBoxBulan";
            this.comboBoxBulan.Size = new System.Drawing.Size(230, 24);
            this.comboBoxBulan.TabIndex = 23;
            this.comboBoxBulan.SelectedIndexChanged += new System.EventHandler(this.comboBoxBulan_SelectedIndexChanged);
            // 
            // textBoxCari
            // 
            this.textBoxCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCari.Location = new System.Drawing.Point(289, 17);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(231, 22);
            this.textBoxCari.TabIndex = 22;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
            // 
            // comboBoxUrut
            // 
            this.comboBoxUrut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUrut.FormattingEnabled = true;
            this.comboBoxUrut.Items.AddRange(new object[] {
            "Judul",
            "Jumlah Penonton",
            "Bulan"});
            this.comboBoxUrut.Location = new System.Drawing.Point(675, 17);
            this.comboBoxUrut.Name = "comboBoxUrut";
            this.comboBoxUrut.Size = new System.Drawing.Size(130, 24);
            this.comboBoxUrut.TabIndex = 21;
            this.comboBoxUrut.SelectedIndexChanged += new System.EventHandler(this.comboBoxUrut_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label3.Location = new System.Drawing.Point(526, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Urut Berdasarkan :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCari.FormattingEnabled = true;
            this.comboBoxCari.Items.AddRange(new object[] {
            "Judul",
            "Jumlah Penonton",
            "Bulan"});
            this.comboBoxCari.Location = new System.Drawing.Point(153, 17);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(130, 24);
            this.comboBoxCari.TabIndex = 19;
            this.comboBoxCari.SelectedIndexChanged += new System.EventHandler(this.comboBoxCari_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cari Berdasarkan :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(191)))), ((int)(((byte)(245)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(817, 42);
            this.label2.TabIndex = 25;
            this.label2.Text = "F I L M   T E R L A R I S   P E R   B U L A N";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKeluar.AutoSize = true;
            this.buttonKeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.buttonKeluar.FlatAppearance.BorderSize = 0;
            this.buttonKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeluar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.buttonKeluar.Location = new System.Drawing.Point(721, 405);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(112, 45);
            this.buttonKeluar.TabIndex = 24;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // dataGridViewHasil
            // 
            this.dataGridViewHasil.AllowUserToAddRows = false;
            this.dataGridViewHasil.AllowUserToDeleteRows = false;
            this.dataGridViewHasil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHasil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewHasil.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasil.Location = new System.Drawing.Point(16, 128);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.ReadOnly = true;
            this.dataGridViewHasil.RowHeadersWidth = 51;
            this.dataGridViewHasil.Size = new System.Drawing.Size(817, 271);
            this.dataGridViewHasil.TabIndex = 18;
            // 
            // buttonCetak
            // 
            this.buttonCetak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCetak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.buttonCetak.FlatAppearance.BorderSize = 0;
            this.buttonCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCetak.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetak.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCetak.Location = new System.Drawing.Point(577, 405);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(112, 45);
            this.buttonCetak.TabIndex = 27;
            this.buttonCetak.Text = "CETAK";
            this.buttonCetak.UseVisualStyleBackColor = false;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // FormLaporanFilmTerlarisPerBulan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(849, 466);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dataGridViewHasil);
            this.Name = "FormLaporanFilmTerlarisPerBulan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Laporan Film Terlaris Per Bulan ";
            this.Load += new System.EventHandler(this.FormLaporanFilmTerlarisPerBulan_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private System.Windows.Forms.ComboBox comboBoxUrut;
        private System.Windows.Forms.ComboBox comboBoxBulan;
        private System.Windows.Forms.Button buttonCetak;
    }
}