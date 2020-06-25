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
    public partial class frQuanLyLop : Form
    {
        public frQuanLyLop(string mgv)
        {
           
            this.mgv = mgv;
            InitializeComponent();
        }
        //private string mdt;
        private string mgv;
        private void LoadDSLop()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = mgv
            });
          
            dgvdsLop.DataSource = new Database().SelectData("LoadDSDT", lstPara);
        }
        private void frQuanLyLop_Load(object sender, EventArgs e)
        {
            LoadDSLop();
           // dgvdsLop.Columns["malophoc"].HeaderText = "Mã lớp";
            dgvdsLop.Columns["maDetai"].HeaderText = "Mã đề tài";
            dgvdsLop.Columns["tenDetai"].HeaderText = "Tên đề tài";
            dgvdsLop.Columns["daketthuc"].HeaderText = "Hoàn thành";
            //dgvdsLop.Columns["loaiDetai"].HeaderText = "Loại đề tài";

        }

        private void picTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSLop();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            //
            //txtTukhoa = "";
            pnlThemDT.Visible = true;
            pnlThemDT.Location = new Point(500, 250);

        //    LoadDT();

        }
       
        private string mdt = null;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(txtmadetai.Text)>255)
            {
                errorProvider2.SetError(txtmadetai, "Gioi han mã đề tài 0-255");
            }
            if(Int32.Parse(txtmalophoc.Text)>255)
            {
                errorProvider1.SetError(txtmalophoc, "Giới hạn mã lớp học 0-255");
            }
            string sql = "";
            string madetai = txtmadetai.Text;
            string tendetai = txttendetai.Text;
            string loaidetai = cbbloaidetai.SelectedItem.ToString();
            string malophoc = txtmalophoc.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            List<CustomParameter> lstPara2 = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mdt))
            {
                sql = "ThemDT";
                
                lstPara.Add(new CustomParameter()
                {
                    key = "@madetai",
                    value = madetai

                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@tendetai",
                    value = tendetai

                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@loaidetai",
                    value = loaidetai

                });
               

                


                lstPara2.Add(new CustomParameter()
                {
                    key = "@magiaovien",
                    value = mgv

                });

                lstPara2.Add(new CustomParameter()
                {
                    key = "@madetai",
                    value = madetai

                });

               
                lstPara2.Add(new CustomParameter()
                {
                    key = "@malophoc",
                    value = malophoc

                });



            }
            


            var rs = new Database().ExCute(sql, lstPara);
            var ist = new Database().ExCute("InsertDT", lstPara2);
            if (rs == 1&&ist ==1)
            {
                if (string.IsNullOrEmpty(mdt))
                {
                    MessageBox.Show("Add Successfull");
                }
                //this.Dispose();
            }
            else
            {
                MessageBox.Show("Fail");
            }

            LoadDSLop();
            
            pnlThemDT.Visible = false;

        }

         

        private void btnHuy_Click(object sender, EventArgs e)
        {
            pnlThemDT.Visible = false;
        }

        string sql = "XoaDT";
        private void btnDel_Click(object sender, EventArgs e)
        {
            
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@madetai",
                value =mdt

            });
            

            var r = new Database().ExCute(sql,lstPara);

            LoadDSLop();
        }

        private void dgvdsLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mdt = dgvdsLop.Rows[e.RowIndex].Cells["maDetai"].Value.ToString();
                new UpdateDT(mdt).ShowDialog();
                LoadDSLop();



            }
        }
        //private string mtd;
        private void dgvdsLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             mdt = dgvdsLop.Rows[e.RowIndex].Cells["maDetai"].Value.ToString();
           
           
        }
    }
}
    

