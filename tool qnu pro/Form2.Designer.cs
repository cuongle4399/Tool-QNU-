namespace tool_qnu_pro
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.lbluser = new System.Windows.Forms.Label();
            this.txtaccount = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblinformation = new System.Windows.Forms.Label();
            this.cbshow = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsavelog = new System.Windows.Forms.Button();
            this.lblbsupport = new System.Windows.Forms.LinkLabel();
            this.lblversion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbluser.Location = new System.Drawing.Point(59, 224);
            this.lbluser.Name = "lbluser";
            this.lbluser.Padding = new System.Windows.Forms.Padding(0, 27, 0, 0);
            this.lbluser.Size = new System.Drawing.Size(136, 71);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "Tài Khoản";
            // 
            // txtaccount
            // 
            this.txtaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaccount.Location = new System.Drawing.Point(202, 224);
            this.txtaccount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtaccount.Multiline = true;
            this.txtaccount.Name = "txtaccount";
            this.txtaccount.Size = new System.Drawing.Size(528, 68);
            this.txtaccount.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(202, 303);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(428, 75);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // lblpassword
            // 
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpassword.Location = new System.Drawing.Point(59, 303);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Padding = new System.Windows.Forms.Padding(0, 27, 0, 0);
            this.lblpassword.Size = new System.Drawing.Size(136, 76);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Mật Khẩu";
            // 
            // btnlogin
            // 
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogin.Location = new System.Drawing.Point(202, 388);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(360, 74);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login QNU";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            this.btnlogin.Enter += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblinformation
            // 
            this.lblinformation.BackColor = System.Drawing.Color.Transparent;
            this.lblinformation.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblinformation.Location = new System.Drawing.Point(124, 479);
            this.lblinformation.Name = "lblinformation";
            this.lblinformation.Size = new System.Drawing.Size(659, 55);
            this.lblinformation.TabIndex = 6;
            this.lblinformation.Text = "Thông báo";
            this.lblinformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblinformation.Click += new System.EventHandler(this.lblinformation_Click);
            // 
            // cbshow
            // 
            this.cbshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbshow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbshow.Location = new System.Drawing.Point(636, 302);
            this.cbshow.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbshow.Name = "cbshow";
            this.cbshow.Size = new System.Drawing.Size(121, 76);
            this.cbshow.TabIndex = 7;
            this.cbshow.Text = "show";
            this.cbshow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbshow.UseVisualStyleBackColor = true;
            this.cbshow.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tool_qnu_pro.Properties.Resources.Tool_QNU_8_27_20241;
            this.pictureBox1.Location = new System.Drawing.Point(86, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(721, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnsavelog
            // 
            this.btnsavelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavelog.Location = new System.Drawing.Point(568, 388);
            this.btnsavelog.Name = "btnsavelog";
            this.btnsavelog.Size = new System.Drawing.Size(162, 74);
            this.btnsavelog.TabIndex = 9;
            this.btnsavelog.Text = "Save Log";
            this.btnsavelog.UseVisualStyleBackColor = true;
            this.btnsavelog.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblbsupport
            // 
            this.lblbsupport.AutoSize = true;
            this.lblbsupport.LinkColor = System.Drawing.Color.Red;
            this.lblbsupport.LinkVisited = true;
            this.lblbsupport.Location = new System.Drawing.Point(833, 9);
            this.lblbsupport.Name = "lblbsupport";
            this.lblbsupport.Size = new System.Drawing.Size(80, 22);
            this.lblbsupport.TabIndex = 10;
            this.lblbsupport.TabStop = true;
            this.lblbsupport.Text = "Support";
            this.lblbsupport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblbsupport_LinkClicked);
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Location = new System.Drawing.Point(843, 40);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(55, 22);
            this.lblversion.TabIndex = 11;
            this.lblversion.Text = "1.0.0";
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(922, 549);
            this.Controls.Add(this.lblversion);
            this.Controls.Add(this.lblbsupport);
            this.Controls.Add(this.btnsavelog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbshow);
            this.Controls.Add(this.lblinformation);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtaccount);
            this.Controls.Add(this.lbluser);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập QNU";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtaccount;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblinformation;
        private System.Windows.Forms.CheckBox cbshow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsavelog;
        private System.Windows.Forms.LinkLabel lblbsupport;
        private System.Windows.Forms.Label lblversion;
    }
}