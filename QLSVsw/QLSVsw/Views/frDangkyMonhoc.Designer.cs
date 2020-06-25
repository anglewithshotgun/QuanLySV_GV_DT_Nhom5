namespace QLSVsw
{
    partial class frDangkyMonhoc
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
            this.dgvDSDT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSDT
            // 
            this.dgvDSDT.AllowUserToAddRows = false;
            this.dgvDSDT.AllowUserToDeleteRows = false;
            this.dgvDSDT.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDT.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDSDT.Location = new System.Drawing.Point(0, 0);
            this.dgvDSDT.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSDT.Name = "dgvDSDT";
            this.dgvDSDT.ReadOnly = true;
            this.dgvDSDT.Size = new System.Drawing.Size(456, 465);
            this.dgvDSDT.TabIndex = 0;
            this.dgvDSDT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDT_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ khóa";
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Location = new System.Drawing.Point(547, 16);
            this.txtTukhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(284, 22);
            this.txtTukhoa.TabIndex = 2;
            this.txtTukhoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // picTimKiem
            // 
            this.picTimKiem.Image = global::QLSVsw.Properties.Resources.btnSearch;
            this.picTimKiem.Location = new System.Drawing.Point(840, 17);
            this.picTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(27, 25);
            this.picTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTimKiem.TabIndex = 6;
            this.picTimKiem.TabStop = false;
            this.picTimKiem.Click += new System.EventHandler(this.picTimKiem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::QLSVsw.Properties.Resources.quit_256;
            this.pictureBox2.Location = new System.Drawing.Point(958, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frDangkyMonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 465);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picTimKiem);
            this.Controls.Add(this.txtTukhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSDT);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frDangkyMonhoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frDangkyMonhoc";
            this.Load += new System.EventHandler(this.frDangkyMonhoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.PictureBox picTimKiem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}