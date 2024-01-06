namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadListView();
        }

        ImageList imageListSmall;
        ImageList imageListLarge;

        void loadImageList()
        {
            imageListLarge = new ImageList() {ImageSize = new Size(90,80)};
            imageListLarge.Images.Add(new Bitmap(Application.StartupPath + "\\images\\1.jpg"));
            imageListLarge.Images.Add(new Bitmap(Application.StartupPath + "\\images\\2.jpg"));
            imageListLarge.Images.Add(new Bitmap(Application.StartupPath + "\\images\\3.jpg"));

            imageListSmall = new ImageList() { ImageSize = new Size(16, 16) };
            imageListSmall.Images.Add(new Bitmap(Application.StartupPath + "\\images\\1.jpg"));
            imageListSmall.Images.Add(new Bitmap(Application.StartupPath + "\\images\\2.JPG"));
            imageListSmall.Images.Add(new Bitmap(Application.StartupPath + "\\images\\3.JPG"));
        }

        void LoadListView() 
        {
             loadImageList();
            lwShow.FullRowSelect = true;
            lwShow.GridLines = true;
            lwShow.LargeImageList = imageListLarge;
            lwShow.SmallImageList = imageListSmall;

            lwShow.Columns.Add("column 1",100);
            lwShow.Columns.Add("column 2",100);
            lwShow.Columns.Add("column 3",100);
            lwShow.Columns.Add("column 4",100);

            ListViewItem item1 = new ListViewItem();
            item1.Text = "item1";
            item1.ImageIndex = 0;

            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 1" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 2" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 3" });

            ListViewItem item2 = new ListViewItem();
            item2.Text = "item2";
            item2.ImageIndex = 1;

            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 1" });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 2" });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 3" });

            ListViewItem item3 = new ListViewItem();
            item3.Text = "item3";
            item3.ImageIndex = 2;

            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "sub item 1" });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "sub item 2" });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 3" });

            lwShow.Items.Add(item1);
            lwShow.Items.Add(item2);
            lwShow.Items.Add(item3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lwShow.View = View.LargeIcon;
            lwShow.CheckBoxes = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lwShow.View = View.Details;
            lwShow.CheckBoxes = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lwShow.View = View.SmallIcon;
            lwShow.CheckBoxes = false;

        }

        private void lwShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            if (lsv.SelectedItems.Count > 0)
            {
                foreach(ListViewItem item in lsv.SelectedItems)
                {
                    
                    MessageBox.Show(item.Text);
                }
           
            }
        }
    }
}