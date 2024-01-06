namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("nội dung","caption", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
           switch (result)
            {
                case DialogResult.Abort:
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Đóng message box");
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.None:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("Cái mới của yes");
                    break;
                default:
                    break;
            }
        }
    }
}