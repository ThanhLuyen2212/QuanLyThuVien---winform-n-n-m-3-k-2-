
namespace QuanLyThuVien
{
    partial class IssueBookForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbCloseIssueBook = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dtgvIssueBook = new System.Windows.Forms.DataGridView();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.tbNameReader = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tbIDIssueBook = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIDReader = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnChiTietPhieuMuon = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCloseIssueBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIssueBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 23);
            this.label7.TabIndex = 50;
            this.label7.Text = "Ngày mượn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.ptbCloseIssueBook);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1102, 149);
            this.panel2.TabIndex = 36;
            // 
            // ptbCloseIssueBook
            // 
            this.ptbCloseIssueBook.Image = global::QuanLyThuVien.Properties.Resources.cancel;
            this.ptbCloseIssueBook.Location = new System.Drawing.Point(1060, 12);
            this.ptbCloseIssueBook.Name = "ptbCloseIssueBook";
            this.ptbCloseIssueBook.Size = new System.Drawing.Size(30, 30);
            this.ptbCloseIssueBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCloseIssueBook.TabIndex = 6;
            this.ptbCloseIssueBook.TabStop = false;
            this.ptbCloseIssueBook.Click += new System.EventHandler(this.ptbCloseIssueBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(403, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "PHIẾU MƯỢN SÁCH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(284, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "PHẦN MỀM QUẢN LÝ THƯ VIỆN";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SlateBlue;
            this.btnReturn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(86, 577);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(282, 44);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Trở về";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dtgvIssueBook
            // 
            this.dtgvIssueBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvIssueBook.Location = new System.Drawing.Point(436, 174);
            this.dtgvIssueBook.Name = "dtgvIssueBook";
            this.dtgvIssueBook.Size = new System.Drawing.Size(634, 447);
            this.dtgvIssueBook.TabIndex = 46;
            this.dtgvIssueBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvIssueBook_CellClick);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.BackColor = System.Drawing.Color.SlateBlue;
            this.btnIssueBook.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBook.ForeColor = System.Drawing.Color.White;
            this.btnIssueBook.Location = new System.Drawing.Point(86, 477);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(143, 44);
            this.btnIssueBook.TabIndex = 2;
            this.btnIssueBook.Text = "Lập phiếu mượn";
            this.btnIssueBook.UseVisualStyleBackColor = false;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // tbNameReader
            // 
            this.tbNameReader.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameReader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbNameReader.Location = new System.Drawing.Point(182, 364);
            this.tbNameReader.Multiline = true;
            this.tbNameReader.Name = "tbNameReader";
            this.tbNameReader.ReadOnly = true;
            this.tbNameReader.Size = new System.Drawing.Size(215, 30);
            this.tbNameReader.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên độc giả";
            // 
            // dtpkNgayMuon
            // 
            this.dtpkNgayMuon.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayMuon.Location = new System.Drawing.Point(182, 421);
            this.dtpkNgayMuon.Name = "dtpkNgayMuon";
            this.dtpkNgayMuon.Size = new System.Drawing.Size(215, 27);
            this.dtpkNgayMuon.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(24, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 23);
            this.label8.TabIndex = 53;
            this.label8.Text = "ID Độc giả";
            // 
            // tbIDIssueBook
            // 
            this.tbIDIssueBook.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDIssueBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbIDIssueBook.Location = new System.Drawing.Point(182, 251);
            this.tbIDIssueBook.Multiline = true;
            this.tbIDIssueBook.Name = "tbIDIssueBook";
            this.tbIDIssueBook.ReadOnly = true;
            this.tbIDIssueBook.Size = new System.Drawing.Size(215, 30);
            this.tbIDIssueBook.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "ID Phiếu mượn";
            // 
            // cbIDReader
            // 
            this.cbIDReader.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIDReader.FormattingEnabled = true;
            this.cbIDReader.Location = new System.Drawing.Point(182, 307);
            this.cbIDReader.Name = "cbIDReader";
            this.cbIDReader.Size = new System.Drawing.Size(215, 27);
            this.cbIDReader.TabIndex = 62;
            this.cbIDReader.SelectionChangeCommitted += new System.EventHandler(this.cbIDReader_SelectionChangeCommitted);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SlateBlue;
            this.btnDelete.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(235, 477);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEdit.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(86, 527);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 44);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnChiTietPhieuMuon
            // 
            this.btnChiTietPhieuMuon.BackColor = System.Drawing.Color.SlateBlue;
            this.btnChiTietPhieuMuon.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietPhieuMuon.ForeColor = System.Drawing.Color.White;
            this.btnChiTietPhieuMuon.Location = new System.Drawing.Point(200, 527);
            this.btnChiTietPhieuMuon.Name = "btnChiTietPhieuMuon";
            this.btnChiTietPhieuMuon.Size = new System.Drawing.Size(168, 44);
            this.btnChiTietPhieuMuon.TabIndex = 68;
            this.btnChiTietPhieuMuon.Text = "Chi tiết phiếu mượn";
            this.btnChiTietPhieuMuon.UseVisualStyleBackColor = false;
            this.btnChiTietPhieuMuon.Click += new System.EventHandler(this.btnChiTietPhieuMuon_Click);
            // 
            // IssueBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 656);
            this.Controls.Add(this.btnChiTietPhieuMuon);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbIDReader);
            this.Controls.Add(this.tbIDIssueBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpkNgayMuon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dtgvIssueBook);
            this.Controls.Add(this.btnIssueBook);
            this.Controls.Add(this.tbNameReader);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBookForm";
            this.Load += new System.EventHandler(this.IssueBookForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCloseIssueBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIssueBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dtgvIssueBook;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.TextBox tbNameReader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkNgayMuon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbIDIssueBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbIDReader;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox ptbCloseIssueBook;
        private System.Windows.Forms.Button btnChiTietPhieuMuon;
    }
}