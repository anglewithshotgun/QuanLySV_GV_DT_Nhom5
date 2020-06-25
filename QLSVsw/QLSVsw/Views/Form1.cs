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
    public partial class Form1 : Form
    {
        public Form1(string tk, string ltk)
        {
            InitializeComponent();
            this.taikhoan = tk;
            this.loaitk = ltk;
           
        }
        private string taikhoan;
        private string loaitk;
        public void AddForm(Form f)
        {

          
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(f);
            
            f.Show();

            f.BringToFront();

            //this.Dispose();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //MessageBox.Show(loaitk);

            //frmDSSV f = new frmDSSV();
            //AddForm(f);

            //var fn = new frmDangnhap();
            

            //fn.ShowDialog();

            //var tk = fn.Tendangnhap;
          //  MessageBox.Show("Tai khoan da dang nhap la: " + tk);
            var db = new Database();
            // dgvData.DataSource = db.SelectData(null);

            //taikhoan = fn.Tendangnhap;
            //loaitk = fn.LoaiTK;
           // MessageBox.Show(loaitk);
            if (loaitk.Equals("SV"))
            {
                //Neu la sinh vien
                btnThongtinSV.Visible = true;
                btnDetai.Visible = true;
                btnDiem.Visible = true;
                picsinhvien.Visible = true;
                picDiem.Visible = true;
                picDEtai.Visible = true;
                //MessageBox.Show("SV");
                //menustripDangkyMonhoc.Visible = true;
            }


            else if (loaitk.Equals("admin"))
            {

                //MessageBox.Show("Admin");


                // Neu la admin
                //menustripDangkyMonhoc.Visible = false;
                menuStripDangkymonhoc.Visible = false;
                btnSinhvien.Visible = true;
                btnGiaovien.Visible = true;
                picGV.Visible = true;
                picSV.Visible = true;
                //MessageBox.Show(btnGiaovien.Visible.ToString());
                btnThongtinGV.Visible = false;


                btnThoat.Location = new Point(93, 150);
                pictureBox1.Location = new Point(50, 150);




            }
            else if (loaitk.Equals("GV"))
            {

                //MessageBox.Show("GV");
                //Neu la giao vien
                picGV.Visible = true;
                picDiem.Visible = true;
                picLop.Visible = true;
                picSV.Visible = true;
                btnThongtinGV.Visible = true;
                btnDiem.Visible = true;
                btbQuanlylop.Visible = true;
                btnSinhvien.Visible = true;
                menuStripDangkymonhoc.Visible = false;
                btnDiem.Visible = false;
                picDiem.Visible = false;
                btnThoat.Location= new Point(93,202);
                pictureBox1.Location = new Point(50, 202);

                //menustripDangkyMonhoc.Visible = false;

            }

            //else MessageBox.Show("Error");

        }

       

       
        

       
       


        private void menuStripDangkymoi_Click(object sender, EventArgs e)
        {
            frDangkyMonhoc fr = new frDangkyMonhoc(taikhoan);
            fr.Show();
        }

        
          

       

        private void button1_Click(object sender, EventArgs e)
        {
            frThongtinSV f = new frThongtinSV(taikhoan, loaitk);
            AddForm(f);
        }

        private void btnThongtinGV_Click(object sender, EventArgs e)
        {
        //    this.splitContainer1.Panel2.Dispose();
            frThongtinGV fr = new frThongtinGV(taikhoan, loaitk);
            AddForm(fr);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            frmDangnhap fr = new frmDangnhap();
            fr.Show();
            this.Close();
        }

        private void menuStripDanhsachdadangky_Click(object sender, EventArgs e)
        {
            frDsmonhocDaDangky fr = new frDsmonhocDaDangky(taikhoan);
            fr.Show();
        }

        private void btnSinhvien_Click(object sender, EventArgs e)
        {
            frmDSSV f = new frmDSSV();
            AddForm(f);
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            frmDSDiem f = new frmDSDiem(taikhoan);
            AddForm(f);
        }

        private void traCứuĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSDiem f = new frmDSDiem(taikhoan);
            f.Show();
        }

        private void btnDetai_Click(object sender, EventArgs e)
        {
            frDsmonhocDaDangky fr = new frDsmonhocDaDangky(taikhoan);
            AddForm(fr);
        }

        private void btbQuanlylop_Click(object sender, EventArgs e)
        {
            frQuanLyLop f = new frQuanLyLop(taikhoan);
            AddForm(f);
        }

        private void btnGiaovien_Click(object sender, EventArgs e)
        {
            frDSGV f = new frDSGV();
            AddForm(f);
        }
    }
}
