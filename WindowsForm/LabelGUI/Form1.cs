namespace LabelGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //label1.Text = "FREE FIRE";
            //label1.ForeColor = Color.Red;

            loadLabel();
        }

        void loadLabel()
        {

            Label lb = new Label();
            this.Controls.Add(lb);
            for (int i = 0; i < 10; i++)
            {
  

                lb.Text = "Tranthao.com  "+i;
                lb.Height = 123;
                lb.Width = 233;
           

            }
        
           
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //    Form2 f = new Form2();
        //    f.Show();
        //    f.label2.Text = "Share to be better";
        //}   
    }
}