﻿using System;
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
    public partial class frThongtinSV : Form
    {
        public frThongtinSV(string msv, string loaitk)
        {

            this.msv = msv;
            this.loaitk = loaitk;
            InitializeComponent();
        }

        private string msv;
        private string loaitk;
        private void button1_Click(object sender, EventArgs e)
        {
            // Goi form cập nhật thông tin
            frmSinhVien fn = new frmSinhVien(msv);


            fn.ShowDialog();



            LoadTTSV();

        }


        private void LoadTTSV()
        {
            var r = new Database().Select("selectSV '" + msv + "'");

           // MessageBox.Show(msv);
            // MessageBox.Show(r[0].ToString());
            lbmsv.Text = r["masinhvien"].ToString();
            lbhoten.Text = r["ho"].ToString() + r["tendem"].ToString() + r["ten"].ToString();
            //txtTendem.Text = ;
            //txtTen.Text = ;
            //mtbNgaysinh.Text = r["ngsinh"].ToString();

            if (int.Parse(r["gioitinh"].ToString()) == 1)
            { lbgioitinh.Text = "Nam"; }
            else { lbgioitinh.Text = "Nữ"; }

            lbquequan.Text = r["quequan"].ToString();
            lbdiachi.Text = r["diachi"].ToString();
            lbsdt.Text = r["dienthoai"].ToString();
            lbemail.Text = r["email"].ToString();



        }

        private void frThongtinSV_Load(object sender, EventArgs e)
        {

            LoadTTSV();

        }

        private int clickpic1 = 0;
        private int clickpic2 = 0;

        private void picseen_Click(object sender, EventArgs e)
        {
            if (clickpic1 == 0)
            { picseen.BackColor = Color.Red; clickpic1 = 1;
                txtmkc.UseSystemPasswordChar = false;

            }
            else { picseen.BackColor = Color.White; clickpic1 = 0;
                txtmkc.UseSystemPasswordChar = true;
            }
        }

        private void picseen2_Click(object sender, EventArgs e)
        {

            if (clickpic2 == 0)
            { picseen2.BackColor = Color.Red; clickpic2 = 1;
                txtmkmoi.UseSystemPasswordChar = false;
            }
            else { picseen.BackColor = Color.White; clickpic2 = 0;
                txtmkmoi.UseSystemPasswordChar = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string loaitaikhoan = loaitk;
            string taikhoan = txttk.Text;
            string matkhaucu = txtmkc.Text;
            string matkhaumoi = txtmkmoi.Text;


            List<CustomParameter> customParameters = new List<CustomParameter>();

            sql = "doimatkhau";
            customParameters.Add(new CustomParameter()
            {
                key="@loaitaikhoan",
                value= loaitaikhoan
            });


            customParameters.Add(new CustomParameter()
            {
                key = "@taikhoan",
                value = taikhoan
            });


            customParameters.Add(new CustomParameter()
            {
                key = "@matkhau",
                value = matkhaucu
            });


            customParameters.Add(new CustomParameter()
            {
                key = "@matkhaumoi",
                value = matkhaumoi
            });


            var rs = new Database().ExCute(sql, customParameters);


            if (rs == 1)
            { MessageBox.Show("Update Successfull"); }
            else { MessageBox.Show("Fail"); }



            pnlDoiMK.Visible = false;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            pnlDoiMK.Visible = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            pnlDoiMK.Visible = false;
        }
    }
}
