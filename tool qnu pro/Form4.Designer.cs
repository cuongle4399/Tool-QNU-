namespace tool_qnu_pro
{
    partial class frmdata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdata));
            this.txtbegin = new System.Windows.Forms.TextBox();
            this.txtend = new System.Windows.Forms.TextBox();
            this.lblbegin = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblthontin = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtbegin
            // 
            this.txtbegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbegin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbegin.Location = new System.Drawing.Point(235, 42);
            this.txtbegin.Multiline = true;
            this.txtbegin.Name = "txtbegin";
            this.txtbegin.Size = new System.Drawing.Size(250, 47);
            this.txtbegin.TabIndex = 0;
            // 
            // txtend
            // 
            this.txtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtend.Location = new System.Drawing.Point(235, 120);
            this.txtend.Multiline = true;
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(250, 47);
            this.txtend.TabIndex = 1;
            // 
            // lblbegin
            // 
            this.lblbegin.BackColor = System.Drawing.Color.Transparent;
            this.lblbegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbegin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblbegin.Location = new System.Drawing.Point(14, 45);
            this.lblbegin.Name = "lblbegin";
            this.lblbegin.Size = new System.Drawing.Size(183, 47);
            this.lblbegin.TabIndex = 2;
            this.lblbegin.Text = "Nhập mã sinh viên đầu";
            this.lblbegin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblend
            // 
            this.lblend.BackColor = System.Drawing.Color.Transparent;
            this.lblend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblend.Location = new System.Drawing.Point(14, 120);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(183, 47);
            this.lblend.TabIndex = 3;
            this.lblend.Text = "Nhập mã sinh viên cuối";
            this.lblend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnupdate.Location = new System.Drawing.Point(235, 262);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(251, 57);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update or Upload";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtclass
            // 
            this.txtclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtclass.Location = new System.Drawing.Point(235, 185);
            this.txtclass.Multiline = true;
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(112, 52);
            this.txtclass.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(14, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 47);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập lớp";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblthontin
            // 
            this.lblthontin.BackColor = System.Drawing.Color.Transparent;
            this.lblthontin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthontin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblthontin.Location = new System.Drawing.Point(48, 333);
            this.lblthontin.Name = "lblthontin";
            this.lblthontin.Size = new System.Drawing.Size(438, 36);
            this.lblthontin.TabIndex = 7;
            this.lblthontin.Text = "Vui lòng cung cấp thông tin để nhập theo lô";
            this.lblthontin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadd.Location = new System.Drawing.Point(18, 262);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(197, 57);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Add Data";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // frmdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(511, 377);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblthontin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.lblbegin);
            this.Controls.Add(this.txtend);
            this.Controls.Add(this.txtbegin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấp dữ liệu";
            this.Load += new System.EventHandler(this.frmdata_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbegin;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.Label lblbegin;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblthontin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnadd;
    }
}