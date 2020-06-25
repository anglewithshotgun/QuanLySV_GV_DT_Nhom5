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
    public partial class frDangkyMonhoc : Form
    {
        public frDangkyMonhoc(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }
        private string masv;
        private void frDangkyMonhoc_Load(object sender, EventArgs e)
        {
            loadDSDT();
            // custom tên cột
            dgvDSDT.Columns["maDetai"].HeaderText = "Mã đề tài";
            dgvDSDT.Columns["loaiDetai"].HeaderText = "Loại đề tài";
            dgvDSDT.Columns["tenDetai"].HeaderText = "Tên đề tài";
            dgvDSDT.Columns["gvien"].HeaderText = "Giáo viên phụ trách";
            dgvDSDT.Columns["malophoc"].HeaderText = "Mã lớp học";
        }
        private void loadDSDT()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = masv
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTukhoa.Text
            });
            dgvDSDT.DataSource = new Database().SelectData("dsDetai", lstPara);
        }

        private void dgvDSDT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDSDT.Rows[e.RowIndex].Index >= 0)
            {
                DialogResult dkydetai = MessageBox.Show("Bạn có muốn đăng ký đề tài ["+ 
                    dgvDSDT.Rows[e.RowIndex].Cells["tenDetai"].Value.ToString()+"]?","Xác nhận đăng ký" 
                    ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(dkydetai == DialogResult.Yes)
                {
                    List<CustomParameter> lstPara = new List<CustomParameter>();
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@masinhvien",
                        value = masv
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@maDetai",
                        value = dgvDSDT.Rows[e.RowIndex].Cells["maDetai"].Value.ToString()
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@malophoc",
                        value = dgvDSDT.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()
                    });


                    var rs = new Database().ExCute("[dkydetai]", lstPara);
                    if(rs == -1)
                    {
                        MessageBox.Show("Bạn đã đăng ký đề tài này ở giáo viên khác", "Thông báo");
                        return;
                    }
                    else if( rs==1)
                    {
                        MessageBox.Show("Đăng ký thành công", "Thông báo");
                        loadDSDT();
                    }    
                }    
            }    
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loadDSDT();
            }
        }

        private void picTimKiem_Click(object sender, EventArgs e)
        {
            loadDSDT();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
