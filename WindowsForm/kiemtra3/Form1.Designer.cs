namespace kiemtra3
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDG = new System.Windows.Forms.Label();
            this.lblKho = new System.Windows.Forms.Label();
            this.rdoHCM = new System.Windows.Forms.RadioButton();
            this.rdoDN = new System.Windows.Forms.RadioButton();
            this.rdoHN = new System.Windows.Forms.RadioButton();
            this.lblNN = new System.Windows.Forms.Label();
            this.dtNN = new System.Windows.Forms.DateTimePicker();
            this.gbCN = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colMaSP = new System.Windows.Forms.ColumnHeader();
            this.colTenSP = new System.Windows.Forms.ColumnHeader();
            this.colDM = new System.Windows.Forms.ColumnHeader();
            this.colSL = new System.Windows.Forms.ColumnHeader();
            this.colDG = new System.Windows.Forms.ColumnHeader();
            this.colKho = new System.Windows.Forms.ColumnHeader();
            this.colNN = new System.Windows.Forms.ColumnHeader();
            this.colTT = new System.Windows.Forms.ColumnHeader();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.gbCN.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(432, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(652, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ SẢN PHẨM NHẬP KHO";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaSP.Location = new System.Drawing.Point(84, 133);
            this.lblMaSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(82, 27);
            this.lblMaSP.TabIndex = 1;
            this.lblMaSP.Text = "Mã SP:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaSP.Location = new System.Drawing.Point(194, 120);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(669, 35);
            this.txtMaSP.TabIndex = 2;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenSP.Location = new System.Drawing.Point(194, 212);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(669, 35);
            this.txtTenSP.TabIndex = 4;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenSP.Location = new System.Drawing.Point(84, 225);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(87, 27);
            this.lblTenSP.TabIndex = 3;
            this.lblTenSP.Text = "Tên SP:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoLuong.Location = new System.Drawing.Point(194, 397);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(669, 35);
            this.txtSoLuong.TabIndex = 8;
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSL.Location = new System.Drawing.Point(84, 409);
            this.lblSL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(112, 27);
            this.lblSL.TabIndex = 7;
            this.lblSL.Text = "Số Lượng:";
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDanhMuc.Location = new System.Drawing.Point(84, 317);
            this.lblDanhMuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(120, 27);
            this.lblDanhMuc.TabIndex = 5;
            this.lblDanhMuc.Text = "Danh Mục:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDonGia.Location = new System.Drawing.Point(194, 489);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(669, 35);
            this.txtDonGia.TabIndex = 10;
            // 
            // lblDG
            // 
            this.lblDG.AutoSize = true;
            this.lblDG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDG.Location = new System.Drawing.Point(84, 502);
            this.lblDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDG.Name = "lblDG";
            this.lblDG.Size = new System.Drawing.Size(106, 27);
            this.lblDG.TabIndex = 9;
            this.lblDG.Text = "Đơn Giá: ";
            // 
            // lblKho
            // 
            this.lblKho.AutoSize = true;
            this.lblKho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKho.Location = new System.Drawing.Point(84, 580);
            this.lblKho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKho.Name = "lblKho";
            this.lblKho.Size = new System.Drawing.Size(59, 27);
            this.lblKho.TabIndex = 11;
            this.lblKho.Text = "Kho:";
            // 
            // rdoHCM
            // 
            this.rdoHCM.AutoSize = true;
            this.rdoHCM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoHCM.Location = new System.Drawing.Point(254, 578);
            this.rdoHCM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoHCM.Name = "rdoHCM";
            this.rdoHCM.Size = new System.Drawing.Size(123, 31);
            this.rdoHCM.TabIndex = 12;
            this.rdoHCM.TabStop = true;
            this.rdoHCM.Text = "Tp.HCM";
            this.rdoHCM.UseVisualStyleBackColor = true;
            // 
            // rdoDN
            // 
            this.rdoDN.AutoSize = true;
            this.rdoDN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoDN.Location = new System.Drawing.Point(429, 580);
            this.rdoDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoDN.Name = "rdoDN";
            this.rdoDN.Size = new System.Drawing.Size(128, 31);
            this.rdoDN.TabIndex = 13;
            this.rdoDN.TabStop = true;
            this.rdoDN.Text = "Đà Nắng ";
            this.rdoDN.UseVisualStyleBackColor = true;
            // 
            // rdoHN
            // 
            this.rdoHN.AutoSize = true;
            this.rdoHN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoHN.Location = new System.Drawing.Point(608, 580);
            this.rdoHN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoHN.Name = "rdoHN";
            this.rdoHN.Size = new System.Drawing.Size(112, 31);
            this.rdoHN.TabIndex = 14;
            this.rdoHN.TabStop = true;
            this.rdoHN.Text = "Hà Nội ";
            this.rdoHN.UseVisualStyleBackColor = true;
            // 
            // lblNN
            // 
            this.lblNN.AutoSize = true;
            this.lblNN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNN.Location = new System.Drawing.Point(84, 666);
            this.lblNN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNN.Name = "lblNN";
            this.lblNN.Size = new System.Drawing.Size(133, 27);
            this.lblNN.TabIndex = 15;
            this.lblNN.Text = "Ngày Nhập: ";
            // 
            // dtNN
            // 
            this.dtNN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtNN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNN.Location = new System.Drawing.Point(254, 653);
            this.dtNN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtNN.Name = "dtNN";
            this.dtNN.Size = new System.Drawing.Size(608, 35);
            this.dtNN.TabIndex = 16;
            // 
            // gbCN
            // 
            this.gbCN.Controls.Add(this.btnThoat);
            this.gbCN.Controls.Add(this.btnSua);
            this.gbCN.Controls.Add(this.btnXoa);
            this.gbCN.Controls.Add(this.btnLuu);
            this.gbCN.Controls.Add(this.btnThem);
            this.gbCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbCN.Location = new System.Drawing.Point(908, 116);
            this.gbCN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCN.Name = "gbCN";
            this.gbCN.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCN.Size = new System.Drawing.Size(521, 583);
            this.gbCN.TabIndex = 17;
            this.gbCN.TabStop = false;
            this.gbCN.Text = "Chức Năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(48, 498);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(428, 75);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(48, 377);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(428, 75);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(48, 266);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(428, 75);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(48, 161);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(428, 75);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(48, 50);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(428, 75);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSP,
            this.colTenSP,
            this.colDM,
            this.colSL,
            this.colDG,
            this.colKho,
            this.colNN,
            this.colTT});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(88, 730);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1353, 281);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colMaSP
            // 
            this.colMaSP.Text = "Ma SP";
            this.colMaSP.Width = 100;
            // 
            // colTenSP
            // 
            this.colTenSP.Text = "Ten SP";
            this.colTenSP.Width = 150;
            // 
            // colDM
            // 
            this.colDM.Text = "Danh Muc";
            this.colDM.Width = 150;
            // 
            // colSL
            // 
            this.colSL.Text = "So Luong";
            this.colSL.Width = 150;
            // 
            // colDG
            // 
            this.colDG.Text = "Don Gia";
            this.colDG.Width = 160;
            // 
            // colKho
            // 
            this.colKho.Text = "Kho";
            this.colKho.Width = 150;
            // 
            // colNN
            // 
            this.colNN.Text = "Ngay Nhap";
            this.colNN.Width = 200;
            // 
            // colTT
            // 
            this.colTT.Text = "Thanh Tien";
            this.colTT.Width = 200;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Items.AddRange(new object[] {
            "Điện Thoại",
            "Laptop",
            "Loa Blutooth"});
            this.cbDanhMuc.Location = new System.Drawing.Point(205, 314);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(657, 33);
            this.cbDanhMuc.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 1027);
            this.Controls.Add(this.cbDanhMuc);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gbCN);
            this.Controls.Add(this.dtNN);
            this.Controls.Add(this.lblNN);
            this.Controls.Add(this.rdoHN);
            this.Controls.Add(this.rdoDN);
            this.Controls.Add(this.rdoHCM);
            this.Controls.Add(this.lblKho);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lblDG);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.lblDanhMuc);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDG;
        private System.Windows.Forms.Label lblKho;
        private System.Windows.Forms.RadioButton rdoHCM;
        private System.Windows.Forms.RadioButton rdoDN;
        private System.Windows.Forms.RadioButton rdoHN;
        private System.Windows.Forms.Label lblNN;
        private System.Windows.Forms.DateTimePicker dtNN;
        private System.Windows.Forms.GroupBox gbCN;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colMaSP;
        private System.Windows.Forms.ColumnHeader colTenSP;
        private System.Windows.Forms.ColumnHeader colDM;
        private System.Windows.Forms.ColumnHeader colSL;
        private System.Windows.Forms.ColumnHeader colDG;
        private System.Windows.Forms.ColumnHeader colKho;
        private System.Windows.Forms.ColumnHeader colNN;
        private System.Windows.Forms.ColumnHeader colTT;
        private ComboBox cbDanhMuc;
    }
}