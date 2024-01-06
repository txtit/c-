namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show("tranthao.com");
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string name = txbValue.Text;
            string spider = ckbValue.CheckState == CheckState.Checked ? "là" : ckbValue.CheckState == CheckState.Unchecked ? "không phải" : "phải cũng khong phải là"; 
            string showString = string.Format("Chào bạn {0}, bạn {1} spiderman!", name,spider);

            MessageBox.Show(showString);
        }
    }
}