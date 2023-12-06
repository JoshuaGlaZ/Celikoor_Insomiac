
namespace Celikoor_Insomiac
{
    partial class FormTambahStudio
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
            this.comboBoxCinema = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxJenisStudio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxHargaWeekday = new System.Windows.Forms.TextBox();
            this.textBoxHargaWeekend = new System.Windows.Forms.TextBox();
            this.numericUpDownKapasitas = new System.Windows.Forms.NumericUpDown();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKapasitas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cinema :";
            // 
            // comboBoxCinema
            // 
            this.comboBoxCinema.FormattingEnabled = true;
            this.comboBoxCinema.Location = new System.Drawing.Point(154, 45);
            this.comboBoxCinema.Name = "comboBoxCinema";
            this.comboBoxCinema.Size = new System.Drawing.Size(209, 28);
            this.comboBoxCinema.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "nama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "kapasitas :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jenis Studio :";
            // 
            // comboBoxJenisStudio
            // 
            this.comboBoxJenisStudio.FormattingEnabled = true;
            this.comboBoxJenisStudio.Location = new System.Drawing.Point(154, 91);
            this.comboBoxJenisStudio.Name = "comboBoxJenisStudio";
            this.comboBoxJenisStudio.Size = new System.Drawing.Size(209, 28);
            this.comboBoxJenisStudio.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "harga weekend :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "harga weekday :";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(154, 134);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(209, 26);
            this.textBoxNama.TabIndex = 8;
            // 
            // textBoxHargaWeekday
            // 
            this.textBoxHargaWeekday.Location = new System.Drawing.Point(168, 223);
            this.textBoxHargaWeekday.Name = "textBoxHargaWeekday";
            this.textBoxHargaWeekday.Size = new System.Drawing.Size(195, 26);
            this.textBoxHargaWeekday.TabIndex = 9;
            // 
            // textBoxHargaWeekend
            // 
            this.textBoxHargaWeekend.Location = new System.Drawing.Point(170, 265);
            this.textBoxHargaWeekend.Name = "textBoxHargaWeekend";
            this.textBoxHargaWeekend.Size = new System.Drawing.Size(193, 26);
            this.textBoxHargaWeekend.TabIndex = 10;
            // 
            // numericUpDownKapasitas
            // 
            this.numericUpDownKapasitas.Location = new System.Drawing.Point(168, 179);
            this.numericUpDownKapasitas.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownKapasitas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKapasitas.Name = "numericUpDownKapasitas";
            this.numericUpDownKapasitas.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownKapasitas.TabIndex = 11;
            this.numericUpDownKapasitas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(42, 365);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(120, 48);
            this.buttonTambah.TabIndex = 12;
            this.buttonTambah.Text = "TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(243, 365);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(120, 48);
            this.buttonBatal.TabIndex = 13;
            this.buttonBatal.Text = "BATAL";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // FormTambahStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.numericUpDownKapasitas);
            this.Controls.Add(this.textBoxHargaWeekend);
            this.Controls.Add(this.textBoxHargaWeekday);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxJenisStudio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCinema);
            this.Controls.Add(this.label1);
            this.Name = "FormTambahStudio";
            this.Text = "FormTambahStudio";
            this.Load += new System.EventHandler(this.FormTambahStudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKapasitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCinema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxJenisStudio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxHargaWeekday;
        private System.Windows.Forms.TextBox textBoxHargaWeekend;
        private System.Windows.Forms.NumericUpDown numericUpDownKapasitas;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonBatal;
    }
}