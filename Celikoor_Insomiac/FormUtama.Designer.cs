
namespace Celikoor_Insomiac
{
    partial class FormUtama
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
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInfo = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabelClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripInfo = new System.Windows.Forms.StatusStrip();
            this.menuStripLaporan = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemLaporan = new System.Windows.Forms.ToolStripMenuItem();
            this.fILMTERLARISPERBULANSELAMA2023ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pEMASUKANCABANGDARIPENJUALANTIKETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fILMBERDASARKANJUMLAHKETIDAKHADIRANPENONTONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDIOBERDASARKANTINGKATUTILITASTERENDAHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kONSUMENBERDASARKANTONTONANGENREKOMEDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.buttonCekTiket = new System.Windows.Forms.Button();
            this.buttonPesanTicket = new System.Windows.Forms.Button();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.buttonInvoices = new System.Windows.Forms.Button();
            this.buttonFilm = new System.Windows.Forms.Button();
            this.buttonStudio = new System.Windows.Forms.Button();
            this.buttonJadwalFilm = new System.Windows.Forms.Button();
            this.buttonJenisStudio = new System.Windows.Forms.Button();
            this.buttonGenre = new System.Windows.Forms.Button();
            this.buttonAktor = new System.Windows.Forms.Button();
            this.buttonKelompok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonPegawai = new System.Windows.Forms.Button();
            this.buttonKonsumen = new System.Windows.Forms.Button();
            this.buttonCinema = new System.Windows.Forms.Button();
            this.menuStripInfo.SuspendLayout();
            this.statusStripInfo.SuspendLayout();
            this.menuStripLaporan.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOffToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(59, 46);
            this.logOffToolStripMenuItem.Text = "Log Off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // menuStripInfo
            // 
            this.menuStripInfo.AutoSize = false;
            this.menuStripInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.menuStripInfo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemProfile,
            this.logOffToolStripMenuItem});
            this.menuStripInfo.Location = new System.Drawing.Point(183, 0);
            this.menuStripInfo.Name = "menuStripInfo";
            this.menuStripInfo.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripInfo.Size = new System.Drawing.Size(830, 50);
            this.menuStripInfo.TabIndex = 28;
            this.menuStripInfo.Text = "menuStrip1";
            // 
            // toolStripMenuItemProfile
            // 
            this.toolStripMenuItemProfile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItemProfile.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItemProfile.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemProfile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItemProfile.Name = "toolStripMenuItemProfile";
            this.toolStripMenuItemProfile.Size = new System.Drawing.Size(78, 46);
            this.toolStripMenuItemProfile.Text = "X / Admin";
            this.toolStripMenuItemProfile.Click += new System.EventHandler(this.toolStripMenuItemProfile_Click);
            // 
            // toolStripStatusLabelClock
            // 
            this.toolStripStatusLabelClock.Name = "toolStripStatusLabelClock";
            this.toolStripStatusLabelClock.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabelClock.Text = "dd/MM/yyyy";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabelTime.Text = "hh/mm/ss";
            // 
            // statusStripInfo
            // 
            this.statusStripInfo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelClock,
            this.toolStripStatusLabelTime});
            this.statusStripInfo.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStripInfo.Location = new System.Drawing.Point(0, 712);
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStripInfo.Size = new System.Drawing.Size(1013, 22);
            this.statusStripInfo.TabIndex = 27;
            this.statusStripInfo.Text = "statusStrip1";
            // 
            // menuStripLaporan
            // 
            this.menuStripLaporan.AutoSize = false;
            this.menuStripLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.menuStripLaporan.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripLaporan.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripLaporan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLaporan});
            this.menuStripLaporan.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStripLaporan.Location = new System.Drawing.Point(0, 53);
            this.menuStripLaporan.Name = "menuStripLaporan";
            this.menuStripLaporan.Padding = new System.Windows.Forms.Padding(0);
            this.menuStripLaporan.Size = new System.Drawing.Size(183, 46);
            this.menuStripLaporan.TabIndex = 31;
            this.menuStripLaporan.Text = "menuStrip2";
            // 
            // toolStripMenuItemLaporan
            // 
            this.toolStripMenuItemLaporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILMTERLARISPERBULANSELAMA2023ToolStripMenuItem,
            this.pEMASUKANCABANGDARIPENJUALANTIKETToolStripMenuItem,
            this.fILMBERDASARKANJUMLAHKETIDAKHADIRANPENONTONToolStripMenuItem1,
            this.sTUDIOBERDASARKANTINGKATUTILITASTERENDAHToolStripMenuItem,
            this.kONSUMENBERDASARKANTONTONANGENREKOMEDIToolStripMenuItem});
            this.toolStripMenuItemLaporan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemLaporan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItemLaporan.Name = "toolStripMenuItemLaporan";
            this.toolStripMenuItemLaporan.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.toolStripMenuItemLaporan.Size = new System.Drawing.Size(182, 41);
            this.toolStripMenuItemLaporan.Text = "  LAPORAN               . . .";
            this.toolStripMenuItemLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fILMTERLARISPERBULANSELAMA2023ToolStripMenuItem
            // 
            this.fILMTERLARISPERBULANSELAMA2023ToolStripMenuItem.AutoSize = false;
            this.fILMTERLARISPERBULANSELAMA2023ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.fILMTERLARISPERBULANSELAMA2023ToolStripMenuItem.Name = "fILMTERLARISPERBULANSELAMA2023ToolStripMenuItem";
            this.fILMTERLARISPERBULANSELAMA2023ToolStripMenuItem.Size = new System.Drawing.Size(433, 22);
            this.fILMTERLARISPERBULANSELAMA2023ToolStripMenuItem.Text = "FILM TERLARIS PER BULAN SELAMA 2023";
            this.fILMTERLARISPERBULANSELAMA2023ToolStripMenuItem.Click += new System.EventHandler(this.fILMTERLARISPERBULANSELAMA2023ToolStripMenuItem_Click);
            // 
            // pEMASUKANCABANGDARIPENJUALANTIKETToolStripMenuItem
            // 
            this.pEMASUKANCABANGDARIPENJUALANTIKETToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.pEMASUKANCABANGDARIPENJUALANTIKETToolStripMenuItem.Name = "pEMASUKANCABANGDARIPENJUALANTIKETToolStripMenuItem";
            this.pEMASUKANCABANGDARIPENJUALANTIKETToolStripMenuItem.Size = new System.Drawing.Size(433, 22);
            this.pEMASUKANCABANGDARIPENJUALANTIKETToolStripMenuItem.Text = "PEMASUKAN CABANG TERBANYAK DARI PENJUALAN TIKET";
            this.pEMASUKANCABANGDARIPENJUALANTIKETToolStripMenuItem.Click += new System.EventHandler(this.pEMASUKANCABANGDARIPENJUALANTIKETToolStripMenuItem_Click);
            // 
            // fILMBERDASARKANJUMLAHKETIDAKHADIRANPENONTONToolStripMenuItem1
            // 
            this.fILMBERDASARKANJUMLAHKETIDAKHADIRANPENONTONToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.fILMBERDASARKANJUMLAHKETIDAKHADIRANPENONTONToolStripMenuItem1.Name = "fILMBERDASARKANJUMLAHKETIDAKHADIRANPENONTONToolStripMenuItem1";
            this.fILMBERDASARKANJUMLAHKETIDAKHADIRANPENONTONToolStripMenuItem1.Size = new System.Drawing.Size(433, 22);
            this.fILMBERDASARKANJUMLAHKETIDAKHADIRANPENONTONToolStripMenuItem1.Text = "FILM BERDASARKAN JUMLAH KETIDAKHADIRAN PENONTON";
            this.fILMBERDASARKANJUMLAHKETIDAKHADIRANPENONTONToolStripMenuItem1.Click += new System.EventHandler(this.fILMBERDASARKANJUMLAHKETIDAKHADIRANPENONTONToolStripMenuItem_Click);
            // 
            // sTUDIOBERDASARKANTINGKATUTILITASTERENDAHToolStripMenuItem
            // 
            this.sTUDIOBERDASARKANTINGKATUTILITASTERENDAHToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sTUDIOBERDASARKANTINGKATUTILITASTERENDAHToolStripMenuItem.Name = "sTUDIOBERDASARKANTINGKATUTILITASTERENDAHToolStripMenuItem";
            this.sTUDIOBERDASARKANTINGKATUTILITASTERENDAHToolStripMenuItem.Size = new System.Drawing.Size(433, 22);
            this.sTUDIOBERDASARKANTINGKATUTILITASTERENDAHToolStripMenuItem.Text = "STUDIO BERDASARKAN TINGKAT UTILITAS TERENDAH";
            this.sTUDIOBERDASARKANTINGKATUTILITASTERENDAHToolStripMenuItem.Click += new System.EventHandler(this.sTUDIOBERDASARKANTINGKATUTILITASTERENDAHToolStripMenuItem_Click);
            // 
            // kONSUMENBERDASARKANTONTONANGENREKOMEDIToolStripMenuItem
            // 
            this.kONSUMENBERDASARKANTONTONANGENREKOMEDIToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.kONSUMENBERDASARKANTONTONANGENREKOMEDIToolStripMenuItem.Name = "kONSUMENBERDASARKANTONTONANGENREKOMEDIToolStripMenuItem";
            this.kONSUMENBERDASARKANTONTONANGENREKOMEDIToolStripMenuItem.Size = new System.Drawing.Size(433, 22);
            this.kONSUMENBERDASARKANTONTONANGENREKOMEDIToolStripMenuItem.Text = "KONSUMEN BERDASARKAN TONTONAN GENRE KOMEDI";
            this.kONSUMENBERDASARKANTONTONANGENREKOMEDIToolStripMenuItem.Click += new System.EventHandler(this.kONSUMENBERDASARKANTONTONANGENREKOMEDIToolStripMenuItem_Click);
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.panelSideBar.Controls.Add(this.buttonCekTiket);
            this.panelSideBar.Controls.Add(this.buttonPesanTicket);
            this.panelSideBar.Controls.Add(this.buttonTicket);
            this.panelSideBar.Controls.Add(this.buttonInvoices);
            this.panelSideBar.Controls.Add(this.buttonFilm);
            this.panelSideBar.Controls.Add(this.buttonStudio);
            this.panelSideBar.Controls.Add(this.buttonJadwalFilm);
            this.panelSideBar.Controls.Add(this.menuStripLaporan);
            this.panelSideBar.Controls.Add(this.buttonJenisStudio);
            this.panelSideBar.Controls.Add(this.buttonGenre);
            this.panelSideBar.Controls.Add(this.buttonAktor);
            this.panelSideBar.Controls.Add(this.buttonKelompok);
            this.panelSideBar.Controls.Add(this.button2);
            this.panelSideBar.Controls.Add(this.buttonPegawai);
            this.panelSideBar.Controls.Add(this.buttonKonsumen);
            this.panelSideBar.Controls.Add(this.buttonCinema);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(183, 712);
            this.panelSideBar.TabIndex = 29;
            // 
            // buttonCekTiket
            // 
            this.buttonCekTiket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.buttonCekTiket.FlatAppearance.BorderSize = 0;
            this.buttonCekTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCekTiket.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCekTiket.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCekTiket.Image = global::Celikoor_Insomiac.Properties.Resources.cek_tiket;
            this.buttonCekTiket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCekTiket.Location = new System.Drawing.Point(0, 564);
            this.buttonCekTiket.Name = "buttonCekTiket";
            this.buttonCekTiket.Size = new System.Drawing.Size(183, 30);
            this.buttonCekTiket.TabIndex = 44;
            this.buttonCekTiket.Text = "  CEK TIKET";
            this.buttonCekTiket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCekTiket.UseVisualStyleBackColor = false;
            this.buttonCekTiket.Click += new System.EventHandler(this.buttonCekTiket_Click);
            // 
            // buttonPesanTicket
            // 
            this.buttonPesanTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.buttonPesanTicket.FlatAppearance.BorderSize = 0;
            this.buttonPesanTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesanTicket.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesanTicket.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPesanTicket.Image = global::Celikoor_Insomiac.Properties.Resources.pesan_tiket;
            this.buttonPesanTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPesanTicket.Location = new System.Drawing.Point(0, 528);
            this.buttonPesanTicket.Name = "buttonPesanTicket";
            this.buttonPesanTicket.Size = new System.Drawing.Size(183, 30);
            this.buttonPesanTicket.TabIndex = 43;
            this.buttonPesanTicket.Text = "  PESAN TICKET";
            this.buttonPesanTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPesanTicket.UseVisualStyleBackColor = false;
            this.buttonPesanTicket.Click += new System.EventHandler(this.buttonPesanTicket_Click);
            // 
            // buttonTicket
            // 
            this.buttonTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.buttonTicket.FlatAppearance.BorderSize = 0;
            this.buttonTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicket.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicket.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTicket.Image = global::Celikoor_Insomiac.Properties.Resources.ticket;
            this.buttonTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTicket.Location = new System.Drawing.Point(0, 492);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Size = new System.Drawing.Size(183, 30);
            this.buttonTicket.TabIndex = 36;
            this.buttonTicket.Text = "  TICKET";
            this.buttonTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTicket.UseVisualStyleBackColor = false;
            this.buttonTicket.Click += new System.EventHandler(this.buttonTicket_Click);
            // 
            // buttonInvoices
            // 
            this.buttonInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.buttonInvoices.FlatAppearance.BorderSize = 0;
            this.buttonInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInvoices.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInvoices.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonInvoices.Image = global::Celikoor_Insomiac.Properties.Resources.invoice;
            this.buttonInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInvoices.Location = new System.Drawing.Point(0, 456);
            this.buttonInvoices.Name = "buttonInvoices";
            this.buttonInvoices.Size = new System.Drawing.Size(183, 30);
            this.buttonInvoices.TabIndex = 35;
            this.buttonInvoices.Text = "  INVOICES";
            this.buttonInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInvoices.UseVisualStyleBackColor = false;
            this.buttonInvoices.Click += new System.EventHandler(this.buttonInvoices_Click);
            // 
            // buttonFilm
            // 
            this.buttonFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.buttonFilm.FlatAppearance.BorderSize = 0;
            this.buttonFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFilm.Image = global::Celikoor_Insomiac.Properties.Resources.film;
            this.buttonFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFilm.Location = new System.Drawing.Point(0, 420);
            this.buttonFilm.Name = "buttonFilm";
            this.buttonFilm.Size = new System.Drawing.Size(183, 30);
            this.buttonFilm.TabIndex = 34;
            this.buttonFilm.Text = "  FILM";
            this.buttonFilm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFilm.UseVisualStyleBackColor = false;
            this.buttonFilm.Click += new System.EventHandler(this.buttonFilm_Click);
            // 
            // buttonStudio
            // 
            this.buttonStudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.buttonStudio.FlatAppearance.BorderSize = 0;
            this.buttonStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonStudio.Image = global::Celikoor_Insomiac.Properties.Resources.studio;
            this.buttonStudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudio.Location = new System.Drawing.Point(0, 384);
            this.buttonStudio.Name = "buttonStudio";
            this.buttonStudio.Size = new System.Drawing.Size(183, 30);
            this.buttonStudio.TabIndex = 33;
            this.buttonStudio.Text = "  STUDIO";
            this.buttonStudio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStudio.UseVisualStyleBackColor = false;
            this.buttonStudio.Click += new System.EventHandler(this.buttonStudio_Click);
            // 
            // buttonJadwalFilm
            // 
            this.buttonJadwalFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.buttonJadwalFilm.FlatAppearance.BorderSize = 0;
            this.buttonJadwalFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJadwalFilm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJadwalFilm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonJadwalFilm.Image = global::Celikoor_Insomiac.Properties.Resources.jadwal_film;
            this.buttonJadwalFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonJadwalFilm.Location = new System.Drawing.Point(0, 348);
            this.buttonJadwalFilm.Name = "buttonJadwalFilm";
            this.buttonJadwalFilm.Size = new System.Drawing.Size(183, 30);
            this.buttonJadwalFilm.TabIndex = 32;
            this.buttonJadwalFilm.Text = "  JADWAL FILM";
            this.buttonJadwalFilm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonJadwalFilm.UseVisualStyleBackColor = false;
            this.buttonJadwalFilm.Click += new System.EventHandler(this.buttonJadwalFilm_Click);
            // 
            // buttonJenisStudio
            // 
            this.buttonJenisStudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.buttonJenisStudio.FlatAppearance.BorderSize = 0;
            this.buttonJenisStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJenisStudio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJenisStudio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonJenisStudio.Image = global::Celikoor_Insomiac.Properties.Resources.jenis_studio;
            this.buttonJenisStudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonJenisStudio.Location = new System.Drawing.Point(0, 312);
            this.buttonJenisStudio.Name = "buttonJenisStudio";
            this.buttonJenisStudio.Size = new System.Drawing.Size(183, 30);
            this.buttonJenisStudio.TabIndex = 30;
            this.buttonJenisStudio.Text = "  JENIS STUDIO";
            this.buttonJenisStudio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonJenisStudio.UseVisualStyleBackColor = false;
            this.buttonJenisStudio.Click += new System.EventHandler(this.buttonJenisStudio_Click);
            // 
            // buttonGenre
            // 
            this.buttonGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.buttonGenre.FlatAppearance.BorderSize = 0;
            this.buttonGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonGenre.Image = global::Celikoor_Insomiac.Properties.Resources.genre;
            this.buttonGenre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenre.Location = new System.Drawing.Point(0, 276);
            this.buttonGenre.Name = "buttonGenre";
            this.buttonGenre.Size = new System.Drawing.Size(183, 30);
            this.buttonGenre.TabIndex = 28;
            this.buttonGenre.Text = "  GENRE";
            this.buttonGenre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGenre.UseVisualStyleBackColor = false;
            this.buttonGenre.Click += new System.EventHandler(this.buttonGenre_Click);
            // 
            // buttonAktor
            // 
            this.buttonAktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.buttonAktor.FlatAppearance.BorderSize = 0;
            this.buttonAktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAktor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAktor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAktor.Image = global::Celikoor_Insomiac.Properties.Resources.aktor;
            this.buttonAktor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAktor.Location = new System.Drawing.Point(0, 240);
            this.buttonAktor.Name = "buttonAktor";
            this.buttonAktor.Size = new System.Drawing.Size(183, 30);
            this.buttonAktor.TabIndex = 27;
            this.buttonAktor.Text = "  AKTOR";
            this.buttonAktor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAktor.UseVisualStyleBackColor = false;
            this.buttonAktor.Click += new System.EventHandler(this.buttonAktor_Click);
            // 
            // buttonKelompok
            // 
            this.buttonKelompok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.buttonKelompok.FlatAppearance.BorderSize = 0;
            this.buttonKelompok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKelompok.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKelompok.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKelompok.Image = global::Celikoor_Insomiac.Properties.Resources.kelompok;
            this.buttonKelompok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKelompok.Location = new System.Drawing.Point(0, 204);
            this.buttonKelompok.Name = "buttonKelompok";
            this.buttonKelompok.Size = new System.Drawing.Size(183, 30);
            this.buttonKelompok.TabIndex = 26;
            this.buttonKelompok.Text = "  KELOMPOK";
            this.buttonKelompok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonKelompok.UseVisualStyleBackColor = false;
            this.buttonKelompok.Click += new System.EventHandler(this.buttonKelompok_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Image = global::Celikoor_Insomiac.Properties.Resources.insomiac;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 50);
            this.button2.TabIndex = 23;
            this.button2.Text = "Insomiac";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonPegawai
            // 
            this.buttonPegawai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.buttonPegawai.FlatAppearance.BorderSize = 0;
            this.buttonPegawai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPegawai.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPegawai.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPegawai.Image = global::Celikoor_Insomiac.Properties.Resources.pegawai;
            this.buttonPegawai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPegawai.Location = new System.Drawing.Point(0, 168);
            this.buttonPegawai.Name = "buttonPegawai";
            this.buttonPegawai.Size = new System.Drawing.Size(183, 30);
            this.buttonPegawai.TabIndex = 25;
            this.buttonPegawai.Text = "  PEGAWAI";
            this.buttonPegawai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPegawai.UseVisualStyleBackColor = false;
            this.buttonPegawai.Click += new System.EventHandler(this.buttonPegawai_Click);
            // 
            // buttonKonsumen
            // 
            this.buttonKonsumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.buttonKonsumen.FlatAppearance.BorderSize = 0;
            this.buttonKonsumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKonsumen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKonsumen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKonsumen.Image = global::Celikoor_Insomiac.Properties.Resources.konsumen;
            this.buttonKonsumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKonsumen.Location = new System.Drawing.Point(0, 96);
            this.buttonKonsumen.Name = "buttonKonsumen";
            this.buttonKonsumen.Size = new System.Drawing.Size(183, 30);
            this.buttonKonsumen.TabIndex = 24;
            this.buttonKonsumen.Text = "  KONSUMEN";
            this.buttonKonsumen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonKonsumen.UseVisualStyleBackColor = false;
            this.buttonKonsumen.Click += new System.EventHandler(this.buttonKonsumen_Click);
            // 
            // buttonCinema
            // 
            this.buttonCinema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.buttonCinema.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.buttonCinema.FlatAppearance.BorderSize = 0;
            this.buttonCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCinema.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCinema.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCinema.Image = global::Celikoor_Insomiac.Properties.Resources.cinema;
            this.buttonCinema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCinema.Location = new System.Drawing.Point(0, 132);
            this.buttonCinema.Name = "buttonCinema";
            this.buttonCinema.Size = new System.Drawing.Size(183, 30);
            this.buttonCinema.TabIndex = 22;
            this.buttonCinema.Text = "  CINEMA";
            this.buttonCinema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCinema.UseVisualStyleBackColor = false;
            this.buttonCinema.Click += new System.EventHandler(this.buttonCinema_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1013, 734);
            this.Controls.Add(this.menuStripInfo);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.statusStripInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "FormUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Celikoor 21 Cineplex";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.menuStripInfo.ResumeLayout(false);
            this.menuStripInfo.PerformLayout();
            this.statusStripInfo.ResumeLayout(false);
            this.statusStripInfo.PerformLayout();
            this.menuStripLaporan.ResumeLayout(false);
            this.menuStripLaporan.PerformLayout();
            this.panelSideBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripInfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProfile;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelClock;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.StatusStrip statusStripInfo;
        private System.Windows.Forms.Button buttonCinema;
        private System.Windows.Forms.Button buttonKonsumen;
        private System.Windows.Forms.Button buttonPegawai;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonKelompok;
        private System.Windows.Forms.Button buttonAktor;
        private System.Windows.Forms.Button buttonGenre;
        private System.Windows.Forms.Button buttonJenisStudio;
        private System.Windows.Forms.MenuStrip menuStripLaporan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLaporan;
        private System.Windows.Forms.ToolStripMenuItem fILMTERLARISPERBULANSELAMA2023ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pEMASUKANCABANGDARIPENJUALANTIKETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fILMBERDASARKANJUMLAHKETIDAKHADIRANPENONTONToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sTUDIOBERDASARKANTINGKATUTILITASTERENDAHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kONSUMENBERDASARKANTONTONANGENREKOMEDIToolStripMenuItem;
        private System.Windows.Forms.Button buttonJadwalFilm;
        private System.Windows.Forms.Button buttonStudio;
        private System.Windows.Forms.Button buttonFilm;
        private System.Windows.Forms.Button buttonInvoices;
        private System.Windows.Forms.Button buttonTicket;
        private System.Windows.Forms.Button buttonPesanTicket;
        private System.Windows.Forms.Button buttonCekTiket;
        private System.Windows.Forms.Panel panelSideBar;
    }
}

