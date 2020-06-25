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
    public partial class frmDSSV : Form
    {
        public frmDSSV()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private string msv = "";
        private void frmDSSV_Load(object sender, EventArgs e)
        {


            LoadDSSV();
            

        }
        private void LoadDSSV()

        {

            List<CustomParameter> lstPara = new List<CustomParameter>();

            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",value= tukhoa
            }); 


            dgvSinhVien.DataSource = null;

            dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhVien", lstPara);
            dgvSinhVien.Columns["masinhvien"].HeaderText = "Mã SV";
            dgvSinhVien.Columns["hoten"].HeaderText = "Họ tên";
            dgvSinhVien.Columns["nsinh"].HeaderText = "Ngày Sinh";
            dgvSinhVien.Columns["gt"].HeaderText = "Giới tính";
            dgvSinhVien.Columns["quequan"].HeaderText = "Quê quán";
       //     dgvSinhVien.Columns["diachi"].HeaderText = "Địa chỉ";
        //    dgvSinhVien.Columns["dienthoai"].HeaderText = "Số điện thoại";
         //   dgvSinhVien.Columns["email"].HeaderText = "Email";

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();

                new frmSinhVien(msv).ShowDialog();




                ////
                ///sau khi dong frmSinh vien, load lai dssv
                ///
                LoadDSSV();



            }
        }


        private void picTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadDSSV();
        }

       
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            msv = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();

        }

        private void txtTuKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                tukhoa = txtTuKhoa.Text;
                LoadDSSV();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmSinhVien(null).ShowDialog();
            tukhoa = "";
            LoadDSSV();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var r = new Database().XoaSV("XoaSV '" + msv + "'");
            tukhoa = "";
            LoadDSSV();
        }
    }
}
