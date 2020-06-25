using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QLSVsw
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien(string taikhoan)
        {
            this.msv = taikhoan;
            InitializeComponent();
        }

        private string msv;


        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnLuu_Click(sender, e);///////
                ///////
                ////////
                ///
                ////CO GI THI BI LOI KIEM TRA CHO NAY CAI, e DUA VAO KHAC NHAU
                ///
                ///
            }
        }



        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(msv);
            if (string.IsNullOrEmpty(msv))
            {
                this.Text = "Thêm mới Sinh viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin Sinh viên";
                var r = new Database().Select("selectSV '" + msv + "'");
                // MessageBox.Show(r[0].ToString());
                txtMSSV.Text = r["masinhvien"].ToString();
                txtHo.Text = r["ho"].ToString();
                txtTendem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                mtbNgaysinh.Text = r["ngsinh"].ToString();

                if (int.Parse(r["gioitinh"].ToString()) == 1)
                { rbtNam.Checked = true; rbtNu.Checked = false; }
                else { rbtNu.Checked = true; rbtNam.Checked = false; }

                txtQuequan.Text = r["quequan"].ToString();
                txtDiachi.Text = r["diachi"].ToString();
                txtDienthoai.Text = r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string ho = txtHo.Text;
            string tendem = txtTendem.Text;
            string ten = txtTen.Text;

            DateTime ngaysinh;
            {
                try
                {
                    ngaysinh = DateTime.ParseExact(mtbNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch(Exception)
                {
                    MessageBox.Show("Birthday Invalid");
                    mtbNgaysinh.Select();//dua tro chuot ve mtbNgaysinh
                    return;
                }
            }

            string gioitinh = rbtNam.Checked ? "1" : "0";
            string quequan = txtQuequan.Text;
            string diachi = txtDiachi.Text;
            string dienthoai = txtDienthoai.Text;
            string email = txtEmail.Text;

            List<CustomParameter> lstPara = new List<CustomParameter>();

            if(string.IsNullOrEmpty(msv))
            {
                sql = "ThemMoiSV";
                string msv = txtMSSV.Text;
                lstPara.Add(new CustomParameter()
                {
                    key = "@masinhvien",
                    value = msv

                });
            }
            else
            {
                sql = "UpdateSV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@masinhvien",
                    value = msv

                });
            }


            lstPara.Add(new CustomParameter()
            {
                key = "@ho",
                value = ho

            });

            lstPara.Add(new CustomParameter()
            {
                key = "@tendem",
                value = tendem

            });


            lstPara.Add(new CustomParameter()
            {
                key = "@ten",
                value = ten

            });


            lstPara.Add(new CustomParameter()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")

            });


            lstPara.Add(new CustomParameter()
            {
                key = "@gioitinh",
                value = gioitinh

            });


            lstPara.Add(new CustomParameter()
            {
                key = "@quequan",
                value = quequan

            });


            lstPara.Add(new CustomParameter()
            {
                key = "@diachi",
                value = diachi

            });


            lstPara.Add(new CustomParameter()
            {
                key = "@dienthoai",
                value = dienthoai

            });


            lstPara.Add(new CustomParameter()
            {
                key = "@email",
                value = email

            });



            var rs = new Database().ExCute(sql, lstPara);

            if (rs== 1)
            {
                if (string.IsNullOrEmpty(msv))
                {
                    MessageBox.Show("Add Successfull");
                }
                else
                {
                    MessageBox.Show("Update Successfull");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Fail");
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
