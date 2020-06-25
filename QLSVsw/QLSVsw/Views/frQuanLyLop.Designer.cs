namespace QLSVsw
{
    partial class frQuanLyLop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvdsLop = new System.Windows.Forms.DataGridView();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.pnlThemDT = new System.Windows.Forms.Panel();
            this.txtmalophoc = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cbbloaidetai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttendetai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmadetai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.pnlThemDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdsLop
            // 
            this.dgvdsLop.AllowUserToAddRows = false;
            this.dgvdsLop.AllowUserToDeleteRows = false;
            this.dgvdsLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdsLop.BackgroundColor = System.Drawing.Color.White;
            this.dgvdsLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsLop.Location = new System.Drawing.Point(0, 60);
            this.dgvdsLop.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdsLop.Name = "dgvdsLop";
            this.dgvdsLop.ReadOnly = true;
            this.dgvdsLop.Size = new System.Drawing.Size(1180, 510);
            this.dgvdsLop.TabIndex = 14;
            this.dgvdsLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdsLop_CellClick);
            this.dgvdsLop.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdsLop_CellDoubleClick);
            // 
            // picTimKiem
            // 
            this.picTimKiem.Image = global::QLSVsw.Properties.Resources.btnSearch;
            this.picTimKiem.Location = new System.Drawing.Point(704, 16);
            this.picTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(27, 25);
            this.picTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTimKiem.TabIndex = 13;
            this.picTimKiem.TabStop = false;
            this.picTimKiem.Click += new System.EventHandler(this.picTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Từ Khóa";
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Location = new System.Drawing.Point(365, 16);
            this.txtTukhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(317, 22);
            this.txtTukhoa.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QLSVsw.Properties.Resources.picAdd;
            this.btnAdd.Location = new System.Drawing.Point(739, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(27, 25);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdd.TabIndex = 15;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlThemDT
            // 
            this.pnlThemDT.BackColor = System.Drawing.Color.White;
            this.pnlThemDT.Controls.Add(this.label6);
            this.pnlThemDT.Controls.Add(this.pictureBox1);
            this.pnlThemDT.Controls.Add(this.txtmalophoc);
            this.pnlThemDT.Controls.Add(this.btnHuy);
            this.pnlThemDT.Controls.Add(this.btnLuu);
            this.pnlThemDT.Controls.Add(this.cbbloaidetai);
            this.pnlThemDT.Controls.Add(this.label5);
            this.pnlThemDT.Controls.Add(this.txttendetai);
            this.pnlThemDT.Controls.Add(this.label4);
            this.pnlThemDT.Controls.Add(this.txtmadetai);
            this.pnlThemDT.Controls.Add(this.label3);
            this.pnlThemDT.Controls.Add(this.label2);
            this.pnlThemDT.Location = new System.Drawing.Point(418, 164);
            this.pnlThemDT.Name = "pnlThemDT";
            this.pnlThemDT.Size = new System.Drawing.Size(339, 264);
            this.pnlThemDT.TabIndex = 16;
            this.pnlThemDT.Visible = false;
            // 
            // txtmalophoc
            // 
            this.txtmalophoc.Location = new System.Drawing.Point(141, 62);
            this.txtmalophoc.Name = "txtmalophoc";
            this.txtmalophoc.Size = new System.Drawing.Size(163, 22);
            this.txtmalophoc.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Location = new System.Drawing.Point(197, 219);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 30);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Location = new System.Drawing.Point(63, 219);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbbloaidetai
            // 
            this.cbbloaidetai.FormattingEnabled = true;
            this.cbbloaidetai.Items.AddRange(new object[] {
            "Đồ án môn học",
            "Đồ án tốt nghiệp",
            "TIểu luận chuyên ngành"});
            this.cbbloaidetai.Location = new System.Drawing.Point(140, 167);
            this.cbbloaidetai.Name = "cbbloaidetai";
            this.cbbloaidetai.Size = new System.Drawing.Size(163, 24);
            this.cbbloaidetai.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Loại đề tài";
            // 
            // txttendetai
            // 
            this.txttendetai.Location = new System.Drawing.Point(140, 132);
            this.txttendetai.Name = "txttendetai";
            this.txttendetai.Size = new System.Drawing.Size(163, 22);
            this.txttendetai.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên đề tài";
            // 
            // txtmadetai
            // 
            this.txtmadetai.Location = new System.Drawing.Point(140, 94);
            this.txtmadetai.Name = "txtmadetai";
            this.txtmadetai.Size = new System.Drawing.Size(163, 22);
            this.txtmadetai.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã đề tài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp";
            // 
            // btnDel
            // 
            this.btnDel.Image = global::QLSVsw.Properties.Resources.pic_Del;
            this.btnDel.Location = new System.Drawing.Point(774, 16);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(27, 25);
            this.btnDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDel.TabIndex = 17;
            this.btnDel.TabStop = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSVsw.Properties.Resources.picAdd;
            this.pictureBox1.Location = new System.Drawing.Point(60, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Đăng kí Đề tài";
            // 
            // frQuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 570);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.pnlThemDT);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvdsLop);
            this.Controls.Add(this.picTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTukhoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frQuanLyLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frQuanLyLop";
            this.Load += new System.EventHandler(this.frQuanLyLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.pnlThemDT.ResumeLayout(false);
            this.pnlThemDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdsLop;
        private System.Windows.Forms.PictureBox picTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.Panel pnlThemDT;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cbbloaidetai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttendetai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmadetai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmalophoc;
        private System.Windows.Forms.PictureBox btnDel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}