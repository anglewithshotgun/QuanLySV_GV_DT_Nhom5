using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLSVsw
{
    public partial class frGV : Form
    {
        public frGV(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }
        private string mgv;
        private string nguoithucthi = "admin";
        private void frGV_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(mgv))
            {
                this.Text = "Thêm mới giáo viên";
            }else
            {
                this.Text = "Cập nhật giáo viên";
                var r = new Database().Select("selectGV '" + int.Parse(mgv) + "'");
                txtHo.Text = r["ho"].ToString();
                txtTendem.Text = r["tenDem"].ToString();
                txtTen.Text = r["ten"].ToString();
                rbtNam.Checked = r["gioitinh"].ToString()=="1" ? true : false;
                mtbNgaysinh.Text = r["ngsinh"].ToString();
                txtDienthoai.Text = r["dienThoai"].ToString();
                txtEmail.Text = r["email"].ToString();
                txtDiachi.Text = r["diachi"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(txtMGV.Text)>255)
                {
                    errorProvider1.SetError(txtMGV, "Giới hạn MGV 0-255");
                }
                string sql = "";
                DateTime ngaysinh;
                List<CustomParameter> lstPara = new List<CustomParameter>();
                try
                {
                    ngaysinh = DateTime.ParseExact(mtbNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Ngày sinh không hợp lệ");
                    mtbNgaysinh.Select();
                    return;
                }





                if (string.IsNullOrEmpty(mgv))
                {
                    sql = "insertGV";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@nguoitao",
                        value = nguoithucthi
                    });
                }
                else
                {
                    sql = "updateGV";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@nguoicapnhat",
                        value = nguoithucthi
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@magiaovien",
                        value = mgv
                    });
                }


                lstPara.Add(new CustomParameter()
                {


                    key = "@magiaovien",
                    value = txtMGV.Text


                });




                lstPara.Add(new CustomParameter()
                {
                    key = "@ho",
                    value = txtHo.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@tenDem",
                    value = txtTendem.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@ten",
                    value = txtTen.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@ngaySinh",
                    value = ngaysinh.ToString("yyyy-MM-dd")

                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@gioitinh",
                    value = rbtNam.Checked ? "1" : "0"
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@email",
                    value = txtEmail.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@dienThoai",
                    value = txtDienthoai.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@diachi",
                    value = txtDiachi.Text
                });


                var rs = new Database().ExCute(sql, lstPara);
                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(mgv))
                    {
                        MessageBox.Show("Thêm mới giáo viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thành công");
                    }
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Lưu thất bại");
                }
            }
            catch(Exception ek)
            {
                MessageBox.Show(ek.ToString());
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
