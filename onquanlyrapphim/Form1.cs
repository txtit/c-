using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onquanlyrapphim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        QuanLyRapPhimEntities db = new QuanLyRapPhimEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            var phim = db.RAPPHIMs.ToList();
            foreach (var item in phim)

            {

                ListViewItem listViewItem = new ListViewItem(item.MADON);
                listViewItem.SubItems.Add(item.TENPHIM);

                listViewItem.SubItems.Add(item.THELOAI);
                listViewItem.SubItems.Add(item.NGAYCONGCHIEU?.ToString("dd/MM/yyyy"));

                lwPhim.Items.Add(listViewItem);
            }
            HighLightRecentMovies();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void DeleteAllData()
        {
            txtMaDon.Text = "";
            txtTenPhim.Text = "";
            txtQuocGia.Text = "";
            rdbTinhCam.Checked = true;
            dtpNgayCongChieu.Value = DateTime.Now;
            txtDotuoiquydinh.Text = "";
            rdb2d.Checked = true;
            txtPhuThu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            DeleteAllData();
            txtMaDon.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void rdb2d_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb2d.Checked == true && rdb3d.Checked == false)
            {
                lbLoaiGhe.Text = "Phụ thu ghế đôi";
            }
            else if (rdb2d.Checked == false && rdb3d.Checked == true)
            {
                lbLoaiGhe.Text = "Phụ thu suấ chiếu ĐB:";

            }
        }


        private void HighLightRecentMovies()
        {
            DateTime currentDate = DateTime.Now;

            foreach (ListViewItem item in lwPhim.Items)
            {
                string ngaycongchieustring = item.SubItems[3].Text;
                // Kiểm tra định dạng của chuỗi ngày công chiếu
                if (DateTime.TryParse(ngaycongchieustring, out DateTime ngayCongChieu))
                {
                    TimeSpan timeDifference = currentDate - ngayCongChieu;

                    if (timeDifference.TotalDays <= 7) // Nếu phim công chiếu trong vòng 7 ngày
                    {
                        item.BackColor = Color.Yellow; // Tô nền vàng cho dòng dữ liệu
                    }
                    else
                    {
                        item.BackColor = Color.White; // Đặt lại nền mặc định nếu không phải phim công chiếu trong vòng 7 ngày
                    }
                }
                else
                {
                    // Xử lý lỗi định dạng ngày không hợp lệ
                    MessageBox.Show($"Lỗi định dạng ngày không hợp lệ: {ngaycongchieustring}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDon.Text))
            {
                MessageBox.Show("Mã đơn không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (string.IsNullOrEmpty(txtTenPhim.Text))
            {
                MessageBox.Show("tên Phim không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (string.IsNullOrEmpty(txtQuocGia.Text))
            {
                MessageBox.Show("Quốc gia không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (string.IsNullOrEmpty(txtDotuoiquydinh.Text))
            {
                MessageBox.Show("Độ tuổi quy định không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (string.IsNullOrEmpty(txtPhuThu.Text))
            {
                MessageBox.Show("Phụ thu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            DateTime ngaycongchieu;
            if (!DateTime.TryParse(dtpNgayCongChieu.Text, out ngaycongchieu))
            {
                MessageBox.Show("Ngày vào làm không hợp lệ!", "Lỗi", MessageBoxButtons
                     .OK, MessageBoxIcon.Hand);
                return;
            }

            if (ngaycongchieu > DateTime.Now)
            {
                MessageBox.Show("Ngày vào làm không lớn hơn ngày hiện tại!", "Lỗi", MessageBoxButtons
                     .OK, MessageBoxIcon.Hand);
                return;
            }

            QuanLyRapPhimEntities db = new QuanLyRapPhimEntities();
            RAPPHIM phim = new RAPPHIM();

            phim.MADON = txtMaDon.Text;
            phim.TENPHIM = txtTenPhim.Text;
            phim.QUOCGIA = txtQuocGia.Text;
            phim.THELOAI = rdbTinhCam.Checked ? "Tình Cảm" : "Hành Động";
            phim.NGAYCONGCHIEU = dtpNgayCongChieu.Value;
            phim.DOTUOIQUYDINH = int.Parse(txtDotuoiquydinh.Text);
            if (rdb2d.Checked == true && rdb3d.Checked == false)
            {
                phim.PHUTHUGHE = decimal.Parse(txtPhuThu.Text);
            }
            else if (rdb2d.Checked == false && rdb3d.Checked == true)
            {
                phim.PHUTHUSUATDATBIET = decimal.Parse(txtPhuThu.Text);
            }


            db.RAPPHIMs.Add(phim);
            db.SaveChanges();


            ListViewItem listViewItem = new ListViewItem(txtMaDon.Text);
            listViewItem.SubItems.Add(txtTenPhim.Text);

            string theloai = rdbTinhCam.Checked ? "Tình Cảm" : "Hành động";
            listViewItem.SubItems.Add(theloai);
            listViewItem.SubItems.Add(dtpNgayCongChieu.Text);
            listViewItem.SubItems.Add(txtDotuoiquydinh.Text);

            lwPhim.Items.Add(listViewItem);
            int index = lwPhim.Items.Count - 1; // Index của dòng cuối cùng (dòng mới nhất)
            if (index >= 0)
            {
                lwPhim.Items[index].Selected = true;
                lwPhim.Select(); // Đảm bảo rằng ListView đang được chọn
            }
            HighLightRecentMovies();
            DeleteAllData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (lwPhim.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phim này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ListViewItem selectedRow = lwPhim.SelectedItems[0];
                    int indexToRemove = selectedRow.Index;

                    lwPhim.Items.Remove(selectedRow);
                    var phim = db.RAPPHIMs.FirstOrDefault(p => p.MADON == txtMaDon.Text);
                    db.RAPPHIMs.Remove(phim);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công");
                    DeleteAllData();
                    if (indexToRemove < lwPhim.Items.Count)
                    {
                        lwPhim.Items[indexToRemove].Selected = true;
                        lwPhim.Select();
                    }
                    else if (indexToRemove > 0)
                    {
                        lwPhim.Items[indexToRemove - 1].Selected = true;
                        lwPhim.Select();
                    }
                    else
                    {
                        DeleteAllData();
                        txtMaDon.Focus();
                    }
                }
            }

        }

        private void lwPhim_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lwPhim.SelectedItems.Count > 0)
            {
                btnLuu.Enabled = false;
                txtMaDon.Enabled = false;
                ListViewItem selectedRow = lwPhim.SelectedItems[0];
                txtMaDon.Text = selectedRow.SubItems[0].Text;
                var phimselected = db.RAPPHIMs.FirstOrDefault(p => p.MADON == txtMaDon.Text);

                txtTenPhim.Text = selectedRow.SubItems[1].Text;
                string theloai = selectedRow.SubItems[2].Text;
                if (theloai == "Tình Cảm")
                {
                    rdbTinhCam.Checked = true;
                }
                else
                {
                    rdbHanhDong.Checked = true;
                }
                txtQuocGia.Text = phimselected.QUOCGIA;
                dtpNgayCongChieu.Value = DateTime.Parse(phimselected.NGAYCONGCHIEU.ToString());
                txtDotuoiquydinh.Text = phimselected.DOTUOIQUYDINH.ToString();
                if (phimselected.PHUTHUGHE != null)
                {
                    rdb2d.Checked = true;
                    txtPhuThu.Text = phimselected.PHUTHUGHE?.ToString("N0");
                }
                else
                {
                    rdb3d.Checked = true;
                    txtPhuThu.Text = phimselected.PHUTHUSUATDATBIET?.ToString("N0");

                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if (lwPhim.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lwPhim.SelectedItems[0];
                selectedRow.SubItems[0].Text = txtMaDon.Text;
                selectedRow.SubItems[1].Text = txtTenPhim.Text;
                if (rdbTinhCam.Checked == true)
                {
                    selectedRow.SubItems[2].Text = "Tình Cảm";

                }
                else
                {
                    selectedRow.SubItems[2].Text = "Hành Động";

                }
                selectedRow.SubItems[3].Text = dtpNgayCongChieu.Text;
               
                var update = db.RAPPHIMs.FirstOrDefault(p => p.MADON == txtMaDon.Text);
                update.MADON = txtMaDon.Text;
                update.TENPHIM = txtTenPhim.Text;
                update.QUOCGIA = txtQuocGia.Text;
                update.THELOAI = selectedRow.SubItems[2].Text;
                update.NGAYCONGCHIEU = dtpNgayCongChieu.Value;
                update.DOTUOIQUYDINH = int.Parse(txtDotuoiquydinh.Text);
                if (rdb2d.Checked == true)
                {
                    update.PHUTHUGHE = decimal.Parse(txtPhuThu.Text);
                }
                else
                {
                    update.PHUTHUSUATDATBIET = decimal.Parse(txtPhuThu.Text);

                }
                HighLightRecentMovies();
                selectedRow.Selected = true;
                lwPhim.Select();
                db.SaveChanges();
                MessageBox.Show("Đã chỉnh sửa thành công");
              

            }
        }
       
        private void ResetListView(IEnumerable<RAPPHIM> tc)
        {
            lwPhim.Items.Clear();
            foreach (var a in tc)
            {
                ListViewItem listViewItem = new ListViewItem(a.MADON);
                listViewItem.SubItems.Add(a.TENPHIM.ToString());
                listViewItem.SubItems.Add(a.THELOAI.ToString());
                listViewItem.SubItems.Add(a.NGAYCONGCHIEU.Value.ToString("dd/MM/yyyy"));
               


                lwPhim.Items.Add(listViewItem);
            }
        }
        private void btnSapXep_Click(object sender, EventArgs e)
        {
            try
            {
                var sort = db.RAPPHIMs.OrderByDescending(p => p.NGAYCONGCHIEU).ThenBy(p => p.DOTUOIQUYDINH).ToList();
                ResetListView(sort);
                MessageBox.Show("Đã sắp xếp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int tongSoLuong2D = 0;
            int tongSoLuong3D = 0;
            double tongDoanhThu2D = 0;
            double tongDoanhThu3D = 0;

            //foreach (ListViewItem item in lwPhim.Items)
            //{
                int soLuong = 1; // Giả sử mỗi dòng đại diện cho một suất chiếu
                double phuThuGheDoi = 0;
                double phuThuSuatChieuDacBiet = 0;
                var phim = db.RAPPHIMs.ToList();



            foreach (var i in phim)
            {
                if (i.PHUTHUGHE != null)
                {
                    tongSoLuong2D += soLuong;
                    tongDoanhThu2D += double.Parse(i.PHUTHUGHE?.ToString("N0"));
                }
                else
                {

                    tongSoLuong3D += soLuong;
                    tongDoanhThu3D += double.Parse(i.PHUTHUSUATDATBIET?.ToString("N0"));
                }
            }


            //}

            // Hiển thị thông báo
            string thongBao = $"Thống kê:\n\nTổng số lượng phim 2D: {tongSoLuong2D}\nTổng doanh thu 2D: {tongDoanhThu2D:C}\n\nTổng số lượng phim 3D: {tongSoLuong3D}\nTổng doanh thu 3D: {tongDoanhThu3D:C}";

            MessageBox.Show(thongBao, "Thống kê", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
