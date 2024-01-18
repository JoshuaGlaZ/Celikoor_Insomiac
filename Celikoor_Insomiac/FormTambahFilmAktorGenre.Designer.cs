
namespace Celikoor_Insomiac
{
    partial class FormTambahFilmAktorGenre
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
            this.dataGridViewAktorFilm = new System.Windows.Forms.DataGridView();
            this.ColumnAktorFilmAktorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAktorFilmNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAktorFilmTglLahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAktorFilmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAktorFilmNegaraAsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAktorFilmPeran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewGenreFilm = new System.Windows.Forms.DataGridView();
            this.ColumnGenreFilmGenreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGenreFilmNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGenreFilmDeskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGenreBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFilm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktorFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenreFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAktorFilm
            // 
            this.dataGridViewAktorFilm.AllowUserToAddRows = false;
            this.dataGridViewAktorFilm.AllowUserToDeleteRows = false;
            this.dataGridViewAktorFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAktorFilm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAktorFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAktorFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAktorFilmAktorId,
            this.ColumnAktorFilmNama,
            this.ColumnAktorFilmTglLahir,
            this.ColumnAktorFilmGender,
            this.ColumnAktorFilmNegaraAsal,
            this.ColumnAktorFilmPeran});
            this.dataGridViewAktorFilm.Location = new System.Drawing.Point(414, 140);
            this.dataGridViewAktorFilm.Name = "dataGridViewAktorFilm";
            this.dataGridViewAktorFilm.ReadOnly = true;
            this.dataGridViewAktorFilm.RowHeadersWidth = 51;
            this.dataGridViewAktorFilm.Size = new System.Drawing.Size(374, 293);
            this.dataGridViewAktorFilm.TabIndex = 163;
            // 
            // ColumnAktorFilmAktorId
            // 
            this.ColumnAktorFilmAktorId.HeaderText = "Aktors_Id";
            this.ColumnAktorFilmAktorId.Name = "ColumnAktorFilmAktorId";
            this.ColumnAktorFilmAktorId.ReadOnly = true;
            this.ColumnAktorFilmAktorId.Width = 77;
            // 
            // ColumnAktorFilmNama
            // 
            this.ColumnAktorFilmNama.HeaderText = "Nama_Aktor";
            this.ColumnAktorFilmNama.Name = "ColumnAktorFilmNama";
            this.ColumnAktorFilmNama.ReadOnly = true;
            this.ColumnAktorFilmNama.Width = 91;
            // 
            // ColumnAktorFilmTglLahir
            // 
            this.ColumnAktorFilmTglLahir.HeaderText = "Tanggal_Lahir";
            this.ColumnAktorFilmTglLahir.Name = "ColumnAktorFilmTglLahir";
            this.ColumnAktorFilmTglLahir.ReadOnly = true;
            // 
            // ColumnAktorFilmGender
            // 
            this.ColumnAktorFilmGender.HeaderText = "Gender";
            this.ColumnAktorFilmGender.Name = "ColumnAktorFilmGender";
            this.ColumnAktorFilmGender.ReadOnly = true;
            this.ColumnAktorFilmGender.Width = 67;
            // 
            // ColumnAktorFilmNegaraAsal
            // 
            this.ColumnAktorFilmNegaraAsal.HeaderText = "Negara_Asal";
            this.ColumnAktorFilmNegaraAsal.Name = "ColumnAktorFilmNegaraAsal";
            this.ColumnAktorFilmNegaraAsal.ReadOnly = true;
            this.ColumnAktorFilmNegaraAsal.Width = 93;
            // 
            // ColumnAktorFilmPeran
            // 
            this.ColumnAktorFilmPeran.HeaderText = "Peran";
            this.ColumnAktorFilmPeran.Name = "ColumnAktorFilmPeran";
            this.ColumnAktorFilmPeran.ReadOnly = true;
            this.ColumnAktorFilmPeran.Width = 60;
            // 
            // dataGridViewGenreFilm
            // 
            this.dataGridViewGenreFilm.AllowUserToAddRows = false;
            this.dataGridViewGenreFilm.AllowUserToDeleteRows = false;
            this.dataGridViewGenreFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewGenreFilm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewGenreFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenreFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnGenreFilmGenreId,
            this.ColumnGenreFilmNama,
            this.ColumnGenreFilmDeskripsi});
            this.dataGridViewGenreFilm.Location = new System.Drawing.Point(12, 140);
            this.dataGridViewGenreFilm.Name = "dataGridViewGenreFilm";
            this.dataGridViewGenreFilm.ReadOnly = true;
            this.dataGridViewGenreFilm.RowHeadersWidth = 51;
            this.dataGridViewGenreFilm.Size = new System.Drawing.Size(374, 293);
            this.dataGridViewGenreFilm.TabIndex = 161;
            // 
            // ColumnGenreFilmGenreId
            // 
            this.ColumnGenreFilmGenreId.HeaderText = "Genres_Id";
            this.ColumnGenreFilmGenreId.Name = "ColumnGenreFilmGenreId";
            this.ColumnGenreFilmGenreId.ReadOnly = true;
            this.ColumnGenreFilmGenreId.Width = 81;
            // 
            // ColumnGenreFilmNama
            // 
            this.ColumnGenreFilmNama.HeaderText = "Nama_Genre";
            this.ColumnGenreFilmNama.Name = "ColumnGenreFilmNama";
            this.ColumnGenreFilmNama.ReadOnly = true;
            this.ColumnGenreFilmNama.Width = 95;
            // 
            // ColumnGenreFilmDeskripsi
            // 
            this.ColumnGenreFilmDeskripsi.HeaderText = "Deskripsi";
            this.ColumnGenreFilmDeskripsi.Name = "ColumnGenreFilmDeskripsi";
            this.ColumnGenreFilmDeskripsi.ReadOnly = true;
            this.ColumnGenreFilmDeskripsi.Width = 75;
            // 
            // buttonGenreBack
            // 
            this.buttonGenreBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.buttonGenreBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGenreBack.FlatAppearance.BorderSize = 0;
            this.buttonGenreBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenreBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenreBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.buttonGenreBack.Location = new System.Drawing.Point(12, 12);
            this.buttonGenreBack.Name = "buttonGenreBack";
            this.buttonGenreBack.Size = new System.Drawing.Size(78, 45);
            this.buttonGenreBack.TabIndex = 160;
            this.buttonGenreBack.Text = "BACK";
            this.buttonGenreBack.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(191)))), ((int)(((byte)(245)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 45);
            this.label1.TabIndex = 164;
            this.label1.Text = "G E N R E";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(191)))), ((int)(((byte)(245)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(414, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 45);
            this.label2.TabIndex = 165;
            this.label2.Text = "A K T O R";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFilm
            // 
            this.labelFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(191)))), ((int)(((byte)(245)))));
            this.labelFilm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.labelFilm.Location = new System.Drawing.Point(96, 12);
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(692, 45);
            this.labelFilm.TabIndex = 166;
            this.labelFilm.Text = "F I L M    N A M E";
            this.labelFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTambahFilmAktorGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFilm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAktorFilm);
            this.Controls.Add(this.dataGridViewGenreFilm);
            this.Controls.Add(this.buttonGenreBack);
            this.Name = "FormTambahFilmAktorGenre";
            this.Text = "Genre & Aktor";
            this.Load += new System.EventHandler(this.FormTambahFilmAktorGenre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktorFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenreFilm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAktorFilm;
        private System.Windows.Forms.DataGridView dataGridViewGenreFilm;
        private System.Windows.Forms.Button buttonGenreBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAktorFilmAktorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAktorFilmNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAktorFilmTglLahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAktorFilmGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAktorFilmNegaraAsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAktorFilmPeran;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGenreFilmGenreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGenreFilmNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGenreFilmDeskripsi;
    }
}