using BTTH24_11.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTTH21_11
{
    public partial class Form1 : Form
    {
        BTTH2_LTTQEntities8 db = new BTTH2_LTTQEntities8();
        public Form1()
        {
            InitializeComponent();
        }

        private void reset()
        {
            txttentc.Text = "";
            txtkhac.Text = "";
            txtmadon.Text = "";
            txtcannang.Text = "";
            txttinhtrang.Text = "";
            txtchungloai.Text = "";
            dtpngaynhan.Value = DateTime.Now.Date;
            radchuabenh.Checked = true;
            radchamsocho.Checked= false;
            txtmadon.Focus();
        }
        private void xem()
        {
            //var dataList1 = from nvbanhang in db.nvbanhangs select nvbanhang;

            //where
            //var dataList1 = from nvbanhang in db.nvbanhangs where nvbanhang.gioitinh==true select nvbanhang; 
            //var dataList1 = from nvbanhang in db.nvbanhangs where nvbanhang.gioitinh==true where nvbanhang.manhanvien=="aa" select nvbanhang;
            //var dataList1 = from nvbanhang in db.nvbanhangs where(nvbanhang.gioitinh == true && nvbanhang.manhanvien == "aa") select nvbanhang;

            //lấy theo cột
            //var dataList1 = from nvbanhang in db.nvbanhangs select nvbanhang.manhanvien;

            //from kết hợp
            //var ketqua = from product in products
            //from color in product.Colors
            //where product.Price < 500
            //where color == "Vàng"
            //select product;

            //order by
            //var ketqua = from product in products
            //             where product.Price <= 300
            //             orderby product.Price descending     //ascending
            //             select product;
            //Cũng có thể sắp xếp theo nhiều dữ liệu, viết cách nhau bởi, orderby thuoctinh1 descending, thuoctinh2, thuoctinh3 descending...

            //group by -- xuanthaolab.net

            //join
            //var ketqua = from product in products
            //             join brand in brands on product.Brand equals brand.ID
            //             select new
            //             {
            //                 name = product.Name,
            //                 brand = brand.Name,
            //                 price = product.Price
            //             };


            //------------nguồn học xuanthaolab.net --------------------
            lvnv.Items.Clear();
            List<thucung> dataList = db.thucungs.Select(g => g).ToList();
            foreach (var nvbh in dataList)
            {
                ListViewItem listViewItem = new ListViewItem(nvbh.madon);
                listViewItem.SubItems.Add(nvbh.tenthucung);
                listViewItem.SubItems.Add(nvbh.chungloai);
                listViewItem.SubItems.Add(nvbh.ngaynhan.ToString());
                lvnv.Items.Add(listViewItem);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Xác nhận thoát!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xem();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmadon.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống", "Error!");
                return;
            }
            if (txttentc.Text == "")
            {
                MessageBox.Show("Họ tên không được để trống", "Error!");
                return;
            }
            if (txtchungloai.Text == "")
            {
                MessageBox.Show("Chủng loại không được để trống", "Error!");
                return;
            }
            if (txtcannang.Text == "")
            {
                MessageBox.Show("Cân nặng không được để trống", "Error!");
                return;
            }
            if (!Regex.IsMatch(txtcannang.Text, @"^[1-9]\d*$"))
            {
                MessageBox.Show("Cân nặng không đúng", "Error!");
                return;
            }
            if (dtpngaynhan.Value>DateTime.Now)
            {
                MessageBox.Show("Ngày nhận không đúng", "Error!");
                return;
            }
            if (txttinhtrang.Text == "")
            {
                MessageBox.Show("Tình trạng không được để trống", "Error!");
                return;
            }
            if (txtkhac.Text == "" || !Regex.IsMatch(txtkhac.Text, @"^\d+(\.\d+)?$"))
            {
                MessageBox.Show("Mục cuối không được để trống hoặc sai", "Error!");
                return;
            }
            if (radchuabenh.Checked == true)
            {
                thucung nv = db.thucungs.FirstOrDefault(p => p.madon == txtmadon.Text);
                if (nv == null)
                {
                    thucung p = new thucung();
                    p.madon = txtmadon.Text;
                    p.tenthucung = txttentc.Text;
                    p.chungloai = txtchungloai.Text;
                    p.cannang = int.Parse(txtcannang.Text);
                    p.ngaynhan = dtpngaynhan.Value.Date;
                    p.tinhtrang = txttinhtrang.Text;
                    p.chiphithuocdieutri = double.Parse(txtkhac.Text);
                    db.thucungs.Add(p);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Mã đơn không được trùng", "Error!");
                    return;
                }
            }
            else
            {
                thucung nv = db.thucungs.FirstOrDefault(p => p.madon == txtmadon.Text);
                if (nv == null)
                {
                    thucung p = new thucung();
                    p.madon = txtmadon.Text;
                    p.tenthucung = txttentc.Text;
                    p.chungloai = txtchungloai.Text;
                    p.cannang = int.Parse(txtcannang.Text);
                    p.ngaynhan = dtpngaynhan.Value.Date;
                    p.tinhtrang = txttinhtrang.Text;
                    p.songay = int.Parse(txtkhac.Text);
                    db.thucungs.Add(p);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Mã đơn không được trùng", "Error!");
                    return;
                }
            }
            xem();
        }

        private void lvnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Giả sử listView là tên của ListView bạn đang sử dụng
            if (lvnv.SelectedItems.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                ListViewItem selectedRow = lvnv.SelectedItems[0];

                // Thực hiện các thao tác khác với dữ liệu từ dòng được chọn
                string ma = selectedRow.SubItems[0].Text;
                thucung nv = db.thucungs.FirstOrDefault(p => p.madon == ma);
                txtmadon.Text = nv.madon;
                txttentc.Text = nv.tenthucung;
                txtchungloai.Text = nv.chungloai;
                txtcannang.Text = nv.cannang.ToString();
                dtpngaynhan.Text = nv.ngaynhan.ToString();
                txttinhtrang.Text = nv.tinhtrang;
                if (nv.chiphithuocdieutri != null)
                {
                    radchuabenh.Checked = true;
                    radchamsocho.Checked = false;
                    txtkhac.Text = nv.chiphithuocdieutri.ToString();
                }
                else
                {
                    radchamsocho.Checked = true;
                    radchuabenh.Checked = false;
                    txtkhac.Text = nv.songay.ToString();
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            // Giả sử listView là tên của ListView bạn đang sử dụng
            if (lvnv.SelectedItems.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                ListViewItem selectedRow = lvnv.SelectedItems[0];
                // Thực hiện các thao tác khác với dữ liệu từ dòng được chọn
                string ma = selectedRow.SubItems[0].Text;
                thucung nv = db.thucungs.FirstOrDefault(p => p.madon == ma);
                if (nv != null)
                {
                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Người dùng đã xác nhận xóa, thực hiện xóa dữ liệu ở đây
                        // Xóa đối tượng
                        db.thucungs.Remove(nv);
                        // Lưu thay đổi vào cơ sở dữ liệu
                        db.SaveChanges();
                    }
                    else return;
                }
                reset();
                xem();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Giả sử listView là tên của ListView bạn đang sử dụng
            if (lvnv.SelectedItems.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                ListViewItem selectedRow = lvnv.SelectedItems[0];

                // Thực hiện các thao tác khác với dữ liệu từ dòng được chọn
                string ma = selectedRow.SubItems[0].Text;
                thucung p = db.thucungs.FirstOrDefault(h => h.madon == ma);

                if (p != null)
                {
                    if (txtmadon.Text == "")
                    {
                        MessageBox.Show("Mã nhân viên không được để trống", "Error!");
                        return;
                    }
                    if (txtmadon.Text != p.madon)
                    {
                        MessageBox.Show("Mã đơn không được sửa", "Error!");
                        reset();
                        return;
                    }
                    if (txttentc.Text == "")
                    {
                        MessageBox.Show("Họ tên không được để trống", "Error!");
                        return;
                    }
                    if (txtchungloai.Text == "")
                    {
                        MessageBox.Show("Chủng loại không được để trống", "Error!");
                        return;
                    }
                    if (txtcannang.Text == "")
                    {
                        MessageBox.Show("Cân nặng không được để trống", "Error!");
                        return;
                    }
                    if (!Regex.IsMatch(txtcannang.Text, @"^[1-9]\d*$"))
                    {
                        MessageBox.Show("Cân nặng không đúng", "Error!");
                        return;
                    }
                    if (dtpngaynhan.Value > DateTime.Now)
                    {
                        MessageBox.Show("Ngày nhận không đúng", "Error!");
                        return;
                    }
                    if (txttinhtrang.Text == "")
                    {
                        MessageBox.Show("Tình trạng không được để trống", "Error!");
                        return;
                    }
                    if (txtkhac.Text == "" || !Regex.IsMatch(txtkhac.Text, @"^\d+(\.\d+)?$"))
                    {
                        MessageBox.Show("Mục cuối không được để trống hoặc sai", "Error!");
                        return;
                    }
                    if (radchuabenh.Checked == true)
                    {
                        p.madon = txtmadon.Text;
                        p.tenthucung = txttentc.Text;
                        p.chungloai = txtchungloai.Text;
                        p.cannang = int.Parse(txtcannang.Text);
                        p.ngaynhan = dtpngaynhan.Value.Date;
                        p.tinhtrang = txttinhtrang.Text;
                        p.chiphithuocdieutri = double.Parse(txtkhac.Text);
                    }
                    else
                    {
                        p.madon = txtmadon.Text;
                        p.tenthucung = txttentc.Text;
                        p.chungloai = txtchungloai.Text;
                        p.cannang = int.Parse(txtcannang.Text);
                        p.ngaynhan = dtpngaynhan.Value.Date;
                        p.tinhtrang = txttinhtrang.Text;
                        p.songay = int.Parse(txtkhac.Text);
                    }
                    // Lưu thay đổi vào cơ sở dữ liệu
                    db.SaveChanges();
                }
                xem();
            }
        }

        private void btnsapxep_Click(object sender, EventArgs e)
        {
            if (lvnv.Items.Count > 0)
            {
                lvnv.Items.Clear();
                int dem = -1;
                string kt = "";
                List<thucung> dataList = db.thucungs.OrderByDescending(g => g.ngaynhan).ToList();
                //List<nvgiaonhan> dataList1 = db.nvgiaonhans.Select(g => g).ToList();
                foreach (var nvbh in dataList)
                {
                    ListViewItem listViewItem = new ListViewItem(nvbh.madon);
                    listViewItem.SubItems.Add(nvbh.tenthucung);
                    listViewItem.SubItems.Add(nvbh.chungloai);
                    listViewItem.SubItems.Add(nvbh.ngaynhan.ToString());
                    lvnv.Items.Add(listViewItem);
                    if (kt != nvbh.ngaynhan.ToString())
                    {
                        dem++;
                    }
                    kt = nvbh.ngaynhan.ToString();
                }
                if(dem == 0)
                {
                    lvnv.Items.Clear();
                    List<thucung> dataList1 = db.thucungs.OrderBy(g => g.cannang).ToList();
                    foreach (var nvbh in dataList)
                    {
                        ListViewItem listViewItem = new ListViewItem(nvbh.madon);
                        listViewItem.SubItems.Add(nvbh.tenthucung);
                        listViewItem.SubItems.Add(nvbh.chungloai);
                        listViewItem.SubItems.Add(nvbh.ngaynhan.ToString());
                        lvnv.Items.Add(listViewItem);
                        MessageBox.Show(nvbh.cannang.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu", "Error!");
                return;
            }
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            var sldon = db.thucungs.Count();
            var data = db.thucungs.ToList();
            float chuabenh = 0;
            float chamsocho = 0;
            foreach (var nv in data)
            {
                if (nv.chiphithuocdieutri != null)
                {
                    chuabenh = chuabenh + float.Parse(nv.chiphithuocdieutri.ToString()) + 100000;
                }
                else
                {
                    chamsocho = int.Parse(nv.songay.ToString()) * 200000;
                }
            }
            var toasoan = db.nvs.Count(g => g.sogiolamthem != null);
            MessageBox.Show($"Có {sldon} đơn \nTổng doanh thu: {chuabenh+chamsocho} đồng \nTổng doanh thu theo dịch vụ chữa bệnh: {chuabenh} đồng \nTổng doanh thu theo dịch vụ chăm sóc hộ: {chamsocho}","Thống kê!");
        }

        private void radchuabenh_CheckedChanged(object sender, EventArgs e)
        {
            if (radchuabenh.Checked == true)
            {
                lakhac.Text = "Chi phí thuốc:";
            }
            else lakhac.Text = "Số ngày:";
        }

        private void radchamsocho_CheckedChanged(object sender, EventArgs e)
        {
            if (radchamsocho.Checked == true)
            {
                lakhac.Text = "Số ngày:";
            }
            else lakhac.Text = "Chi phí thuốc:";
        }
    }
}
