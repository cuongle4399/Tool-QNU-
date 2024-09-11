namespace tool_qnu_pro
{
    partial class frmhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbavatar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnmessager = new System.Windows.Forms.Button();
            this.btncaodata = new System.Windows.Forms.Button();
            this.pnhocbong = new System.Windows.Forms.Panel();
            this.btnxemdiem = new System.Windows.Forms.Button();
            this.btnthoikhoabieu = new System.Windows.Forms.Button();
            this.btninfor = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btntrangchu = new System.Windows.Forms.Button();
            this.lblclass = new System.Windows.Forms.Label();
            this.lblinformation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pntrangchu = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbavatar)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnhocbong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pntrangchu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.ptbavatar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblclass);
            this.panel1.Controls.Add(this.lblinformation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 570);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ptbavatar
            // 
            this.ptbavatar.Image = ((System.Drawing.Image)(resources.GetObject("ptbavatar.Image")));
            this.ptbavatar.Location = new System.Drawing.Point(91, 4);
            this.ptbavatar.Name = "ptbavatar";
            this.ptbavatar.Size = new System.Drawing.Size(100, 69);
            this.ptbavatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbavatar.TabIndex = 6;
            this.ptbavatar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel3.Controls.Add(this.btnmessager);
            this.panel3.Controls.Add(this.btncaodata);
            this.panel3.Controls.Add(this.pnhocbong);
            this.panel3.Controls.Add(this.btnshow);
            this.panel3.Controls.Add(this.btntrangchu);
            this.panel3.Location = new System.Drawing.Point(3, 159);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 407);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnmessager
            // 
            this.btnmessager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmessager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmessager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmessager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmessager.Location = new System.Drawing.Point(0, 402);
            this.btnmessager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnmessager.Name = "btnmessager";
            this.btnmessager.Size = new System.Drawing.Size(256, 70);
            this.btnmessager.TabIndex = 11;
            this.btnmessager.Text = "Kênh chat online";
            this.btnmessager.UseVisualStyleBackColor = true;
            this.btnmessager.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btncaodata
            // 
            this.btncaodata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncaodata.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncaodata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncaodata.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncaodata.Location = new System.Drawing.Point(0, 332);
            this.btncaodata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncaodata.Name = "btncaodata";
            this.btncaodata.Size = new System.Drawing.Size(256, 70);
            this.btncaodata.TabIndex = 10;
            this.btncaodata.Text = "Cào dữ liệu";
            this.btncaodata.UseVisualStyleBackColor = true;
            this.btncaodata.Click += new System.EventHandler(this.btnthoikhobieu_Click);
            // 
            // pnhocbong
            // 
            this.pnhocbong.Controls.Add(this.btnxemdiem);
            this.pnhocbong.Controls.Add(this.btnthoikhoabieu);
            this.pnhocbong.Controls.Add(this.btninfor);
            this.pnhocbong.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnhocbong.Location = new System.Drawing.Point(0, 140);
            this.pnhocbong.Name = "pnhocbong";
            this.pnhocbong.Size = new System.Drawing.Size(256, 192);
            this.pnhocbong.TabIndex = 9;
            // 
            // btnxemdiem
            // 
            this.btnxemdiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnxemdiem.Location = new System.Drawing.Point(0, 108);
            this.btnxemdiem.Name = "btnxemdiem";
            this.btnxemdiem.Size = new System.Drawing.Size(256, 54);
            this.btnxemdiem.TabIndex = 2;
            this.btnxemdiem.Text = "Xem điểm";
            this.btnxemdiem.UseVisualStyleBackColor = true;
            this.btnxemdiem.Click += new System.EventHandler(this.btnxemdiem_Click);
            // 
            // btnthoikhoabieu
            // 
            this.btnthoikhoabieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnthoikhoabieu.Location = new System.Drawing.Point(0, 54);
            this.btnthoikhoabieu.Name = "btnthoikhoabieu";
            this.btnthoikhoabieu.Size = new System.Drawing.Size(256, 54);
            this.btnthoikhoabieu.TabIndex = 1;
            this.btnthoikhoabieu.Text = "Thời khóa biểu";
            this.btnthoikhoabieu.UseVisualStyleBackColor = true;
            this.btnthoikhoabieu.Click += new System.EventHandler(this.btnshowtop_Click);
            // 
            // btninfor
            // 
            this.btninfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninfor.Location = new System.Drawing.Point(0, 0);
            this.btninfor.Name = "btninfor";
            this.btninfor.Size = new System.Drawing.Size(256, 54);
            this.btninfor.TabIndex = 0;
            this.btninfor.Text = "Xem thông tin";
            this.btninfor.UseVisualStyleBackColor = true;
            this.btninfor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnshow
            // 
            this.btnshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnshow.Location = new System.Drawing.Point(0, 70);
            this.btnshow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(256, 70);
            this.btnshow.TabIndex = 1;
            this.btnshow.Text = "Trình bày";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.button2_Click);
            // 
            // btntrangchu
            // 
            this.btntrangchu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntrangchu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntrangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntrangchu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btntrangchu.Location = new System.Drawing.Point(0, 0);
            this.btntrangchu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btntrangchu.Name = "btntrangchu";
            this.btntrangchu.Size = new System.Drawing.Size(256, 70);
            this.btntrangchu.TabIndex = 0;
            this.btntrangchu.Text = "Trang chủ";
            this.btntrangchu.UseVisualStyleBackColor = true;
            this.btntrangchu.Click += new System.EventHandler(this.btntrangchu_Click);
            // 
            // lblclass
            // 
            this.lblclass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblclass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblclass.Font = new System.Drawing.Font("Segoe UI Black", 12.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclass.ForeColor = System.Drawing.Color.Cyan;
            this.lblclass.Location = new System.Drawing.Point(3, 117);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(275, 37);
            this.lblclass.TabIndex = 5;
            this.lblclass.Text = "class";
            this.lblclass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblinformation
            // 
            this.lblinformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblinformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblinformation.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinformation.ForeColor = System.Drawing.Color.Cyan;
            this.lblinformation.Location = new System.Drawing.Point(5, 76);
            this.lblinformation.Name = "lblinformation";
            this.lblinformation.Size = new System.Drawing.Size(275, 41);
            this.lblinformation.TabIndex = 4;
            this.lblinformation.Text = "name";
            this.lblinformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::tool_qnu_pro.Properties.Resources.logotrangchu;
            this.pictureBox1.Location = new System.Drawing.Point(45, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(867, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(396, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pntrangchu
            // 
            this.pntrangchu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pntrangchu.Controls.Add(this.button1);
            this.pntrangchu.Controls.Add(this.pictureBox1);
            this.pntrangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pntrangchu.Location = new System.Drawing.Point(286, 0);
            this.pntrangchu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pntrangchu.Name = "pntrangchu";
            this.pntrangchu.Size = new System.Drawing.Size(960, 570);
            this.pntrangchu.TabIndex = 0;
            this.pntrangchu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1245, 570);
            this.Controls.Add(this.pntrangchu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tool QNU";
            this.Load += new System.EventHandler(this.frmhome_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbavatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnhocbong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pntrangchu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btntrangchu;
        private System.Windows.Forms.Label lblinformation;
        private System.Windows.Forms.Label lblclass;
        private System.Windows.Forms.PictureBox ptbavatar;
        private System.Windows.Forms.Panel pnhocbong;
        private System.Windows.Forms.Button btninfor;
        private System.Windows.Forms.Button btnmessager;
        private System.Windows.Forms.Button btncaodata;
        private System.Windows.Forms.Button btnxemdiem;
        private System.Windows.Forms.Button btnthoikhoabieu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pntrangchu;
    }
}

