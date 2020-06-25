using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSVsw
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {

            //Form1 f = new Form1();
            //f.Hide();

            InitializeComponent();
            this.txtMatkhau.PasswordChar = '*';
        }

        
         private string taikhoan;
        private string loaitk;
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            Dangnhap();
            
        }
        private void Dangnhap()
        {
            // Kiem tra rang buot
            if (cbbLoaitaikhoan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui long chon loai tai khoan", "Tai khoan khong duoc de trong");
                return;
            }
            if (string.IsNullOrEmpty(txtTentaikhoan.Text))
            {
                MessageBox.Show("Vui long nhap tai khoan");
                txtTentaikhoan.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtMatkhau.Text))
            {
                MessageBox.Show("Vui long nhap mat khau", "Mat khau khong the bo trong");
            }

            taikhoan = txtTentaikhoan.Text;
            loaitk = "";
            #region swtk
            switch (cbbLoaitaikhoan.Text)
            {
                case "Quản trị viên":
                    loaitk = "admin";
                    break;
                case "Giáo viên":
                   loaitk = "GV";
                    break;
                case "Sinh viên":
                    loaitk = "SV";
                    break;
            }
            #endregion

            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key="@loaitaikhoan",
                    value=loaitk
                },
                new CustomParameter()
                {
                    key="@taikhoan",
                    value=txtTentaikhoan.Text
                },
                new CustomParameter()
                {
                    key="@matkhau",
                    value=txtMatkhau.Text
                },


            };
            var rs = new Database().SelectData("dangnhap", lst);
            if (rs.Rows.Count > 0)
            {
                //MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                Form1 fn = new Form1(taikhoan, loaitk);
                fn.ShowDialog();


                //Form1 f = new Form1();
                //f.Show();
                //this.Hide();
                //Form1 f = new Form1();
                //f.ShowDialog();

            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tài khoản", "Tài khoản hoặc mật khẩu không hợp lệ");
            }


            //var fn = new frmDangnhap();


            //fn.ShowDialog();

            //var tk = this.Tendangnhap;
            //  MessageBox.Show("Tai khoan da dang nhap la: " + tk);
            
            
            
            
            
            //var db = new Database();
            // dgvData.DataSource = db.SelectData(null);

            //taikhoan = this.Tendangnhap;
            //loaitk = this.LoaiTK;
            
            
            
            //if (loaitk.Equals("admin"))
            //{
            //    // Neu la admin
            //    //menustripDangkyMonhoc.Visible = false;



            //}
            //else if (loaitk.Equals("SV"))
            //{
            //    //Neu la sinh vien
            //    btnGiaovien.Visible = false;
            //    btnSinhvien.Visible = false;
            //    //menustripDangkyMonhoc.Visible = true;
            //}
            //else
            //{
            //    //Neu la giao vien
            //    frmDSSV f = new frmDSSV();
            //    AddForm(f);
            //    btnGiaovien.Visible = false;
            //    //menustripDangkyMonhoc.Visible = false;

            //}
        }




        private void txtMatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {

                Dangnhap();
            }
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fr = new Form2();
            fr.ShowDialog();
            this.Show();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();

            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Giáo viên: đăng nhập lần đầu tài khoản là mã giáo viên, mật khẩu mặt định: 0000\n" +
               "2. Sinh viên lần đầu dăng nhập tài khoản là mã sinh viên, mật khẩu mặt định: 0000 \n" +
               "3. Người dùng có thể thay đổi mật khẩu trong phần thông tin cá nhân");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Giáo viên: đăng nhập lần đầu tài khoản là mã giáo viên, mật khẩu mặt định: 0000\n" +
               "2. Sinh viên lần đầu dăng nhập tài khoản là mã sinh viên, mật khẩu mặt định: 0000 \n" +
               "3. Người dùng có thể thay đổi mật khẩu trong phần thông tin cá nhân");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            About fr = new About();
            fr.ShowDialog();
            this.Show();
        }
    }
}
