namespace Celikoor_Insomiac
{
    partial class FormScanBarcode
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
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.buttonHadir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(191)))), ((int)(((byte)(245)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label6.Location = new System.Drawing.Point(22, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(468, 65);
            this.label6.TabIndex = 85;
            this.label6.Text = "S C A N  B A R C O D E";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarcode.Location = new System.Drawing.Point(40, 112);
            this.textBoxBarcode.MaxLength = 6;
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(438, 71);
            this.textBoxBarcode.TabIndex = 86;
            // 
            // buttonHadir
            // 
            this.buttonHadir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.buttonHadir.FlatAppearance.BorderSize = 0;
            this.buttonHadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHadir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHadir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonHadir.Location = new System.Drawing.Point(156, 202);
            this.buttonHadir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHadir.Name = "buttonHadir";
            this.buttonHadir.Size = new System.Drawing.Size(177, 69);
            this.buttonHadir.TabIndex = 87;
            this.buttonHadir.Text = "UPDATE";
            this.buttonHadir.UseVisualStyleBackColor = false;
            this.buttonHadir.Click += new System.EventHandler(this.buttonHadir_Click);
            // 
            // FormScanBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 295);
            this.Controls.Add(this.buttonHadir);
            this.Controls.Add(this.textBoxBarcode);
            this.Controls.Add(this.label6);
            this.Name = "FormScanBarcode";
            this.Text = "FormScanBarcode";
            this.Load += new System.EventHandler(this.FormScanBarcode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Button buttonHadir;
    }
}