namespace QLSVsw
{
    partial class frmDSDiem
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
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.dgvdsdiem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsdiem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Location = new System.Drawing.Point(415, 26);
            this.txtTukhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(317, 22);
            this.txtTukhoa.TabIndex = 8;
            this.txtTukhoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTukhoa_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Từ Khóa";
            // 
            // picTimKiem
            // 
            this.picTimKiem.Image = global::QLSVsw.Properties.Resources.btnSearch;
            this.picTimKiem.Location = new System.Drawing.Point(753, 26);
            this.picTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(27, 25);
            this.picTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTimKiem.TabIndex = 9;
            this.picTimKiem.TabStop = false;
            this.picTimKiem.Click += new System.EventHandler(this.picTimKiem_Click);
            // 
            // dgvdsdiem
            // 
            this.dgvdsdiem.AllowUserToAddRows = false;
            this.dgvdsdiem.AllowUserToDeleteRows = false;
            this.dgvdsdiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdsdiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdsdiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvdsdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsdiem.Location = new System.Drawing.Point(0, 71);
            this.dgvdsdiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvdsdiem.Name = "dgvdsdiem";
            this.dgvdsdiem.ReadOnly = true;
            this.dgvdsdiem.Size = new System.Drawing.Size(795, 390);
            this.dgvdsdiem.TabIndex = 10;
            // 
            // frmDSDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 462);
            this.Controls.Add(this.dgvdsdiem);
            this.Controls.Add(this.picTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTukhoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDSDiem";
            this.Text = "frmDSDiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDSDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsdiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picTimKiem;
        private System.Windows.Forms.DataGridView dgvdsdiem;
    }
}