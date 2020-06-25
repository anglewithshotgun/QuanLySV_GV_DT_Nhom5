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
    public partial class UpdateDT : Form
    {
        public UpdateDT(string mdt)
        {
            this.mdt = mdt;
            InitializeComponent();
        }

        private void UpdateDT_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mdt))
            {
                this.Text = "Thêm mới đề tài";
            }
            else
            {
                this.Text = "Cập nhật thông tin đề tài";
                var r = new Database().Select("selectDT '" + mdt + "'");
                // MessageBox.Show(r[0].ToString());
                txtmadetai.Text = r["maDetai"].ToString();
                txttendetai.Text = r["tenDetai"].ToString();
               
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string mdt = null;
        private void btnluu_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(txtmadetai.Text)>255)
            {
                errorProvider1.SetError(txtmadetai, "Giới hạn mã đề tài 0-255");
            }
            string sql = "";
            string tendetai = txttendetai.Text;
            string madetai = txtmadetai.Text;
           

         


            //string loaidetai = cbbloaidetai.SelectedItem.ToString();
            List<CustomParameter> lstPara = new List<CustomParameter>();


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

               
            }
            else

            {
                sql = "UpdateDT";
                
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

                


               
            }
            var rs = new Database().ExCute(sql, lstPara);

           
           
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mdt))
                {
                    MessageBox.Show("Add Successfull");
                }
                else
                {
                    MessageBox.Show("Update Successfull");
                }
                //this.Dispose();
            }
            else
            {
                MessageBox.Show("Fail");
            }


            this.Close();
        }
    }
}
