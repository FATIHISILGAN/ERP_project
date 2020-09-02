namespace exERP_Full
{
    partial class hakkında
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SİTE = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // çıkış
            // 
            this.çıkış.AutoSize = true;
            this.çıkış.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkış.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.çıkış.Location = new System.Drawing.Point(-1, 0);
            this.çıkış.Name = "çıkış";
            this.çıkış.Size = new System.Drawing.Size(18, 18);
            this.çıkış.TabIndex = 25;
            this.çıkış.Text = "X";
            this.çıkış.MouseClick += new System.Windows.Forms.MouseEventHandler(this.çıkış_MouseClick);
            this.çıkış.MouseLeave += new System.EventHandler(this.çıkış_MouseLeave);
            this.çıkış.MouseMove += new System.Windows.Forms.MouseEventHandler(this.çıkış_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(-3, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "BU YAZILIM FATİH IŞILGAN TARAFINDAN GELİŞTİRİLMİŞTİR";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(2, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 103);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GELİŞTİRİCİ";
            // 
            // SİTE
            // 
            this.SİTE.AutoSize = true;
            this.SİTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SİTE.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SİTE.Location = new System.Drawing.Point(187, 286);
            this.SİTE.Name = "SİTE";
            this.SİTE.Size = new System.Drawing.Size(191, 20);
            this.SİTE.TabIndex = 28;
            this.SİTE.TabStop = true;
            this.SİTE.Text = "Benimle iletişime geçin";
            this.SİTE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SİTE_LinkClicked);
            // 
            // hakkında
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(611, 417);
            this.Controls.Add(this.SİTE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.çıkış);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hakkında";
            this.Text = "hakkında";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hakkında_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hakkında_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hakkında_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label çıkış;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel SİTE;
    }
}