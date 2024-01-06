namespace WDF_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bạn đã click form "+i+ " lần");
            i++;
        }
    }
}