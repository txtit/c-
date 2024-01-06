namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void showResult(Label label, Panel pnl)
        {
            RadioButton rdbtn = null;

            foreach(RadioButton item in pnl.Controls)
            {
                if(item !=null)
                if(item.Checked)
                {
                    rdbtn = item;
                    break;
                }    
            }    

            if(rdbtn != null)
            {
                label1.Text = rdbtn.Text;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            showResult(label1, panel1);
            showResult(label2, panel2);
            showResult(label3, panel3);
        }
    }
}