namespace Celikoor_Insomiac
{
    partial class FormRegister
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
            this.labelRegister = new System.Windows.Forms.Label();
            this.textBoxNoHp = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonPerempuan = new System.Windows.Forms.RadioButton();
            this.radioButtonLakiLaki = new System.Windows.Forms.RadioButton();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUlangiPassword = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelOr = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxTglLahir = new System.Windows.Forms.GroupBox();
            this.dateTimePickerLahir = new System.Windows.Forms.DateTimePicker();
            this.labelAsk = new System.Windows.Forms.Label();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxTglLahir.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.BackColor = System.Drawing.Color.Transparent;
            this.labelRegister.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.labelRegister.Location = new System.Drawing.Point(121, 9);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(246, 65);
            this.labelRegister.TabIndex = 16;
            this.labelRegister.Text = "REGISTER";
            // 
            // textBoxNoHp
            // 
            this.textBoxNoHp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNoHp.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxNoHp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.textBoxNoHp.Location = new System.Drawing.Point(77, 139);
            this.textBoxNoHp.Name = "textBoxNoHp";
            this.textBoxNoHp.Size = new System.Drawing.Size(332, 36);
            this.textBoxNoHp.TabIndex = 3;
            this.textBoxNoHp.Text = "     Nomor Handphone     ";
            this.textBoxNoHp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNoHp.Enter += new System.EventHandler(this.textBoxNoHp_Enter);
            this.textBoxNoHp.Leave += new System.EventHandler(this.textBoxNoHp_Leave);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.textBoxUsername.Location = new System.Drawing.Point(77, 319);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(332, 36);
            this.textBoxUsername.TabIndex = 7;
            this.textBoxUsername.Text = "     Username     ";
            this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // textBoxNama
            // 
            this.textBoxNama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNama.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.textBoxNama.Location = new System.Drawing.Point(77, 97);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(332, 36);
            this.textBoxNama.TabIndex = 2;
            this.textBoxNama.Text = "     Nama Lengkap     ";
            this.textBoxNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNama.Enter += new System.EventHandler(this.textBoxNama_Enter);
            this.textBoxNama.Leave += new System.EventHandler(this.textBoxNama_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.textBoxEmail.Location = new System.Drawing.Point(77, 181);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(332, 36);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.Text = "     Alamat Email     ";
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonPerempuan);
            this.groupBoxGender.Controls.Add(this.radioButtonLakiLaki);
            this.groupBoxGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxGender.Location = new System.Drawing.Point(77, 233);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(89, 70);
            this.groupBoxGender.TabIndex = 5;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender:";
            // 
            // radioButtonPerempuan
            // 
            this.radioButtonPerempuan.AutoSize = true;
            this.radioButtonPerempuan.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonPerempuan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPerempuan.Location = new System.Drawing.Point(51, 26);
            this.radioButtonPerempuan.Name = "radioButtonPerempuan";
            this.radioButtonPerempuan.Size = new System.Drawing.Size(23, 38);
            this.radioButtonPerempuan.TabIndex = 1;
            this.radioButtonPerempuan.Text = "P";
            this.radioButtonPerempuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonPerempuan.UseVisualStyleBackColor = true;
            // 
            // radioButtonLakiLaki
            // 
            this.radioButtonLakiLaki.AutoSize = true;
            this.radioButtonLakiLaki.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonLakiLaki.Checked = true;
            this.radioButtonLakiLaki.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLakiLaki.Location = new System.Drawing.Point(17, 26);
            this.radioButtonLakiLaki.Name = "radioButtonLakiLaki";
            this.radioButtonLakiLaki.Size = new System.Drawing.Size(22, 38);
            this.radioButtonLakiLaki.TabIndex = 0;
            this.radioButtonLakiLaki.TabStop = true;
            this.radioButtonLakiLaki.Text = "L";
            this.radioButtonLakiLaki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonLakiLaki.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.textBoxPassword.Location = new System.Drawing.Point(77, 361);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(332, 36);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.Text = "     Password     ";
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textBoxUlangiPassword
            // 
            this.textBoxUlangiPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUlangiPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxUlangiPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.textBoxUlangiPassword.Location = new System.Drawing.Point(77, 403);
            this.textBoxUlangiPassword.Name = "textBoxUlangiPassword";
            this.textBoxUlangiPassword.Size = new System.Drawing.Size(332, 36);
            this.textBoxUlangiPassword.TabIndex = 9;
            this.textBoxUlangiPassword.Text = "     Ulangi Password     ";
            this.textBoxUlangiPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUlangiPassword.TextChanged += new System.EventHandler(this.textBoxUlangiPassword_TextChanged);
            this.textBoxUlangiPassword.Enter += new System.EventHandler(this.textBoxUlangiPassword_Enter);
            this.textBoxUlangiPassword.Leave += new System.EventHandler(this.textBoxUlangiPassword_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(104)))));
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRegister.Location = new System.Drawing.Point(77, 491);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(332, 45);
            this.buttonRegister.TabIndex = 11;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelOr
            // 
            this.labelOr.AutoSize = true;
            this.labelOr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOr.Location = new System.Drawing.Point(225, 540);
            this.labelOr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOr.Name = "labelOr";
            this.labelOr.Size = new System.Drawing.Size(26, 21);
            this.labelOr.TabIndex = 29;
            this.labelOr.Text = "or";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.buttonExit.Location = new System.Drawing.Point(77, 564);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(332, 45);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxTglLahir
            // 
            this.groupBoxTglLahir.Controls.Add(this.dateTimePickerLahir);
            this.groupBoxTglLahir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTglLahir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxTglLahir.Location = new System.Drawing.Point(172, 233);
            this.groupBoxTglLahir.Name = "groupBoxTglLahir";
            this.groupBoxTglLahir.Size = new System.Drawing.Size(237, 70);
            this.groupBoxTglLahir.TabIndex = 6;
            this.groupBoxTglLahir.TabStop = false;
            this.groupBoxTglLahir.Text = "Tanggal Lahir:";
            // 
            // dateTimePickerLahir
            // 
            this.dateTimePickerLahir.Location = new System.Drawing.Point(15, 26);
            this.dateTimePickerLahir.Name = "dateTimePickerLahir";
            this.dateTimePickerLahir.Size = new System.Drawing.Size(216, 25);
            this.dateTimePickerLahir.TabIndex = 0;
            // 
            // labelAsk
            // 
            this.labelAsk.AutoSize = true;
            this.labelAsk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.labelAsk.Location = new System.Drawing.Point(119, 454);
            this.labelAsk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAsk.Name = "labelAsk";
            this.labelAsk.Size = new System.Drawing.Size(193, 21);
            this.labelAsk.TabIndex = 31;
            this.labelAsk.Text = "Already have an account?";
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabelLogin.Location = new System.Drawing.Point(312, 454);
            this.linkLabelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(55, 21);
            this.linkLabelLogin.TabIndex = 10;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Log in";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(484, 631);
            this.Controls.Add(this.labelAsk);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelOr);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxUlangiPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.groupBoxTglLahir);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxNoHp);
            this.Controls.Add(this.labelRegister);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxTglLahir.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.TextBox textBoxNoHp;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonPerempuan;
        private System.Windows.Forms.RadioButton radioButtonLakiLaki;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUlangiPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelOr;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxTglLahir;
        private System.Windows.Forms.DateTimePicker dateTimePickerLahir;
        private System.Windows.Forms.Label labelAsk;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
    }
}