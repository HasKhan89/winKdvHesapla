namespace winKdvHesapla
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
            this.lstHarcamalar = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstHarcamalar
            // 
            this.lstHarcamalar.FormattingEnabled = true;
            this.lstHarcamalar.Location = new System.Drawing.Point(12, 12);
            this.lstHarcamalar.Name = "lstHarcamalar";
            this.lstHarcamalar.Size = new System.Drawing.Size(229, 186);
            this.lstHarcamalar.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(395, 108);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlık :";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(332, 30);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(138, 20);
            this.txtBaslik.TabIndex = 3;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(332, 56);
            this.txtTutar.Mask = "0000.00 T\\L";
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(138, 20);
            this.txtTutar.TabIndex = 4;
            this.txtTutar.TextChanged += new System.EventHandler(this.txtTutar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tutar :";
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(332, 82);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(138, 20);
            this.txtToplam.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 261);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstHarcamalar);
            this.Name = "Form1";
            this.Text = "KDV Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHarcamalar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.MaskedTextBox txtTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToplam;
    }
}

