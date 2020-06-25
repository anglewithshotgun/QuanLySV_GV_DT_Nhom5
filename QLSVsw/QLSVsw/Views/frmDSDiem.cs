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
    public partial class frmDSDiem : Form
    {
        public frmDSDiem(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }
        private string masv;
        private void Loaddsdiem()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = masv
            });
            lst.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTukhoa.Text
            }) ;
            dgvdsdiem.DataSource = new Database().SelectData("dsdiem", lst);
        }

        private void frmDSDiem_Load(object sender, EventArgs e)
        {
            Loaddsdiem();
            dgvdsdiem.Columns["maDetai"].HeaderText = "Mã đề tài";
            dgvdsdiem.Columns["loaiDetai"].HeaderText = "Loại đề tài";
            dgvdsdiem.Columns["tenDetai"].HeaderText = "Tên đề tài";
            dgvdsdiem.Columns["gvien"].HeaderText = "Giáo viên phụ trách";
            dgvdsdiem.Columns["tienTrinhDT"].HeaderText = "Tiến trình";
            dgvdsdiem.Columns["diemDetai"].HeaderText = "Điểm đề tài";
        }

        private void picTimKiem_Click(object sender, EventArgs e)
        {
            Loaddsdiem();
        }

        private void txtTukhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Loaddsdiem();
            }
        }
    }
}
