namespace QLSVsw
{
    partial class frDSGV
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.dgvDSGV = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.btnTimkiem = new System.Windows.Forms.PictureBox();
            this.btnDel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimkiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(655, 55);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(243, 30);
            this.txtTimkiem.TabIndex = 1;
            // 
            // dgvDSGV
            // 
            this.dgvDSGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSGV.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGV.Location = new System.Drawing.Point(0, 137);
            this.dgvDSGV.MultiSelect = false;
            this.dgvDSGV.Name = "dgvDSGV";
            this.dgvDSGV.RowTemplate.Height = 24;
            this.dgvDSGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSGV.Size = new System.Drawing.Size(1028, 484);
            this.dgvDSGV.TabIndex = 6;
            this.dgvDSGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGV_CellClick);
            this.dgvDSGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGV_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QLSVsw.Properties.Resources.picAdd;
            this.btnAdd.Location = new System.Drawing.Point(952, 55);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdd.TabIndex = 5;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.Lime;
            this.btnTimkiem.Image = global::QLSVsw.Properties.Resources.btnSearch;
            this.btnTimkiem.Location = new System.Drawing.Point(919, 55);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(25, 25);
            this.btnTimkiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.TabStop = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::QLSVsw.Properties.Resources.pic_Del;
            this.btnDel.Location = new System.Drawing.Point(985, 55);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(25, 25);
            this.btnDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDel.TabIndex = 7;
            this.btnDel.TabStop = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // frDSGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 621);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dgvDSGV);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frDSGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách giáo viên";
            this.Load += new System.EventHandler(this.frDSGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimkiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.PictureBox btnTimkiem;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.DataGridView dgvDSGV;
        private System.Windows.Forms.PictureBox btnDel;
    }
}