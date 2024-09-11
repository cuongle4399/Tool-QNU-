namespace tool_qnu_pro
{
    partial class frmhocbong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhocbong));
            this.btnloaddiem = new System.Windows.Forms.Button();
            this.btnrank = new System.Windows.Forms.Button();
            this.btnsoluongsinhvien = new System.Windows.Forms.Button();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdkhb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnupdatedata = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnloaddiem
            // 
            this.btnloaddiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloaddiem.Location = new System.Drawing.Point(26, 279);
            this.btnloaddiem.Name = "btnloaddiem";
            this.btnloaddiem.Size = new System.Drawing.Size(131, 62);
            this.btnloaddiem.TabIndex = 1;
            this.btnloaddiem.Text = "Tải dữ liệu";
            this.btnloaddiem.UseVisualStyleBackColor = true;
            this.btnloaddiem.Click += new System.EventHandler(this.btnloaddiem_Click);
            // 
            // btnrank
            // 
            this.btnrank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrank.Location = new System.Drawing.Point(172, 279);
            this.btnrank.Name = "btnrank";
            this.btnrank.Size = new System.Drawing.Size(91, 62);
            this.btnrank.TabIndex = 2;
            this.btnrank.Text = "Top";
            this.btnrank.UseVisualStyleBackColor = true;
            this.btnrank.Click += new System.EventHandler(this.btnrank_Click);
            // 
            // btnsoluongsinhvien
            // 
            this.btnsoluongsinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsoluongsinhvien.Location = new System.Drawing.Point(553, 279);
            this.btnsoluongsinhvien.Name = "btnsoluongsinhvien";
            this.btnsoluongsinhvien.Size = new System.Drawing.Size(191, 62);
            this.btnsoluongsinhvien.TabIndex = 4;
            this.btnsoluongsinhvien.Text = "Số sinh viên";
            this.btnsoluongsinhvien.UseVisualStyleBackColor = true;
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cname,
            this.cdtb,
            this.cdkhb,
            this.ctop,
            this.diem1,
            this.diem2,
            this.diem3,
            this.diem4,
            this.diem5,
            this.diem6,
            this.diem7,
            this.diem8});
            this.dgvdata.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvdata.Location = new System.Drawing.Point(0, 0);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersVisible = false;
            this.dgvdata.RowHeadersWidth = 51;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.Size = new System.Drawing.Size(950, 273);
            this.dgvdata.TabIndex = 5;
            this.dgvdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellClick_1);
            // 
            // cname
            // 
            this.cname.HeaderText = "Họ và tên";
            this.cname.MinimumWidth = 6;
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            this.cname.Width = 400;
            // 
            // cdtb
            // 
            this.cdtb.HeaderText = "Điểm trung bình";
            this.cdtb.MinimumWidth = 6;
            this.cdtb.Name = "cdtb";
            this.cdtb.ReadOnly = true;
            this.cdtb.Width = 150;
            // 
            // cdkhb
            // 
            this.cdkhb.HeaderText = "Điều kiện học bổng";
            this.cdkhb.MinimumWidth = 6;
            this.cdkhb.Name = "cdkhb";
            this.cdkhb.ReadOnly = true;
            this.cdkhb.Width = 280;
            // 
            // ctop
            // 
            this.ctop.HeaderText = "Top";
            this.ctop.MinimumWidth = 6;
            this.ctop.Name = "ctop";
            this.ctop.ReadOnly = true;
            this.ctop.Width = 150;
            // 
            // diem1
            // 
            this.diem1.HeaderText = "diem1";
            this.diem1.MinimumWidth = 6;
            this.diem1.Name = "diem1";
            this.diem1.ReadOnly = true;
            this.diem1.Visible = false;
            this.diem1.Width = 125;
            // 
            // diem2
            // 
            this.diem2.HeaderText = "diem2";
            this.diem2.MinimumWidth = 6;
            this.diem2.Name = "diem2";
            this.diem2.ReadOnly = true;
            this.diem2.Visible = false;
            this.diem2.Width = 125;
            // 
            // diem3
            // 
            this.diem3.HeaderText = "diem3";
            this.diem3.MinimumWidth = 6;
            this.diem3.Name = "diem3";
            this.diem3.ReadOnly = true;
            this.diem3.Visible = false;
            this.diem3.Width = 125;
            // 
            // diem4
            // 
            this.diem4.HeaderText = "diem4";
            this.diem4.MinimumWidth = 6;
            this.diem4.Name = "diem4";
            this.diem4.ReadOnly = true;
            this.diem4.Visible = false;
            this.diem4.Width = 125;
            // 
            // diem5
            // 
            this.diem5.HeaderText = "diem5";
            this.diem5.MinimumWidth = 6;
            this.diem5.Name = "diem5";
            this.diem5.ReadOnly = true;
            this.diem5.Visible = false;
            this.diem5.Width = 125;
            // 
            // diem6
            // 
            this.diem6.HeaderText = "diem6";
            this.diem6.MinimumWidth = 6;
            this.diem6.Name = "diem6";
            this.diem6.ReadOnly = true;
            this.diem6.Visible = false;
            this.diem6.Width = 125;
            // 
            // diem7
            // 
            this.diem7.HeaderText = "diem7";
            this.diem7.MinimumWidth = 6;
            this.diem7.Name = "diem7";
            this.diem7.ReadOnly = true;
            this.diem7.Visible = false;
            this.diem7.Width = 125;
            // 
            // diem8
            // 
            this.diem8.HeaderText = "diem8";
            this.diem8.MinimumWidth = 6;
            this.diem8.Name = "diem8";
            this.diem8.ReadOnly = true;
            this.diem8.Visible = false;
            this.diem8.Width = 125;
            // 
            // btn1
            // 
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Red;
            this.btn1.Location = new System.Drawing.Point(14, 347);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(72, 58);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "Điểm";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Red;
            this.btn2.Location = new System.Drawing.Point(108, 347);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(72, 58);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "Điểm";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Red;
            this.btn4.Location = new System.Drawing.Point(303, 347);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(72, 58);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "Điểm";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Red;
            this.btn3.Location = new System.Drawing.Point(204, 347);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(72, 58);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "Điểm";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Red;
            this.btn8.Location = new System.Drawing.Point(681, 347);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(72, 58);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "Điểm";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Red;
            this.btn7.Location = new System.Drawing.Point(583, 347);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(72, 58);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "Điểm";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Red;
            this.btn6.Location = new System.Drawing.Point(492, 347);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(72, 58);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "Điểm";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Red;
            this.btn5.Location = new System.Drawing.Point(399, 347);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(72, 58);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "Điểm";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(399, 279);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(148, 62);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.Text = "Xóa toàn bộ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnupdatedata
            // 
            this.btnupdatedata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatedata.Location = new System.Drawing.Point(269, 279);
            this.btnupdatedata.Name = "btnupdatedata";
            this.btnupdatedata.Size = new System.Drawing.Size(124, 62);
            this.btnupdatedata.TabIndex = 16;
            this.btnupdatedata.Text = "Cập nhập";
            this.btnupdatedata.UseVisualStyleBackColor = true;
            this.btnupdatedata.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmhocbong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(950, 417);
            this.Controls.Add(this.btnupdatedata);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnsoluongsinhvien);
            this.Controls.Add(this.btnrank);
            this.Controls.Add(this.btnloaddiem);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmhocbong";
            this.Text = "Dữ liệu";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmhocbong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnloaddiem;
        private System.Windows.Forms.Button btnrank;
        private System.Windows.Forms.Button btnsoluongsinhvien;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdkhb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctop;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem3;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem4;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem5;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem6;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem7;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem8;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnupdatedata;
    }
}