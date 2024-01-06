namespace bt32
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Thongtin = new System.Windows.Forms.GroupBox();
            this.DinhDang = new System.Windows.Forms.GroupBox();
            this.rdb3D = new System.Windows.Forms.RadioButton();
            this.rdb2D = new System.Windows.Forms.RadioButton();
            this.TheLoai = new System.Windows.Forms.GroupBox();
            this.rdbAction = new System.Windows.Forms.RadioButton();
            this.rdbRomance = new System.Windows.Forms.RadioButton();
            this.txbPhuThi = new System.Windows.Forms.TextBox();
            this.txbTuoi = new System.Windows.Forms.TextBox();
            this.NgayCongChieu = new System.Windows.Forms.DateTimePicker();
            this.txbQuocGia = new System.Windows.Forms.TextBox();
            this.txbTenPhim = new System.Windows.Forms.TextBox();
            this.txbMaDon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TacVu = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.DSPhim = new System.Windows.Forms.GroupBox();
            this.lwCinema = new System.Windows.Forms.ListView();
            this.Thongtin.SuspendLayout();
            this.DinhDang.SuspendLayout();
            this.TheLoai.SuspendLayout();
            this.TacVu.SuspendLayout();
            this.DSPhim.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(966, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ DOANH THU PHIM CHIẾU RẠP";
            // 
            // Thongtin
            // 
            this.Thongtin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Thongtin.Controls.Add(this.DinhDang);
            this.Thongtin.Controls.Add(this.TheLoai);
            this.Thongtin.Controls.Add(this.txbPhuThi);
            this.Thongtin.Controls.Add(this.txbTuoi);
            this.Thongtin.Controls.Add(this.NgayCongChieu);
            this.Thongtin.Controls.Add(this.txbQuocGia);
            this.Thongtin.Controls.Add(this.txbTenPhim);
            this.Thongtin.Controls.Add(this.txbMaDon);
            this.Thongtin.Controls.Add(this.label10);
            this.Thongtin.Controls.Add(this.label9);
            this.Thongtin.Controls.Add(this.label8);
            this.Thongtin.Controls.Add(this.label7);
            this.Thongtin.Controls.Add(this.label6);
            this.Thongtin.Controls.Add(this.label5);
            this.Thongtin.Controls.Add(this.label4);
            this.Thongtin.Controls.Add(this.label3);
            this.Thongtin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Thongtin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Thongtin.ForeColor = System.Drawing.Color.Black;
            this.Thongtin.Location = new System.Drawing.Point(18, 61);
            this.Thongtin.Name = "Thongtin";
            this.Thongtin.Size = new System.Drawing.Size(583, 513);
            this.Thongtin.TabIndex = 4;
            this.Thongtin.TabStop = false;
            this.Thongtin.Text = "Thông tin phim";
            // 
            // DinhDang
            // 
            this.DinhDang.Controls.Add(this.rdb3D);
            this.DinhDang.Controls.Add(this.rdb2D);
            this.DinhDang.Location = new System.Drawing.Point(206, 355);
            this.DinhDang.Name = "DinhDang";
            this.DinhDang.Size = new System.Drawing.Size(283, 46);
            this.DinhDang.TabIndex = 7;
            this.DinhDang.TabStop = false;
            // 
            // rdb3D
            // 
            this.rdb3D.AutoSize = true;
            this.rdb3D.Location = new System.Drawing.Point(190, 15);
            this.rdb3D.Name = "rdb3D";
            this.rdb3D.Size = new System.Drawing.Size(60, 29);
            this.rdb3D.TabIndex = 39;
            this.rdb3D.TabStop = true;
            this.rdb3D.Text = "3D";
            this.rdb3D.UseVisualStyleBackColor = true;
            // 
            // rdb2D
            // 
            this.rdb2D.AutoSize = true;
            this.rdb2D.Location = new System.Drawing.Point(31, 15);
            this.rdb2D.Name = "rdb2D";
            this.rdb2D.Size = new System.Drawing.Size(60, 29);
            this.rdb2D.TabIndex = 38;
            this.rdb2D.TabStop = true;
            this.rdb2D.Text = "2D";
            this.rdb2D.UseVisualStyleBackColor = true;
            // 
            // TheLoai
            // 
            this.TheLoai.Controls.Add(this.rdbAction);
            this.TheLoai.Controls.Add(this.rdbRomance);
            this.TheLoai.Location = new System.Drawing.Point(190, 198);
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.Size = new System.Drawing.Size(299, 51);
            this.TheLoai.TabIndex = 4;
            this.TheLoai.TabStop = false;
            // 
            // rdbAction
            // 
            this.rdbAction.AutoSize = true;
            this.rdbAction.Location = new System.Drawing.Point(162, 16);
            this.rdbAction.Name = "rdbAction";
            this.rdbAction.Size = new System.Drawing.Size(129, 29);
            this.rdbAction.TabIndex = 4;
            this.rdbAction.TabStop = true;
            this.rdbAction.Text = "Hành Động";
            this.rdbAction.UseVisualStyleBackColor = true;
            // 
            // rdbRomance
            // 
            this.rdbRomance.AutoSize = true;
            this.rdbRomance.Location = new System.Drawing.Point(16, 16);
            this.rdbRomance.Name = "rdbRomance";
            this.rdbRomance.Size = new System.Drawing.Size(111, 29);
            this.rdbRomance.TabIndex = 3;
            this.rdbRomance.TabStop = true;
            this.rdbRomance.Text = "Tình Cảm";
            this.rdbRomance.UseVisualStyleBackColor = true;
            // 
            // txbPhuThi
            // 
            this.txbPhuThi.Location = new System.Drawing.Point(299, 422);
            this.txbPhuThi.Name = "txbPhuThi";
            this.txbPhuThi.Size = new System.Drawing.Size(221, 31);
            this.txbPhuThi.TabIndex = 8;
            // 
            // txbTuoi
            // 
            this.txbTuoi.Location = new System.Drawing.Point(222, 313);
            this.txbTuoi.Name = "txbTuoi";
            this.txbTuoi.Size = new System.Drawing.Size(298, 31);
            this.txbTuoi.TabIndex = 6;
            // 
            // NgayCongChieu
            // 
            this.NgayCongChieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayCongChieu.Location = new System.Drawing.Point(220, 257);
            this.NgayCongChieu.Name = "NgayCongChieu";
            this.NgayCongChieu.Size = new System.Drawing.Size(300, 31);
            this.NgayCongChieu.TabIndex = 5;
            // 
            // txbQuocGia
            // 
            this.txbQuocGia.Location = new System.Drawing.Point(158, 161);
            this.txbQuocGia.Name = "txbQuocGia";
            this.txbQuocGia.Size = new System.Drawing.Size(362, 31);
            this.txbQuocGia.TabIndex = 3;
            // 
            // txbTenPhim
            // 
            this.txbTenPhim.Location = new System.Drawing.Point(158, 107);
            this.txbTenPhim.Name = "txbTenPhim";
            this.txbTenPhim.Size = new System.Drawing.Size(362, 31);
            this.txbTenPhim.TabIndex = 2;
            // 
            // txbMaDon
            // 
            this.txbMaDon.Location = new System.Drawing.Point(158, 57);
            this.txbMaDon.Name = "txbMaDon";
            this.txbMaDon.Size = new System.Drawing.Size(362, 31);
            this.txbMaDon.TabIndex = 1;
            this.txbMaDon.TextChanged += new System.EventHandler(this.txbMaDon_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Phụ thu suất chiếu đặc biệt: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Định dạng: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Độ Tuổi Qui Định: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tên Phim: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Quốc gia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Thể Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ngày Công Chiếu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã Đơn:";
            // 
            // TacVu
            // 
            this.TacVu.Controls.Add(this.btnThongKe);
            this.TacVu.Controls.Add(this.btnSapXep);
            this.TacVu.Controls.Add(this.btnSua);
            this.TacVu.Controls.Add(this.btnXoa);
            this.TacVu.Controls.Add(this.btnLuu);
            this.TacVu.Controls.Add(this.btnThem);
            this.TacVu.Location = new System.Drawing.Point(18, 580);
            this.TacVu.Name = "TacVu";
            this.TacVu.Size = new System.Drawing.Size(1263, 117);
            this.TacVu.TabIndex = 5;
            this.TacVu.TabStop = false;
            this.TacVu.Text = "Tác vụ";
            // 
            // btnThongKe
            // 
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Location = new System.Drawing.Point(1096, 50);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(112, 34);
            this.btnThongKe.TabIndex = 14;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.ForeColor = System.Drawing.Color.Black;
            this.btnSapXep.Location = new System.Drawing.Point(902, 50);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(112, 34);
            this.btnSapXep.TabIndex = 13;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(690, 50);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 34);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(471, 50);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location = new System.Drawing.Point(260, 50);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 34);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(64, 50);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DSPhim
            // 
            this.DSPhim.Controls.Add(this.lwCinema);
            this.DSPhim.Location = new System.Drawing.Point(607, 61);
            this.DSPhim.Name = "DSPhim";
            this.DSPhim.Size = new System.Drawing.Size(698, 513);
            this.DSPhim.TabIndex = 7;
            this.DSPhim.TabStop = false;
            this.DSPhim.Text = "Danh sách phim";
            // 
            // lwCinema
            // 
            this.lwCinema.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lwCinema.FullRowSelect = true;
            this.lwCinema.GridLines = true;
            this.lwCinema.Location = new System.Drawing.Point(6, 30);
            this.lwCinema.Name = "lwCinema";
            this.lwCinema.Size = new System.Drawing.Size(686, 471);
            this.lwCinema.TabIndex = 7;
            this.lwCinema.UseCompatibleStateImageBehavior = false;
            this.lwCinema.View = System.Windows.Forms.View.Details;
            this.lwCinema.SelectedIndexChanged += new System.EventHandler(this.lwCinema_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1317, 725);
            this.Controls.Add(this.DSPhim);
            this.Controls.Add(this.TacVu);
            this.Controls.Add(this.Thongtin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "6251071092 - Trần Xuân Thao";
            this.Thongtin.ResumeLayout(false);
            this.Thongtin.PerformLayout();
            this.DinhDang.ResumeLayout(false);
            this.DinhDang.PerformLayout();
            this.TheLoai.ResumeLayout(false);
            this.TheLoai.PerformLayout();
            this.TacVu.ResumeLayout(false);
            this.DSPhim.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox Thongtin;
        private TextBox txbPhuThi;
        private TextBox txbTuoi;
        private DateTimePicker NgayCongChieu;
        private TextBox txbQuocGia;
        private TextBox txbTenPhim;
        private TextBox txbMaDon;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox TacVu;
        private Button btnThongKe;
        private Button btnSapXep;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnThem;
        private GroupBox DSPhim;
        private ListView lwCinema;
        private RadioButton rdbAction;
        private RadioButton rdbRomance;
        private GroupBox DinhDang;
        private RadioButton rdb3D;
        private RadioButton rdb2D;
        private GroupBox TheLoai;
    }
}