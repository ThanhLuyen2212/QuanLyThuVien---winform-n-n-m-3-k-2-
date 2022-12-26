
namespace QuanLyThuVien
{
    partial class ReturnBookForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbIDReader = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.tbNameReader = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbReturnBookClose = new System.Windows.Forms.PictureBox();
            this.dtgvIssueBook = new System.Windows.Forms.DataGridView();
            this.dtgvReturnbook = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpkReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIDPhieuMuon = new System.Windows.Forms.TextBox();
            this.tbIDPhieuTra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChiTietPhieuTra = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReturnBookClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIssueBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReturnbook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SlateBlue;
            this.btnDelete.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(250, 546);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 44);
            this.btnDelete.TabIndex = 84;
            this.btnDelete.Text = "Xóa phiếu trả";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbIDReader
            // 
            this.tbIDReader.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDReader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbIDReader.Location = new System.Drawing.Point(174, 106);
            this.tbIDReader.Multiline = true;
            this.tbIDReader.Name = "tbIDReader";
            this.tbIDReader.ReadOnly = true;
            this.tbIDReader.Size = new System.Drawing.Size(227, 30);
            this.tbIDReader.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 78;
            this.label4.Text = "ID Phiếu mượn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 23);
            this.label8.TabIndex = 77;
            this.label8.Text = "ID Độc giả";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SlateBlue;
            this.btnReturn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(250, 596);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(141, 44);
            this.btnReturn.TabIndex = 72;
            this.btnReturn.Text = "Trở về";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.SlateBlue;
            this.btnReturnBook.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Location = new System.Drawing.Point(103, 546);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(141, 44);
            this.btnReturnBook.TabIndex = 71;
            this.btnReturnBook.Text = "Lập phiếu trả";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // tbNameReader
            // 
            this.tbNameReader.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameReader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbNameReader.Location = new System.Drawing.Point(174, 157);
            this.tbNameReader.Multiline = true;
            this.tbNameReader.Name = "tbNameReader";
            this.tbNameReader.ReadOnly = true;
            this.tbNameReader.Size = new System.Drawing.Size(227, 30);
            this.tbNameReader.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 74;
            this.label2.Text = "Tên độc giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(465, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "PHIẾU TRẢ SÁCH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(348, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(498, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "PHẦN MỀM QUẢN LÝ THƯ VIỆN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.ptbReturnBookClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 150);
            this.panel2.TabIndex = 73;
            // 
            // ptbReturnBookClose
            // 
            this.ptbReturnBookClose.Image = global::QuanLyThuVien.Properties.Resources.cancel;
            this.ptbReturnBookClose.Location = new System.Drawing.Point(1138, 12);
            this.ptbReturnBookClose.Name = "ptbReturnBookClose";
            this.ptbReturnBookClose.Size = new System.Drawing.Size(30, 30);
            this.ptbReturnBookClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbReturnBookClose.TabIndex = 8;
            this.ptbReturnBookClose.TabStop = false;
            this.ptbReturnBookClose.Click += new System.EventHandler(this.ptbReturnBookClose_Click);
            // 
            // dtgvIssueBook
            // 
            this.dtgvIssueBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvIssueBook.Location = new System.Drawing.Point(489, 199);
            this.dtgvIssueBook.Name = "dtgvIssueBook";
            this.dtgvIssueBook.Size = new System.Drawing.Size(659, 208);
            this.dtgvIssueBook.TabIndex = 75;
            this.dtgvIssueBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvIssueBook_CellClick);
            // 
            // dtgvReturnbook
            // 
            this.dtgvReturnbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReturnbook.Location = new System.Drawing.Point(489, 448);
            this.dtgvReturnbook.Name = "dtgvReturnbook";
            this.dtgvReturnbook.Size = new System.Drawing.Size(659, 209);
            this.dtgvReturnbook.TabIndex = 85;
            this.dtgvReturnbook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvReturnbook_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(665, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(258, 29);
            this.label10.TabIndex = 86;
            this.label10.Text = "Danh sách phiếu mượn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(675, 414);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(224, 29);
            this.label11.TabIndex = 87;
            this.label11.Text = "Danh sách phiếu trả";
            // 
            // dtpkReturnDate
            // 
            this.dtpkReturnDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkReturnDate.Location = new System.Drawing.Point(207, 491);
            this.dtpkReturnDate.Name = "dtpkReturnDate";
            this.dtpkReturnDate.Size = new System.Drawing.Size(227, 27);
            this.dtpkReturnDate.TabIndex = 88;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(39, 494);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 23);
            this.label12.TabIndex = 89;
            this.label12.Text = "Ngày lập phiếu trả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbIDPhieuMuon);
            this.groupBox1.Controls.Add(this.tbIDReader);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNameReader);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 230);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu mượn";
            // 
            // tbIDPhieuMuon
            // 
            this.tbIDPhieuMuon.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDPhieuMuon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbIDPhieuMuon.Location = new System.Drawing.Point(174, 52);
            this.tbIDPhieuMuon.Multiline = true;
            this.tbIDPhieuMuon.Name = "tbIDPhieuMuon";
            this.tbIDPhieuMuon.ReadOnly = true;
            this.tbIDPhieuMuon.Size = new System.Drawing.Size(227, 30);
            this.tbIDPhieuMuon.TabIndex = 79;
            // 
            // tbIDPhieuTra
            // 
            this.tbIDPhieuTra.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDPhieuTra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbIDPhieuTra.Location = new System.Drawing.Point(207, 445);
            this.tbIDPhieuTra.Multiline = true;
            this.tbIDPhieuTra.Name = "tbIDPhieuTra";
            this.tbIDPhieuTra.ReadOnly = true;
            this.tbIDPhieuTra.Size = new System.Drawing.Size(227, 30);
            this.tbIDPhieuTra.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(39, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 94;
            this.label5.Text = "ID Phiếu trả";
            // 
            // btnChiTietPhieuTra
            // 
            this.btnChiTietPhieuTra.BackColor = System.Drawing.Color.SlateBlue;
            this.btnChiTietPhieuTra.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietPhieuTra.ForeColor = System.Drawing.Color.White;
            this.btnChiTietPhieuTra.Location = new System.Drawing.Point(103, 596);
            this.btnChiTietPhieuTra.Name = "btnChiTietPhieuTra";
            this.btnChiTietPhieuTra.Size = new System.Drawing.Size(141, 44);
            this.btnChiTietPhieuTra.TabIndex = 96;
            this.btnChiTietPhieuTra.Text = "Chi tiết phiếu trả";
            this.btnChiTietPhieuTra.UseVisualStyleBackColor = false;
            this.btnChiTietPhieuTra.Click += new System.EventHandler(this.btnChiTietPhieuTra_Click);
            // 
            // ReturnBookForm
            // 
            this.AcceptButton = this.btnReturnBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1180, 676);
            this.Controls.Add(this.btnChiTietPhieuTra);
            this.Controls.Add(this.tbIDPhieuTra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpkReturnDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtgvReturnbook);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgvIssueBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBookForm";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReturnBookClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIssueBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReturnbook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbIDReader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.TextBox tbNameReader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvIssueBook;
        private System.Windows.Forms.DataGridView dtgvReturnbook;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpkReturnDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox ptbReturnBookClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIDPhieuMuon;
        private System.Windows.Forms.TextBox tbIDPhieuTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChiTietPhieuTra;
    }
}