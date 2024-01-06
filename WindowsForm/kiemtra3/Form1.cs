namespace kiemtra3
{
    public partial class Form1 : Form
    {
        List<string> listItem;

        public Form1()
        {
            InitializeComponent();
     
        }

       
        int count = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            count++;
            string kho = rdoHCM.Checked == true ? "Tp.HCM" : rdoDN.Checked == true ? "Đà Nẵng" : rdoHN.Checked==true? "Hà Nội":"NULL";
            string thanhTienStr="";
      

            double.TryParse(txtDonGia.Text, out double dongia);
            double.TryParse(txtSoLuong.Text, out double thanhtien);
                    double thanhTien = dongia*thanhtien;
                    thanhTienStr = thanhTien.ToString();

            ListViewItem MaDon = new ListViewItem();
            // them hàng
            MaDon.Text = txtMaSP.Text;
            MaDon.ForeColor = System.Drawing.Color.BlueViolet;

            MaDon.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtTenSP.Text });
            MaDon.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cbDanhMuc.Text });
            MaDon.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtSoLuong.Text });
            MaDon.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtDonGia.Text });
            MaDon.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = kho });

            MaDon.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dtNN.Text });
            MaDon.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = thanhTienStr});
            listView1.Items.Add(MaDon);

            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cbDanhMuc.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            rdoHCM.Text = "Tp.Hồ Chí Minh";
            dtNN.Value = DateTime.Now;

            txtMaSP.Focus();
        }

        public class Food
        {
            public string Name { get; set; }
            public float Price { get; set; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbDanhMuc.SelectedItem = "Điện Thoại";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
              

                foreach (ListViewItem item in listView1.Items)
                {

                    if (item.Selected)
                    {
                        txtMaSP.Text = listView1.SelectedItems[0].SubItems[0].Text;
                        txtTenSP.Text = listView1.SelectedItems[0].SubItems[1].Text;
                        cbDanhMuc.Text=listView1.SelectedItems[0].SubItems[2].Text;
                        txtSoLuong.Text=listView1.SelectedItems[0].SubItems[3].Text;
                        txtDonGia.Text = listView1.SelectedItems[0].SubItems[4].Text;

                        string kho = (string)(listView1.SelectedItems[0].SubItems[5].Text);
                        rdoHCM.Checked = (kho == "Tp.HCM") ? true : false;
                        rdoDN.Checked = (kho == "Đà Nẵng") ? true : false;
                        rdoHN.Checked = (kho == "Hà Nội") ? true : false;
                        dtNN.Text = listView1.SelectedItems[0].SubItems[6].Text;


                    }

                }
                

            }
        }
    }
}