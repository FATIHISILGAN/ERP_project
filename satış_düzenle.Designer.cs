namespace exERP_Full
{
    partial class satış_düzenle
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
            this.çıkış = new System.Windows.Forms.Label();
            this.ürün_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ürün_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.satış_adet = new System.Windows.Forms.TextBox();
            this.satış_adet_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Güncelle_btn = new System.Windows.Forms.Button();
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.silincek_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.satış_tarihi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // çıkış
            // 
            this.çıkış.AutoSize = true;
            this.çıkış.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkış.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.çıkış.Location = new System.Drawing.Point(0, -1);
            this.çıkış.Name = "çıkış";
            this.çıkış.Size = new System.Drawing.Size(18, 18);
            this.çıkış.TabIndex = 18;
            this.çıkış.Text = "X";
            this.çıkış.Click += new System.EventHandler(this.çıkış_Click);
            this.çıkış.MouseLeave += new System.EventHandler(this.çıkış_MouseLeave);
            this.çıkış.MouseMove += new System.Windows.Forms.MouseEventHandler(this.çıkış_MouseMove);
            // 
            // ürün_id
            // 
            this.ürün_id.Location = new System.Drawing.Point(140, 79);
            this.ürün_id.Name = "ürün_id";
            this.ürün_id.Size = new System.Drawing.Size(100, 20);
            this.ürün_id.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(82, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "ürün id";
            // 
            // ürün_ad
            // 
            this.ürün_ad.Location = new System.Drawing.Point(140, 132);
            this.ürün_ad.Name = "ürün_ad";
            this.ürün_ad.Size = new System.Drawing.Size(100, 20);
            this.ürün_ad.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(82, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "ürün ad";
            // 
            // satış_adet
            // 
            this.satış_adet.Location = new System.Drawing.Point(140, 186);
            this.satış_adet.Name = "satış_adet";
            this.satış_adet.Size = new System.Drawing.Size(100, 20);
            this.satış_adet.TabIndex = 26;
            // 
            // satış_adet_lbl
            // 
            this.satış_adet_lbl.AutoSize = true;
            this.satış_adet_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satış_adet_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.satış_adet_lbl.Location = new System.Drawing.Point(68, 186);
            this.satış_adet_lbl.Name = "satış_adet_lbl";
            this.satış_adet_lbl.Size = new System.Drawing.Size(71, 18);
            this.satış_adet_lbl.TabIndex = 25;
            this.satış_adet_lbl.Text = "satış adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(68, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "satış tarihi";
            // 
            // Güncelle_btn
            // 
            this.Güncelle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.Güncelle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Güncelle_btn.ForeColor = System.Drawing.Color.SlateGray;
            this.Güncelle_btn.Location = new System.Drawing.Point(143, 352);
            this.Güncelle_btn.Name = "Güncelle_btn";
            this.Güncelle_btn.Size = new System.Drawing.Size(93, 27);
            this.Güncelle_btn.TabIndex = 30;
            this.Güncelle_btn.Text = "Güncelle";
            this.Güncelle_btn.UseVisualStyleBackColor = false;
            this.Güncelle_btn.Click += new System.EventHandler(this.Güncelle_btn_Click);
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.kaydet_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet_btn.ForeColor = System.Drawing.Color.SlateGray;
            this.kaydet_btn.Location = new System.Drawing.Point(143, 309);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(93, 27);
            this.kaydet_btn.TabIndex = 29;
            this.kaydet_btn.Text = "Kaydet";
            this.kaydet_btn.UseVisualStyleBackColor = false;
            this.kaydet_btn.Click += new System.EventHandler(this.kaydet_btn_Click);
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sil.ForeColor = System.Drawing.Color.SlateGray;
            this.Sil.Location = new System.Drawing.Point(420, 182);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(93, 27);
            this.Sil.TabIndex = 34;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // silincek_text
            // 
            this.silincek_text.Location = new System.Drawing.Point(414, 133);
            this.silincek_text.Name = "silincek_text";
            this.silincek_text.Size = new System.Drawing.Size(100, 20);
            this.silincek_text.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(374, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID";
            // 
            // satış_tarihi
            // 
            this.satış_tarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.satış_tarihi.Location = new System.Drawing.Point(148, 250);
            this.satış_tarihi.Name = "satış_tarihi";
            this.satış_tarihi.Size = new System.Drawing.Size(97, 20);
            this.satış_tarihi.TabIndex = 35;
            // 
            // satış_düzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(578, 456);
            this.Controls.Add(this.satış_tarihi);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.silincek_text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Güncelle_btn);
            this.Controls.Add(this.kaydet_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.satış_adet);
            this.Controls.Add(this.satış_adet_lbl);
            this.Controls.Add(this.ürün_ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ürün_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.çıkış);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "satış_düzenle";
            this.Text = "satış_düzenle";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.satış_düzenle_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.satış_düzenle_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.satış_düzenle_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label çıkış;
        private System.Windows.Forms.TextBox ürün_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ürün_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox satış_adet;
        private System.Windows.Forms.Label satış_adet_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Güncelle_btn;
        private System.Windows.Forms.Button kaydet_btn;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.TextBox silincek_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker satış_tarihi;
    }
}