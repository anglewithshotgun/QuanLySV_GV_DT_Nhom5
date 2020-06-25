using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSVsw
{
    public partial class frDsmonhocDaDangky : Form
    {
        private string masv;
      //  private string tukhoa = "";
        public frDsmonhocDaDangky(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }

       


        private void frDsmonhocDaDangky_Load(object sender, EventArgs e)
        {
            LoadDetaidk();
            dgvDsMhDdk.Columns["maDetai"].HeaderText = "Mã đề tài";
        //    dgvDsMhDdk.Columns["loaiDetai"].HeaderText = "Loại đề tài";
            dgvDsMhDdk.Columns["tenDetai"].HeaderText = "Tên đề tài";
            dgvDsMhDdk.Columns["gvien"].HeaderText = "Giáo viên phụ trách";
        }

        private void LoadDetaidk()
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
            });
            dgvDsMhDdk.DataSource = new Database().SelectData("detaidadky", lst);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frDangkyMonhoc fr = new frDangkyMonhoc(masv);
            fr.Show();
        }

        private void picTimKiem_Click(object sender, EventArgs e)
        {
            LoadDetaidk();
        }

        private void txtTukhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoadDetaidk();
            }
        }

        private void update_ProBar()
        {
            prbTientrinh.Value = progressbar * 25;
        }
        private int progressbar = 0;

        private void dgvDsMhDdk_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            panel1.Visible = true;
            progressbar = 0;
         
            var mdt = dgvDsMhDdk.Rows[e.RowIndex].Cells["maDetai"].Value.ToString();
            
            var r = new Database().Select("selectDetai '"+masv+"','"+mdt+"'");

            lblMaDetai.Text = r["maDetai"].ToString();
            lblTenDetai.Text = r["tenDetai"].ToString();
            lblLoaidetai.Text = r["loaiDetai"].ToString();
            lblGVHD.Text = r["gvien"].ToString();
            string part1 = r["part1"].ToString();
            string part2= r["part2"].ToString();
            string part3= r["part3"].ToString();
            string part4= r["part4"].ToString();
            
            if (part1 == "1")
            { chbpart1.Checked = true; progressbar++; }
            else chbpart1.Checked = false;

            if (part2 == "1")
            { chbpart2.Checked = true; progressbar++; }
            else chbpart2.Checked = false;

            if (part3 == "1")
            { chbpart3.Checked = true; progressbar++; }
            else chbpart3.Checked = false;

            if (part4 == "1")
            { chbpart4.Checked = true; progressbar++; }
            else chbpart4.Checked = false;

            update_ProBar();

            lblDiem.Text = r["diemDetai"].ToString();


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mdt = lblMaDetai.Text;
            string tdt = lblTenDetai.Text;
            string ldt = lblLoaidetai.Text;
            string gvhd = lblGVHD.Text;

            string part1 = ""; string part2 = ""; string part3 = ""; string part4 = "";
            if (chbpart2.Checked) part2 = "1";
            if (chbpart1.Checked) part1 = "1";
            if (chbpart3.Checked) part3 = "1";
            if (chbpart4.Checked) part4 = "1";


            string ttt = prbTientrinh.Value.ToString();
            string ddt = lblDiem.Text;


            List<CustomParameter> lst = new List<CustomParameter>();

            lst.Add(new CustomParameter()
            {
                key = "@madetai",
                value = mdt
            });
            lst.Add(new CustomParameter()
            {
                key = "@part1",
                value = part1
            });
            lst.Add(new CustomParameter()
            {
                key = "@part2",
                value = part2
            });
            lst.Add(new CustomParameter()
            {
                key = "@part3",
                value = part3
            });
            lst.Add(new CustomParameter()
            {
                key = "@part4",
                value = part4
            });


            string sql = "updatethongtindetai";

            var rs = new Database().ExCute(sql, lst);


            if (rs == 1)
            { MessageBox.Show("Update Successfull"); }
            else { MessageBox.Show("Fail"); }


            LoadDetaidk();
            panel1.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadDetaidk();
        }
    }
}
