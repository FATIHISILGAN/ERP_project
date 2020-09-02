namespace exERP_Full
{
    partial class yönetici
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yönetici));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn1 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.satış_pnl = new System.Windows.Forms.Panel();
            this.satış_lbl = new System.Windows.Forms.Label();
            this.satış_pic = new System.Windows.Forms.PictureBox();
            this.stok_pnl = new System.Windows.Forms.Panel();
            this.stok_lbl = new System.Windows.Forms.Label();
            this.stok_pic = new System.Windows.Forms.PictureBox();
            this.çalışanlar_pnl = new System.Windows.Forms.Panel();
            this.çalışanlar_lbl = new System.Windows.Forms.Label();
            this.çalışanlar_pic = new System.Windows.Forms.PictureBox();
            this.anasayfa_pnl = new System.Windows.Forms.Panel();
            this.anasayfa_lbl = new System.Windows.Forms.Label();
            this.anasayfa_pic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.düzenle_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.db_görüntüleyici = new System.Windows.Forms.DataGridView();
            this.çalışan_maaş = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.çalışanlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eRP_ikiDataSet2 = new exERP_Full.ERP_ikiDataSet2();
            this.en_çok_satılan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eRP_ikiDataSet1 = new exERP_Full.ERP_ikiDataSet1();
            this.satış = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.satışBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eRP_ikiDataSet = new exERP_Full.ERP_ikiDataSet();
            this.satışTableAdapter = new exERP_Full.ERP_ikiDataSetTableAdapters.satışTableAdapter();
            this.stokTableAdapter = new exERP_Full.ERP_ikiDataSet1TableAdapters.StokTableAdapter();
            this.çalışanlarTableAdapter = new exERP_Full.ERP_ikiDataSet2TableAdapters.çalışanlarTableAdapter();
            this.grafikleri_yenile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.satış_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satış_pic)).BeginInit();
            this.stok_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stok_pic)).BeginInit();
            this.çalışanlar_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.çalışanlar_pic)).BeginInit();
            this.anasayfa_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anasayfa_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_görüntüleyici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.çalışan_maaş)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.çalışanlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRP_ikiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en_çok_satılan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRP_ikiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satış)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satışBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRP_ikiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.satış_pnl);
            this.panel1.Controls.Add(this.stok_pnl);
            this.panel1.Controls.Add(this.çalışanlar_pnl);
            this.panel1.Controls.Add(this.anasayfa_pnl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-6, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 589);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // satış_pnl
            // 
            this.satış_pnl.Controls.Add(this.satış_lbl);
            this.satış_pnl.Controls.Add(this.satış_pic);
            this.satış_pnl.Location = new System.Drawing.Point(12, 490);
            this.satış_pnl.Name = "satış_pnl";
            this.satış_pnl.Size = new System.Drawing.Size(143, 100);
            this.satış_pnl.TabIndex = 5;
            this.satış_pnl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.satış_pnl_MouseClick);
            this.satış_pnl.MouseLeave += new System.EventHandler(this.satış_pnl_MouseLeave);
            this.satış_pnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.satış_pnl_MouseMove);
            // 
            // satış_lbl
            // 
            this.satış_lbl.AutoSize = true;
            this.satış_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satış_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.satış_lbl.Location = new System.Drawing.Point(46, 77);
            this.satış_lbl.Name = "satış_lbl";
            this.satış_lbl.Size = new System.Drawing.Size(50, 20);
            this.satış_lbl.TabIndex = 2;
            this.satış_lbl.Text = "Satış";
            this.satış_lbl.Click += new System.EventHandler(this.satış_lbl_Click);
            this.satış_lbl.MouseLeave += new System.EventHandler(this.satış_lbl_MouseLeave);
            this.satış_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.satış_lbl_MouseMove);
            // 
            // satış_pic
            // 
            this.satış_pic.Image = ((System.Drawing.Image)(resources.GetObject("satış_pic.Image")));
            this.satış_pic.Location = new System.Drawing.Point(31, 16);
            this.satış_pic.Name = "satış_pic";
            this.satış_pic.Size = new System.Drawing.Size(82, 65);
            this.satış_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.satış_pic.TabIndex = 2;
            this.satış_pic.TabStop = false;
            this.satış_pic.Click += new System.EventHandler(this.satış_pic_Click);
            this.satış_pic.MouseLeave += new System.EventHandler(this.satış_pic_MouseLeave);
            this.satış_pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.satış_pic_MouseMove);
            // 
            // stok_pnl
            // 
            this.stok_pnl.Controls.Add(this.stok_lbl);
            this.stok_pnl.Controls.Add(this.stok_pic);
            this.stok_pnl.Location = new System.Drawing.Point(13, 369);
            this.stok_pnl.Name = "stok_pnl";
            this.stok_pnl.Size = new System.Drawing.Size(143, 100);
            this.stok_pnl.TabIndex = 4;
            this.stok_pnl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stok_pnl_MouseClick);
            this.stok_pnl.MouseLeave += new System.EventHandler(this.stok_pnl_MouseLeave);
            this.stok_pnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.stok_pnl_MouseMove);
            // 
            // stok_lbl
            // 
            this.stok_lbl.AutoSize = true;
            this.stok_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stok_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.stok_lbl.Location = new System.Drawing.Point(47, 80);
            this.stok_lbl.Name = "stok_lbl";
            this.stok_lbl.Size = new System.Drawing.Size(46, 20);
            this.stok_lbl.TabIndex = 2;
            this.stok_lbl.Text = "Stok";
            this.stok_lbl.Click += new System.EventHandler(this.stok_lbl_Click);
            this.stok_lbl.MouseLeave += new System.EventHandler(this.stok_lbl_MouseLeave);
            this.stok_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.stok_lbl_MouseMove);
            // 
            // stok_pic
            // 
            this.stok_pic.Image = ((System.Drawing.Image)(resources.GetObject("stok_pic.Image")));
            this.stok_pic.Location = new System.Drawing.Point(31, 16);
            this.stok_pic.Name = "stok_pic";
            this.stok_pic.Size = new System.Drawing.Size(82, 65);
            this.stok_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stok_pic.TabIndex = 2;
            this.stok_pic.TabStop = false;
            this.stok_pic.Click += new System.EventHandler(this.stok_pic_Click);
            this.stok_pic.MouseLeave += new System.EventHandler(this.stok_pic_MouseLeave);
            this.stok_pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.stok_pic_MouseMove);
            // 
            // çalışanlar_pnl
            // 
            this.çalışanlar_pnl.Controls.Add(this.çalışanlar_lbl);
            this.çalışanlar_pnl.Controls.Add(this.çalışanlar_pic);
            this.çalışanlar_pnl.Location = new System.Drawing.Point(12, 247);
            this.çalışanlar_pnl.Name = "çalışanlar_pnl";
            this.çalışanlar_pnl.Size = new System.Drawing.Size(143, 100);
            this.çalışanlar_pnl.TabIndex = 3;
            this.çalışanlar_pnl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.çalışanlar_pnl_MouseClick);
            this.çalışanlar_pnl.MouseLeave += new System.EventHandler(this.çalışanlar_pnl_MouseLeave);
            this.çalışanlar_pnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.çalışanlar_pnl_MouseMove);
            // 
            // çalışanlar_lbl
            // 
            this.çalışanlar_lbl.AutoSize = true;
            this.çalışanlar_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çalışanlar_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.çalışanlar_lbl.Location = new System.Drawing.Point(25, 80);
            this.çalışanlar_lbl.Name = "çalışanlar_lbl";
            this.çalışanlar_lbl.Size = new System.Drawing.Size(88, 20);
            this.çalışanlar_lbl.TabIndex = 2;
            this.çalışanlar_lbl.Text = "Çalışanlar";
            this.çalışanlar_lbl.Click += new System.EventHandler(this.çalışanlar_lbl_Click);
            this.çalışanlar_lbl.MouseLeave += new System.EventHandler(this.çalışanlar_lbl_MouseLeave);
            this.çalışanlar_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.çalışanlar_lbl_MouseMove);
            // 
            // çalışanlar_pic
            // 
            this.çalışanlar_pic.Image = ((System.Drawing.Image)(resources.GetObject("çalışanlar_pic.Image")));
            this.çalışanlar_pic.Location = new System.Drawing.Point(31, 16);
            this.çalışanlar_pic.Name = "çalışanlar_pic";
            this.çalışanlar_pic.Size = new System.Drawing.Size(82, 65);
            this.çalışanlar_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.çalışanlar_pic.TabIndex = 2;
            this.çalışanlar_pic.TabStop = false;
            this.çalışanlar_pic.Click += new System.EventHandler(this.çalışanlar_pic_Click);
            this.çalışanlar_pic.MouseLeave += new System.EventHandler(this.çalışanlar_pic_MouseLeave);
            this.çalışanlar_pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.çalışanlar_pic_MouseMove);
            // 
            // anasayfa_pnl
            // 
            this.anasayfa_pnl.Controls.Add(this.anasayfa_lbl);
            this.anasayfa_pnl.Controls.Add(this.anasayfa_pic);
            this.anasayfa_pnl.Location = new System.Drawing.Point(12, 126);
            this.anasayfa_pnl.Name = "anasayfa_pnl";
            this.anasayfa_pnl.Size = new System.Drawing.Size(143, 100);
            this.anasayfa_pnl.TabIndex = 2;
            this.anasayfa_pnl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.anasayfa_pnl_MouseClick);
            this.anasayfa_pnl.MouseLeave += new System.EventHandler(this.anasayfa_pnl_MouseLeave);
            this.anasayfa_pnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.anasayfa_pnl_MouseMove);
            // 
            // anasayfa_lbl
            // 
            this.anasayfa_lbl.AutoSize = true;
            this.anasayfa_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfa_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.anasayfa_lbl.Location = new System.Drawing.Point(29, 80);
            this.anasayfa_lbl.Name = "anasayfa_lbl";
            this.anasayfa_lbl.Size = new System.Drawing.Size(84, 20);
            this.anasayfa_lbl.TabIndex = 2;
            this.anasayfa_lbl.Text = "Anasayfa";
            this.anasayfa_lbl.Click += new System.EventHandler(this.anasayfa_lbl_Click);
            this.anasayfa_lbl.MouseLeave += new System.EventHandler(this.anasayfa_lbl_MouseLeave);
            this.anasayfa_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.anasayfa_lbl_MouseMove);
            // 
            // anasayfa_pic
            // 
            this.anasayfa_pic.Image = ((System.Drawing.Image)(resources.GetObject("anasayfa_pic.Image")));
            this.anasayfa_pic.Location = new System.Drawing.Point(31, 16);
            this.anasayfa_pic.Name = "anasayfa_pic";
            this.anasayfa_pic.Size = new System.Drawing.Size(82, 65);
            this.anasayfa_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anasayfa_pic.TabIndex = 2;
            this.anasayfa_pic.TabStop = false;
            this.anasayfa_pic.Click += new System.EventHandler(this.anasayfa_pic_Click);
            this.anasayfa_pic.MouseLeave += new System.EventHandler(this.anasayfa_pic_MouseLeave);
            this.anasayfa_pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.anasayfa_pic_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btn_yenile);
            this.panel2.Controls.Add(this.düzenle_btn);
            this.panel2.Location = new System.Drawing.Point(156, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 141);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // btn_yenile
            // 
            this.btn_yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.btn_yenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yenile.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_yenile.Location = new System.Drawing.Point(377, 98);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(93, 27);
            this.btn_yenile.TabIndex = 5;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = false;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // düzenle_btn
            // 
            this.düzenle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.düzenle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.düzenle_btn.ForeColor = System.Drawing.Color.SlateGray;
            this.düzenle_btn.Location = new System.Drawing.Point(378, 62);
            this.düzenle_btn.Name = "düzenle_btn";
            this.düzenle_btn.Size = new System.Drawing.Size(93, 27);
            this.düzenle_btn.TabIndex = 4;
            this.düzenle_btn.Text = "Düzenle";
            this.düzenle_btn.UseVisualStyleBackColor = false;
            this.düzenle_btn.Click += new System.EventHandler(this.düzenle_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(916, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hakkında";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label5_MouseMove);
            // 
            // db_görüntüleyici
            // 
            this.db_görüntüleyici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_görüntüleyici.Location = new System.Drawing.Point(171, 88);
            this.db_görüntüleyici.Name = "db_görüntüleyici";
            this.db_görüntüleyici.Size = new System.Drawing.Size(794, 369);
            this.db_görüntüleyici.TabIndex = 15;
            // 
            // çalışan_maaş
            // 
            this.çalışan_maaş.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.çalışan_maaş.ChartAreas.Add(chartArea1);
            this.çalışan_maaş.DataSource = this.çalışanlarBindingSource;
            legend1.Name = "Legend1";
            this.çalışan_maaş.Legends.Add(legend1);
            this.çalışan_maaş.Location = new System.Drawing.Point(171, 328);
            this.çalışan_maaş.Name = "çalışan_maaş";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Maaşlar";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.XValueMember = "ad soyad";
            series1.YValueMembers = "maaş";
            this.çalışan_maaş.Series.Add(series1);
            this.çalışan_maaş.Size = new System.Drawing.Size(768, 156);
            this.çalışan_maaş.TabIndex = 14;
            this.çalışan_maaş.Text = "chart2";
            // 
            // çalışanlarBindingSource
            // 
            this.çalışanlarBindingSource.DataMember = "çalışanlar";
            this.çalışanlarBindingSource.DataSource = this.eRP_ikiDataSet2;
            // 
            // eRP_ikiDataSet2
            // 
            this.eRP_ikiDataSet2.DataSetName = "ERP_ikiDataSet2";
            this.eRP_ikiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // en_çok_satılan
            // 
            this.en_çok_satılan.BackColor = System.Drawing.Color.DimGray;
            chartArea2.Name = "ChartArea1";
            this.en_çok_satılan.ChartAreas.Add(chartArea2);
            this.en_çok_satılan.DataSource = this.stokBindingSource;
            legend2.Name = "Legend1";
            this.en_çok_satılan.Legends.Add(legend2);
            this.en_çok_satılan.Location = new System.Drawing.Point(600, 73);
            this.en_çok_satılan.Name = "en_çok_satılan";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "ürün_ad";
            series2.YValueMembers = "ürün_toplam_satılma";
            this.en_çok_satılan.Series.Add(series2);
            this.en_çok_satılan.Size = new System.Drawing.Size(318, 240);
            this.en_çok_satılan.TabIndex = 13;
            this.en_çok_satılan.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            title1.Name = "Ürünlerin satış oranları";
            title1.Text = "Ürünlerin satış oranları";
            this.en_çok_satılan.Titles.Add(title1);
            // 
            // stokBindingSource
            // 
            this.stokBindingSource.DataMember = "Stok";
            this.stokBindingSource.DataSource = this.eRP_ikiDataSet1;
            // 
            // eRP_ikiDataSet1
            // 
            this.eRP_ikiDataSet1.DataSetName = "ERP_ikiDataSet1";
            this.eRP_ikiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satış
            // 
            this.satış.BackColor = System.Drawing.Color.DimGray;
            this.satış.BorderlineColor = System.Drawing.Color.LightGray;
            chartArea3.Name = "ChartArea1";
            this.satış.ChartAreas.Add(chartArea3);
            this.satış.DataSource = this.satışBindingSource;
            legendCellColumn1.Name = "satış_adet";
            legend3.CellColumns.Add(legendCellColumn1);
            legend3.Name = "Legend1";
            this.satış.Legends.Add(legend3);
            this.satış.Location = new System.Drawing.Point(189, 73);
            this.satış.Name = "satış";
            this.satış.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Color = System.Drawing.Color.DarkOliveGreen;
            series3.Legend = "Legend1";
            series3.Name = "Satış";
            series3.XValueMember = "satış_tarihi";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series3.YValueMembers = "satış_adet";
            this.satış.Series.Add(series3);
            this.satış.Size = new System.Drawing.Size(405, 240);
            this.satış.TabIndex = 12;
            this.satış.Text = "chart1";
            // 
            // satışBindingSource
            // 
            this.satışBindingSource.DataMember = "satış";
            this.satışBindingSource.DataSource = this.eRP_ikiDataSet;
            // 
            // eRP_ikiDataSet
            // 
            this.eRP_ikiDataSet.DataSetName = "ERP_ikiDataSet";
            this.eRP_ikiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satışTableAdapter
            // 
            this.satışTableAdapter.ClearBeforeFill = true;
            // 
            // stokTableAdapter
            // 
            this.stokTableAdapter.ClearBeforeFill = true;
            // 
            // çalışanlarTableAdapter
            // 
            this.çalışanlarTableAdapter.ClearBeforeFill = true;
            // 
            // grafikleri_yenile
            // 
            this.grafikleri_yenile.AutoSize = true;
            this.grafikleri_yenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grafikleri_yenile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grafikleri_yenile.Location = new System.Drawing.Point(485, 2);
            this.grafikleri_yenile.Name = "grafikleri_yenile";
            this.grafikleri_yenile.Size = new System.Drawing.Size(133, 20);
            this.grafikleri_yenile.TabIndex = 16;
            this.grafikleri_yenile.Text = "Grafikleri yenile";
            this.grafikleri_yenile.Click += new System.EventHandler(this.grafikleri_yenile_Click);
            this.grafikleri_yenile.MouseLeave += new System.EventHandler(this.grafikleri_yenile_MouseLeave);
            this.grafikleri_yenile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grafikleri_yenile_MouseMove);
            // 
            // yönetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1000, 612);
            this.Controls.Add(this.grafikleri_yenile);
            this.Controls.Add(this.db_görüntüleyici);
            this.Controls.Add(this.çalışan_maaş);
            this.Controls.Add(this.en_çok_satılan);
            this.Controls.Add(this.satış);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yönetici";
            this.Load += new System.EventHandler(this.yönetici_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.yönetici_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.yönetici_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.yönetici_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.satış_pnl.ResumeLayout(false);
            this.satış_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satış_pic)).EndInit();
            this.stok_pnl.ResumeLayout(false);
            this.stok_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stok_pic)).EndInit();
            this.çalışanlar_pnl.ResumeLayout(false);
            this.çalışanlar_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.çalışanlar_pic)).EndInit();
            this.anasayfa_pnl.ResumeLayout(false);
            this.anasayfa_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anasayfa_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_görüntüleyici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.çalışan_maaş)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.çalışanlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRP_ikiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en_çok_satılan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRP_ikiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satış)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satışBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRP_ikiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel anasayfa_pnl;
        private System.Windows.Forms.Label anasayfa_lbl;
        private System.Windows.Forms.PictureBox anasayfa_pic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel çalışanlar_pnl;
        private System.Windows.Forms.Label çalışanlar_lbl;
        private System.Windows.Forms.PictureBox çalışanlar_pic;
        private System.Windows.Forms.Panel satış_pnl;
        private System.Windows.Forms.Label satış_lbl;
        private System.Windows.Forms.PictureBox satış_pic;
        private System.Windows.Forms.Panel stok_pnl;
        private System.Windows.Forms.Label stok_lbl;
        private System.Windows.Forms.PictureBox stok_pic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Button düzenle_btn;
        private System.Windows.Forms.DataGridView db_görüntüleyici;
        private System.Windows.Forms.DataVisualization.Charting.Chart çalışan_maaş;
        private System.Windows.Forms.DataVisualization.Charting.Chart en_çok_satılan;
        private System.Windows.Forms.DataVisualization.Charting.Chart satış;
        private ERP_ikiDataSet eRP_ikiDataSet;
        private System.Windows.Forms.BindingSource satışBindingSource;
        private ERP_ikiDataSetTableAdapters.satışTableAdapter satışTableAdapter;
        private ERP_ikiDataSet1 eRP_ikiDataSet1;
        private System.Windows.Forms.BindingSource stokBindingSource;
        private ERP_ikiDataSet1TableAdapters.StokTableAdapter stokTableAdapter;
        private ERP_ikiDataSet2 eRP_ikiDataSet2;
        private System.Windows.Forms.BindingSource çalışanlarBindingSource;
        private ERP_ikiDataSet2TableAdapters.çalışanlarTableAdapter çalışanlarTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label grafikleri_yenile;
    }
}

