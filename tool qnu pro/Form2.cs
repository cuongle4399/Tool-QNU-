using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Net.Mime.MediaTypeNames;
namespace tool_qnu_pro
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            lblinformation.Visible=false;
        }

        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            int o = 0;
            if (string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrEmpty(txtaccount.Text))
            {
                MessageBox.Show("Nhập Tài khoản, Mật khẩu đi huhuhuhuhu");
                o++;
            }
            if (o == 0)
            {
                lblinformation.Text = "Tiến hành...";
                lblinformation.ForeColor = Color.Blue;
                DateTime timenow = DateTime.Now;

                int i = 0;
                string account2 = txtaccount.Text;
                string password2 = txtpassword.Text;
                ChromeOptions option = new ChromeOptions();
                option.AddArgument("--headless");
                ChromeDriverService cmd = ChromeDriverService.CreateDefaultService();
                cmd.HideCommandPromptWindow = true;
                using (ChromeDriver chrome = new ChromeDriver(option))
                {
                    try
                    {
                        chrome.Url = "https://daotao.qnu.edu.vn/Login";
                        var accountweb = chrome.FindElement(By.Id("txtTaiKhoan"));
                        accountweb.SendKeys(account2.Trim());
                        var passwordweb = chrome.FindElement(By.Id("txtMatKhau"));
                        passwordweb.SendKeys(password2);
                        var loginqnu = chrome.FindElement(By.XPath("/html/body/form/div/div/div[7]/input"));
                        loginqnu.Click();
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại kết nối Internet hoặc web trường bị ngờ u :))");
                        i++;
                    }
                    if (i == 0)
                    {
                        try
                        {
                            lblinformation.Show();
                            lblinformation.Text = "Kiểm tra đăng nhập...";
                            lblinformation.ForeColor = Color.Blue;
                            var idmember = chrome.FindElement(By.XPath("/html/body/form/div/header/div[2]/div/div/div/nav/div[2]/ul[2]/li/a/span[1]"));
                            if (idmember.Displayed)
                            {
                                Thread.Sleep(200);
                                lblinformation.Text = "Đang lấy dữ liệu từ web.....";
                                idmember.Click();
                                var tabthongtin = chrome.FindElement(By.XPath("//*[@id=\"menu\"]/ul[2]/li/ul/li[1]/a"));
                                tabthongtin.Click();
                                var name = chrome.FindElement(By.XPath("//*[@id=\"body\"]/div/div[2]/div/div[2]/table/tbody/tr[3]/td"));
                                var classsform = chrome.FindElement(By.XPath("//*[@id=\"body\"]/div/div[2]/div/div[2]/table/tbody/tr[24]/td[1]"));
                                var sex = chrome.FindElement(By.XPath("//*[@id=\"body\"]/div/div[2]/div/div[2]/table/tbody/tr[6]/td"));
                                string thongtin = name.Text + "|" + classsform.Text + "|" + sex.Text + "|" + txtaccount.Text + "|" + txtpassword.Text;
                                string diemdanhold = File.ReadAllText("diemdanh.txt");
                                if (diemdanhold == 1.ToString())
                                {
                                    ChromeDriver diemdanh = new ChromeDriver(cmd, option);
                                    lblinformation.Text = "Điểm danh. Lần sau login sẽ không cần điểm danh nx";
                                    diemdanh.Url = "https://anotepad.com/notes/tp7tqrap";
                                    var name1 = diemdanh.FindElement(By.Id("comment_name"));
                                    name1.SendKeys(name.Text);
                                    var comment1 = diemdanh.FindElement(By.Id("comment_content"));
                                    comment1.SendKeys("Đã đăng nhập vào lúc :" + timenow);
                                    var submit11 = diemdanh.FindElement(By.Id("comment_submit"));
                                    submit11.Click();
                                    File.WriteAllText("diemdanh.txt", "");
                                }
                                this.Hide();
                                frmhome menuForm = new frmhome();
                                menuForm.data = thongtin;
                                menuForm.Show();
                            }



                        }
                        catch (Exception ex)
                        {
                            lblinformation.Text = "Tài khoản hoặc Mật khẩu bị sai";
                            lblinformation.ForeColor = Color.Red;
                        }
                    }

                }
            }
            

              
        }


        private void lblinformation_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshow.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }


        private void frmlogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            string datalog = File.ReadAllText("login.txt");
            if (datalog != "")
            {
                string info = File.ReadAllText("login.txt");
                string[] info1 =info.Split('|');
                txtaccount.Text = info1[0];
                txtpassword.Text = info1[1];
                btnsavelog.Text = "Delete log";
            }
            else
            {
                btnsavelog.Text = "Save Log";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k=0;
            if (string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrEmpty(txtaccount.Text))
            {
                MessageBox.Show("Nhập Tài khoản, Mật khẩu đi huhuhuhuhu");
                k++;
            }
            if (k == 0)
            {
                string datalog = File.ReadAllText("login.txt");
                if (datalog != "")
                {
                    File.WriteAllText("login.txt", "");
                    txtaccount.Text = "";
                    txtpassword.Text = "";
                    btnsavelog.Text = "Save Log";
                }
                else
                {
                    string savelog = txtaccount.Text + "|" + txtpassword.Text;
                    File.WriteAllText("login.txt", savelog);
                    btnsavelog.Text = "Delete log";
                }
                
            }
        }

        private void lblbsupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100033805601997&locale=vi_VN");
        }
    }
}
