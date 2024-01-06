namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValue_Click(object sender, EventArgs e)
        {

         
            
        }

        private void tb_value_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(tb_value.Text, out num))
            {
                lbValue.Text = Math.Pow(num, 2).ToString();
            }
            else
            {
                lbValue.Text = " vui lòng nhập số ";
            }
        }
    }
}