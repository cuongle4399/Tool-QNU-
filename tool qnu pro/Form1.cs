using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.IO;
using System.Diagnostics;


namespace tool_qnu_pro
{
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }
        public string data;
        public DataGridView dataGridView;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        
        private void frmhome_Load(object sender, EventArgs e)
        {
            pnhocbong.Visible = false;
            string[] thongtin = data.Split('|');
            string[] inputname = thongtin[0].Split(' ');
            lblinformation.Text = inputname[inputname.Length - 2] + " " +inputname[inputname.Length-1];
            lblclass.Text = thongtin[1];
            if (thongtin[2] == "Nam")
            {

                ptbavatar.Image = Properties.Resources.boy;
            }
            if (thongtin[2] == "Nữ")
            {
                ptbavatar.Image = Properties.Resources.girl;
            }

        }
        private Form active = null;
        private void openchildform(Form childForm)
        {
            if(active != null)
            {
                active.Close();
            }
            active = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock=DockStyle.Fill;
            pntrangchu.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new frmlogin();
            form.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmlogin();
            form.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool switchdropdown = false;
        private void hidedropdown ()
        {
            if (switchdropdown == true)
            {
                pnhocbong.Visible = false;
                switchdropdown = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (switchdropdown == false)
            {
                pnhocbong.Visible = true;
                switchdropdown = true;
            }
            else
            {
                pnhocbong.Visible = false;
                switchdropdown = false;
            }

        }

        private void btntrangchu_Click(object sender, EventArgs e)
        {
            hidedropdown();
            if(active != null)
            {
                active.Close();
                active = null;
            }
        }

        private void ptbavatar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            string[] thongtinvip = data.Split('|');
            string accountvip = thongtinvip[3];
        }

        private void btnthoikhobieu_Click(object sender, EventArgs e)
        {
            openchildform(new frmhocbong());
            hidedropdown();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            hidedropdown();
            MessageBox.Show("Chức năng này đang trong quá trình xây dựng. Khi xok app sẽ tự cập nhập tự động!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChromeDriverService cmd = ChromeDriverService.CreateDefaultService();
            ChromeDriver trinhduyet = new ChromeDriver(cmd);
            cmd.HideCommandPromptWindow = true;
            string[] thongtinvip = data.Split('|');
            string accountvip = thongtinvip[3];
            string passwordvip = thongtinvip[4];
                trinhduyet.Url = "https://daotao.qnu.edu.vn/Login";
                var accountweb = trinhduyet.FindElement(By.Id("txtTaiKhoan"));
                accountweb.SendKeys(accountvip);
                var passwordweb = trinhduyet.FindElement(By.Id("txtMatKhau"));
                passwordweb.SendKeys(passwordvip);
                var loginqnu = trinhduyet.FindElement(By.XPath("/html/body/form/div/div/div[7]/input"));
                loginqnu.Click();
                Thread.Sleep(200);
                try
                {
                    var idmember = trinhduyet.FindElement(By.XPath("/html/body/form/div/header/div[2]/div/div/div/nav/div[2]/ul[2]/li/a/span[1]"));
                    idmember.Click();
                    var tabthongtin = trinhduyet.FindElement(By.XPath("//*[@id=\"menu\"]/ul[2]/li/ul/li[1]/a"));
                    tabthongtin.Click();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi");
                }
           
        }

        private void btnshowtop_Click(object sender, EventArgs e)
        {
            ChromeDriverService cmd = ChromeDriverService.CreateDefaultService();
            cmd.HideCommandPromptWindow = true;
            string[] thongtinvip = data.Split('|');
            string accountvip = thongtinvip[3];
            string passwordvip = thongtinvip[4];
            ChromeDriver trinhduyet = new ChromeDriver(cmd);
            trinhduyet.Url = "https://daotao.qnu.edu.vn/Login";
            var accountweb = trinhduyet.FindElement(By.Id("txtTaiKhoan"));
            accountweb.SendKeys(accountvip);
            var passwordweb = trinhduyet.FindElement(By.Id("txtMatKhau"));
            passwordweb.SendKeys(passwordvip);
            var loginqnu = trinhduyet.FindElement(By.XPath("/html/body/form/div/div/div[7]/input"));
                loginqnu.Click();
                Thread.Sleep(200);
                try
                {
                    var thoikhoabieu = trinhduyet.FindElement(By.XPath("//*[@id=\"leftMenu\"]/div[3]/div[2]/div/ul/li[5]/a"));
                    thoikhoabieu.Click();
                var combobox = trinhduyet.FindElement(By.Id("TypeID"));
                combobox.Click();
                var tuan = trinhduyet.FindElement(By.XPath("//*[@id=\"TypeID\"]/option[1]"));
                tuan.Click();
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi");
                }

        }

        private void btnxemdiem_Click(object sender, EventArgs e)
        {
            string[] thongtinvip = data.Split('|');
            string accountvip = thongtinvip[3];
            string passwordvip = thongtinvip[4];
            ChromeDriverService cmd = ChromeDriverService.CreateDefaultService();
            cmd.HideCommandPromptWindow = true;
            ChromeDriver trinhduyet = new ChromeDriver(cmd);
            
                trinhduyet.Url = "https://daotao.qnu.edu.vn/Login";
                var accountweb = trinhduyet.FindElement(By.Id("txtTaiKhoan"));
                accountweb.SendKeys(accountvip);
                var passwordweb = trinhduyet.FindElement(By.Id("txtMatKhau"));
                passwordweb.SendKeys(passwordvip);
                var loginqnu = trinhduyet.FindElement(By.XPath("/html/body/form/div/div/div[7]/input"));
                loginqnu.Click();
                Thread.Sleep(200);
                try
                {
                    var diem = trinhduyet.FindElement(By.XPath("//*[@id=\"leftMenu\"]/div[3]/div[2]/div/ul/li[7]/a"));
                    diem.Click();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi");
                }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmlogin();
            form.Show();
        }

    }
}
