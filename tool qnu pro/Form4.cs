using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tool_qnu_pro
{
    public partial class frmdata : Form
    {
        public frmdata()
        {
            InitializeComponent();
        }
        public string hocbongdata="";
        public float[] diemmon=new float[8];

        private void btnupdate_Click(object sender, EventArgs e )
        {
            if(string.IsNullOrEmpty(txtbegin.Text)||string.IsNullOrEmpty(txtend.Text)|| string.IsNullOrEmpty(txtclass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu nhaaaaaaa!");
            }
            hocbongdata = "";
            int dem = 0;
            long begin = long.Parse(txtbegin.Text.Trim());
            long end = long.Parse(txtend.Text.Trim());
            for (long i = begin; i <= end; i++)
            {
                int dkhb = 0;
                lblthontin.ForeColor = Color.Blue;
                lblthontin.Text = "Đang kiểm tra " + i;
                ChromeOptions option = new ChromeOptions();
                option.AddArgument("--headless");
                ChromeDriverService cmd = ChromeDriverService.CreateDefaultService();
                cmd.HideCommandPromptWindow = true;
                using (ChromeDriver chrome = new ChromeDriver(cmd,option))
                {
                    try
                    {
                        chrome.Url = "https://daotao.qnu.edu.vn/Login";
                        var accountweb = chrome.FindElement(By.Id("txtTaiKhoan"));
                        accountweb.SendKeys(i.ToString());
                        var passwordweb = chrome.FindElement(By.Id("txtMatKhau"));
                        passwordweb.SendKeys("admin");
                        var loginqnu = chrome.FindElement(By.XPath("/html/body/form/div/div/div[7]/input"));
                        loginqnu.Click();
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại kết nối Internet");
                        break;
                    }
                    Thread.Sleep(100);
                    try
                    {
                        var idmember = chrome.FindElement(By.XPath("/html/body/form/div/header/div[2]/div/div/div/nav/div[2]/ul[2]/li/a/span[1]"));
                        idmember.Click();
                        var tabthongtin = chrome.FindElement(By.XPath("//*[@id=\"menu\"]/ul[2]/li/ul/li[1]/a"));
                        tabthongtin.Click();
                        var name = chrome.FindElement(By.XPath("//*[@id=\"body\"]/div/div[2]/div/div[2]/table/tbody/tr[3]/td"));
                        string namevip = name.Text;
                        var classne = chrome.FindElement(By.XPath("//*[@id=\"body\"]/div/div[2]/div/div[2]/table/tbody/tr[24]/td[1]"));
                        string[] khoa = classne.Text.Split(' ');
                        string classkhoa = khoa[khoa.Length - 1];
                        if (txtclass.Text.ToUpper().Trim() != classkhoa)
                        {
                            continue;
                        }
                        var diem = chrome.FindElement(By.XPath("//*[@id=\"leftMenu\"]/div[3]/div[2]/div/ul/li[7]/a"));
                        diem.Click();
                        var menudiemtb = chrome.FindElement(By.XPath("/html/body/form/div/div/div/div[2]/div/div[5]/table/tbody/tr[21]/td[1]"));
                        string[] diemarray = menudiemtb.Text.Split('\n');
                        string[] diemtb = diemarray[2].Split(':');
                        string diemtb1 = diemtb[diemtb.Length - 1].Trim();
                        if (float.Parse(diemtb1) <= 2)
                        {
                            continue;
                        }
                        for (int j = 13; j <= 20; j++)
                        {
                            var diemmonweb = chrome.FindElement(By.XPath("//*[@id=\"divHienthiKQHT\"]/table/tbody/tr[" + j + "]/td[5]"));
                            diemmon[j - 13] = float.Parse(diemmonweb.Text);
                        }
                        for (int j = 0; j <= 7; j++)
                        {
                            hocbongdata += diemmon[j] + "|";
                            if (diemmon[j] < 4 || float.Parse(diemtb1) < 7)
                            {
                                dkhb++;
                            }
                        }
                        hocbongdata += namevip + "|" + diemtb1 + "|";
                        if (dkhb == 0)
                        {
                            hocbongdata += "Đạt" + "*";
                        }
                        else
                        {
                            hocbongdata += "Không Đạt" + "*";
                        }

                        dem++;

                    }
                    catch
                    {
                        lblthontin.ForeColor = Color.Red;
                        lblthontin.Text = "Mã " + i + " đã bị loại";
                    }
                }
                
            }
            
            File.WriteAllText("data.txt", hocbongdata);
            lblthontin.ForeColor = Color.Blue;
            lblthontin.Text = "Đã thêm được " + dem + " thành viên";
            MessageBox.Show("Ấn cập nhập hộ nhé!! \nClick vào cột của dòng sẽ xem được điểm của msv đó :>");
        }

        private void frmdata_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbegin.Text) || string.IsNullOrEmpty(txtend.Text) || string.IsNullOrEmpty(txtclass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu nhaaaaaaa!");
            }
            hocbongdata = "";
            int dem = 0;
            long begin = long.Parse(txtbegin.Text.Trim());
            long end = long.Parse(txtend.Text.Trim());
            for (long i = begin; i <= end; i++)
            {
                int dkhb = 0;
                lblthontin.ForeColor = Color.Blue;
                lblthontin.Text = "Đang kiểm tra " + i;
                ChromeOptions option = new ChromeOptions();
                option.AddArgument("--headless");
                ChromeDriverService cmd = ChromeDriverService.CreateDefaultService();
                cmd.HideCommandPromptWindow = true;
                using (ChromeDriver chrome = new ChromeDriver(cmd,option))
                {
                    try
                    {
                        chrome.Url = "https://daotao.qnu.edu.vn/Login";
                        var accountweb = chrome.FindElement(By.Id("txtTaiKhoan"));
                        accountweb.SendKeys(i.ToString());
                        var passwordweb = chrome.FindElement(By.Id("txtMatKhau"));
                        passwordweb.SendKeys("admin");
                        var loginqnu = chrome.FindElement(By.XPath("/html/body/form/div/div/div[7]/input"));
                        loginqnu.Click();
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại kết nối Internet");
                        break;
                    }
                    Thread.Sleep(100);
                    try
                    {
                        var idmember = chrome.FindElement(By.XPath("/html/body/form/div/header/div[2]/div/div/div/nav/div[2]/ul[2]/li/a/span[1]"));
                        idmember.Click();
                        var tabthongtin = chrome.FindElement(By.XPath("//*[@id=\"menu\"]/ul[2]/li/ul/li[1]/a"));
                        tabthongtin.Click();
                        var name = chrome.FindElement(By.XPath("//*[@id=\"body\"]/div/div[2]/div/div[2]/table/tbody/tr[3]/td"));
                        string namevip = name.Text;
                        var classne = chrome.FindElement(By.XPath("//*[@id=\"body\"]/div/div[2]/div/div[2]/table/tbody/tr[24]/td[1]"));
                        string[] khoa = classne.Text.Split(' ');
                        string classkhoa = khoa[khoa.Length - 1];
                        if (txtclass.Text.ToUpper().Trim() != classkhoa)
                        {
                            continue;
                        }
                        var diem = chrome.FindElement(By.XPath("//*[@id=\"leftMenu\"]/div[3]/div[2]/div/ul/li[7]/a"));
                        diem.Click();
                        var menudiemtb = chrome.FindElement(By.XPath("/html/body/form/div/div/div/div[2]/div/div[5]/table/tbody/tr[21]/td[1]"));
                        string[] diemarray = menudiemtb.Text.Split('\n');
                        string[] diemtb = diemarray[2].Split(':');
                        string diemtb1 = diemtb[diemtb.Length - 1].Trim();
                        if (float.Parse(diemtb1) <= 2)
                        {
                            continue;
                        }
                        for (int j = 13; j <= 20; j++)
                        {
                            var diemmonweb = chrome.FindElement(By.XPath("//*[@id=\"divHienthiKQHT\"]/table/tbody/tr[" + j + "]/td[5]"));
                            diemmon[j - 13] = float.Parse(diemmonweb.Text);
                        }
                        for (int j = 0; j <= 7; j++)
                        {
                            hocbongdata += diemmon[j]+"|";
                            if (diemmon[j] < 4 || float.Parse(diemtb1) < 7)
                            {
                                dkhb++;
                            }
                        }
                        hocbongdata += namevip + "|" + diemtb1 + "|";
                        if (dkhb == 0)
                        {
                            hocbongdata += "Đạt" + "*";
                        }
                        else
                        {
                            hocbongdata += "Không Đạt" + "*";
                        }

                        dem++;

                    }
                    catch
                    {
                        lblthontin.ForeColor = Color.Red;
                        lblthontin.Text = "Mã " + i + " đã bị loại";
                    }
                }

            }
            string dataold = File.ReadAllText("data.txt");
            File.WriteAllText("data.txt", dataold+hocbongdata);
            lblthontin.ForeColor = Color.Blue;
            lblthontin.Text = "Đã thêm được " + dem + " thành viên";
            MessageBox.Show("Ấn cập nhập hộ nhé!! \nClick vào cột của dòng sẽ xem được điểm của msv đó :>");
        }

    }
}
