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
    public partial class frDSGV : Form
    {
        public frDSGV()
        {
            InitializeComponent();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimkiem.Text;
            loadDSGV();
        }
        private string tukhoa = "";
        private string mgvien = "";
        private void loadDSGV()
        {






            string sql = "selectAllGV";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key ="@tukhoa",
                value =tukhoa
            });
            dgvDSGV.DataSource = new Database().SelectData(sql,lstPara);

            dgvDSGV.Columns["magiaovien"].HeaderText = "Mã giáo viên";
            dgvDSGV.Columns["hoten"].HeaderText = "Họ tên";
            dgvDSGV.Columns["email"].HeaderText = "Email";
            dgvDSGV.Columns["gt"].HeaderText = "Giới tính";
            dgvDSGV.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvDSGV.Columns["dienthoai"].HeaderText = "Điện thoại";

        }

        private void frDSGV_Load(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frGV(null).ShowDialog();
            loadDSGV();
        }

        private void dgvDSGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new frGV(mgv).ShowDialog();
                loadDSGV();
            }
        }

        private void dgvDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mgvien = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
        }
        string sql = "XoaGV";
        private void btnDel_Click(object sender, EventArgs e)
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = mgvien

            });
            var r = new Database().ExCute(sql, lstPara);

            loadDSGV();
        }
    }
    
}
