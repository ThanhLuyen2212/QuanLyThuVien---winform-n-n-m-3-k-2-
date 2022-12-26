
namespace QuanLyThuVien
{
    partial class ChiTietPhieuTra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.dtgvSachDaDuocMuon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.btnLuuChiTietPhieuMuon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIDSach = new System.Windows.Forms.TextBox();
            this.dtgvChitietPhieuTra = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpkNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIDPhieuMuon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIDPhieuTra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTenSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachDaDuocMuon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChitietPhieuTra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.SlateBlue;
            this.btnTroVe.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.ForeColor = System.Drawing.Color.White;
            this.btnTroVe.Location = new System.Drawing.Point(865, 625);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(183, 44);
            this.btnTroVe.TabIndex = 64;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dtgvSachDaDuocMuon
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvSachDaDuocMuon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvSachDaDuocMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSachDaDuocMuon.Location = new System.Drawing.Point(6, 26);
            this.dtgvSachDaDuocMuon.Name = "dtgvSachDaDuocMuon";
            this.dtgvSachDaDuocMuon.Size = new System.Drawing.Size(427, 343);
            this.dtgvSachDaDuocMuon.TabIndex = 57;
            this.dtgvSachDaDuocMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSachDaDuocMuon_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvSachDaDuocMuon);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 12F);
            this.groupBox2.Location = new System.Drawing.Point(621, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 375);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các cuốn sách đã được mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(316, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "PHẦN MỀM QUẢN LÝ THƯ VIỆN";
            // 
            // ptbClose
            // 
            this.ptbClose.Image = global::QuanLyThuVien.Properties.Resources.cancel;
            this.ptbClose.Location = new System.Drawing.Point(1047, 12);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(30, 30);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClose.TabIndex = 8;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            // 
            // btnLuuChiTietPhieuMuon
            // 
            this.btnLuuChiTietPhieuMuon.BackColor = System.Drawing.Color.SlateBlue;
            this.btnLuuChiTietPhieuMuon.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuChiTietPhieuMuon.ForeColor = System.Drawing.Color.White;
            this.btnLuuChiTietPhieuMuon.Location = new System.Drawing.Point(621, 625);
            this.btnLuuChiTietPhieuMuon.Name = "btnLuuChiTietPhieuMuon";
            this.btnLuuChiTietPhieuMuon.Size = new System.Drawing.Size(238, 44);
            this.btnLuuChiTietPhieuMuon.TabIndex = 65;
            this.btnLuuChiTietPhieuMuon.Text = "Lưu phiếu chi tiết phiếu trả";
            this.btnLuuChiTietPhieuMuon.UseVisualStyleBackColor = false;
            this.btnLuuChiTietPhieuMuon.Click += new System.EventHandler(this.btnLuuChiTietPhieuMuon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ptbClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 128);
            this.panel1.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(436, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chi tiết phiếu trả";
            // 
            // tbIDSach
            // 
            this.tbIDSach.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbIDSach.Location = new System.Drawing.Point(225, 136);
            this.tbIDSach.Multiline = true;
            this.tbIDSach.Name = "tbIDSach";
            this.tbIDSach.ReadOnly = true;
            this.tbIDSach.Size = new System.Drawing.Size(277, 30);
            this.tbIDSach.TabIndex = 59;
            // 
            // dtgvChitietPhieuTra
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvChitietPhieuTra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvChitietPhieuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChitietPhieuTra.Location = new System.Drawing.Point(6, 294);
            this.dtgvChitietPhieuTra.Name = "dtgvChitietPhieuTra";
            this.dtgvChitietPhieuTra.Size = new System.Drawing.Size(544, 207);
            this.dtgvChitietPhieuTra.TabIndex = 58;
            this.dtgvChitietPhieuTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChitietPhieuTra_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpkNgayTra);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbIDPhieuMuon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbIDSach);
            this.groupBox1.Controls.Add(this.dtgvChitietPhieuTra);
            this.groupBox1.Controls.Add(this.tbIDPhieuTra);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTenSach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 507);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết phiếu mượn";
            // 
            // dtpkNgayTra
            // 
            this.dtpkNgayTra.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayTra.Location = new System.Drawing.Point(225, 238);
            this.dtpkNgayTra.Name = "dtpkNgayTra";
            this.dtpkNgayTra.Size = new System.Drawing.Size(277, 27);
            this.dtpkNgayTra.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(46, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 63;
            this.label7.Text = "Ngày trả";
            // 
            // tbIDPhieuMuon
            // 
            this.tbIDPhieuMuon.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDPhieuMuon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbIDPhieuMuon.Location = new System.Drawing.Point(225, 87);
            this.tbIDPhieuMuon.Multiline = true;
            this.tbIDPhieuMuon.Name = "tbIDPhieuMuon";
            this.tbIDPhieuMuon.ReadOnly = true;
            this.tbIDPhieuMuon.Size = new System.Drawing.Size(277, 30);
            this.tbIDPhieuMuon.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 60;
            this.label4.Text = "ID Phiếu mượn";
            // 
            // tbIDPhieuTra
            // 
            this.tbIDPhieuTra.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDPhieuTra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbIDPhieuTra.Location = new System.Drawing.Point(225, 35);
            this.tbIDPhieuTra.Multiline = true;
            this.tbIDPhieuTra.Name = "tbIDPhieuTra";
            this.tbIDPhieuTra.ReadOnly = true;
            this.tbIDPhieuTra.Size = new System.Drawing.Size(277, 30);
            this.tbIDPhieuTra.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(46, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 53;
            this.label8.Text = "ID Phiếu trả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "ID Sách";
            // 
            // tbTenSach
            // 
            this.tbTenSach.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbTenSach.Location = new System.Drawing.Point(225, 184);
            this.tbTenSach.Multiline = true;
            this.tbTenSach.Name = "tbTenSach";
            this.tbTenSach.ReadOnly = true;
            this.tbTenSach.Size = new System.Drawing.Size(277, 30);
            this.tbTenSach.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(46, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "Tên sách";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAdd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(621, 575);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(238, 44);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Trả sách";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SlateBlue;
            this.btnDelete.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(865, 575);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 44);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Xóa sách";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ChiTietPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 698);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLuuChiTietPhieuMuon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietPhieuTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietPhieuTra";
            this.Load += new System.EventHandler(this.ChiTietPhieuTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachDaDuocMuon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChitietPhieuTra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridView dtgvSachDaDuocMuon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.Button btnLuuChiTietPhieuMuon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIDSach;
        private System.Windows.Forms.DataGridView dtgvChitietPhieuTra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIDPhieuMuon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIDPhieuTra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbTenSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpkNgayTra;
        private System.Windows.Forms.Label label7;
    }
}