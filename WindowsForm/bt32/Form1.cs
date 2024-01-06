namespace bt32
  
{
    using System.Collections;
    using System.IO;
    using System.Text;

    public class DateComparer : IComparer
    {
        private int columnToSort;

        public DateComparer(int columnToSort)
        {
            this.columnToSort = columnToSort;
        }

        public int Compare(object x, object y)
        {
            ListViewItem item1 = x as ListViewItem;
            ListViewItem item2 = y as ListViewItem;

            DateTime date1 = DateTime.Parse(item1.SubItems[columnToSort].Text);
            DateTime date2 = DateTime.Parse(item2.SubItems[columnToSort].Text);

            // Sắp xếp theo thứ tự giảm dần (Descending Order)
            return date1.CompareTo(date2);
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadViewCinema();

        }

        public static void SortListViewByDate(ListView listView, int columnToSort)
        {
            // Kiểm tra xem cột cần sắp xếp có tồn tại trong ListView không
            if (columnToSort < 0 || columnToSort >= listView.Columns.Count)
            {
                throw new ArgumentOutOfRangeException("columnToSort", "Chỉ mục cột không hợp lệ.");
            }

            // Sử dụng lớp so sánh tùy chỉnh để sắp xếp ListView
            listView.ListViewItemSorter = new DateComparer(columnToSort);
            listView.Sort();
        }
        void LoadViewCinema()
        {
            // them cot
            lwCinema.Columns.Add("Mã Đơn", 160);
            lwCinema.Columns.Add("Tên Phim", 160);
            lwCinema.Columns.Add("Thể Loại", 160);
            lwCinema.Columns.Add("Ngày Công Chiếu", 200);
            
        }

        

        void addListCinema()
        {

            string theloai = rdbRomance.Checked == true ? "Tình Cảm" : rdbAction.Checked == true ? "Hành Động" : "NULL";
            ListViewItem MaDon = new ListViewItem();
            // them hàng
            MaDon.Text = txbMaDon.Text;
            MaDon.ForeColor = System.Drawing.Color.BlueViolet;

            MaDon.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txbTenPhim.Text });
            MaDon.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = theloai });
            MaDon.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = NgayCongChieu.Text });
            lwCinema.Items.Add(MaDon);


        }
        void ResetValue(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                {

                    ((TextBox)control).Clear();
                }
                else if (control is CheckBox)
                {

                    ((CheckBox)control).Checked = false;
                }
                else if (control is RadioButton)
                {

                    ((RadioButton)control).Checked = false;

                }

            }
            count = 0;
        }
        int count = 0;
        int itemIndex = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            count++;
            itemIndex++;
            txbMaDon.TabIndex = 1;
            addListCinema();
            if (count != 0)
            {
                ResetValue(Thongtin);
                ResetValue(TheLoai);
                ResetValue(DinhDang);
            }
        }
  
        private void txbMaDon_TextChanged(object sender, EventArgs e)
        {
            TacVu.Enabled = true;
        }

        private void lwCinema_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            ListViewItem okla = sender as ListViewItem;
            
            foreach (ListViewItem item in lwCinema.Items)
            {
                string subItem1Value = "";
                string subItem2Value = "";
                string subItem3Value = "";
                //string subItem4Value = "";

                for (int i = 0; i < itemIndex; i++)
                {
                    subItem1Value = lwCinema.Items[i].SubItems[1].Text;
                    subItem2Value = lwCinema.Items[i].SubItems[2].Text;
                    subItem3Value = lwCinema.Items[i].SubItems[3].Text;
                }
                if (item.Selected)
                {
                    
                    txbMaDon.Text = item.Text;
                    txbTenPhim.Text = subItem1Value;


                }


            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //if (lwCinema.SelectedItems.Count > 0)
            //{
            //    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            //    if (result == DialogResult.Yes)
            //    {
            //        MessageBox.Show("Đã xóa thành công!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        itemIndex--; // giảm index
            //        lwCinema.SelectedItems[0].SubItems[0].Text = "";
            //        lwCinema.SelectedItems[0].SubItems[1].Text = "";
            //        lwCinema.SelectedItems[0].SubItems[2].Text = "";
            //        lwCinema.SelectedItems[0].SubItems[3].Text = "";

            //    }
            //    else if (result == DialogResult.No)
            //    {
            //        MessageBox.Show("Đã hủy!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Hãy chọn nhiều hơn 1 hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            if (lwCinema.SelectedItems.Count > 0)
            {
                // Xác định chỉ mục hàng cần xóa
                int selectedIndex = lwCinema.SelectedItems[0].Index;

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    if (selectedIndex < lwCinema.Items.Count - 1) // Kiểm tra xem có item kế tiếp hay không
                    {
                        // Thay thế item bị xóa bằng item kế tiếp
                        lwCinema.Items[selectedIndex].Text = lwCinema.Items[selectedIndex + 1].Text;
                        for (int i = 0; i < lwCinema.Items[selectedIndex + 1].SubItems.Count; i++)
                        {
                            lwCinema.Items[selectedIndex].SubItems[i].Text = lwCinema.Items[selectedIndex + 1].SubItems[i].Text;
                        }

                        // Sau đó xóa item kế tiếp (đã được sao chép)
                        lwCinema.Items.RemoveAt(selectedIndex + 1);
                    }
                    else
                    {
                        // Nếu không có item kế tiếp, chỉ xóa item hiện tại
                        lwCinema.Items.RemoveAt(selectedIndex);
                    }

                    MessageBox.Show("Đã xóa và thay thế thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Đã hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một hàng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
                // Đường dẫn tới tệp văn bản
                string filePath = "G:\\CODE\\C#\\trực quan\\WindowsForm\\bt32\\file.txt";

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                    // Lưu thông tin từ ListView
                    writer.WriteLine($"Mã Đơn\t\t Tên Phim\t \tThể Loại\t Ngày Công Chiếu");
                        foreach (ListViewItem item in lwCinema.Items)
                        {
                            string maDon = item.Text;
                            string tenPhim = item.SubItems[1].Text;
                            string theLoai = item.SubItems[2].Text;
                            string ngayCongChieu = item.SubItems[3].Text;

                            // Ghi thông tin mỗi mục vào tệp
                            writer.WriteLine($"{maDon}\t {tenPhim}\t\t {theLoai}\t\t{ngayCongChieu}");
                        }

                      
                        // Thêm các control khác tương tự ở đây

                        MessageBox.Show("Đã lưu thành công vào tệp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TacVu.Enabled = true;
            if (lwCinema.SelectedItems.Count > 0)
            {
                string theloai = rdbRomance.Checked == true ? "Tình Cảm" : rdbAction.Checked == true ? "Hành Động" : "NULL";

                lwCinema.SelectedItems[0].SubItems[0].Text = txbMaDon.Text;
                lwCinema.SelectedItems[0].SubItems[1].Text = txbTenPhim.Text;
                lwCinema.SelectedItems[0].SubItems[2].Text = theloai;
                lwCinema.SelectedItems[0].SubItems[3].Text = NgayCongChieu.Text;

                
                MessageBox.Show("Đã sửa thành công!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Hãy chọn nhiều hơn 1 hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

    

        private void lwCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwCinema.SelectedItems.Count > 0)
            {
                Thongtin.Enabled = false;
              
                    Thongtin.Enabled = true;
               

                    foreach (ListViewItem item in lwCinema.Items)
                    {

                        if (item.Selected)
                        {
                            txbMaDon.Text = lwCinema.SelectedItems[0].SubItems[0].Text;
                            txbTenPhim.Text = lwCinema.SelectedItems[0].SubItems[1].Text;
                            string theloai = (string)(lwCinema.SelectedItems[0].SubItems[2].Text);
                            rdbRomance.Checked = (theloai == "Tình Cảm") ? true : false;
                            rdbAction.Checked = (theloai == "Hành Động") ? true : false;
                            NgayCongChieu.Text = lwCinema.SelectedItems[0].SubItems[3].Text;

                        }

                    }
                    TacVu.Enabled = true;
              
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            int columnToSort = 3;

            // Gọi hàm để sắp xếp ListView theo cột ngày công chiếu
            SortListViewByDate(lwCinema, columnToSort);

            MessageBox.Show("Đã sắp xếp tăng dần theo ngày công chiếu!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> movieCountByGenre = new Dictionary<string, int>();

            // Đếm số lượng phim theo từng thể loại
            foreach (ListViewItem item in lwCinema.Items)
            {
                string theLoai = item.SubItems[2].Text;

                if (movieCountByGenre.ContainsKey(theLoai))
                {
                    movieCountByGenre[theLoai]++;
                }
                else
                {
                    movieCountByGenre[theLoai] = 1;
                }
            }

            // Hiển thị kết quả thống kê
            StringBuilder result = new StringBuilder();
            result.AppendLine("Thống kê số lượng phim theo thể loại:");

            foreach (var entry in movieCountByGenre)
            {
                result.AppendLine($"{entry.Key}: {entry.Value} phim");
            }

            MessageBox.Show(result.ToString(), "Thống kê", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}