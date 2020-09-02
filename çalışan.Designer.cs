namespace exERP_Full
{
    partial class çalışan
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // çıkış
            // 
            this.çıkış.AutoSize = true;
            this.çıkış.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkış.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.çıkış.Location = new System.Drawing.Point(2, 2);
            this.çıkış.Name = "çıkış";
            this.çıkış.Size = new System.Drawing.Size(18, 18);
            this.çıkış.TabIndex = 25;
            this.çıkış.Text = "X";
            this.çıkış.Click += new System.EventHandler(this.çıkış_Click);
            this.çıkış.MouseLeave += new System.EventHandler(this.çıkış_MouseLeave);
            this.çıkış.MouseMove += new System.Windows.Forms.MouseEventHandler(this.çıkış_MouseMove);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(55, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(486, 180);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(203, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Son verilen görev";
            // 
            // id_text
            // 
            this.id_text.AutoSize = true;
            this.id_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id_text.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.id_text.Location = new System.Drawing.Point(491, 9);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(24, 25);
            this.id_text.TabIndex = 28;
            this.id_text.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(459, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "İD:";
            // 
            // çalışan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(603, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.çıkış);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "çalışan";
            this.Text = "çalışan";
            this.Load += new System.EventHandler(this.çalışan_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.çalışan_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.çalışan_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.çalışan_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label çıkış;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label id_text;
        private System.Windows.Forms.Label label1;
    }
}