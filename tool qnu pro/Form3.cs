using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Principal;
using System.Threading;

namespace tool_qnu_pro
{
    public partial class frmhocbong : Form
    {
        public frmhocbong()
        {
            InitializeComponent();
        }
        string datafile_old="";
        public void frmhocbong_Load(object sender, EventArgs e)
        {
            int i =0;
            string data;
            string[] sinhvien,index,itemvip;
                if (File.Exists("Data.txt"))
                {
                    data = File.ReadAllText("Data.txt");
                    datafile_old = data;
                         sinhvien = data.Split('*');
                         for (int l = 0; l < sinhvien.Length - 1; l++) {
                           index = sinhvien[l].Split('|');
                              dgvdata.Rows.Add(new object[]
                              {
                              index[8], index[9],index[10],"xx",index[0],index[1],index[2],index[3],index[4],index[5],index[6],index[7]
                              });

                              if (index[10] == "Đạt")
                              {
                              dgvdata.Rows[i].Cells[2].Style.ForeColor = Color.Green;
                              dgvdata.Rows[i].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                              }
                              else
                              {
                              dgvdata.Rows[i].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                               }
                              i++;

                          }
                          btnsoluongsinhvien.Text = "Số sinh viên: " + (sinhvien.Length - 1).ToString();
                    
                }
            
        }

        private void btnloaddiem_Click(object sender, EventArgs e)
        {
            Form frm= new frmdata();
            frm.ShowDialog();
        }

        private void btnrank_Click(object sender, EventArgs e)
        {
            if (dgvdata.Columns[1].HeaderCell.SortGlyphDirection == SortOrder.None)
            {
                dgvdata.Sort(dgvdata.Columns[1], ListSortDirection.Descending);
                for (int i = 0; i < dgvdata.Rows.Count - 1; i++)
                {
                    dgvdata.Rows[i].Cells[3].Value = i + 1;
                }
            }

        }

        private void btnrankhb_Click(object sender, EventArgs e)
        {
        }


        private void dgvdata_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btn1.Text = dgvdata.Rows[dgvdata.CurrentCell.RowIndex].Cells[4].Value.ToString();
            btn2.Text = dgvdata.Rows[dgvdata.CurrentCell.RowIndex].Cells[5].Value.ToString();
            btn3.Text = dgvdata.Rows[dgvdata.CurrentCell.RowIndex].Cells[6].Value.ToString();
            btn4.Text = dgvdata.Rows[dgvdata.CurrentCell.RowIndex].Cells[7].Value.ToString();
            btn5.Text = dgvdata.Rows[dgvdata.CurrentCell.RowIndex].Cells[8].Value.ToString();
            btn6.Text = dgvdata.Rows[dgvdata.CurrentCell.RowIndex].Cells[9].Value.ToString();
            btn7.Text = dgvdata.Rows[dgvdata.CurrentCell.RowIndex].Cells[10].Value.ToString();
            btn8.Text = dgvdata.Rows[dgvdata.CurrentCell.RowIndex].Cells[11].Value.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            File.WriteAllText("data.txt","");
            dgvdata.Rows.Clear();
            btnsoluongsinhvien.Text = "Số sinh viên: 0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string data;
            string[] sinhvien, index, itemvip;
            if (File.Exists("Data.txt"))
            {
                data = File.ReadAllText("Data.txt");
                if (datafile_old != data)
                {
                    datafile_old = data;
                    sinhvien = data.Split('*');
                    for (int l = 0; l < sinhvien.Length - 1; l++)
                    {
                        index = sinhvien[l].Split('|');
                        dgvdata.Rows.Add(new object[]
                        {
                              index[8], index[9],index[10],"xx",index[0],index[1],index[2],index[3],index[4],index[5],index[6],index[7]
                        });

                        if (index[10] == "Đạt")
                        {
                            dgvdata.Rows[i].Cells[2].Style.ForeColor = Color.Green;
                            dgvdata.Rows[i].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                        else
                        {
                            dgvdata.Rows[i].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                        i++;

                    }
                    btnsoluongsinhvien.Text = "Số sinh viên: " + (sinhvien.Length - 1).ToString();

                }
                else
                {
                    MessageBox.Show("Đã cập nhập rồi mà má");
                }

            }
        }
    }
}
