
namespace QuanLyThuVien
{
    partial class ChiTietPhieuMuon
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
            this.label8 = new System.Windows.Forms.Label();
            this.tbTenSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIDSach = new System.Windows.Forms.TextBox();
            this.dtgvChitietSach = new System.Windows.Forms.DataGridView();
            this.tbIDPhieuMuon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvTimkiemSach = new System.Windows.Forms.DataGridView();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.tbSearchBook = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuuChiTietPhieuMuon = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChitietSach)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimkiemSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(46, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 23);
            this.label8.TabIndex = 53;
            this.label8.Text = "ID Phiếu mượn";
            // 
            // tbTenSach
            // 
            this.tbTenSach.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbTenSach.Location = new System.Drawing.Point(253, 173);
            this.tbTenSach.Multiline = true;
            this.tbTenSach.Name = "tbTenSach";
            this.tbTenSach.ReadOnly = true;
            this.tbTenSach.Size = new System.Drawing.Size(249, 30);
            this.tbTenSach.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(46, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "Tên sách";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SlateBlue;
            this.btnDelete.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(285, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 44);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Xóa sách";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAdd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(125, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 44);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Thêm sách";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "ID Sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbIDSach);
            this.groupBox1.Controls.Add(this.dtgvChitietSach);
            this.groupBox1.Controls.Add(this.tbIDPhieuMuon);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.tbTenSach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 507);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết phiếu mượn";
            // 
            // tbIDSach
            // 
            this.tbIDSach.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbIDSach.Location = new System.Drawing.Point(253, 114);
            this.tbIDSach.Multiline = true;
            this.tbIDSach.Name = "tbIDSach";
            this.tbIDSach.ReadOnly = true;
            this.tbIDSach.Size = new System.Drawing.Size(249, 30);
            this.tbIDSach.TabIndex = 59;
            // 
            // dtgvChitietSach
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvChitietSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvChitietSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChitietSach.Location = new System.Drawing.Point(8, 310);
            this.dtgvChitietSach.Name = "dtgvChitietSach";
            this.dtgvChitietSach.Size = new System.Drawing.Size(544, 191);
            this.dtgvChitietSach.TabIndex = 58;
            this.dtgvChitietSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChitietSach_CellClick);
            // 
            // tbIDPhieuMuon
            // 
            this.tbIDPhieuMuon.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDPhieuMuon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbIDPhieuMuon.Location = new System.Drawing.Point(253, 58);
            this.tbIDPhieuMuon.Multiline = true;
            this.tbIDPhieuMuon.Name = "tbIDPhieuMuon";
            this.tbIDPhieuMuon.ReadOnly = true;
            this.tbIDPhieuMuon.Size = new System.Drawing.Size(249, 30);
            this.tbIDPhieuMuon.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(398, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chi tiết phiếu mượn";
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
            this.panel1.TabIndex = 58;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvTimkiemSach);
            this.groupBox2.Controls.Add(this.btnSearchBook);
            this.groupBox2.Controls.Add(this.tbSearchBook);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 12F);
            this.groupBox2.Location = new System.Drawing.Point(621, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 385);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm và chọn sách để mượn";
            // 
            // dtgvTimkiemSach
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvTimkiemSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTimkiemSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTimkiemSach.Location = new System.Drawing.Point(6, 185);
            this.dtgvTimkiemSach.Name = "dtgvTimkiemSach";
            this.dtgvTimkiemSach.Size = new System.Drawing.Size(427, 186);
            this.dtgvTimkiemSach.TabIndex = 57;
            this.dtgvTimkiemSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTimkiemSach_CellClick);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSearchBook.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.ForeColor = System.Drawing.Color.White;
            this.btnSearchBook.Location = new System.Drawing.Point(129, 117);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(183, 44);
            this.btnSearchBook.TabIndex = 43;
            this.btnSearchBook.Text = "Tìm kiếm";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // tbSearchBook
            // 
            this.tbSearchBook.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbSearchBook.Location = new System.Drawing.Point(159, 55);
            this.tbSearchBook.Multiline = true;
            this.tbSearchBook.Name = "tbSearchBook";
            this.tbSearchBook.Size = new System.Drawing.Size(231, 30);
            this.tbSearchBook.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(38, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "Tên sách";
            // 
            // btnLuuChiTietPhieuMuon
            // 
            this.btnLuuChiTietPhieuMuon.BackColor = System.Drawing.Color.SlateBlue;
            this.btnLuuChiTietPhieuMuon.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuChiTietPhieuMuon.ForeColor = System.Drawing.Color.White;
            this.btnLuuChiTietPhieuMuon.Location = new System.Drawing.Point(627, 581);
            this.btnLuuChiTietPhieuMuon.Name = "btnLuuChiTietPhieuMuon";
            this.btnLuuChiTietPhieuMuon.Size = new System.Drawing.Size(238, 44);
            this.btnLuuChiTietPhieuMuon.TabIndex = 60;
            this.btnLuuChiTietPhieuMuon.Text = "Lưu phiếu chi tiết phiếu mượn";
            this.btnLuuChiTietPhieuMuon.UseVisualStyleBackColor = false;
            this.btnLuuChiTietPhieuMuon.Click += new System.EventHandler(this.btnLuuChiTietPhieuMuon_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.SlateBlue;
            this.btnTroVe.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.ForeColor = System.Drawing.Color.White;
            this.btnTroVe.Location = new System.Drawing.Point(887, 581);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(154, 44);
            this.btnTroVe.TabIndex = 60;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // ChiTietPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 687);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnLuuChiTietPhieuMuon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietPhieuMuon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChitietSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimkiemSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTenSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIDPhieuMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.TextBox tbSearchBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.DataGridView dtgvChitietSach;
        private System.Windows.Forms.DataGridView dtgvTimkiemSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIDSach;
        private System.Windows.Forms.Button btnLuuChiTietPhieuMuon;
        private System.Windows.Forms.Button btnTroVe;
    }
}