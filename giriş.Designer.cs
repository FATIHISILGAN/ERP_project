namespace exERP_Full
{
    partial class giriş
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.çıkış = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gir = new System.Windows.Forms.Button();
            this.Yönetici = new System.Windows.Forms.RadioButton();
            this.çalışan = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(158, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 23;
            // 
            // çıkış
            // 
            this.çıkış.AutoSize = true;
            this.çıkış.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkış.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.çıkış.Location = new System.Drawing.Point(4, 3);
            this.çıkış.Name = "çıkış";
            this.çıkış.Size = new System.Drawing.Size(18, 18);
            this.çıkış.TabIndex = 24;
            this.çıkış.Text = "X";
            this.çıkış.Click += new System.EventHandler(this.çıkış_Click);
            this.çıkış.MouseLeave += new System.EventHandler(this.çıkış_MouseLeave);
            this.çıkış.MouseMove += new System.Windows.Forms.MouseEventHandler(this.çıkış_MouseMove);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(134, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Şifre";
            // 
            // gir
            // 
            this.gir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.gir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gir.ForeColor = System.Drawing.Color.SlateGray;
            this.gir.Location = new System.Drawing.Point(213, 292);
            this.gir.Name = "gir";
            this.gir.Size = new System.Drawing.Size(93, 27);
            this.gir.TabIndex = 30;
            this.gir.Text = "Giriş";
            this.gir.UseVisualStyleBackColor = false;
            this.gir.Click += new System.EventHandler(this.gir_Click);
            // 
            // Yönetici
            // 
            this.Yönetici.AutoSize = true;
            this.Yönetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yönetici.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Yönetici.Location = new System.Drawing.Point(139, 245);
            this.Yönetici.Name = "Yönetici";
            this.Yönetici.Size = new System.Drawing.Size(116, 29);
            this.Yönetici.TabIndex = 31;
            this.Yönetici.TabStop = true;
            this.Yönetici.Text = "Yönetici";
            this.Yönetici.UseVisualStyleBackColor = true;
            // 
            // çalışan
            // 
            this.çalışan.AutoSize = true;
            this.çalışan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çalışan.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.çalışan.Location = new System.Drawing.Point(261, 245);
            this.çalışan.Name = "çalışan";
            this.çalışan.Size = new System.Drawing.Size(109, 29);
            this.çalışan.TabIndex = 32;
            this.çalışan.TabStop = true;
            this.çalışan.Text = "Çalışan";
            this.çalışan.UseVisualStyleBackColor = true;
            // 
            // giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(531, 443);
            this.Controls.Add(this.çalışan);
            this.Controls.Add(this.Yönetici);
            this.Controls.Add(this.gir);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.çıkış);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "giriş";
            this.Text = "giriş";
            this.Load += new System.EventHandler(this.giriş_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.giriş_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.giriş_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.giriş_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label çıkış;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gir;
        private System.Windows.Forms.RadioButton Yönetici;
        private System.Windows.Forms.RadioButton çalışan;
    }
}